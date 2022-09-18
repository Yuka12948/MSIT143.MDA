using prjMDA;
using prjMDAComment;
using prjMDAComment.Models;
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

namespace prjMDA
{
    public partial class Frm評論 : Form
    {

        public Frm評論()
        {
            InitializeComponent();

            #region //cbBox var q

            var qMovie = from c in dbMDA.電影Movies.AsEnumerable()
                         orderby c.電影編號Movie_ID
                         select c.電影編號Movie_ID +" "+ c.中文標題Title_Cht;

            List<string> list電影 = qMovie.ToList();

            for (int i = 0; i < list電影.Count; i++)
                cbBox電影名稱.Items.Add($"{list電影[i]}");
            //////////////////////////////////////////////////////////////////
            var qView = from c in dbMDA.電影評論MovieComment.AsEnumerable()
                        group c by c.觀影方式Source into gv
                        orderby gv.Count() descending //熱門觀看方式排序
                        select gv.Key;

            List<string> list觀影 = qView.ToList();

            for (int i = 0; i < list觀影.Count; i++)
                cbBox觀影方式.Items.Add($"{list觀影[i]}");
            //////////////////////////////////////////////////////////////////
            var qRate = from c in dbMDA.電影評論MovieComment.AsEnumerable()
                        orderby Convert.ToInt32(c.評分Rate.Value)
                        group c by Convert.ToInt32(c.評分Rate.Value) into gv
                        select gv.Key;

            List<int> list評分 = qRate.ToList(); //轉int給SelectedIndex使用

            for (int i = 0; i < 5; i++)
                cbBox評分.Items.Add(new MyItem(list評分[i], $"{i+1}星"));
            //////////////////////////////////////////////////////////////////
            var qAnt = from c in dbMDA.電影評論MovieComment
                       orderby c.期待度anticipation.Value
                       group c by c.期待度anticipation.Value into gv
                       select gv.Key;

            List<decimal> list期待度 = qAnt.ToList(); //轉int給SelectedIndex使用

            for (int i = 0; i < 5; i++)
                cbBox期待度.Items.Add(new MyItem(list期待度[i], $"{i + 1}星"));
            //////////////////////////////////////////////////////////////////
            var qPublic = from c in dbMDA.電影評論MovieComment
                          orderby c.公開等級編號Public_ID.Value
                          group c by c.公開等級編號Public_ID.Value into gv
                          select gv.Key;

            List<int> list公開 = qPublic.ToList();

            cbBox公開等級.Items.Add(new MyItem(list公開[0], "0 公開"));
            cbBox公開等級.Items.Add(new MyItem(list公開[1], "1 僅追蹤者"));
            cbBox公開等級.Items.Add(new MyItem(list公開[2], "2 不公開"));
            //////////////////////////////////////////////////////////////////
            var qInvisible = from c in dbMDA.電影評論MovieComment
                             orderby c.屏蔽Invisible
                             group c by c.屏蔽Invisible into gv
                             select gv.Key;

            List<int> list屏蔽 = qInvisible.ToList();

            cbBox屏蔽狀態.Items.Add(new MyItem(list屏蔽[0], "0 正常"));
            cbBox屏蔽狀態.Items.Add(new MyItem(list屏蔽[1], "1 刪除"));
            cbBox屏蔽狀態.Items.Add(new MyItem(list屏蔽[2], "2 敏感言論過濾"));
            cbBox屏蔽狀態.Items.Add(new MyItem(list屏蔽[3], "3 檢舉屏蔽"));
            //////////////////////////////////////////////////////////////////
            var qReport = from c in dbMDA.電影評論MovieComment
                          orderby c.檢舉Report
                          group c by c.檢舉Report into gv
                          select gv.Key;
            List<int> list檢舉 = qReport.ToList();

            cbBox檢舉狀態.Items.Add(new MyItem(list檢舉[0], "0 正常"));
            cbBox檢舉狀態.Items.Add(new MyItem(list檢舉[1], "1 待審核"));
            cbBox檢舉狀態.Items.Add(new MyItem(list檢舉[2], "2 已審核"));
            //////////////////////////////////////////////////////////////////
            #endregion
            clear查詢清空();
            clear評論清空();
        }

