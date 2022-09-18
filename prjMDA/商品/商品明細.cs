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
    public partial class 商品明細 : Form
    {
        MDAEntities dbContext = new MDAEntities();
        public 商品明細()
        {
            InitializeComponent();

        }
        CProductsDetail PrDetail = new CProductsDetail();
        List<CProductsDetail> myList = new List<CProductsDetail>();
        購買商品明細Receipt ReList = new 購買商品明細Receipt();
        List<CProductsDetail> Re = new List<CProductsDetail>();
        int flag;
        int reduceOne;      
       
        string myTheName = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (flag)
            {
                case 1:
                    PrDetail.電影院名稱TheaterName = (string)dataGridView1.CurrentRow.Cells[0].Value;
                    label4.Text = PrDetail.電影院名稱TheaterName;
                    myTheName= PrDetail.電影院名稱TheaterName;
                    break;
                case 2:
                    if (dataGridView1.DataSource == null) //todo
                        return;
                   PrDetail.商品編號ProId = (int)dataGridView1.CurrentRow.Cells[2].Value;
                    PrDetail.單價Price = (decimal)dataGridView1.CurrentRow.Cells[1].Value;
                    PrDetail.商品名稱ProName = (string)dataGridView1.CurrentRow.Cells[0].Value;
                    label8.Text = PrDetail.單價Price.ToString("0");
                    label6.Text = PrDetail.商品名稱ProName;
                    break;

            }
        }
        private void selectTheaName(object sender, EventArgs e)
        {
            flag = 1;
            groupBox1.Visible = true;
            dataGridView1.Visible = true;
            var q = from p in dbContext.電影院Theater
                    select new { p.電影院名稱Theater_Name };

            dataGridView1.DataSource = q.ToList();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            flag = 2;
            groupBox1.Visible = true;
            dataGridView1.Visible = true;
            var q = from m in dbContext.電影院Theater
                    from p in m.商品資料Products
                    where m.電影院名稱Theater_Name.Equals(PrDetail.電影院名稱TheaterName)
                    select new { p.商品名稱Product_Name, p.商品價格Product_Price, p.商品編號Product_ID };
            if (!q.Any())
                return; //todo

            var q2 = q.ToList();
            if (q2.Count == 0)
            {
                MessageBox.Show($"{myTheName}尚未建立商品，請重新選擇");
                return;
            }
            dataGridView1.DataSource = q.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flag = 5;
            if (textBox1.Text == "" || textBox1.Text == "0") { MessageBox.Show("請輸入正確數量"); return; }
            groupBox2.Visible = true;
            dataGridView2.Visible = true;
            PrDetail.數量Amount = Convert.ToInt32(textBox1.Text);
            PrDetail.小計金額ListTotal = PrDetail.單價Price * PrDetail.數量Amount;
            label7.Text = (PrDetail.單價Price * PrDetail.數量Amount).ToString("0");

            myList.Add(new CProductsDetail()
            {
                商品編號ProId = PrDetail.商品編號ProId,
                商品名稱ProName = PrDetail.商品名稱ProName,
                單價Price = PrDetail.單價Price,
                數量Amount = PrDetail.數量Amount,
                小計金額ListTotal = PrDetail.小計金額ListTotal,
                電影院名稱TheaterName = PrDetail.電影院名稱TheaterName
            });

            dataGridView2.DataSource = myList.ToList();
            label6.Text = "";           
            
            label8.Text = "";
            //Re = myList;
            //MessageBox.Show(myList.Count.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = 3;
            Re.Clear();
            Re.AddRange(myList);
            dataGridView2.DataSource = null;
            myList.Clear();
        }
        void myAddReceitp()
        {
            this.dbContext.購買商品明細Receipt.Add(ReList);
            this.dbContext.SaveChanges();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"{myCar.ProId}");//抓最後一次的值
            //TODO 訂單編號是寫固定2，填的是假資料
            if (flag == 5)
            {
                for (int i = 0; i < myList.Count; i++)
                {
                    ReList.商品編號Product_ID = myList[i].商品編號ProId;
                    ReList.訂單編號Order_ID = 2;//待詢問
                    ReList.商品數量Qty = myList[i].數量Amount;
                    myAddReceitp();
                }
            } else if (flag==4) 
            {
                for (int i = 0; i < Re.Count; i++)
                {
                    ReList.商品編號Product_ID = Re[i].商品編號ProId;
                    ReList.訂單編號Order_ID = 2;//待詢問
                    ReList.商品數量Qty = Re[i].數量Amount;
                    myAddReceitp();
                }
            }

            MessageBox.Show("您已成功加入「購買商品明細」");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            flag = 4;
            myList.Clear();
            myList.AddRange(Re);
            dataGridView2.DataSource = myList.ToList();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            reduceOne = (int)dataGridView2.CurrentRow.Index;
            //MessageBox.Show(reduceOne.ToString());//0、1           
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (flag == 3)
            {
                Re.RemoveAt(reduceOne);
            }
            else if (flag==4)
            {
                myList.RemoveAt(reduceOne);
            }
            else if (flag == 5)
            {
                myList.RemoveAt(reduceOne);
                
            }
            dataGridView2.DataSource = myList.ToList();
        }

    }
}
