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
    public partial class ItemTemplateTicket : UserControl
    {
        public ItemTemplateTicket()
        {
            InitializeComponent();
        }
        public string MyTickname
        {

            set { label1.Text = value; }
        }
    }
}
