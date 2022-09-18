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
    public partial class frmBonusPlus : Form
    {
        bool _isOkClick = false;
        public frmBonusPlus()
        {
            InitializeComponent();
        }

        public int bonus
        {
            get { return Int32.Parse(txtBonusPlus.Text); }
            set { txtBonusPlus.Text = value.ToString(); }

        }
        public bool isOkButtonClicked
        {
            get { return _isOkClick; }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _isOkClick = true;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
