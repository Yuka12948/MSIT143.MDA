using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMDA.編輯視窗
{
    public partial class Frm座位顯示 : Form
    {
        public Frm座位顯示()
        {
            InitializeComponent();
        }

        public Frm座位顯示(string SeatInfo)
        {
            InitializeComponent();
            PrinfSeat(SeatInfo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrinfSeat(txtSeatInfo.Text);
        }

        private void RB_Click(object sender, EventArgs e)
        {
            RadioButton RB = sender as RadioButton;
            if (RB == null)
                return;

            MessageBox.Show(RB.Tag.ToString());
        }

        private void PrinfSeat(string seatInfo)
        {
            if (seatInfo == "")
                return;

            string[] SeatInfoArr = seatInfo.Split('@');

            int X = 85; //==>初始位置X
            int Y = 85; //==>初始位置Y

            foreach (string seat in SeatInfoArr)
            {

                if (!seat.Contains("NA") && !seat.Contains("||") && seat != "")
                {
                    RadioButton RB = new RadioButton();
                    RB.Text = "";
                    RB.Tag = $"{seat}";
                    RB.Size = new Size(25, 25);
                    RB.Location = new Point(X, Y);
                    RB.Click += RB_Click;
                    this.splitContainer1.Panel2.Controls.Add(RB);
                }

                X += 25;
                if (seat.Contains("||"))
                {
                    X = 85;
                    Y += 25;
                }
            }
        }
    }
}
