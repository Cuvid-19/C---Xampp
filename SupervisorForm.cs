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
    public partial class SupervisorForm : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        //MySqlDataReader mdr;
        MySqlDataAdapter adpt;
        DataTable dt;
        int index;
        MySqlCommandBuilder cmdbl;
        DataSet ds;



        public SupervisorForm()
        {
            InitializeComponent();


            LeaveConnection();
            OvertimeConnection();
        }


        //---------------------------------------------------
        //---------------------------------------------------
        //-----------    Supervisor Leave Section  ----------------------
        //---------------------------------------------------
        private void LeaveConnection()
        {
            adpt = new MySqlDataAdapter("SELECT * FROM inforecord.leavetable", connection);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                textBox1.Text = selectedRow.Cells[0].Value.ToString();
                textBox2.Text = selectedRow.Cells[1].Value.ToString();
                textBox3.Text = selectedRow.Cells[2].Value.ToString();
                textBox4.Text = selectedRow.Cells[3].Value.ToString();
                textBox5.Text = selectedRow.Cells[4].Value.ToString();
                textBox6.Text = selectedRow.Cells[5].Value.ToString();
                DayBox.Text = selectedRow.Cells[6].Value.ToString();
            }
            catch { MessageBox.Show("Please don't double click."); }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "update inforecord.leavetable SET LeaveStatus = @leavestatus ";
                command.Parameters.AddWithValue("@leavestatus", DayBox.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Update Success");
                LeaveConnection();
            }
            catch
            { MessageBox.Show("Something wrong"); }

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }













        //------------------------------------------------------
        //-------------------------------------------------------
        //---------   Supervisor Overtime Section  --------------------
        //---------------------------------------------------
        private void OvertimeConnection()
        {
            adpt = new MySqlDataAdapter("SELECT * FROM inforecord.overtimetable", connection);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView2.DataSource = dt;
        }

       
      

    





    }
}
