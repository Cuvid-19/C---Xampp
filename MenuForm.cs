using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void EmpBtn_Click(object sender, EventArgs e)
        {
            EmployeeForm frm2 = new EmployeeForm();
            frm2.ShowDialog();
        }

        private void SupBtn_Click(object sender, EventArgs e)
        {
            SupervisorForm frm2 = new SupervisorForm();
            frm2.ShowDialog();
        }

        private void OCRBtn_Click(object sender, EventArgs e)
        {
            OCR frm2 = new OCR();
            frm2.ShowDialog();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }
    }
}
