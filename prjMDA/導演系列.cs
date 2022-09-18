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
    public partial class 導演系列 : Form
    {
        public 導演系列()
        {
            InitializeComponent();
        }
        MDAEntities1 dbContext = new MDAEntities1();
        ImageToBinary image = new ImageToBinary();
        private void btnSelect_Click(object sender, EventArgs e)
        {
            Read_RefreshDataGridView();
        }
        void Read_RefreshDataGridView()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView2.DataSource = null;
            this.dataGridView1.DataSource = this.dbContext.導演總表Director.ToList();
            this.dataGridView2.DataSource = this.dbContext.電影導演MovieDirector.ToList();

        }
       
        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMovieID.Text = dataGridView2.CurrentRow.Cells["電影編號Movie_ID"].Value.ToString();
            txtDirectorID.Text = dataGridView2.CurrentRow.Cells["導演編號Director_ID"].Value.ToString();
            labMDID.Text = this.dataGridView2.CurrentRow.Cells["電影導演編號MD_ID"].Value.ToString();
            labDirID.Text=labMDID.Text;
            int x = int.Parse(txtDirectorID.Text);

            try
            {
                txtDirectorCh.Text = this.dataGridView1.Rows[x].Cells["中文名字Name_Cht"].Value.ToString();
                txtDirectorEng.Text = this.dataGridView1.Rows[x].Cells["英文名字Name_Eng"].Value.ToString();
                byte[] ByteData = (byte[])dataGridView1.Rows[x].Cells["導演照片Image"].Value;
                if (dataGridView1.Rows[x].Cells["導演照片Image"].Value == null)
                { pictureBox1.Image = null; };
                MemoryStream memoryStream = new MemoryStream(ByteData);
                pictureBox1.Image = Image.FromStream(memoryStream);
                memoryStream.Close();
            }
            catch { }

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtDirectorCh.Text = dataGridView1.CurrentRow.Cells["中文名字Name_Cht"].Value.ToString();
            txtDirectorEng.Text = dataGridView1.CurrentRow.Cells["英文名字Name_Eng"].Value.ToString();
            labDirID.Text= dataGridView1.CurrentRow.Cells["導演編號Director_ID"].Value.ToString();
            int x = int.Parse(labDirID.Text);

            try
            {
                labMDID.Text = this.dataGridView2.Rows[x - 1].Cells["電影導演編號MD_ID"].Value.ToString();
                txtMovieID.Text = this.dataGridView2.Rows[x - 1].Cells["電影導演編號MD_ID"].Value.ToString();
                txtDirectorID.Text = this.dataGridView2.Rows[x - 1].Cells["電影導演編號MD_ID"].Value.ToString();
                byte[] ByteData = (byte[])dataGridView1.Rows[x-1].Cells["導演照片Image"].Value;
                MemoryStream memoryStream = new MemoryStream(ByteData);
                pictureBox1.Image = Image.FromStream(memoryStream);
                memoryStream.Close();
            }
            catch
            {
                pictureBox1.Image = null;
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtDirectorCh.Text == "" || txtDirectorEng.Text == "" )
                return;
            var q = (from p in this.dbContext.導演總表Director
                     where p.中文名字Name_Cht == txtDirectorCh.Text ||
                     p.英文名字Name_Eng == txtDirectorEng.Text
                     select p).Any();
            if (q)
            {
                MessageBox.Show("導演重複");
                return;
            }
            var q1 = from p in this.dbContext.電影主演Cast
                     group p by p.演員編號Actor_ID into g
                     select new { Count = g.Count() };
            導演總表Director 導演總表 = new 導演總表Director();
            導演總表.中文名字Name_Cht = txtDirectorCh.Text;
            導演總表.英文名字Name_Eng = txtDirectorEng.Text;
            導演總表.導演照片Image = image.ConvertToByte(pictureBox1.Image);


            this.dbContext.導演總表Director.Add(導演總表);
            this.dbContext.SaveChanges();
            this.Read_RefreshDataGridView();
            labState.Text += $"指令為 新增 第 {q1.Count() } 導演編號 \n";
        }

        private void btnInsertDirector_Click(object sender, EventArgs e)
        {
            if (txtMovieID.Text == "" || txtDirectorID.Text == "")
                return;
            //var q = (from p in this.dbContext.電影導演MovieDirector.AsEnumerable()
            //         where p.電影編號Movie_ID == int.Parse(txtMovieID.Text)
            //         select p).Any();
            //if (q)
            //{
            //    MessageBox.Show("導演編號重複");
            //    return;
            //}
            var q1 = from p in this.dbContext.電影導演MovieDirector
                     group p by p.導演編號Director_ID into g
                     select new { Count = g.Count() };
            電影導演MovieDirector 電影導演 = new 電影導演MovieDirector();
            電影導演.電影編號Movie_ID = int.Parse(txtMovieID.Text);
            電影導演.導演編號Director_ID = int.Parse(txtDirectorID.Text);


            this.dbContext.電影導演MovieDirector.Add(電影導演);
            this.dbContext.SaveChanges();
            this.Read_RefreshDataGridView();
            labState.Text += $"指令為 新增 第 {q1.Count() } 導演編號 \n";
        }

        private void btnUppdate_Click(object sender, EventArgs e)
        {
            var q = (from p in this.dbContext.導演總表Director.AsEnumerable()
                     where p.導演編號Director_ID == int.Parse(labDirID.Text)
                     select p).FirstOrDefault();
            if (q == null)
                return;
            if (q.導演照片Image != null)
            {
                q.導演照片Image = null;
                this.dbContext.SaveChanges();
            }
            labState.Text += $"指令為修改 第 { q.導演編號Director_ID }   {q.中文名字Name_Cht} 跟 {q.英文名字Name_Eng}\n";
            q.中文名字Name_Cht = txtDirectorCh.Text;
            q.英文名字Name_Eng = txtDirectorEng.Text;
            q.導演照片Image = image.ConvertToByte(pictureBox1.Image);

            this.dbContext.SaveChanges();
            this.Read_RefreshDataGridView();
            labState.Text += $"　　　改成 第 { q.導演編號Director_ID }   {q.中文名字Name_Cht} 跟 {q.英文名字Name_Eng}\n";

        }

        private void btnUppdateDirector_Click(object sender, EventArgs e)
        {
            var q = (from p in this.dbContext.電影導演MovieDirector.AsEnumerable()
                     where p.電影導演編號MD_ID == int.Parse(labMDID.Text)
                     select p).FirstOrDefault();
            if (q == null)
                return;
            labState.Text += $"指令為修改 第 { q.導演編號Director_ID }   {q.電影編號Movie_ID} 跟 {q.導演編號Director_ID}\n";
            q.電影編號Movie_ID = int.Parse(txtMovieID.Text);
            q.導演編號Director_ID = int.Parse(txtDirectorID.Text);

            this.dbContext.SaveChanges();
            this.Read_RefreshDataGridView();
            labState.Text += $"　　　改成 第 { q.導演編號Director_ID }   {q.電影編號Movie_ID} 跟 {q.導演編號Director_ID}\n";
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            OpenFileDialog open = new OpenFileDialog();

            open.InitialDirectory = "c:\\";
            open.Filter = "圖片 files (*.jpeg)|*.txt|All files (*.*)|*.*";
            open.FilterIndex = 2;
            open.RestoreDirectory = true;

            if (open.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = open.FileName;
                //Read the contents of the file into a stream
                var fileStream = open.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    pictureBox1.Width = Image.FromFile(open.FileName).Width;
                    pictureBox1.Height = Image.FromFile(open.FileName).Height;
                    pictureBox1.Image = Image.FromFile(open.FileName);
                }
            }
        }
    }
}
