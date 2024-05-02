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
    public partial class CalibrationParameters : Form
    {
        public CalibrationParameters()
        {
            InitializeComponent();
            TreeNode parentNode = treeView1.Nodes.Add("Calibration");
            TreeNode basicInfo = parentNode.Nodes.Add("BasicInfo");

            treeView1.NodeMouseClick += treeView1_NodeMouseClick;


        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            panel1.Controls.Clear();
            BasicInfoParameters frm4 = new BasicInfoParameters();
            frm4.TopLevel = false;
            panel1.Controls.Add(frm4);
            frm4.Show();
        }

    }
}
