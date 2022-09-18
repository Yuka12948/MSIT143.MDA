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
    public partial class 關鍵字查詢 : Form
    {
        public 關鍵字查詢()
        {
            InitializeComponent();
        }
        public string keyword
        {
            get { return this.myKeyWord.Text; }
            set { myKeyWord.Text = value; }
        }
        bool isClickOk = false;
        public bool getclickok
        {
            get { return isClickOk; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            isClickOk = true;
            Frm票價資訊 myTickInfo = new Frm票價資訊();
           // myTickInfo.listBox1.Items.Clear();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
