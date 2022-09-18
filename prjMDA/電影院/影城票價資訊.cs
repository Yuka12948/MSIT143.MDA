using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMDA
{
    public partial class 影城票價資訊 : Form
    {
        MDAEntities db票價資料庫 = new MDAEntities();
        public 影城票價資訊()
        {
            InitializeComponent();
            var q = from p in db票價資料庫.票價資訊TicketPrice
                    join x in db票價資料庫.影城MainTheater
                    on p.影城編號MainTheater_ID equals x.影城編號MainTheater_ID
                    join y in db票價資料庫.票種TicketType
                    on p.票種編號TicketType_ID equals y.票種編號TicketType_ID
                    orderby p.影城編號MainTheater_ID
                    select new
                    {
                        x.影城名稱MainTheater_Name,
                        y.票種名稱TicketType_Name,
                        p.影城編號MainTheater_ID,
                        p.票種編號TicketType_ID
                    };
            dataGridView1.DataSource = q.ToList();
            var Q = from p in db票價資料庫.票價資訊TicketPrice
                    join x in db票價資料庫.影城MainTheater
                    on p.影城編號MainTheater_ID equals x.影城編號MainTheater_ID
                    join y in db票價資料庫.票種TicketType
                    on p.票種編號TicketType_ID equals y.票種編號TicketType_ID
                    orderby p.影城編號MainTheater_ID
                    select new
                    {
                        x.影城名稱MainTheater_Name,
                        y.票種名稱TicketType_Name,
                        p.價格TicketPrice

                    };
            dataGridView2.DataSource = Q.ToList();
            拉取資料();
        }
        private void 拉取資料()
        {
            影城Box.Items.Clear();

            var q = db票價資料庫.影城MainTheater.Select(x => x.影城名稱MainTheater_Name);
            foreach (var r in q) 影城Box.Items.Add(r);


        }
        string[] 票種 = { "全票", "優待票", "愛心票" };
        string[] 影城 = { "秀泰影城", "威秀影城", "誠品", "喜樂時代影城", "微風影城", "國賓", "in89", "新光影城", "喜滿客", "美麗新影城" };
        private void 清空()
        {
            影城Box.Text = "";

            票種圖表.Series.Clear();
        }
        private void 紀錄()
        {
            dataGridView1.DataSource = null;
            var q = from p in db票價資料庫.票價資訊TicketPrice
                    join x in db票價資料庫.影城MainTheater
                    on p.影城編號MainTheater_ID equals x.影城編號MainTheater_ID
                    join y in db票價資料庫.票種TicketType
                    on p.票種編號TicketType_ID equals y.票種編號TicketType_ID
                    orderby p.影城編號MainTheater_ID
                    select new
                    {
                        x.影城名稱MainTheater_Name,
                        y.票種名稱TicketType_Name,
                        p.影城編號MainTheater_ID,
                        p.票種編號TicketType_ID
                    };
            dataGridView1.DataSource = q.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            清空();
            紀錄();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            票種圖表.Series.Clear();
            string s = 影城Box.Text;
            if (影城Box.Text == "") return;
            票種圖表.Series.Add(s);
            var R = from p in db票價資料庫.訂單明細OrderDetail
                    join x in db票價資料庫.票價資訊TicketPrice
                    on p.票價明細Ticket_ID equals x.票價明細Ticket_ID
                    join i in db票價資料庫.票種TicketType
                    on x.票種編號TicketType_ID equals i.票種編號TicketType_ID
                    join j in db票價資料庫.影城MainTheater
                    on x.影城編號MainTheater_ID equals j.影城編號MainTheater_ID
                    where j.影城名稱MainTheater_Name == s
                    group p by i.票種名稱TicketType_Name into g
                    select new
                    {
                        影城名稱 = g.Select(x => x.票價資訊TicketPrice.影城MainTheater.影城名稱MainTheater_Name).FirstOrDefault(),
                        票種名稱 = g.Key,
                        售出票數 = g.Count(),
                        售出總金額 = g.Count() * g.Select(x => x.票價資訊TicketPrice.價格TicketPrice).FirstOrDefault()
                    };
            dataGridView1.DataSource = R.ToList();
            票種圖表.DataSource = R.ToList();
            foreach (var k in R)
            {
                票種圖表.Series[0].Points.AddXY(k.票種名稱, k.售出總金額);

            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            票種圖表.Series.Clear();
            var R = from p in db票價資料庫.訂單明細OrderDetail
                    join x in db票價資料庫.票價資訊TicketPrice
                    on p.票價明細Ticket_ID equals x.票價明細Ticket_ID
                    join y in db票價資料庫.影城MainTheater
                    on x.影城編號MainTheater_ID equals y.影城編號MainTheater_ID
                    group p by p.票價資訊TicketPrice.票種TicketType.票種名稱TicketType_Name into g

                    select new
                    {
                        票種名稱 = g.Key,
                        秀泰影城 = g.Count(x => x.票價資訊TicketPrice.影城MainTheater.影城名稱MainTheater_Name.Contains("秀泰影城")),
                        威秀影城 = g.Count(x => x.票價資訊TicketPrice.影城MainTheater.影城名稱MainTheater_Name.Contains("威秀影城")),
                        誠品 = g.Count(x => x.票價資訊TicketPrice.影城MainTheater.影城名稱MainTheater_Name.Contains("誠品")),
                        喜樂時代影城 = g.Count(x => x.票價資訊TicketPrice.影城MainTheater.影城名稱MainTheater_Name.Contains("喜樂時代影城")),
                        微風影城 = g.Count(x => x.票價資訊TicketPrice.影城MainTheater.影城名稱MainTheater_Name.Contains("微風影城")),
                        國賓 = g.Count(x => x.票價資訊TicketPrice.影城MainTheater.影城名稱MainTheater_Name.Contains("國賓")),
                        in89 = g.Count(x => x.票價資訊TicketPrice.影城MainTheater.影城名稱MainTheater_Name.Contains("in89")),
                        新光影城 = g.Count(x => x.票價資訊TicketPrice.影城MainTheater.影城名稱MainTheater_Name.Contains("新光影城")),
                        喜滿客 = g.Count(x => x.票價資訊TicketPrice.影城MainTheater.影城名稱MainTheater_Name.Contains("喜滿客")),
                        美麗新影城 = g.Count(x => x.票價資訊TicketPrice.影城MainTheater.影城名稱MainTheater_Name.Contains("美麗新影城")),



                    };

            dataGridView1.DataSource = R.ToList();
            票種圖表.DataSource = R.ToList();
            for (int i = 0; i < 影城.Length; i++)
            {
                票種圖表.Series.Add(影城[i]);
                票種圖表.Series[i].XValueMember = "票種名稱";
                票種圖表.Series[i].YValueMembers = 影城[i];
                票種圖表.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                票種圖表.Series[i].BorderWidth = 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
