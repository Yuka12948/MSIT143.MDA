//using ProjectMda.Models;
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

namespace ProjectMda
{
    public partial class 商品修改 : Form
    {
        int MyProId;
        string theaterName;
        string theaterNo;
        int v;
        int n;

        public 商品修改(int ProId)
        {
            InitializeComponent();
           
            //MessageBox.Show(MyProId.ToString());
            MyProId = ProId;            
            var q = 
                from k in dbContext.電影院Theater
                from p in k.商品資料Products
                     where p.商品編號Product_ID == MyProId                   
                     select new { 
                         p.商品編號Product_ID,
                         p.商品名稱Product_Name, 
                         p.商品價格Product_Price,
                         p.商品圖片Image,
                         k.電影院名稱Theater_Name,
                         k.電影院編號Theater_ID
                         };
           
            foreach (var item in q)
            {
                myProds_Name.Text = item.商品名稱Product_Name;
                myProds_Price.Text = item.商品價格Product_Price.ToString("0");
                n = item.電影院編號Theater_ID;
                label5.Text = item.電影院名稱Theater_Name;
                theaterNo = item.電影院編號Theater_ID.ToString();
                theaterName = item.電影院名稱Theater_Name.ToString();

            }
            dataGridView1.DataSource = q.ToList();           
            
            
            var q3 = (from p in dbContext.商品資料Products
                     where p.商品編號Product_ID == MyProId
                     select p.商品圖片Image).SingleOrDefault();
            if (q3!=null)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(q3);
                pictureBox1.Image = Image.FromStream(ms);
            }
            

            var q2 = dbContext.電影院Theater.Select(p => p);

            var theaterList = q2.ToList();

            foreach (var item in theaterList)
            {
                theaterName = item.電影院名稱Theater_Name;
                theaterNo = item.電影院編號Theater_ID.ToString();
                comboBox2.Items.Add(theaterName);
            }

        }

        MDAEntities dbContext = new MDAEntities();
        
        public byte[] Bytes {
            set
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(value);
                this.pictureBox1.Image = Image.FromStream(ms);
                
            }
        }
        public 商品修改()
        {
            InitializeComponent();
            
        }
        
        private void FileImg_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            openFileDialog1.FileName = "*.png;*.jpg;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            //string show = "";            
            //show = comboBox2.Text;
            v = (comboBox2.SelectedIndex)+1;
            //MessageBox.Show(show);
            //MessageBox.Show(v.ToString());

        }

        private void btnProdEdit_Click(object sender, EventArgs e)
        {           
            if (myProds_Name.Text == "" || myProds_Price.Text == "") { MessageBox.Show("商品名稱或價格，不可為空白"); return; }
            byte[] bytes = null;
            if (pictureBox1.Image!=null)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                this.pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                bytes = ms.GetBuffer();
            }


            var editProductd = this.dbContext.商品資料Products.Where(p => p.商品編號Product_ID == MyProId).SingleOrDefault();
            //MessageBox.Show($"combox編號:{comboBox1.SelectedIndex}") 0 1 2;
            try
            {
                editProductd.商品名稱Product_Name = myProds_Name.Text;
                editProductd.商品價格Product_Price = Convert.ToDecimal(myProds_Price.Text);
                editProductd.商品圖片Image = bytes;

                if (comboBox2.SelectedIndex <=0)
                {
                   
                    //string s = "";
                    //s = label5.Text;
                    //MessageBox.Show(n.ToString());
                    editProductd.電影院編號Theater_ID = Convert.ToInt32(n);
                }
                else
                {
                    editProductd.電影院編號Theater_ID = Convert.ToInt32(v);
                    
                }
                this.dbContext.SaveChanges();
                MessageBox.Show("商品修改成功!請按「修改後查詢」按鈕");
            }
            catch
            {

                MessageBox.Show("電影院名稱無異動\n系統自動儲存原電影院名稱");
            }


        }

        private void btnCheckProduct_Click(object sender, EventArgs e)
        {            
            var q2 =
                from k in dbContext.電影院Theater
                from p in k.商品資料Products
                where p.商品編號Product_ID == MyProId
                select new
                {
                    p.商品編號Product_ID,
                    p.商品名稱Product_Name,
                    p.商品價格Product_Price,
                    p.商品圖片Image,
                    k.電影院名稱Theater_Name,
                    k.電影院編號Theater_ID
                };

            foreach (var item in q2)
            {
                myProds_Name.Text = item.商品名稱Product_Name;
                myProds_Price.Text = item.商品價格Product_Price.ToString("0");
                label5.Text = item.電影院名稱Theater_Name;
                item.電影院編號Theater_ID.ToString();

            }
            dataGridView1.DataSource = q2.ToList();
        }

        
    }
}