        MDAEntities dbMDA = new MDAEntities();
        ImageToBinary image = new ImageToBinary();
        電影評論MovieComment tb電影評論 = new 電影評論MovieComment();

        //List<obj> objs = new List<obj>();
        //List<obj> showobj = new List<obj>();

        void clear查詢清空()
        {
            txt關鍵字.Text = "";
            txt查詢會員編號.Text = "";
            cbBox屏蔽狀態.SelectedIndex = 1;
            cbBox檢舉狀態.SelectedIndex = 1;
        }       

        void clear評論清空()
        {
            cbBox電影名稱.SelectedIndex = -1;
            cbBox觀影方式.SelectedIndex = -1;
            cbBox評分.SelectedIndex = -1;
            cbBox期待度.SelectedIndex = -1;
            cbBox公開等級.SelectedIndex = -1;
            flowLayoutPanel.Controls.Clear();
            txt評論編號.Text = "";
            txt會員編號.Text = "";
            txt會員暱稱.Text = "";
            txt電影編號.Text = "";
            cbBox電影名稱.SelectedText = "";
            cbBox電影名稱.SelectedItem = "";
            dtPicker觀影日期.Value = DateTime.Now;
            cbBox觀影方式.SelectedText = "";
            cbBox觀影方式.SelectedItem = "";
            dtPicker發佈時間.Value = DateTime.Now;
            cbBox評分.SelectedText = "";
            cbBox評分.SelectedItem = "";
            cbBox期待度.SelectedText = "";
            cbBox期待度.SelectedItem = "";
            cbBox公開等級.SelectedText = "";
            cbBox公開等級.SelectedItem = "";
            ckBox開放討論串yes.Checked = false;
            ckBox開放討論串no.Checked = false;
            txt評論標題.Text = "";
            rTxt評論內容.Text = "";
            txt狀態.Text = "";
            btnVerify.Enabled = false;
            cbBox屏蔽.SelectedIndex = -1;
            cbBox屏蔽.Enabled = false;
            picBoxUpDate.Image = null;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        void DataGridView刷新()
        {
            clear查詢清空();
            clear評論清空();
            this.dataGridView.DataSource = null;

            var q = from c in this.dbMDA.電影評論MovieComment.AsEnumerable()
                    from m in this.dbMDA.會員Members
                    from d in this.dbMDA.電影Movies
                    where c.會員編號Member_ID == m.會員編號Member_ID &&
                          c.電影編號Movie_ID == d.電影編號Movie_ID &&
                          c.屏蔽Invisible != 1 //已刪除的評論不顯示
                    orderby c.評論編號Comment_ID descending /*c.發佈時間Comment_Time descending*/
                    select new
                    {
                        評論編號 = c.評論編號Comment_ID,
                        評論標題 = c.評論標題Comment_Title,
                        電影編號 = c.電影編號Movie_ID,
                        評論電影 = d.中文標題Title_Cht,
                        評論內容 = c.評論內容Comments,
                        會員編號 = c.會員編號Member_ID,
                        發佈人 = m.暱稱NickName,
                        評分 = c.評分Rate,
                        期待度 = c.期待度anticipation,
                        觀影方式 = c.觀影方式Source,
                        觀影日期 = c.觀影日期Viewing_Time,
                        發佈時間 = c.發佈時間Comment_Time,
                        公開等級 = c.公開等級編號Public_ID, // 0公開/1限追蹤者/2不公開 
                        是否開放討論串 = c.是否開放討論串OX_Floor,
                        屏蔽狀態 = c.屏蔽Invisible, // 0正常/1刪除(會員)/2敏感言論屏蔽(自動過濾)/3檢舉屏蔽(管理員審核)
                        檢舉狀態 = c.檢舉Report // 0正常/1待審核/2審核>正常>不屏蔽/3審核>不正常>屏蔽
                    };

            txt_Count.Text = $"資料筆數: {q.Count()}筆";
            this.dataGridView.DataSource = q.ToList();
        }

        private void btn檢視_Click(object sender, EventArgs e)
        {
            DataGridView刷新();
        }

        private void btn關鍵字_Click(object sender, EventArgs e)
        {
            txt查詢會員編號.Text = "";
            cbBox屏蔽狀態.SelectedIndex = 1;
            cbBox檢舉狀態.SelectedIndex = 1;
            clear評論清空();

            var q = from c in dbMDA.電影評論MovieComment.AsEnumerable()
                    from m in this.dbMDA.會員Members
                    from d in this.dbMDA.電影Movies
                    where c.會員編號Member_ID == m.會員編號Member_ID &&
                          c.電影編號Movie_ID == d.電影編號Movie_ID
                    select new
                    {
                        評論編號 = c.評論編號Comment_ID,
                        評論標題 = c.評論標題Comment_Title,
                        電影編號 = c.電影編號Movie_ID,
                        評論電影 = d.中文標題Title_Cht,
                        評論內容 = c.評論內容Comments,
                        會員編號 = c.會員編號Member_ID,
                        發佈人 = m.暱稱NickName,
                        評分 = c.評分Rate,
                        期待度 = c.期待度anticipation,
                        觀影方式 = c.觀影方式Source,
                        觀影日期 = c.觀影日期Viewing_Time,
                        發佈時間 = c.發佈時間Comment_Time,
                        公開等級 = c.公開等級編號Public_ID,
                        是否開放討論串 = c.是否開放討論串OX_Floor,
                        屏蔽狀態 = c.屏蔽Invisible,
                        檢舉狀態 = c.檢舉Report
                    };

            var key = from cts in q
                      where cts.評論標題.ToUpper().Contains(txt關鍵字.Text.ToUpper()) ||
                            cts.評論電影.Contains(txt關鍵字.Text) ||
                            cts.評論內容.ToUpper().Contains(txt關鍵字.Text.ToUpper()) ||
                            cts.發佈人.ToUpper().Contains(txt關鍵字.Text.ToUpper()) ||
                            cts.觀影方式.ToUpper().Contains(txt關鍵字.Text.ToUpper())
                      select cts;

            if (txt關鍵字.Text == "")
            {
                MessageBox.Show("請輸入關鍵字查詢");
                return;
            }

            txt_Count.Text = $"資料筆數: {key.Count()}筆";
            this.dataGridView.DataSource = key.ToList();
        }

        private void btn查詢會員_Click(object sender, EventArgs e)
        {
            txt關鍵字.Text = "";
            cbBox屏蔽狀態.SelectedIndex = 1;
            cbBox檢舉狀態.SelectedIndex = 1;
            clear評論清空();

            if (txt查詢會員編號.Text == "")
                MessageBox.Show("請輸入會員編號");

            else if (txt查詢會員編號.Text != null)
            {
                txt會員編號.Enabled = false;
                var q = from c in this.dbMDA.電影評論MovieComment.AsEnumerable()
                        from m in this.dbMDA.會員Members
                        from d in this.dbMDA.電影Movies
                        where c.會員編號Member_ID == m.會員編號Member_ID &&
                              c.電影編號Movie_ID == d.電影編號Movie_ID &&
                              c.會員編號Member_ID == Convert.ToInt32(txt查詢會員編號.Text)
                        select new
                        {
                            評論編號 = c.評論編號Comment_ID,
                            評論標題 = c.評論標題Comment_Title,
                            電影編號 = c.電影編號Movie_ID,
                            評論電影 = d.中文標題Title_Cht,
                            評論內容 = c.評論內容Comments,
                            會員編號 = c.會員編號Member_ID,
                            發佈人 = m.暱稱NickName,
                            評分 = c.評分Rate,
                            期待度 = c.期待度anticipation,
                            觀影方式 = c.觀影方式Source,
                            觀影日期 = c.觀影日期Viewing_Time,
                            發佈時間 = c.發佈時間Comment_Time,
                            公開等級 = c.公開等級編號Public_ID,
                            是否開放討論串 = c.是否開放討論串OX_Floor,
                            屏蔽狀態 = c.屏蔽Invisible,
                            檢舉狀態 = c.檢舉Report
                        };
                
                #region //new obj()
                //select new obj()
                //{
                //    評論編號Comment_ID = c.評論編號Comment_ID,
                //    評論標題Comment_Title = c.評論標題Comment_Title,
                //    電影編號Movie_ID = c.電影編號Movie_ID,
                //    中文標題Title_Cht = d.中文標題Title_Cht,
                //    評論內容Comments = c.評論內容Comments,
                //    會員編號Member_ID = c.會員編號Member_ID,
                //    暱稱NickName = m.暱稱NickName,
                //    評分Rate = c.評分Rate,
                //    期待度anticipation = c.期待度anticipation,
                //    觀影方式Source = c.觀影方式Source,
                //    觀影日期Viewing_Time = c.觀影日期Viewing_Time,
                //    發佈時間Comment_Time = c.發佈時間Comment_Time,
                //    公開等級編號Public_ID = c.公開等級編號Public_ID,
                //    是否開放討論串OX_Floor = c.是否開放討論串OX_Floor,
                //    屏蔽Invisible = c.屏蔽Invisible,
                //    檢舉Report = c.檢舉Report
                //};
                //objs = q.ToList();
                #endregion

                txt_Count.Text = $"資料筆數: {q.Count()}筆";
                this.dataGridView.DataSource = q.ToList();

                if(!q.ToList().Any())
                    MessageBox.Show("無此會員編號,請重新查詢");

                //showobj= showobj.Where  //todo
            }
        }

        private void txt查詢會員編號_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                txt狀態.Text = $"{lab會員編號.Text}格式輸入錯誤";
            else
                txt狀態.Text = "";
        }

