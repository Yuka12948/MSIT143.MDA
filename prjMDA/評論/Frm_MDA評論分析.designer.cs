
namespace prjMDAComment
{
    partial class Frm_MDA評論分析
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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart評分 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn檢視 = new System.Windows.Forms.Button();
            this.listBoxMovie = new System.Windows.Forms.ListBox();
            this.chart評論數 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView觀影方式 = new System.Windows.Forms.DataGridView();
            this.dataGridView公開 = new System.Windows.Forms.DataGridView();
            this.chart觀影方式 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart公開 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart期待度 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.lab電影評論數 = new System.Windows.Forms.Label();
            this.lab電影評分 = new System.Windows.Forms.Label();
            this.lab電影期待度 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart評分)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart評論數)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView觀影方式)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView公開)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart觀影方式)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart公開)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart期待度)).BeginInit();
            this.SuspendLayout();
            // 
            // chart評分
            // 
            chartArea1.Name = "ChartArea1";
            this.chart評分.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart評分.Legends.Add(legend1);
            this.chart評分.Location = new System.Drawing.Point(254, 369);
            this.chart評分.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.chart評分.Name = "chart評分";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Gold;
            series1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart評分.Series.Add(series1);
            this.chart評分.Size = new System.Drawing.Size(550, 214);
            this.chart評分.TabIndex = 1;
            this.chart評分.Text = "chart1";
            // 
            // btn檢視
            // 
            this.btn檢視.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.btn檢視.FlatAppearance.BorderSize = 0;
            this.btn檢視.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn檢視.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn檢視.ForeColor = System.Drawing.Color.White;
            this.btn檢視.Location = new System.Drawing.Point(11, 810);
            this.btn檢視.Margin = new System.Windows.Forms.Padding(2, 7, 2, 7);
            this.btn檢視.Name = "btn檢視";
            this.btn檢視.Size = new System.Drawing.Size(235, 35);
            this.btn檢視.TabIndex = 51;
            this.btn檢視.Text = "檢視全部";
            this.btn檢視.UseVisualStyleBackColor = false;
            this.btn檢視.Click += new System.EventHandler(this.Frm_MDA評論分析_Load);
            // 
            // listBoxMovie
            // 
            this.listBoxMovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxMovie.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBoxMovie.ForeColor = System.Drawing.Color.DimGray;
            this.listBoxMovie.FormattingEnabled = true;
            this.listBoxMovie.ItemHeight = 20;
            this.listBoxMovie.Location = new System.Drawing.Point(11, 369);
            this.listBoxMovie.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.listBoxMovie.Name = "listBoxMovie";
            this.listBoxMovie.Size = new System.Drawing.Size(235, 440);
            this.listBoxMovie.TabIndex = 52;
            this.listBoxMovie.SelectedIndexChanged += new System.EventHandler(this.listBoxMovie_SelectedIndexChanged);
            // 
            // chart評論數
            // 
            chartArea2.Name = "ChartArea1";
            this.chart評論數.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart評論數.Legends.Add(legend2);
            this.chart評論數.Location = new System.Drawing.Point(820, 369);
            this.chart評論數.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.chart評論數.Name = "chart評論數";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Tomato;
            series2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series3.ChartArea = "ChartArea1";
            series3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "Series2";
            series4.ChartArea = "ChartArea1";
            series4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.Legend = "Legend1";
            series4.Name = "Series3";
            this.chart評論數.Series.Add(series2);
            this.chart評論數.Series.Add(series3);
            this.chart評論數.Series.Add(series4);
            this.chart評論數.Size = new System.Drawing.Size(984, 476);
            this.chart評論數.TabIndex = 54;
            this.chart評論數.Text = "chart4";
            // 
            // dataGridView觀影方式
            // 
            this.dataGridView觀影方式.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView觀影方式.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView觀影方式.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView觀影方式.Location = new System.Drawing.Point(643, 39);
            this.dataGridView觀影方式.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dataGridView觀影方式.Name = "dataGridView觀影方式";
            this.dataGridView觀影方式.RowTemplate.Height = 24;
            this.dataGridView觀影方式.Size = new System.Drawing.Size(377, 263);
            this.dataGridView觀影方式.TabIndex = 55;
            // 
            // dataGridView公開
            // 
            this.dataGridView公開.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView公開.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView公開.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView公開.Location = new System.Drawing.Point(1439, 39);
            this.dataGridView公開.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dataGridView公開.Name = "dataGridView公開";
            this.dataGridView公開.RowTemplate.Height = 24;
            this.dataGridView公開.Size = new System.Drawing.Size(365, 263);
            this.dataGridView公開.TabIndex = 56;
            // 
            // chart觀影方式
            // 
            chartArea3.Name = "ChartArea1";
            this.chart觀影方式.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart觀影方式.Legends.Add(legend3);
            this.chart觀影方式.Location = new System.Drawing.Point(16, 39);
            this.chart觀影方式.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.chart觀影方式.Name = "chart觀影方式";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.CustomProperties = "PieLineColor=64\\, 64\\, 64, PieLabelStyle=Outside";
            series5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.IsValueShownAsLabel = true;
            series5.Label = "#PERCENT";
            series5.Legend = "Legend1";
            series5.LegendText = "#VALX";
            series5.Name = "Series1";
            this.chart觀影方式.Series.Add(series5);
            this.chart觀影方式.Size = new System.Drawing.Size(623, 263);
            this.chart觀影方式.TabIndex = 60;
            this.chart觀影方式.Text = "chart4";
            // 
            // chart公開
            // 
            chartArea4.Name = "ChartArea1";
            this.chart公開.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart公開.Legends.Add(legend4);
            this.chart公開.Location = new System.Drawing.Point(1037, 39);
            this.chart公開.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.chart公開.Name = "chart公開";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series6.IsValueShownAsLabel = true;
            series6.Label = "#PERCENT";
            series6.Legend = "Legend1";
            series6.LegendText = "#VALX";
            series6.Name = "Series1";
            this.chart公開.Series.Add(series6);
            this.chart公開.Size = new System.Drawing.Size(398, 263);
            this.chart公開.TabIndex = 61;
            this.chart公開.Text = "chart4";
            // 
            // chart期待度
            // 
            chartArea5.Name = "ChartArea1";
            this.chart期待度.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart期待度.Legends.Add(legend5);
            this.chart期待度.Location = new System.Drawing.Point(254, 633);
            this.chart期待度.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.chart期待度.Name = "chart期待度";
            series7.ChartArea = "ChartArea1";
            series7.Color = System.Drawing.Color.DeepSkyBlue;
            series7.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart期待度.Series.Add(series7);
            this.chart期待度.Size = new System.Drawing.Size(550, 212);
            this.chart期待度.TabIndex = 62;
            this.chart期待度.Text = "chart4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(11, 341);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.TabIndex = 63;
            this.label1.Text = "電影列表";
            // 
            // lab電影評論數
            // 
            this.lab電影評論數.AutoSize = true;
            this.lab電影評論數.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab電影評論數.ForeColor = System.Drawing.Color.DimGray;
            this.lab電影評論數.Location = new System.Drawing.Point(815, 341);
            this.lab電影評論數.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab電影評論數.Name = "lab電影評論數";
            this.lab電影評論數.Size = new System.Drawing.Size(193, 26);
            this.lab電影評論數.TabIndex = 64;
            this.lab電影評論數.Text = "電影評論數量TOP5";
            // 
            // lab電影評分
            // 
            this.lab電影評分.AutoSize = true;
            this.lab電影評分.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab電影評分.ForeColor = System.Drawing.Color.DimGray;
            this.lab電影評分.Location = new System.Drawing.Point(249, 341);
            this.lab電影評分.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab電影評分.Name = "lab電影評分";
            this.lab電影評分.Size = new System.Drawing.Size(151, 26);
            this.lab電影評分.TabIndex = 65;
            this.lab電影評分.Text = "電影評分TOP5";
            // 
            // lab電影期待度
            // 
            this.lab電影期待度.AutoSize = true;
            this.lab電影期待度.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab電影期待度.ForeColor = System.Drawing.Color.DimGray;
            this.lab電影期待度.Location = new System.Drawing.Point(249, 603);
            this.lab電影期待度.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab電影期待度.Name = "lab電影期待度";
            this.lab電影期待度.Size = new System.Drawing.Size(172, 26);
            this.lab電影期待度.TabIndex = 66;
            this.lab電影期待度.Text = "電影期待度TOP5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(1032, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 26);
            this.label5.TabIndex = 67;
            this.label5.Text = "使用者評論公開設定占比";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(11, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 26);
            this.label6.TabIndex = 68;
            this.label6.Text = "使用者電影觀影方式占比";
            // 
            // Frm_MDA評論分析
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1834, 868);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lab電影期待度);
            this.Controls.Add(this.lab電影評分);
            this.Controls.Add(this.lab電影評論數);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart期待度);
            this.Controls.Add(this.chart公開);
            this.Controls.Add(this.chart觀影方式);
            this.Controls.Add(this.dataGridView公開);
            this.Controls.Add(this.dataGridView觀影方式);
            this.Controls.Add(this.chart評論數);
            this.Controls.Add(this.btn檢視);
            this.Controls.Add(this.chart評分);
            this.Controls.Add(this.listBoxMovie);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Frm_MDA評論分析";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_MDA評論分析";
            this.Load += new System.EventHandler(this.Frm_MDA評論分析_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart評分)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart評論數)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView觀影方式)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView公開)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart觀影方式)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart公開)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart期待度)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart評分;
        private System.Windows.Forms.Button btn檢視;
        private System.Windows.Forms.ListBox listBoxMovie;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart評論數;
        private System.Windows.Forms.DataGridView dataGridView觀影方式;
        private System.Windows.Forms.DataGridView dataGridView公開;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart觀影方式;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart公開;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart期待度;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab電影評論數;
        private System.Windows.Forms.Label lab電影評分;
        private System.Windows.Forms.Label lab電影期待度;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}