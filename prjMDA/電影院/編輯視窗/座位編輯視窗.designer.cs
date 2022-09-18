
namespace prjMDA.編輯視窗
{
    partial class Frm座位編輯
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtSeatInfo = new System.Windows.Forms.TextBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.functionBox = new System.Windows.Forms.ComboBox();
            this.txtColumn = new System.Windows.Forms.TextBox();
            this.txtRow = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.BtnSubmit);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.BtnCheck);
            this.splitContainer1.Panel1.Controls.Add(this.BtnCreate);
            this.splitContainer1.Panel1.Controls.Add(this.functionBox);
            this.splitContainer1.Panel1.Controls.Add(this.txtColumn);
            this.splitContainer1.Panel1.Controls.Add(this.txtRow);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.splitContainer1.Size = new System.Drawing.Size(930, 800);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtSeatInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(440, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 260);
            this.panel1.TabIndex = 10;
            // 
            // TxtSeatInfo
            // 
            this.TxtSeatInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSeatInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtSeatInfo.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtSeatInfo.Location = new System.Drawing.Point(0, 0);
            this.TxtSeatInfo.Multiline = true;
            this.TxtSeatInfo.Name = "TxtSeatInfo";
            this.TxtSeatInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtSeatInfo.Size = new System.Drawing.Size(490, 260);
            this.TxtSeatInfo.TabIndex = 0;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.BtnSubmit.FlatAppearance.BorderSize = 0;
            this.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubmit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSubmit.Location = new System.Drawing.Point(170, 163);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(117, 55);
            this.BtnSubmit.TabIndex = 9;
            this.BtnSubmit.Text = "送出座位";
            this.BtnSubmit.UseVisualStyleBackColor = false;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(124, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "排數";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(124, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "欄數";
            // 
            // BtnCheck
            // 
            this.BtnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.BtnCheck.FlatAppearance.BorderSize = 0;
            this.BtnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCheck.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCheck.Location = new System.Drawing.Point(293, 163);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(117, 55);
            this.BtnCheck.TabIndex = 6;
            this.BtnCheck.Text = "檢查座位";
            this.BtnCheck.UseVisualStyleBackColor = false;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.BtnCreate.FlatAppearance.BorderSize = 0;
            this.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCreate.Location = new System.Drawing.Point(47, 163);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(117, 55);
            this.BtnCreate.TabIndex = 5;
            this.BtnCreate.Text = "產生座位";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // functionBox
            // 
            this.functionBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.functionBox.ForeColor = System.Drawing.Color.DimGray;
            this.functionBox.FormattingEnabled = true;
            this.functionBox.Items.AddRange(new object[] {
            "空位",
            "走道(直)",
            "走道(橫)",
            "損壞",
            "已出售",
            "愛心",
            "查詢"});
            this.functionBox.Location = new System.Drawing.Point(202, 47);
            this.functionBox.Name = "functionBox";
            this.functionBox.Size = new System.Drawing.Size(208, 28);
            this.functionBox.TabIndex = 4;
            this.functionBox.Text = "空位";
            this.functionBox.SelectedIndexChanged += new System.EventHandler(this.functionBox_SelectedIndexChanged);
            // 
            // txtColumn
            // 
            this.txtColumn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtColumn.ForeColor = System.Drawing.Color.DimGray;
            this.txtColumn.Location = new System.Drawing.Point(47, 82);
            this.txtColumn.Name = "txtColumn";
            this.txtColumn.Size = new System.Drawing.Size(71, 29);
            this.txtColumn.TabIndex = 1;
            this.txtColumn.Text = "10";
            this.txtColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRow
            // 
            this.txtRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRow.ForeColor = System.Drawing.Color.DimGray;
            this.txtRow.Location = new System.Drawing.Point(47, 47);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(71, 29);
            this.txtRow.TabIndex = 0;
            this.txtRow.Text = "10";
            this.txtRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm座位編輯
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(930, 800);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Frm座位編輯";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "座位編輯";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.ComboBox functionBox;
        private System.Windows.Forms.TextBox txtColumn;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtSeatInfo;
    }
}