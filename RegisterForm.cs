using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class RegisterForm : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
         MySqlCommand command;
        MySqlDataReader mdr;
        public RegisterForm()
        {
            InitializeComponent();
        }

        // ------ Load Time and Date ----------------------------------
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label9.Text = DateTime.Now.ToLongDateString();
            label10.Text = DateTime.Now.ToLongTimeString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        //--------------------------------------------------------------



        public void GetID()
        { 
            

            /*string getid;
            string query = "select ID from inforecord.userinfo order by ID Desc";

            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.Read())
            { int i = int.Parse(dr[0].ToString()) + 1;
                getid = i.ToString("000000");
            }
            else if(Convert.IsDBNull(dr))
            { getid = "000001"; }
            else
            { getid = "000001"; }
            connection.Close();

            WrkBox.Text = getid.ToString();

    */



        }

        
   

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

     

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            string selectQuery = "SELECT * FROM inforecord.userinfo WHERE Username = '" + textBox6.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                MessageBox.Show("Username not available!");
            }
            else
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=inforecord;";
                string iquery = "INSERT INTO  inforecord.userinfo(`ID`,`Name`, `IdentificationCard `, `Address`,`Nationality`, 'Status', 'Password') VALUES (NULL, '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + comboBox1.Text+ "', '" + textBox7.Text + "')";

                
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(iquery, databaseConnection);
                commandDatabase.CommandTimeout = 60;

                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    // Show any error message.
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Account Successfully Created!");


                // Jump page
                Form1 frm2 = new Form1();
                frm2.ShowDialog();
            }

            connection.Close();

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }
        }




        private void Clearbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

    }
}
