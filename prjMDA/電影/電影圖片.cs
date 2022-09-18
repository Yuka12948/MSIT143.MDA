using prjMDA.Models;
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
    public partial class 電影圖片 : Form
    {
        public 電影圖片()
        {
            InitializeComponent();
            loadDate();
        }
        private void loadDate()
        {
            var q1 = dbContext.電影圖片MovieIImagesList.Select(p => new C圖片
            {
                圖片Image = p.電影圖片總表MovieImages.圖片Image,
                圖片編號Image_ID = p.圖片編號Image_ID,
                電影編號Movie_ID = p.電影編號Movie_ID,
                中文標題Title_Cht = p.電影Movies.中文標題Title_Cht,
                屏蔽Invisible = p.電影圖片總表MovieImages.屏蔽Invisible
            }) ;
            var q2 = from p in q1
                     where p.屏蔽Invisible == 0
                     select p;

            listALL = q2.ToList();
        }
        電影圖片總表MovieImages current電影圖片總表MovieImages = new 電影圖片總表MovieImages();
        電影圖片MovieIImagesList current電影圖片ImagesList = new 電影圖片MovieIImagesList();
        ImageToBinary image = new ImageToBinary();
        MDAEntities dbContext = new MDAEntities();
        
        bool Insertflag = false;
        bool Uppdateflag = false;

        void Read_RefreshDataGridView()
        {
            listBox1.Items.Clear();
            this.flowLayoutPanel1.Controls.Clear();
            Insertflag = false;
            Uppdateflag = false;

            var q1 = from p in dbContext.電影圖片MovieIImagesList
                     from r in dbContext.電影圖片總表MovieImages
                     where p.圖片編號Image_ID==r.圖片編號Image_ID
                     select new
                     {
                         電影編號 = p.電影編號Movie_ID,
                         中文標題 = p.電影Movies.中文標題Title_Cht,
                         屏蔽=r.屏蔽Invisible == 0,
                     };

            var q2 = from p in dbContext.電影圖片MovieIImagesList
                     select new
                     {
                         電影編號 = p.電影編號Movie_ID,
                         中文標題 = p.電影Movies.中文標題Title_Cht,

                     };

            var q3 = from p in dbContext.電影Movies
                     select new
                     {
                         電影編號 = p.電影編號Movie_ID,
                         中文標題 = p.中文標題Title_Cht,
                     };

            if (cboMovie.SelectedItem.ToString() == "有圖片的電影")
            {
                foreach (var item in q1.Distinct())
                {
                    listBox1.Items.Add(item.電影編號 + " " + item.中文標題);
                }
                lab電影數量.Text =$"筆數:{q2.Distinct().Count()}";
            }
            else if (cboMovie.SelectedItem.ToString() == "沒圖片的電影")
            {
                foreach (var item in q3.Except(q2).Distinct())
                {
                    listBox1.Items.Add(item.電影編號 + " " + item.中文標題);
                }
                lab電影數量.Text = $"筆數:{q3.Except(q2).Distinct().Count()}";
            }

            loadDate();

            }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            txt搜尋.Text = "";
            txt電影編號.Text = "";
            txt圖片編號.Text = "";
            Read_RefreshDataGridView();
        }



        private void btn新增圖片_Click(object sender, EventArgs e)
        {
            ////labState.Text = "狀態";
            txt圖片編號.Text = "";
            if (Insertflag == false) 
            {
                pictureBox1.Image = null;
                OpenFileDialog open = new OpenFileDialog();
                open.FileName = "*.png;*.jpg;*.gif";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(open.FileName);
                }
                else
                    return;
                Insertflag = true;
            }
            else
            {
                string[] str = listBox1.SelectedItem.ToString().Split(' ');
                電影圖片總表MovieImages newImages電影圖片總表 = new 電影圖片總表MovieImages();
                電影圖片MovieIImagesList newList電影圖片 = new 電影圖片MovieIImagesList();

                newImages電影圖片總表.圖片Image = current電影圖片總表MovieImages.圖片Image;
                newImages電影圖片總表.圖片編號Image_ID = current電影圖片總表MovieImages.圖片編號Image_ID;



                newImages電影圖片總表.圖片Image = image.ConvertToByte(this.pictureBox1.Image);
                this.dbContext.電影圖片總表MovieImages.Add(newImages電影圖片總表);
                this.dbContext.SaveChanges(); //電影圖片總表 圖片編號

                newList電影圖片.電影編號Movie_ID = current電影圖片ImagesList.電影編號Movie_ID;
                newList電影圖片.圖片編號Image_ID = current電影圖片ImagesList.圖片編號Image_ID;

                int id圖片 = this.dbContext.電影圖片總表MovieImages.AsEnumerable().Select(y => y.圖片編號Image_ID).Last();
                newList電影圖片.電影編號Movie_ID = Convert.ToInt32(str[0]); //listbox 電影編號
                newList電影圖片.圖片編號Image_ID = id圖片;
                this.dbContext.電影圖片MovieIImagesList.Add(newList電影圖片);
                this.dbContext.SaveChanges();

                pictureBox1.Image = null;
                int x = this.dbContext.電影圖片總表MovieImages.Count();
                MessageBox.Show($"新增圖片({id圖片}) 至 電影編號: {str[0]}");
                this.Read_RefreshDataGridView();
            }

        }

        private void btn修改圖片_Click(object sender, EventArgs e)
        {
            if (txt圖片編號.Text == "")
            { return; }

            var q = (from p in this.dbContext.電影圖片總表MovieImages.AsEnumerable()
                     where p.圖片編號Image_ID == Convert.ToInt32(txt圖片編號.Text)
                     select p).FirstOrDefault();
            if (q == null)
                return;
            ////int x = Convert.ToInt32(dataGridView1.CurrentRow.Cells["圖片ID"].Value);
            if (Uppdateflag == false)
            {
                pictureBox1.Image = null;
                OpenFileDialog open = new OpenFileDialog();
                open.FileName = "*.png;*.jpg;*.gif";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(open.FileName);
                }
                Uppdateflag = true;
            }
            else
            {
                q.圖片Image = image.ConvertToByte(pictureBox1.Image);
                this.dbContext.SaveChanges();
                pictureBox1.Image = null;
                Read_RefreshDataGridView();
                MessageBox.Show("修改編號 : " + txt圖片編號.Text + " 的圖片成功");
            }
        }


        private void btn搜尋_Click(object sender, EventArgs e) //搜尋listbox電影
        {
            if (txt搜尋.Text == "")
            { return; }
            listBox1.Items.Clear();


            if (cboMovie.SelectedItem.ToString() == "有圖片的電影")
            {
                var q = listALL.Where(p => p.中文標題Title_Cht.Contains(txt搜尋.Text)).Where(p => p.屏蔽Invisible == 0);
                //var q = from p in listALL
                //        where p.中文標題Title_Cht.Contains(txt搜尋.Text) || p.電影編號Movie_ID.ToString() == txt搜尋.Text&&p.屏蔽Invisible==0
                //        select p;

                foreach (var item in q.Distinct())
                {
                    listBox1.Items.Add(item.電影編號Movie_ID + " " + item.中文標題Title_Cht);
                }
            }
            else if (cboMovie.SelectedItem.ToString() == "沒圖片的電影")
            {
                var q2 = this.dbContext.電影Movies.Where(m => m.電影圖片MovieIImagesList.Any()==false);
                var q = from p in q2
                        where p.中文標題Title_Cht.Contains(txt搜尋.Text) || p.電影編號Movie_ID.ToString() == txt搜尋.Text
                        select p;

                foreach (var item in q.Distinct())
                    {
                        listBox1.Items.Add(item.電影編號Movie_ID + " " + item.中文標題Title_Cht);
                    }           
            }
        }



        private void cboPicturelist_SelectedIndexChanged(object sender, EventArgs e)
        {

            var q = from p in dbContext.電影圖片總表MovieImages
                    orderby p.圖片編號Image_ID
                    select new
                    {
                        圖片ID = p.圖片編號Image_ID,
                        圖片 = p.圖片Image,
                    };


            var q1 = from p in dbContext.電影圖片總表MovieImages
                     from r in dbContext.電影圖片MovieIImagesList
                     select new
                     {
                         圖片ID = r.圖片編號Image_ID,
                         圖片 = p.圖片Image,
                     };

        }
        List<電影Movies> allMovie = new List<電影Movies>();
        List<C圖片> listALL=new List<C圖片>(); 
        List<C圖片> listSelect = new List<C圖片>();
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;
            this.flowLayoutPanel1.Controls.Clear();
            ListBox box = sender as ListBox;
            string[] str = box.SelectedItem.ToString().Split(' ');
            int id = Convert.ToInt32(str[0]);
            txt電影編號.Text =id.ToString();
            var q1 = listALL.Where(p => p.電影編號Movie_ID == id&&p.屏蔽Invisible==0);

            foreach(var item in q1)
            {
                UserControl1 us = new UserControl1();
                us.Desc = "編號：" + item.圖片編號Image_ID.ToString();
                us.Bytes = item.圖片Image;
                us.picbox.Click += Picbox_Click;
                us.picbox.Tag = item.圖片編號Image_ID;
                us.picbox.Enabled = true;
                us.Click += Us_Click;
                this.flowLayoutPanel1.Controls.Add(us);
                Application.DoEvents();
            }
        }

        private void Picbox_Click(object sender, EventArgs e)
        {
            PictureBox box = sender as PictureBox;
            var q = dbContext.電影圖片總表MovieImages.AsEnumerable().Where(p => p.圖片編號Image_ID == Convert.ToInt32(box.Tag)).SingleOrDefault();
            q.屏蔽Invisible = 1;
            dbContext.SaveChanges();
            MessageBox.Show("屏蔽編號 : " + box.Tag + " 的圖片成功");
            this.flowLayoutPanel1.Controls.Clear();

            loadDate();
        }

        private void Us_Click(object sender, EventArgs e)
        {
            UserControl1 pictureBox = sender as UserControl1;
            //pictureBox1.Image = pictureBox.pic;

            string[] arr圖片編號 = pictureBox.lab.ToString().Split('：');
            txt圖片編號.Text = arr圖片編號[1];
        }



        private void delete(int 圖片編號,int 電影編號)
        {
            var q = dbContext.電影圖片MovieIImagesList;
            var d=q.Where(s=>s.圖片編號Image_ID== 圖片編號&&s.電影圖片編號MI_ID== 電影編號).SingleOrDefault();

            this.dbContext.電影圖片MovieIImagesList.Remove(d);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            delete(int.Parse(txt圖片編號.Text), int.Parse(txt電影編號.Text));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Read_RefreshDataGridView();
        }

        private void 電影圖片_Load(object sender, EventArgs e)
        {

        }
    }
}
