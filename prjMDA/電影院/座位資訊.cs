using prjMDA;
using prjMDA.編輯視窗;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 電影院
{
    public partial class Frm座位資訊 : Form
    {
        MDAEntities 座位資訊data = new MDAEntities();
        private int _id = -1;
        public Frm座位資訊()
        {
            InitializeComponent();
            var q = from p in 座位資訊data.出售座位狀態SeatStatus
                    select new { 
                    p.出售座位編號Seat_ID,
                    p.場次編號Screening_ID,
                    p.出售座位資訊SeatSoldInfo                                                          
                    };
            座位data.DataSource = q.ToList();
            拉資料();
        }
        private void 拉資料()
        {
            場次Box1.Items.Clear();
            var q =座位資訊data.場次Screening.Select(r => r.場次編號Screening_ID);
            foreach (var r in q)
            {
                場次Box1.Items.Add(r);
            }
        }
        private void 清空()
        {
            場次Box1.Text = "";
            座位txt.Text = "";
        }

        private void 時段bt_Click(object sender, EventArgs e)
        {
            var q = from p in 座位資訊data.出售座位狀態SeatStatus
                    select p;
            if (場次Box1.Text == "" || 座位txt.Text == "")
            {
                MessageBox.Show("資料有誤");
                return;
            }
            出售座位狀態SeatStatus movie = new 出售座位狀態SeatStatus();
                movie.場次編號Screening_ID = Convert.ToInt32(場次Box1.Text) ;
                movie.出售座位資訊SeatSoldInfo = 座位txt.Text;
                this.座位資訊data.出售座位狀態SeatStatus.Add(movie);
                this.座位資訊data.SaveChanges();           
                紀錄方法();
                清空();
                 MessageBox.Show("新增成功");
        }
        private void 紀錄方法()
        {
            座位data.DataSource = null;
            var q = from p in 座位資訊data.出售座位狀態SeatStatus
                    select new
                    {
                        p.出售座位編號Seat_ID,
                        p.場次編號Screening_ID,
                        p.出售座位資訊SeatSoldInfo
                    };
            座位data.DataSource = q.ToList();
        }

        private void 座位data_MouseUp(object sender, MouseEventArgs e)
        {
            if (座位data.CurrentRow is null)
                return;
            _id = (int)座位data.CurrentRow.Cells[0].Value;
            出售座位狀態SeatStatus movie = this.座位資訊data.出售座位狀態SeatStatus.Where(m => m.出售座位編號Seat_ID == _id).SingleOrDefault();
            if (movie == null) { return; }
            座位txt.Text = movie.出售座位資訊SeatSoldInfo.ToString();
            場次Box1.Text = movie.場次編號Screening_ID.ToString();
            座位資訊data = new MDAEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var q = this.座位資訊data.出售座位狀態SeatStatus.Where(m => m.出售座位編號Seat_ID == _id).SingleOrDefault();
            if (場次Box1.Text == "" || 座位txt.Text == "")
            {
                MessageBox.Show("資料有誤");
                return;
            }
                q.場次編號Screening_ID = Convert.ToInt32(場次Box1.Text);
                q.出售座位資訊SeatSoldInfo = 座位txt.Text;
                this.座位資訊data.SaveChanges();
                this.座位資訊data.SaveChanges();
                紀錄方法();            
                清空();
                MessageBox.Show("修改成功");
        }
        private void 查詢_Click(object sender, EventArgs e)
        {
            var q = from p in 座位資訊data.出售座位狀態SeatStatus
                    where p.出售座位資訊SeatSoldInfo.Contains(查詢txt.Text)
                    select new {
                p.出售座位編號Seat_ID,
                    p.場次編號Screening_ID,
                    p.出售座位資訊SeatSoldInfo
                    };
            if (查詢txt.Text == "")
            {
                MessageBox.Show("請輸入資料");
                return;
            }
            座位data.DataSource = q.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            紀錄方法();
            清空();
            拉資料();
        }

        private void 場次Box1_SelectedValueChanged(object sender, EventArgs e)
        {
            int x = int.Parse(場次Box1.Text);
            int i = 座位資訊data.場次Screening.Where(r => r.場次編號Screening_ID == x).Select(y => y.影廳編號Cinema_ID).FirstOrDefault();
            string p = 座位資訊data.影廳Cinema.Where(r => r.影廳編號Cinema_ID == i).Select(y => y.座位資訊SeatInfo).FirstOrDefault();
            座位txt.Text = p;
        }

        private void 座位顯示_Click(object sender, EventArgs e)
        {
            Frm座位顯示 座位 = new Frm座位顯示(座位txt.Text);
            座位.WindowState = FormWindowState.Normal;
            座位.ShowDialog();

        }
    }
}
