
namespace 電影院
{
    partial class Frm座位資訊
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm座位資訊));
            this.button1 = new System.Windows.Forms.Button();
            this.座位data = new System.Windows.Forms.DataGridView();
            this.時段bt = new System.Windows.Forms.Button();
            this.座位txt = new System.Windows.Forms.TextBox();
            this.時段lb = new System.Windows.Forms.Label();
            this.場次Box1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.查詢 = new System.Windows.Forms.Button();
            this.查詢txt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.座位顯示 = new System.Windows.Forms.Button();
            this.grpBox座位資訊 = new System.Windows.Forms.GroupBox();
            this.lab座位資訊 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.座位data)).BeginInit();
            this.grpBox座位資訊.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(401, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 35);
            this.button1.TabIndex = 43;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 座位data
            // 
            this.座位data.BackgroundColor = System.Drawing.Color.White;
            this.座位data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.座位data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.座位data.Location = new System.Drawing.Point(662, 67);
            this.座位data.Name = "座位data";
            this.座位data.RowHeadersWidth = 51;
            this.座位data.RowTemplate.Height = 24;
            this.座位data.Size = new System.Drawing.Size(434, 244);
            this.座位data.TabIndex = 42;
            this.座位data.MouseUp += new System.Windows.Forms.MouseEventHandler(this.座位data_MouseUp);
            // 
            // 時段bt
            // 
            this.時段bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.時段bt.FlatAppearance.BorderSize = 0;
            this.時段bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.時段bt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.時段bt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.時段bt.Location = new System.Drawing.Point(278, 276);
            this.時段bt.Name = "時段bt";
            this.時段bt.Size = new System.Drawing.Size(117, 35);
            this.時段bt.TabIndex = 41;
            this.時段bt.Text = "新增";
            this.時段bt.UseVisualStyleBackColor = false;
            this.時段bt.Click += new System.EventHandler(this.時段bt_Click);
            // 
            // 座位txt
            // 
            this.座位txt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.座位txt.ForeColor = System.Drawing.Color.DimGray;
            this.座位txt.Location = new System.Drawing.Point(278, 104);
            this.座位txt.Multiline = true;
            this.座位txt.Name = "座位txt";
            this.座位txt.Size = new System.Drawing.Size(363, 166);
            this.座位txt.TabIndex = 40;
            // 
            // 時段lb
            // 
            this.時段lb.AutoSize = true;
            this.時段lb.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.時段lb.ForeColor = System.Drawing.Color.DimGray;
            this.時段lb.Location = new System.Drawing.Point(166, 104);
            this.時段lb.Name = "時段lb";
            this.時段lb.Size = new System.Drawing.Size(106, 21);
            this.時段lb.TabIndex = 39;
            this.時段lb.Text = "出售座位狀態";
            this.時段lb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 場次Box1
            // 
            this.場次Box1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.場次Box1.ForeColor = System.Drawing.Color.DimGray;
            this.場次Box1.FormattingEnabled = true;
            this.場次Box1.Location = new System.Drawing.Point(278, 67);
            this.場次Box1.Name = "場次Box1";
            this.場次Box1.Size = new System.Drawing.Size(363, 28);
            this.場次Box1.TabIndex = 45;
            this.場次Box1.SelectedValueChanged += new System.EventHandler(this.場次Box1_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(198, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 44;
            this.label5.Text = "電影場次";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 查詢
            // 
            this.查詢.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.查詢.FlatAppearance.BorderSize = 0;
            this.查詢.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.查詢.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.查詢.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.查詢.Location = new System.Drawing.Point(22, 235);
            this.查詢.Name = "查詢";
            this.查詢.Size = new System.Drawing.Size(120, 35);
            this.查詢.TabIndex = 50;
            this.查詢.Text = "查詢";
            this.查詢.UseVisualStyleBackColor = false;
            this.查詢.Click += new System.EventHandler(this.查詢_Click);
            // 
            // 查詢txt
            // 
            this.查詢txt.Font = new System.Drawing.Font("新細明體", 14F);
            this.查詢txt.Location = new System.Drawing.Point(22, 199);
            this.查詢txt.Name = "查詢txt";
            this.查詢txt.Size = new System.Drawing.Size(120, 30);
            this.查詢txt.TabIndex = 49;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(21, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 35);
            this.button2.TabIndex = 51;
            this.button2.Text = "重新整理";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 座位顯示
            // 
            this.座位顯示.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.座位顯示.FlatAppearance.BorderSize = 0;
            this.座位顯示.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.座位顯示.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.座位顯示.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.座位顯示.Location = new System.Drawing.Point(524, 276);
            this.座位顯示.Name = "座位顯示";
            this.座位顯示.Size = new System.Drawing.Size(117, 35);
            this.座位顯示.TabIndex = 62;
            this.座位顯示.Text = "顯示座位";
            this.座位顯示.UseVisualStyleBackColor = false;
            this.座位顯示.Click += new System.EventHandler(this.座位顯示_Click);
            // 
            // grpBox座位資訊
            // 
            this.grpBox座位資訊.Controls.Add(this.lab座位資訊);
            this.grpBox座位資訊.Controls.Add(this.座位顯示);
            this.grpBox座位資訊.Controls.Add(this.查詢txt);
            this.grpBox座位資訊.Controls.Add(this.場次Box1);
            this.grpBox座位資訊.Controls.Add(this.button2);
            this.grpBox座位資訊.Controls.Add(this.label5);
            this.grpBox座位資訊.Controls.Add(this.button1);
            this.grpBox座位資訊.Controls.Add(this.查詢);
            this.grpBox座位資訊.Controls.Add(this.座位data);
            this.grpBox座位資訊.Controls.Add(this.時段lb);
            this.grpBox座位資訊.Controls.Add(this.時段bt);
            this.grpBox座位資訊.Controls.Add(this.座位txt);
            this.grpBox座位資訊.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.grpBox座位資訊.ForeColor = System.Drawing.Color.DimGray;
            this.grpBox座位資訊.Location = new System.Drawing.Point(40, 40);
            this.grpBox座位資訊.Name = "grpBox座位資訊";
            this.grpBox座位資訊.Size = new System.Drawing.Size(1125, 345);
            this.grpBox座位資訊.TabIndex = 64;
            this.grpBox座位資訊.TabStop = false;
            // 
            // lab座位資訊
            // 
            this.lab座位資訊.AutoSize = true;
            this.lab座位資訊.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold);
            this.lab座位資訊.ForeColor = System.Drawing.Color.DimGray;
            this.lab座位資訊.Location = new System.Drawing.Point(15, -5);
            this.lab座位資訊.Name = "lab座位資訊";
            this.lab座位資訊.Size = new System.Drawing.Size(123, 35);
            this.lab座位資訊.TabIndex = 33;
            this.lab座位資訊.Text = "座位資訊";
            // 
            // Frm座位資訊
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1203, 886);
            this.Controls.Add(this.grpBox座位資訊);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm座位資訊";
            this.Text = "座位資訊";
            ((System.ComponentModel.ISupportInitialize)(this.座位data)).EndInit();
            this.grpBox座位資訊.ResumeLayout(false);
            this.grpBox座位資訊.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView 座位data;
        private System.Windows.Forms.Button 時段bt;
        private System.Windows.Forms.TextBox 座位txt;
        private System.Windows.Forms.Label 時段lb;
        private System.Windows.Forms.ComboBox 場次Box1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button 查詢;
        private System.Windows.Forms.TextBox 查詢txt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button 座位顯示;
        private System.Windows.Forms.GroupBox grpBox座位資訊;
        private System.Windows.Forms.Label lab座位資訊;
    }
}