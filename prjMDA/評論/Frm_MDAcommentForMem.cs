using prjMDA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMDAComment
{
    public partial class Frm_MDAcommentForMem : Form
    {
        public Frm_MDAcommentForMem()
        {
            InitializeComponent();
        }
            MDAEntities dbMDA = new MDAEntities();
            //ImageToBinary image = new ImageToBinary();
            電影評論MovieComment tb電影評論 = new 電影評論MovieComment();

        private void btn_Show_Click(object sender, EventArgs e)
        {
            var q = from c in this.dbMDA.電影評論MovieComment
                    select c;

            this.dataGridView.DataSource = q.ToList();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //tb電影評論.評論標題Comment_Title = txt評論編號.Text;
            //tb電影評論.會員編號Member_ID = txt會員編號.Text;
            //tb電影評論.

        }
    }
}
