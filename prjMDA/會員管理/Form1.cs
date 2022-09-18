using prjMember.Member;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMember
{
    public partial class Form1 : Form
    {
        Form activeForm = null;
        public Form1()
        {
            InitializeComponent();
            this.Text = "會員管理";
            this.Width = 1520;
            this.Height = 950;

            //frmMemStart f = new frmMemStart();
            //f.ShowDialog();
        }

        void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.MdiParent = this;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }
        //https://lillylovecode.medium.com/c-%E5%AD%90%E6%AF%8D%E8%A1%A8%E5%96%AE-windows-form-app-e38e1610fba6
        //https://dotblogs.com.tw/jeff-yeh/2010/01/04/12799
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            openChildForm(new frmMemManage());
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            openChildForm(new frmList());
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            //openChildForm(new frmFollowMem());
        }

        private void toolStripLabel7_Click(object sender, EventArgs e)
        {
            frmReport.isDetailClick = false;
            openChildForm(new frmMemSearch());
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            openChildForm(new frmReport());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
