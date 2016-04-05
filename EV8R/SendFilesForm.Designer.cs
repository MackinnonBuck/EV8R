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
            this.editLoginLinkLabel = new System.Windows.Forms.LinkLabel();
            this.toLabel = new System.Windows.Forms.Label();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.RichTextBox();
            this.filesLabel = new System.Windows.Forms.Label();
            this.fileSelectButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.localCopyCheckBox = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.localCopyFolderLabel = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fromLabel.Location = new System.Drawing.Point(12, 9);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(33, 13);
            this.fromLabel.TabIndex = 0;
            this.fromLabel.Text = "From:";
            // 
            // editLoginLinkLabel
            // 
            this.editLoginLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.editLoginLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editLoginLinkLabel.AutoSize = true;
            this.editLoginLinkLabel.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.editLoginLinkLabel.Location = new System.Drawing.Point(277, 9);
            this.editLoginLinkLabel.Name = "editLoginLinkLabel";
            this.editLoginLinkLabel.Size = new System.Drawing.Size(79, 13);
            this.editLoginLinkLabel.TabIndex = 1;
            this.editLoginLinkLabel.TabStop = true;
            this.editLoginLinkLabel.Text = "Edit login info...";
            this.editLoginLinkLabel.VisitedLinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.editLoginLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.editLoginLinkLabel_LinkClicked);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.toLabel.Location = new System.Drawing.Point(12, 28);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(23, 13);
            this.toLabel.TabIndex = 2;
            this.toLabel.Text = "To:";
            // 
            // toTextBox
            // 
            this.toTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toTextBox.Location = new System.Drawing.Point(41, 25);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(315, 20);
            this.toTextBox.TabIndex = 3;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.subjectLabel.Location = new System.Drawing.Point(12, 54);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(46, 13);
            this.subjectLabel.TabIndex = 4;
            this.subjectLabel.Text = "Subject:";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectTextBox.Location = new System.Drawing.Point(64, 51);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(292, 20);
            this.subjectTextBox.TabIndex = 5;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.messageLabel.Location = new System.Drawing.Point(12, 131);
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
            this.messageTextBox.Location = new System.Drawing.Point(12, 147);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(344, 157);
            this.messageTextBox.TabIndex = 7;
            this.messageTextBox.Text = "";
            // 
            // filesLabel
            // 
            this.filesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesLabel.AutoEllipsis = true;
            this.filesLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.filesLabel.Location = new System.Drawing.Point(12, 83);
            this.filesLabel.Name = "filesLabel";
            this.filesLabel.Size = new System.Drawing.Size(314, 13);
            this.filesLabel.TabIndex = 8;
            this.filesLabel.Text = "Files: <none selected>";
            // 
            // fileSelectButton
            // 
            this.fileSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileSelectButton.Location = new System.Drawing.Point(332, 77);
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
            // localCopyCheckBox
            // 
            this.localCopyCheckBox.AutoSize = true;
            this.localCopyCheckBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.localCopyCheckBox.Location = new System.Drawing.Point(12, 107);
            this.localCopyCheckBox.Name = "localCopyCheckBox";
            this.localCopyCheckBox.Size = new System.Drawing.Size(116, 17);
            this.localCopyCheckBox.TabIndex = 10;
            this.localCopyCheckBox.Text = "Create local copies";
            this.localCopyCheckBox.UseVisualStyleBackColor = true;
            this.localCopyCheckBox.CheckedChanged += new System.EventHandler(this.localCopyCheckBox_CheckedChanged);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Browse for a folder to save local copies.";
            // 
            // localCopyFolderLabel
            // 
            this.localCopyFolderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.localCopyFolderLabel.AutoEllipsis = true;
            this.localCopyFolderLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.localCopyFolderLabel.Location = new System.Drawing.Point(160, 108);
            this.localCopyFolderLabel.Name = "localCopyFolderLabel";
            this.localCopyFolderLabel.Size = new System.Drawing.Size(196, 17);
            this.localCopyFolderLabel.TabIndex = 11;
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(280, 310);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 12;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // SendFilesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(368, 345);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.localCopyFolderLabel);
            this.Controls.Add(this.localCopyCheckBox);
            this.Controls.Add(this.fileSelectButton);
            this.Controls.Add(this.filesLabel);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.editLoginLinkLabel);
            this.Controls.Add(this.fromLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(256, 256);
            this.Name = "SendFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Send Files";
            this.Load += new System.EventHandler(this.SendFilesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.LinkLabel editLoginLinkLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.RichTextBox messageTextBox;
        private System.Windows.Forms.Label filesLabel;
        private System.Windows.Forms.Button fileSelectButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.CheckBox localCopyCheckBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label localCopyFolderLabel;
        private System.Windows.Forms.Button sendButton;
    }
}