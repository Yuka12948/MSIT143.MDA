
namespace prjMDA
{
    partial class Frm電影場次
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
            this.放映日期txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.電影院box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.新增 = new System.Windows.Forms.Button();
            this.修改 = new System.Windows.Forms.Button();
            this.電影代碼Box2 = new System.Windows.Forms.ComboBox();
            this.放映開始box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.查詢 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.查詢box = new System.Windows.Forms.ComboBox();
            this.查詢txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.地區Box = new System.Windows.Forms.TextBox();
            this.影城Box = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.影廳Box = new System.Windows.Forms.ComboBox();
            this.grpBox電影場次 = new System.Windows.Forms.GroupBox();
            this.lab電影場次 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpBox電影場次.SuspendLayout();
            this.SuspendLayout();
            // 
            // 放映日期txt
            // 
            this.放映日期txt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.放映日期txt.ForeColor = System.Drawing.Color.DimGray;
            this.放映日期txt.Location = new System.Drawing.Point(144, 203);
            this.放映日期txt.Name = "放映日期txt";
            this.放映日期txt.Size = new System.Drawing.Size(297, 29);
            this.放映日期txt.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(64, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "放映日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(64, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "電影代碼";
            // 
            // 電影院box
            // 
            this.電影院box.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.電影院box.ForeColor = System.Drawing.Color.DimGray;
            this.電影院box.FormattingEnabled = true;
            this.電影院box.Location = new System.Drawing.Point(144, 101);
            this.電影院box.Name = "電影院box";
            this.電影院box.Size = new System.Drawing.Size(297, 28);
            this.電影院box.TabIndex = 32;
            this.電影院box.SelectedValueChanged += new System.EventHandler(this.電影院box_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(48, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "電影院名稱";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 330);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(610, 362);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // 新增
            // 
            this.新增.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.新增.FlatAppearance.BorderSize = 0;
            this.新增.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.新增.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.新增.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.新增.Location = new System.Drawing.Point(144, 273);
            this.新增.Name = "新增";
            this.新增.Size = new System.Drawing.Size(145, 35);
            this.新增.TabIndex = 39;
            this.新增.Text = "新增";
            this.新增.UseVisualStyleBackColor = false;
            this.新增.Click += new System.EventHandler(this.新增_Click);
            // 
            // 修改
            // 
            this.修改.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.修改.FlatAppearance.BorderSize = 0;
            this.修改.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.修改.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.修改.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.修改.Location = new System.Drawing.Point(296, 273);
            this.修改.Name = "修改";
            this.修改.Size = new System.Drawing.Size(145, 35);
            this.修改.TabIndex = 40;
            this.修改.Text = "修改";
            this.修改.UseVisualStyleBackColor = false;
            this.修改.Click += new System.EventHandler(this.修改_Click);
            // 
            // 電影代碼Box2
            // 
            this.電影代碼Box2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.電影代碼Box2.ForeColor = System.Drawing.Color.DimGray;
            this.電影代碼Box2.FormattingEnabled = true;
            this.電影代碼Box2.Location = new System.Drawing.Point(144, 169);
            this.電影代碼Box2.Name = "電影代碼Box2";
            this.電影代碼Box2.Size = new System.Drawing.Size(297, 28);
            this.電影代碼Box2.TabIndex = 41;
            // 
            // 放映開始box
            // 
            this.放映開始box.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.放映開始box.ForeColor = System.Drawing.Color.DimGray;
            this.放映開始box.Location = new System.Drawing.Point(144, 238);
            this.放映開始box.Name = "放映開始box";
            this.放映開始box.Size = new System.Drawing.Size(297, 29);
            this.放映開始box.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(32, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 44;
            this.label4.Text = "放映開始日期";
            // 
            // 查詢
            // 
            this.查詢.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.查詢.FlatAppearance.BorderSize = 0;
            this.查詢.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.查詢.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.查詢.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.查詢.Location = new System.Drawing.Point(511, 232);
            this.查詢.Name = "查詢";
            this.查詢.Size = new System.Drawing.Size(135, 35);
            this.查詢.TabIndex = 48;
            this.查詢.Text = "查詢";
            this.查詢.UseVisualStyleBackColor = false;
            this.查詢.Click += new System.EventHandler(this.查詢_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(511, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 35);
            this.button1.TabIndex = 49;
            this.button1.Text = "重新整理";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 查詢box
            // 
            this.查詢box.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.查詢box.ForeColor = System.Drawing.Color.DimGray;
            this.查詢box.FormattingEnabled = true;
            this.查詢box.Location = new System.Drawing.Point(511, 163);
            this.查詢box.Name = "查詢box";
            this.查詢box.Size = new System.Drawing.Size(135, 28);
            this.查詢box.TabIndex = 50;
            this.查詢box.SelectedValueChanged += new System.EventHandler(this.查詢box_SelectedValueChanged);
            // 
            // 查詢txt
            // 
            this.查詢txt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.查詢txt.ForeColor = System.Drawing.Color.DimGray;
            this.查詢txt.Location = new System.Drawing.Point(511, 197);
            this.查詢txt.Name = "查詢txt";
            this.查詢txt.Size = new System.Drawing.Size(135, 29);
            this.查詢txt.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(243, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 52;
            this.label5.Text = "影城";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(96, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 21);
            this.label6.TabIndex = 53;
            this.label6.Text = "地區";
            // 
            // 地區Box
            // 
            this.地區Box.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.地區Box.ForeColor = System.Drawing.Color.DimGray;
            this.地區Box.Location = new System.Drawing.Point(144, 66);
            this.地區Box.Name = "地區Box";
            this.地區Box.Size = new System.Drawing.Size(93, 29);
            this.地區Box.TabIndex = 54;
            this.地區Box.TextChanged += new System.EventHandler(this.地區Box_TextChanged);
            // 
            // 影城Box
            // 
            this.影城Box.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.影城Box.ForeColor = System.Drawing.Color.DimGray;
            this.影城Box.FormattingEnabled = true;
            this.影城Box.Location = new System.Drawing.Point(291, 66);
            this.影城Box.Name = "影城Box";
            this.影城Box.Size = new System.Drawing.Size(150, 28);
            this.影城Box.TabIndex = 55;
            this.影城Box.SelectedValueChanged += new System.EventHandler(this.影城Box_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(64, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 56;
            this.label7.Text = "影廳名稱";
            // 
            // 影廳Box
            // 
            this.影廳Box.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.影廳Box.ForeColor = System.Drawing.Color.DimGray;
            this.影廳Box.FormattingEnabled = true;
            this.影廳Box.Location = new System.Drawing.Point(144, 135);
            this.影廳Box.Name = "影廳Box";
            this.影廳Box.Size = new System.Drawing.Size(297, 28);
            this.影廳Box.TabIndex = 57;
            // 
            // grpBox電影場次
            // 
            this.grpBox電影場次.Controls.Add(this.lab電影場次);
            this.grpBox電影場次.Controls.Add(this.影廳Box);
            this.grpBox電影場次.Controls.Add(this.dataGridView1);
            this.grpBox電影場次.Controls.Add(this.label7);
            this.grpBox電影場次.Controls.Add(this.新增);
            this.grpBox電影場次.Controls.Add(this.影城Box);
            this.grpBox電影場次.Controls.Add(this.修改);
            this.grpBox電影場次.Controls.Add(this.地區Box);
            this.grpBox電影場次.Controls.Add(this.查詢);
            this.grpBox電影場次.Controls.Add(this.label6);
            this.grpBox電影場次.Controls.Add(this.label5);
            this.grpBox電影場次.Controls.Add(this.button1);
            this.grpBox電影場次.Controls.Add(this.放映開始box);
            this.grpBox電影場次.Controls.Add(this.查詢box);
            this.grpBox電影場次.Controls.Add(this.label4);
            this.grpBox電影場次.Controls.Add(this.查詢txt);
            this.grpBox電影場次.Controls.Add(this.電影代碼Box2);
            this.grpBox電影場次.Controls.Add(this.label1);
            this.grpBox電影場次.Controls.Add(this.放映日期txt);
            this.grpBox電影場次.Controls.Add(this.電影院box);
            this.grpBox電影場次.Controls.Add(this.label3);
            this.grpBox電影場次.Controls.Add(this.label2);
            this.grpBox電影場次.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.grpBox電影場次.ForeColor = System.Drawing.Color.DimGray;
            this.grpBox電影場次.Location = new System.Drawing.Point(40, 40);
            this.grpBox電影場次.Name = "grpBox電影場次";
            this.grpBox電影場次.Size = new System.Drawing.Size(686, 729);
            this.grpBox電影場次.TabIndex = 63;
            this.grpBox電影場次.TabStop = false;
            // 
            // lab電影場次
            // 
            this.lab電影場次.AutoSize = true;
            this.lab電影場次.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold);
            this.lab電影場次.ForeColor = System.Drawing.Color.DimGray;
            this.lab電影場次.Location = new System.Drawing.Point(15, -5);
            this.lab電影場次.Name = "lab電影場次";
            this.lab電影場次.Size = new System.Drawing.Size(123, 35);
            this.lab電影場次.TabIndex = 33;
            this.lab電影場次.Text = "電影場次";
            // 
            // Frm電影場次
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 801);
            this.Controls.Add(this.grpBox電影場次);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm電影場次";
            this.Text = "場次";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpBox電影場次.ResumeLayout(false);
            this.grpBox電影場次.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox 放映日期txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox 電影院box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button 新增;
        private System.Windows.Forms.Button 修改;
        private System.Windows.Forms.ComboBox 電影代碼Box2;
        private System.Windows.Forms.TextBox 放映開始box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button 查詢;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox 查詢box;
        private System.Windows.Forms.TextBox 查詢txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox 地區Box;
        private System.Windows.Forms.ComboBox 影城Box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox 影廳Box;
        private System.Windows.Forms.GroupBox grpBox電影場次;
        private System.Windows.Forms.Label lab電影場次;
    }
}