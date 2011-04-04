using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Collections;
using System.Windows.Forms;

namespace OmegleSpy
{
    class OmegleBot
    {
        public string ID = "";
        public bool PollEvents;
        public System.Drawing.Color chatColor;
        private Thread t;
        private frmSpy f;
        private delegate void HandleEventsDelegate(Hashtable events);
        private HandleEventsDelegate delHandleEvents;
        private OmegleBot otherBot;
        private PictureBox pbCaptcha;
        private TextBox txtCaptcha;
        private string challengeKey = "";
        private Label lblCaptchaId;
        private ToolStripStatusLabel lblBotStatus;

        public OmegleBot(frmSpy ff, System.Drawing.Color chatCol, OmegleBot OtherTwin, PictureBox recaptcha, TextBox textCaptcha, Label _lblCaptchaId, ToolStripStatusLabel _lblBotStatus)
        {
            f = ff;
            chatColor = chatCol;
            otherBot = OtherTwin;
            pbCaptcha = recaptcha;
            txtCaptcha = textCaptcha;
            lblCaptchaId = _lblCaptchaId;
            lblBotStatus = _lblBotStatus;
            delHandleEvents = new HandleEventsDelegate(HandleEvents); 
        }

        public string StartNewSession()
        {
            try
            {
                PollEvents = true;
                ID = Request("{OMEGLEURL}/start?rcs=1", "").Substring(1, 6);
                f.txtDebug.Text += "Bot was assigned id " + ID + Environment.NewLine; f.txtDebug.SelectionStart = f.txtDebug.TextLength; f.txtDebug.ScrollToCaret();
                lblBotStatus.Text = ID + " is idle.";
                StartPollingAgain();

                return ID;
            }
            catch
            {
                return String.Empty;
            }
        }

        public void Disconnect()
        {
            try
            {
                PollEvents = false;
                Request("{OMEGLEURL}/disconnect", "id=" + ID);
                f.Convo("Bot ", System.Drawing.Color.DarkGray, System.Drawing.FontStyle.Bold, false);
                f.Convo(ID, System.Drawing.Color.Black, System.Drawing.FontStyle.Bold, false);
                f.Convo(" has disconnected.", System.Drawing.Color.DarkGray, System.Drawing.FontStyle.Bold, true);
                f.cboTalkAs.Items.Remove(this.ID);
                lblBotStatus.Text = ID + " is idle.";
            }
            catch { }
        }

        public void StartPollingAgain()
        {
            t = new Thread(EventWatcherThread);
            t.Start();
        }

        public bool Say(string what)
        {
            if (what == "/disconnect")
            {
                this.Disconnect();
                return false;
            }
            else
            {
                Thread th = new Thread(SayThread);
                th.Start(what);
                return true;
            }
        }

        private void SayThread(object what)
        {
            Request("{OMEGLEURL}/send", "id=" + ID + "&msg=" + (string)what);
        }

        public void TryCaptchaResponse(string response, string challenge)
        {
            string answer = Request("{OMEGLEURL}/recaptcha", "id=" + ID + "&challenge=" + challenge + "&response=" + response);
            if (answer == "win")
            {
                f.panelRecaptcha.Visible = false;
                pbCaptcha.Enabled = false;
                txtCaptcha.Enabled = false;
                PollEvents = true;
                this.StartPollingAgain();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("You have incorrectly answered the reCAPTCHA for Bot " + ID + ". Try again.");
            }
        }

        public void newReCaptcha()
        {
            f.panelRecaptcha.Visible = true;
            pbCaptcha.Enabled = true;
            txtCaptcha.Enabled = true;
            lblCaptchaId.Text = ID;
            string[] captchaResponseFromAPI = Request("http://www.google.com/recaptcha/api/challenge?k=" + challengeKey, "", "GET").Split(',');
            string challenge = captchaResponseFromAPI[1].Substring(18, 164);
            f.txtDebug.Text += ID + " > Got challenge: " + challenge + Environment.NewLine; f.txtDebug.SelectionStart = f.txtDebug.TextLength; f.txtDebug.ScrollToCaret();
            pbCaptcha.Load("http://www.google.com/recaptcha/api/image?c=" + challenge);
            pbCaptcha.Tag = challenge;
        }

        private void EventWatcherThread()
        {
            while (true)
            {
                if (PollEvents)
                    GetEvents();
                else
                    break;
                Thread.Sleep(1000);
            }
        }

        private void GetEvents()
        {
            string event_json = Request("{OMEGLEURL}/events", "id=" + ID);

            if (event_json != "null")
            {
                Hashtable events = ParseJSON(event_json);
                f.Invoke(delHandleEvents, new Object[] { events });
            }
        }

