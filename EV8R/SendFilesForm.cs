using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EV8R
{
    public partial class SendFilesForm : Form
    {
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public SendFilesForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Shows the LoginDialog.
        /// </summary>
        private void ShowLoginDialog()
        {
            Program.LoginDialog.ShowDialog(this);
            if (!Program.LoginDialog.IsFormComplete)
            {
                if (MessageBox.Show(this, "Cannot send files without valid login information.\nReenter information?", "Cannot send files.",
                    MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                    ShowLoginDialog();
                else
                    Close();
            }
        }

        /// <summary>
        /// Sets the fromLabel's text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendFilesForm_Load(object sender, EventArgs e)
        {
            fromLabel.Text = "From: " + Program.LoginDialog.Email;
        }

        /// <summary>
        /// Shows the LoginDialog when the edit login link label is clicked..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editLoginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
        /// Creates the files and sends the email.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendButton_Click(object sender, EventArgs e)
        {
            // TODO
        }
    }
}
