using prjMDA.Models;
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

namespace prjMDA.會員
{
    //77777
    public partial class frmMemManage : Form
    {
        List<string> gender = new List<string>() { "不公開", "男", "女", "多元性別" };
        List<string> formal = new List<string>() { "簡易會員", "正式會員" };
        List<string> permission = new List<string>() { "正常使用", "停權", "審核中", "管理員" };

        bool flagInformal = false;
        bool flagFormal = false;
        int _position = -1;
        //bool autoSelect = false;

        CMember mem = new CMember();
        MDAEntities dbContext = new MDAEntities();
        public frmMemManage()
        {
            InitializeComponent();
            foreach (string gen in gender)
                this.cmbGender.Items.Add(gen);
     
            foreach (string fo in formal)
                this.cmbFormal.Items.Add(fo);
       
            foreach (string per in permission)
                this.cmbPremission.Items.Add(per);
            

        }
        private void frmMemManage_Load(object sender, EventArgs e)
        {
            
            txtPhone.Text = "09";
            txtPsw.Text = "";
            txtNickname.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtBonus.Text = "0";

            cmbPremission.SelectedIndex = 0;    
            cmbGender.SelectedIndex = 0;    
            cmbFormal.SelectedIndex = 0;

            lblPhone.Text = "請輸入手機";
            lblEmail.Text = "請輸入Email";
            lblPsw.Text = "請輸入密碼";
            lblName.Text = "";
            lblNickname.Text = "";
            lblAddress.Text = "";
            lblBonus.Text = "";

            pictureBox1.Image = null;

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
            //if (autoSelect)
            //{
            //    autoSelect = false;
            //    return;
            //}
            if (member != null)
                lblPhone.Text = "用戶已存在";

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
                lblEmail.Text = "用戶已存在";

        }
        private void txtBonus_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(txtBonus.Text, out _))
                lblBonus.Text = "請輸入數字";
            else
                lblBonus.Text = "";
        }
        private void txtPsw_TextChanged(object sender, EventArgs e)
        {
            if (txtPsw.Text == "")
                lblPsw.Text = "請輸入密碼";
            else
                lblPsw.Text = "";
        }
        private void txtNickname_TextChanged(object sender, EventArgs e)
        {
            if (txtNickname.Text == "")
                lblNickname.Text = "請輸入暱稱";
            else
                lblNickname.Text = "";
        }
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
                lblAddress.Text = "請輸入地址";
            else
                lblAddress.Text = "";
        }
        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
                lblName.Text = "請輸入姓名";
            else
                lblName.Text = "";
        }
        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")
                lblName.Text = "請輸入姓名";
            else
                lblName.Text = "";
        }
        void validInformalCheck()
        {
            if (lblBonus.Text != "")
                txtBonus.Focus();

            if (lblPsw.Text != "")
                txtPsw.Focus();

            if (lblEmail.Text != "")
                txtEmail.Focus();

            if (lblPhone.Text != "")
                txtPhone.Focus();

            if (lblBonus.Text == "" && lblEmail.Text == "" && lblPhone.Text == "" && lblPsw.Text == "")
                flagInformal = true;
            else
                flagInformal = false;

        }
        void validFormalCheck()
        {
            if (lblAddress.Text != "")
                txtAddress.Focus();

            if (lblNickname.Text == "")
                txtNickname.Focus();

            if (lblName.Text != "")
                txtFirstName.Focus();

            if (lblAddress.Text == "" && lblNickname.Text == "" && lblName.Text == "")
                flagFormal = true;
            else
                flagFormal = false;

            //if((new DateTime()-dateTimePicker1.Value).Days<=365*18)

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            validFormalCheck();
            validInformalCheck();

            //MessageBox.Show(flagInformal + "," + flagFormal);

            if (cmbFormal.SelectedIndex == 0 && flagInformal)
            {
                會員Members m = new 會員Members
                {
                    會員電話Cellphone = this.txtPhone.Text,
                    電子信箱Email = this.txtEmail.Text,
                    密碼Password = this.txtPsw.Text,
                    姓氏L_Name = this.txtLastName.Text,
                    名字F_Name = this.txtFirstName.Text,
                    暱稱NickName = this.txtNickname.Text,
                    生日BirthDate = null,
                    性別Gender = null,
                    地址Address = this.txtAddress.Text,
                    正式會員Formal = false,
                    會員權限Permission = this.cmbPremission.SelectedIndex,
                    紅利點數Bonus = int.Parse(this.txtBonus.Text),
                    會員照片Image = null,
                    建立時間CreatedTime = dateTimePicker2.Value,

                };
                this.dbContext.會員Members.Add(m);
                this.dbContext.SaveChanges();
                refreshDataGridView();
                MessageBox.Show("簡易會員新增成功");
                flagFormal = false;
                flagInformal = false;

            }


            else if (cmbFormal.SelectedIndex == 1 && flagFormal && flagInformal)
            {
                validFormalCheck();

                byte[] bytes;
                if (this.pictureBox1.Image == null)
                    bytes = null;
                else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    bytes = ms.GetBuffer();
                }


                if (flagFormal && flagInformal)
                {
                    會員Members m = new 會員Members
                    {
                        會員電話Cellphone = this.txtPhone.Text,
                        電子信箱Email = this.txtEmail.Text,
                        密碼Password = this.txtPsw.Text,
                        姓氏L_Name = this.txtLastName.Text,
                        名字F_Name = this.txtFirstName.Text,
                        暱稱NickName = this.txtNickname.Text,
                        生日BirthDate = dateTimePicker1.Value,
                        性別Gender = this.cmbGender.SelectedIndex,
                        地址Address = this.txtAddress.Text,
                        正式會員Formal = true,
                        會員權限Permission = this.cmbPremission.SelectedIndex,
                        紅利點數Bonus = int.Parse(this.txtBonus.Text),
                        會員照片Image = bytes,
                        建立時間CreatedTime = dateTimePicker2.Value,

                    };
                    this.dbContext.會員Members.Add(m);
                    this.dbContext.SaveChanges();
                    refreshDataGridView();
                    MessageBox.Show("正式會員新增成功");
                    flagFormal = false;
                    flagInformal = false;
                }
                else
                    MessageBox.Show("資料有誤");

            }
            else
                MessageBox.Show("資料有誤");
        }
        void refreshDataGridView()
        {
            this.dataGridView1.DataSource = null;
            var q = from m in this.dbContext.會員Members
                    select new
                    {
                        m.會員編號Member_ID,
                        m.會員電話Cellphone,
                        m.電子信箱Email,
                        m.密碼Password,
                        m.正式會員Formal,
                        m.會員權限Permission,
                        m.姓氏L_Name,
                        m.名字F_Name,
                        m.暱稱NickName,
                        m.生日BirthDate,
                        m.性別Gender,
                        m.地址Address,
                        m.紅利點數Bonus,
                        m.建立時間CreatedTime,
                        m.會員照片Image
                    };

            this.dataGridView1.DataSource = q.ToList();
            setGridStyle();

        }

        private void btnChoosePic_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void cmbFormal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFormal.SelectedIndex == 1)
            {
                if(txtFirstName.Text==""||txtLastName.Text=="")
                    lblName.Text = "請輸入姓名";
                if(txtNickname.Text=="")
                    lblNickname.Text = "請輸入暱稱";
                if(txtAddress.Text=="")
                    lblAddress.Text = "請輸入地址";
            }
            else
            {
                lblName.Text = "";
                lblNickname.Text = "";
                lblAddress.Text = "";
            }
        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_position < 0)
                return;

            會員Members member = (from m in this.dbContext.會員Members
                     where m.會員電話Cellphone.Equals(txtPhone.Text)
                     select m).FirstOrDefault();
            if (member == null) return; //exit method

            //q.會員電話Cellphone= txtPhone.Text;
            member.電子信箱Email = this.txtEmail.Text;
            member.密碼Password = txtPsw.Text;
            member.姓氏L_Name = txtLastName.Text;
            member.名字F_Name = txtFirstName.Text;
            member.暱稱NickName = txtNickname.Text;
            member.地址Address = txtAddress.Text;
            member.紅利點數Bonus = Int32.Parse(txtBonus.Text);
            member.性別Gender = cmbGender.SelectedIndex;
            member.生日BirthDate = dateTimePicker1.Value;
            member.建立時間CreatedTime = dateTimePicker2.Value;
            if (cmbFormal.SelectedIndex == 0)
                member.正式會員Formal = false;
            else
                member.正式會員Formal = true;
            member.會員權限Permission = this.cmbPremission.SelectedIndex;            

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

            this.dbContext.SaveChanges();
            this.refreshDataGridView();
            MessageBox.Show("修改成功");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex; 
            this.pictureBox1.Image = null;
            string a = this.dataGridView1.Rows[_position].Cells[0].Value.ToString();

            會員Members q = this.dbContext.會員Members.Where(m => m.會員編號Member_ID.ToString()==a).FirstOrDefault();


            if (q.會員照片Image!= null)
                this.pictureBox1.Image = Image.FromStream(new MemoryStream(q.會員照片Image));
            txtPhone.Text = q.會員電話Cellphone;
            txtEmail.Text = q.電子信箱Email;
            txtPsw.Text = q.密碼Password;
            txtLastName.Text = q.姓氏L_Name;
            txtFirstName.Text = q.名字F_Name;
            txtNickname.Text = q.暱稱NickName;
            txtAddress.Text = q.地址Address;
            txtBonus.Text = q.紅利點數Bonus.ToString();
            dateTimePicker2.Value = q.建立時間CreatedTime;
            if (q.性別Gender!= null)
                cmbGender.SelectedIndex = (int)q.性別Gender;
            if (q.生日BirthDate != null)
                dateTimePicker1.Value = (DateTime)q.生日BirthDate;
            if (q.正式會員Formal == false)
                cmbFormal.SelectedIndex = 0;
            else
                cmbFormal.SelectedIndex = 1;
            if (q.會員權限Permission != null)
                cmbPremission.SelectedIndex = (int)q.會員權限Permission;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_position < 0)
                return;

            會員Members member = (from m in this.dbContext.會員Members
                                where m.會員電話Cellphone.Equals(txtPhone.Text)
                                select m).FirstOrDefault();
            if (member == null) return; //exit method

            this.dbContext.會員Members.Remove(member);
            this.dbContext.SaveChanges();
            this.refreshDataGridView();
            MessageBox.Show("刪除成功");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyW = txtKeyword.Text;
            if (keyW == "")
                return;


            var q = from m in dbContext.會員Members.AsEnumerable()
                    where m.名字F_Name.Contains(keyW) || m.姓氏L_Name.Contains(keyW) || m.暱稱NickName.Contains(keyW)
                    || m.會員電話Cellphone.Equals(keyW) || m.會員編號Member_ID.ToString().Equals(keyW)
                    || m.電子信箱Email.Contains(keyW) || m.地址Address.Contains(keyW)
                    select m;
            this.dataGridView1.DataSource = q.ToList();


        }
        private void setGridStyle()
        {
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 50;
            dataGridView1.Columns[5].Width = 50;
            dataGridView1.Columns[6].Width = 50;
            dataGridView1.Columns[7].Width = 50;
            dataGridView1.Columns[8].Width = 100;
            dataGridView1.Columns[9].Width = 100;
            dataGridView1.Columns[10].Width = 50;
            dataGridView1.Columns[11].Width = 200;
            dataGridView1.Columns[12].Width = 100;
            dataGridView1.Columns[13].Width = 50;
            dataGridView1.Columns[13].Width = 200;

            bool isColorChanged = false;
            Color bgColor;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                isColorChanged = !isColorChanged;
                bgColor = Color.LightBlue;
                if (isColorChanged)
                    bgColor = Color.WhiteSmoke;
                foreach (DataGridViewCell c in r.Cells)
                    c.Style.BackColor = bgColor;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            frmMemManage_Load(sender, e);
        }

        private void btnBuildInformal_Click(object sender, EventArgs e)
        {
            mem.buildInformalData();
        }
        private void btnBuildData_Click(object sender, EventArgs e)
        {
            mem.buildData();
        }
    }
}
