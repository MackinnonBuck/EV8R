namespace EV8R
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.sendFilesLabel = new System.Windows.Forms.Label();
            this.openFilesLabel = new System.Windows.Forms.Label();
            this.ev8rLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.logInLinkLabel = new System.Windows.Forms.LinkLabel();
            this.aboutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.loginStatusLabel = new System.Windows.Forms.Label();
            this.openFilesButton = new EV8R.ImageButton();
            this.sendButton = new EV8R.ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.ev8rLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFilesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendButton)).BeginInit();
            this.SuspendLayout();
            // 
            // sendFilesLabel
            // 
            this.sendFilesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sendFilesLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendFilesLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.sendFilesLabel.Location = new System.Drawing.Point(12, 505);
            this.sendFilesLabel.Name = "sendFilesLabel";
            this.sendFilesLabel.Size = new System.Drawing.Size(288, 36);
            this.sendFilesLabel.TabIndex = 2;
            this.sendFilesLabel.Text = "Send Files";
            this.sendFilesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFilesLabel
            // 
            this.openFilesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openFilesLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFilesLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.openFilesLabel.Location = new System.Drawing.Point(306, 505);
            this.openFilesLabel.Name = "openFilesLabel";
            this.openFilesLabel.Size = new System.Drawing.Size(288, 36);
            this.openFilesLabel.TabIndex = 3;
            this.openFilesLabel.Text = "Open Files";
            this.openFilesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ev8rLogoPictureBox
            // 
            this.ev8rLogoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ev8rLogoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ev8rLogoPictureBox.BackgroundImage")));
            this.ev8rLogoPictureBox.Location = new System.Drawing.Point(47, 12);
            this.ev8rLogoPictureBox.Name = "ev8rLogoPictureBox";
            this.ev8rLogoPictureBox.Size = new System.Drawing.Size(512, 196);
            this.ev8rLogoPictureBox.TabIndex = 4;
            this.ev8rLogoPictureBox.TabStop = false;
            // 
            // logInLinkLabel
            // 
            this.logInLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.logInLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logInLinkLabel.AutoSize = true;
            this.logInLinkLabel.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.logInLinkLabel.Location = new System.Drawing.Point(514, 9);
            this.logInLinkLabel.Name = "logInLinkLabel";
            this.logInLinkLabel.Size = new System.Drawing.Size(37, 13);
            this.logInLinkLabel.TabIndex = 5;
            this.logInLinkLabel.TabStop = true;
            this.logInLinkLabel.Text = "Log In";
            this.logInLinkLabel.VisitedLinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.logInLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logInLinkLabel_LinkClicked);
            // 
            // aboutLinkLabel
            // 
            this.aboutLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.aboutLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutLinkLabel.AutoSize = true;
            this.aboutLinkLabel.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.aboutLinkLabel.Location = new System.Drawing.Point(557, 9);
            this.aboutLinkLabel.Name = "aboutLinkLabel";
            this.aboutLinkLabel.Size = new System.Drawing.Size(35, 13);
            this.aboutLinkLabel.TabIndex = 6;
            this.aboutLinkLabel.TabStop = true;
            this.aboutLinkLabel.Text = "About";
            this.aboutLinkLabel.VisitedLinkColor = System.Drawing.SystemColors.MenuHighlight;
            // 
            // loginStatusLabel
            // 
            this.loginStatusLabel.AutoSize = true;
            this.loginStatusLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginStatusLabel.Location = new System.Drawing.Point(9, 9);
            this.loginStatusLabel.Name = "loginStatusLabel";
            this.loginStatusLabel.Size = new System.Drawing.Size(215, 13);
            this.loginStatusLabel.TabIndex = 7;
            this.loginStatusLabel.Text = "Please complete all log in fields to send files.";
            // 
            // openFilesButton
            // 
            this.openFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openFilesButton.AwayImage = ((System.Drawing.Image)(resources.GetObject("openFilesButton.AwayImage")));
            this.openFilesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openFilesButton.BackgroundImage")));
            this.openFilesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openFilesButton.HoveringImage = ((System.Drawing.Image)(resources.GetObject("openFilesButton.HoveringImage")));
            this.openFilesButton.Location = new System.Drawing.Point(306, 214);
            this.openFilesButton.Name = "openFilesButton";
            this.openFilesButton.PressedImage = ((System.Drawing.Image)(resources.GetObject("openFilesButton.PressedImage")));
            this.openFilesButton.Size = new System.Drawing.Size(288, 288);
            this.openFilesButton.TabIndex = 1;
            this.openFilesButton.TabStop = false;
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sendButton.AwayImage = ((System.Drawing.Image)(resources.GetObject("sendButton.AwayImage")));
            this.sendButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sendButton.BackgroundImage")));
            this.sendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendButton.HoveringImage = ((System.Drawing.Image)(resources.GetObject("sendButton.HoveringImage")));
            this.sendButton.Location = new System.Drawing.Point(12, 214);
            this.sendButton.Name = "sendButton";
            this.sendButton.PressedImage = ((System.Drawing.Image)(resources.GetObject("sendButton.PressedImage")));
            this.sendButton.Size = new System.Drawing.Size(288, 288);
            this.sendButton.TabIndex = 0;
            this.sendButton.TabStop = false;
            this.sendButton.Text = "imageButton1";
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(606, 550);
            this.Controls.Add(this.loginStatusLabel);
            this.Controls.Add(this.aboutLinkLabel);
            this.Controls.Add(this.logInLinkLabel);
            this.Controls.Add(this.ev8rLogoPictureBox);
            this.Controls.Add(this.openFilesLabel);
            this.Controls.Add(this.sendFilesLabel);
            this.Controls.Add(this.openFilesButton);
            this.Controls.Add(this.sendButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "EV8R";
            ((System.ComponentModel.ISupportInitialize)(this.ev8rLogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFilesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ImageButton sendButton;
        private ImageButton openFilesButton;
        private System.Windows.Forms.Label sendFilesLabel;
        private System.Windows.Forms.Label openFilesLabel;
        private System.Windows.Forms.PictureBox ev8rLogoPictureBox;
        private System.Windows.Forms.LinkLabel logInLinkLabel;
        private System.Windows.Forms.LinkLabel aboutLinkLabel;
        private System.Windows.Forms.Label loginStatusLabel;
    }
}