        private void btn查詢屏蔽_Click(object sender, EventArgs e)
        {
            txt關鍵字.Text = "";
            txt查詢會員編號.Text = "";
            cbBox檢舉狀態.SelectedIndex = 1;
            clear評論清空();

            var q = from c in dbMDA.電影評論MovieComment.AsEnumerable()
                    from m in this.dbMDA.會員Members
                    from d in this.dbMDA.電影Movies
                    where c.會員編號Member_ID == m.會員編號Member_ID &&
                          c.電影編號Movie_ID == d.電影編號Movie_ID &&
                          c.屏蔽Invisible == Convert.ToInt32(cbBox屏蔽狀態.SelectedIndex)
                    orderby c.屏蔽Invisible
                    select new
                    {
                        評論編號 = c.評論編號Comment_ID,
                        評論標題 = c.評論標題Comment_Title,
                        電影編號 = c.電影編號Movie_ID,
                        評論電影 = d.中文標題Title_Cht,
                        評論內容 = c.評論內容Comments,
                        會員編號 = c.會員編號Member_ID,
                        發佈人 = m.暱稱NickName,
                        評分 = c.評分Rate,
                        期待度 = c.期待度anticipation,
                        觀影方式 = c.觀影方式Source,
                        觀影日期 = c.觀影日期Viewing_Time,
                        發佈時間 = c.發佈時間Comment_Time,
                        公開等級 = c.公開等級編號Public_ID,
                        是否開放討論串 = c.是否開放討論串OX_Floor,
                        屏蔽狀態 = c.屏蔽Invisible,
                        檢舉狀態 = c.檢舉Report
                    };

            txt_Count.Text = $"資料筆數: {q.Count()}筆";
            this.dataGridView.DataSource = q.ToList();
        }

