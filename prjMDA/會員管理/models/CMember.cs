using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMember
{
    public class CMember
    {
        MDAEntities dbContext = new MDAEntities();
        public CMember()
        {

        }

        static string str_ph;
        public static string phone
        {
            get
            { return str_ph; }
            set
            { str_ph = value; }
        }

        public void buildData()
        {
            Random rnd = new Random();
            
            string[] lastname = { "趙", "錢", "孫", "李", "周", "吳", "鄭", "王", "馮", "陳", "褚", "衛", "蔣", "沈", "韓", "楊" };
            string[] firstname = { "家豪", "志明", "俊傑", "建宏", "俊宏", "志豪", "志偉", "文雄", "金龍", "志強", "淑芬", "淑惠", "美玲", "雅婷", "美惠", "麗華", "淑娟", "淑貞", "怡君", "淑華" };
            string[] company = { "gmail", "hotmail", "outlook", "yahoo" };
            string[] place = { "台北", "台中", "新北", "新竹", "苗栗", "嘉義", "台南", "雲林", "宜蘭", "花蓮", "屏東", "高雄" };
            string phone = "";
            string email = "";
            string password = "";
            string fname = "";
            string lname = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source =.; Initial Catalog = MDA; Integrated Security = True";
            con.Open();

            for (int j = 0; j < 5; j++)
            {

                fname = lastname[rnd.Next(0, lastname.Length)];
                lname = firstname[rnd.Next(0, firstname.Length)];
                phone = "";
                for (int i = 0; i < 8; i++)
                {
                    phone += rnd.Next(0, 9).ToString();
                }
                phone = "09" + phone;

                email = "";
                for (int i = 0; i < rnd.Next(7, 12); i++)
                {
                    email += (char)rnd.Next(97, 122);
                }
                email = email + "@" + company[rnd.Next(0, company.Length)] + ".com.tw";
                password = "";
                for (int i = 0; i < rnd.Next(7, 12); i++)
                {
                    password += (char)rnd.Next(97, 122);
                }

                string sql = "INSERT INTO 會員Members(";
                sql += "會員電話Cellphone,";
                sql += "密碼Password,";  //要新增欄位加這順位第二
                sql += "姓氏L_Name,";
                sql += "名字F_Name,";
                sql += "暱稱Nickname,";
                //sql += "生日BirthDate,";
                sql += "性別Gender,";
                sql += "電子信箱EMail,";  //要新增欄位加這倒數第二
                sql += "地址Address,";
                sql += "紅利點數Bonus,";
                sql += "正式會員Formal,";
                sql += "會員權限Permission";
                //sql += "會員照片Image";
                sql += ") VALUES (";
                sql += "'" + phone + "',";
                sql += "'0000',";/*"'" + password + "',";*/
                sql += "'" + fname + "',";
                sql += "'" + lname + "',";
                sql += "'0',";
                //sql += "'0',";
                sql += "'0',";
                sql += "'" + email + "',";
                sql += "'" + place[rnd.Next(0, place.Length)] + "',";
                sql += "'0',";
                sql += "'0',";
                sql += "'0')";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("假資料建立成功");
        }

        public void buildFollowData()
        {
            Random rnd = new Random();

            List<int> members = new List<int>();
            List<int> comms = new List<int>();
            List<int> replies = new List<int>();

            var tempMem = this.dbContext.會員Members.Where(m=>m.正式會員Formal==true).Select(m => m.會員編號Member_ID);            
            members = tempMem.ToList();

            var tempCom = dbContext.電影評論MovieComment.Select(c => c.評論編號Comment_ID);
            comms = tempCom.ToList();

            var tempRep = dbContext.回覆樓數Floor.Select(f => f.樓數編號Floor_ID);
            replies = tempRep.ToList();

            List<string> reasons = new List<string>()
            {
                "暴雷", "騷擾", "", "寫太爛", "看他不爽", "",
            };

            List<int> typesId = new List<int>() { 0, 3 };

            for (int i = 0; i < 10; i++)
            {
                我的追蹤清單MyFollowLists m = new 我的追蹤清單MyFollowLists
                {
                    會員編號Member_ID = members[rnd.Next(0, members.Count())],
                    對象Target_ID = 1,
                    追讚倒編號ActionType_ID = typesId[rnd.Next(0, 2)],
                    連接編號Connect_ID = members[rnd.Next(0, members.Count())],
                    檢舉理由ReportReason = "",
                    處理狀態Status = null,

                };
                this.dbContext.我的追蹤清單MyFollowLists.Add(m);
            }
            for (int i = 0; i < 10; i++)
            {
                我的追蹤清單MyFollowLists m = new 我的追蹤清單MyFollowLists
                {
                    會員編號Member_ID = members[rnd.Next(0, members.Count())],
                    對象Target_ID = 2,
                    追讚倒編號ActionType_ID = rnd.Next(0, 4),
                    連接編號Connect_ID = comms[rnd.Next(0, comms.Count())],
                    檢舉理由ReportReason = "",
                    處理狀態Status = null,

                };
                this.dbContext.我的追蹤清單MyFollowLists.Add(m);
            }
            for (int i = 0; i < 10; i++)
            {
                我的追蹤清單MyFollowLists m = new 我的追蹤清單MyFollowLists
                {
                    會員編號Member_ID = members[rnd.Next(0, members.Count())],
                    對象Target_ID = 0,
                    追讚倒編號ActionType_ID = rnd.Next(0, 4),
                    連接編號Connect_ID = replies[rnd.Next(0, replies.Count())],
                    檢舉理由ReportReason = "",
                    處理狀態Status = null,

                };
                this.dbContext.我的追蹤清單MyFollowLists.Add(m);
            }
            this.dbContext.SaveChanges();

            var q = dbContext.我的追蹤清單MyFollowLists
                .Where(m => m.追讚倒編號ActionType_ID == 3);
            foreach (var m in q.ToList())
            {
                m.處理狀態Status = 0;
                m.檢舉理由ReportReason = reasons[rnd.Next(0, reasons.Count())];
            }
            this.dbContext.SaveChanges();

            MessageBox.Show("假資料建立成功");
        }

        public void buildFloorData()
        {
            Random rnd = new Random();

            List<int> members = new List<int>();
            List<int> comms = new List<int>();
            
            List<string> replies = new List<string>()
            {
                "讚喔","無聊","雷","認同","推","原來如此","看不懂","太棒了",
            };
            

            var tempMem = this.dbContext.會員Members.Select(m => m.會員編號Member_ID);
            members = tempMem.ToList();

            var tempCom = dbContext.電影評論MovieComment.Select(c => c.評論編號Comment_ID);
            comms = tempCom.ToList();

            for (int i = 0; i < 20; i++)
            {
                回覆樓數Floor f = new 回覆樓數Floor
                {
                    評論編號Comment_ID = comms[rnd.Next(0, comms.Count())],
                    會員編號Member_ID = members[rnd.Next(0, members.Count())],
                    回覆內容Floors = replies[rnd.Next(0, replies.Count())],
                    發佈時間Floor_Time=DateTime.Now,
                    被按讚次數Thumbs_Up = null,
                    被倒讚次數Thumbs_Down = null,
                    屏蔽Invisible = 0,
                    檢舉Report = 0,
                };
                this.dbContext.回覆樓數Floor.Add(f);
            }
            this.dbContext.SaveChanges();
            MessageBox.Show("假資料建立成功");

        }



    }
}

