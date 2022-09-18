using prjMDA;
using prjMDA.會員;
using prjMDA.編輯視窗;
using System;
using System.Windows.Forms;
using 電影院;

namespace prjMDA
{
    public partial class Frm電影院管理 : Form
    {        
        public Frm電影院管理()
        {
            InitializeComponent();            
        }

        private void toolStripLab影城_Click(object sender, EventArgs e)
        {
            Frm影城 frm = new Frm影城();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(Frm影城) && f.GetType() != typeof(Frm電影院管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab電影院_Click(object sender, EventArgs e)
        {
            電影院 frm = new 電影院();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(電影院) && f.GetType() != typeof(Frm電影院管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab影廳_Click(object sender, EventArgs e)
        {
            影廳 frm = new 影廳();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(影廳) && f.GetType() != typeof(Frm電影院管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab電影場次_Click(object sender, EventArgs e)
        {
            Frm電影場次 frm = new Frm電影場次();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(Frm電影場次) && f.GetType() != typeof(Frm電影院管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab座位資訊_Click(object sender, EventArgs e)
        {
            Frm座位資訊 frm = new Frm座位資訊();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(Frm座位資訊) && f.GetType() != typeof(Frm電影院管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab座位編輯_Click(object sender, EventArgs e)
        {
            Frm座位編輯 frm = new Frm座位編輯();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(Frm座位編輯) && f.GetType() != typeof(Frm電影院管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab座位顯示_Click(object sender, EventArgs e)
        {
            Frm座位顯示 frm = new Frm座位顯示();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(Frm座位顯示) && f.GetType() != typeof(Frm電影院管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab影城票價資訊_Click(object sender, EventArgs e)
        {
            影城票價資訊 frm = new 影城票價資訊();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(影城票價資訊) && f.GetType() != typeof(Frm電影院管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }
    }
}