        private void HandleEvents(Hashtable events)
        {
            IDictionaryEnumerator en = events.GetEnumerator();
            while (en.MoveNext())
            {
                f.txtDebug.Text += ID + " > " + "[\"" + en.Key.ToString() + "\", \"" + en.Value.ToString() + "\"]" + Environment.NewLine;
                f.txtDebug.SelectionStart = f.txtDebug.TextLength;
                f.txtDebug.ScrollToCaret();
                switch (en.Key.ToString())
                {
                    case "typing":
                        if (otherBot != null && otherBot.PollEvents)
                            otherBot.Request("{OMEGLEURL}/typing", "id=" + otherBot.ID);
                        lblBotStatus.Text = ID + " is typing..";
                        break;

                    case "stoppedTyping":
                        if (otherBot != null && otherBot.PollEvents)
                            otherBot.Request("{OMEGLEURL}/stoppedtyping", "id=" + otherBot.ID);
                        lblBotStatus.Text = ID + " is connected.";
                        break;

                    case "waiting":
                        break;

                    case "connected":
                        f.Convo("Found a stranger.", System.Drawing.Color.Gray, System.Drawing.FontStyle.Bold, true);
                        lblBotStatus.Text = ID + " is connected.";
                        break;

                    case "gotMessage":
                        f.Convo(ID, chatColor, System.Drawing.FontStyle.Bold, false);
                        f.Convo(": ", System.Drawing.Color.Black, System.Drawing.FontStyle.Bold, false);
                        f.Convo(en.Value.ToString(), System.Drawing.Color.Black, System.Drawing.FontStyle.Regular, true);
                        if(otherBot != null && otherBot.PollEvents)
                            otherBot.Say(en.Value.ToString());
                        lblBotStatus.Text = ID + " is connected.";
                        break;

                    case "strangerDisconnected":
                        PollEvents = false;
                        f.Convo("Bot ", System.Drawing.Color.DarkGray, System.Drawing.FontStyle.Bold, false);
                        f.Convo(ID, System.Drawing.Color.Black, System.Drawing.FontStyle.Bold, false);
                        f.Convo(" has disconnected.", System.Drawing.Color.DarkGray, System.Drawing.FontStyle.Bold, true);
                        f.cboTalkAs.Items.Remove(this.ID);
                        lblBotStatus.Text = ID + " is idle.";
                        break;

                    case "recaptchaRequired":
                        PollEvents = false;
                        challengeKey = en.Value.ToString();
                        this.newReCaptcha();
                        break;

                    case "recaptchaRejected":
                        PollEvents = false;
                        f.panelRecaptcha.Visible = true;
                        pbCaptcha.Enabled = true;
                        txtCaptcha.Enabled = true;
                        txtCaptcha.Text = "";
                        txtCaptcha.Focus();
                        System.Windows.Forms.MessageBox.Show("You have incorrectly answered the reCAPTCHA for Bot " + ID + ". Try again.");
                        break;

                    default:
                        f.Convo("Server returned ", System.Drawing.Color.DarkGray, System.Drawing.FontStyle.Bold, false);
                        f.Convo("[\"" + en.Key.ToString() + "\", \"" + en.Value.ToString() + "\"]", System.Drawing.Color.Black, System.Drawing.FontStyle.Bold, true);
                        break;
                }
            }
        }

        private Hashtable ParseJSON(string json)
        {
            Hashtable result = new System.Collections.Hashtable();
            try
            {
                // [["connected"], ["gotMessage", "lol"]]
                json = json.Remove(0, 1);
                json = json.Remove(json.Length - 1, 1);
                string[] json_messages = json.Split(']');

                foreach (string message in json_messages)
                {
                    string m = message;

                    if (m == "")
                        break;

                    if (message.Substring(0, 2) == ", ")
                        m = message.Remove(0, 2);

                    m.Remove(0, 1); // Remove ["

                    string[] split = m.Split(',');
                    string key = "", value = "";

                    if (split.Length >= 1)
                    {
                        key = split[0];

                        // Strip off " surrounding key
                        key = key.Remove(0, 2);
                        key = key.Remove(key.Length - 1, 1);
                    }

                    if (split.Length == 2)
                    {
                        value = split[1].Remove(0, 1);

                        // Strip off " surrounding value
                        value = value.Remove(0, 1);
                        value = value.Remove(value.Length - 1, 1);
                    }

                    try
                    {
                        result.Add(key, value);
                    }
                    catch { }
                }
            }
            catch { }

            return result;
        }

        private string Request(string url, string parameters, string method = "POST")
        {
            try
            {
                url = url.Replace("{OMEGLEURL}", "http://bajor.omegle.com");

                WebRequest request;

                request = WebRequest.Create(url);
                request.Method = method;

                byte[] byteArray = Encoding.UTF8.GetBytes(parameters);

                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;

                Stream dataStream;
                if (method == "POST")
                {
                    dataStream = request.GetRequestStream();
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    dataStream.Close();
                }

                WebResponse response = request.GetResponse(); // code pauses here until response is received (aka, something happened)

                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();

                reader.Close();
                dataStream.Close();
                response.Close();

                return responseFromServer;
            }
            catch
            {
                return String.Empty;
            }
        }
    }
}
