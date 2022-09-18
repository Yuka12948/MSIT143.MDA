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
    public partial class Frm票價資訊 : Form
    {
        public Frm票價資訊()
        {
            InitializeComponent();
        }
        MDAEntities dbContext = new MDAEntities();
        int MyNo;
        string MyName = "";
        int TickNo;
        string TickName = "";
        int EditNo;

        int flag = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            flag = 1;
            dataGridView1.Visible = true;

            var q = from m in dbContext.影城MainTheater
                    select new
                    {
                        m.影城編號MainTheater_ID,
                        m.影城名稱MainTheater_Name
                    };
            dataGridView1.DataSource = q.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flag = 2;
            dataGridView1.Visible = true;

            var q = from t in dbContext.票種TicketType
                    select new
                    {
                        t.票種編號TicketType_ID,
                        t.票種名稱TicketType_Name
                    };
            dataGridView1.DataSource = q.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (flag)
            {
                case 1:
                    MyNo = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    MyName = (string)dataGridView1.CurrentRow.Cells[1].Value;
                    label4.Text = MyName.ToString();
                    break;
                case 2:
                    TickNo = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    TickName = (string)dataGridView1.CurrentRow.Cells[1].Value;
                    label5.Text = TickName;
                    break;
                case 3:
                    EditNo = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    break;

                default:
                    MessageBox.Show("尚未選擇");
                    break;
            }
        }

        decimal myPrice;
        
        private void button5_Click(object sender, EventArgs e)
        {
            if (Money.Text == "") { MessageBox.Show("請輸入正確價格"); return; }
            myPrice = Convert.ToDecimal(Money.Text);
            if (myPrice <= 0) { MessageBox.Show("請輸入正確價格"); return; }

            var q2 = from p in dbContext.票價資訊TicketPrice.AsEnumerable()
                     let v = p.影城編號MainTheater_ID.Equals(MyNo)
                     let r = p.票種編號TicketType_ID.Equals(TickNo)
                     where v && r
                     select new
                     {
                         p.票價明細Ticket_ID,
                         p.影城編號MainTheater_ID,
                         p.票種編號TicketType_ID,
                         p.價格TicketPrice
                     };
           
            var comp = q2.ToList();
            if (comp.Count > 0)
            {
                MessageBox.Show($"已設定票價資訊，不可重覆新增");
            }
            else
            {
                票價資訊TicketPrice tickInfo = new 票價資訊TicketPrice()
                {
                    價格TicketPrice = myPrice,
                    影城編號MainTheater_ID = MyNo,
                    票種編號TicketType_ID = TickNo
                };
                this.dbContext.票價資訊TicketPrice.Add(tickInfo);
                this.dbContext.SaveChanges();
                MessageBox.Show($"票價資訊如下\n影城名稱:{MyName}\n票種名稱:{TickName}\n票價:{myPrice}\n新增成功!");

                var q = (from p in dbContext.票價資訊TicketPrice.AsEnumerable()
                         join m in dbContext.影城MainTheater
                         on p.影城編號MainTheater_ID equals m.影城編號MainTheater_ID
                         join t in dbContext.票種TicketType
                         on p.票種編號TicketType_ID equals t.票種編號TicketType_ID
                         orderby p.票價明細Ticket_ID descending
                         select new
                         {
                             p.票價明細Ticket_ID,
                             p.票種編號TicketType_ID,
                             m.影城名稱MainTheater_Name,
                             t.票種名稱TicketType_Name,
                             p.價格TicketPrice,
                         }).Take(1);
                dataGridView1.DataSource = q.ToList();
            }      
           
        }

        //public void reflash()
        //{
        //    listBox1.Items.Clear();
        //}
        private void button2_Click(object sender, EventArgs e)
        {
            //reflash();
            Money.Text = "";
            flag = 3;
            dataGridView1.Visible = true;
            groupBox1.Visible = true;
            關鍵字查詢 TicketSearch = new 關鍵字查詢();
            TicketSearch.ShowDialog();
            if (TicketSearch.getclickok)
            {
                dataGridView1.DataSource = "";
                var q3 = dbContext.票價資訊TicketPrice.AsEnumerable();
                var q4 = q3
                    .Where(p => p.影城MainTheater.影城名稱MainTheater_Name.Contains(TicketSearch.keyword)
                    || p.票種TicketType.票種名稱TicketType_Name.Contains(TicketSearch.keyword)
                    || p.價格TicketPrice == getTicketPrice(TicketSearch.keyword)//.Equals(Convert.ToDecimal(TicketSearch.keyword))
                    )
                    .Select(p => new
                    {
                        p.票價明細Ticket_ID,
                        p.影城MainTheater.影城名稱MainTheater_Name,
                        p.票種TicketType.票種名稱TicketType_Name,
                        p.價格TicketPrice
                    });

                dataGridView1.DataSource = q4.ToList();
                #region
                //var q2 =
                //    from p in dbContext.票價資訊TicketPrice.AsEnumerable()
                //    join mm in dbContext.影城MainTheater
                //    on p.影城編號MainTheater_ID equals mm.影城編號MainTheater_ID
                //    join t in dbContext.票種TicketType
                //    on p.票種編號TicketType_ID equals t.票種編號TicketType_ID
                //    let v = mm.影城名稱MainTheater_Name.Contains(TicketSearch.keyword)
                //    let r = t.票種名稱TicketType_Name.Contains(TicketSearch.keyword)
                //    let m = p.價格TicketPrice.Equals(TicketSearch.keyword)
                //    where v  || r || m  // || v && r
                //    select new
                //    {
                //        p.票價明細Ticket_ID,
                //        mm.影城名稱MainTheater_Name,
                //        t.票種名稱TicketType_Name,
                //        p.價格TicketPrice
                //    };
                //不用listbox清單
                //foreach (var item in q2)
                //{                   
                //    listBox1.Items.Add(item.影城名稱MainTheater_Name+ item.票種名稱TicketType_Name+ item.價格TicketPrice.ToString("0"));

                //}               
                #endregion
            }

        }

        private decimal getTicketPrice(string keyword)
        {
            decimal num;
            bool isNum = decimal.TryParse(keyword, out num);
            if (isNum)
            {
                return num;
            }
            else
            {
                return -1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (Money.Text == "") { MessageBox.Show("請輸入正確價格"); return; }
            myPrice = Convert.ToDecimal(Money.Text);
            if (myPrice <= 0) { MessageBox.Show("請輸入正確價格"); return; }

            switch (flag)
            {
                case 3:
                    var editPrice = this.dbContext.票價資訊TicketPrice
                                     .Where(p => p.票價明細Ticket_ID.Equals(EditNo)
                                     ).SingleOrDefault();

                    editPrice.價格TicketPrice = Convert.ToDecimal(Money.Text);

                    this.dbContext.SaveChanges();

                    MessageBox.Show($"金額已改為{myPrice}\n請按「查詢」按鈕確認");

                    //var q = from p in dbContext.票價資訊TicketPrice
                            
                    //        select new {
                    //            p.影城編號MainTheater_ID,
                    //            p.影城MainTheater.影城名稱MainTheater_Name,
                    //            p.票種編號TicketType_ID,
                    //            p.票種TicketType.票種名稱TicketType_Name,
                    //            p.價格TicketPrice
                    //        };
                    //dataGridView1.DataSource = q.ToList();
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label4.Text = "請按選擇";
            label5.Text = "請按選擇";
            Money.Text = "";
        }
    }
}
