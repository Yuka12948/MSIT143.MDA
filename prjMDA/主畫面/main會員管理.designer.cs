
namespace prjMDA
{
    partial class Frm會員管理
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm會員管理));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLab報表 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer1.Size = new System.Drawing.Size(1498, 944);
            this.splitContainer1.SplitterDistance = 45;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel7,
            this.toolStripSeparator7,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripLabel5,
            this.toolStripSeparator3,
            this.toolStripLabel3,
            this.toolStripSeparator1,
            this.toolStripLab報表});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1498, 45);
            this.toolStrip1.TabIndex = 1;
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel7.Image")));
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(109, 42);
            this.toolStripLabel7.Text = "會員管理";
            this.toolStripLabel7.Click += new System.EventHandler(this.toolStripLab會員管理_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(109, 42);
            this.toolStripLabel1.Text = "會員增刪";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLab會員增刪_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel5.Image")));
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(109, 42);
            this.toolStripLabel5.Text = "檢舉管理";
            this.toolStripLabel5.Click += new System.EventHandler(this.toolStripLab檢舉管理_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel3.Image")));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(109, 42);
            this.toolStripLabel3.Text = "片單管理";
            this.toolStripLabel3.Click += new System.EventHandler(this.toolStripLab片單管理_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripLab報表
            // 
            this.toolStripLab報表.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLab報表.Image")));
            this.toolStripLab報表.Name = "toolStripLab報表";
            this.toolStripLab報表.Size = new System.Drawing.Size(77, 42);
            this.toolStripLab報表.Text = "報表";
            this.toolStripLab報表.Click += new System.EventHandler(this.toolStripLab報表_Click);
            // 
            // Frm會員管理
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1498, 944);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm會員管理";
            this.Text = "會員管理";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLab報表;
    }
}

