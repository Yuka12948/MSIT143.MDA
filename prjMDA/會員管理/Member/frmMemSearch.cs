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

namespace prjMember.Member
{
    public partial class frmMemSearch : Form
    {
        List<string> gender = new List<string>() { "不公開", "男", "女", "多元性別" };
        List<string> formal = new List<string>() { "簡易會員", "正式會員" };
        List<string> permission = new List<string>() { "正常使用", "停權", "審核中", "管理員" };

        //object selMonMin;
        //object selMonMax;

        CMember mem = new CMember();
        MDAEntities dbContext = new MDAEntities();
        int _position = -1;
        public frmMemSearch()
        {
            InitializeComponent();
        }
        
        private void frmMemSearch_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
            foreach (string gen in gender)
            {
                this.cmbGender.Items.Add(gen);
                this.cmbGenderS.Items.Add(gen);
            }

            foreach (string fo in formal)
            {
                this.cmbFormal.Items.Add(fo);
                this.cmbFormalS.Items.Add(fo);
            }

            foreach (string per in permission)
            {
                this.cmbPremission.Items.Add(per);
                this.cmbPermissionS.Items.Add(per);
            }

            this.txtId.Enabled = false;
            this.txtPhone.Enabled = false;

            dateTimePickerMin.Checked = false;
            dateTimePickerMax.Checked = false;

            //for (int i = 1; i <= 12; i++)
            //{
            //    cmbMonMin.Items.Add(i);
            //    cmbMonMax.Items.Add(i);
            //}

            if (frmReport.isDetailClick)
            {
                txtId.Text = frmReport.memId.ToString();
                會員Members q = this.dbContext.會員Members
                    .Where(m => m.會員編號Member_ID == frmReport.memId).FirstOrDefault();
                
                if (q.會員照片Image != null)
                    this.pictureBox1.Image = Image.FromStream(new MemoryStream(q.會員照片Image));
                txtPhone.Text = q.會員電話Cellphone;
                txtEmail.Text = q.電子信箱Email;
                txtPsw.Text = q.密碼Password;
                txtLastName.Text = q.姓氏L_Name;
                txtFirstName.Text = q.名字F_Name;
                txtNickname.Text = q.暱稱NickName;
                txtAddress.Text = q.地址Address;
                txtBonus.Text = q.紅利點數Bonus.ToString();
                dateTimePickerCT.Value = q.建立時間CreatedTime;
                if (q.性別Gender != null)
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

        }
        
        void refreshDataGridView()
        {
            this.dataGridView1.DataSource = null;
            var q = from m in this.dbContext.會員Members
                    select new
                    {
                        會員編號=m.會員編號Member_ID,
                        電話=m.會員電話Cellphone,
                        電子信箱=m.電子信箱Email,
                        密碼=m.密碼Password,
                        正式會員=m.正式會員Formal,
                        權限=m.會員權限Permission,
                        姓氏=m.姓氏L_Name,
                        名字= m.名字F_Name,
                        暱稱=m.暱稱NickName,
                        生日=m.生日BirthDate,
                        性別=m.性別Gender,
                        地址=m.地址Address,
                        紅利=m.紅利點數Bonus,
                        建立時間=m.建立時間CreatedTime,
                        照片= m.會員照片Image
                    };

            this.dataGridView1.DataSource = q.ToList();
            setGridStyle();

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
            dataGridView1.Columns[11].Width = 100;
            dataGridView1.Columns[12].Width = 100;
            dataGridView1.Columns[13].Width = 50;
            dataGridView1.Columns[14].Width = 200;

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
        private void cmbPremission_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            refreshDataGridView();
        }
        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string add = txtAddressS.Text;
            string boMin = txtBonusMin.Text;
            string boMax = txtBonusMax.Text;
            string keyW = txtKeyword.Text;
            //string moMin = cmbMonMin.SelectedItem.ToString();
            //string moMax = cmbMonMax.SelectedItem.ToString();
            string moMin = txtMonMin.Text;
            string moMax = txtMonMax.Text;
            int formal = cmbFormalS.SelectedIndex;
            int per = cmbPermissionS.SelectedIndex;
            int gen = cmbGenderS.SelectedIndex;
            string yMax = txtYearMax.Text;
            string yMin = txtYearMin.Text;
            DateTime dMin = dateTimePickerMin.Value;
            DateTime dMax = dateTimePickerMax.Value;
            
            //string dMinS = dMin.ToShortDateString();
            //string dMaxS = (dMax.AddDays(1)).ToShortDateString();

            bool fo =false;
            if (formal == 0)
                fo = false;
            else if (formal == 1)
                fo = true;

            var q = this.dbContext.會員Members.AsEnumerable().Select(m => m);

