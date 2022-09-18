using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMDA
{
    internal class Members //會員 Members
    {
        public string Cellphone { get; set; } //數字鍵[0-9]是48~57
        public String Password { get; set; }
        public String F_Name { get; set; }
        public String L_Name { get; set; }
        public String NickName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Gender { get; set; }
        public String E_Mail { get; set; }
        public String Address { get; set; }
        public int Point { get; set; }
        public bool Formal { get; set; }
        public bool Permission { get; set; }
        public String image { get; set; }

    }
}
