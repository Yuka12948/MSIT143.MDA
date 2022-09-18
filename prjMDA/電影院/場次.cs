using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjMDA.Models;

namespace prjMDA
{
    
    public partial class Frm電影場次 : Form
    {
        MDAEntities 場次data = new MDAEntities();
        private int _id = -1;
        public Frm電影場次()
        {
            InitializeComponent();
            var q = from p in 場次data.場次Screening
                    select new { 
                    p.場次編號Screening_ID,
                    p.影廳編號Cinema_ID,
                    p.電影代碼Movie_Code,
                    p.放映日期Play_Date,
                    p.放映開始時間Play_Time};
            dataGridView1.DataSource = q.ToList();
            拉取資料();
        }
        private void 清空()
        {
            放映日期txt.Text = "";
            電影院box.Text = "";
            電影代碼Box2.Text = "";
            放映開始box.Text = "";
            影城Box.Text = "";
            地區Box.Text = "";
            影廳Box.Text = "";

        }
        private void 拉取資料()
        {          
            電影代碼Box2.Items.Clear();
            查詢box.Items.Clear();
            var q = 場次data.影城MainTheater.Select(r => r.影城名稱MainTheater_Name);
            foreach (var r in q)影城Box.Items.Add(r);
            var p = 場次data.電影代碼MovieCode.Select(r => r.電影代碼編號MovieCode_ID);
            foreach (var r in p)電影代碼Box2.Items.Add(r);           
            var i = 場次data.場次Screening.Select(r => r.放映日期Play_Date);
            foreach (var r in i) 查詢box.Items.Add(r);
            var j = 場次data.場次Screening.Select(r => r.放映開始時間Play_Time);
            foreach (var r in j) 查詢box.Items.Add(r);
        }
        private void 新增_Click(object sender, EventArgs e)
        {
            var q = (from p in 場次data.場次Screening
                     select p).Any();
            int ID1 = this.場次data.影廳Cinema.Where(m => m.影廳名稱Cinema_Name == 影廳Box.Text).Select(m => m.影廳編號Cinema_ID).FirstOrDefault();
            if (影廳Box.Text == "" || 電影代碼Box2.Text == "" || 放映日期txt.Text == "" || 放映開始box.Text == "")
            {
                MessageBox.Show("資料有誤");
                return;
            }
            場次Screening movie = new 場次Screening();            
                movie.放映日期Play_Date =DateTime.Parse( 放映日期txt.Text);
                movie.影廳編號Cinema_ID = ID1;
                movie.電影代碼Movie_Code = int.Parse(電影代碼Box2.Text);
                movie.放映開始時間Play_Time =放映開始box.Text;
                this.場次data.場次Screening.Add(movie);
                this.場次data.SaveChanges();              
                紀錄方法();
                清空();
                MessageBox.Show("新增成功");            
        }
        private void 紀錄方法()
        {
            dataGridView1.DataSource = null;
            var q = from p in 場次data.場次Screening
                    select new
                    {
                        p.場次編號Screening_ID,
                        p.影廳編號Cinema_ID,
                        p.電影代碼Movie_Code,
                        p.放映日期Play_Date,
                        p.放映開始時間Play_Time
                    };
            dataGridView1.DataSource = q.ToList();
        }

