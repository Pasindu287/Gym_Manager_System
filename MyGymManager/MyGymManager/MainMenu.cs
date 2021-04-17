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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddMember add = new AddMember();
            add.Show();//open add member  form
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteMember delet = new DeleteMember();
            delet.Show();//open delete member form
        }

        private void listbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListofMember list = new ListofMember();
            list.Show();//open listof member form
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchMember search = new SearchMember();
            search.Show();//open search member form
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            this.Hide();
            loginForm log = new loginForm();
            log.Show();//back to login form

        }
    }
}
