using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMember
{
    public partial class frmList : Form
    {
        CMember mem = new CMember();
        MDAEntities dbContext = new MDAEntities();
        
        int listIndex = -1;

        List<string> formal = new List<string>() { "簡易會員", "正式會員" };
        List<string> permission = new List<string>() { "正常使用", "停權", "審核中", "管理員" };
        List<string> series;
        public frmList()
        {
            InitializeComponent();
            splitContainer3.BorderStyle = BorderStyle.FixedSingle;
            splitContainer5.BorderStyle = BorderStyle.FixedSingle;
        }
        private void frmList_Load(object sender, EventArgs e)
        {
            refreshViewList();
            refreshViewMem();
            refreshViewMovie();

            foreach (string fo in formal)
                this.cmbFormal.Items.Add(fo);

            foreach (string per in permission)
                this.cmbPer.Items.Add(per);

            var q = this.dbContext.系列電影MovieSeries.Select(s => s.系列名稱Series_Name);
            series = q.ToList();
            foreach (string se in series)
                this.cmbSeries.Items.Add(se);

            cmbBy.SelectedIndex = 0;
        }

        private void btnViewMember_Click(object sender, EventArgs e)
        {
            refreshViewMem();
            
        }

        private void refreshViewMem()
        {
            cmbFormal.SelectedIndex = -1;
            cmbPer.SelectedIndex = -1;

            this.dataGridViewMem.DataSource = null;
            var q = from m in this.dbContext.會員Members
                    select new
                    {
                        會員編號 = m.會員編號Member_ID,
                        電話 = m.會員電話Cellphone,
                        正式會員 = m.正式會員Formal,
                        權限 = m.會員權限Permission,

                    };
            this.dataGridViewMem.DataSource = q.ToList();
            setViewMem();
            setGridStyle(dataGridViewMem);

        }

        private void setViewMem()
        {
            dataGridViewMem.Columns[0].Width = 70;
            dataGridViewMem.Columns[1].Width = 200;
            dataGridViewMem.Columns[2].Width = 70;
            dataGridViewMem.Columns[3].Width = 50;
        }

        void refreshViewList()
        {
            this.dataGridViewList.DataSource = null;
            var q = from m in this.dbContext.我的片單MyMovieLists
                    select new
                    {
                        片單編號=m.我的片單MyMovieList_ID,
                        會員編號=m.會員編號Member_ID,
                        片單名稱=m.片單總表MovieLists.片單總表名稱List_Name,
                        電影編號=m.電影編號Movie_ID,
                        片名=m.電影Movies.中文標題Title_Cht,

                    };
            this.dataGridViewList.DataSource = q.ToList();
            setViewList();
            setGridStyle(dataGridViewList);
        }
        void setViewList()
        {
            dataGridViewList.Columns[0].Width = 50;
            dataGridViewList.Columns[1].Width = 50;
            dataGridViewList.Columns[2].Width = 100;
            dataGridViewList.Columns[3].Width = 50;
            dataGridViewList.Columns[4].Width = 200;
        }
        private void refreshViewMovie()
        {
            cmbSeries.SelectedIndex = -1;

            this.dataGridViewMovie.DataSource = null;
            var q = from m in this.dbContext.電影Movies
                    select new
                    {
                        電影編號 = m.電影編號Movie_ID,
                        片名 = m.中文標題Title_Cht,
                        系列電影 = m.系列電影MovieSeries.系列名稱Series_Name,

                    };
            this.dataGridViewMovie.DataSource = q.ToList();
            setViewMov();
            setGridStyle(dataGridViewMovie);
        }

        private void setViewMov()
        {
            dataGridViewMovie.Columns[0].Width = 70;
            dataGridViewMovie.Columns[1].Width = 200;
            dataGridViewMovie.Columns[2].Width = 150;
        }

        void refreshViewByMem()
        {
            string keyW = txtKeywordList.Text;
            this.dataGridViewBy.DataSource = null;
            var q = from m in this.dbContext.我的片單MyMovieLists.AsEnumerable()
                    where m.會員編號Member_ID.ToString() == keyW
                    ||m.會員Members.會員電話Cellphone== keyW
                    select new
                    {
                        片單編號=m.我的片單MyMovieList_ID,
                        會員編號=m.會員編號Member_ID,
                        片單名稱=m.片單總表MovieLists.片單總表名稱List_Name,
                        電影編號=m.電影編號Movie_ID,
                        片名=m.電影Movies.中文標題Title_Cht,

                    };
            this.dataGridViewBy.DataSource = q.ToList();            
            dataGridViewBy.Columns[4].Width = 200;
            setGridStyle(dataGridViewBy);
        }
        void refreshViewByMov()
        {
            string keyW = txtKeywordList.Text;
            this.dataGridViewBy.DataSource = null;
            var q = from m in this.dbContext.我的片單MyMovieLists.AsEnumerable()
                    where m.電影編號Movie_ID.ToString() == keyW
                    ||m.電影Movies.中文標題Title_Cht.Contains(keyW)
                    ||m.電影Movies.系列電影MovieSeries.系列名稱Series_Name.Contains(keyW)
                    select new
                    {
                        片單編號 = m.我的片單MyMovieList_ID,
                        電影編號 = m.電影編號Movie_ID,
                        片名 = m.電影Movies.中文標題Title_Cht,
                        會員編號 = m.會員編號Member_ID,
                        片單名稱 = m.片單總表MovieLists.片單總表名稱List_Name,       

                    };
            this.dataGridViewBy.DataSource = q.ToList();
            dataGridViewBy.Columns[2].Width = 200;
            setGridStyle(dataGridViewBy);
        }
        private void btnViewList_Click(object sender, EventArgs e)
        {
            refreshViewList();
        }

        private void btnViewMovie_Click(object sender, EventArgs e)
        {
            refreshViewMovie();
        }

     
        private void dataGridViewMem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int _position = e.RowIndex;
            if (_position < 0)
                return;
            string a = dataGridViewMem.Rows[_position].Cells["會員編號"].Value.ToString();
            txtMemId.Text = a;
            txtKeywordList.Text = a;
            cmbBy.SelectedIndex = 0;
        }

        private void dataGridViewMovie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int _position = e.RowIndex;
            if (_position < 0)
                return;
            string a= dataGridViewMovie.Rows[_position].Cells["電影編號"].Value.ToString();
            txtMovieId.Text = a;
            txtKeywordList.Text = a;
            cmbBy.SelectedIndex = 1;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string listName = txtListName.Text;
            int memid = Int32.Parse(txtMemId.Text);
            int movid = Int32.Parse(txtMovieId.Text);
                        
            var formal = this.dbContext.會員Members
                .Where(m => m.會員編號Member_ID.Equals(memid))
                .Select(m => m.正式會員Formal).FirstOrDefault();
            //bool formal = fo.GetValueOrDefault();
            if (formal == false)
            {
                MessageBox.Show("簡易會員無此功能");
                return;
            }
            
            片單總表MovieLists q = this.dbContext.片單總表MovieLists
                .Where(ml => ml.會員編號Member_ID.Equals(memid))
                .Where(ml2=>ml2.片單總表名稱List_Name.Equals(listName)).FirstOrDefault();
            if (q == null)
            {
                片單總表MovieLists m = new 片單總表MovieLists
                {
                    片單總表名稱List_Name = listName,
                    會員編號Member_ID = memid,

                };

                this.dbContext.片單總表MovieLists.Add(m);
                this.dbContext.SaveChanges();


                int count = (this.dbContext.片單總表MovieLists.Select(t => t)).Count();
                int lid = dbContext.片單總表MovieLists.Select(li => li.片單總表編號MovieList_ID).ToList()[count - 1];

                我的片單MyMovieLists mm = new 我的片單MyMovieLists
                {
                    片單總表編號MovieList_ID = lid,
                    會員編號Member_ID = memid,
                    電影編號Movie_ID = Int32.Parse(txtMovieId.Text)
                };
                this.dbContext.我的片單MyMovieLists.Add(mm);

            }
            else
            {                
                int lid = this.dbContext.片單總表MovieLists
                    .Where(ml1 => ml1.會員編號Member_ID.Equals(memid))
                    .Where(ml2 => ml2.片單總表名稱List_Name.Equals(listName))
                    .Select(ml => ml.片單總表編號MovieList_ID).FirstOrDefault();
                var qq = this.dbContext.我的片單MyMovieLists
                    .Where(q1 => q1.會員編號Member_ID.Equals(memid))
                    .Where(q3 => q3.電影編號Movie_ID.Equals(movid))
                    .Where(q2 => q2.片單總表MovieLists.片單總表名稱List_Name.Equals(listName))
                    .FirstOrDefault();
                if (qq!=null)
                {
                    MessageBox.Show("重複新增相同片單電影");
                    return;
                }
                我的片單MyMovieLists mm = new 我的片單MyMovieLists
                {
                    片單總表編號MovieList_ID = lid,
                    會員編號Member_ID = memid,
                    電影編號Movie_ID = Int32.Parse(txtMovieId.Text)
                };
                this.dbContext.我的片單MyMovieLists.Add(mm);

            }
            this.dbContext.SaveChanges();
            refreshViewList();
            MessageBox.Show($"會員{txtMemId.Text} 片單新增成功");
        }

 
        private void btnSearchMem_Click(object sender, EventArgs e)
        {
            setGridStyle(dataGridViewMem);
            string keyW = txtKeywordMem.Text;
            var q = this.dbContext.會員Members
                .Where(m=> m.會員編號Member_ID.ToString().Equals(keyW) || m.會員電話Cellphone.ToString().Equals(keyW))
                .Select(m=>new
                {
                    會員編號=m.會員編號Member_ID,
                    電話=m.會員電話Cellphone,
                    正式會員=m.正式會員Formal,
                    權限=m.會員權限Permission,

                });
            
            dataGridViewMem.DataSource = q.ToList();
            setViewMem();
        }

        private void searchByKeyword(DataGridView d, TextBox t)
        {
            foreach (DataGridViewRow r in d.Rows)
            {
                r.Selected = false;
                foreach (DataGridViewCell c in r.Cells)
                {
                    if (c.Value == null)
                        continue;
                    if (c.Value.ToString().ToUpper().Contains(t.Text.ToUpper()))
                    {
                        c.Style.BackColor = Color.Yellow;
                        r.Selected=true;

                        return;
                    }
                }
            }
        }

        private void setGridStyle(DataGridView d)
        {
            bool isColorChanged = false;
            Color bgColor;
            foreach (DataGridViewRow r in d.Rows)
            {
                isColorChanged = !isColorChanged;
                bgColor = Color.LightBlue;
                if (isColorChanged)
                    bgColor = Color.WhiteSmoke;
                foreach (DataGridViewCell c in r.Cells)
                    c.Style.BackColor = bgColor;
            }
        }

        private void btnSearchMovie(object sender, EventArgs e)
        {
            setGridStyle(dataGridViewMem);
            string keyW = txtKeywordMovie.Text;
            var q = this.dbContext.電影Movies
                .Where(m => m.電影編號Movie_ID.ToString().Equals(keyW) || m.中文標題Title_Cht.ToString().Contains(keyW))
                .Select(m => new
                {
                    電影編號=m.電影編號Movie_ID,
                    片名=m.中文標題Title_Cht,
                    系列電影=m.系列電影MovieSeries.系列名稱Series_Name,

                });

            dataGridViewMovie.DataSource = q.ToList();
            setViewMov();
        }

        private void btnSearchList_Click(object sender, EventArgs e)
        {
            setGridStyle(dataGridViewBy);
            if (cmbBy.SelectedIndex < 0) return;
            else if (cmbBy.SelectedIndex == 0)
                refreshViewByMem();
            else
                refreshViewByMov();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listIndex < 0)
                return;
            我的片單MyMovieLists list = (from l in this.dbContext.我的片單MyMovieLists
                                     where l.我的片單MyMovieList_ID.Equals(listIndex)
                                     select l).FirstOrDefault();
            if (list == null) return;
            list.片單總表MovieLists.片單總表名稱List_Name = txtListName.Text;

            this.dbContext.SaveChanges();
            this.refreshViewList();
            MessageBox.Show("修改成功");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (listIndex < 0)
                return;

            我的片單MyMovieLists list = (from l in this.dbContext.我的片單MyMovieLists
                                where l.我的片單MyMovieList_ID.Equals(listIndex)
                                select l).FirstOrDefault();
            if (list == null) return; 

            this.dbContext.我的片單MyMovieLists.Remove(list);
            this.dbContext.SaveChanges();
            this.refreshViewList();
            MessageBox.Show("片單中電影刪除成功");
        }

        private void dataGridViewList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int _position = e.RowIndex;
            if (_position < 0)
                return;
            txtMemId.Text = dataGridViewList.Rows[_position].Cells["會員編號"].Value.ToString();
            txtMovieId.Text= dataGridViewList.Rows[_position].Cells["電影編號"].Value.ToString();
            txtListName.Text= dataGridViewList.Rows[_position].Cells["片單名稱"].Value.ToString();
            listIndex= Int32.Parse(dataGridViewList.Rows[_position].Cells["片單編號"].Value.ToString());
        }

        private void btnDelList_Click(object sender, EventArgs e)
        {
            int memId = Int32.Parse(txtMemId.Text);
            string listName = txtListName.Text;
            if (listIndex < 0)
                return;
            var q = (from l in this.dbContext.我的片單MyMovieLists
                          where l.片單總表MovieLists.片單總表名稱List_Name.Equals(listName)
                          select l);
            if (q == null) return;
            var myList = q.ToList();
            foreach (var i in myList)
                this.dbContext.我的片單MyMovieLists.Remove(i);
            this.dbContext.SaveChanges();

            var moList = this.dbContext.片單總表MovieLists
                         .Where(l1=>l1.會員編號Member_ID.Equals(memId))
                         .Where(l2=>l2.片單總表名稱List_Name.Equals(listName))
                         .FirstOrDefault();
            if (moList == null) return;
            this.dbContext.片單總表MovieLists.Remove(moList);
            this.dbContext.SaveChanges();
            this.refreshViewList();
            MessageBox.Show("整個片單刪除");
        }      


        private void dataGridViewBy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int _position = e.RowIndex;
            if (_position < 0)
                return;
            txtMemId.Text = dataGridViewList.Rows[_position].Cells["會員編號"].Value.ToString();
            txtMovieId.Text = dataGridViewList.Rows[_position].Cells["電影編號"].Value.ToString();
            txtListName.Text = dataGridViewList.Rows[_position].Cells["片單名稱"].Value.ToString();
            listIndex = Int32.Parse(dataGridViewList.Rows[_position].Cells["片單編號"].Value.ToString());
        }

        private void cmbFormal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFormal.SelectedIndex < 0) return;
            bool fo;

            if (cmbFormal.SelectedIndex == 0)
                fo = false;
            else
                fo = true;
            this.dataGridViewMem.DataSource = null;
            
            var q =this.dbContext.會員Members
                        .Where(m=> m.正式會員Formal == fo);
            if (cmbPer.SelectedIndex < 0)
            {
                var q1=q.Select(m => new
                {
                    會員編號 = m.會員編號Member_ID,
                    電話 = m.會員電話Cellphone,
                    正式會員 = m.正式會員Formal,
                    權限 = m.會員權限Permission,
                });
                this.dataGridViewMem.DataSource = q1.ToList(); 
            }
            else
            {
                var q2=q.Where(m=>m.會員權限Permission==cmbPer.SelectedIndex)
                    .Select(m => new
                    {
                        會員編號 = m.會員編號Member_ID,
                        電話 = m.會員電話Cellphone,
                        正式會員 = m.正式會員Formal,
                        權限 = m.會員權限Permission,
                    });
                this.dataGridViewMem.DataSource = q2.ToList();
            }

            setViewMem();
            setGridStyle(dataGridViewMem);
        }

        private void cmbPer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPer.SelectedIndex < 0) return;
            this.dataGridViewMem.DataSource = null;
            var q = this.dbContext.會員Members.Where(m => m.會員權限Permission == cmbPer.SelectedIndex);

            if (cmbFormal.SelectedIndex < 0)
            {
                var q1 = q.Select(m=> new
                         {
                             會員編號 = m.會員編號Member_ID,
                             電話 = m.會員電話Cellphone,
                             正式會員 = m.正式會員Formal,
                             權限 = m.會員權限Permission,

                         });
                this.dataGridViewMem.DataSource = q1.ToList();
            }
            else
            {
                if (cmbFormal.SelectedIndex < 0) return;
                bool fo;

                if (cmbFormal.SelectedIndex == 0)
                    fo = false;
                else
                    fo = true;
                var q2=q.Where(m=>m.正式會員Formal==fo)
                    .Select(m => new
                    {
                        會員編號 = m.會員編號Member_ID,
                        電話 = m.會員電話Cellphone,
                        正式會員 = m.正式會員Formal,
                        權限 = m.會員權限Permission,

                    });
                this.dataGridViewMem.DataSource = q2.ToList();
            }
            setViewMem();
            setGridStyle(dataGridViewMem);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSeries.SelectedIndex < 0) return;
            this.dataGridViewMovie.DataSource = null;
            var q = this.dbContext.電影Movies.AsEnumerable()
                .Where(m => m.系列電影MovieSeries.系列名稱Series_Name.Equals(cmbSeries.SelectedItem.ToString()))
                .Select(m => new
                {
                    電影編號=m.電影編號Movie_ID,
                    片名=m.中文標題Title_Cht,
                    系列電影=m.系列電影MovieSeries.系列名稱Series_Name,

                });
            
            dataGridViewMovie.DataSource = q.ToList();
            setViewMov();
        }

        private void dataGridViewList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int _position = e.RowIndex;
            if (_position < 0)
                return;
            txtMemId.Text = dataGridViewList.Rows[_position].Cells["會員編號"].Value.ToString();
            txtMovieId.Text = dataGridViewList.Rows[_position].Cells["電影編號"].Value.ToString();
            txtListName.Text = dataGridViewList.Rows[_position].Cells["片單名稱"].Value.ToString();
            listIndex = Int32.Parse(dataGridViewList.Rows[_position].Cells["片單編號"].Value.ToString());

        }
    }
}