        private void 修改_Click(object sender, EventArgs e)
        {
            var q = this.場次data.場次Screening.Where(m => m.場次編號Screening_ID == _id).SingleOrDefault();
            int ID1 = this.場次data.影廳Cinema.Where(m => m.影廳名稱Cinema_Name == 影廳Box.Text).Select(m => m.影廳編號Cinema_ID).FirstOrDefault();

            if (影廳Box.Text == "" || 電影代碼Box2.Text == "" || 放映日期txt.Text == "" || 放映開始box.Text == "")
            {
                MessageBox.Show("資料有誤");
                return;
            }
                q.放映日期Play_Date = DateTime.Parse(放映日期txt.Text);
                q.影廳編號Cinema_ID = Convert.ToInt32(影廳Box.Text);
                q.電影代碼Movie_Code = Convert.ToInt32(電影代碼Box2.Text);
                q.放映開始時間Play_Time = 放映開始box.Text;
                this.場次data.SaveChanges();
                紀錄方法();               
                清空();
                MessageBox.Show("修改成功");
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.CurrentRow is null)
                return;
            _id = (int)dataGridView1.CurrentRow.Cells[0].Value;           
            場次Screening movie = this.場次data.場次Screening.Where(m => m.場次編號Screening_ID == _id).SingleOrDefault();
            string Name = 場次data.影廳Cinema.Where(x => x.影廳編號Cinema_ID == movie.影廳編號Cinema_ID).Select(x => x.影廳名稱Cinema_Name).FirstOrDefault();
            if (movie == null) { return; }
            影廳Box.Text =Name;
            放映開始box.Text = movie.放映開始時間Play_Time.ToString();
            電影代碼Box2.Text = movie.電影代碼Movie_Code.ToString();
            放映日期txt.Text = movie.放映日期Play_Date.ToString();
            場次data = new MDAEntities();
        }     
        private void 查詢_Click(object sender, EventArgs e)
        {
            if (查詢txt.Text == "")
            {
                MessageBox.Show("請輸入資料");
                return;
            }
            int x = int.Parse(查詢txt.Text);
            var i = from p in 場次data.場次Screening
                    where p.放映日期Play_Date.ToString().Contains(查詢txt.Text) ||
                    p.放映開始時間Play_Time.Contains(查詢txt.Text) 
                    select new
                    {
                        p.場次編號Screening_ID,
                        p.影廳編號Cinema_ID,
                        p.電影代碼Movie_Code,
                        p.放映日期Play_Date,
                        p.放映開始時間Play_Time
                    };

            dataGridView1.DataSource = i.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            紀錄方法();
            拉取資料();
            清空();
        }

        private void 查詢box_SelectedValueChanged(object sender, EventArgs e)
        {
            if (查詢box.Text == "")
            {
                MessageBox.Show("請輸入資料");
                return;
            }
            DateTime x = DateTime.Parse(查詢box.Text);
            var i = from p in 場次data.場次Screening
                    where p.放映日期Play_Date== x ||
                    p.放映開始時間Play_Time.Contains(查詢txt.Text)
                    select new
                    {
                        p.場次編號Screening_ID,
                        p.影廳編號Cinema_ID,
                        p.電影代碼MovieCode,
                        p.放映日期Play_Date,
                        p.放映開始時間Play_Time
                    };
            dataGridView1.DataSource = i.ToList();
        }

        private void 地區Box_TextChanged(object sender, EventArgs e)
        {
            電影院box.Items.Clear();
            if (影城Box.Text == "")
            {
                var i = 場次data.電影院Theater.Where(r => r.地址Address.Contains(地區Box.Text)).Select(r => r.電影院名稱Theater_Name);
                foreach (var r in i)
                    電影院box.Items.Add(r);
            }
            else
            {
                int ID = 場次data.影城MainTheater.Where(r => r.影城名稱MainTheater_Name == 影城Box.Text).Select(x => x.影城編號MainTheater_ID).FirstOrDefault();
                var i = 場次data.電影院Theater.Where(r => r.影城編號MainTheater_ID == ID && r.地址Address.Contains(地區Box.Text)).Select(r => r.電影院名稱Theater_Name);
                foreach (var r in i)
                    電影院box.Items.Add(r);
            }
        }

        private void 影城Box_SelectedValueChanged(object sender, EventArgs e)
        {
            電影院box.Items.Clear();
            if (地區Box.Text == "")
            {
                int ID = 場次data.影城MainTheater.Where(r => r.影城名稱MainTheater_Name == 影城Box.Text).Select(x => x.影城編號MainTheater_ID).FirstOrDefault();
                var i = 場次data.電影院Theater.Where(r => r.影城編號MainTheater_ID == ID).Select(r => r.電影院名稱Theater_Name);
                foreach (var r in i)
                    電影院box.Items.Add(r);
            }
            else
            {
                int ID = 場次data.影城MainTheater.Where(r => r.影城名稱MainTheater_Name == 影城Box.Text).Select(x => x.影城編號MainTheater_ID).FirstOrDefault();
                var i = 場次data.電影院Theater.Where(r => r.影城編號MainTheater_ID == ID && r.地址Address.Contains(地區Box.Text)).Select(r => r.電影院名稱Theater_Name);
                foreach (var r in i)
                    電影院box.Items.Add(r);
            }

        }

        private void 電影院box_SelectedValueChanged(object sender, EventArgs e)
        {
            影廳Box.Items.Clear();
            int id = 場次data.電影院Theater.Where(r => r.電影院名稱Theater_Name == 電影院box.Text).Select(x => x.電影院編號Theater_ID).FirstOrDefault();
            var q = 場次data.影廳Cinema.Where(r => r.電影院編號Theater_ID == id).Select(x => x.影廳名稱Cinema_Name);
            foreach (var x in q) 影廳Box.Items.Add(x);
        }
    }
}
