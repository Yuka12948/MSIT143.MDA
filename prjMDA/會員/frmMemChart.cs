using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMDA.會員
{
    public partial class frmMemChart : Form
    {
        MDAEntities dbContext = new MDAEntities();

        public frmMemChart()
        {
            InitializeComponent();
        }

        private void frmMemReport_Load(object sender, EventArgs e)
        {
            //this.cmbYearMonth.Items.Add("ALL");
            //this.cmbYearMonth.Items.Add("依性別");

            this.cmbCopose.Items.Add("簡易/正式會員");
            this.cmbCopose.Items.Add("性別");
            this.cmbCopose.Items.Add("地區");

            //==============================================================
            //Age 
            string[] groupAge = { "20歲以下", "20~29歲", "30~39歲", "40~49歲", "50~59歲", "60歲以上" };

            var qAge = this.dbContext.會員Members.AsEnumerable()
                .Where(m => m.正式會員Formal == true)
                .GroupBy(m => grpAge(m)).Select(g => new
                {
                    Age = g.Key,
                    Count = g.Count(),
                }).OrderBy(m => m.Age);


            this.chtAge.DataSource = qAge.ToList();
            this.chtAge.Series[0].XValueMember = "Age";
            this.chtAge.Series[0].YValueMembers = "Count";
            this.chtAge.Series[0].Name = "人數";
            this.chtAge.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            //==============================================================
            //CreTime
            //var qCreYear = this.dbContext.會員Members.AsEnumerable().GroupBy(m => m.建立時間CreatedTime.Year).Select(g => new
            //{
            //    Year = g.Key,
            //    Count = g.Count(),
            //});
            //this.chtCreTime.DataSource = qCreYear.ToList();
            //this.chtCreTime.Series[0].XValueMember = "Year";
            //this.chtCreTime.Series[0].YValueMembers = "Count";
            //this.chtCreTime.Series[0].Name = "加入會員人數";
            //this.chtCreTime.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            //==============================================================
            //CreTime Month
            var qCreMon = this.dbContext.會員Members.AsEnumerable()
                .GroupBy(m => new { m.建立時間CreatedTime.Year, m.建立時間CreatedTime.Month })
                .Select(g => new
                {
                    YearMonth = $"{g.Key.Year}/{g.Key.Month}",
                    Count = g.Count(),
                }).OrderBy(m => m.YearMonth);

            this.chtCreTime.DataSource = qCreMon.ToList();
            this.chtCreTime.Series[0].XValueMember = "YearMonth";
            this.chtCreTime.Series[0].YValueMembers = "Count";
            this.chtCreTime.Series[0].Name = "加入會員人數";
            this.chtCreTime.Series[0].BorderWidth = 3;
            this.chtCreTime.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            //==============================================================
            drawFormal();
            //==============================================================

        }

        private void drawFormal()
        {
            decimal q = this.dbContext.會員Members.AsEnumerable().Count();
            //Comp Formal
            var qFormal = this.dbContext.會員Members.AsEnumerable()
                .GroupBy(m => grpFormal(m))
                .Select(g => new
                {
                    Formal = g.Key,
                    xx = $"{g.Key} {(g.Count() / q).ToString("P1")}",
                    Count = g.Count(),
                });
            this.chtComp.DataSource = qFormal.ToList();
            this.chtComp.Series[0].XValueMember = "xx";
            this.chtComp.Series[0].YValueMembers = "Count";
            this.chtComp.Series[0].Name = "人數";
            this.chtComp.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }
        private void drawGender()
        {
            decimal q = this.dbContext.會員Members.AsEnumerable()
                .Where(m => m.正式會員Formal == true).Count();
            //Comp Gender
            var qGender = this.dbContext.會員Members.AsEnumerable()
                .Where(m => m.正式會員Formal == true)
                .GroupBy(m => grpGender(m))
                .Select(g => new
                {
                    Gender = g.Key,
                    xx = $"{g.Key} {(g.Count() / q).ToString("P1")}",
                    Count = g.Count(),
                });
            this.chtComp.DataSource = qGender.ToList();
            this.chtComp.Series[0].XValueMember = "xx";
            this.chtComp.Series[0].YValueMembers = "Count";
            this.chtComp.Series[0].Name = "人數";
            this.chtComp.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }
        private void drawAddress()
        {
            //Comp Address
            var qAddress = this.dbContext.會員Members.AsEnumerable()
                .Where(m => m.正式會員Formal == true)
                .GroupBy(m => m.地址Address)
                .Select(g => new
                {
                    Region = g.Key,
                    Count = g.Count(),
                }).OrderByDescending(m => m.Count);
            this.chtComp.DataSource = qAddress.ToList();
            this.chtComp.Series[0].XValueMember = "Region";
            this.chtComp.Series[0].YValueMembers = "Count";
            this.chtComp.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            this.chtComp.ChartAreas["ChartArea1"].AxisX.IntervalOffset = 1;
            this.chtComp.ChartAreas["ChartArea1"].AxisX.LabelStyle.IsStaggered = true;
            this.chtComp.Series[0].Name = "人數";
            this.chtComp.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }
        private string grpFormal(會員Members m)
        {
            if (m.正式會員Formal == false)
                return "簡易會員";
            else
                return "正式會員";
        }
        private string grpGender(會員Members m)
        {
            string[] groupGender = { "不公開", "男", "女", "多元性別" };

            return groupGender[(int)m.性別Gender];
        }
        private string grpAge(會員Members m)
        {
            string[] groupAge = { "20歲以下", "20~29歲", "30~39歲", "40~49歲", "50~59歲", "60歲以上" };

            int age = (DateTime.Now.Year - m.生日BirthDate.Value.Year);

            if (age < 20)
                return groupAge[0];
            else if (age < 30)
                return groupAge[1];
            else if (age < 40)
                return groupAge[2];
            else if (age < 50)
                return groupAge[3];
            else if (age < 60)
                return groupAge[4];
            else
                return groupAge[5];
        }

        private void cmbCopose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCopose.SelectedIndex < 0)
                return;
            else if (cmbCopose.SelectedIndex == 0) //正式//性別//地區
                drawFormal();
            else if (cmbCopose.SelectedIndex == 1)
                drawGender();
            else
                drawAddress();
        }







    }
}
