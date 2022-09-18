using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMDA
{
    public partial class 優惠券分析 : Form
    {
        public 優惠券分析()
        {
            InitializeComponent();
        }
        優惠總表Coupon 優惠總表Coupon = new 優惠總表Coupon();
        MDAEntities db = new MDAEntities();
        優惠明細CouponLists 優惠明細CouponLists = new 優惠明細CouponLists();
        會員Members 會員Members = new 會員Members();

        void viewchart1()
        {
            string flag = "true";
            var q = db.優惠明細CouponLists.AsEnumerable().GroupBy(p => flag = p.是否使用優惠OX_CouponUsing ? "已使用" : "未使用").Select(p => new {
                使用狀態 = p.Key,
                數量 = p.Count()
            });
            chart1.DataSource = q.ToList();
            chart1.Series[0].XValueMember = "使用狀態";
            chart1.Series[0].YValueMembers = "數量";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }

        void viewchart2()
        {

          var q = db.優惠明細CouponLists.AsEnumerable().GroupBy(p => p.優惠總表Coupon.優惠名稱Coupon_Name).Select(o => new
            {
                優惠券 = o.Key,
                數量 = o.Count(),
                使用狀態1 = o.Where(t => t.是否使用優惠OX_CouponUsing == true).ToList().Count(),
                使用狀態2 = o.Where(t => t.是否使用優惠OX_CouponUsing == false).ToList().Count(),
            });
            
            chart2.DataSource = q.ToList();
            chart2.Series[0].XValueMember = "優惠券";
            chart2.Series[0].YValueMembers = "使用狀態1";
            chart2.Series[1].XValueMember = "優惠券";
            chart2.Series[1].YValueMembers = "使用狀態2";            
            this.chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }

        private void btnviewBonus_Click(object sender, EventArgs e)
        {
            viewchart1();
            viewchart2();
        }
    }
}
