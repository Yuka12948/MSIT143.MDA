
namespace prjMember
{
    partial class frmMemSign
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.btnSignIn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(48, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(282, 289);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登入";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(127, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "忘記密碼";
            this.label3.Click += new System.EventHandler(this.lblForget);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(56, 142);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(164, 39);
            this.txtPassword.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "密碼";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(56, 75);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(164, 39);
            this.txtPhone.TabIndex = 3;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(56, 216);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(164, 48);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "登入";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "手機";
            // 
            // frmMemSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 361);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMemSign";
            this.Text = "frmMemSign";
            this.Load += new System.EventHandler(this.frmMemSign_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}