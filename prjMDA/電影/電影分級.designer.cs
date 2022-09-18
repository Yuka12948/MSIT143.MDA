
namespace prjMDA.電影
{
    partial class 電影分級
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView分級 = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse分級 = new System.Windows.Forms.Button();
            this.btnShow分級 = new System.Windows.Forms.Button();
            this.txt分級說明 = new System.Windows.Forms.TextBox();
            this.txt分級級數 = new System.Windows.Forms.TextBox();
            this.txt分級編號 = new System.Windows.Forms.TextBox();
            this.lab分級編號 = new System.Windows.Forms.Label();
            this.lab分級級數 = new System.Windows.Forms.Label();
            this.lab分級說明 = new System.Windows.Forms.Label();
            this.btnInsert分級 = new System.Windows.Forms.Button();
            this.btnUpdate分級 = new System.Windows.Forms.Button();
            this.picBoxUpDate分級 = new System.Windows.Forms.PictureBox();
            this.picBoxUpDate國家 = new System.Windows.Forms.PictureBox();
            this.btnUpdate國家 = new System.Windows.Forms.Button();
            this.btnInsert國家 = new System.Windows.Forms.Button();
            this.lab國家名稱 = new System.Windows.Forms.Label();
            this.lab國家編號 = new System.Windows.Forms.Label();
            this.txt國家名稱 = new System.Windows.Forms.TextBox();
            this.txt國家編號 = new System.Windows.Forms.TextBox();
            this.btnBrowse國家 = new System.Windows.Forms.Button();
            this.btnShow國家 = new System.Windows.Forms.Button();
            this.dataGridView國家 = new System.Windows.Forms.DataGridView();
            this.grpBox電影分級 = new System.Windows.Forms.GroupBox();
            this.lab電影分級 = new System.Windows.Forms.Label();
            this.grpBox電影產地 = new System.Windows.Forms.GroupBox();
            this.lab電影產地 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView分級)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUpDate分級)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUpDate國家)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView國家)).BeginInit();
            this.grpBox電影分級.SuspendLayout();
            this.grpBox電影產地.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView分級
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 10F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView分級.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView分級.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView分級.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView分級.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView分級.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView分級.Location = new System.Drawing.Point(38, 237);
            this.dataGridView分級.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView分級.Name = "dataGridView分級";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView分級.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView分級.RowHeadersWidth = 51;
            this.dataGridView分級.RowTemplate.Height = 24;
            this.dataGridView分級.Size = new System.Drawing.Size(545, 334);
            this.dataGridView分級.TabIndex = 2;
            this.dataGridView分級.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView分級_CellMouseUp);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnBrowse分級
            // 
            this.btnBrowse分級.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.btnBrowse分級.FlatAppearance.BorderSize = 0;
            this.btnBrowse分級.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse分級.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBrowse分級.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBrowse分級.Location = new System.Drawing.Point(456, 183);
            this.btnBrowse分級.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowse分級.Name = "btnBrowse分級";
            this.btnBrowse分級.Size = new System.Drawing.Size(127, 37);
            this.btnBrowse分級.TabIndex = 7;
            this.btnBrowse分級.Text = "上傳圖片";
            this.btnBrowse分級.UseVisualStyleBackColor = false;
            this.btnBrowse分級.Click += new System.EventHandler(this.btn_Browse分級_Click);
            // 
            // btnShow分級
            // 
            this.btnShow分級.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.btnShow分級.FlatAppearance.BorderSize = 0;
            this.btnShow分級.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow分級.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShow分級.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShow分級.Location = new System.Drawing.Point(39, 183);
            this.btnShow分級.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShow分級.Name = "btnShow分級";
            this.btnShow分級.Size = new System.Drawing.Size(131, 37);
            this.btnShow分級.TabIndex = 6;
            this.btnShow分級.Text = "檢視全部";
            this.btnShow分級.UseVisualStyleBackColor = false;
            this.btnShow分級.Click += new System.EventHandler(this.btn_Show分級_Click);
            // 
            // txt分級說明
            // 
            this.txt分級說明.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt分級說明.ForeColor = System.Drawing.Color.DimGray;
            this.txt分級說明.Location = new System.Drawing.Point(115, 135);
            this.txt分級說明.Name = "txt分級說明";
            this.txt分級說明.Size = new System.Drawing.Size(149, 29);
            this.txt分級說明.TabIndex = 12;
            // 
            // txt分級級數
            // 
            this.txt分級級數.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt分級級數.ForeColor = System.Drawing.Color.DimGray;
            this.txt分級級數.Location = new System.Drawing.Point(115, 100);
            this.txt分級級數.Name = "txt分級級數";
            this.txt分級級數.Size = new System.Drawing.Size(149, 29);
            this.txt分級級數.TabIndex = 11;
            // 
            // txt分級編號
            // 
            this.txt分級編號.Enabled = false;
            this.txt分級編號.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt分級編號.ForeColor = System.Drawing.Color.DimGray;
            this.txt分級編號.Location = new System.Drawing.Point(115, 65);
            this.txt分級編號.Name = "txt分級編號";
            this.txt分級編號.Size = new System.Drawing.Size(149, 29);
            this.txt分級編號.TabIndex = 10;
            // 
            // lab分級編號
            // 
            this.lab分級編號.AutoSize = true;
            this.lab分級編號.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab分級編號.ForeColor = System.Drawing.Color.DimGray;
            this.lab分級編號.Location = new System.Drawing.Point(35, 68);
            this.lab分級編號.Name = "lab分級編號";
            this.lab分級編號.Size = new System.Drawing.Size(74, 21);
            this.lab分級編號.TabIndex = 13;
            this.lab分級編號.Text = "分級編號";
            // 
            // lab分級級數
            // 
            this.lab分級級數.AutoSize = true;
            this.lab分級級數.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab分級級數.ForeColor = System.Drawing.Color.DimGray;
            this.lab分級級數.Location = new System.Drawing.Point(35, 103);
            this.lab分級級數.Name = "lab分級級數";
            this.lab分級級數.Size = new System.Drawing.Size(74, 21);
            this.lab分級級數.TabIndex = 14;
            this.lab分級級數.Text = "分級級數";
            // 
            // lab分級說明
            // 
            this.lab分級說明.AutoSize = true;
            this.lab分級說明.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab分級說明.ForeColor = System.Drawing.Color.DimGray;
            this.lab分級說明.Location = new System.Drawing.Point(35, 138);
            this.lab分級說明.Name = "lab分級說明";
            this.lab分級說明.Size = new System.Drawing.Size(74, 21);
            this.lab分級說明.TabIndex = 15;
            this.lab分級說明.Text = "分級說明";
            // 
            // btnInsert分級
            // 
            this.btnInsert分級.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.btnInsert分級.FlatAppearance.BorderSize = 0;
            this.btnInsert分級.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert分級.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsert分級.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInsert分級.Location = new System.Drawing.Point(179, 183);
            this.btnInsert分級.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert分級.Name = "btnInsert分級";
            this.btnInsert分級.Size = new System.Drawing.Size(131, 37);
            this.btnInsert分級.TabIndex = 16;
            this.btnInsert分級.Text = "新增";
            this.btnInsert分級.UseVisualStyleBackColor = false;
            this.btnInsert分級.Click += new System.EventHandler(this.btnInsert分級_Click);
            // 
            // btnUpdate分級
            // 
            this.btnUpdate分級.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.btnUpdate分級.FlatAppearance.BorderSize = 0;
            this.btnUpdate分級.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate分級.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate分級.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate分級.Location = new System.Drawing.Point(320, 183);
            this.btnUpdate分級.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate分級.Name = "btnUpdate分級";
            this.btnUpdate分級.Size = new System.Drawing.Size(127, 37);
            this.btnUpdate分級.TabIndex = 17;
            this.btnUpdate分級.Text = "修改";
            this.btnUpdate分級.UseVisualStyleBackColor = false;
            this.btnUpdate分級.Click += new System.EventHandler(this.btnUpdate分級_Click);
            // 
            // picBoxUpDate分級
            // 
            this.picBoxUpDate分級.Location = new System.Drawing.Point(277, 65);
            this.picBoxUpDate分級.Name = "picBoxUpDate分級";
            this.picBoxUpDate分級.Size = new System.Drawing.Size(306, 99);
            this.picBoxUpDate分級.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxUpDate分級.TabIndex = 18;
            this.picBoxUpDate分級.TabStop = false;
            // 
            // picBoxUpDate國家
            // 
            this.picBoxUpDate國家.Location = new System.Drawing.Point(277, 53);
            this.picBoxUpDate國家.Name = "picBoxUpDate國家";
            this.picBoxUpDate國家.Size = new System.Drawing.Size(335, 111);
            this.picBoxUpDate國家.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxUpDate國家.TabIndex = 28;
            this.picBoxUpDate國家.TabStop = false;
            // 
            // btnUpdate國家
            // 
            this.btnUpdate國家.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.btnUpdate國家.FlatAppearance.BorderSize = 0;
            this.btnUpdate國家.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate國家.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate國家.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate國家.Location = new System.Drawing.Point(328, 183);
            this.btnUpdate國家.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate國家.Name = "btnUpdate國家";
            this.btnUpdate國家.Size = new System.Drawing.Size(139, 35);
            this.btnUpdate國家.TabIndex = 27;
            this.btnUpdate國家.Text = "修改";
            this.btnUpdate國家.UseVisualStyleBackColor = false;
            this.btnUpdate國家.Click += new System.EventHandler(this.btnUpdate國家_Click);
            // 
            // btnInsert國家
            // 
            this.btnInsert國家.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.btnInsert國家.FlatAppearance.BorderSize = 0;
            this.btnInsert國家.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert國家.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsert國家.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInsert國家.Location = new System.Drawing.Point(183, 183);
            this.btnInsert國家.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert國家.Name = "btnInsert國家";
            this.btnInsert國家.Size = new System.Drawing.Size(139, 35);
            this.btnInsert國家.TabIndex = 26;
            this.btnInsert國家.Text = "新增";
            this.btnInsert國家.UseVisualStyleBackColor = false;
            this.btnInsert國家.Click += new System.EventHandler(this.btnInsert國家_Click);
            // 
            // lab國家名稱
            // 
            this.lab國家名稱.AutoSize = true;
            this.lab國家名稱.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab國家名稱.ForeColor = System.Drawing.Color.DimGray;
            this.lab國家名稱.Location = new System.Drawing.Point(34, 92);
            this.lab國家名稱.Name = "lab國家名稱";
            this.lab國家名稱.Size = new System.Drawing.Size(74, 21);
            this.lab國家名稱.TabIndex = 25;
            this.lab國家名稱.Text = "國家名稱";
            // 
            // lab國家編號
            // 
            this.lab國家編號.AutoSize = true;
            this.lab國家編號.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab國家編號.ForeColor = System.Drawing.Color.DimGray;
            this.lab國家編號.Location = new System.Drawing.Point(34, 56);
            this.lab國家編號.Name = "lab國家編號";
            this.lab國家編號.Size = new System.Drawing.Size(74, 21);
            this.lab國家編號.TabIndex = 24;
            this.lab國家編號.Text = "國家編號";
            // 
            // txt國家名稱
            // 
            this.txt國家名稱.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt國家名稱.ForeColor = System.Drawing.Color.DimGray;
            this.txt國家名稱.Location = new System.Drawing.Point(114, 88);
            this.txt國家名稱.Name = "txt國家名稱";
            this.txt國家名稱.Size = new System.Drawing.Size(150, 29);
            this.txt國家名稱.TabIndex = 23;
            // 
            // txt國家編號
            // 
            this.txt國家編號.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt國家編號.ForeColor = System.Drawing.Color.DimGray;
            this.txt國家編號.Location = new System.Drawing.Point(114, 53);
            this.txt國家編號.Name = "txt國家編號";
            this.txt國家編號.Size = new System.Drawing.Size(150, 29);
            this.txt國家編號.TabIndex = 22;
            // 
            // btnBrowse國家
            // 
            this.btnBrowse國家.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.btnBrowse國家.FlatAppearance.BorderSize = 0;
            this.btnBrowse國家.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse國家.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBrowse國家.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBrowse國家.Location = new System.Drawing.Point(473, 183);
            this.btnBrowse國家.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowse國家.Name = "btnBrowse國家";
            this.btnBrowse國家.Size = new System.Drawing.Size(139, 35);
            this.btnBrowse國家.TabIndex = 21;
            this.btnBrowse國家.Text = "上傳圖片";
            this.btnBrowse國家.UseVisualStyleBackColor = false;
            this.btnBrowse國家.Click += new System.EventHandler(this.btnBrowse國家_Click);
            // 
            // btnShow國家
            // 
            this.btnShow國家.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.btnShow國家.FlatAppearance.BorderSize = 0;
            this.btnShow國家.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow國家.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShow國家.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShow國家.Location = new System.Drawing.Point(38, 183);
            this.btnShow國家.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShow國家.Name = "btnShow國家";
            this.btnShow國家.Size = new System.Drawing.Size(139, 35);
            this.btnShow國家.TabIndex = 20;
            this.btnShow國家.Text = "檢視全部";
            this.btnShow國家.UseVisualStyleBackColor = false;
            this.btnShow國家.Click += new System.EventHandler(this.btn_Show國家_Click);
            // 
            // dataGridView國家
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 10F);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView國家.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView國家.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView國家.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微軟正黑體", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView國家.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView國家.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView國家.Location = new System.Drawing.Point(38, 245);
            this.dataGridView國家.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView國家.Name = "dataGridView國家";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微軟正黑體", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView國家.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView國家.RowHeadersWidth = 51;
            this.dataGridView國家.RowTemplate.Height = 24;
            this.dataGridView國家.Size = new System.Drawing.Size(574, 334);
            this.dataGridView國家.TabIndex = 19;
            this.dataGridView國家.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView國家_CellMouseUp);
            // 
            // grpBox電影分級
            // 
            this.grpBox電影分級.Controls.Add(this.lab電影分級);
            this.grpBox電影分級.Controls.Add(this.lab分級編號);
            this.grpBox電影分級.Controls.Add(this.txt分級編號);
            this.grpBox電影分級.Controls.Add(this.txt分級級數);
            this.grpBox電影分級.Controls.Add(this.txt分級說明);
            this.grpBox電影分級.Controls.Add(this.lab分級級數);
            this.grpBox電影分級.Controls.Add(this.lab分級說明);
            this.grpBox電影分級.Controls.Add(this.picBoxUpDate分級);
            this.grpBox電影分級.Controls.Add(this.btnShow分級);
            this.grpBox電影分級.Controls.Add(this.dataGridView分級);
            this.grpBox電影分級.Controls.Add(this.btnBrowse分級);
            this.grpBox電影分級.Controls.Add(this.btnInsert分級);
            this.grpBox電影分級.Controls.Add(this.btnUpdate分級);
            this.grpBox電影分級.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.grpBox電影分級.ForeColor = System.Drawing.Color.DimGray;
            this.grpBox電影分級.Location = new System.Drawing.Point(40, 40);
            this.grpBox電影分級.Name = "grpBox電影分級";
            this.grpBox電影分級.Size = new System.Drawing.Size(627, 614);
            this.grpBox電影分級.TabIndex = 31;
            this.grpBox電影分級.TabStop = false;
            // 
            // lab電影分級
            // 
            this.lab電影分級.AutoSize = true;
            this.lab電影分級.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold);
            this.lab電影分級.ForeColor = System.Drawing.Color.DimGray;
            this.lab電影分級.Location = new System.Drawing.Point(15, -5);
            this.lab電影分級.Name = "lab電影分級";
            this.lab電影分級.Size = new System.Drawing.Size(123, 35);
            this.lab電影分級.TabIndex = 33;
            this.lab電影分級.Text = "電影分級";
            // 
            // grpBox電影產地
            // 
            this.grpBox電影產地.Controls.Add(this.lab電影產地);
            this.grpBox電影產地.Controls.Add(this.lab國家編號);
            this.grpBox電影產地.Controls.Add(this.btnUpdate國家);
            this.grpBox電影產地.Controls.Add(this.txt國家編號);
            this.grpBox電影產地.Controls.Add(this.btnInsert國家);
            this.grpBox電影產地.Controls.Add(this.picBoxUpDate國家);
            this.grpBox電影產地.Controls.Add(this.btnBrowse國家);
            this.grpBox電影產地.Controls.Add(this.txt國家名稱);
            this.grpBox電影產地.Controls.Add(this.btnShow國家);
            this.grpBox電影產地.Controls.Add(this.dataGridView國家);
            this.grpBox電影產地.Controls.Add(this.lab國家名稱);
            this.grpBox電影產地.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.grpBox電影產地.ForeColor = System.Drawing.Color.DimGray;
            this.grpBox電影產地.Location = new System.Drawing.Point(730, 40);
            this.grpBox電影產地.Name = "grpBox電影產地";
            this.grpBox電影產地.Size = new System.Drawing.Size(656, 614);
            this.grpBox電影產地.TabIndex = 32;
            this.grpBox電影產地.TabStop = false;
            // 
            // lab電影產地
            // 
            this.lab電影產地.AutoSize = true;
            this.lab電影產地.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold);
            this.lab電影產地.ForeColor = System.Drawing.Color.DimGray;
            this.lab電影產地.Location = new System.Drawing.Point(15, -5);
            this.lab電影產地.Name = "lab電影產地";
            this.lab電影產地.Size = new System.Drawing.Size(123, 35);
            this.lab電影產地.TabIndex = 34;
            this.lab電影產地.Text = "電影產地";
            // 
            // 電影分級
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1421, 976);
            this.Controls.Add(this.grpBox電影產地);
            this.Controls.Add(this.grpBox電影分級);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "電影分級";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView分級)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUpDate分級)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUpDate國家)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView國家)).EndInit();
            this.grpBox電影分級.ResumeLayout(false);
            this.grpBox電影分級.PerformLayout();
            this.grpBox電影產地.ResumeLayout(false);
            this.grpBox電影產地.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView分級;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnBrowse分級;
        private System.Windows.Forms.Button btnShow分級;
        private System.Windows.Forms.TextBox txt分級說明;
        private System.Windows.Forms.TextBox txt分級級數;
        private System.Windows.Forms.TextBox txt分級編號;
        private System.Windows.Forms.Label lab分級編號;
        private System.Windows.Forms.Label lab分級級數;
        private System.Windows.Forms.Label lab分級說明;
        private System.Windows.Forms.Button btnInsert分級;
        private System.Windows.Forms.Button btnUpdate分級;
        private System.Windows.Forms.PictureBox picBoxUpDate分級;
        private System.Windows.Forms.PictureBox picBoxUpDate國家;
        private System.Windows.Forms.Button btnUpdate國家;
        private System.Windows.Forms.Button btnInsert國家;
        private System.Windows.Forms.Label lab國家名稱;
        private System.Windows.Forms.Label lab國家編號;
        private System.Windows.Forms.TextBox txt國家名稱;
        private System.Windows.Forms.TextBox txt國家編號;
        private System.Windows.Forms.Button btnBrowse國家;
        private System.Windows.Forms.Button btnShow國家;
        private System.Windows.Forms.DataGridView dataGridView國家;
        private System.Windows.Forms.GroupBox grpBox電影分級;
        private System.Windows.Forms.GroupBox grpBox電影產地;
        private System.Windows.Forms.Label lab電影分級;
        private System.Windows.Forms.Label lab電影產地;
    }
}

