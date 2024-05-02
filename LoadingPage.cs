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
    public partial class LoadingPage : Form
    {
        public LoadingPage()
        {
            InitializeComponent();
        }

        private void LoadingPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value <100)
            {
                progressBar1.Value += 5;

                label2.Text = progressBar1.Value.ToString() + "%";
                
               

            }
            else
            {
                timer1.Stop();
                this.Hide();
                LoginPage frm = new LoginPage();
                frm.Show();
            }


            /*
            this.progressBar1.Increment(10);
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                LoginPage frm = new LoginPage();
                frm.Show();
            }
            else
            {
                timer1.Stop();
            }
             */

        }
    }
}
