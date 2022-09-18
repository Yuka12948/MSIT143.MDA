using prjMDA;
using prjMDA.會員;
using prjMDAComment;
using System;
using System.Windows.Forms;

namespace prjMDA
{
    public partial class Frm評論管理 : Form
    {        
        public Frm評論管理()
        {
            InitializeComponent();           
        }

        private void toolStripLab評論管理_Click(object sender, EventArgs e)
        {
            Frm評論 frm = new Frm評論();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {

                if (f.GetType() != typeof(Frm評論) && f.GetType() != typeof(Frm評論管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab檢舉管理_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(frmReport) && f.GetType() != typeof(Frm評論管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab評論分析_Click(object sender, EventArgs e)
        {
            Frm_MDA評論分析 frm = new Frm_MDA評論分析();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(Frm_MDA評論分析) && f.GetType() != typeof(Frm評論管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }
    }
}
