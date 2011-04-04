namespace OmegleSpy
{
    partial class frmSpy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtConversation = new System.Windows.Forms.RichTextBox();
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.panelRecaptcha = new System.Windows.Forms.Panel();
            this.lblCaptchaId2 = new System.Windows.Forms.Label();
            this.lblCaptchaId = new System.Windows.Forms.Label();
            this.btnNewCaptcha2 = new System.Windows.Forms.Button();
            this.btnNewCaptcha = new System.Windows.Forms.Button();
            this.txtCaptchaResponse2 = new System.Windows.Forms.TextBox();
            this.pbCaptcha2 = new System.Windows.Forms.PictureBox();
            this.btnSubmitCaptcha = new System.Windows.Forms.Button();
            this.txtCaptchaResponse = new System.Windows.Forms.TextBox();
            this.pbCaptcha = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtTalkText = new System.Windows.Forms.TextBox();
            this.cboTalkAs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblBotStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBotStatus2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.panelRecaptcha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptcha2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptcha)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConversation
            // 
            this.txtConversation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConversation.BackColor = System.Drawing.Color.White;
            this.txtConversation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConversation.Location = new System.Drawing.Point(2, 2);
            this.txtConversation.Name = "txtConversation";
            this.txtConversation.ReadOnly = true;
            this.txtConversation.Size = new System.Drawing.Size(914, 537);
            this.txtConversation.TabIndex = 0;
            this.txtConversation.Text = "";
            // 
            // txtDebug
            // 
            this.txtDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDebug.BackColor = System.Drawing.Color.White;
            this.txtDebug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDebug.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebug.Location = new System.Drawing.Point(2, 5);
            this.txtDebug.Multiline = true;
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.ReadOnly = true;
            this.txtDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDebug.Size = new System.Drawing.Size(912, 103);
            this.txtDebug.TabIndex = 0;
            // 
            // panelRecaptcha
            // 
            this.panelRecaptcha.BackColor = System.Drawing.Color.LightGray;
            this.panelRecaptcha.Controls.Add(this.lblCaptchaId2);
            this.panelRecaptcha.Controls.Add(this.lblCaptchaId);
            this.panelRecaptcha.Controls.Add(this.btnNewCaptcha2);
            this.panelRecaptcha.Controls.Add(this.btnNewCaptcha);
            this.panelRecaptcha.Controls.Add(this.txtCaptchaResponse2);
            this.panelRecaptcha.Controls.Add(this.pbCaptcha2);
            this.panelRecaptcha.Controls.Add(this.btnSubmitCaptcha);
            this.panelRecaptcha.Controls.Add(this.txtCaptchaResponse);
            this.panelRecaptcha.Controls.Add(this.pbCaptcha);
            this.panelRecaptcha.Controls.Add(this.label1);
            this.panelRecaptcha.Location = new System.Drawing.Point(3, 3);
            this.panelRecaptcha.Name = "panelRecaptcha";
            this.panelRecaptcha.Size = new System.Drawing.Size(424, 290);
            this.panelRecaptcha.TabIndex = 0;
            this.panelRecaptcha.Visible = false;
            // 
            // lblCaptchaId2
            // 
            this.lblCaptchaId2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptchaId2.Location = new System.Drawing.Point(9, 166);
            this.lblCaptchaId2.Name = "lblCaptchaId2";
            this.lblCaptchaId2.Size = new System.Drawing.Size(47, 18);
            this.lblCaptchaId2.TabIndex = 6;
            this.lblCaptchaId2.Text = "null";
            this.lblCaptchaId2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaptchaId
            // 
            this.lblCaptchaId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptchaId.Location = new System.Drawing.Point(9, 68);
            this.lblCaptchaId.Name = "lblCaptchaId";
            this.lblCaptchaId.Size = new System.Drawing.Size(47, 18);
            this.lblCaptchaId.TabIndex = 5;
            this.lblCaptchaId.Text = "null";
            this.lblCaptchaId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewCaptcha2
            // 
            this.btnNewCaptcha2.Location = new System.Drawing.Point(369, 161);
            this.btnNewCaptcha2.Name = "btnNewCaptcha2";
            this.btnNewCaptcha2.Size = new System.Drawing.Size(42, 23);
            this.btnNewCaptcha2.TabIndex = 4;
            this.btnNewCaptcha2.Text = "New";
            this.btnNewCaptcha2.UseVisualStyleBackColor = true;
            this.btnNewCaptcha2.Click += new System.EventHandler(this.btnNewCaptcha2_Click);
            // 
            // btnNewCaptcha
            // 
            this.btnNewCaptcha.Location = new System.Drawing.Point(369, 63);
            this.btnNewCaptcha.Name = "btnNewCaptcha";
            this.btnNewCaptcha.Size = new System.Drawing.Size(42, 23);
            this.btnNewCaptcha.TabIndex = 3;
            this.btnNewCaptcha.Text = "New";
            this.btnNewCaptcha.UseVisualStyleBackColor = true;
            this.btnNewCaptcha.Click += new System.EventHandler(this.btnNewCaptcha_Click);
            // 
            // txtCaptchaResponse2
            // 
            this.txtCaptchaResponse2.Enabled = false;
            this.txtCaptchaResponse2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaptchaResponse2.Location = new System.Drawing.Point(62, 212);
            this.txtCaptchaResponse2.Name = "txtCaptchaResponse2";
            this.txtCaptchaResponse2.Size = new System.Drawing.Size(300, 27);
            this.txtCaptchaResponse2.TabIndex = 1;
            this.txtCaptchaResponse2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCaptchaResponse2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCaptchaResponse2_KeyUp);
            // 
            // pbCaptcha2
            // 
            this.pbCaptcha2.Enabled = false;
            this.pbCaptcha2.Location = new System.Drawing.Point(62, 145);
            this.pbCaptcha2.Name = "pbCaptcha2";
            this.pbCaptcha2.Size = new System.Drawing.Size(300, 57);
            this.pbCaptcha2.TabIndex = 4;
            this.pbCaptcha2.TabStop = false;
            // 
            // btnSubmitCaptcha
            // 
            this.btnSubmitCaptcha.Location = new System.Drawing.Point(62, 249);
            this.btnSubmitCaptcha.Name = "btnSubmitCaptcha";
            this.btnSubmitCaptcha.Size = new System.Drawing.Size(300, 32);
            this.btnSubmitCaptcha.TabIndex = 2;
            this.btnSubmitCaptcha.Text = "Submit";
            this.btnSubmitCaptcha.UseVisualStyleBackColor = true;
            this.btnSubmitCaptcha.Click += new System.EventHandler(this.btnSubmitCaptcha_Click);
            // 
            // txtCaptchaResponse
            // 
            this.txtCaptchaResponse.Enabled = false;
            this.txtCaptchaResponse.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaptchaResponse.Location = new System.Drawing.Point(62, 112);
            this.txtCaptchaResponse.Name = "txtCaptchaResponse";
            this.txtCaptchaResponse.Size = new System.Drawing.Size(300, 27);
            this.txtCaptchaResponse.TabIndex = 0;
            this.txtCaptchaResponse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCaptchaResponse.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCaptchaResponse_KeyUp);
            // 
            // pbCaptcha
            // 
            this.pbCaptcha.Enabled = false;
            this.pbCaptcha.Location = new System.Drawing.Point(62, 45);
            this.pbCaptcha.Name = "pbCaptcha";
            this.pbCaptcha.Size = new System.Drawing.Size(300, 57);
            this.pbCaptcha.TabIndex = 1;
            this.pbCaptcha.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "reCAPTCHA Required";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exotToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.connectionToolStripMenuItem.Text = "Start New Conversation";
            this.connectionToolStripMenuItem.Click += new System.EventHandler(this.connectionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(226, 6);
            // 
            // exotToolStripMenuItem
            // 
            this.exotToolStripMenuItem.Name = "exotToolStripMenuItem";
            this.exotToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.exotToolStripMenuItem.Text = "Exit";
            this.exotToolStripMenuItem.Click += new System.EventHandler(this.exotToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelRecaptcha);
            this.splitContainer1.Panel1.Controls.Add(this.txtConversation);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtTalkText);
            this.splitContainer1.Panel2.Controls.Add(this.cboTalkAs);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtDebug);
            this.splitContainer1.Size = new System.Drawing.Size(917, 683);
            this.splitContainer1.SplitterDistance = 542;
            this.splitContainer1.TabIndex = 4;
            // 
            // txtTalkText
            // 
            this.txtTalkText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTalkText.AutoCompleteCustomSource.AddRange(new string[] {
            "/disconnect"});
            this.txtTalkText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTalkText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTalkText.Location = new System.Drawing.Point(185, 111);
            this.txtTalkText.Name = "txtTalkText";
            this.txtTalkText.Size = new System.Drawing.Size(729, 20);
            this.txtTalkText.TabIndex = 3;
            this.txtTalkText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTalkText_KeyUp);
            // 
            // cboTalkAs
            // 
            this.cboTalkAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboTalkAs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTalkAs.FormattingEnabled = true;
            this.cboTalkAs.Location = new System.Drawing.Point(59, 111);
            this.cboTalkAs.Name = "cboTalkAs";
            this.cboTalkAs.Size = new System.Drawing.Size(121, 21);
            this.cboTalkAs.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Talk To:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblBotStatus,
            this.toolStripStatusLabel2,
            this.lblBotStatus2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 708);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(918, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblBotStatus
            // 
            this.lblBotStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblBotStatus.Name = "lblBotStatus";
            this.lblBotStatus.Size = new System.Drawing.Size(56, 17);
            this.lblBotStatus.Text = "Bot is idle.";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(14, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // lblBotStatus2
            // 
            this.lblBotStatus2.BackColor = System.Drawing.Color.Transparent;
            this.lblBotStatus2.Name = "lblBotStatus2";
            this.lblBotStatus2.Size = new System.Drawing.Size(56, 17);
            this.lblBotStatus2.Text = "Bot is idle.";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitHubPageToolStripMenuItem,
            this.toolStripMenuItem2,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // gitHubPageToolStripMenuItem
            // 
            this.gitHubPageToolStripMenuItem.Name = "gitHubPageToolStripMenuItem";
            this.gitHubPageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gitHubPageToolStripMenuItem.Text = "GitHub Page";
            this.gitHubPageToolStripMenuItem.Click += new System.EventHandler(this.gitHubPageToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // frmSpy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 730);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSpy";
            this.Text = "Omegle Spy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSpy_FormClosing);
            this.panelRecaptcha.ResumeLayout(false);
            this.panelRecaptcha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptcha2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptcha)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtConversation;
        public System.Windows.Forms.TextBox txtDebug;
        public System.Windows.Forms.Panel panelRecaptcha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        public System.Windows.Forms.PictureBox pbCaptcha;
        public System.Windows.Forms.TextBox txtCaptchaResponse;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.TextBox txtCaptchaResponse2;
        public System.Windows.Forms.PictureBox pbCaptcha2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exotToolStripMenuItem;
        private System.Windows.Forms.Button btnNewCaptcha2;
        private System.Windows.Forms.Button btnNewCaptcha;
        private System.Windows.Forms.TextBox txtTalkText;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cboTalkAs;
        public System.Windows.Forms.Button btnSubmitCaptcha;
        public System.Windows.Forms.Label lblCaptchaId2;
        public System.Windows.Forms.Label lblCaptchaId;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblBotStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblBotStatus2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

