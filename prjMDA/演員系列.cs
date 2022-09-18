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
    public partial class 演員系列 : Form
    {
        public 演員系列()
        {
            InitializeComponent();

        }
        ImageToBinary image = new ImageToBinary();
        MDAEntities1 dbContext = new MDAEntities1();
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtActorCh.Text == "" || txtActorEng.Text == "")
                return;
            var q = (from p in this.dbContext.演員總表Actors.AsEnumerable()
                     where p.中文名字Name_Cht == txtActorCh.Text || p.英文名字Name_Eng == txtActorEng.Text
                     select p).Any();
            if (q)
            {
                MessageBox.Show("演員名字重複");
                return;
            }
            var q1 = from p in this.dbContext.演員總表Actors.AsEnumerable()
                     group p by p.演員編號Actors_ID into g
                     select new { Count = g.Count() };
            演員總表Actors 演員 = new 演員總表Actors();
            演員.中文名字Name_Cht = txtActorCh.Text;
            演員.英文名字Name_Eng = txtActorEng.Text;
            演員.演員照片Image = image.ConvertToByte(pictureBox1.Image);

            this.dbContext.演員總表Actors.Add(演員);
            this.dbContext.SaveChanges();
            this.Read_RefreshDataGridView();
            labState.Text += $"指令為 新增 第 {q1.Count()  } 演員編號\n";
        }
        void Read_RefreshDataGridView()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView2.DataSource = null;
            this.dataGridView1.DataSource = this.dbContext.演員總表Actors.ToList();
            this.dataGridView2.DataSource = this.dbContext.電影主演Cast.ToList();

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.Read_RefreshDataGridView();
        }

        private void btnUppdate_Click(object sender, EventArgs e)
        {

            var q = (from p in this.dbContext.演員總表Actors.AsEnumerable()
                           where p.演員編號Actors_ID==int.Parse(txtActorID.Text)
                           select p).FirstOrDefault();
            if (q == null)
                return;
            if (q.演員照片Image != null)
            {
                q.演員照片Image = null;
                this.dbContext.SaveChanges();
            }

            labState.Text += $"修改前為 演員編號:{ q.演員編號Actors_ID } { q.中文名字Name_Cht } { q.英文名字Name_Eng }\n";
            q.中文名字Name_Cht = txtActorCh.Text;
            q.英文名字Name_Eng = txtActorEng.Text;
            q.演員照片Image = image.ConvertToByte(pictureBox1.Image);

            this.dbContext.SaveChanges();
            this.Read_RefreshDataGridView();
            labState.Text += $"修改前為 演員編號:{ q.演員編號Actors_ID } { q.中文名字Name_Cht } { q.英文名字Name_Eng }\n";

        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            txtActorCh.Text = dataGridView1.CurrentRow.Cells["中文名字Name_Cht"].Value.ToString();
            txtActorEng.Text = dataGridView1.CurrentRow.Cells["英文名字Name_Eng"].Value.ToString();

            try
            {
                byte[] ByteData = (byte[])dataGridView1.CurrentRow.Cells["演員照片Image"].Value;
                MemoryStream memoryStream = new MemoryStream(ByteData);
                pictureBox1.Image = Image.FromStream(memoryStream);
                memoryStream.Close();
            }
            catch 
            {
                pictureBox1.Image = null;
            }


            int x = (int)dataGridView1.CurrentRow.Cells["演員編號Actors_ID"].Value;
            //------------------------------------------
            try
            {
                txtMovieID.Text = this.dataGridView2.Rows[x - 1].Cells["電影編號Movie_ID"].Value.ToString();
                txtActorID.Text = this.dataGridView2.Rows[x - 1].Cells["演員編號Actor_ID"].Value.ToString();
                txtActorName.Text = this.dataGridView2.Rows[x - 1].Cells["角色名字Character_Name"].Value.ToString();
                txtActorHistory.Text = this.dataGridView2.Rows[x - 1].Cells["角色說明Character_illustrate"].Value.ToString();
            }
            catch { }

        }


        private void btnSelectMovie_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInsertMovie_Click(object sender, EventArgs e)
        {
            if (txtMovieID.Text == "" || txtActorID.Text == ""|| txtActorName.Text==""|| txtActorHistory.Text=="")
                return;
            var q = (from p in this.dbContext.電影主演Cast
                     where p.電影編號Movie_ID == int.Parse(txtMovieID.Text) || 
                     p.演員編號Actor_ID == int.Parse(txtActorID.Text) || 
                     p.角色名字Character_Name == txtActorName.Text||
                     p.角色說明Character_illustrate==txtActorHistory.Text
                     select p).Any();
            if (q)
            {
                MessageBox.Show("角色名字重複");
                return;
            }
            var q1 = from p in this.dbContext.電影主演Cast
                     group p by p.演員編號Actor_ID into g
                     select new { Count = g.Count() };
            電影主演Cast 電影主演 = new 電影主演Cast();
            電影主演.電影編號Movie_ID = int.Parse(txtMovieID.Text);
            電影主演.演員編號Actor_ID = int.Parse(txtActorID.Text);
            電影主演.角色名字Character_Name = txtActorName.Text;
            電影主演.角色說明Character_illustrate = txtActorHistory.Text;

            this.dbContext.電影主演Cast.Add(電影主演);
            this.dbContext.SaveChanges();
            this.Read_RefreshDataGridView();
            labState.Text += $"指令為 新增 第 {q1.Count()  } 電影編號\n";
        }

        private void btnUppdateMovie_Click(object sender, EventArgs e)
        {
            var q = (from p in this.dbContext.電影主演Cast.AsEnumerable()
                     where p.演員編號Actor_ID==int.Parse(txtActorID.Text)
                     select p).FirstOrDefault();
            if (q == null)
                return;
            //q.電影編號Movie_ID = int.Parse(txtMovieID.Text);
            //q.演員編號Actor_ID = int.Parse(txtActorID.Text);
            q.角色名字Character_Name = txtActorName.Text;
            q.角色說明Character_illustrate = txtActorHistory.Text;

            this.dbContext.SaveChanges();
            this.Read_RefreshDataGridView();
            labState.Text += $"指令為 修改 第 { q.演員編號Actor_ID } 演員編號\n";
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            txtMovieID.Text = dataGridView2.CurrentRow.Cells["電影編號Movie_ID"].Value.ToString();
            txtActorID.Text = dataGridView2.CurrentRow.Cells["演員編號Actor_ID"].Value.ToString();
            txtActorName.Text = dataGridView2.CurrentRow.Cells["角色名字Character_Name"].Value.ToString();
            txtActorHistory.Text = dataGridView2.CurrentRow.Cells["角色說明Character_illustrate"].Value.ToString();


            //dataGridView1.CurrentRow.Cells["演員編號Actors_ID"].Value = txtActorID.Text;
            //int x = (int)dataGridView1.CurrentRow.Cells["演員編號Actors_ID"].Value;
            int x = int.Parse(txtActorID.Text);

            try
            {
                txtActorCh.Text = this.dataGridView1.Rows[x - 1].Cells["中文名字Name_Cht"].Value.ToString();
                txtActorEng.Text = this.dataGridView1.Rows[x - 1].Cells["英文名字Name_Eng"].Value.ToString();
                byte[] ByteData = (byte[])dataGridView1.Rows[x - 1].Cells["演員照片Image"].Value;
                if(dataGridView1.Rows[x - 1].Cells["演員照片Image"].Value==null)
                { pictureBox1.Image = null; };
                MemoryStream memoryStream = new MemoryStream(ByteData);
                pictureBox1.Image = Image.FromStream(memoryStream);
                memoryStream.Close();
            }
            catch { }

        }



        private void pictureBox1_DoubleClick(object sender, EventArgs e)
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
