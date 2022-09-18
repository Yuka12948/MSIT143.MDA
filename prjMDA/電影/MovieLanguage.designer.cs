
namespace prjMDA
{
    partial class MovieLanguage
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
            this.btnLanguageAdd = new System.Windows.Forms.Button();
            this.btnLanguageUpDate = new System.Windows.Forms.Button();
            this.dataGridViewMovieLanguage = new System.Windows.Forms.DataGridView();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.lab語言名稱 = new System.Windows.Forms.Label();
            this.btnviewLanguage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lab語言編號 = new System.Windows.Forms.Label();
            this.grpBox電影語言 = new System.Windows.Forms.GroupBox();
            this.lab電影語言 = new System.Windows.Forms.Label();
            this.labStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieLanguage)).BeginInit();
            this.grpBox電影語言.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLanguageAdd
            // 
            this.btnLanguageAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.btnLanguageAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanguageAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnLanguageAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLanguageAdd.Location = new System.Drawing.Point(152, 164);
            this.btnLanguageAdd.Name = "btnLanguageAdd";
            this.btnLanguageAdd.Size = new System.Drawing.Size(117, 40);
            this.btnLanguageAdd.TabIndex = 28;
            this.btnLanguageAdd.Text = "新增";
            this.btnLanguageAdd.UseVisualStyleBackColor = false;
            this.btnLanguageAdd.Click += new System.EventHandler(this.btnLanguageAdd_Click);
            // 
            // btnLanguageUpDate
            // 
            this.btnLanguageUpDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.btnLanguageUpDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanguageUpDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnLanguageUpDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLanguageUpDate.Location = new System.Drawing.Point(275, 164);
            this.btnLanguageUpDate.Name = "btnLanguageUpDate";
            this.btnLanguageUpDate.Size = new System.Drawing.Size(117, 40);
            this.btnLanguageUpDate.TabIndex = 29;
            this.btnLanguageUpDate.Text = "修改";
            this.btnLanguageUpDate.UseVisualStyleBackColor = false;
            this.btnLanguageUpDate.Click += new System.EventHandler(this.btnLanguageUpDate_Click);
            // 
            // dataGridViewMovieLanguage
            // 
            this.dataGridViewMovieLanguage.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMovieLanguage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMovieLanguage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovieLanguage.Location = new System.Drawing.Point(29, 219);
            this.dataGridViewMovieLanguage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridViewMovieLanguage.Name = "dataGridViewMovieLanguage";
            this.dataGridViewMovieLanguage.RowHeadersWidth = 51;
            this.dataGridViewMovieLanguage.RowTemplate.Height = 27;
            this.dataGridViewMovieLanguage.Size = new System.Drawing.Size(363, 437);
            this.dataGridViewMovieLanguage.TabIndex = 30;
            this.dataGridViewMovieLanguage.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMovieLanguage_CellMouseUp);
            // 
            // txtLanguage
            // 
            this.txtLanguage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLanguage.ForeColor = System.Drawing.Color.DimGray;
            this.txtLanguage.Location = new System.Drawing.Point(105, 91);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(182, 29);
            this.txtLanguage.TabIndex = 51;
            // 
            // lab語言名稱
            // 
            this.lab語言名稱.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab語言名稱.AutoSize = true;
            this.lab語言名稱.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab語言名稱.ForeColor = System.Drawing.Color.DimGray;
            this.lab語言名稱.Location = new System.Drawing.Point(25, 94);
            this.lab語言名稱.Name = "lab語言名稱";
            this.lab語言名稱.Size = new System.Drawing.Size(74, 21);
            this.lab語言名稱.TabIndex = 53;
            this.lab語言名稱.Text = "語言名稱";
            // 
            // btnviewLanguage
            // 
            this.btnviewLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.btnviewLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnviewLanguage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnviewLanguage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnviewLanguage.Location = new System.Drawing.Point(29, 164);
            this.btnviewLanguage.Name = "btnviewLanguage";
            this.btnviewLanguage.Size = new System.Drawing.Size(117, 40);
            this.btnviewLanguage.TabIndex = 56;
            this.btnviewLanguage.Text = "檢視";
            this.btnviewLanguage.UseVisualStyleBackColor = false;
            this.btnviewLanguage.Click += new System.EventHandler(this.btnviewLanguage_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(105, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 29);
            this.textBox1.TabIndex = 59;
            // 
            // lab語言編號
            // 
            this.lab語言編號.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab語言編號.AutoSize = true;
            this.lab語言編號.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab語言編號.ForeColor = System.Drawing.Color.DimGray;
            this.lab語言編號.Location = new System.Drawing.Point(25, 60);
            this.lab語言編號.Name = "lab語言編號";
            this.lab語言編號.Size = new System.Drawing.Size(74, 21);
            this.lab語言編號.TabIndex = 60;
            this.lab語言編號.Text = "語言編號";
            // 
            // grpBox電影語言
            // 
            this.grpBox電影語言.Controls.Add(this.lab電影語言);
            this.grpBox電影語言.Controls.Add(this.labStatus);
            this.grpBox電影語言.Controls.Add(this.btnviewLanguage);
            this.grpBox電影語言.Controls.Add(this.textBox1);
            this.grpBox電影語言.Controls.Add(this.dataGridViewMovieLanguage);
            this.grpBox電影語言.Controls.Add(this.btnLanguageAdd);
            this.grpBox電影語言.Controls.Add(this.lab語言編號);
            this.grpBox電影語言.Controls.Add(this.btnLanguageUpDate);
            this.grpBox電影語言.Controls.Add(this.lab語言名稱);
            this.grpBox電影語言.Controls.Add(this.txtLanguage);
            this.grpBox電影語言.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpBox電影語言.ForeColor = System.Drawing.Color.DimGray;
            this.grpBox電影語言.Location = new System.Drawing.Point(40, 40);
            this.grpBox電影語言.Name = "grpBox電影語言";
            this.grpBox電影語言.Size = new System.Drawing.Size(418, 684);
            this.grpBox電影語言.TabIndex = 61;
            this.grpBox電影語言.TabStop = false;
            // 
            // lab電影語言
            // 
            this.lab電影語言.AutoSize = true;
            this.lab電影語言.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold);
            this.lab電影語言.ForeColor = System.Drawing.Color.DimGray;
            this.lab電影語言.Location = new System.Drawing.Point(15, -5);
            this.lab電影語言.Name = "lab電影語言";
            this.lab電影語言.Size = new System.Drawing.Size(123, 35);
            this.lab電影語言.TabIndex = 62;
            this.lab電影語言.Text = "電影語言";
            // 
            // labStatus
            // 
            this.labStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(79)))), ((int)(((byte)(55)))));
            this.labStatus.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStatus.ForeColor = System.Drawing.Color.Gold;
            this.labStatus.Location = new System.Drawing.Point(336, 57);
            this.labStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(56, 33);
            this.labStatus.TabIndex = 77;
            this.labStatus.Text = "狀態";
            this.labStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MovieLanguage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(497, 750);
            this.Controls.Add(this.grpBox電影語言);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MovieLanguage";
            this.Text = "Language";
            this.Click += new System.EventHandler(this.MovieLanguage_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieLanguage)).EndInit();
            this.grpBox電影語言.ResumeLayout(false);
            this.grpBox電影語言.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLanguageAdd;
        private System.Windows.Forms.Button btnLanguageUpDate;
        private System.Windows.Forms.DataGridView dataGridViewMovieLanguage;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Label lab語言名稱;
        private System.Windows.Forms.Button btnviewLanguage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lab語言編號;
        private System.Windows.Forms.GroupBox grpBox電影語言;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.Label lab電影語言;
    }
}