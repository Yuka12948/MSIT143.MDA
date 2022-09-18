
namespace prjMDA
{
    partial class MovieImages
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
            this.ptbshow = new System.Windows.Forms.PictureBox();
            this.btnADDMOVIE = new System.Windows.Forms.Button();
            this.btnMovieUpDate = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewMovieImage = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.labStatus = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtkeyword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBox電影圖庫 = new System.Windows.Forms.GroupBox();
            this.lab電影圖庫 = new System.Windows.Forms.Label();
            this.lab電影圖庫總圖 = new System.Windows.Forms.Label();
            this.lab電影圖庫總表 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbshow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieImage)).BeginInit();
            this.grpBox電影圖庫.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbshow
            // 
            this.ptbshow.BackColor = System.Drawing.Color.White;
            this.ptbshow.Location = new System.Drawing.Point(193, 95);
            this.ptbshow.Name = "ptbshow";
            this.ptbshow.Size = new System.Drawing.Size(277, 634);
            this.ptbshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbshow.TabIndex = 2;
            this.ptbshow.TabStop = false;
            this.ptbshow.Click += new System.EventHandler(this.pictureshow_Click);
            // 
            // btnADDMOVIE
            // 
            this.btnADDMOVIE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.btnADDMOVIE.FlatAppearance.BorderSize = 0;
            this.btnADDMOVIE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADDMOVIE.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnADDMOVIE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnADDMOVIE.Location = new System.Drawing.Point(29, 166);
            this.btnADDMOVIE.Name = "btnADDMOVIE";
            this.btnADDMOVIE.Size = new System.Drawing.Size(135, 40);
            this.btnADDMOVIE.TabIndex = 27;
            this.btnADDMOVIE.Text = "新增";
            this.btnADDMOVIE.UseVisualStyleBackColor = false;
            this.btnADDMOVIE.Click += new System.EventHandler(this.btnAddImage);
            // 
            // btnMovieUpDate
            // 
            this.btnMovieUpDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.btnMovieUpDate.FlatAppearance.BorderSize = 0;
            this.btnMovieUpDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovieUpDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnMovieUpDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMovieUpDate.Location = new System.Drawing.Point(29, 212);
            this.btnMovieUpDate.Name = "btnMovieUpDate";
            this.btnMovieUpDate.Size = new System.Drawing.Size(135, 40);
            this.btnMovieUpDate.TabIndex = 28;
            this.btnMovieUpDate.Text = "修改";
            this.btnMovieUpDate.UseVisualStyleBackColor = false;
            this.btnMovieUpDate.Click += new System.EventHandler(this.btnUpdateImage);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridViewMovieImage
            // 
            this.dataGridViewMovieImage.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMovieImage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMovieImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovieImage.Location = new System.Drawing.Point(484, 95);
            this.dataGridViewMovieImage.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMovieImage.Name = "dataGridViewMovieImage";
            this.dataGridViewMovieImage.RowHeadersWidth = 51;
            this.dataGridViewMovieImage.RowTemplate.Height = 27;
            this.dataGridViewMovieImage.Size = new System.Drawing.Size(349, 634);
            this.dataGridViewMovieImage.TabIndex = 29;
            this.dataGridViewMovieImage.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMovieImage_CellMouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(29, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 40);
            this.button1.TabIndex = 31;
            this.button1.Text = "檢視圖片庫";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnShowImageData);
            // 
            // labStatus
            // 
            this.labStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(79)))), ((int)(((byte)(55)))));
            this.labStatus.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStatus.ForeColor = System.Drawing.Color.Gold;
            this.labStatus.Location = new System.Drawing.Point(1289, 39);
            this.labStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(56, 33);
            this.labStatus.TabIndex = 32;
            this.labStatus.Text = "狀態";
            this.labStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(846, 95);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(511, 634);
            this.flowLayoutPanel1.TabIndex = 33;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnsearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsearch.Location = new System.Drawing.Point(29, 352);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(135, 40);
            this.btnsearch.TabIndex = 73;
            this.btnsearch.Text = "搜尋";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtkeyword
            // 
            this.txtkeyword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtkeyword.ForeColor = System.Drawing.Color.DimGray;
            this.txtkeyword.Location = new System.Drawing.Point(29, 317);
            this.txtkeyword.Name = "txtkeyword";
            this.txtkeyword.Size = new System.Drawing.Size(135, 29);
            this.txtkeyword.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(188, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 26);
            this.label1.TabIndex = 37;
            this.label1.Text = "圖片編號:";
            // 
            // grpBox電影圖庫
            // 
            this.grpBox電影圖庫.Controls.Add(this.lab電影圖庫);
            this.grpBox電影圖庫.Controls.Add(this.lab電影圖庫總圖);
            this.grpBox電影圖庫.Controls.Add(this.lab電影圖庫總表);
            this.grpBox電影圖庫.Controls.Add(this.button1);
            this.grpBox電影圖庫.Controls.Add(this.dataGridViewMovieImage);
            this.grpBox電影圖庫.Controls.Add(this.label1);
            this.grpBox電影圖庫.Controls.Add(this.flowLayoutPanel1);
            this.grpBox電影圖庫.Controls.Add(this.btnsearch);
            this.grpBox電影圖庫.Controls.Add(this.ptbshow);
            this.grpBox電影圖庫.Controls.Add(this.btnMovieUpDate);
            this.grpBox電影圖庫.Controls.Add(this.btnADDMOVIE);
            this.grpBox電影圖庫.Controls.Add(this.labStatus);
            this.grpBox電影圖庫.Controls.Add(this.txtkeyword);
            this.grpBox電影圖庫.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpBox電影圖庫.ForeColor = System.Drawing.Color.DimGray;
            this.grpBox電影圖庫.Location = new System.Drawing.Point(40, 40);
            this.grpBox電影圖庫.Name = "grpBox電影圖庫";
            this.grpBox電影圖庫.Size = new System.Drawing.Size(1376, 759);
            this.grpBox電影圖庫.TabIndex = 74;
            this.grpBox電影圖庫.TabStop = false;
            // 
            // lab電影圖庫
            // 
            this.lab電影圖庫.AutoSize = true;
            this.lab電影圖庫.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold);
            this.lab電影圖庫.ForeColor = System.Drawing.Color.DimGray;
            this.lab電影圖庫.Location = new System.Drawing.Point(15, -5);
            this.lab電影圖庫.Name = "lab電影圖庫";
            this.lab電影圖庫.Size = new System.Drawing.Size(123, 35);
            this.lab電影圖庫.TabIndex = 86;
            this.lab電影圖庫.Text = "電影圖庫";
            // 
            // lab電影圖庫總圖
            // 
            this.lab電影圖庫總圖.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab電影圖庫總圖.AutoSize = true;
            this.lab電影圖庫總圖.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab電影圖庫總圖.ForeColor = System.Drawing.Color.DimGray;
            this.lab電影圖庫總圖.Location = new System.Drawing.Point(841, 63);
            this.lab電影圖庫總圖.Name = "lab電影圖庫總圖";
            this.lab電影圖庫總圖.Size = new System.Drawing.Size(138, 26);
            this.lab電影圖庫總圖.TabIndex = 85;
            this.lab電影圖庫總圖.Text = "電影圖庫總圖";
            // 
            // lab電影圖庫總表
            // 
            this.lab電影圖庫總表.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab電影圖庫總表.AutoSize = true;
            this.lab電影圖庫總表.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab電影圖庫總表.ForeColor = System.Drawing.Color.DimGray;
            this.lab電影圖庫總表.Location = new System.Drawing.Point(479, 63);
            this.lab電影圖庫總表.Name = "lab電影圖庫總表";
            this.lab電影圖庫總表.Size = new System.Drawing.Size(138, 26);
            this.lab電影圖庫總表.TabIndex = 84;
            this.lab電影圖庫總表.Text = "電影圖庫總表";
            // 
            // MovieImages
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1452, 834);
            this.Controls.Add(this.grpBox電影圖庫);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MovieImages";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.MovieImages_Click);
            ((System.ComponentModel.ISupportInitialize)(this.ptbshow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieImage)).EndInit();
            this.grpBox電影圖庫.ResumeLayout(false);
            this.grpBox電影圖庫.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbshow;
        private System.Windows.Forms.Button btnADDMOVIE;
        private System.Windows.Forms.Button btnMovieUpDate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridViewMovieImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtkeyword;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBox電影圖庫;
        private System.Windows.Forms.Label lab電影圖庫總表;
        private System.Windows.Forms.Label lab電影圖庫總圖;
        private System.Windows.Forms.Label lab電影圖庫;
    }
}

