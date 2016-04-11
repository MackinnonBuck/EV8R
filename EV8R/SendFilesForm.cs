using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EV8R
{
    public partial class SendFilesForm : Form
    {
        /// <summary>
        /// Used for determining if the message can be sent.
        /// </summary>
        private bool IsMessageValid
        {
            get
            {
                return toTextBox.TextLength != 0;
            }
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public SendFilesForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Updates the from label with email name if the login form is complete.
        /// </summary>
        void UpdateFromLabel()
        {
            fromLabel.Text = "From: " + (Program.LoginDialog.IsFormComplete ? Program.LoginDialog.Email : "<incomplete login info>");
        }

        /// <summary>
        /// Shows the LoginDialog.
        /// </summary>
        private void ShowLoginDialog()
        {
            Program.LoginDialog.ShowDialog(this);
            UpdateFromLabel();
        }

        /// <summary>
        /// Sets the fromLabel's text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendFilesForm_Load(object sender, EventArgs e)
        {
            UpdateFromLabel();
        }

        /// <summary>
        /// Cancels the send process if running, then closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendFilesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sendingBackgroundWorker.IsBusy)
            {
                MessageBox.Show(this, "A send operation is currently active.\nPlease cancel the operation to close the window.",
                    "Operation in progress.");
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Shows the LoginDialog when the edit login link label is clicked..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLoginDialog();
        }

        /// <summary>
        /// Shows the file open dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileSelectButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filesLabel.Text = "Files: ";

                foreach (string filename in openFileDialog.FileNames)
                    filesLabel.Text += new FileInfo(filename).Name + ", ";

                filesLabel.Text = filesLabel.Text.Substring(0, filesLabel.Text.LastIndexOf(','));
            }
            else
            {
                filesLabel.Text = "Files: <none selected>";
            }
        }

        /// <summary>
        /// Opens the folder browser dialog to allow the user to select the path to which copies are saved.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void localCopyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (localCopyCheckBox.Checked)
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    localCopyFolderLabel.Text = folderBrowserDialog.SelectedPath;
                else
                    localCopyCheckBox.Checked = false;
            }
            else
            {
                localCopyFolderLabel.Text = string.Empty;
            }
        }

        /// <summary>
        /// Enables or disables the custom message fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customMessageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            subjectTextBox.Enabled = messageTextBox.Enabled = customMessageCheckBox.Checked;
        }

        /// <summary>
        /// Creates the files and sends the email.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendButton_Click(object sender, EventArgs e)
        {
            if (sendingBackgroundWorker.IsBusy)
            {
                sendButton.Enabled = false;
                sendingBackgroundWorker.CancelAsync();
                sendStatusLabel.Text = "Canceling...";
                sendProgressBar.Style = ProgressBarStyle.Marquee;
                return;
            }

            if (!Program.LoginDialog.IsFormComplete)
            {
                MessageBox.Show(this, "You must complete login info to send files.", "Unable to send.");
                return;
            }

            if (!IsMessageValid)
            {
                MessageBox.Show(this, "You must specify the email delivery address.", "Unable to send.");
                return;
            }

            if (openFileDialog.FileNames.Length == 0)
            {
                MessageBox.Show(this, "You have not attached any files to send.", "Unable to send.");
                return;
            }

            sendButton.Enabled = false;
            sendProgressBar.Visible = true;
            sendStatusLabel.Visible = true;

            MailMessage message = null;

            if (customMessageCheckBox.Checked)
            {
                message = new MailMessage(Program.LoginDialog.Email, toTextBox.Text);
                message.Subject = subjectTextBox.Text;
                message.Body = messageTextBox.Text;
            }

            sendingBackgroundWorker.RunWorkerAsync(message);
            sendButton.Enabled = true;
            sendButton.Text = "Cancel";
        }

        /// <summary>
        /// Exports the files and then sends the message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendingBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            sendingBackgroundWorker.ReportProgress(-1, "Exporting files...");

            Exporter exporter = new Exporter((int)fileSizeNumericUpDown.Value);

            foreach (string fileName in openFileDialog.FileNames)
                exporter.Load(fileName);

            string outputPath = localCopyCheckBox.Checked ? folderBrowserDialog.SelectedPath + '\\' : Path.GetTempPath();
            exporter.Write(outputPath);

            using (SmtpClient client = new SmtpClient(Program.LoginDialog.Server, Program.LoginDialog.Port))
            {
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(Program.LoginDialog.Email, Program.LoginDialog.Password);

                try
                {
                    if (e.Argument != null)
                    {
                        if (sendingBackgroundWorker.CancellationPending)
                            return;

                        sendingBackgroundWorker.ReportProgress(-1, "Sending message...");
                        client.Send((MailMessage)e.Argument);
                    }

                    for (int i = 0; i < exporter.SubFiles.Count; i++)
                    {
                        if (sendingBackgroundWorker.CancellationPending)
                            return;

                        sendingBackgroundWorker.ReportProgress((int)((i + 1) / (float)exporter.SubFiles.Count * 100.0f),
                            "Sending files " + (i + 1) + " of " + exporter.SubFiles.Count + "...");

                        using (MailMessage message = new MailMessage(Program.LoginDialog.Email, toTextBox.Text))
                        {
                            message.Subject = "EV8R (Pt. " + (i + 1) + '/' + exporter.SubFiles.Count + ')';
                            message.Attachments.Add(new Attachment(outputPath + exporter.SubFiles[i].FileName));

                            client.Send(message);
                        }
                    }

                    e.Result = "Files sent successfully!";
                }
                catch (SmtpException ex)
                {
                    e.Result = ex.Message;
                }
            }
        }

        /// <summary>
        /// Updates the progress bar and the status label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendingBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            sendStatusLabel.Text = (string)e.UserState;

            if (e.ProgressPercentage < 0)
            {
                sendProgressBar.Style = ProgressBarStyle.Marquee;
            }
            else
            {
                sendProgressBar.Style = ProgressBarStyle.Continuous;
                sendProgressBar.Value = e.ProgressPercentage;
            }
        }

        /// <summary>
        /// Hides the progress bar and status label and re-enables the send button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendingBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            sendButton.Enabled = true;
            sendButton.Text = "Send";
            sendProgressBar.Visible = false;
            sendStatusLabel.Visible = false;

            if (e.Result != null)
                MessageBox.Show(this, (string)e.Result);
        }
    }
}
