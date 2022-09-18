using prjMDA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMDAComment
{
    public partial class Frm_MDA評論分析 : Form
    {
        public Frm_MDA評論分析()
        {
            InitializeComponent();
        }

        MDAEntities dbMDA = new MDAEntities();

        private void Frm_MDA評論分析_Load(object sender, EventArgs e)
        {
            listBoxMovie.Items.Clear();
            lab電影評論數.Text = "電影評論數TOP5";
            lab電影評分.Text = "電影評分TOP5";
            lab電影期待度.Text = "電影期待度TOP5";

            #region //listbox顯示電影清單

            var q = dbMDA.電影Movies
                         .Select(g => new
                         {
                             電影編號 = g.電影編號Movie_ID,
                             電影標題 = g.中文標題Title_Cht,
                         });

            foreach (var item in q)
                listBoxMovie.Items.Add(item.電影編號 + " " + item.電影標題);

            var qAll = dbMDA.電影評論MovieComment
                            .Select(g => new
                            {
                                評論編號 = g.評論編號Comment_ID,
                                評論標題 = g.評論標題Comment_Title,
                                電影編號 = g.電影編號Movie_ID,
                                評論電影 = g.電影Movies.中文標題Title_Cht,
                                評論內容 = g.評論內容Comments,
                                會員編號 = g.會員編號Member_ID,
                                //發佈人 = g.會員Members.暱稱NickName,
                                評分 = g.評分Rate,
                                期待度 = g.期待度anticipation,
                                觀影方式 = g.觀影方式Source,
                                觀影日期 = g.觀影日期Viewing_Time,
                                發佈時間 = g.發佈時間Comment_Time,
                                公開等級 = g.公開等級編號Public_ID, // 0公開/1限追蹤者/2不公開 
                                是否開放討論串 = g.是否開放討論串OX_Floor,
                                屏蔽狀態 = g.屏蔽Invisible, // 0正常/1刪除(會員)/2敏感言論屏蔽(自動過濾)/3檢舉屏蔽(管理員審核)
                                檢舉狀態 = g.檢舉Report, // 0正常/1待審核/2審核>正常>不屏蔽/3審核>不正常>屏蔽
                            });

            //this.dataGridView.DataSource = qAll.ToList();

            #endregion

            int qsCount = dbMDA.電影評論MovieComment.Count();

            //================ 總評論數 ================
            
            var q評論數 = dbMDA.電影評論MovieComment.AsEnumerable()
                               .GroupBy(g=>g.電影Movies.中文標題Title_Cht)
                               .Select(g => new
                               {
                                   電影標題 = g.Key,
                                   評論數 = g.Count(),
                                   負評數 = g.Where(gg=>gg.評分Rate<=3).Select(gg=>gg.評分Rate).Count(),
                                   好評數 = g.Where(gg => gg.評分Rate > 3).Select(gg => gg.評分Rate).Count(),
                               }).OrderByDescending(g => g.評論數).Take(5);

            this.chart評論數.DataSource = q評論數.ToList();
            this.chart評論數.Series[0].XValueMember = "電影標題";
            this.chart評論數.Series[0].YValueMembers = "評論數";
            this.chart評論數.Series[0].Name = "評論數量";
            this.chart評論數.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            this.chart評論數.Series[1].YValueMembers = "負評數";
            this.chart評論數.Series[1].Name = "負評數量";
            this.chart評論數.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            this.chart評論數.Series[2].YValueMembers = "好評數";
            this.chart評論數.Series[2].Name = "好評數量";
            this.chart評論數.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

            //================ 總評分 ================

            var q評分 = dbMDA.電影評論MovieComment.AsEnumerable()
                             .GroupBy(g => g.電影Movies.中文標題Title_Cht)
                             .Select(g => new
                             {
                                 電影標題 = g.Key,
                                 平均評分 = g.Select(gg => gg.評分Rate).Sum() / g.Count(),
                             }).OrderByDescending(g => g.平均評分).Take(5); ;

            this.chart評分.DataSource = q評分.ToList();
            this.chart評分.Series[0].XValueMember = "電影標題";
            this.chart評分.Series[0].YValueMembers = "平均評分";
            this.chart評分.Series[0].Name = "平均評分";
            this.chart評分.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

            //================ 總期待度 ================

            var q期待度 = dbMDA.電影評論MovieComment.AsEnumerable()
                               .GroupBy(g => g.電影Movies.中文標題Title_Cht)
                               .Select(g => new
                               {
                                   電影標題 = g.Key,
                                   平均期待度 = g.Select(gg => gg.期待度anticipation).Sum() / g.Count(),
                               }).OrderByDescending(g => g.平均期待度).Take(5); ;

            this.chart期待度.DataSource = q期待度.ToList();
            this.chart期待度.Series[0].XValueMember = "電影標題";
            this.chart期待度.Series[0].YValueMembers = "平均期待度";
            this.chart期待度.Series[0].Name = "平均期待度";
            this.chart期待度.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

            //================ 總公開度 ================

            var q公開 = dbMDA.電影評論MovieComment.AsEnumerable()
                             .GroupBy(qs => str公開(qs))
                             .Select(g => new
                             {
                                 公開度 = g.Key.ToString() /*+ " " + (Convert.ToDecimal(g.Count()) / Convert.ToDecimal(qs評論Count)).ToString("0.##")*/,
                                 人數 = g.Count(),
                                 百分比 = (Convert.ToDecimal(g.Count()) / Convert.ToDecimal(qsCount)).ToString("P1")
                             });

            this.dataGridView公開.DataSource = q公開.ToList();

            this.chart公開.DataSource = q公開.ToList();
            this.chart公開.Series[0].XValueMember = "公開度";
            this.chart公開.Series[0].YValueMembers = "人數";
            this.chart公開.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            //================ 總觀影方式 ================

            var q觀影方式 = dbMDA.電影評論MovieComment.AsEnumerable()
                                 .GroupBy(qs => qs.觀影方式Source)
                                 .Select(g => new
                                 {
                                     觀影方式 = g.Key.ToString(),
                                     人數 = g.Count(),
                                     百分比 = (Convert.ToDecimal(g.Count()) / Convert.ToDecimal(qsCount)).ToString("P1"),
                                 });

            this.dataGridView觀影方式.DataSource = q觀影方式.ToList();

            this.chart觀影方式.DataSource = q觀影方式.ToList();
            this.chart觀影方式.Series[0].XValueMember = "觀影方式";
            this.chart觀影方式.Series[0].YValueMembers = "人數";
            this.chart觀影方式.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }



        private void listBoxMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region //顯示listbox所選擇的電影評論
            lab電影評論數.Text = "電影評論數";
            lab電影評分.Text = "電影評分";
            lab電影期待度.Text = "電影期待度";

            //this.dataGridView.DataSource = null;

            var qAll = dbMDA.電影評論MovieComment.AsEnumerable()
                            .Where(qs=>qs.屏蔽Invisible != 1)
                            .OrderByDescending(qs=>qs.評論編號Comment_ID)
                            .Select(g => new
                            {
                                評論編號 = g.評論編號Comment_ID,
                                評論標題 = g.評論標題Comment_Title,
                                電影編號 = g.電影編號Movie_ID,
                                評論電影 = g.電影Movies.中文標題Title_Cht,
                                評論內容 = g.評論內容Comments,
                                會員編號 = g.會員編號Member_ID,
                                //發佈人 = g.會員Members.暱稱NickName,
                                評分 = g.評分Rate,
                                期待度 = g.期待度anticipation,
                                觀影方式 = g.觀影方式Source,
                                觀影日期 = g.觀影日期Viewing_Time,
                                發佈時間 = g.發佈時間Comment_Time,
                                公開等級 = g.公開等級編號Public_ID, // 0公開/1限追蹤者/2不公開 
                                是否開放討論串 = g.是否開放討論串OX_Floor,
                                屏蔽狀態 = g.屏蔽Invisible, // 0正常/1刪除(會員)/2敏感言論屏蔽(自動過濾)/3檢舉屏蔽(管理員審核)
                                檢舉狀態 = g.檢舉Report, // 0正常/1待審核/2審核>正常>不屏蔽/3審核>不正常>屏蔽
                            });

            var q選擇電影 = qAll
                            .Where(qs => qs.電影編號 == listBoxMovie.SelectedIndex+1)
                            .Select(g => new
                            {
                                評論編號 = g.評論編號,
                                評論標題 = g.評論標題,
                                電影編號 = g.電影編號,
                                評論電影 = g.評論電影,
                                評論內容 = g.評論內容,
                                會員編號 = g.會員編號,
                                //發佈人 = g.發佈人,
                                評分 = g.評分,
                                期待度 = g.期待度,
                                觀影方式 = g.觀影方式,
                                觀影日期 = g.觀影日期,
                                發佈時間 = g.發佈時間,
                                公開等級 = g.公開等級, // 0公開/1限追蹤者/2不公開 
                                是否開放討論串 = g.是否開放討論串,
                                屏蔽狀態 = g.屏蔽狀態, // 0正常/1刪除(會員)/2敏感言論屏蔽(自動過濾)/3檢舉屏蔽(管理員審核)
                                檢舉狀態 = g.檢舉狀態 // 0正常/1待審核/2審核>正常>不屏蔽/3審核>不正常>屏蔽
                            });

            //this.dataGridView.DataSource = q選擇電影.ToList();

            #endregion

            //================ 評論數 ================

            var q評論數 = dbMDA.電影評論MovieComment.AsEnumerable()
                               .Where(qs => qs.電影編號Movie_ID == listBoxMovie.SelectedIndex + 1)
                               .GroupBy(g => g.電影Movies.中文標題Title_Cht)
                               .Select(g => new
                               {
                                   電影標題 = g.Key,
                                   評論數 = g.Count(),
                                   負評數 = g.Where(gg => gg.評分Rate <= 3).Select(gg => gg.評分Rate).Count(),
                                   好評數 = g.Where(gg => gg.評分Rate > 3).Select(gg => gg.評分Rate).Count(),
                               }).OrderByDescending(g => g.評論數).Take(5);

            this.chart評論數.DataSource = q評論數.ToList();
            this.chart評論數.Series[0].XValueMember = "電影標題";
            this.chart評論數.Series[0].YValueMembers = "評論數";
            this.chart評論數.Series[0].Name = "評論數量";
            this.chart評論數.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

            //================ 評分 ================

            var q評分 = dbMDA.電影評論MovieComment.AsEnumerable()
                             .Where(qs => qs.電影編號Movie_ID == listBoxMovie.SelectedIndex + 1)
                             .GroupBy(g => g.電影Movies.中文標題Title_Cht)
                             .Select(g => new
                             {
                                 電影標題 = g.Key,
                                 平均評分 = g.Select(gg => gg.評分Rate).Sum() / g.Count(),
                             }).OrderByDescending(g => g.平均評分).Take(5); ;

            this.chart評分.DataSource = q評分.ToList();
            this.chart評分.Series[0].XValueMember = "電影標題";
            this.chart評分.Series[0].YValueMembers = "平均評分";
            this.chart評分.Series[0].Name = "平均評分";
            this.chart評分.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

            //================ 期待度 ================

            var q期待度 = dbMDA.電影評論MovieComment.AsEnumerable()
                               .Where(qs => qs.電影編號Movie_ID == listBoxMovie.SelectedIndex + 1)
                               .GroupBy(g => g.電影Movies.中文標題Title_Cht)
                               .Select(g => new
                               {
                                   電影標題 = g.Key,
                                   平均期待度 = g.Select(gg => gg.期待度anticipation).Sum() / g.Count(),
                               }).OrderByDescending(g => g.平均期待度).Take(5); ;

            this.chart期待度.DataSource = q期待度.ToList();
            this.chart期待度.Series[0].XValueMember = "電影標題";
            this.chart期待度.Series[0].YValueMembers = "平均期待度";
            this.chart期待度.Series[0].Name = "平均期待度";
            this.chart期待度.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

            //================ 公開度分析 ================

            int qsCount = dbMDA.電影評論MovieComment.Where(qs => qs.電影編號Movie_ID == listBoxMovie.SelectedIndex + 1).Count();

            var q公開 = dbMDA.電影評論MovieComment.AsEnumerable()
                             .Where(qs => qs.電影編號Movie_ID == listBoxMovie.SelectedIndex + 1)
                             .GroupBy(qs => str公開(qs))
                             .Select(g => new
                             {
                                 公開度 = g.Key.ToString(),
                                 人數 = g.Count(),
                                 百分比 = (Convert.ToDecimal(g.Count()) / Convert.ToDecimal(qsCount)).ToString("P1")
                             });

            this.dataGridView公開.DataSource = q公開.ToList();

            this.chart公開.DataSource = q公開.ToList();
            this.chart公開.Series[0].XValueMember = "公開度";
            this.chart公開.Series[0].YValueMembers = "人數";
            this.chart公開.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            //================ 觀影方式 ================

            var q觀影方式 = dbMDA.電影評論MovieComment.AsEnumerable()
                                 .Where(qs => qs.電影編號Movie_ID == listBoxMovie.SelectedIndex + 1)
                                 .GroupBy(qs => qs.觀影方式Source)
                                 .Select(g => new
                                 {
                                     觀影方式 = g.Key.ToString(),
                                     人數 = g.Count(),
                                     百分比 = (Convert.ToDecimal(g.Count()) / Convert.ToDecimal(qsCount)).ToString("P1")
                                 });

            this.dataGridView觀影方式.DataSource = q觀影方式.ToList();

            this.chart觀影方式.DataSource = q觀影方式.ToList();
            this.chart觀影方式.Series[0].XValueMember = "觀影方式";
            this.chart觀影方式.Series[0].YValueMembers = "人數";
            this.chart觀影方式.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

        private string str公開(電影評論MovieComment m)
        {
            string[] string公開 = { "公開", "僅追蹤者", "不公開"};
            return string公開[(int)m.公開等級編號Public_ID];
        }
    }
}
