//using ProjectMda.Models;
using prjMDA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjectMda
{
    public partial class Frm商品 : Form
    {
        public int ProId { get; set; }
       
        string theaterName;
        string theaterNo;
        string MytheaterNo;
        string MytheaterName;
        MDAEntities dbContext = new MDAEntities();
                
        public Frm商品()
        {
            InitializeComponent();
            var TheaterName = from p in dbContext.電影院Theater
                              select p;
            //dataGridView1.DataSource = TheaterName.ToList();
            List<電影院Theater> theaterList = TheaterName.ToList();

            foreach (var item in theaterList)
            {
                theaterName = item.電影院名稱Theater_Name;
                theaterNo = Convert.ToString(item.電影院編號Theater_ID);
                comboBox1.Items.Add(item.電影院名稱Theater_Name);
            }
            //var q = from m in dbContext.電影院Theater
            //        from op in m.商品資料Products
            //        orderby m.電影院編號Theater_ID
            //        select new
            //        {
            //            op.商品編號Prods_ID,
            //            op.商品名稱Prods_Name,
            //            op.商品價格Prods_Price,
            //            op.商品圖片Image,
            //            m.電影院名稱Theater_Name,
            //            m.電影院編號Theater_ID
            //        };

            var q = dbContext.商品資料Products.Select(op => new
            {
                op.商品編號Product_ID,
                op.商品名稱Product_Name,
                op.商品價格Product_Price,
                op.商品圖片Image,
                op.電影院Theater.電影院名稱Theater_Name,
                op.電影院編號Theater_ID
            });
            dataGridView1.DataSource = q.ToList();
        }
        public void QueryProdName()
        {
            string prdName = myProds_Name.Text;
            var q = from m in dbContext.電影院Theater
                    from p in m.商品資料Products
                    where (p.商品名稱Product_Name.Contains(prdName))
                    orderby m.電影院編號Theater_ID
                    select new
                    {
                        p.商品編號Product_ID,
                        p.商品名稱Product_Name,
                        p.商品價格Product_Price,
                        p.商品圖片Image,
                        m.電影院名稱Theater_Name,
                        m.電影院編號Theater_ID
                    };

            dataGridView1.DataSource = q.ToList();
            var prdList = q.ToList();
            string message = "";
            if (prdList.Count == 0)
            {
                message = $"找不到{prdName},請重新查詢";
                MessageBox.Show(message);
            }

        }
        public void QueryPrice()
        {
            if (myProds_Price.Text == "")
            {
                MessageBox.Show("請輸入正確價格");
                return;
            }
            else
            {
                decimal prdPrice = Convert.ToDecimal(myProds_Price.Text);
                var q = from m in dbContext.電影院Theater
                        from p in m.商品資料Products
                        where (p.商品價格Product_Price.Equals(prdPrice))
                        orderby m.電影院編號Theater_ID
                        select new
                        {
                            p.商品編號Product_ID,
                            p.商品名稱Product_Name,
                            p.商品價格Product_Price,
                            p.商品圖片Image,
                            m.電影院名稱Theater_Name,
                            m.電影院編號Theater_ID
                        };
                dataGridView1.DataSource = q.ToList();
                var prdList = q.ToList();
                string message = "";
                if (prdList.Count == 0)
                {
                    message = $"找不到{prdPrice},請重新查詢";
                    MessageBox.Show(message);
                }
            }
            
        }

        public void QueryTheaterProd() 
        {
            MytheaterName = comboBox1.Text;
           
            if (comboBox1.SelectedIndex != -1)
            {
                var q = from m in dbContext.電影院Theater
                        from p in m.商品資料Products
                        where m.電影院名稱Theater_Name.Equals(MytheaterName)
                        orderby m.電影院編號Theater_ID 
                        select new
                        {
                            p.商品編號Product_ID,
                            p.商品名稱Product_Name,
                            p.商品價格Product_Price,
                            p.商品圖片Image,
                            m.電影院名稱Theater_Name,
                            m.電影院編號Theater_ID
                        };
                dataGridView1.DataSource = q.ToList();
                var prdList = q.ToList();
                string message = "";
                if (prdList.Count == 0)
                {
                    message = $"找不到{MytheaterName}商品資料，請重新查詢";
                    MessageBox.Show(message);
                }
            }
        }

        public void QueryAllProd()
        {           
            var q2 = from m in dbContext.電影院Theater
                     from p in m.商品資料Products
                     select new
                     {
                         p.商品編號Product_ID,
                         p.商品名稱Product_Name,
                         p.商品價格Product_Price,
                         p.商品圖片Image,
                         m.電影院名稱Theater_Name,
                         m.電影院編號Theater_ID
                     };
            dataGridView1.DataSource = q2.ToList();
        }

        private void QueryProdName_Click(object sender, EventArgs e)
        {
            if (myProds_Name.Text == "")
            {
                MessageBox.Show("請確認輸入文字，謝謝");
                return;
            }
            else
            {
                dataGridView1.DataSource = null;
                QueryProdName();
                myProds_Name.Text = "";
            }
        }
        private void QueryPrice_Click(object sender, EventArgs e)
        {
            if (myProds_Price.Text == "")
            {
                MessageBox.Show("請確認輸入價格，謝謝");
                return;
            }
            else
            {
                this.dataGridView1.DataSource = null;
                QueryPrice();                
                myProds_Price.Text = "";
            }
            //ProId = (int)dataGridView1.CurrentRow.Cells[0].Value; //再修改
            //商品修改 prodEdit = new 商品修改(ProId);
        }
        private void QueryMovieProduct_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text!="")
            {
                dataGridView1.DataSource = null;
                QueryTheaterProd();
            }
            else
            {
                MessageBox.Show("請選擇要查詢的電影院");
            }
            
        }

        private void QueryAllProd_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            QueryAllProd();
            //ProId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            //商品修改 prodEdit = new 商品修改(ProId);
        }
        private void SelectImg_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            openFileDialog1.FileName = "*.png;*.jpg;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }
        public byte[] Bytes
        {
            set
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(value);
                this.pictureBox1.Image = Image.FromStream(ms);
            }
        }
        private void AddProd_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            this.pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] bytes = ms.GetBuffer();
            
            if (comboBox1.SelectedIndex == -1 )//&& q2)
            {
                MessageBox.Show("請確認輸入的欄位是否正確!");
            }
            else
            {
                MytheaterName = comboBox1.Text.ToString();
                //MessageBox.Show(MytheaterName);
                var q = this.dbContext.電影院Theater
                    .Where(m => m.電影院名稱Theater_Name.Equals(MytheaterName))
                    .Select(m=>m);
                List<電影院Theater> mylist = q.ToList();
                foreach (var x in mylist)
                {
                    MytheaterNo = x.電影院編號Theater_ID.ToString();
                }
                //MessageBox.Show(MytheaterNo.ToString());

                商品資料Products product = new 商品資料Products
                {
                    商品圖片Image = bytes,
                    商品名稱Product_Name = Convert.ToString(myProds_Name.Text),
                    商品價格Product_Price = Convert.ToInt32(myProds_Price.Text),
                    電影院編號Theater_ID = Convert.ToInt32(MytheaterNo)
                };

                this.dbContext.商品資料Products.Add(product);
                this.dbContext.SaveChanges();
                MessageBox.Show("新增商品成功");

            }
            var q2 = from p in dbContext.電影院Theater
                    from op in p.商品資料Products
                    orderby op.商品編號Product_ID descending
                    select new
                    {
                        op.商品編號Product_ID,
                        op.商品名稱Product_Name,
                        op.商品價格Product_Price,
                        op.商品圖片Image,
                        p.電影院名稱Theater_Name,
                        p.電影院編號Theater_ID
                    };
            dataGridView1.DataSource = q2.ToList();


        }      
      
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProId = (int)dataGridView1.CurrentRow.Cells[0].Value;          

            商品修改 prodEdit = new 商品修改(ProId);

            prodEdit.ShowDialog();
        }

       
    }
}
