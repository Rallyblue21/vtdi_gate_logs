using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtdi_gate_logs
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void Log_In_Form_Click(object sender, EventArgs e)
        {
            LogInForm logIn = new LogInForm();
            logIn.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            String UserName = TbUserName.Text;
            var Password = tbPassword.Text;
            if (String.IsNullOrEmpty(Password) ||
                String.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please enter values!");
            }
            else if (UserName == "admin" &&
                String.Equals("admin", Password))
            {
                MessageBox.Show($"Welcome {UserName}");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Credentails Enter");
            }
                           
            }

        private void tbnReset_Click(object sender, EventArgs e)
        {
            TbUserName.Text = null;
            tbPassword.Text = null;
        }
       
    }
}


        


