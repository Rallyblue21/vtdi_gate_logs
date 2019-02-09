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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInForm logIn = new LogInForm();
            logIn.MdiParent = this;
            logIn.Show();
           
        }

        private void userManagermentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log In Clicked");
        }

        private void schedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log In Clicked");
        }

        private void alertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log In Clicked");
        }

        private void guestListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log In Clicked");
        }

        private void gateInOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log In Clicked");
        }

        private void gateReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log In Clicked");
        }

        private void userLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log In Clicked");
        }
    }
}