            if (formal >= 0)
            {
                q = q.Where(m => m.正式會員Formal == fo);
            }
            if(per>=0)
            {
                q = q.Where(m => m.會員權限Permission == per);
            }
            if(gen>=0)
            {
                q = q.Where(m => m.性別Gender == gen);
            }
            if(add!="")
            {
                q = q.Where(m => m.地址Address.Contains(add));
            }
            if(yMax!=""&&yMin=="")
            {
                q = q.Where(m => m.生日BirthDate != null)
                    .Where(m => m.生日BirthDate.Value.Year <= Int32.Parse(yMax));
            }
            if(yMax == "" && yMin != "")
            {
                q = q.Where(m => m.生日BirthDate != null)
                    .Where(m => m.生日BirthDate.Value.Year >= Int32.Parse(yMin));
            }
            if (yMax!=""&&yMin!="")
            {
                q = q.Where(m => m.生日BirthDate!=null)
                    .Where(m => m.生日BirthDate.Value.Year >= Int32.Parse(yMin) && m.生日BirthDate.Value.Year <= Int32.Parse(yMax));
            }
            if (moMin !="" && moMax== "")
            {
                int mon = Int32.Parse(moMin);
                q = q.Where(m => m.生日BirthDate != null)
                    .Where(m => m.生日BirthDate.Value.Month >= mon);
            }
            if (moMin == "" && moMax != "")
            {
                int mon = Int32.Parse(moMax);
                q = q.Where(m => m.生日BirthDate != null)
                    .Where(m => m.生日BirthDate.Value.Month <= mon);
            }
            if (moMin!= "" && moMax!= "")
            {
                int mon1 = Int32.Parse(moMin);
                int mon2 = Int32.Parse(moMax);

                q = q.Where(m => m.生日BirthDate != null)
                    .Where(m => m.生日BirthDate.Value.Month >= mon1
                    && m.生日BirthDate.Value.Month <= mon2);
            }
            if (dMin > dMax)
            {
                DateTime d = dMax;
                dMax = dMin;
                dMin = d;
            }
            if (dateTimePickerMax.Checked == true && dateTimePickerMin.Checked == true)
            {
                q = q.Where(m => m.建立時間CreatedTime >= DateTime.Parse(dMin.ToShortDateString()) 
                && m.建立時間CreatedTime <= DateTime.Parse(dMax.ToShortDateString()));
            }
            if(dateTimePickerMax.Checked == false && dateTimePickerMin.Checked == true)
            {
                q = q.Where(m => m.建立時間CreatedTime >= DateTime.Parse(dMin.ToShortDateString()));
            }
            if (dateTimePickerMax.Checked == true && dateTimePickerMin.Checked == false)
            {
                q = q.Where(m => m.建立時間CreatedTime <= DateTime.Parse(dMax.ToShortDateString()));
            }
            if (boMax == "" && boMin != "")
            {
                q = q.Where(m => m.紅利點數Bonus >= Int32.Parse(boMin));
            }
            if (boMax != "" && boMin == "")
            {
                q = q.Where(m => m.紅利點數Bonus <= Int32.Parse(boMax));
            }
            if (boMax!=""&&boMin!="")
            {
                q = q.Where(m => m.紅利點數Bonus >= Int32.Parse(boMin) && m.紅利點數Bonus <= Int32.Parse(boMax));
            }

            if(keyW!="")
            {
                q = q.Where(m => m.名字F_Name.Contains(keyW)
                  || m.姓氏L_Name.ToUpper().Contains(keyW.ToUpper())
                  || m.暱稱NickName.ToUpper().Contains(keyW.ToUpper())
                  || m.會員電話Cellphone.ToString().Equals(keyW)
                  || m.會員編號Member_ID.ToString().Equals(keyW)
                  || m.電子信箱Email.ToUpper().Contains(keyW.ToUpper()));
            }

            //if (q.ToList()== null)
            //{
            //    MessageBox.Show("查無結果");
            //    return;
            //}
            //else
            q.Select(m => new
            {
                會員編號 = m.會員編號Member_ID,
                電話 = m.會員電話Cellphone,
                電子信箱 = m.電子信箱Email,
                密碼 = m.密碼Password,
                正式會員 = m.正式會員Formal,
                權限 = m.會員權限Permission,
                姓氏 = m.姓氏L_Name,
                名字 = m.名字F_Name,
                暱稱 = m.暱稱NickName,
                生日 = m.生日BirthDate,
                性別 = m.性別Gender,
                地址 = m.地址Address,
                紅利 = m.紅利點數Bonus,
                建立時間 = m.建立時間CreatedTime,
                照片 = m.會員照片Image
            });
            dataGridView1.DataSource = q.ToList();
            setGridStyle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
            this.pictureBox1.Image = null;
            string a = this.dataGridView1.Rows[_position].Cells[0].Value.ToString();

