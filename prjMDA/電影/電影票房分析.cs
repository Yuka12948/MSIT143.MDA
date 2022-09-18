using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMDA.電影
{
    public partial class 電影票房分析 : Form
    {
        MDAEntities dbContext = new MDAEntities();
        List<Class1> 票房 = new List<Class1>();

        public 電影票房分析()
        {
            InitializeComponent();
        }

        private void btn票房分析_Click(object sender, EventArgs e)
        {
            var q = dbContext.電影Movies;


            var q1 = dbContext.電影Movies.AsEnumerable().Select(p => new {
                票房 = Convert.ToDouble(p.票房BoxOffice.Replace("億美元", "")),
                名稱 = p.中文標題Title_Cht,
            });


            foreach (var item in q1)
            {
                Class1 class1 = new Class1();
                class1.x = item.票房;
                class1.name = item.名稱;
                票房.Add(class1);
            }
            this.dataGridView1.DataSource = q1.ToList();
            this.chart1.DataSource = q1.ToList();
            this.chart1.Series[0].XValueMember = "名稱";
            this.chart1.Series[0].YValueMembers = "票房";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            this.chart1.Series[0].Name = "億美元";
        }
    }
}
