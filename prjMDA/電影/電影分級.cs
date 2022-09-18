using prjMDA;
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

namespace prjMDA.電影
{
    public partial class 電影分級 : Form
    {
        public 電影分級()
        {
            InitializeComponent();
        }

        MDAEntities dbMDA = new MDAEntities();
        ImageToBinary image = new ImageToBinary();
        電影分級MovieRating tb電影分級 = new 電影分級MovieRating();
        國家總表Countrys tb國家總表 = new 國家總表Countrys();


        private void DataGridView刷新分級()
        {
            this.dataGridView分級.DataSource = null;
            this.dataGridView分級.DataSource = this.dbMDA.電影分級MovieRating.ToList();
        }

        private void DataGridView刷新國家()
        {
            this.dataGridView國家.DataSource = null;
            this.dataGridView國家.DataSource = this.dbMDA.國家總表Countrys.ToList();
        }

        public void setGridStyle分級()
        {
            dataGridView分級.Columns[0].Width = 65; //欄寬
            dataGridView分級.Columns[1].Width = 65;
            dataGridView分級.Columns[2].Width = 130;
            dataGridView分級.Columns[3].Width = 120;

            bool isColorChange = false;
            Color bgColor; //1.宣告顏色紀錄器
            foreach (DataGridViewRow r in dataGridView分級.Rows) //2.搜尋每一列Row
            {
                isColorChange = !isColorChange; //3.當Row顏色變更時繼續執行
                bgColor = Color.AliceBlue; //4.設定資料行背景色
                //r.DefaultCellStyle.BackColor = Color.SeaShell;
                if (isColorChange)
                    bgColor = Color.White;//4.設定資料行背景色
                //r.DefaultCellStyle.BackColor = Color.AliceBlue;

                foreach (DataGridViewCell c in r.Cells)
                    c.Style.BackColor = bgColor; //5.將關鍵字搜尋改色的Cell恢復自訂背景色
            }
        }

        public void setGridStyle國家()
        {
            dataGridView國家.Columns[0].Width = 65; //欄寬
            dataGridView國家.Columns[1].Width = 65;
            dataGridView國家.Columns[2].Width = 130;
            dataGridView國家.Columns[3].Width = 120;

            bool isColorChange = false;
            Color bgColor; //1.宣告顏色紀錄器
            foreach (DataGridViewRow r in dataGridView國家.Rows) //2.搜尋每一列Row
            {
                isColorChange = !isColorChange; //3.當Row顏色變更時繼續執行
                bgColor = Color.AliceBlue; //4.設定資料行背景色
                //r.DefaultCellStyle.BackColor = Color.SeaShell;
                if (isColorChange)
                    bgColor = Color.White;//4.設定資料行背景色
                //r.DefaultCellStyle.BackColor = Color.AliceBlue;

                foreach (DataGridViewCell c in r.Cells)
                    c.Style.BackColor = bgColor; //5.將關鍵字搜尋改色的Cell恢復自訂背景色
            }
        }

        private void btn_Show分級_Click(object sender, EventArgs e) //檢視
        {
            var q = from r in this.dbMDA.電影分級MovieRating
                    select r;

            this.dataGridView分級.DataSource = q.ToList();
            setGridStyle分級();
        }

        private void btnInsert分級_Click(object sender, EventArgs e)
        {
            if (txt分級編號.Text == "" || txt分級級數.Text == "" || txt分級說明.Text == "")
                return;

            tb電影分級.分級編號Rating_ID = Convert.ToInt32(txt分級編號.Text);
            tb電影分級.分級級數Rating_Level = txt分級級數.Text;
            tb電影分級.分級說明Rating_illustrate = txt分級說明.Text;
            tb電影分級.分級圖片Rating_Image = image.ConvertToByte(picBoxUpDate分級.Image);

            this.dbMDA.電影分級MovieRating.Add(tb電影分級); //資料新增
            this.dbMDA.SaveChanges(); //資料存進資料庫
            this.DataGridView刷新分級(); //DataGridView刷新
            MessageBox.Show($"新增成功\n分級編號:{txt分級編號.Text}\n分級級數:{txt分級級數.Text}\n分級說明{txt分級說明.Text}");
        }

        private void btnUpdate分級_Click(object sender, EventArgs e)
        {
            if (txt分級編號.Text == "" || txt分級級數.Text == "" || txt分級說明.Text == "")
                return;
            var q = (from r in this.dbMDA.電影分級MovieRating.AsEnumerable()
                     where r.分級編號Rating_ID == Convert.ToInt32(txt分級編號.Text) //比對txtbox與DataGridView欄位資料
                     select r).FirstOrDefault(); //傳回第一筆

            if (q == null)
                return;

            if (q.分級圖片Rating_Image != null) //防呆 沒有圖片時存空值
            {
                q.分級圖片Rating_Image = null;
                this.dbMDA.SaveChanges();
            }

            q.分級級數Rating_Level = txt分級級數.Text;
            q.分級說明Rating_illustrate = txt分級說明.Text;
            q.分級圖片Rating_Image = image.ConvertToByte(picBoxUpDate分級.Image);

            this.dbMDA.SaveChanges();
            this.DataGridView刷新分級();
            MessageBox.Show($"修改成功\n分級編號:{txt分級編號.Text}\n分級級數:{txt分級級數.Text}\n分級說明:{txt分級說明.Text}");
        }

