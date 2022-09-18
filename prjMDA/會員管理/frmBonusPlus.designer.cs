
namespace prjMember
{
    partial class frmBonusPlus
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBonusPlus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "新增紅利:";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnOk.Location = new System.Drawing.Point(331, 180);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(119, 61);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "確定";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(202, 180);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 61);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBonusPlus
            // 
            this.txtBonusPlus.Location = new System.Drawing.Point(202, 79);
            this.txtBonusPlus.Name = "txtBonusPlus";
            this.txtBonusPlus.Size = new System.Drawing.Size(248, 39);
            this.txtBonusPlus.TabIndex = 3;
            this.txtBonusPlus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmBonusPlus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 291);
            this.Controls.Add(this.txtBonusPlus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmBonusPlus";
            this.Text = "frmBonusPlus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtBonusPlus;
    }
}