using prjMDA;
using prjMDA.會員;
using System;
using System.Windows.Forms;

namespace prjMDA
{
    public partial class Frm優惠券管理 : Form
    {        
        public Frm優惠券管理()
        {
            InitializeComponent();
        }
        
        private void toolStripLab優惠券總表_Click(object sender, EventArgs e)
        {
            Frm優惠券總表 frm = new Frm優惠券總表();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(Frm優惠券總表) && f.GetType() != typeof(Frm優惠券管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab優惠券明細_Click(object sender, EventArgs e)
        {
            Frm優惠券明細 frm = new Frm優惠券明細();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(Frm優惠券明細) && f.GetType() != typeof(Frm優惠券管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

            優惠券分析 frm = new 優惠券分析();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(優惠券分析) && f.GetType() != typeof(Frm優惠券管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }
    }
}
