using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjMDA;

namespace prjMDA
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovieImages movieImages = new MovieImages();
            movieImages.TopLevel = false;
            movieImages.Parent = this.splitContainer1.Panel2;
            movieImages.Show();
            movieImages.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {

                if (f.GetType() != typeof(MovieImages) && f.GetType() != typeof(FormMain)&&f.GetType()!= typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MovieIImagesList movieIImagesList = new MovieIImagesList();
            movieIImagesList.TopLevel = false;
            movieIImagesList.Parent = this.splitContainer1.Panel2;
            movieIImagesList.Show();
            movieIImagesList.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {

                if (f.GetType() != typeof(MovieIImagesList) && f.GetType() != typeof(FormMain) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MovieImages movieImages = new MovieImages();
            movieImages.TopLevel = false;
            movieImages.Parent = this.splitContainer1.Panel2;
            movieImages.Show();
            movieImages.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {

                if (f.GetType() != typeof(MovieImages) && f.GetType() != typeof(FormMain) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MovieCode movieCode = new MovieCode();
            movieCode.TopLevel = false;
            movieCode.Parent = this.splitContainer1.Panel2;
            movieCode.Show();
            movieCode.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {

                if (f.GetType() != typeof(MovieCode) && f.GetType() != typeof(FormMain) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm優惠券總表 coupon = new Frm優惠券總表();
            coupon.TopLevel = false;
            coupon.Parent = this.splitContainer1.Panel2;
            coupon.Show();
            coupon.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {

                if (f.GetType() != typeof(Frm優惠券總表) && f.GetType() != typeof(FormMain) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm優惠券明細 couponList = new Frm優惠券明細();
            couponList.TopLevel = false;
            couponList.Parent = this.splitContainer1.Panel2;
            couponList.Show();
            couponList.WindowState = FormWindowState.Maximized;
            foreach (Form f in Application.OpenForms)
            {

                if (f.GetType() != typeof(Frm優惠券明細) && f.GetType() != typeof(FormMain) && f.GetType() != typeof(MDA))
                {
                    f.Close();
                    return;
                }
            }
        }
    }
 }

