
namespace prjMDA
{
    partial class Frm影城
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm影城));
            this.影城nametxt = new System.Windows.Forms.TextBox();
            this.影城名字 = new System.Windows.Forms.Label();
            this.修改 = new System.Windows.Forms.Button();
            this.新增 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.查詢 = new System.Windows.Forms.Button();
            this.查詢txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lab影城 = new System.Windows.Forms.Label();
            this.grpBox影城 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpBox影城.SuspendLayout();
            this.SuspendLayout();
            // 
            // 影城nametxt
            // 
            this.影城nametxt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.影城nametxt.ForeColor = System.Drawing.Color.DimGray;
            this.影城nametxt.Location = new System.Drawing.Point(300, 57);
            this.影城nametxt.Name = "影城nametxt";
            this.影城nametxt.Size = new System.Drawing.Size(231, 29);
            this.影城nametxt.TabIndex = 37;
            // 
            // 影城名字
            // 
            this.影城名字.AutoSize = true;
            this.影城名字.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.影城名字.ForeColor = System.Drawing.Color.DimGray;
            this.影城名字.Location = new System.Drawing.Point(221, 60);
            this.影城名字.Name = "影城名字";
            this.影城名字.Size = new System.Drawing.Size(73, 20);
            this.影城名字.TabIndex = 36;
            this.影城名字.Text = "影城名稱";
            this.影城名字.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 修改
            // 
            this.修改.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.修改.FlatAppearance.BorderSize = 0;
            this.修改.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.修改.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.修改.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.修改.Location = new System.Drawing.Point(382, 92);
            this.修改.Name = "修改";
            this.修改.Size = new System.Drawing.Size(149, 35);
            this.修改.TabIndex = 42;
            this.修改.Text = "修改";
            this.修改.UseVisualStyleBackColor = false;
            this.修改.Click += new System.EventHandler(this.修改_Click);
            // 
            // 新增
            // 
            this.新增.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.新增.FlatAppearance.BorderSize = 0;
            this.新增.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.新增.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.新增.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.新增.Location = new System.Drawing.Point(225, 92);
            this.新增.Name = "新增";
            this.新增.Size = new System.Drawing.Size(149, 35);
            this.新增.TabIndex = 41;
            this.新增.Text = "新增";
            this.新增.UseVisualStyleBackColor = false;
            this.新增.Click += new System.EventHandler(this.新增_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(225, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(306, 397);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // 查詢
            // 
            this.查詢.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.查詢.FlatAppearance.BorderSize = 0;
            this.查詢.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.查詢.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.查詢.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.查詢.Location = new System.Drawing.Point(31, 95);
            this.查詢.Name = "查詢";
            this.查詢.Size = new System.Drawing.Size(130, 40);
            this.查詢.TabIndex = 50;
            this.查詢.Text = "查詢";
            this.查詢.UseVisualStyleBackColor = false;
            this.查詢.Click += new System.EventHandler(this.查詢_Click);
            // 
            // 查詢txt
            // 
            this.查詢txt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.查詢txt.ForeColor = System.Drawing.Color.DimGray;
            this.查詢txt.Location = new System.Drawing.Point(31, 60);
            this.查詢txt.Name = "查詢txt";
            this.查詢txt.Size = new System.Drawing.Size(130, 29);
            this.查詢txt.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(31, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 40);
            this.button1.TabIndex = 51;
            this.button1.Text = "重新整理";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lab影城
            // 
            this.lab影城.AutoSize = true;
            this.lab影城.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold);
            this.lab影城.ForeColor = System.Drawing.Color.DimGray;
            this.lab影城.Location = new System.Drawing.Point(15, -5);
            this.lab影城.Name = "lab影城";
            this.lab影城.Size = new System.Drawing.Size(69, 35);
            this.lab影城.TabIndex = 33;
            this.lab影城.Text = "影城";
            // 
            // grpBox影城
            // 
            this.grpBox影城.Controls.Add(this.lab影城);
            this.grpBox影城.Controls.Add(this.dataGridView1);
            this.grpBox影城.Controls.Add(this.button1);
            this.grpBox影城.Controls.Add(this.影城nametxt);
            this.grpBox影城.Controls.Add(this.新增);
            this.grpBox影城.Controls.Add(this.影城名字);
            this.grpBox影城.Controls.Add(this.查詢);
            this.grpBox影城.Controls.Add(this.修改);
            this.grpBox影城.Controls.Add(this.查詢txt);
            this.grpBox影城.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.grpBox影城.ForeColor = System.Drawing.Color.DimGray;
            this.grpBox影城.Location = new System.Drawing.Point(40, 40);
            this.grpBox影城.Name = "grpBox影城";
            this.grpBox影城.Size = new System.Drawing.Size(566, 563);
            this.grpBox影城.TabIndex = 52;
            this.grpBox影城.TabStop = false;
            // 
            // Frm影城
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(648, 632);
            this.Controls.Add(this.grpBox影城);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm影城";
            this.Text = "影城";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpBox影城.ResumeLayout(false);
            this.grpBox影城.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox 影城nametxt;
        private System.Windows.Forms.Label 影城名字;
        private System.Windows.Forms.Button 修改;
        private System.Windows.Forms.Button 新增;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button 查詢;
        private System.Windows.Forms.TextBox 查詢txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lab影城;
        private System.Windows.Forms.GroupBox grpBox影城;
    }
}