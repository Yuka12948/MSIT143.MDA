using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMember
{
    public partial class frmMemInfo : Form
    {
        MDAEntities dbContext = new MDAEntities();
        會員Members member;

        List<string> gender = new List<string>() { "不公開", "男", "女", "多元性別" };
        List<string> formal = new List<string>() { "簡易會員", "正式會員" };
        List<string> permission = new List<string>() { "正常使用", "停權", "審核中","管理員" };
        public frmMemInfo()
        {
            InitializeComponent();
            foreach (string gen in gender)
                this.cmbGender.Items.Add(gen);
            foreach (string fo in formal)
                this.cmbFormal.Items.Add(fo);
            foreach (string per in permission)
                this.cmbPremission.Items.Add(per);
            txtPhone.Enabled = false;
            cmbPremission.Enabled = false; 
            cmbFormal.Enabled = false;
        }

        private void frmMemInfo_Load(object sender, EventArgs e)
        {
            txtPhone.Text = CMember.phone;
           
            member = (from m in this.dbContext.會員Members
                                where m.會員電話Cellphone.Equals(txtPhone.Text)
                                select m).FirstOrDefault();
            txtEmail.Text = member.電子信箱Email;
            cmbPremission.SelectedIndex = (int)member.會員權限Permission;
            
            if (member.正式會員Formal == false)
                cmbFormal.SelectedIndex = 0;
            else
                cmbFormal.SelectedIndex = 1;           

            if (member.暱稱NickName != null)
                txtNickname.Text = member.暱稱NickName;
            if (member.姓氏L_Name != null)
                txtLastName.Text = member.姓氏L_Name;
            if (member.名字F_Name != null)
                txtFirstName.Text = member.名字F_Name;
            if (member.地址Address != null)
                txtAddress.Text = member.地址Address;
            if (member.生日BirthDate != null)
                dateTimePicker1.Value = (DateTime)member.生日BirthDate;
            if (member.性別Gender != null)
                cmbGender.SelectedIndex = (int)member.性別Gender;

            if (member.會員照片Image != null)
                pictureBox1.Image = Image.FromStream(new MemoryStream(member.會員照片Image));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lblEmail.Text != "" || (IsValidEmail(txtEmail.Text) == false))
            {
                txtEmail.Focus();
                lblEmail.Text = "請輸入正確格式";
                return;
            }
                
            member = (from m in this.dbContext.會員Members
                      where m.會員電話Cellphone.Equals(txtPhone.Text)
                      select m).FirstOrDefault(); 
            member.電子信箱Email = txtEmail.Text;
            member.姓氏L_Name = txtLastName.Text;
            member.名字F_Name = txtFirstName.Text;
            member.暱稱NickName = txtNickname.Text;
            member.地址Address = txtAddress.Text;
            member.性別Gender = cmbGender.SelectedIndex;
            member.生日BirthDate = dateTimePicker1.Value;

            byte[] bytes;
            if (this.pictureBox1.Image == null)
                bytes = null;
            else
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                this.pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                bytes = ms.GetBuffer();
            }
            member.會員照片Image = bytes;

            if (member.正式會員Formal == false && txtEmail.Text != null && txtLastName.Text != null && txtFirstName.Text != null && txtNickname.Text != null && txtAddress.Text != null && cmbGender.SelectedIndex != -1)
            {
                member.正式會員Formal = true;
                cmbFormal.SelectedIndex = 1;            
            }
            

            this.dbContext.SaveChanges();
            MessageBox.Show("修改成功");
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (IsValidEmail(email) == false)
                lblEmail.Text = "請輸入正確格式";
            else
                lblEmail.Text = "";            
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
       
    }
}