        private void btn查詢檢舉_Click(object sender, EventArgs e)
        {
            txt關鍵字.Text = "";
            txt查詢會員編號.Text = "";
            cbBox屏蔽狀態.SelectedIndex = 1;
            clear評論清空();
            var q = from c in dbMDA.電影評論MovieComment.AsEnumerable()
                    from m in this.dbMDA.會員Members
                    from d in this.dbMDA.電影Movies
                    where c.會員編號Member_ID == m.會員編號Member_ID &&
                          c.電影編號Movie_ID == d.電影編號Movie_ID &&
                          c.檢舉Report == Convert.ToInt32(cbBox檢舉狀態.SelectedIndex)
                    orderby c.檢舉Report
                    select new
                    {
                        評論編號 = c.評論編號Comment_ID,
                        評論標題 = c.評論標題Comment_Title,
                        電影編號 = c.電影編號Movie_ID,
                        評論電影 = d.中文標題Title_Cht,
                        評論內容 = c.評論內容Comments,
                        會員編號 = c.會員編號Member_ID,
                        發佈人 = m.暱稱NickName,
                        評分 = c.評分Rate,
                        期待度 = c.期待度anticipation,
                        觀影方式 = c.觀影方式Source,
                        觀影日期 = c.觀影日期Viewing_Time,
                        發佈時間 = c.發佈時間Comment_Time,
                        公開等級 = c.公開等級編號Public_ID,
                        是否開放討論串 = c.是否開放討論串OX_Floor,
                        屏蔽狀態 = c.屏蔽Invisible,
                        檢舉狀態 = c.檢舉Report
                    };

            txt_Count.Text = $"資料筆數: {q.Count()}筆";
            this.dataGridView.DataSource = q.ToList();
        }

