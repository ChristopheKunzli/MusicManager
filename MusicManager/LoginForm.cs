using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BC = BCrypt.Net.BCrypt;

namespace MusicManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            string pass = txtPass.Text;
            string mail = txtMail.Text;

            //Check that user gave both an email and a password
            if(mail == "" || pass == "")
            {
                MessageBox.Show("Enter your address mail and your password");
                return;
            }

            //Attemtp to find the user
            ConnectionDB db = new ConnectionDB();
            User user = db.getUser(mail);

            if (user == null) 
            {
                MessageBox.Show("User not found");
                return;
            }

            //Check if the password corresponds with the hash stored in DB
            bool passwordIsCorrect = BC.Verify(pass, user.Password);

            if(passwordIsCorrect)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect password");
                return;
            }
        }
    }
}
