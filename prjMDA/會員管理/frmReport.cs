using prjMember.Member;
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
    
    public partial class frmReport : Form
    {
        MDAEntities dbContext = new MDAEntities();
        CMember clsMem = new CMember();

        string replyNo = "經審查並未發現有違反社群守則之處\n";
        string replyNo2 = "若您認為應再次進行調查,請回此封信件告知我們\n";
        string replyYes = "經審查發現有違反社群守則之處\n";
        string replyYesP = "該則將予以屏蔽\n";
        string replyYesP2 = "該會員將予以停權\n";
        bool isRefresh = false;
        int seleCFid = -1;
        int index = -1;
        public frmReport()
        {
            InitializeComponent();
            splitContainer2.BorderStyle = BorderStyle.FixedSingle;
        }
        public static string reply { get; set; }
        public static string reason { get; set; }
        public static string name { get;set;}
        public static string email { get; set; }

        public static int memId { get; set; }
        public static bool isDetailClick { get; set; }


        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtReporter.Text == ""||rtxtReply.Text=="") return;
            frmEmail f = new frmEmail();
            reply = rtxtReply.Text;
            reason = rtxtReason.Text;
            var q = this.dbContext.我的追蹤清單MyFollowLists.AsEnumerable()
                .Where(m => m.會員編號Member_ID == Int32.Parse(txtReporter.Text))
                .Select(m => new { NickName = m.會員Members.暱稱NickName, Phone = m.會員Members.會員電話Cellphone, Email=m.會員Members.電子信箱Email })
                .FirstOrDefault();
            email = q.Email;
            if (q.NickName != "")
                name = q.NickName;
            else
                name = q.Phone;

            f.Show();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(replyNo);
            listBox1.Items.Add(replyNo2);
            listBox1.Items.Add(replyYes);
            listBox1.Items.Add(replyYesP);
            listBox1.Items.Add(replyYesP2);

            cmbNull.Items.Add("無理由");
            cmbNull.Items.Add("有理由");
            cmbNull.Items.Add("(無)");

            var q = dbContext.對象Targets.Select(t => t.對象名稱Target_Name);
            foreach (var i in q.ToList())
                cmbTarget.Items.Add(i);
            cmbTarget.Items.Add("(無)");

            cmbStatus.Items.Add("未處理");
            cmbStatus.Items.Add("已處理");
            cmbStatus.Items.Add("(無)");

            refreshDataGridView();
        }

        void refreshDataGridView()
        {
            this.dataGridView1.DataSource = null;
            var q = from m in this.dbContext.我的追蹤清單MyFollowLists
                    where m.追讚倒編號ActionType_ID==3
                    select new
                    {
                        清單編號=m.我的追蹤清單編號CF_ID,
                        會員編號=m.會員編號Member_ID,
                        對象=m.對象Targets.對象名稱Target_Name,
                        連接編號=m.連接編號Connect_ID,
                        理由=m.檢舉理由ReportReason,
                        狀態=m.處理狀態Status,
                    };

            this.dataGridView1.DataSource = q.ToList();
            setGridStyle();

        }
        private void setGridStyle()
        {
            //dataGridView1.Columns[0].Width = 50;
            //dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 150;
            //dataGridView1.Columns[3].Width = 100;
            //dataGridView1.Columns[4].Width = 50;
            
            bool isColorChanged = false;
            Color bgColor;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                isColorChanged = !isColorChanged;
                bgColor = Color.LightBlue;
                if (isColorChanged)
                    bgColor = Color.WhiteSmoke;
                foreach (DataGridViewCell c in r.Cells)
                    c.Style.BackColor = bgColor;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            rtxtReply.Text += listBox1.SelectedItem.ToString();
        }

        private void btnSetData_Click(object sender, EventArgs e)
        {
            clsMem.buildFollowData();
        }

        private void cmbTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isRefresh) return;
            int s = cmbStatus.SelectedIndex;
            int s1 = cmbTarget.SelectedIndex;
            int s2 = cmbNull.SelectedIndex;

            var q = this.dbContext.我的追蹤清單MyFollowLists
                    .Where(m => m.追讚倒編號ActionType_ID == 3);

            if(s > -1 && s != cmbStatus.Items.Count - 1)
            {
                q = q.Where(m => m.處理狀態Status == s);
            }

            if (s1 > -1 && s1 != cmbTarget.Items.Count - 1)
            {
                q = q.Where(m => m.對象Target_ID == s1);
            }

            if (s2 == 0)
            {
                q = q.Where(m => m.檢舉理由ReportReason == ""|| m.檢舉理由ReportReason == null);
            }
            else if (s2 == 1)
            {
                q = q.Where(m => m.檢舉理由ReportReason != "");
            }

            var q1 = q.Select(m => new
            {
                清單編號 = m.我的追蹤清單編號CF_ID,
                會員編號 = m.會員編號Member_ID,
                對象 = m.對象Targets.對象名稱Target_Name,
                連接編號 = m.連接編號Connect_ID,
                理由 = m.檢舉理由ReportReason,
                狀態 = m.處理狀態Status,
            });
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = q1.ToList();
            setGridStyle();

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            string reporter = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtReporter.Text = reporter;
            string tar = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtTarget.Text = tar;
            string tarId = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtTargetID.Text = tarId;
            string reason1 = dataGridView1.Rows[index].Cells[4].Value.ToString();
            rtxtReason.Text = reason1;
            string status = dataGridView1.Rows[index].Cells[5].Value.ToString();
            if (status == "1")
                ckbStatus.Checked = true;
            else
                ckbStatus.Checked = false;
            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            seleCFid = Int32.Parse(id);
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (txtTargetID.Text == "")
                return;
            frmMemSearch fMem = new frmMemSearch();
            memId = Int32.Parse(txtTargetID.Text);
            isDetailClick = true;
            if (txtTarget.Text == "會員")
                fMem.Show();
                
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {            
            string s = txtSearch.Text;
            if (s == "") return;

            cmbNull.SelectedIndex = -1;
            int t = cmbTarget.SelectedIndex;
            var q = this.dbContext.我的追蹤清單MyFollowLists.AsEnumerable()
                    .Where(m => m.檢舉理由ReportReason.Contains(s));
            if (t > -1 && t != cmbTarget.Items.Count - 1)
            {
                q=q.Where(m => m.對象Target_ID == t);
            }
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = q.ToList();
            setGridStyle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsMem.buildFloorData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            isRefresh = true;
            refreshDataGridView();
            cmbNull.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            cmbTarget.SelectedIndex = -1;
            txtSearch.Text = "";
            isRefresh = false;
            
        }

        private void ckbStatus_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void ckbStatus_Click(object sender, EventArgs e)
        {
            if (txtTargetID.Text == "") return;

            我的追蹤清單MyFollowLists q = this.dbContext.我的追蹤清單MyFollowLists.AsEnumerable()
                .Where(m => m.我的追蹤清單編號CF_ID==seleCFid).FirstOrDefault();
            if (ckbStatus.Checked == true)
            {
                q.處理狀態Status = 1;
            }
            else
            {
                q.處理狀態Status = 0;
            }

            this.dbContext.SaveChanges();
            MessageBox.Show("處理狀態修改成功");
        }
    }
}
