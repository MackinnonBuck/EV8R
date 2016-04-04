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
        /// The login dialog for connecting to an email server.
        /// </summary>
        private LoginDialog loginDialog;

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public MainWindow()
        {
            loginDialog = new LoginDialog();

            InitializeComponent();
        }

        /// <summary>
        /// Shows the log in dialog when the log in link is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logInLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (loginDialog.ShowDialog() == DialogResult.OK)
                loginStatusLabel.Text = "Welcome, " + loginDialog.Email + "!";
            else
                loginStatusLabel.Text = "Please log in to use EV8R.";
        }
    }
}
