using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjMDA.Models;
using prjMDA.編輯視窗;

namespace prjMDA
{
    public partial class 影廳 : Form
    { 
        MDAEntities 影廳data = new MDAEntities();
        ImageToBinary picTool = new ImageToBinary();
        private int _id = -1;
        public 影廳()
        {
            InitializeComponent();           
            var q = from p in 影廳data.影廳Cinema
                    select new { 
                    p.影廳編號Cinema_ID,
                    p.影廳名稱Cinema_Name,
                    p.電影院編號Theater_ID,
                    p.廳種名稱Cinema_Cls_Name,
                    p.座位資訊SeatInfo,
                    p.影廳照片Image                   
                    };
            dataGridView1.DataSource= q.ToList();
            拉取資料();
        }
        private void 拉取資料()
        {
            var x = 影廳data.影城MainTheater.Select(r => r.影城名稱MainTheater_Name);
            foreach (var r in x)
                影城box.Items.Add(r);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox Pic = (PictureBox)sender;
            this.影廳照片.Image = Pic.Image;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.Image = null;
            openFileDialog1.FileName = "*.png;*.jpg;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pic.Image = Image.FromFile(openFileDialog1.FileName);
            }
            影廳照片.Image = pic.Image;
        }

        private void 新增(object sender, EventArgs e)
        {
            var q = this.影廳data.影廳Cinema.Where(m => m.影廳名稱Cinema_Name == 影廳nmtxt.Text).Any();
             int ID=this.影廳data.電影院Theater.Where(x=>x.電影院名稱Theater_Name== 影廳電影box.Text).Select(x=>x.電影院編號Theater_ID).FirstOrDefault();
            if (影廳nmtxt.Text == "" || 影廳電影box.Text == "" || 廳種txt.Text == "" || 座位txt.Text == "" || 影廳照片.Image == null)
            {
                MessageBox.Show("資料有誤");
                return;
            }
                影廳Cinema movie = new 影廳Cinema();
                movie.影廳名稱Cinema_Name = 影廳nmtxt.Text;
                movie.座位資訊SeatInfo =座位txt .Text;
                movie.廳種名稱Cinema_Cls_Name = 廳種txt.Text;
                movie.電影院編號Theater_ID =ID;
                movie.影廳照片Image = picTool.ConvertToByte(this.影廳照片.Image);
                this.影廳data.影廳Cinema.Add(movie);
                this.影廳data.SaveChanges();
                紀錄方法();            
                清空();
                MessageBox.Show("新增成功");       
        }
        private void 清空()
        {
            影廳nmtxt.Text = "";
            座位txt.Text = "";
            影廳電影box.Text = "";
            廳種txt.Text="";
            影廳照片.Image = null;
            影城box.Text = "";
        }

