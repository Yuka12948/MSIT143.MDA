
namespace prjMember
{
    partial class frmMemInfo
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
            this.btnOk = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblBirthD = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.lblNickname = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.cmbPremission = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFormal = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(1021, 625);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(145, 62);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "確定修改";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox9);
            this.panel1.Controls.Add(this.groupBox8);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(54, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 705);
            this.panel1.TabIndex = 33;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblAddress);
            this.groupBox7.Controls.Add(this.txtAddress);
            this.groupBox7.Location = new System.Drawing.Point(23, 577);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(498, 82);
            this.groupBox7.TabIndex = 35;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "地址";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAddress.Location = new System.Drawing.Point(218, 37);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(0, 25);
            this.lblAddress.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(12, 30);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(210, 39);
            this.txtAddress.TabIndex = 2;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblGender);
            this.groupBox9.Controls.Add(this.cmbGender);
            this.groupBox9.Location = new System.Drawing.Point(299, 478);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(222, 82);
            this.groupBox9.TabIndex = 33;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "性別";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGender.Location = new System.Drawing.Point(17, 54);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(0, 23);
            this.lblGender.TabIndex = 1;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(6, 38);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(124, 38);
            this.cmbGender.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblBirthD);
            this.groupBox8.Controls.Add(this.dateTimePicker1);
            this.groupBox8.Location = new System.Drawing.Point(23, 477);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(270, 82);
            this.groupBox8.TabIndex = 32;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "生日";
            // 
            // lblBirthD
            // 
            this.lblBirthD.AutoSize = true;
            this.lblBirthD.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBirthD.Location = new System.Drawing.Point(7, 55);
            this.lblBirthD.Name = "lblBirthD";
            this.lblBirthD.Size = new System.Drawing.Size(0, 25);
            this.lblBirthD.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 39);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtNickname);
            this.groupBox6.Controls.Add(this.lblNickname);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(23, 363);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(498, 108);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "暱稱";
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(10, 32);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(210, 39);
            this.txtNickname.TabIndex = 15;
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNickname.Location = new System.Drawing.Point(226, 37);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(0, 25);
            this.lblNickname.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(7, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "請勿超過50字";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtLastName);
            this.groupBox5.Controls.Add(this.lblName);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtFirstName);
            this.groupBox5.Location = new System.Drawing.Point(23, 252);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(498, 105);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "姓名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "姓";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(11, 58);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(85, 39);
            this.txtLastName.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.Location = new System.Drawing.Point(226, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 25);
            this.lblName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "名";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(101, 58);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(114, 39);
            this.txtFirstName.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.lblEmail);
            this.groupBox3.Location = new System.Drawing.Point(23, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(498, 82);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "電子郵件";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(10, 28);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 39);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEmail.Location = new System.Drawing.Point(236, 42);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 25);
            this.lblEmail.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.lblPhone);
            this.groupBox2.Location = new System.Drawing.Point(23, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 82);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "手機";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(12, 27);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(210, 39);
            this.txtPhone.TabIndex = 2;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPhone.Location = new System.Drawing.Point(226, 34);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(0, 25);
            this.lblPhone.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Location = new System.Drawing.Point(677, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(489, 273);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "頭像";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 48);
            this.button2.TabIndex = 9;
            this.button2.Text = "選擇檔案";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(291, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 30);
            this.label10.TabIndex = 8;
            this.label10.Text = "jpg, jpeg, png";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.cmbPremission);
            this.groupBox10.Location = new System.Drawing.Point(677, 474);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(489, 86);
            this.groupBox10.TabIndex = 35;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "會員權限";
            // 
            // cmbPremission
            // 
            this.cmbPremission.FormattingEnabled = true;
            this.cmbPremission.Location = new System.Drawing.Point(21, 32);
            this.cmbPremission.Name = "cmbPremission";
            this.cmbPremission.Size = new System.Drawing.Size(150, 38);
            this.cmbPremission.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFormal);
            this.groupBox1.Location = new System.Drawing.Point(677, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 81);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "正式會員";
            // 
            // cmbFormal
            // 
            this.cmbFormal.FormattingEnabled = true;
            this.cmbFormal.Location = new System.Drawing.Point(21, 28);
            this.cmbFormal.Name = "cmbFormal";
            this.cmbFormal.Size = new System.Drawing.Size(150, 38);
            this.cmbFormal.TabIndex = 1;
            // 
            // frmMemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1217, 735);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMemInfo";
            this.Text = "frmMemInfo";
            this.Load += new System.EventHandler(this.frmMemInfo_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblBirthD;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ComboBox cmbPremission;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFormal;
    }
}