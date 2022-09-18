using prjMDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMDA.會員
{
    public partial class Frm會員登入 : Form
    {
        MDAEntities dbContext = new MDAEntities();
        //public string phone { get; set; }
        public Frm會員登入()
        {
            InitializeComponent();
        }
        

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string phone = txtPhone.Text;

            if (phone.Length != 10)
                lblPhone.Text = "請輸入手機號碼10碼";
            else
                lblPhone.Text = "";

            foreach (char n in phone)
            {
                if (!Int32.TryParse(n.ToString(), out _))
                    lblPhone.Text = "請輸入純數字";
            }
                        
        }

        private void frmMemStart_Load(object sender, EventArgs e)
        {
            lblPhone.Text = "請輸入手機";

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            CMember.phone = txtPhone.Text;

            會員Members member = (from m in this.dbContext.會員Members
                                where m.會員電話Cellphone.Equals(txtPhone.Text)
                                select m).FirstOrDefault();

            if (lblPhone.Text == "" && member == null)
            {
                frmMemNew fN = new frmMemNew();
                //fN.Owner = this;
                fN.Show();
                //this.Hide();
            }

            else if (lblPhone.Text == "" && member != null)
            {
                frmMemSign fS = new frmMemSign();
                //fS.Owner = this;
                fS.Show();
                //this.Hide();
            }
            else
                txtPhone.Focus();
        }
    }
}
