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
        /// Creates the files and sends the email.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendButton_Click(object sender, EventArgs e)
        {
            if (!Program.LoginDialog.IsFormComplete)
            {
                MessageBox.Show(this, "You must complete login info to send files.", "Unable to send.");
                return;
            }

            if (openFileDialog.FileNames.Length == 0 &&
                MessageBox.Show(this, "You must complete login info to send files.\nContinue anyway?", "Unable to send.",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            Exporter exporter = new Exporter((int)fileSizeNumericUpDown.Value);
            
            foreach (string fileName in openFileDialog.FileNames)
                exporter.Load(fileName);

            if (localCopyCheckBox.Checked)
                exporter.Write(folderBrowserDialog.SelectedPath);
        }
    }
}
