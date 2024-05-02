using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECUProject2
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnCalibration_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CalibrationParameters frm2 = new CalibrationParameters();
            frm2.TopLevel = false;
            panel1.Controls.Add(frm2);
            frm2.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Settings frm3 = new Settings();
            frm3.TopLevel = false;
            panel1.Controls.Add(frm3);
            frm3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome logged username: " + global.Email_Id);
            lbl_loguser.Text = "WELCOME : " + global.Email_Id;
        }
    }
}
