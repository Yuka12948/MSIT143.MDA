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
    public partial class Frm報表 : Form
    {
        public Frm報表()
        {
            InitializeComponent();
            var q = from p in dbContext.電影院Theater
                    orderby p.電影院編號Theater_ID
                    select p.電影院名稱Theater_Name;
            foreach (var item in q)
            {
                comboBox1.Items.Add(item);
            }
        }
        MDAEntities dbContext = new MDAEntities();
        string MytheaterName;

        private void button1_Click(object sender, EventArgs e)
        {
            var q = dbContext.票價資訊TicketPrice.AsEnumerable();

            var q2 = q.Where(p => p.影城MainTheater.影城編號MainTheater_ID.Equals(p.影城編號MainTheater_ID)
              && p.票種TicketType.票種編號TicketType_ID.Equals(p.票種編號TicketType_ID))
                .Select(p => new
                {
                    p.影城編號MainTheater_ID,
                    p.影城MainTheater.影城名稱MainTheater_Name,
                    p.票種編號TicketType_ID,
                    p.票種TicketType.票種名稱TicketType_Name
                })
                .OrderBy(p => p.影城編號MainTheater_ID);
            dataGridView1.DataSource = q2.ToList();
            //var q3 = q.Any(p => p.影城編號MainTheater_ID.Equals(p.影城MainTheater.影城編號MainTheater_ID));
            //if (q3)
            //{
            //    MessageBox.Show("q3為true");
            //}
            setGridStyle();
        }

        void Clear()
        {
            dataGridView1.DataSource = null;
            chart1.DataSource = null;
        }

        private void setGridStyle()
        {
            bool isColoChanged = false;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                isColoChanged = !isColoChanged;
                r.DefaultCellStyle.BackColor = Color.CadetBlue;
                if (isColoChanged)
                    r.DefaultCellStyle.BackColor = Color.White;
            }
        }

        public void QueryTheaterName()
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

                            //p.商品圖片Image,
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
        private void button4_Click(object sender, EventArgs e)
        {
            setGridStyle();
            var q = dbContext.票價資訊TicketPrice.AsEnumerable();
            var q2 = q.Select(p => (p.價格TicketPrice)).Max();
            decimal ss = q2;
            var q3 = q.Where(p => p.價格TicketPrice.Equals(ss))
                .Select(p => new
                {
                    p.影城MainTheater.影城名稱MainTheater_Name,
                    p.票種TicketType.票種名稱TicketType_Name,
                    p.價格TicketPrice
                });


            dataGridView1.DataSource = q3.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
            var q1 = from m in dbContext.電影院Theater
                     from p in m.商品資料Products
                     group p by p.電影院Theater.電影院名稱Theater_Name into g
                     select new
                     {
                         TheaterName = g.Key,
                         ProductCount = g.Count()

                     };
            dataGridView1.DataSource = q1.ToList();

            chart1.DataSource = q1.ToList();
            chart1.Series[0].XValueMember = "TheaterName";
            chart1.Series[0].YValueMembers = "ProductCount";

            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
            var q = from p in dbContext.商品資料Products
                    from pi in p.購買商品明細Receipt
                    group p by pi.商品資料Products.電影院Theater.電影院名稱Theater_Name into g
                    //from m in dp.商品資料Products.電影院Theater

                    select new
                    {
                        //p.商品編號Prods_ID,
                        //p.商品名稱Prods_Name,
                        //p.電影院Theater.電影院名稱Theater_Name
                        電影院名稱 = g.Key,
                        商品明細筆數 = g.Count()
                    };
            dataGridView1.DataSource = q.ToList();

            chart1.DataSource = q.ToList();
            chart1.Series[0].XValueMember = "電影院名稱";
            chart1.Series[0].YValueMembers = "商品明細筆數";
            chart1.Series[0].Name = "電影院名稱";
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clear();
            //QueryTheaterName();
            var q = dbContext.購買商品明細Receipt
               .GroupBy(n => new { n.商品資料Products.商品名稱Product_Name, n.商品資料Products.電影院Theater.電影院名稱Theater_Name })
               .Select(p => new
               {
                   電影院 = p.Key.電影院名稱Theater_Name,
                   商品名稱 = p.Key.商品名稱Product_Name,
                   數量 = p.Select(n => n.商品數量Qty).Sum(),
                   單價 = p.Select(n => n.商品資料Products.商品價格Product_Price).FirstOrDefault(),
                   銷售金額 = p.Select(n => n.商品數量Qty).Sum() * p.Select(n => n.商品資料Products.商品價格Product_Price).FirstOrDefault()
               });
            dataGridView1.DataSource = q.ToList();


            var q2 = q.Where(n => n.電影院 == comboBox1.Text);
            chart1.DataSource = q2.ToList();
            chart1.Series[0].Name = "銷售量";
            chart1.Series[0].XValueMember = "商品名稱";
            chart1.Series[0].YValueMembers = "銷售金額";

            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            //var q = from p in dbContext.商品資料Products
            //        from pi in p.購買商品明細Receipt
            //        where pi.商品資料Products.電影院Theater.電影院名稱Theater_Name.Equals(MytheaterName) //&& p.電影院Theater.電影院名稱Theater_Name.Equals("秀泰影城")
            //                                                                                 //group p by pi.商品資料Products.電影院Theater.電影院名稱Theater_Name into g

            //        select new
            //        {
            //            電影院名稱 = p.電影院Theater.電影院名稱Theater_Name,
            //            商品名稱 = p.商品名稱Product_Name,
            //            數量 = pi.商品數量Qty
            //        };

            //dataGridView1.DataSource = q.ToList();

            //chart1.DataSource = q.ToList();
            //chart1.Series[0].XValueMember = "商品名稱";
            //chart1.Series[0].YValueMembers = "數量";
            //chart1.Series[0].Name = "品名";
            //chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clear();
            var q = dbContext.購買商品明細Receipt
                .GroupBy(n => new { n.商品資料Products.商品名稱Product_Name, n.商品資料Products.電影院Theater.電影院名稱Theater_Name })
                .Select(p => new
                {
                    電影院 = p.Key.電影院名稱Theater_Name,
                    商品名稱 = p.Key.商品名稱Product_Name,
                    數量 = p.Select(n => n.商品數量Qty).Sum(),
                    單價 = p.Select(n => n.商品資料Products.商品價格Product_Price).FirstOrDefault(),
                    銷售金額 = p.Select(n => n.商品數量Qty).Sum() * p.Select(n => n.商品資料Products.商品價格Product_Price).FirstOrDefault()
                });
            dataGridView1.DataSource = q.ToList();

            chart1.DataSource = q.ToList();
            chart1.Series[0].Name = "品名";
            chart1.Series[0].XValueMember = "商品名稱";
            chart1.Series[0].YValueMembers = "銷售金額";

            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;


            //decimal q1 = dbContext.購買商品明細Receipt.AsEnumerable()
            //    .Where(p => p.商品數量Qty > 1).Count();


            //var q = from p in dbContext.商品資料Products
            //        from pi in p.購買商品明細Receipt
            //        group p by pi.商品資料Products.商品名稱Product_Name into g
            //        where g.Count() > 1
            //        select new
            //        {
            //            商品名稱 = g.Key,
            //            商品明細筆數 = g.Count()
            //        };
            //dataGridView1.DataSource = q.ToList();

            //chart1.DataSource = q.ToList();
            //chart1.Series[0].XValueMember = "商品名稱";
            //chart1.Series[0].YValueMembers = "商品明細筆數";

            //chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;        }
        }
    }
}
