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
    public partial class Frm座位編輯 : Form
    {
        public Frm座位編輯()
        {
            InitializeComponent();
            BtnCheck.Enabled = false;
            BtnSubmit.Enabled = false;
        }

        public string SeatInfostr { get { return TxtSeatInfo.Text; } }

        private Color flagColor = Color.Red;
        private Color originColor = Color.Green;
        private string _pathFlag;

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(flagColor==Color.Gray)
            {
                changeColor(_pathFlag, btn.Tag as int[]);
            }
            else if(functionBox.Text=="查詢")
            {
                int[] arr = btn.Tag as int[];
                MessageBox.Show($"{arr[0]}:{arr[1]}");
            }
            else
            {
                btn.BackColor = btn.BackColor == originColor ? flagColor : originColor;
            }
        }

        private void Show_buttom(int SizeofX, int SizeofY)
        {
            int X, Y;
            int tag = 0;

            while(tag==0)
            {

                X = 195; //==>初始位置X軸
                Y = 63; //==>初始位置Y軸
                for (int i = 0; i < SizeofX; i++)
                {
                    Label lbl = new Label();
                    lbl.Text = i.ToString();
                    lbl.AutoSize = false;
                    lbl.Font = lbl.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                    lbl.Size = new Size(60, 30);
                    lbl.Location = new Point(X, Y);
                    lbl.Text = i.ToString();
                    lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    this.splitContainer1.Panel2.Controls.Add(lbl);
                    X += 65;

                }

                X = 135; //==>初始位置X軸
                Y = 107; //==>初始位置Y軸

                for (int i = 0; i < SizeofY; i++)
                {
                    Label lbl = new Label();
                    lbl.AutoSize = false;
                    lbl.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                    lbl.Size = new Size(60, 30);
                    lbl.Text = i.ToString();
                    lbl.Location = new Point(X, Y);
                    lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                    this.splitContainer1.Panel2.Controls.Add(lbl);
                    Y += 65;
                }

                X = 195; //==>初始位置X軸
                Y = 95; //==>初始位置Y軸
                for (int i = 0; i < SizeofY; i++)
                {
                    X = 195;//==>初始位置X
                    for (int j = 0; j < SizeofX; j++)
                    {
                        Button btn = new Button();
                        btn.Size = new Size(60, 60);
                        btn.Click += Btn_Click;
                        btn.BackColor = Color.Green;
                        btn.Location = new Point(X, Y);
                        btn.Tag = new int[] { i+1, j+1 };
                        this.splitContainer1.Panel2.Controls.Add(btn);
                        X += 65;
                        Application.DoEvents();
                    }
                    Y += 65;
                    Application.DoEvents();
                }

                tag++;
                Application.DoEvents();
            }


        }

        private void fn_ButtonDelet()
        {
            this.splitContainer1.Panel2.Controls.Clear();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            fn_ButtonDelet();
            int X = Convert.ToInt32(this.txtColumn.Text);
            int Y = Convert.ToInt32(this.txtRow.Text);            
            Show_buttom(X, Y);
            BtnCheck.Enabled = true;
        }

        private void functionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (functionBox.Text)
            {
                case "空位":
                    flagColor = Color.Red;
                    break;
                case "走道(橫)":
                    flagColor = Color.Gray;
                    _pathFlag = "row";
                    break;
                case "走道(直)":
                    flagColor = Color.Gray;
                    _pathFlag = "column";
                    break;
                case "損壞":
                    flagColor = Color.Yellow;
                    break;
                case "已出售":
                    flagColor = Color.Brown;
                    break;
                case "愛心":
                    flagColor = Color.Pink;
                    break;
                case "查詢":
                    flagColor = Color.Green;
                    break;
            }
        }

        private void changeColor(string flag, int[] target)/*-----row or column------*/
        {
            switch (flag)
            {
                case "block":
                    foreach (Control item in (this.splitContainer1.Panel2.Controls))
                    {
                        Button btn = item as Button;
                        if (btn != null)
                        {
                            int[] arr = btn.Tag as int[];
                            if (arr[0] == target[0])
                            {
                                btn.BackColor = Color.Gray;
                            }

                            if (arr[0] > target[0])
                            {
                                arr[0]--;
                            }
                            btn.Tag = arr;
                        }
                    }
                    return;
                case "row":
                    foreach (Control item in (this.splitContainer1.Panel2.Controls))
                    {
                        Button btn = item as Button;
                        if (btn!=null)
                        {
                            int[] arr = btn.Tag as int[];
                            if (arr[0] == target[0])
                            {
                                btn.BackColor = Color.Gray;
                            }

                            if (arr[0] > target[0])
                            {
                                arr[0]--;
                            }
                            btn.Tag = arr;
                       }
                    }
                    return;
                case "column":
                    foreach (Control item in this.splitContainer1.Panel2.Controls)
                    {

                        Button btn = item as Button;
                        if (btn != null)
                        {
                            int[] arr = btn.Tag as int[];
                            if (arr[1] == target[1])
                            {
                                btn.BackColor = Color.Gray;
                            }

                            if (arr[1] > target[1])
                            {
                                arr[1]--;
                            }
                            btn.Tag = arr;
                        }
                    }
                    return;
                default:
                    MessageBox.Show("錯誤回報");
                    return;
            }
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.splitContainer1.Panel2.Controls)
            {
                if (item.BackColor != Color.Green && item.BackColor != Color.Brown && item.BackColor != Color.Pink) 
                {
                    item.Visible = false;
                }
            }

            BtnSubmit.Enabled = true;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string str = "";
            int count = 0; //計算換行用

            foreach (Control item in this.splitContainer1.Panel2.Controls)
            {
                if(item as Button !=null)
                {
                    if (item.Visible && item.BackColor == Color.Green)
                    {
                        int[] arr = item.Tag as int[];
                        str += $"{arr[0]}:{arr[1]}@";
                    }
                    else if (item.Visible && item.BackColor == Color.Pink)
                    {
                        int[] arr = item.Tag as int[];
                        str += $"{arr[0]}:{arr[1]}love@";
                    }
                    else if (item.Visible && item.BackColor == Color.Brown)
                    {
                        int[] arr = item.Tag as int[];
                        str += $"{arr[0]}:{arr[1]}saled@";
                    }
                    else
                    {
                        str += "NA@";
                    }
                    count++;
                    if (count == Convert.ToInt32(txtColumn.Text))
                    {
                        str += "||@";
                        count = 0;
                    }

                }


            }

            MessageBox.Show(str);

            TxtSeatInfo.Text = str;
        }
    }
}
