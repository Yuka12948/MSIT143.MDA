
namespace prjMDA
{
    partial class 會員Members
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMembers = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnMovieComment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMembers
            // 
            this.btnMembers.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMembers.Location = new System.Drawing.Point(26, 28);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(116, 47);
            this.btnMembers.TabIndex = 0;
            this.btnMembers.Text = "製作會員";
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCount.Location = new System.Drawing.Point(148, 31);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 39);
            this.txtCount.TabIndex = 1;
            // 
            // btnMovieComment
            // 
            this.btnMovieComment.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMovieComment.Location = new System.Drawing.Point(26, 93);
            this.btnMovieComment.Name = "btnMovieComment";
            this.btnMovieComment.Size = new System.Drawing.Size(116, 45);
            this.btnMovieComment.TabIndex = 2;
            this.btnMovieComment.Text = "製作電影評論";
            this.btnMovieComment.UseVisualStyleBackColor = true;
            this.btnMovieComment.Click += new System.EventHandler(this.btnMovieComment_Click);
            // 
            // 會員Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 495);
            this.Controls.Add(this.btnMovieComment);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.btnMembers);
            this.Name = "會員Members";
            this.Text = "會員Members";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnMovieComment;
    }
}

