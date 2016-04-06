using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EV8R
{
    public partial class LoginDialog : Form
    {
        /// <summary>
        /// A list of each registered SMTP server.
        /// </summary>
        private List<Tuple<string, string, int>> serverList;

        /// <summary>
        /// Returns true if the form has been completed.
        /// </summary>
        public bool IsFormComplete
        {
            get
            {
                return serverComboBox.Text.Length > 0 && emailTextBox.Text.Length > 0 && passwordTextBox.Text.Length > 0;
            }
        }

        /// <summary>
        /// Returns the email entered by the user.
        /// </summary>
        public string Email
        {
            get
            {
                return emailTextBox.Text;
            }
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public LoginDialog()
        {
            serverList = new List<Tuple<string, string, int>>();
            serverList.Add(new Tuple<string, string, int>("GMail", "smtp.gmail.com", 465));
            serverList.Add(new Tuple<string, string, int>("Outlook", "smtp.live.com", 587));
            serverList.Add(new Tuple<string, string, int>("Office365", "smtp.office365.com", 587));
            serverList.Add(new Tuple<string, string, int>("Yahoo Mail", "smtp.mail.yahoo.com", 465));
            serverList.Add(new Tuple<string, string, int>("iCloud", "smtp.mail.me.com", 587));

            InitializeComponent();

            foreach (Tuple<string, string, int> server in serverList)
                serverComboBox.Items.Add(server.Item1 + " (" + server.Item2 + ")");
        }

        /// <summary>
        /// Updates the port with the value that corresponds to the selected server.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            portNumericUpDown.Value = serverList[serverComboBox.SelectedIndex].Item3;
        }
    }
}
