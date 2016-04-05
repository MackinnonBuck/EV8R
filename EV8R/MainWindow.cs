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
        /// Initializes this instance.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Shows the log in dialog when the log in link is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logInLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LoginDialog.ShowDialog(this);
            if (Program.LoginDialog.IsFormComplete)
                loginStatusLabel.Text = "Welcome, " + Program.LoginDialog.Email + "!";
            else
                loginStatusLabel.Text = "Please complete all log in fields to send files.";
        }

        /// <summary>
        /// Shows the user the send message form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendButton_Click(object sender, EventArgs e)
        {
            if (!Program.LoginDialog.IsFormComplete)
            {
                MessageBox.Show(this, "You must complete all log in fields before sending files.", "Please log in.");
                return;
            }

            new SendFilesForm().ShowDialog();
        }
    }
}
