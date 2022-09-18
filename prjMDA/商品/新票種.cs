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
    public partial class Frm商品票種 : Form
    {
        public Frm商品票種()
        {
            InitializeComponent();
        }
        MDAEntities dbContext = new MDAEntities();      
        int flag;
        int z;
        string v;
        private void AddTickets(object sender, EventArgs e)
        {

            string y = TicketTp.Text;
            if (TicketTp.Text == "" || TicketTp.Text == "0" || TicketTp.Text == " ")
            {
                MessageBox.Show("請確認輸入內容");
                return;
            }
            else if (true)
            {
                var w = dbContext.票種TicketType
                    .Where(p => p.票種名稱TicketType_Name.Equals(y))
                    .Select(p => p);

                var Comp = w.ToList();
                if (Comp.Count != 0)
                {
                    MessageBox.Show("名稱重複，請重新輸入");
                    TicketTp.Text = "";
                    return;
                }
                else
                {
                    票種TicketType MyTicket = new 票種TicketType()
                    {
                        票種名稱TicketType_Name = y
                    };
                    this.dbContext.票種TicketType.Add(MyTicket);
                    this.dbContext.SaveChanges();

                    var q = from p in dbContext.票種TicketType
                            where p.票種名稱TicketType_Name == y
                            select new
                            {
                                p.票種編號TicketType_ID,
                                p.票種名稱TicketType_Name
                            };

                    var Mlist = q.ToList();
                    dataGridView1.Visible = true;

                    dataGridView1.DataSource = q.ToList();
                    MessageBox.Show("新增成功");
                }
            }
        }

        private void EditTickets(object sender, EventArgs e)
        {
            TicketTp.Text = "";

            var q3 = from p in dbContext.票種TicketType
                     select new { p.票種編號TicketType_ID, p.票種名稱TicketType_Name };
            dataGridView1.Visible = true;
            dataGridView1.DataSource = q3.ToList();
            flag = 2;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            z = (int)dataGridView1.CurrentRow.Cells[0].Value;
            v = (string)dataGridView1.CurrentRow.Cells[1].Value;
            switch (flag)
            {
                case 2:
                    if (z >= 0)
                    {
                        dataGridView1.Visible = true;
                        label7.Text = v;
                    }
                    else
                    {
                        MessageBox.Show("請選擇要修改的項目");
                        return;
                    }
                    break;
                case 3:
                    if (z >= 0)
                    {
                        try
                        {
                            var q = (from p in dbContext.票種TicketType
                                     where p.票種編號TicketType_ID.Equals(z)
                                     select p).SingleOrDefault();
                            this.dbContext.票種TicketType.Remove(q);
                            this.dbContext.SaveChanges();
                            MessageBox.Show($"已刪除{v}");
                            var q3 = from p in dbContext.票種TicketType
                                     select new { p.票種編號TicketType_ID, p.票種名稱TicketType_Name };
                            dataGridView1.Visible = true;
                            dataGridView1.DataSource = q3.ToList();

                        }
                        catch (Exception)
                        {

                            MessageBox.Show($"票種編號:{z}，已建立票價資訊\n故無法刪除");
                        }

                    }
                    else
                    {
                        MessageBox.Show("尚未選擇刪除項目");
                    }
                    break;
                case 5:
                    if (z>=0)
                    {
                        label7.Text = v;
                    }
                    break;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string NewName = "";
            var editMTic = this.dbContext.票種TicketType
               .Where(t => t.票種編號TicketType_ID.Equals(z)).SingleOrDefault();

            editMTic.票種名稱TicketType_Name = textBox2.Text;

            NewName = textBox2.Text;

            this.dbContext.SaveChanges();

            MessageBox.Show($"原本為{v}\n已改為{NewName}");

            var q3 = from p in dbContext.票種TicketType
                     select new { p.票種編號TicketType_ID, p.票種名稱TicketType_Name };
            dataGridView1.Visible = true;
            dataGridView1.DataSource = q3.ToList();
        }

        private void DelBtn(object sender, EventArgs e)
        {
          
            var q3 = from p in dbContext.票種TicketType
                     select new { p.票種編號TicketType_ID, p.票種名稱TicketType_Name };
            dataGridView1.Visible = true;
            dataGridView1.DataSource = q3.ToList();
            flag = 3;
            groupBox3.Visible = false;
        }

        private void SearchKeyWordBtn(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            flowLayoutPanel1.Visible = false;
            dataGridView1.Visible = true;
            dataGridView1.DataSource = "";
            關鍵字查詢 TicketSearch = new 關鍵字查詢();
            TicketSearch.ShowDialog();
            if (TicketSearch.getclickok)
            {
                dataGridView1.DataSource = "";
                var q3 = dbContext.票種TicketType;
                var q4 = q3
                    .Where(p => p.票種名稱TicketType_Name.Contains(TicketSearch.keyword)
                    )
                    .Select(p => new
                    {
                        p.票種編號TicketType_ID,
                        p.票種名稱TicketType_Name

                    });
                var q = q4.ToList();
                if (q.Count == 0)
                {
                    MessageBox.Show("查無資料");
                }
                dataGridView1.DataSource = q4.ToList();
                flag = 5;
            }

        }

        private void SearchAll(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
            dataGridView1.Visible = false;
            groupBox3.Visible = false;
            var q = from p in dbContext.票種TicketType
                    select p;
            List<票種TicketType> Mylist = q.ToList();

            #region
            //for (int i = 0; i < Mylist.Count; i++)
            //{
            //    ItemTemplateTicket item = new ItemTemplateTicket();
            //    item.MyTickname = Mylist[i].票種名稱TicketType_Name;
            //    this.flowLayoutPanel1.Controls.Add(item);
            //    Application.DoEvents();
            //}
            #endregion
            Mylist.Reverse();
            foreach (var j in Mylist)
            {
                ItemTemplateTicket item = new ItemTemplateTicket();
                item.MyTickname = j.票種名稱TicketType_Name;
                this.flowLayoutPanel1.Controls.Add(item);
                Application.DoEvents();
            }
        }
    }
}
