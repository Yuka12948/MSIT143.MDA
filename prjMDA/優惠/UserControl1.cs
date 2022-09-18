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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public Image pic { get { return this.pictureBox1.Image; } }
        public string lab { get { return this.label1.Text; } }
        public PictureBox picbox
        { 
            get { return this.picBox2; }
            set { picBox2 = value; }
        }
        public byte[] Bytes
        {

            set
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(value);
                this.pictureBox1.Image = Image.FromStream(ms);
            }
        }
        internal string Desc
        {
            set { label1.Text = value; }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UserControl1 us = new UserControl1();
            us.Click += Us_Click;

        }

        private void Us_Click(object sender, EventArgs e)
        {
            UserControl1 num = sender as UserControl1;
            //num.lab
        }
    }
}
