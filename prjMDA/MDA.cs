using prjMDA.Models;
using prjMDA.會員;
using prjMDA.電影;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 電影院;

namespace prjMDA
{
    public partial class MDA : Form
    {
        public MDA()
        {
            InitializeComponent();
            toolStrip1.Renderer = new MDASr();
        }

        private void toolStripBtn電影管理_Click(object sender, EventArgs e)
        {
            Frm電影管理 frm = new Frm電影管理();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(Frm電影管理) &&  f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripBtn電影院管理_Click(object sender, EventArgs e)
        {
            Frm電影院管理 frm = new Frm電影院管理();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(Frm電影院管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripBtn商品管理_Click(object sender, EventArgs e)
        {
            Frm商品管理 frm = new Frm商品管理();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(Frm商品管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripBtn會員管理_Click(object sender, EventArgs e)
        {
            Frm會員管理 frm = new Frm會員管理();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(Frm會員管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripBtn優惠管理_Click(object sender, EventArgs e)
        {
            Frm優惠券管理 frm = new Frm優惠券管理();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(Frm優惠券管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripBtn評論管理_Click(object sender, EventArgs e)
        {
            Frm評論管理 frm = new Frm評論管理();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(Frm評論管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripBtn會員登入_Click(object sender, EventArgs e)
        {
            Frm會員登入 frm = new Frm會員登入();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(Frm會員登入) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }
    }
}
