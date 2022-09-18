
namespace prjMDAComment.Models
{
    partial class UserControlPics
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlPics));
            this.pBox刪除 = new System.Windows.Forms.PictureBox();
            this.lab圖片編號 = new System.Windows.Forms.Label();
            this.pBox評論圖片 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox刪除)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox評論圖片)).BeginInit();
            this.SuspendLayout();
            // 
            // pBox刪除
            // 
            this.pBox刪除.BackColor = System.Drawing.Color.Transparent;
            this.pBox刪除.Image = ((System.Drawing.Image)(resources.GetObject("pBox刪除.Image")));
            this.pBox刪除.Location = new System.Drawing.Point(138, 139);
            this.pBox刪除.Name = "pBox刪除";
            this.pBox刪除.Size = new System.Drawing.Size(28, 28);
            this.pBox刪除.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox刪除.TabIndex = 8;
            this.pBox刪除.TabStop = false;
            this.pBox刪除.Click += new System.EventHandler(this.pBox刪除_Click);
            // 
            // lab圖片編號
            // 
            this.lab圖片編號.AutoSize = true;
            this.lab圖片編號.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lab圖片編號.Enabled = false;
            this.lab圖片編號.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab圖片編號.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lab圖片編號.Location = new System.Drawing.Point(7, 8);
            this.lab圖片編號.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab圖片編號.Name = "lab圖片編號";
            this.lab圖片編號.Size = new System.Drawing.Size(65, 24);
            this.lab圖片編號.TabIndex = 7;
            this.lab圖片編號.Text = "label1";
            // 
            // pBox評論圖片
            // 
            this.pBox評論圖片.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pBox評論圖片.Enabled = false;
            this.pBox評論圖片.Location = new System.Drawing.Point(6, 7);
            this.pBox評論圖片.Margin = new System.Windows.Forms.Padding(2);
            this.pBox評論圖片.Name = "pBox評論圖片";
            this.pBox評論圖片.Size = new System.Drawing.Size(160, 160);
            this.pBox評論圖片.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox評論圖片.TabIndex = 6;
            this.pBox評論圖片.TabStop = false;
            // 
            // UserControlPics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.pBox刪除);
            this.Controls.Add(this.lab圖片編號);
            this.Controls.Add(this.pBox評論圖片);
            this.Name = "UserControlPics";
            this.Size = new System.Drawing.Size(173, 174);
            ((System.ComponentModel.ISupportInitialize)(this.pBox刪除)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox評論圖片)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox刪除;
        private System.Windows.Forms.Label lab圖片編號;
        private System.Windows.Forms.PictureBox pBox評論圖片;
    }
}
