
namespace prjMDA.會員
{
    partial class frmMemNew
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPsw = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSign = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPsw);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPsw);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSign);
            this.groupBox1.Location = new System.Drawing.Point(43, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(522, 332);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "註冊";
            // 
            // lblPsw
            // 
            this.lblPsw.AutoSize = true;
            this.lblPsw.Location = new System.Drawing.Point(252, 200);
            this.lblPsw.Name = "lblPsw";
            this.lblPsw.Size = new System.Drawing.Size(54, 20);
            this.lblPsw.TabIndex = 14;
            this.lblPsw.Text = "label6";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(252, 126);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 20);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "label5";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(252, 62);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(54, 20);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.Text = "label4";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(80, 123);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(164, 29);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "電子郵件";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(80, 59);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(164, 29);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "手機";
            // 
            // txtPsw
            // 
            this.txtPsw.Location = new System.Drawing.Point(80, 191);
            this.txtPsw.Margin = new System.Windows.Forms.Padding(5);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(164, 29);
            this.txtPsw.TabIndex = 7;
            this.txtPsw.TextChanged += new System.EventHandler(this.txtPsw_TextChanged);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "密碼";
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(80, 254);
            this.btnSign.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(167, 48);
            this.btnSign.TabIndex = 2;
            this.btnSign.Text = "註冊";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // frmMemNew
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(743, 420);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMemNew";
            this.Text = "frmMemNew";
            this.Load += new System.EventHandler(this.frmMemNew_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPsw;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
    }
}