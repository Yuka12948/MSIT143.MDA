
namespace prjMDA.會員
{
    partial class Frm會員登入
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
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.btnSignIn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(65, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(450, 250);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登入/註冊";
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblPhone.ForeColor = System.Drawing.Color.DimGray;
            this.lblPhone.Location = new System.Drawing.Point(150, 116);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(150, 20);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPhone.ForeColor = System.Drawing.Color.DimGray;
            this.txtPhone.Location = new System.Drawing.Point(150, 82);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(150, 29);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSignIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSignIn.Location = new System.Drawing.Point(150, 175);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(150, 48);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "登入 / 註冊";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(146, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "手機";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm會員登入
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm會員登入";
            this.Text = "frmMemStart";
            this.Load += new System.EventHandler(this.frmMemStart_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPhone;
    }
}