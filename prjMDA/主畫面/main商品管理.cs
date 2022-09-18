using prjMDA;
using prjMDA.會員;
using ProjectMda;
using System;
using System.Windows.Forms;

namespace prjMDA
{
    public partial class Frm商品管理 : Form
    {        
        public Frm商品管理()
        {
            InitializeComponent();
            //this.Text = "會員管理";
            //this.Width = 1520;
            //this.Height = 950;

            //frmMemStart f = new frmMemStart();
            //f.ShowDialog();
        }

        private void toolStripLab商品_Click(object sender, EventArgs e)
        {

            Frm商品 frmMemManage = new Frm商品();
            frmMemManage.TopLevel = false;
            frmMemManage.Parent = this.splitContainer1.Panel2;
            frmMemManage.Show();
            frmMemManage.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(Frm商品) && f.GetType() != typeof(Frm商品管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab商品明細_Click(object sender, EventArgs e)
        {
            商品明細 frm = new 商品明細();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(商品明細) && f.GetType() != typeof(Frm商品管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab商品影城_Click(object sender, EventArgs e)
        {

            Frm商品影城 frmMemManage = new Frm商品影城();
            frmMemManage.TopLevel = false;
            frmMemManage.Parent = this.splitContainer1.Panel2;
            frmMemManage.Show();
            frmMemManage.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {

                if (f.GetType() != typeof(Frm商品影城) && f.GetType() != typeof(Frm商品管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab商品票種_Click(object sender, EventArgs e)
        {
            Frm商品票種 frmMemManage = new Frm商品票種();
            frmMemManage.TopLevel = false;
            frmMemManage.Parent = this.splitContainer1.Panel2;
            frmMemManage.Show();
            frmMemManage.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {

                if (f.GetType() != typeof(Frm商品票種) && f.GetType() != typeof(Frm商品管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab票價資訊_Click(object sender, EventArgs e)
        {
            Frm票價資訊 frm = new Frm票價資訊();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(Frm票價資訊) && f.GetType() != typeof(Frm商品管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab報表_Click(object sender, EventArgs e)
        {
            Frm報表 frm = new Frm報表();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(Frm報表) && f.GetType() != typeof(Frm商品管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }
    }
}
