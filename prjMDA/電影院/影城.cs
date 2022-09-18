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


namespace prjMDA
{
    public partial class Frm影城 : Form
    {
        MDAEntities 影城data = new MDAEntities();

        private int _id = -1;
        public Frm影城()
        {
            InitializeComponent();
            var q = from p in 影城data.影城MainTheater
                    select new { 
                        p.影城編號MainTheater_ID,
                        p.影城名稱MainTheater_Name};
            dataGridView1.DataSource = q.ToList();
        }
        private void 紀錄方法()
        {
            dataGridView1.DataSource = null;
            var q = from p in 影城data.影城MainTheater
                    select new
                    {
                        p.影城編號MainTheater_ID,
                        p.影城名稱MainTheater_Name
                    };
            dataGridView1.DataSource = q.ToList();
            
        }
        private void 清空()
        {
            影城nametxt.Text ="";
        }
        private void 新增_Click(object sender, EventArgs e)
        {

            var q = (from p in 影城data.影城MainTheater
                     select p).Any();
            if (影城nametxt.Text == "")
            {
                MessageBox.Show("輸入有誤");
                return;
            }
                影城MainTheater movie = new 影城MainTheater();
                movie.影城名稱MainTheater_Name = 影城nametxt.Text;
                影城data.影城MainTheater.Add(movie);
                影城data.SaveChanges();
                紀錄方法();       
                清空();
                MessageBox.Show("新增成功");
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.CurrentRow is null)
                return;
            _id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            影城MainTheater movie = 影城data.影城MainTheater.Where(s => s.影城編號MainTheater_ID == _id).SingleOrDefault();
            if (movie == null)  return;
            影城data.SaveChanges();
            影城nametxt.Text = movie.影城名稱MainTheater_Name;
            影城data = new MDAEntities();
        }

        private void 修改_Click(object sender, EventArgs e)
        {
            var q= 影城data.影城MainTheater.Where(s => s.影城編號MainTheater_ID == _id).SingleOrDefault();
            if (影城nametxt.Text == "")
            {
                MessageBox.Show("資料有誤");
                return;
            }
                q.影城名稱MainTheater_Name = 影城nametxt.Text;
                影城data.SaveChanges();
                紀錄方法();             
                清空();
                MessageBox.Show("新增成功");
        }
        private void 查詢_Click(object sender, EventArgs e)
        {
            var q = from p in 影城data.影城MainTheater
                    where p.影城名稱MainTheater_Name.Contains(查詢txt.Text)
                    select new{
                        p.影城編號MainTheater_ID,
                        p.影城名稱MainTheater_Name


            };
            if (查詢txt.Text == "")
            {
                MessageBox.Show("請輸入資料");
                return;
            }
            dataGridView1.DataSource = q.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            紀錄方法();
            清空(); 
        }
    }
    
}
