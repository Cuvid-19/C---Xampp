using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class EmployeeForm : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;
        MySqlDataAdapter adpt;
        DataTable dt;


        public EmployeeForm()
        {
            InitializeComponent();
            DayBox.Items.Add("Full Day");
            DayBox.Items.Add("Half Day");


            LeaveConnection();
            OvertimeConnection();
        }


        // Load Username
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            namelabel.Text = Form1.recby;
           

        }


        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }





        //---------------------------------------------------
        //---------------------------------------------------
        //-----------    Leave Section  ----------------------
        //---------------------------------------------------
        private void ApplyLeaveBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            string Query = "INSERT INTO inforecord.leavetable( LeaveCases, LeaveStatus, DateCreated  , Day, LeaveStarted, LeaveEnded, Name) VALUES('"+label17.Text+"',   '" + label16.Text + "' ,'" + dateCreated.Text + "' , '" + DayBox.Text + "' , '" + LeaveStart.Text + "' ,'" + LeaveEnd.Text + "', '"+ namelabel.Text + "'   )";
            command = new MySqlCommand(Query, connection);
            mdr = command.ExecuteReader();
            connection.Close();
            MessageBox.Show("The data has been submited");
        }

        private void LeaveConnection()
        {
            adpt = new MySqlDataAdapter("SELECT * FROM inforecord.leavetable", connection);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

     






        private void Deletebtn_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                bool delete = (bool)dataGridView1.Rows[i].Cells[6].Value;

                // if the checkbox cell is checked

                if (delete == true)
                {
                    DataGridViewRow rowToRemove = dataGridView1.Rows[i];

                    dataGridView1.Rows.Remove(rowToRemove);
                }
            }
        }



        //---------------------------------------------------
        //---------------------------------------------------
        //-----------Overtime Section 
        //---------------------------------------------------
        private void ApplyOvertimeBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            string Query = "INSERT INTO inforecord.overtimetable( OTCreatedBy, OTStarted, OTEnded, OTDateCreated) VALUES('" + namelabel.Text + "' , '" + OTstart.Text + "' , '" + OTEnd.Text + "' ,'" + dateCreate2.Text + "')";
            command = new MySqlCommand(Query, connection);
            mdr = command.ExecuteReader();
            connection.Close();
            MessageBox.Show("The data has been submited");
        }

        private void OvertimeConnection()
        {
            adpt = new MySqlDataAdapter("SELECT * FROM inforecord.overtimetable", connection);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView2.DataSource = dt;
        }

       
    }
}
