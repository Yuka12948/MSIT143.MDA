using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMDAComment.Models
{
    public partial class UserControlPics : UserControl
    {
        public UserControlPics()
        {
            InitializeComponent();
        }
        public Image us評論圖片get { get { return this.pBox評論圖片.Image; } }
        public string us圖片編號get { get { return this.lab圖片編號.Text; } }

        public PictureBox Del評論圖片 { get { return this.pBox刪除; }  set { this.pBox刪除 = value; } }
        public byte[] us評論圖片set
        {
            set
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(value);
                this.pBox評論圖片.Image = Image.FromStream(ms);
            }
        }
        internal string us圖片編號set
        {
            set { lab圖片編號.Text = value; }
        }

        private void pBox刪除_Click(object sender, EventArgs e)
        {
        }
    }
}
