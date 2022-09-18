using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMDA.Models
{
    public partial class frmKeyword : Form
    {
        bool _isOkClick = false;
        public frmKeyword()
        {
            InitializeComponent();
        }
        public string keyword
        {
            get { return txtKeyword.Text; }
            set { txtKeyword.Text = value; }
        }
        public bool isOkButtonClicked
        {
            get { return _isOkClick; }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _isOkClick = true;
            Close();
        }
    }
}
