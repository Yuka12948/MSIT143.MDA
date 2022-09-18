
namespace prjMDA.會員
{
    partial class frmMemChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtAge = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtComp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbCopose = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbYearMonth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chtCreTime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chtAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtCreTime)).BeginInit();
            this.SuspendLayout();
            // 
            // chtAge
            // 
            chartArea1.Name = "ChartArea1";
            this.chtAge.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtAge.Legends.Add(legend1);
            this.chtAge.Location = new System.Drawing.Point(61, 433);
            this.chtAge.Name = "chtAge";
            this.chtAge.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtAge.Series.Add(series1);
            this.chtAge.Size = new System.Drawing.Size(761, 324);
            this.chtAge.TabIndex = 17;
            this.chtAge.Text = "chart4";
            // 
            // chtComp
            // 
            chartArea2.Name = "ChartArea1";
            this.chtComp.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtComp.Legends.Add(legend2);
            this.chtComp.Location = new System.Drawing.Point(856, 89);
            this.chtComp.Name = "chtComp";
            this.chtComp.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtComp.Series.Add(series2);
            this.chtComp.Size = new System.Drawing.Size(592, 324);
            this.chtComp.TabIndex = 16;
            this.chtComp.Text = "chart2";
            // 
            // cmbCopose
            // 
            this.cmbCopose.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbCopose.ForeColor = System.Drawing.Color.DimGray;
            this.cmbCopose.FormattingEnabled = true;
            this.cmbCopose.Location = new System.Drawing.Point(1017, 47);
            this.cmbCopose.Name = "cmbCopose";
            this.cmbCopose.Size = new System.Drawing.Size(183, 28);
            this.cmbCopose.TabIndex = 15;
            this.cmbCopose.SelectedIndexChanged += new System.EventHandler(this.cmbCopose_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(852, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "會員組成分布圖";
            // 
            // cmbYearMonth
            // 
            this.cmbYearMonth.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbYearMonth.ForeColor = System.Drawing.Color.DimGray;
            this.cmbYearMonth.FormattingEnabled = true;
            this.cmbYearMonth.Location = new System.Drawing.Point(264, 47);
            this.cmbYearMonth.Name = "cmbYearMonth";
            this.cmbYearMonth.Size = new System.Drawing.Size(183, 28);
            this.cmbYearMonth.TabIndex = 13;
            this.cmbYearMonth.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(57, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "會員每月加入趨勢圖";
            // 
            // chtCreTime
            // 
            chartArea3.Name = "ChartArea1";
            this.chtCreTime.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chtCreTime.Legends.Add(legend3);
            this.chtCreTime.Location = new System.Drawing.Point(61, 89);
            this.chtCreTime.Name = "chtCreTime";
            this.chtCreTime.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chtCreTime.Series.Add(series3);
            this.chtCreTime.Size = new System.Drawing.Size(761, 324);
            this.chtCreTime.TabIndex = 11;
            this.chtCreTime.Text = "chart1";
            // 
            // frmMemChart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.chtAge);
            this.Controls.Add(this.chtComp);
            this.Controls.Add(this.cmbCopose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbYearMonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chtCreTime);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMemChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMemChart";
            this.Load += new System.EventHandler(this.frmMemReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtCreTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtAge;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtComp;
        private System.Windows.Forms.ComboBox cmbCopose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbYearMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtCreTime;
    }
}