        private void 紀錄方法()
        {
            dataGridView1.DataSource = null;
            var q = from p in 影廳data.影廳Cinema
                    select new
                    {
                        p.影廳編號Cinema_ID,
                        p.影廳名稱Cinema_Name,
                        p.電影院編號Theater_ID,
                        p.廳種名稱Cinema_Cls_Name,
                        p.座位資訊SeatInfo,
                        p.影廳照片Image
                    };
            dataGridView1.DataSource = q.ToList();
        }


        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            _id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            影廳Cinema movie = this.影廳data.影廳Cinema.Where(m => m.影廳編號Cinema_ID == _id).SingleOrDefault();
            if (movie == null) { return; }
            string Name = 影廳data.電影院Theater.Where(x => x.電影院編號Theater_ID == movie.電影院編號Theater_ID).Select(x => x.電影院名稱Theater_Name).FirstOrDefault();
            廳種txt.Text = movie.廳種名稱Cinema_Cls_Name;
             影廳nmtxt.Text=movie.影廳名稱Cinema_Name;
            座位txt.Text = movie.座位資訊SeatInfo;
            影廳電影box.Text=Name;
            if (movie.影廳照片Image == null)
            {
                影廳data = new MDAEntities();
                return;
            }
            this.影廳照片.Image= picTool.ConvertToImage(movie.影廳照片Image );
            影廳data = new MDAEntities();
        }

        private void 修改(object sender, EventArgs e)
        {
            var q = this.影廳data.影廳Cinema.Where(m => m.影廳編號Cinema_ID== _id).SingleOrDefault();
            int ID = this.影廳data.電影院Theater.Where(x => x.電影院名稱Theater_Name == 影廳電影box.Text).Select(x => x.電影院編號Theater_ID).FirstOrDefault();

            if (影廳nmtxt.Text == "" || 影廳電影box.Text == "" || 廳種txt.Text == "" || 座位txt.Text == ""||影廳照片.Image==null)
            {
                MessageBox.Show("資料有誤");
                return;
            }
                q.影廳名稱Cinema_Name = 影廳nmtxt.Text;
                q.座位資訊SeatInfo = 座位txt.Text;
                q.廳種名稱Cinema_Cls_Name = 廳種txt.Text;
                q.電影院編號Theater_ID = ID;
                q.影廳照片Image = picTool.ConvertToByte(this.影廳照片.Image);
                this.影廳data.SaveChanges();
                紀錄方法();               
                清空();
                MessageBox.Show("修改成功");    
        }

        private void 查詢_Click(object sender, EventArgs e)
        {
            var q = from p in 影廳data.影廳Cinema
                    where p.影廳名稱Cinema_Name.Contains(查詢txt.Text)||
                    p.廳種名稱Cinema_Cls_Name.Contains(查詢txt.Text)||
                    p.座位資訊SeatInfo.Contains(查詢txt.Text)
                    select new {
                    p.影廳編號Cinema_ID,
                    p.影廳名稱Cinema_Name,
                    p.電影院編號Theater_ID,
                    p.廳種名稱Cinema_Cls_Name,
                    p.座位資訊SeatInfo,
                    p.影廳照片Image
                    };
            if (查詢txt.Text == "")
            {
                MessageBox.Show("請輸入資料");
                return;
            }
            dataGridView1.DataSource = q.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            紀錄方法();
            拉取資料();
            清空();
        }

        private void 影城box_SelectedValueChanged(object sender, EventArgs e)
        {
            影廳電影box.Items.Clear();
            if (地區box.Text == "") { 
            int ID = 影廳data.影城MainTheater.Where(r => r.影城名稱MainTheater_Name == 影城box.Text).Select(x => x.影城編號MainTheater_ID).FirstOrDefault();
            var i = 影廳data.電影院Theater.Where(r => r.影城編號MainTheater_ID==ID).Select(r => r.電影院名稱Theater_Name);
            foreach (var r in i)
                影廳電影box.Items.Add(r);
            }
            else
            {
                int ID = 影廳data.影城MainTheater.Where(r => r.影城名稱MainTheater_Name == 影城box.Text).Select(x => x.影城編號MainTheater_ID).FirstOrDefault();
                var i = 影廳data.電影院Theater.Where(r => r.影城編號MainTheater_ID == ID&&r.地址Address.Contains(地區box.Text)).Select(r => r.電影院名稱Theater_Name);
                foreach (var r in i)
                    影廳電影box.Items.Add(r);
            }      
        }

        private void 地區box_TextChanged(object sender, EventArgs e)
        {
            影廳電影box.Items.Clear();
            if (影城box.Text == "")
            {
                var i = 影廳data.電影院Theater.Where(r =>  r.地址Address.Contains(地區box.Text)).Select(r => r.電影院名稱Theater_Name);
                foreach (var r in i)
                    影廳電影box.Items.Add(r);
            }
            else
            {
                int ID = 影廳data.影城MainTheater.Where(r => r.影城名稱MainTheater_Name == 影城box.Text).Select(x => x.影城編號MainTheater_ID).FirstOrDefault();
                var i = 影廳data.電影院Theater.Where(r => r.影城編號MainTheater_ID == ID && r.地址Address.Contains(地區box.Text)).Select(r => r.電影院名稱Theater_Name);
                foreach (var r in i)
                    影廳電影box.Items.Add(r);
            }
        }

        private void 座位規劃_Click(object sender, EventArgs e)
        {
            Frm座位編輯 座位 = new Frm座位編輯();
            座位.WindowState = FormWindowState.Normal;
            座位.ShowDialog();
            this.座位txt.Text = 座位.SeatInfostr;
        }

        private void 座位顯示_Click(object sender, EventArgs e)
        {
            Frm座位顯示 座位 = new Frm座位顯示(座位txt.Text);
            座位.WindowState = FormWindowState.Normal;
            座位.ShowDialog();
            
        }
    }
}
