namespace EV8R
{
    partial class SendFilesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendFilesForm));
            this.fromLabel = new System.Windows.Forms.Label();
            this.loginLinkLabel = new System.Windows.Forms.LinkLabel();
            this.toLabel = new System.Windows.Forms.Label();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.RichTextBox();
            this.filesLabel = new System.Windows.Forms.Label();
            this.fileSelectButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.sendButton = new System.Windows.Forms.Button();
            this.fileSizeLimitLabel = new System.Windows.Forms.Label();
            this.fileSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.filePropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.messageGroupBox = new System.Windows.Forms.GroupBox();
            this.customMessageCheckBox = new System.Windows.Forms.CheckBox();
            this.sendProgressBar = new System.Windows.Forms.ProgressBar();
            this.sendStatusLabel = new System.Windows.Forms.Label();
            this.sendingBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.saveLocalButton = new System.Windows.Forms.Button();
            this.includeExecutableCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSizeNumericUpDown)).BeginInit();
            this.filePropertiesGroupBox.SuspendLayout();
            this.messageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fromLabel.Location = new System.Drawing.Point(6, 16);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(33, 13);
            this.fromLabel.TabIndex = 0;
            this.fromLabel.Text = "From:";
            // 
            // loginLinkLabel
            // 
            this.loginLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.loginLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginLinkLabel.AutoSize = true;
            this.loginLinkLabel.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginLinkLabel.Location = new System.Drawing.Point(284, 16);
            this.loginLinkLabel.Name = "loginLinkLabel";
            this.loginLinkLabel.Size = new System.Drawing.Size(54, 13);
            this.loginLinkLabel.TabIndex = 1;
            this.loginLinkLabel.TabStop = true;
            this.loginLinkLabel.Text = "Login Info";
            this.loginLinkLabel.VisitedLinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLinkLabel_LinkClicked);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.toLabel.Location = new System.Drawing.Point(6, 38);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(23, 13);
            this.toLabel.TabIndex = 2;
            this.toLabel.Text = "To:";
            // 
            // toTextBox
            // 
            this.toTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toTextBox.Location = new System.Drawing.Point(35, 35);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(303, 20);
            this.toTextBox.TabIndex = 3;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.subjectLabel.Location = new System.Drawing.Point(6, 87);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(46, 13);
            this.subjectLabel.TabIndex = 4;
            this.subjectLabel.Text = "Subject:";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectTextBox.Enabled = false;
            this.subjectTextBox.Location = new System.Drawing.Point(58, 84);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(280, 20);
            this.subjectTextBox.TabIndex = 5;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.messageLabel.Location = new System.Drawing.Point(6, 107);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(53, 13);
            this.messageLabel.TabIndex = 6;
            this.messageLabel.Text = "Message:";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTextBox.Enabled = false;
            this.messageTextBox.Location = new System.Drawing.Point(6, 123);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(332, 168);
            this.messageTextBox.TabIndex = 7;
            this.messageTextBox.Text = "";
            // 
            // filesLabel
            // 
            this.filesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesLabel.AutoEllipsis = true;
            this.filesLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.filesLabel.Location = new System.Drawing.Point(6, 25);
            this.filesLabel.Name = "filesLabel";
            this.filesLabel.Size = new System.Drawing.Size(302, 13);
            this.filesLabel.TabIndex = 8;
            this.filesLabel.Text = "Files: <none selected>";
            // 
            // fileSelectButton
            // 
            this.fileSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileSelectButton.Location = new System.Drawing.Point(314, 19);
            this.fileSelectButton.Name = "fileSelectButton";
            this.fileSelectButton.Size = new System.Drawing.Size(24, 24);
            this.fileSelectButton.TabIndex = 9;
            this.fileSelectButton.Text = "...";
            this.fileSelectButton.UseVisualStyleBackColor = true;
            this.fileSelectButton.Click += new System.EventHandler(this.fileSelectButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Multiselect = true;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Browse for a folder to save local copies.";
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(281, 438);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 12;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // fileSizeLimitLabel
            // 
            this.fileSizeLimitLabel.AutoSize = true;
            this.fileSizeLimitLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fileSizeLimitLabel.Location = new System.Drawing.Point(6, 51);
            this.fileSizeLimitLabel.Name = "fileSizeLimitLabel";
            this.fileSizeLimitLabel.Size = new System.Drawing.Size(92, 13);
            this.fileSizeLimitLabel.TabIndex = 13;
            this.fileSizeLimitLabel.Text = "File size limit (MB):";
            // 
            // fileSizeNumericUpDown
            // 
            this.fileSizeNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileSizeNumericUpDown.Location = new System.Drawing.Point(104, 49);
            this.fileSizeNumericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.fileSizeNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.fileSizeNumericUpDown.Name = "fileSizeNumericUpDown";
            this.fileSizeNumericUpDown.Size = new System.Drawing.Size(234, 20);
            this.fileSizeNumericUpDown.TabIndex = 14;
            this.fileSizeNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // filePropertiesGroupBox
            // 
            this.filePropertiesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePropertiesGroupBox.Controls.Add(this.includeExecutableCheckBox);
            this.filePropertiesGroupBox.Controls.Add(this.saveLocalButton);
            this.filePropertiesGroupBox.Controls.Add(this.filesLabel);
            this.filePropertiesGroupBox.Controls.Add(this.fileSizeLimitLabel);
            this.filePropertiesGroupBox.Controls.Add(this.fileSizeNumericUpDown);
            this.filePropertiesGroupBox.Controls.Add(this.fileSelectButton);
            this.filePropertiesGroupBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.filePropertiesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.filePropertiesGroupBox.Name = "filePropertiesGroupBox";
            this.filePropertiesGroupBox.Size = new System.Drawing.Size(344, 104);
            this.filePropertiesGroupBox.TabIndex = 15;
            this.filePropertiesGroupBox.TabStop = false;
            this.filePropertiesGroupBox.Text = "File Properties";
            // 
            // messageGroupBox
            // 
            this.messageGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageGroupBox.Controls.Add(this.customMessageCheckBox);
            this.messageGroupBox.Controls.Add(this.fromLabel);
            this.messageGroupBox.Controls.Add(this.loginLinkLabel);
            this.messageGroupBox.Controls.Add(this.toTextBox);
            this.messageGroupBox.Controls.Add(this.toLabel);
            this.messageGroupBox.Controls.Add(this.messageTextBox);
            this.messageGroupBox.Controls.Add(this.subjectTextBox);
            this.messageGroupBox.Controls.Add(this.messageLabel);
            this.messageGroupBox.Controls.Add(this.subjectLabel);
            this.messageGroupBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.messageGroupBox.Location = new System.Drawing.Point(12, 122);
            this.messageGroupBox.Name = "messageGroupBox";
            this.messageGroupBox.Size = new System.Drawing.Size(344, 297);
            this.messageGroupBox.TabIndex = 16;
            this.messageGroupBox.TabStop = false;
            this.messageGroupBox.Text = "Message";
            // 
            // customMessageCheckBox
            // 
            this.customMessageCheckBox.AutoSize = true;
            this.customMessageCheckBox.Location = new System.Drawing.Point(6, 61);
            this.customMessageCheckBox.Name = "customMessageCheckBox";
            this.customMessageCheckBox.Size = new System.Drawing.Size(133, 17);
            this.customMessageCheckBox.TabIndex = 8;
            this.customMessageCheckBox.Text = "Send custom message";
            this.customMessageCheckBox.UseVisualStyleBackColor = true;
            this.customMessageCheckBox.CheckedChanged += new System.EventHandler(this.customMessageCheckBox_CheckedChanged);
            // 
            // sendProgressBar
            // 
            this.sendProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendProgressBar.Location = new System.Drawing.Point(12, 438);
            this.sendProgressBar.MarqueeAnimationSpeed = 25;
            this.sendProgressBar.Name = "sendProgressBar";
            this.sendProgressBar.Size = new System.Drawing.Size(263, 23);
            this.sendProgressBar.TabIndex = 17;
            this.sendProgressBar.Visible = false;
            // 
            // sendStatusLabel
            // 
            this.sendStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sendStatusLabel.AutoSize = true;
            this.sendStatusLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.sendStatusLabel.Location = new System.Drawing.Point(12, 422);
            this.sendStatusLabel.Name = "sendStatusLabel";
            this.sendStatusLabel.Size = new System.Drawing.Size(55, 13);
            this.sendStatusLabel.TabIndex = 8;
            this.sendStatusLabel.Text = "Sending...";
            this.sendStatusLabel.Visible = false;
            // 
            // sendingBackgroundWorker
            // 
            this.sendingBackgroundWorker.WorkerReportsProgress = true;
            this.sendingBackgroundWorker.WorkerSupportsCancellation = true;
            this.sendingBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.sendingBackgroundWorker_DoWork);
            this.sendingBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.sendingBackgroundWorker_ProgressChanged);
            this.sendingBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.sendingBackgroundWorker_RunWorkerCompleted);
            // 
            // saveLocalButton
            // 
            this.saveLocalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveLocalButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveLocalButton.Location = new System.Drawing.Point(228, 75);
            this.saveLocalButton.Name = "saveLocalButton";
            this.saveLocalButton.Size = new System.Drawing.Size(110, 23);
            this.saveLocalButton.TabIndex = 15;
            this.saveLocalButton.Text = "Save Local Copies";
            this.saveLocalButton.UseVisualStyleBackColor = true;
            this.saveLocalButton.Click += new System.EventHandler(this.saveLocalButton_Click);
            // 
            // includeExecutableCheckBox
            // 
            this.includeExecutableCheckBox.AutoSize = true;
            this.includeExecutableCheckBox.Location = new System.Drawing.Point(6, 79);
            this.includeExecutableCheckBox.Name = "includeExecutableCheckBox";
            this.includeExecutableCheckBox.Size = new System.Drawing.Size(165, 17);
            this.includeExecutableCheckBox.TabIndex = 16;
            this.includeExecutableCheckBox.Text = "Include extraction executable";
            this.includeExecutableCheckBox.UseVisualStyleBackColor = true;
            // 
            // SendFilesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(368, 473);
            this.Controls.Add(this.sendStatusLabel);
            this.Controls.Add(this.sendProgressBar);
            this.Controls.Add(this.messageGroupBox);
            this.Controls.Add(this.filePropertiesGroupBox);
            this.Controls.Add(this.sendButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(384, 512);
            this.Name = "SendFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Send Files";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SendFilesForm_FormClosing);
            this.Load += new System.EventHandler(this.SendFilesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSizeNumericUpDown)).EndInit();
            this.filePropertiesGroupBox.ResumeLayout(false);
            this.filePropertiesGroupBox.PerformLayout();
            this.messageGroupBox.ResumeLayout(false);
            this.messageGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.LinkLabel loginLinkLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.RichTextBox messageTextBox;
        private System.Windows.Forms.Label filesLabel;
        private System.Windows.Forms.Button fileSelectButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label fileSizeLimitLabel;
        private System.Windows.Forms.NumericUpDown fileSizeNumericUpDown;
        private System.Windows.Forms.GroupBox filePropertiesGroupBox;
        private System.Windows.Forms.GroupBox messageGroupBox;
        private System.Windows.Forms.ProgressBar sendProgressBar;
        private System.Windows.Forms.Label sendStatusLabel;
        private System.ComponentModel.BackgroundWorker sendingBackgroundWorker;
        private System.Windows.Forms.CheckBox customMessageCheckBox;
        private System.Windows.Forms.Button saveLocalButton;
        private System.Windows.Forms.CheckBox includeExecutableCheckBox;
    }
}