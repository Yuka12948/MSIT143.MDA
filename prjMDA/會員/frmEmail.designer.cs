
namespace prjMDA
{
    partial class frmEmail
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
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Enabled = false;
            this.txtContent.Location = new System.Drawing.Point(121, 106);
            this.txtContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(388, 230);
            this.txtContent.TabIndex = 0;
            this.txtContent.Text = "";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(164, 34);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(345, 25);
            this.txtEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(164, 71);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(345, 25);
            this.txtTitle.TabIndex = 5;
            // 
            // frmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 389);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContent);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEmail";
            this.Text = "frmEmail";
            this.Load += new System.EventHandler(this.frmEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
    }
}