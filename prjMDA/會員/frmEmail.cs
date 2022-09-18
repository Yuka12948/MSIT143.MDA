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
    public partial class frmEmail : Form
    {  
        public frmEmail()
        {
            InitializeComponent();
        }
        string title = "檢舉事項回覆";

        private void frmEmail_Load(object sender, EventArgs e)
        {
            txtEmail.Text = frmReport.email;
            txtTitle.Text = title;
            string a = $"針對您此次提出的檢舉,";
            if (frmReport.reason != "")
                a += $"「{frmReport.reason}」";
            txtContent.Text = 
                $"親愛的會員 {frmReport.name} 您好，\n" +
                $"感谢您對認為達反我們社群守則的內容提出檢舉。對於讓MDA成為安全且友好的環境來說,您提出的檢舉是相當重要的一環。\n" +
                $"{a}\n" +
                $"{frmReport.reply}\n" +
                $"感謝您！";
        }
    }
}
