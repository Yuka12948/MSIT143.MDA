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
    public partial class Frm商品影城 : Form
    {
        public Frm商品影城()
        {
            InitializeComponent();
        }
        MDAEntities dbContext = new MDAEntities();
        int flag;
        int z;
        string v = "";

        private void AddTheater(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            string x = MainThName.Text;
            if (MainThName.Text == "" || MainThName.Text == "0" || MainThName.Text == " ")
            {
                MessageBox.Show("請確認輸入內容");
                return;
            }
            else if (true)
            {
                var w = dbContext.影城MainTheater
                    .Where(p => p.影城名稱MainTheater_Name.Equals(x))
                    .Select(p => p);

                var Comp = w.ToList();
                if (Comp.Count != 0)
                {
                    MessageBox.Show("名稱重複，請重新輸入");
                    MainThName.Text = "";
                    return;
                }
                else
                {
                    影城MainTheater MyMainTheater = new 影城MainTheater()
                    {
                        影城名稱MainTheater_Name = x
                    };
                    this.dbContext.影城MainTheater.Add(MyMainTheater);
                    this.dbContext.SaveChanges();

                    var q = from p in dbContext.影城MainTheater
                            where p.影城名稱MainTheater_Name == x
                            select new
                            {
                                p.影城編號MainTheater_ID,
                                p.影城名稱MainTheater_Name
                            };

                    var Mlist = q.ToList();
                    dataGridView1.Visible = true;
                    MessageBox.Show("新增成功");
                    dataGridView1.DataSource = q.ToList();
                }
            }
        }

        private void EditTheater(object sender, EventArgs e)
        {
            flag = 2;
            MainThName.Text = "";

            var q3 = from p in dbContext.影城MainTheater
                     select new { p.影城編號MainTheater_ID, p.影城名稱MainTheater_Name };
            dataGridView1.Visible = true;
            dataGridView1.DataSource = q3.ToList();
        }

        private void DelBtn(object sender, EventArgs e)
        {
            flag = 3;
            
            var q3 = from p in dbContext.影城MainTheater
                     select new { p.影城編號MainTheater_ID, p.影城名稱MainTheater_Name };
            dataGridView1.Visible = true;
            dataGridView1.DataSource = q3.ToList();
        }

        private void SuchAllBtn(object sender, EventArgs e)
        {
            flag = 4;
            flowLayoutPanel1.Visible = true;
            groupBox3.Visible = false;
            dataGridView1.Visible = false;
            var q = from p in dbContext.影城MainTheater
                    select p;
            List<影城MainTheater> Mylist = q.ToList();
            #region
            //for (int i = 0; i <Mylist.Count; i++)
            //{
            //    ItemTemplate item = new ItemTemplate();
            //    item.Tname = Mylist[i].影城名稱MainTheater_Name;
            //    this.flowLayoutPanel1.Controls.Add(item);
            //    Application.DoEvents();
            //}
            #endregion
            Mylist.Reverse();
            foreach (var j in Mylist)
            {
                ItemTemplate item = new ItemTemplate();
                item.Tname = j.影城名稱MainTheater_Name;
                this.flowLayoutPanel1.Controls.Add(item);
                //Application.DoEvents();
            }
        }

        private void SearchKeyword(object sender, EventArgs e)
        {
            
            dataGridView1.Visible = true;
            flowLayoutPanel1.Visible = false;
            groupBox3.Visible = true;
            label7.Text = "";
            textBox2.Text = "";
            dataGridView1.DataSource = "";
            關鍵字查詢 TicketSearch = new 關鍵字查詢();
            TicketSearch.ShowDialog();
            if (TicketSearch.getclickok)
            {
                dataGridView1.DataSource = "";
                var q3 = dbContext.影城MainTheater;
                var q4 = q3
                    .Where(p => p.影城名稱MainTheater_Name.Contains(TicketSearch.keyword)
                    )
                    .Select(p => new
                    {
                        p.影城編號MainTheater_ID,
                        p.影城名稱MainTheater_Name

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            z = (int)dataGridView1.CurrentRow.Cells[0].Value;
            v = (string)dataGridView1.CurrentRow.Cells[1].Value;
            switch (flag)
            {
                case 2:
                    if (z >= 0)
                    {
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
                            var q = (from p in dbContext.影城MainTheater
                                     where p.影城編號MainTheater_ID.Equals(z)
                                     select p).SingleOrDefault();
                            this.dbContext.影城MainTheater.Remove(q);
                            this.dbContext.SaveChanges();
                            MessageBox.Show($"已刪除{v}");

                            var q3 = from p in dbContext.影城MainTheater
                                     select new { p.影城編號MainTheater_ID, p.影城名稱MainTheater_Name };
                            dataGridView1.Visible = true;
                            dataGridView1.DataSource = q3.ToList();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show($"影城編號:{z}，已建立相關票價資訊\n故無法刪除");
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
                        label7.Text = v.ToString();
                    }
                    break;
                default:
                    break;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string NewName = "";
            var editMTic = this.dbContext.影城MainTheater
               .Where(t => t.影城編號MainTheater_ID.Equals(z)).SingleOrDefault();

            editMTic.影城名稱MainTheater_Name = textBox2.Text;

            NewName = textBox2.Text;

            this.dbContext.SaveChanges();

            MessageBox.Show($"原本為{v}\n已改為{NewName}");

            var q3 = from p in dbContext.影城MainTheater
                     select new { p.影城編號MainTheater_ID, p.影城名稱MainTheater_Name };
            dataGridView1.Visible = true;
            dataGridView1.DataSource = q3.ToList();
        }
    }
}
