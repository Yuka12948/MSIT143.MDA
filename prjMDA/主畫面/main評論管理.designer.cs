
namespace prjMDA
{
    partial class Frm評論管理
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm評論管理));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLab評論管理 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLab檢舉管理 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLab評論分析 = new System.Windows.Forms.ToolStripLabel();
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
            this.splitContainer1.IsSplitterFixed = true;
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
            this.splitContainer1.Size = new System.Drawing.Size(1064, 681);
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
            this.toolStripLab評論管理,
            this.toolStripSeparator7,
            this.toolStripLab檢舉管理,
            this.toolStripSeparator1,
            this.toolStripLab評論分析,
            this.toolStripSeparator6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1064, 45);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLab評論管理
            // 
            this.toolStripLab評論管理.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLab評論管理.Image")));
            this.toolStripLab評論管理.Name = "toolStripLab評論管理";
            this.toolStripLab評論管理.Size = new System.Drawing.Size(109, 42);
            this.toolStripLab評論管理.Text = "評論管理";
            this.toolStripLab評論管理.Click += new System.EventHandler(this.toolStripLab評論管理_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripLab檢舉管理
            // 
            this.toolStripLab檢舉管理.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLab檢舉管理.Image")));
            this.toolStripLab檢舉管理.Name = "toolStripLab檢舉管理";
            this.toolStripLab檢舉管理.Size = new System.Drawing.Size(109, 42);
            this.toolStripLab檢舉管理.Text = "檢舉管理";
            this.toolStripLab檢舉管理.Click += new System.EventHandler(this.toolStripLab檢舉管理_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripLab評論分析
            // 
            this.toolStripLab評論分析.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLab評論分析.Image")));
            this.toolStripLab評論分析.Name = "toolStripLab評論分析";
            this.toolStripLab評論分析.Size = new System.Drawing.Size(109, 42);
            this.toolStripLab評論分析.Text = "評論分析";
            this.toolStripLab評論分析.Click += new System.EventHandler(this.toolStripLab評論分析_Click);
            // 
            // Frm評論管理
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm評論管理";
            this.Text = "評論管理";
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
        private System.Windows.Forms.ToolStripLabel toolStripLab評論管理;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStripLab檢舉管理;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLab評論分析;
    }
}