        private void btn_Browse分級_Click(object sender, EventArgs e) //上傳圖片
        {
            var filePath = string.Empty;
            OpenFileDialog OPfile = new OpenFileDialog();

            OPfile.FileName = "";
            OPfile.Multiselect = false; //該值確定是否可以選擇多個檔案
            OPfile.Title = "開啟檔案";
            OPfile.Filter = "所有檔案 (*.*)|*.*|" +
                            "Png (*.png;*.pns)|*.png;*.pns|" +
                            "Jpeg (*.jpg;*.jpeg;*.jpe)|*.jpg;*.jpeg;*.jpe"; //設定要選擇的檔案的型別
            OPfile.FilterIndex = 2;
            OPfile.RestoreDirectory = true;

            if (OPfile.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = OPfile.FileName;
                //Read the contents of the file into a stream
                var fileStream = OPfile.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    picBoxUpDate分級.Width = Image.FromFile(OPfile.FileName).Width;
                    picBoxUpDate分級.Height = Image.FromFile(OPfile.FileName).Height;
                    picBoxUpDate分級.Image = Image.FromFile(OPfile.FileName);
                }
            }
        }

        private void dataGridView分級_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e) //點擊dataGridView欄位
        {
            txt分級編號.Text = dataGridView分級.CurrentRow.Cells["分級編號Rating_ID"].Value.ToString();
            txt分級級數.Text = dataGridView分級.CurrentRow.Cells["分級級數Rating_Level"].Value.ToString();
            txt分級說明.Text = dataGridView分級.CurrentRow.Cells["分級說明Rating_illustrate"].Value.ToString();

            try
            {
                byte[] ByteData = (byte[])dataGridView分級.CurrentRow.Cells["分級圖片Rating_Image"].Value;
                MemoryStream memoryStream = new MemoryStream(ByteData);
                picBoxUpDate分級.Image = Image.FromStream(memoryStream);
                memoryStream.Close();
            }
            catch
            {
                picBoxUpDate分級.Image = null;
            }
        }

        private void btn_Show國家_Click(object sender, EventArgs e)
        {
            var q = from c in this.dbMDA.國家總表Countrys
                    select c;

            this.dataGridView國家.DataSource = q.ToList();
            setGridStyle國家();
        }

        private void btnInsert國家_Click(object sender, EventArgs e)
        {
            if (txt國家編號.Text == "" || txt國家名稱.Text == "")
                return;
            tb國家總表.國家編號Country_ID = txt國家編號.Text;
            tb國家總表.國家名稱Country_Name = txt國家名稱.Text;
            tb國家總表.國旗Country_Image = image.ConvertToByte(picBoxUpDate國家.Image);

            this.dbMDA.國家總表Countrys.Add(tb國家總表); //資料新增
            this.dbMDA.SaveChanges(); //資料存進資料庫
            this.DataGridView刷新國家(); //DataGridView刷新
            MessageBox.Show($"新增成功\n國家編號:{txt國家編號.Text}\n國家名稱:{txt國家名稱.Text}");
        }

        private void btnUpdate國家_Click(object sender, EventArgs e)
        {
            if (txt國家編號.Text == "" || txt國家名稱.Text == "")
                return;
            var q = (from c in this.dbMDA.國家總表Countrys.AsEnumerable()
                     where c.國家編號Country_ID == txt國家編號.Text //比對txtbox與DataGridView欄位資料
                     select c).FirstOrDefault(); //傳回第一筆

            if (q == null)
                return;

            if (q.國旗Country_Image != null) //防呆 沒有圖片時存空值
            {
                q.國旗Country_Image = null;
                this.dbMDA.SaveChanges();
            }

            q.國家名稱Country_Name = txt國家名稱.Text;
            q.國旗Country_Image = image.ConvertToByte(picBoxUpDate國家.Image);

            this.dbMDA.SaveChanges();
            this.DataGridView刷新國家();
            MessageBox.Show($"修改成功\n國家編號:{txt國家編號.Text}\n國家名稱:{txt國家名稱.Text}");
        }

        private void btnBrowse國家_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            OpenFileDialog OPfile = new OpenFileDialog();

            OPfile.FileName = "";
            OPfile.Multiselect = false; //該值確定是否可以選擇多個檔案
            OPfile.Title = "開啟檔案";
            OPfile.Filter = "所有檔案 (*.*)|*.*|" +
                            "Png (*.png;*.pns)|*.png;*.pns|" +
                            "Jpeg (*.jpg;*.jpeg;*.jpe)|*.jpg;*.jpeg;*.jpe"; //設定要選擇的檔案的型別
            OPfile.FilterIndex = 2;
            OPfile.RestoreDirectory = true;

            if (OPfile.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = OPfile.FileName;
                //Read the contents of the file into a stream
                var fileStream = OPfile.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    picBoxUpDate國家.Width = Image.FromFile(OPfile.FileName).Width;
                    picBoxUpDate國家.Height = Image.FromFile(OPfile.FileName).Height;
                    picBoxUpDate國家.Image = Image.FromFile(OPfile.FileName);
                }
            }
        }

        private void dataGridView國家_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e) //點擊dataGridView欄位
        {
            txt國家編號.Text = dataGridView國家.CurrentRow.Cells["國家編號Country_ID"].Value.ToString();
            txt國家名稱.Text = dataGridView國家.CurrentRow.Cells["國家名稱Country_Name"].Value.ToString();

            try
            {
                byte[] ByteData = (byte[])dataGridView國家.CurrentRow.Cells["國旗Country_Image"].Value;
                MemoryStream memoryStream = new MemoryStream(ByteData);
                picBoxUpDate國家.Image = Image.FromStream(memoryStream);
                memoryStream.Close();
            }
            catch
            {
                picBoxUpDate國家.Image = null;
            }
        }
    }
}
