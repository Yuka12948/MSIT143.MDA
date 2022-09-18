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
    public partial class 電影院 : Form
    {
        MDAEntities 電影院data = new MDAEntities();
        ImageToBinary picTool = new ImageToBinary();
        private int _id = -1;
        public 電影院()
        {
            InitializeComponent();
            var q = from p in 電影院data.電影院Theater
                    select new { 
                    p.電影院編號Theater_ID,
                    p.電影院名稱Theater_Name,
                    p.影城編號MainTheater_ID,
                    p.營業時間BusinessHours,
                    p.電話Phone,
                    p.地址Address,
                    p.官方網站URL,
                    p.電影院照片Image
                    };
            dataGridView1.DataSource = q.ToList();
            拉取資料();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox Pic = (PictureBox)sender;
            this.電影院照片.Image = Pic.Image;
        }

        private void 電影院照片_DoubleClick(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.Image = null;
            openFileDialog1.FileName = "*.png;*.jpg;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pic.Image = Image.FromFile(openFileDialog1.FileName);
            }
            電影院照片.Image = pic.Image;
        }
        private void 拉取資料()
        {
            影城box.Items.Clear();
            var q = 電影院data.影城MainTheater.Select(r => r);
            foreach (var r in q)
            {
                影城box.Items.Add(r.影城名稱MainTheater_Name);
            }
        }
        private void 新增(object sender, EventArgs e)
        {
            var q = this.電影院data.電影院Theater.Where(m => m.電影院名稱Theater_Name == 電影院nmtxt.Text || m.電話Phone == phone.Text || m.地址Address == address.Text || m.官方網站URL == urls.Text).Any();
            int ID = this.電影院data.影城MainTheater.Where(m => m.影城名稱MainTheater_Name == 影城box.Text).Select(m => m.影城編號MainTheater_ID).FirstOrDefault();
                if (電影院照片.Image == null)
                {
                    MessageBox.Show("沒有圖,上傳個圖吧");
                    return;
                }             
                電影院Theater movie = new 電影院Theater();
                movie.電影院名稱Theater_Name = 電影院nmtxt.Text;
                movie.電話Phone = phone.Text;         
                movie.影城編號MainTheater_ID =ID;
                movie.營業時間BusinessHours = 營業time.Text;
                movie.地址Address = address.Text;
                movie.官方網站URL = urls.Text;            
                movie.電影院照片Image = picTool.ConvertToByte(this.電影院照片.Image);             
                this.電影院data.電影院Theater.Add(movie);
                this.電影院data.SaveChanges();
                紀錄方法();              
                清空();   
                MessageBox.Show("新增成功");
        }
        private void 紀錄方法()
        {
            dataGridView1.DataSource = null;
            var q = from p in 電影院data.電影院Theater
                    select new
                    {
                        p.電影院編號Theater_ID,
                        p.電影院名稱Theater_Name,
                        p.影城編號MainTheater_ID,
                        p.營業時間BusinessHours,
                        p.電話Phone,
                        p.地址Address,
                        p.官方網站URL,
                        p.電影院照片Image
                    };
            dataGridView1.DataSource = q.ToList();
        }
        private void 清空()
        {
            電影院nmtxt.Text = "";
            phone.Text = "";
            address.Text = "";
            urls.Text = "";
            電影院照片.Image = null;
            影城box.Text = "";
            營業time.Text = "";
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.CurrentRow is null)
                return;
            _id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            電影院Theater movie = this.電影院data.電影院Theater.Where(m => m.電影院編號Theater_ID == _id).SingleOrDefault();
            string Name= 電影院data.影城MainTheater.Where(r => r.影城編號MainTheater_ID==movie.影城編號MainTheater_ID).Select(r=>r.影城名稱MainTheater_Name).FirstOrDefault();
            if (movie == null) { return; }
            this.電影院data.SaveChanges();
            電影院nmtxt.Text = movie.電影院名稱Theater_Name;
            phone.Text = movie.電話Phone;
            address.Text = movie.地址Address;
            影城box.Text = Name;
            營業time.Text = movie.營業時間BusinessHours;
            urls.Text = movie.官方網站URL;
            if(movie.電影院照片Image==null)
            {
                電影院data = new MDAEntities();
                return;
            }
            電影院照片.Image =picTool.ConvertToImage( movie.電影院照片Image);
            電影院data = new MDAEntities();        
        }
        private void 修改(object sender, EventArgs e)
        {
            var q = this.電影院data.電影院Theater.Where(m => m.電影院編號Theater_ID==_id).SingleOrDefault();
            if (電影院nmtxt.Text == "" || 影城box.Text == "" || 營業time.Text == "" || phone.Text == "" || address.Text == "" || urls.Text == "")
            {
                MessageBox.Show("資料有誤");
                return;
            }
            int ID = this.電影院data.影城MainTheater.Where(m => m.影城名稱MainTheater_Name == 影城box.Text).Select(m => m.影城編號MainTheater_ID).FirstOrDefault();          
                q.電影院名稱Theater_Name = 電影院nmtxt.Text;
                q.電話Phone = phone.Text;
                q.地址Address = address.Text;
                q.官方網站URL = urls.Text;
                q.營業時間BusinessHours = 營業time.Text;
                q.影城編號MainTheater_ID = ID;
                q.電影院照片Image = picTool.ConvertToByte(this.電影院照片.Image);
                this.電影院data.SaveChanges();
                紀錄方法();              
                清空();
                 MessageBox.Show("修改成功");
        }
        private void 查詢_Click(object sender, EventArgs e)
        {
            var q = from p in 電影院data.電影院Theater
                    where p.電影院名稱Theater_Name.Contains(查詢txt.Text)||p.地址Address.Contains(查詢txt.Text)
                    ||p.官方網站URL.Contains(查詢txt.Text)|| p.營業時間BusinessHours.Contains(查詢txt.Text)
                    ||p.電話Phone.Contains(查詢txt.Text)
                    select new
                    {
                        p.電影院編號Theater_ID,
                        p.電影院名稱Theater_Name,
                        p.影城編號MainTheater_ID,
                        p.營業時間BusinessHours,
                        p.電話Phone,
                        p.地址Address,
                        p.官方網站URL,
                        p.電影院照片Image
                    };
            if (查詢txt.Text == "")
            {
                MessageBox.Show("請輸入資料"); 
                return;
            }
            dataGridView1.DataSource = q.ToList();
        }

        private void 重新整理_Click(object sender, EventArgs e)
        {
            紀錄方法();
            清空();
            拉取資料();
        }
    }
}
