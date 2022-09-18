using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMDA
{
    public partial class MDA_MDI : Form
    {
        public MDA_MDI()
        {
            InitializeComponent();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            導演系列 f = new 導演系列();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            演員系列 f = new 演員系列();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
    }
}
