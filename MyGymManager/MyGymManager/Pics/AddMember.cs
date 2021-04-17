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
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu main = new MainMenu();
            main.Show();

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            String fname = txtFirstName.Text;
            String lname = txtLastName.Text;
            String gender = comboBoxGender.Text;
            String dob = dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(txtTelNum.Text);
            String joindate = dateTimeJoin.Text;
            String shedule = comboBoxShedule.Text;
            String membership = comboBoxTime.Text;

            SqlConnection sql = new SqlConnection();
            //Implement data connection string
            sql.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pasin\\Desktop\\MyGymManager\\MyGymManager\\MyGymDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sql;
           

            cmd.CommandText = "INSERT INTO GymMembers(Fname,Lname,Gender,DOB,Mobile,JoinDate,Shedule,MemberShipTime)" + 
                "Values('"+ fname +"','"+lname + "','" + gender + "','" + dob + "','" + mobile + "','" + joindate + "','" + shedule + "','" + membership + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data Saved!");
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            //clear and rest data
            txtFirstName.Clear();
            txtLastName.Clear();
            comboBoxGender.ResetText();
            dateTimePickerDOB.Value=DateTime.Now;
            txtTelNum.Clear();
            dateTimeJoin.Value = DateTime.Now;
            comboBoxShedule.ResetText();
            comboBoxTime.ResetText();

        }
    }
}