            會員Members q = this.dbContext.會員Members.Where(m => m.會員編號Member_ID.ToString() == a).FirstOrDefault();


            if (q.會員照片Image != null)
                this.pictureBox1.Image = Image.FromStream(new MemoryStream(q.會員照片Image));
            txtId.Text = q.會員編號Member_ID.ToString();
            txtPhone.Text = q.會員電話Cellphone;
            txtEmail.Text = q.電子信箱Email;
            txtPsw.Text = q.密碼Password;
            txtLastName.Text = q.姓氏L_Name;
            txtFirstName.Text = q.名字F_Name;
            txtNickname.Text = q.暱稱NickName;
            txtAddress.Text = q.地址Address;
            txtBonus.Text = q.紅利點數Bonus.ToString();
            dateTimePickerCT.Value = q.建立時間CreatedTime;
            if (q.性別Gender != null)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            

            會員Members member = (from m in this.dbContext.會員Members
                                where m.會員編號Member_ID.Equals(id)
                                select m).FirstOrDefault();
            if (member == null) return; 

            member.電子信箱Email = txtEmail.Text;
            member.密碼Password = txtPsw.Text;
            member.姓氏L_Name = txtLastName.Text;
            member.名字F_Name = txtFirstName.Text;
            member.暱稱NickName = txtNickname.Text;
            member.地址Address = txtAddress.Text;
            member.紅利點數Bonus = Int32.Parse(txtBonus.Text);
            member.性別Gender = cmbGender.SelectedIndex;
            member.生日BirthDate = dateTimePicker1.Value;
            member.建立時間CreatedTime = dateTimePickerCT.Value;
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

        private void btnChoosePic_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnDelPic_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = null;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //cmbMonMin.SelectedItem = null;
            //cmbMonMax.SelectedItem = null;
            
            //cmbMonMin.Items.Clear();
            //cmbMonMax.Items.Clear();
            //for (int i = 1; i <= 12; i++)
            //{
            //    cmbMonMin.Items.Add(i);
            //    cmbMonMax.Items.Add(i);
            //}
            cmbFormalS.SelectedItem = null;
            cmbPermissionS.SelectedItem = null;
            cmbGenderS.SelectedItem = null;
            
            txtMonMin.Text = "";
            txtMonMax.Text = "";

            txtAddressS.Text = "";
            txtKeyword.Text = "";
            txtBonusMax.Text = "";
            txtBonusMin.Text = "";
            txtYearMax.Text = "";
            txtYearMin.Text = "";            

            refreshDataGridView();

        }

        //private void cmbMonMin_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    object s = cmbMonMin.SelectedItem;
        //    selMonMin = s;
        //    if (s == null) return;

        //    int min = Int32.Parse(s.ToString());
            
        //    cmbMonMax.Items.Clear();
        //    for (int i = min; i <= 12; i++)
        //        cmbMonMax.Items.Add(i);
        //     cmbMonMax.SelectedItem = selMonMax;


        //}

        //private void cmbMonMax_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    object s = cmbMonMax.SelectedItem;
        //    selMonMax = s;
        //    if (s == null) return;

        //    cmbMonMin.Items.Clear();
        //    int max = Int32.Parse(s.ToString());
        //    for (int i = 1; i <= max; i++)
        //        cmbMonMin.Items.Add(i);
        //    cmbMonMin.SelectedItem = selMonMin;
        //}

        private void btnDel_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            if (_position < 0)
                return;

            會員Members member = (from m in this.dbContext.會員Members
                                where m.會員編號Member_ID.Equals(id)
                                select m).FirstOrDefault();
            if (member == null) return;

            this.dbContext.會員Members.Remove(member);
            this.dbContext.SaveChanges();
            this.refreshDataGridView();
            MessageBox.Show("刪除成功");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBonusPlus f = new frmBonusPlus();
            f.Text = "新增紅利作業";
            f.ShowDialog();

            if (f.isOkButtonClicked)
            {
                List<int> ids = new List<int>();
                foreach (DataGridViewRow r in dataGridView1.Rows)
                    ids.Add(Int32.Parse(r.Cells[0].Value.ToString()));

                foreach (int id in ids)
                {
                    會員Members q = this.dbContext.會員Members.AsEnumerable()
                        .Where(m => m.會員編號Member_ID.Equals(id)).FirstOrDefault();
                    q.紅利點數Bonus = q.紅利點數Bonus + f.bonus;
                    this.dbContext.SaveChanges();
                }
                //refreshDataGridView();
                MessageBox.Show("新增紅利成功");
            }
            
        }

        
    }
}
