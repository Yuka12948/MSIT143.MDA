using prjMDA;
using prjMDA.會員;
using System;
using System.Windows.Forms;

namespace prjMDA
{
    public partial class Frm會員管理 : Form
    {        
        public Frm會員管理()
        {
            InitializeComponent();
            //this.Text = "會員管理";
            //this.Width = 1520;
            //this.Height = 950;

            ////frmMemStart f = new frmMemStart();
            ////f.ShowDialog();
        }

        private void toolStripLab會員管理_Click(object sender, EventArgs e)
        {
            FrmMemSearch frm = new FrmMemSearch();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(會員.FrmMemSearch) && f.GetType() != typeof(Frm會員管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab會員增刪_Click(object sender, EventArgs e)
        {
            frmMemManage frmMemManage = new frmMemManage();
            frmMemManage.TopLevel = false;
            frmMemManage.Parent = this.splitContainer1.Panel2;
            frmMemManage.Show();
            frmMemManage.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(frmMemManage) && f.GetType() != typeof(Frm會員管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab檢舉管理_Click(object sender, EventArgs e)
        {
            frmReport frmReport = new frmReport();
            frmReport.TopLevel = false;
            frmReport.Parent = this.splitContainer1.Panel2;
            frmReport.Show();
            frmReport.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(frmReport) && f.GetType() != typeof(Frm會員管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab片單管理_Click(object sender, EventArgs e)
        {
            frmList frmList = new frmList();
            frmList.TopLevel = false;
            frmList.Parent = this.splitContainer1.Panel2;
            frmList.Show();
            frmList.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(frmList) && f.GetType() != typeof(Frm會員管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab報表_Click(object sender, EventArgs e)
        {
            frmMemChart frmt = new frmMemChart();
            frmt.TopLevel = false;
            frmt.Parent = this.splitContainer1.Panel2;
            frmt.Show();
            frmt.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(frmMemChart) && f.GetType() != typeof(Frm會員管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }
    }
}
