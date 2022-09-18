
namespace prjMDA
{
    partial class Frm商品管理
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm商品管理));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLab商品 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLab商品明細 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLab影城 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLab票種 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLab票價資訊 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
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
            this.toolStripLab商品,
            this.toolStripSeparator1,
            this.toolStripLab商品明細,
            this.toolStripSeparator2,
            this.toolStripLab影城,
            this.toolStripSeparator3,
            this.toolStripLab票種,
            this.toolStripSeparator4,
            this.toolStripLab票價資訊,
            this.toolStripSeparator5,
            this.toolStripLab報表});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1064, 45);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLab商品
            // 
            this.toolStripLab商品.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLab商品.Image")));
            this.toolStripLab商品.Name = "toolStripLab商品";
            this.toolStripLab商品.Size = new System.Drawing.Size(77, 42);
            this.toolStripLab商品.Text = "商品";
            this.toolStripLab商品.Click += new System.EventHandler(this.toolStripLab商品_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripLab商品明細
            // 
            this.toolStripLab商品明細.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLab商品明細.Image")));
            this.toolStripLab商品明細.Name = "toolStripLab商品明細";
            this.toolStripLab商品明細.Size = new System.Drawing.Size(109, 42);
            this.toolStripLab商品明細.Text = "商品明細";
            this.toolStripLab商品明細.Click += new System.EventHandler(this.toolStripLab商品明細_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripLab影城
            // 
            this.toolStripLab影城.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLab影城.Image")));
            this.toolStripLab影城.Name = "toolStripLab影城";
            this.toolStripLab影城.Size = new System.Drawing.Size(77, 42);
            this.toolStripLab影城.Text = "影城";
            this.toolStripLab影城.Click += new System.EventHandler(this.toolStripLab商品影城_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripLab票種
            // 
            this.toolStripLab票種.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLab票種.Image")));
            this.toolStripLab票種.Name = "toolStripLab票種";
            this.toolStripLab票種.Size = new System.Drawing.Size(77, 42);
            this.toolStripLab票種.Text = "票種";
            this.toolStripLab票種.Click += new System.EventHandler(this.toolStripLab商品票種_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripLab票價資訊
            // 
            this.toolStripLab票價資訊.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLab票價資訊.Image")));
            this.toolStripLab票價資訊.Name = "toolStripLab票價資訊";
            this.toolStripLab票價資訊.Size = new System.Drawing.Size(109, 42);
            this.toolStripLab票價資訊.Text = "票價資訊";
            this.toolStripLab票價資訊.Click += new System.EventHandler(this.toolStripLab票價資訊_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripLab報表
            // 
            this.toolStripLab報表.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLab報表.Image")));
            this.toolStripLab報表.Name = "toolStripLab報表";
            this.toolStripLab報表.Size = new System.Drawing.Size(77, 42);
            this.toolStripLab報表.Text = "報表";
            this.toolStripLab報表.Click += new System.EventHandler(this.toolStripLab報表_Click);
            // 
            // Frm商品管理
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm商品管理";
            this.Text = "商品管理";
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLab商品明細;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLab報表;
        private System.Windows.Forms.ToolStripLabel toolStripLab票種;
        private System.Windows.Forms.ToolStripLabel toolStripLab票價資訊;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLab商品;
        private System.Windows.Forms.ToolStripLabel toolStripLab影城;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

