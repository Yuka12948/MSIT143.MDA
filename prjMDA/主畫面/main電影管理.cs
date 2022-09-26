using prjMDA;
using prjMDA.會員;
using prjMDA.電影;
using System;
using System.Windows.Forms;

namespace prjMDA
{
    public partial class Frm電影管理 : Form
    {        
        public Frm電影管理()
        {
            InitializeComponent();
            //薇薇~薇薇~好棒棒!!
        }

        private void toolStripLab導演類_Click(object sender, EventArgs e)
        {
            導演類 frm = new 導演類();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(導演類) && f.GetType() != typeof(Frm電影管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab演員類_Click(object sender, EventArgs e)
        {

            演員類 frm = new 演員類();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(演員類) && f.GetType() != typeof(Frm電影管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab電影分級_Click(object sender, EventArgs e)
        {
            電影分級 frm = new 電影分級();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(電影分級) && f.GetType() != typeof(Frm電影管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab電影語言_Click(object sender, EventArgs e)
        {
            MovieLanguage frm = new MovieLanguage();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(MovieLanguage) && f.GetType() != typeof(Frm電影管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab電影代碼_Click(object sender, EventArgs e)
        {
            MovieCode frm = new MovieCode();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(MovieCode) && f.GetType() != typeof(Frm電影管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab電影圖片總表_Click(object sender, EventArgs e)
        {
            MovieImages frm = new MovieImages();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(MovieImages) && f.GetType() != typeof(Frm電影管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab電影圖片明細_Click(object sender, EventArgs e)
        {

            MovieIImagesList frm = new MovieIImagesList();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(MovieIImagesList) && f.GetType() != typeof(Frm電影管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab電影圖片_Click(object sender, EventArgs e)
        {
            電影圖片 frm = new 電影圖片();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(電影圖片) && f.GetType() != typeof(Frm電影管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void toolStripLab票房分析_Click(object sender, EventArgs e)
        {
            電影票房分析 frm = new 電影票房分析();
            frm.TopLevel = false;
            frm.Parent = this.splitContainer1.Panel2;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(電影票房分析) && f.GetType() != typeof(Frm電影管理) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
            
        }
    }
}
