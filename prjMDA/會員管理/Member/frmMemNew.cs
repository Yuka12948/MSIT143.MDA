using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMember
{
    public partial class frmMemNew : Form
    {
        bool flagInformal = false;

        MDAEntities dbContext = new MDAEntities();
        public frmMemNew()
        {
            InitializeComponent();
        }

        private void frmMemNew_Load(object sender, EventArgs e)
        {
            lblPhone.Text = "請輸入手機";
            lblEmail.Text = "請輸入Email";
            lblPsw.Text = "請輸入密碼";

            //CMember cMem = new CMember();
            txtPhone.Text = CMember.phone;
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

            會員Members member = (from m in this.dbContext.會員Members
                                where m.會員電話Cellphone.Equals(txtPhone.Text)
                                select m).FirstOrDefault();
            if (member != null)
                lblPhone.Text = "該帳號已存在";

        }
        static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (IsValidEmail(email) == false)
                lblEmail.Text = "請輸入正確格式";
            else
                lblEmail.Text = "";
            會員Members member = (from m in this.dbContext.會員Members
                                where m.電子信箱Email.Equals(txtEmail.Text)
                                select m).FirstOrDefault();
            if (member != null)
                lblEmail.Text = "該帳號已存在";

        }
        private void txtPsw_TextChanged(object sender, EventArgs e)
        {
            if (txtPsw.Text == "")
                lblPsw.Text = "請輸入密碼";
            else
                lblPsw.Text = "";
        }
        void validInformalCheck()
        {
            if (lblPsw.Text != "")
                txtPsw.Focus();

            if (lblEmail.Text != "")
                txtEmail.Focus();

            if (lblPhone.Text != "")
                txtPhone.Focus();

            if (lblEmail.Text == "" && lblPhone.Text == "" && lblPsw.Text == "")
                flagInformal = true;
            else
                flagInformal = false;

        }
        private void btnSign_Click(object sender, EventArgs e)
        {
            validInformalCheck();
               
            if (flagInformal)
            {
                會員Members m = new 會員Members
                {
                    會員電話Cellphone = this.txtPhone.Text,
                    電子信箱Email = this.txtEmail.Text,
                    密碼Password = this.txtPsw.Text,
                    姓氏L_Name = null,
                    名字F_Name = null,
                    暱稱NickName = null,
                    生日BirthDate = null,
                    性別Gender = null,
                    地址Address = null,
                    正式會員Formal = false,
                    會員權限Permission = 0,
                    紅利點數Bonus = null,
                    會員照片Image = null,

                };
                this.dbContext.會員Members.Add(m);
                this.dbContext.SaveChanges();
                
                MessageBox.Show("註冊成功\n到會員中心填寫完整會員資料，獲取更多優惠!");
                flagInformal = false;
                frmMemInfo fInfo = new frmMemInfo();
                fInfo.Show();
                this.Hide();

            }
        }
    }
}
