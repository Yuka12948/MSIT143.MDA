
namespace prjMDA
{
    partial class 影廳
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.座位txt = new System.Windows.Forms.TextBox();
            this.影廳nmtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.影廳照片 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.廳種txt = new System.Windows.Forms.TextBox();
            this.查詢 = new System.Windows.Forms.Button();
            this.查詢txt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.影城box = new System.Windows.Forms.ComboBox();
            this.影廳電影box = new System.Windows.Forms.ComboBox();
            this.地區box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.座位規劃 = new System.Windows.Forms.Button();
            this.座位顯示 = new System.Windows.Forms.Button();
            this.grpBox影廳 = new System.Windows.Forms.GroupBox();
            this.lab影廳 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.影廳照片)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpBox影廳.SuspendLayout();
            this.SuspendLayout();
            // 
            // 座位txt
            // 
            this.座位txt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.座位txt.ForeColor = System.Drawing.Color.DimGray;
            this.座位txt.Location = new System.Drawing.Point(766, 79);
            this.座位txt.Multiline = true;
            this.座位txt.Name = "座位txt";
            this.座位txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.座位txt.Size = new System.Drawing.Size(361, 520);
            this.座位txt.TabIndex = 15;
            // 
            // 影廳nmtxt
            // 
            this.影廳nmtxt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.影廳nmtxt.ForeColor = System.Drawing.Color.DimGray;
            this.影廳nmtxt.Location = new System.Drawing.Point(268, 150);
            this.影廳nmtxt.Name = "影廳nmtxt";
            this.影廳nmtxt.Size = new System.Drawing.Size(264, 29);
            this.影廳nmtxt.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(534, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "影廳照片";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(762, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "座位資訊";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(188, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "影廳名稱";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(268, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 31);
            this.button1.TabIndex = 20;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.新增);
            // 
            // 影廳照片
            // 
            this.影廳照片.BackColor = System.Drawing.Color.AliceBlue;
            this.影廳照片.Location = new System.Drawing.Point(538, 80);
            this.影廳照片.Name = "影廳照片";
            this.影廳照片.Size = new System.Drawing.Size(197, 171);
            this.影廳照片.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.影廳照片.TabIndex = 21;
            this.影廳照片.TabStop = false;
            this.影廳照片.Click += new System.EventHandler(this.pictureBox1_Click);
            this.影廳照片.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(714, 332);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(172, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "電影院名稱";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(403, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 31);
            this.button2.TabIndex = 25;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.修改);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(188, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "廳種名稱";
            // 
            // 廳種txt
            // 
            this.廳種txt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.廳種txt.ForeColor = System.Drawing.Color.DimGray;
            this.廳種txt.Location = new System.Drawing.Point(268, 185);
            this.廳種txt.Name = "廳種txt";
            this.廳種txt.Size = new System.Drawing.Size(264, 29);
            this.廳種txt.TabIndex = 27;
            // 
            // 查詢
            // 
            this.查詢.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.查詢.FlatAppearance.BorderSize = 0;
            this.查詢.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.查詢.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.查詢.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.查詢.Location = new System.Drawing.Point(21, 183);
            this.查詢.Name = "查詢";
            this.查詢.Size = new System.Drawing.Size(129, 31);
            this.查詢.TabIndex = 50;
            this.查詢.Text = "查詢";
            this.查詢.UseVisualStyleBackColor = false;
            this.查詢.Click += new System.EventHandler(this.查詢_Click);
            // 
            // 查詢txt
            // 
            this.查詢txt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.查詢txt.ForeColor = System.Drawing.Color.DimGray;
            this.查詢txt.Location = new System.Drawing.Point(21, 147);
            this.查詢txt.Name = "查詢txt";
            this.查詢txt.Size = new System.Drawing.Size(129, 29);
            this.查詢txt.TabIndex = 49;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(21, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 31);
            this.button3.TabIndex = 51;
            this.button3.Text = "重新整理";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // 影城box
            // 
            this.影城box.AllowDrop = true;
            this.影城box.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.影城box.ForeColor = System.Drawing.Color.DimGray;
            this.影城box.FormattingEnabled = true;
            this.影城box.Location = new System.Drawing.Point(406, 80);
            this.影城box.Name = "影城box";
            this.影城box.Size = new System.Drawing.Size(126, 28);
            this.影城box.TabIndex = 53;
            this.影城box.SelectedValueChanged += new System.EventHandler(this.影城box_SelectedValueChanged);
            // 
            // 影廳電影box
            // 
            this.影廳電影box.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.影廳電影box.ForeColor = System.Drawing.Color.DimGray;
            this.影廳電影box.FormattingEnabled = true;
            this.影廳電影box.Location = new System.Drawing.Point(268, 115);
            this.影廳電影box.Name = "影廳電影box";
            this.影廳電影box.Size = new System.Drawing.Size(264, 28);
            this.影廳電影box.TabIndex = 54;
            // 
            // 地區box
            // 
            this.地區box.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.地區box.ForeColor = System.Drawing.Color.DimGray;
            this.地區box.Location = new System.Drawing.Point(268, 80);
            this.地區box.Name = "地區box";
            this.地區box.Size = new System.Drawing.Size(84, 29);
            this.地區box.TabIndex = 55;
            this.地區box.TextChanged += new System.EventHandler(this.地區box_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(220, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 21);
            this.label6.TabIndex = 58;
            this.label6.Text = "地區";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(358, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 21);
            this.label7.TabIndex = 59;
            this.label7.Text = "影城";
            // 
            // 座位規劃
            // 
            this.座位規劃.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.座位規劃.FlatAppearance.BorderSize = 0;
            this.座位規劃.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.座位規劃.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.座位規劃.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.座位規劃.Location = new System.Drawing.Point(901, 43);
            this.座位規劃.Name = "座位規劃";
            this.座位規劃.Size = new System.Drawing.Size(110, 30);
            this.座位規劃.TabIndex = 60;
            this.座位規劃.Text = "座位規劃";
            this.座位規劃.UseVisualStyleBackColor = false;
            this.座位規劃.Click += new System.EventHandler(this.座位規劃_Click);
            // 
            // 座位顯示
            // 
            this.座位顯示.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.座位顯示.FlatAppearance.BorderSize = 0;
            this.座位顯示.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.座位顯示.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.座位顯示.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.座位顯示.Location = new System.Drawing.Point(1017, 43);
            this.座位顯示.Name = "座位顯示";
            this.座位顯示.Size = new System.Drawing.Size(110, 30);
            this.座位顯示.TabIndex = 61;
            this.座位顯示.Text = "顯示座位";
            this.座位顯示.UseVisualStyleBackColor = false;
            this.座位顯示.Click += new System.EventHandler(this.座位顯示_Click);
            // 
            // grpBox影廳
            // 
            this.grpBox影廳.Controls.Add(this.lab影廳);
            this.grpBox影廳.Controls.Add(this.查詢txt);
            this.grpBox影廳.Controls.Add(this.button3);
            this.grpBox影廳.Controls.Add(this.label7);
            this.grpBox影廳.Controls.Add(this.查詢);
            this.grpBox影廳.Controls.Add(this.座位顯示);
            this.grpBox影廳.Controls.Add(this.label6);
            this.grpBox影廳.Controls.Add(this.影廳照片);
            this.grpBox影廳.Controls.Add(this.地區box);
            this.grpBox影廳.Controls.Add(this.座位規劃);
            this.grpBox影廳.Controls.Add(this.影廳電影box);
            this.grpBox影廳.Controls.Add(this.label5);
            this.grpBox影廳.Controls.Add(this.影城box);
            this.grpBox影廳.Controls.Add(this.dataGridView1);
            this.grpBox影廳.Controls.Add(this.廳種txt);
            this.grpBox影廳.Controls.Add(this.button1);
            this.grpBox影廳.Controls.Add(this.label3);
            this.grpBox影廳.Controls.Add(this.button2);
            this.grpBox影廳.Controls.Add(this.label2);
            this.grpBox影廳.Controls.Add(this.影廳nmtxt);
            this.grpBox影廳.Controls.Add(this.label1);
            this.grpBox影廳.Controls.Add(this.label4);
            this.grpBox影廳.Controls.Add(this.座位txt);
            this.grpBox影廳.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.grpBox影廳.ForeColor = System.Drawing.Color.DimGray;
            this.grpBox影廳.Location = new System.Drawing.Point(40, 40);
            this.grpBox影廳.Name = "grpBox影廳";
            this.grpBox影廳.Size = new System.Drawing.Size(1156, 622);
            this.grpBox影廳.TabIndex = 62;
            this.grpBox影廳.TabStop = false;
            // 
            // lab影廳
            // 
            this.lab影廳.AutoSize = true;
            this.lab影廳.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold);
            this.lab影廳.ForeColor = System.Drawing.Color.DimGray;
            this.lab影廳.Location = new System.Drawing.Point(15, -5);
            this.lab影廳.Name = "lab影廳";
            this.lab影廳.Size = new System.Drawing.Size(69, 35);
            this.lab影廳.TabIndex = 33;
            this.lab影廳.Text = "影廳";
            // 
            // 影廳
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1223, 696);
            this.Controls.Add(this.grpBox影廳);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "影廳";
            this.Text = "影廳";
            ((System.ComponentModel.ISupportInitialize)(this.影廳照片)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpBox影廳.ResumeLayout(false);
            this.grpBox影廳.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox 座位txt;
        private System.Windows.Forms.TextBox 影廳nmtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox 影廳照片;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox 廳種txt;
        private System.Windows.Forms.Button 查詢;
        private System.Windows.Forms.TextBox 查詢txt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox 影城box;
        private System.Windows.Forms.ComboBox 影廳電影box;
        private System.Windows.Forms.TextBox 地區box;
        protected internal System.Windows.Forms.Label label6;
        protected internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button 座位規劃;
        private System.Windows.Forms.Button 座位顯示;
        private System.Windows.Forms.GroupBox grpBox影廳;
        private System.Windows.Forms.Label lab影廳;
    }
}