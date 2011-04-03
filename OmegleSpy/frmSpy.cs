﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace OmegleSpy
{
    public partial class frmSpy : Form
    {
        private OmegleBot Bot1 = null;
        private OmegleBot Bot2 = null;

        public frmSpy()
        {
            InitializeComponent();
            Bot1 = new OmegleBot(this, Color.Red, Bot2, pbCaptcha, txtCaptchaResponse);
            Bot2 = new OmegleBot(this, Color.Blue, Bot1, pbCaptcha2, txtCaptchaResponse2);
        }

        public void Convo(string text, Color color, FontStyle fs, bool newLine)
        {
            txtConversation.SelectionStart = txtConversation.TextLength;
            txtConversation.SelectionFont = new Font("Tahoma", 11, fs);
            txtConversation.SelectionColor = color;
            if(newLine)
                txtConversation.SelectedText = text + Environment.NewLine;
            else
                txtConversation.SelectedText = text;
            txtConversation.SelectionStart = txtConversation.TextLength;
            txtConversation.ScrollToCaret();
        }

        private void btnSubmitCaptcha_Click(object sender, EventArgs e)
        {
            if (pbCaptcha.Enabled)
            {
                Bot1.TryCaptchaResponse(txtCaptchaResponse.Text, pbCaptcha.Tag.ToString());
            }
            if (pbCaptcha2.Enabled)
            {
                Bot2.TryCaptchaResponse(txtCaptchaResponse2.Text, pbCaptcha2.Tag.ToString());
            }
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cboTalkAs.Items.Clear();
            string bot1id = Bot1.StartNewSession();
            string bot2id = Bot2.StartNewSession();
            if (bot1id != String.Empty && bot2id != String.Empty)
            {
                cboTalkAs.Items.Add(bot1id);
                cboTalkAs.Items.Add(bot2id);
                Convo("Bots got session ids ", Color.DarkGray, FontStyle.Bold, false);
                Convo(bot1id, Color.Black, FontStyle.Bold, false);
                Convo(" and ", Color.DarkGray, FontStyle.Bold, false);
                Convo(bot2id, Color.Black, FontStyle.Bold, false);
                Convo("!", Color.DarkGray, FontStyle.Bold, true);
            }
            else
            {
                Convo("Could not get session ids.", Color.DarkGray, FontStyle.Bold, true);
            }
        }

        private void frmSpy_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Bot1 != null)
                Bot1.PollEvents = false;
            if (Bot2 != null)
                Bot2.PollEvents = false;
        }

        private void exotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bot1 != null)
                Bot1.PollEvents = false;
            if (Bot2 != null)
                Bot2.PollEvents = false;
            Application.Exit();
        }

        private void btnNewCaptcha_Click(object sender, EventArgs e)
        {
            if (pbCaptcha.Enabled)
                Bot1.newReCaptcha();
        }

        private void btnNewCaptcha2_Click(object sender, EventArgs e)
        {
            if (pbCaptcha2.Enabled)
                Bot2.newReCaptcha();
        }

        private void txtTalkText_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (cboTalkAs.Items.Count > 0 && txtTalkText.TextLength > 0)
                {
                    if (cboTalkAs.SelectedItem.ToString() == Bot1.ID)
                    {
                        Bot1.sendMessages.Add(txtTalkText.Text);
                        Convo("You > " + Bot1.ID, Color.DarkGreen, System.Drawing.FontStyle.Bold, false);
                        Convo(": ", System.Drawing.Color.Black, System.Drawing.FontStyle.Bold, false);
                        Convo(txtTalkText.Text, System.Drawing.Color.Black, System.Drawing.FontStyle.Regular, true);
                    }
                    else if (cboTalkAs.SelectedItem.ToString() == Bot2.ID)
                    {
                        Bot2.sendMessages.Add(txtTalkText.Text);
                        Convo("You > " + Bot2.ID, Color.DarkGreen, System.Drawing.FontStyle.Bold, false);
                        Convo(": ", System.Drawing.Color.Black, System.Drawing.FontStyle.Bold, false);
                        Convo(txtTalkText.Text, System.Drawing.Color.Black, System.Drawing.FontStyle.Regular, true);
                    }
                    
                }

                txtTalkText.Text = "";
                txtTalkText.Focus();
            }
        }
    }
}