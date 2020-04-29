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
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;

        public Form1()
        {
            InitializeComponent();
            groupBox1.BackColor = Color.FromArgb(225, Color.Aqua); 
            

        }



        public static string username;

        public static string recby
        { get { return username; }
          set { username = value; }
        }



        private void submitbtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            string selectQuery = "SELECT * FROM inforecord.userinfo WHERE Username = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                recby = txtUsername.Text;
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                string Query = "update inforecord.userinfo set LastLogin='" + dateTimePicker1.Value + "' where Username='" + this.txtUsername.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();

                MessageBox.Show("Login Successful!");
                this.Hide();
                MenuForm frm2 = new MenuForm();
                frm2.ShowDialog();

            }
            else
            { 

                MessageBox.Show("Incorrect Login Information! Try again.");
            }

            connection.Close();

            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }

        }




        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            string selectQuery = "SELECT * FROM inforecord.userinfo WHERE Username = '" + txtUsername.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                MessageBox.Show("Username not available!");
            }
            else
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=inforecord;";
                string iquery = "INSERT INTO userinfo(`ID`,`Username`, `Password`, `DateCreated`,`LastLogin`) VALUES (NULL, '" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + dateTimePicker1.Value + "', '" + dateTimePicker1.Value + "')";

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
            }

            connection.Close();

            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }

        }








        private void exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }










        private void button1_Click(object sender, EventArgs e)
        {
            DBConnection();
        }

        private void DBConnection()
        {
            string ConnectString = "datasource = localhost; username = root; password =; database= inforecord; ";
            MySqlConnection DBConnect = new MySqlConnection(ConnectString);
            try
            {
                DBConnect.Open();
                MessageBox.Show("A connection to database is detected.");
            }
            catch (Exception e)
            { MessageBox.Show(e.Message); }
        }










        private void button3_Click(object sender, EventArgs e)
        {
            SupervisorForm frm2 = new SupervisorForm();
            frm2.ShowDialog();

        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            RegisterForm frm2 = new RegisterForm();
            frm2.ShowDialog();
        }

        private void OCRbtn_Click(object sender, EventArgs e)
        {
            OCR frm2 = new OCR();
            frm2.ShowDialog();

        }
    }
}
