using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGymManager
{
    public partial class DeleteMember : Form
    {
        public DeleteMember()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu main = new MainMenu();
            main.Show();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("You really want to delete the data?","Delete data",MessageBoxButtons.YesNo)== DialogResult.Yes){
                SqlConnection sql = new SqlConnection();
                sql.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pasin\\Desktop\\MyGymManager\\MyGymManager\\MyGymDB.mdf;Integrated Security=True;Connect Timeout=30";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sql;

                cmd.CommandText = "Delete from GymMembers where MemberID = " + textBox1.Text + "";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                MessageBox.Show("Data deleted!");
            }
            else
            {
                this.Activate();
                SqlConnection sql = new SqlConnection();
                sql.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pasin\\Desktop\\MyGymManager\\MyGymManager\\MyGymDB.mdf;Integrated Security=True;Connect Timeout=30";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sql;

                cmd.CommandText = "select  * from GymMembers";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];

            }

         
        }

        private void DeleteMember_Load(object sender, EventArgs e)
        {
            // get data for grid 
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pasin\\Desktop\\MyGymManager\\MyGymManager\\MyGymDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sql;

            cmd.CommandText = "select * from GymMembers";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];

        }
    }
}
