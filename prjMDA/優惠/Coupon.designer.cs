
namespace prjMDA
{
    partial class Frm優惠券總表
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
            this.dataGridViewCoupon = new System.Windows.Forms.DataGridView();
            this.grpBox優惠總表 = new System.Windows.Forms.GroupBox();
            this.labStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCouponCode = new System.Windows.Forms.TextBox();
            this.lab優惠代碼 = new System.Windows.Forms.Label();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.lab優惠所需紅利 = new System.Windows.Forms.Label();
            this.lab優惠截止日期 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lab優惠折扣 = new System.Windows.Forms.Label();
            this.txtBonusName = new System.Windows.Forms.TextBox();
            this.lab優惠名稱 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnLanguageAdd = new System.Windows.Forms.Button();
            this.btnLanguageUpDate = new System.Windows.Forms.Button();
            this.btnviewBonus = new System.Windows.Forms.Button();
            this.lab優惠總表 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoupon)).BeginInit();
            this.grpBox優惠總表.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCoupon
            // 
            this.dataGridViewCoupon.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCoupon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCoupon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoupon.Location = new System.Drawing.Point(181, 243);
            this.dataGridViewCoupon.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCoupon.Name = "dataGridViewCoupon";
            this.dataGridViewCoupon.RowHeadersWidth = 51;
            this.dataGridViewCoupon.RowTemplate.Height = 27;
            this.dataGridViewCoupon.Size = new System.Drawing.Size(672, 373);
            this.dataGridViewCoupon.TabIndex = 63;
            this.dataGridViewCoupon.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCoupon_CellMouseUp);
            // 
            // grpBox優惠總表
            // 
            this.grpBox優惠總表.Controls.Add(this.labStatus);
            this.grpBox優惠總表.Controls.Add(this.label8);
            this.grpBox優惠總表.Controls.Add(this.label7);
            this.grpBox優惠總表.Controls.Add(this.label9);
            this.grpBox優惠總表.Controls.Add(this.dateTimePicker1);
            this.grpBox優惠總表.Controls.Add(this.txtCouponCode);
            this.grpBox優惠總表.Controls.Add(this.lab優惠代碼);
            this.grpBox優惠總表.Controls.Add(this.txtPoint);
            this.grpBox優惠總表.Controls.Add(this.lab優惠所需紅利);
            this.grpBox優惠總表.Controls.Add(this.lab優惠截止日期);
            this.grpBox優惠總表.Controls.Add(this.txtDiscount);
            this.grpBox優惠總表.Controls.Add(this.lab優惠折扣);
            this.grpBox優惠總表.Controls.Add(this.txtBonusName);
            this.grpBox優惠總表.Controls.Add(this.lab優惠名稱);
            this.grpBox優惠總表.Controls.Add(this.button1);
            this.grpBox優惠總表.Controls.Add(this.comboBox1);
            this.grpBox優惠總表.Controls.Add(this.txtsearch);
            this.grpBox優惠總表.Controls.Add(this.btnsearch);
            this.grpBox優惠總表.Controls.Add(this.dataGridViewCoupon);
            this.grpBox優惠總表.Controls.Add(this.btnLanguageAdd);
            this.grpBox優惠總表.Controls.Add(this.btnLanguageUpDate);
            this.grpBox優惠總表.Controls.Add(this.btnviewBonus);
            this.grpBox優惠總表.Controls.Add(this.lab優惠總表);
            this.grpBox優惠總表.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.grpBox優惠總表.ForeColor = System.Drawing.Color.DimGray;
            this.grpBox優惠總表.Location = new System.Drawing.Point(40, 40);
            this.grpBox優惠總表.Name = "grpBox優惠總表";
            this.grpBox優惠總表.Size = new System.Drawing.Size(891, 642);
            this.grpBox優惠總表.TabIndex = 73;
            this.grpBox優惠總表.TabStop = false;
            // 
            // labStatus
            // 
            this.labStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(79)))), ((int)(((byte)(55)))));
            this.labStatus.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStatus.ForeColor = System.Drawing.Color.Gold;
            this.labStatus.Location = new System.Drawing.Point(797, 56);
            this.labStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(56, 33);
            this.labStatus.TabIndex = 112;
            this.labStatus.Text = "狀態";
            this.labStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(21, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 25);
            this.label8.TabIndex = 111;
            this.label8.Text = "優惠截止日期";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(21, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 25);
            this.label7.TabIndex = 110;
            this.label7.Text = "請輸入關鍵字";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(79)))), ((int)(((byte)(55)))));
            this.label9.Location = new System.Drawing.Point(444, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 18);
            this.label9.TabIndex = 109;
            this.label9.Text = "最多至2076/06/06";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker1.Location = new System.Drawing.Point(288, 160);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 29);
            this.dateTimePicker1.TabIndex = 108;
            // 
            // txtCouponCode
            // 
            this.txtCouponCode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCouponCode.ForeColor = System.Drawing.Color.DimGray;
            this.txtCouponCode.Location = new System.Drawing.Point(288, 126);
            this.txtCouponCode.Name = "txtCouponCode";
            this.txtCouponCode.Size = new System.Drawing.Size(151, 29);
            this.txtCouponCode.TabIndex = 106;
            // 
            // lab優惠代碼
            // 
            this.lab優惠代碼.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab優惠代碼.AutoSize = true;
            this.lab優惠代碼.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab優惠代碼.Location = new System.Drawing.Point(208, 129);
            this.lab優惠代碼.Name = "lab優惠代碼";
            this.lab優惠代碼.Size = new System.Drawing.Size(74, 21);
            this.lab優惠代碼.TabIndex = 107;
            this.lab優惠代碼.Text = "優惠代碼";
            // 
            // txtPoint
            // 
            this.txtPoint.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPoint.ForeColor = System.Drawing.Color.DimGray;
            this.txtPoint.Location = new System.Drawing.Point(288, 192);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(151, 29);
            this.txtPoint.TabIndex = 103;
            // 
            // lab優惠所需紅利
            // 
            this.lab優惠所需紅利.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab優惠所需紅利.AutoSize = true;
            this.lab優惠所需紅利.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab優惠所需紅利.Location = new System.Drawing.Point(177, 195);
            this.lab優惠所需紅利.Name = "lab優惠所需紅利";
            this.lab優惠所需紅利.Size = new System.Drawing.Size(106, 21);
            this.lab優惠所需紅利.TabIndex = 104;
            this.lab優惠所需紅利.Text = "優惠所需紅利";
            // 
            // lab優惠截止日期
            // 
            this.lab優惠截止日期.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab優惠截止日期.AutoSize = true;
            this.lab優惠截止日期.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab優惠截止日期.Location = new System.Drawing.Point(177, 164);
            this.lab優惠截止日期.Name = "lab優惠截止日期";
            this.lab優惠截止日期.Size = new System.Drawing.Size(106, 21);
            this.lab優惠截止日期.TabIndex = 102;
            this.lab優惠截止日期.Text = "優惠截止日期";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDiscount.ForeColor = System.Drawing.Color.DimGray;
            this.txtDiscount.Location = new System.Drawing.Point(288, 91);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(151, 29);
            this.txtDiscount.TabIndex = 100;
            // 
            // lab優惠折扣
            // 
            this.lab優惠折扣.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab優惠折扣.AutoSize = true;
            this.lab優惠折扣.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab優惠折扣.Location = new System.Drawing.Point(208, 94);
            this.lab優惠折扣.Name = "lab優惠折扣";
            this.lab優惠折扣.Size = new System.Drawing.Size(74, 21);
            this.lab優惠折扣.TabIndex = 101;
            this.lab優惠折扣.Text = "優惠折扣";
            // 
            // txtBonusName
            // 
            this.txtBonusName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBonusName.ForeColor = System.Drawing.Color.DimGray;
            this.txtBonusName.Location = new System.Drawing.Point(288, 56);
            this.txtBonusName.Name = "txtBonusName";
            this.txtBonusName.Size = new System.Drawing.Size(151, 29);
            this.txtBonusName.TabIndex = 98;
            // 
            // lab優惠名稱
            // 
            this.lab優惠名稱.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab優惠名稱.AutoSize = true;
            this.lab優惠名稱.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab優惠名稱.Location = new System.Drawing.Point(208, 59);
            this.lab優惠名稱.Name = "lab優惠名稱";
            this.lab優惠名稱.Size = new System.Drawing.Size(74, 21);
            this.lab優惠名稱.TabIndex = 99;
            this.lab優惠名稱.Text = "優惠名稱";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(21, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 40);
            this.button1.TabIndex = 97;
            this.button1.Text = "搜尋";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(21, 412);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 28);
            this.comboBox1.TabIndex = 96;
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtsearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtsearch.Location = new System.Drawing.Point(22, 271);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(129, 29);
            this.txtsearch.TabIndex = 94;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnsearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsearch.Location = new System.Drawing.Point(21, 306);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(130, 40);
            this.btnsearch.TabIndex = 92;
            this.btnsearch.Text = "搜尋";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnLanguageAdd
            // 
            this.btnLanguageAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.btnLanguageAdd.FlatAppearance.BorderSize = 0;
            this.btnLanguageAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanguageAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLanguageAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLanguageAdd.Location = new System.Drawing.Point(21, 124);
            this.btnLanguageAdd.Name = "btnLanguageAdd";
            this.btnLanguageAdd.Size = new System.Drawing.Size(130, 40);
            this.btnLanguageAdd.TabIndex = 90;
            this.btnLanguageAdd.Text = "新增";
            this.btnLanguageAdd.UseVisualStyleBackColor = false;
            this.btnLanguageAdd.Click += new System.EventHandler(this.btnLanguageAdd_Click);
            // 
            // btnLanguageUpDate
            // 
            this.btnLanguageUpDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.btnLanguageUpDate.FlatAppearance.BorderSize = 0;
            this.btnLanguageUpDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanguageUpDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLanguageUpDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLanguageUpDate.Location = new System.Drawing.Point(21, 170);
            this.btnLanguageUpDate.Name = "btnLanguageUpDate";
            this.btnLanguageUpDate.Size = new System.Drawing.Size(130, 40);
            this.btnLanguageUpDate.TabIndex = 91;
            this.btnLanguageUpDate.Text = "修改";
            this.btnLanguageUpDate.UseVisualStyleBackColor = false;
            this.btnLanguageUpDate.Click += new System.EventHandler(this.btnLanguageUpDate_Click);
            // 
            // btnviewBonus
            // 
            this.btnviewBonus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.btnviewBonus.FlatAppearance.BorderSize = 0;
            this.btnviewBonus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnviewBonus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnviewBonus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnviewBonus.Location = new System.Drawing.Point(21, 56);
            this.btnviewBonus.Name = "btnviewBonus";
            this.btnviewBonus.Size = new System.Drawing.Size(130, 40);
            this.btnviewBonus.TabIndex = 89;
            this.btnviewBonus.Text = "檢視";
            this.btnviewBonus.UseVisualStyleBackColor = false;
            this.btnviewBonus.Click += new System.EventHandler(this.btnviewBonus_Click);
            // 
            // lab優惠總表
            // 
            this.lab優惠總表.AutoSize = true;
            this.lab優惠總表.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold);
            this.lab優惠總表.ForeColor = System.Drawing.Color.DimGray;
            this.lab優惠總表.Location = new System.Drawing.Point(15, -5);
            this.lab優惠總表.Name = "lab優惠總表";
            this.lab優惠總表.Size = new System.Drawing.Size(123, 35);
            this.lab優惠總表.TabIndex = 33;
            this.lab優惠總表.Text = "優惠總表";
            // 
            // Frm優惠券總表
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(962, 713);
            this.Controls.Add(this.grpBox優惠總表);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm優惠券總表";
            this.Text = "Bonus";
            this.Click += new System.EventHandler(this.Coupon_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoupon)).EndInit();
            this.grpBox優惠總表.ResumeLayout(false);
            this.grpBox優惠總表.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewCoupon;
        private System.Windows.Forms.GroupBox grpBox優惠總表;
        private System.Windows.Forms.Label lab優惠總表;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtCouponCode;
        private System.Windows.Forms.Label lab優惠代碼;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.Label lab優惠所需紅利;
        private System.Windows.Forms.Label lab優惠截止日期;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lab優惠折扣;
        private System.Windows.Forms.TextBox txtBonusName;
        private System.Windows.Forms.Label lab優惠名稱;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnLanguageAdd;
        private System.Windows.Forms.Button btnLanguageUpDate;
        private System.Windows.Forms.Button btnviewBonus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labStatus;
    }
}