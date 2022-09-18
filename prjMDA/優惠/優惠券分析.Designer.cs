
namespace prjMDA
{
    partial class 優惠券分析
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnviewBonus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(445, 40);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "每年使用的優惠券占比";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(539, 326);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(445, 387);
            this.chart2.Name = "chart2";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "單種優惠券被使用占比";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "單種優惠券沒使用占比";
            this.chart2.Series.Add(series5);
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(539, 337);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // btnviewBonus
            // 
            this.btnviewBonus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.btnviewBonus.FlatAppearance.BorderSize = 0;
            this.btnviewBonus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnviewBonus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnviewBonus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnviewBonus.Location = new System.Drawing.Point(33, 40);
            this.btnviewBonus.Name = "btnviewBonus";
            this.btnviewBonus.Size = new System.Drawing.Size(137, 40);
            this.btnviewBonus.TabIndex = 89;
            this.btnviewBonus.Text = "檢視";
            this.btnviewBonus.UseVisualStyleBackColor = false;
            this.btnviewBonus.Click += new System.EventHandler(this.btnviewBonus_Click);
            // 
            // 優惠券分析
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1276, 798);
            this.Controls.Add(this.btnviewBonus);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Name = "優惠券分析";
            this.Text = "優惠券分析";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button btnviewBonus;
    }
}