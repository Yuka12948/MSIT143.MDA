using prjMDA.Models;
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

namespace prjMDA.會員
{
    public partial class frmMemSign : Form
    {
        MDAEntities dbContext = new MDAEntities();
        public frmMemSign()
        {
            InitializeComponent();
        }
        
        private void frmMemSign_Load(object sender, EventArgs e)
        {
            //frmMemStart cMem = new frmMemStart();
            txtPhone.Text = CMember.phone;

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            會員Members member = (from m in this.dbContext.會員Members
                                where m.會員電話Cellphone.Equals(txtPhone.Text)
                                select m).FirstOrDefault();
            if (member.密碼Password == txtPassword.Text&&member.會員權限Permission==3)
            {
                Frm會員管理 f = new Frm會員管理();
                f.Show();
                //this.Hide();
            }
            else if(member.密碼Password == txtPassword.Text)
            {
                frmMemInfo fInfo = new frmMemInfo();
                fInfo.Show();
                //this.Hide();
            }
            else
                MessageBox.Show("密碼錯誤");
        }
        private void lblForget(object sender, EventArgs e)
        {

        }
    }
}
