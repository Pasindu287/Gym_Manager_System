using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGymManager
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            if (username == "gymmanager" && password == "123gym")//user name and password
            {
                MessageBox.Show("Login Success!!");
                this.Hide();
                MainMenu main = new MainMenu();
                main.Show();

            }
            else
            {
                MessageBox.Show("Inavalid UserName or Password !!!");
            }
             
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