        private void dataGridView_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.dataGridView.CurrentRow == null)
            { return; }

            //多圖顯示
            int id評論 = Convert.ToInt32(dataGridView.CurrentRow.Cells["評論編號"].Value);
            this.flowLayoutPanel.Controls.Clear();

            var q = this.dbMDA.評論圖片明細CommentImagesList
                .Where(p => p.評論編號Comment_ID == id評論)
                .Where(r => r.評論圖片總表CommentImages.屏蔽Invisible == 0)
                .Select(p => p.評論圖片總表CommentImages);

            foreach (var item in q)
            {
                UserControlPics ucPics = new UserControlPics();
                ucPics.us圖片編號set = "圖片編號:" + item.評論圖庫編號CommentImage_ID.ToString();
                ucPics.us評論圖片set = item.圖片Image;
                ucPics.Del評論圖片.Click += Del評論圖片_Click;
                ucPics.Del評論圖片.Tag = item.評論圖庫編號CommentImage_ID;
                this.flowLayoutPanel.Controls.Add(ucPics);
                Application.DoEvents();
            }
        }

        private void dataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            clear評論清空();
            if (dataGridView.CurrentRow == null){ return; }

            txt評論編號.Text = dataGridView.CurrentRow.Cells["評論編號"].Value.ToString();
            if(txt評論編號.Text!=null)
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            txt會員編號.Text = dataGridView.CurrentRow.Cells["會員編號"].Value.ToString();
            txt會員暱稱.Text = dataGridView.CurrentRow.Cells["發佈人"].Value.ToString();
            txt電影編號.Text = dataGridView.CurrentRow.Cells["電影編號"].Value.ToString();
            cbBox電影名稱.SelectedItem = dataGridView.CurrentRow.Cells["評論電影"].Value;
            cbBox電影名稱.SelectedIndex = Convert.ToInt32(dataGridView.CurrentRow.Cells["電影編號"].Value) - 1;
            dtPicker觀影日期.Value = Convert.ToDateTime(dataGridView.CurrentRow.Cells["觀影日期"].Value);
            cbBox觀影方式.SelectedItem = dataGridView.CurrentRow.Cells["觀影方式"].Value;
            dtPicker發佈時間.Value = Convert.ToDateTime(dataGridView.CurrentRow.Cells["發佈時間"].Value);
            cbBox評分.SelectedItem = dataGridView.CurrentRow.Cells["評分"].Value;
            cbBox評分.SelectedIndex = Convert.ToInt32(dataGridView.CurrentRow.Cells["評分"].Value) - 1;
            cbBox期待度.SelectedItem = dataGridView.CurrentRow.Cells["期待度"].Value;
            cbBox期待度.SelectedIndex = Convert.ToInt32(dataGridView.CurrentRow.Cells["期待度"].Value) - 1;
            cbBox公開等級.SelectedItem = dataGridView.CurrentRow.Cells["公開等級"].Value;
            cbBox公開等級.SelectedIndex = Convert.ToInt32(dataGridView.CurrentRow.Cells["公開等級"].Value);
            ckBox開放討論串yes.Checked = Convert.ToBoolean(dataGridView.CurrentRow.Cells["是否開放討論串"].Value);
            //ckBox開放討論串no.Checked = Convert.ToBoolean(dataGridView.CurrentRow.Cells["是否開放討論串"].Value);
            if (ckBox開放討論串yes.Checked != true)
                ckBox開放討論串no.Checked = true;
            txt評論標題.Text = dataGridView.CurrentRow.Cells["評論標題"].Value.ToString();
            rTxt評論內容.Text = dataGridView.CurrentRow.Cells["評論內容"].Value.ToString();
            cbBox屏蔽狀態.SelectedItem = dataGridView.CurrentRow.Cells["屏蔽狀態"].Value;
            cbBox檢舉狀態.SelectedItem = dataGridView.CurrentRow.Cells["檢舉狀態"].Value;
            inv= Convert.ToInt32(dataGridView.CurrentRow.Cells["屏蔽狀態"].Value);
            Rep= Convert.ToInt32(dataGridView.CurrentRow.Cells["檢舉狀態"].Value);

            if (inv == 1)
            {
                btn刪除回復.Enabled = true;
                btnDelete.Enabled = false;
            }
            else
            {
                btn刪除回復.Enabled = false;
                btnDelete.Enabled = true;
            }

            if (Rep == 1)
            {
                btnVerify.Enabled = true;
                cbBox屏蔽.Enabled = true;
            }
            else
            {
                btnVerify.Enabled = false;
                cbBox屏蔽.Enabled = false;
            }

            if (inv == 0 && Rep == 1)
                lab審核狀態.Text = "狀態:待審核";
            else if((inv == 3 && Rep == 2) || (inv == 0 && Rep == 2))
                lab審核狀態.Text = "狀態:已審核";
            else
                lab審核狀態.Text = "";
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            電影評論MovieComment tb電影評論 = new 電影評論MovieComment();
            //tb電影評論.評論編號Comment_ID  //PK
            txt評論編號.Text = "";
            txt會員編號.Text = "1";
            txt會員暱稱.Text = "Yuka";
            txt電影編號.Text = "1";
            cbBox電影名稱.SelectedIndex = 0;
            dtPicker觀影日期.Value = Convert.ToDateTime("2022-09-04");
            cbBox觀影方式.SelectedIndex = 0;
            dtPicker發佈時間.Value = DateTime.Now;
            cbBox評分.SelectedIndex = 4;
            cbBox期待度.SelectedIndex = -1;
            cbBox公開等級.SelectedIndex = 0;
            ckBox開放討論串yes.Checked = true;
            txt評論標題.Text = "魔法經典，傳奇再現";
            rTxt評論內容.Text = $"【一言以蔽之】：帶我們回到魔法世界的起源，時隔20年依然精采絕倫\n\n" +
                $"1997年起，由英國作家J.K.羅琳撰寫的《哈利波特》系列小說，帶起奇幻文學風潮，改編成電影之後更是紅遍全世界，如今距離2001年的第一部電影《哈利波特：神秘的魔法石》已經過了20年，電影公司將這部電影重新上映，除了是「20週年粉絲同樂會」之外，也讓當時來不及參與的年輕觀眾有機會認識經典。\n\n" +
                $"《哈利波特：神秘的魔法石》改編自本系列第一本小說，描述一個背負傳奇命運的男孩，踏入一個平凡人看不見的魔法世界，在那裡，貓頭鷹會送信，學校是一棟豪華城堡，老師可以變成貓，騎著魔法掃帚還可以飛上天，整個故事以奇幻元素穿針引線，結合青少年成長、校園喜劇、懸疑推理元素，透過豐富的想像力帶來愉快的觀影體驗，證明真正好看的電影，即使過了20年，還是一樣令人感動！";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txt會員編號.Text == "" && txt電影編號.Text == "")
            {
                MessageBox.Show("請輸入評論");
                return;
            }

            //tb電影評論.評論編號Comment_ID  //PK
            tb電影評論.會員編號Member_ID = 1; //todo 抓登入的會員編號
            tb電影評論.電影編號Movie_ID = Convert.ToInt32(txt電影編號.Text); //cbBox電影名稱_SelectedIndexChanged
            tb電影評論.觀影日期Viewing_Time = dtPicker觀影日期.Value;
            tb電影評論.觀影方式Source = cbBox觀影方式.Text;
            tb電影評論.發佈時間Comment_Time = dtPicker發佈時間.Value;
            tb電影評論.評分Rate = Convert.ToDecimal(cbBox評分.SelectedIndex+1);
            tb電影評論.期待度anticipation = Convert.ToDecimal(cbBox期待度.SelectedIndex+1);
            tb電影評論.公開等級編號Public_ID = Convert.ToInt32(cbBox公開等級.SelectedIndex);
            if (ckBox開放討論串yes.Checked == false && ckBox開放討論串no.Checked == false)
                tb電影評論.是否開放討論串OX_Floor = true ; //兩個都沒勾的話 預設true
            else
            tb電影評論.是否開放討論串OX_Floor = ckBox開放討論串yes.Checked;
            tb電影評論.評論標題Comment_Title = txt評論標題.Text;
            tb電影評論.評論內容Comments = rTxt評論內容.Text;

            if (picBoxUpDate.Image != null) //有上傳圖片
            {
             評論圖片總表CommentImages tb評論圖片總表 = new 評論圖片總表CommentImages();
             評論圖片明細CommentImagesList tb評論圖片明細 = new 評論圖片明細CommentImagesList();

             tb評論圖片總表.圖片Image = image.ConvertToByte(this.picBoxUpDate.Image);
            this.dbMDA.評論圖片總表CommentImages.Add(tb評論圖片總表);
            this.dbMDA.SaveChanges(); //圖片進評論圖庫總表 產生圖庫總表ID

            //剛新增的圖片 圖庫總表ID
            int id評論圖片 = this.dbMDA.評論圖片總表CommentImages.AsEnumerable().Select(y => y.評論圖庫編號CommentImage_ID).Last();
            this.dbMDA.電影評論MovieComment.Add(tb電影評論);
            this.dbMDA.SaveChanges(); //評論進電影評論 產生評論編號ID

            //剛新增的評論 評論編號ID
            int id評論 = this.dbMDA.電影評論MovieComment.AsEnumerable().Last().評論編號Comment_ID;
            tb評論圖片明細.評論圖庫編號CommentImage_ID = id評論圖片;
            tb評論圖片明細.評論編號Comment_ID = id評論;
            this.dbMDA.評論圖片明細CommentImagesList.Add(tb評論圖片明細);
            this.dbMDA.SaveChanges(); //評論ID 圖片ID 進評論圖片明細
            }
            else
            {
                this.dbMDA.電影評論MovieComment.Add(tb電影評論);
                this.dbMDA.SaveChanges(); //評論進電影評論 評論編號ID
            }

            picBoxUpDate.Image = null;
            DataGridView刷新();
            MessageBox.Show($"第{this.dbMDA.電影評論MovieComment.Count()}筆評論新增成功");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var q = (from c in dbMDA.電影評論MovieComment.AsEnumerable()
                     where c.評論編號Comment_ID == Convert.ToInt32(txt評論編號.Text)
                     select c).FirstOrDefault();

            if (q == null)
                return;

            q.會員編號Member_ID = Convert.ToInt32(txt會員編號.Text);
            q.電影編號Movie_ID = Convert.ToInt32(txt電影編號.Text);
            q.觀影日期Viewing_Time = dtPicker觀影日期.Value;
            q.觀影方式Source = cbBox觀影方式.Text;
            q.發佈時間Comment_Time = dtPicker發佈時間.Value;
            q.評分Rate = Convert.ToDecimal(cbBox評分.SelectedIndex + 1);
            q.期待度anticipation = Convert.ToDecimal(cbBox期待度.SelectedIndex + 1);
            q.公開等級編號Public_ID = Convert.ToInt32(cbBox公開等級.SelectedIndex);
            q.是否開放討論串OX_Floor = ckBox開放討論串yes.Checked;
            q.評論標題Comment_Title = txt評論標題.Text;
            q.評論內容Comments = rTxt評論內容.Text;

            if (picBoxUpDate.Image != null)
            {
                評論圖片總表CommentImages tb評論圖片總表 = new 評論圖片總表CommentImages();
                評論圖片明細CommentImagesList tb評論圖片明細 = new 評論圖片明細CommentImagesList();

                tb評論圖片總表.圖片Image = image.ConvertToByte(this.picBoxUpDate.Image);
                this.dbMDA.評論圖片總表CommentImages.Add(tb評論圖片總表);
                this.dbMDA.SaveChanges(); //圖片進評論圖庫總表 產生圖庫總表ID

                //剛新增的圖片 圖庫總表ID
                int id評論圖片 = this.dbMDA.評論圖片總表CommentImages.AsEnumerable().Select(y => y.評論圖庫編號CommentImage_ID).Last();

                tb評論圖片明細.評論圖庫編號CommentImage_ID = id評論圖片;
                tb評論圖片明細.評論編號Comment_ID = q.評論編號Comment_ID;
                this.dbMDA.評論圖片明細CommentImagesList.Add(tb評論圖片明細);
            }

            this.dbMDA.SaveChanges(); //評論ID 圖片ID 進評論圖片明細
            MessageBox.Show($"第{txt評論編號.Text}筆評論修改成功");
            DataGridView刷新();
        }

        private void btnDelete_Click(object sender, EventArgs e) //屏蔽 index要變1
        {
            var q = (from c in dbMDA.電影評論MovieComment.AsEnumerable()
                     where c.評論編號Comment_ID == Convert.ToInt32(txt評論編號.Text)
                     select c).FirstOrDefault();

            if (q == null)
                return;

            q.屏蔽Invisible = 1;

            this.dbMDA.SaveChanges();
            MessageBox.Show($"第{txt評論編號.Text}筆評論刪除成功");
            DataGridView刷新();
        }

        private void btn刪除回復_Click(object sender, EventArgs e) //屏蔽回復 index變回0
        {
            var q = (from c in dbMDA.電影評論MovieComment.AsEnumerable()
                     where c.評論編號Comment_ID == Convert.ToInt32(txt評論編號.Text)
                     select c).FirstOrDefault();

            if (q == null)
                return;

            q.屏蔽Invisible = 0;

            this.dbMDA.SaveChanges();
            MessageBox.Show($"第{txt評論編號.Text}筆評論回復成功");
            DataGridView刷新();
            btn刪除回復.Enabled = false;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            var q = (from c in dbMDA.電影評論MovieComment.AsEnumerable()
                     where c.評論編號Comment_ID == Convert.ToInt32(txt評論編號.Text)
                     select c).FirstOrDefault();

            if (q == null)
                return;
            q.屏蔽Invisible = cbBox屏蔽.SelectedIndex;
            q.檢舉Report = 2;

            this.dbMDA.SaveChanges();
            MessageBox.Show($"第{txt評論編號.Text}筆評論審核成功");
            DataGridView刷新();
            btnVerify.Enabled = false;
            txt狀態.Text = "";
        }

        private void btn_Browse_Click(object sender, EventArgs e)
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
                filePath = OPfile.FileName;
                var fileStream = OPfile.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    picBoxUpDate.Image = Image.FromFile(OPfile.FileName);
                }
            }
        }

        private void Del評論圖片_Click(object sender, EventArgs e)
        {
            PictureBox box = sender as PictureBox;
            var q = this.dbMDA.評論圖片總表CommentImages.AsEnumerable()
                .Where(p => p.評論圖庫編號CommentImage_ID == Convert.ToInt32(box.Tag)).SingleOrDefault();

            q.屏蔽Invisible = 1;

            this.dbMDA.SaveChanges();
            MessageBox.Show($"評論圖片[{q.評論圖庫編號CommentImage_ID}] 刪除成功");

            foreach(UserControlPics us in this.flowLayoutPanel.Controls) //多圖 選擇屏蔽後移除該圖
            {
                if (us.Del評論圖片.Tag == box.Tag)
                    this.flowLayoutPanel.Controls.Remove(us);
            }
        }

        private void cbBox電影名稱_SelectedIndexChanged(object sender, EventArgs e) //選電影名稱 電影編號跟著變更
        {
            txt電影編號.Text = (cbBox電影名稱.SelectedIndex + 1).ToString();
        }

        private void ckBox開放討論串yes_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBox開放討論串yes.Checked) 
                ckBox開放討論串no.Checked = false;
        }
        private void ckBox開放討論串no_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBox開放討論串no.Checked )
                ckBox開放討論串yes.Checked = false;
        }

        int inv, Rep;
        private void btnVerify_EnabledChanged(object sender, EventArgs e)
        {
            if (btnVerify.Enabled != false)
                cbBox屏蔽.SelectedIndex = 3;
            else
                cbBox屏蔽.SelectedIndex = -1;
        }

        private void txt評論編號_TextChanged(object sender, EventArgs e)
        {
            if (txt評論編號.Text == "")
            {
                btnDemo.Enabled = true;
                btnInsert.Enabled = true;
            }
            else
            {
                btnDemo.Enabled = false;
                btnInsert.Enabled = false;
            }
        }
    }
}
