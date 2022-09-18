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

namespace ProjectMda
{
    public partial class 訂單總表 : Form
    {
        public 訂單總表()
        {
            InitializeComponent();
        }
        MDAEntities dbContext = new MDAEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            //TODO 編輯中
            //訂單總表Orders OrderTable = new 訂單總表Orders() {
            //會員編號Members_ID=Convert.ToInt32(textBox1.Text),
            //訂單時間=dateTimePicker1.Value,
            //場次編號Screening_ID=Convert.ToInt32(textBox3.Text),
            //優惠明細編號BonusList_ID=Convert.ToInt32(textBox4.Text),
            //訂單狀態編號OrderStatus_ID=Convert.ToInt32(textBox5.Text)
            //};
            //this.dbContext.訂單總表Orders.Add(OrderTable);
            //this.dbContext.SaveChanges();
        }
    }
}
