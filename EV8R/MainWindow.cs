using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EV8R
{
    public partial class MainWindow : Form
    {
        /// <summary>
        /// The about dialog.
        /// </summary>
        private AboutDialog aboutDialog;

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            aboutDialog = new AboutDialog();
        }

        /// <summary>
        /// Updates the welcome message label after the window regains focus.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Activated(object sender, EventArgs e)
        {
            welcomeMessageLabel.Text = Program.LoginDialog.IsFormComplete ? "Welcome, " + Program.LoginDialog.Email + "!" : string.Empty;
        }

        /// <summary>
        /// Shows the log in dialog when the log in link is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LoginDialog.ShowDialog(this);
        }

        /// <summary>
        /// Shows the about dialog when the about link label is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            aboutDialog.ShowDialog();
        }

        /// <summary>
        /// Shows the user the send message form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendButton_Click(object sender, EventArgs e)
        {
            using (SendFilesForm sendFilesForm = new SendFilesForm())
                sendFilesForm.ShowDialog(this);
        }

        /// <summary>
        /// Opens the openFileDialog for the user to select EV8R files to load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFilesButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) != DialogResult.OK || folderBrowserDialog.ShowDialog(this) != DialogResult.OK)
                return;

            using (ImportFilesForm importFilesForm = new ImportFilesForm(openFileDialog.FileNames, folderBrowserDialog.SelectedPath))
                importFilesForm.ShowDialog(this);
        }
    }
}
