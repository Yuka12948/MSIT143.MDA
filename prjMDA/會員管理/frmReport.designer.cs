
namespace prjMember
{
    partial class frmReport
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSetData = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDetail = new System.Windows.Forms.Button();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTargetID = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtxtReply = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReporter = new System.Windows.Forms.TextBox();
            this.rtxtReason = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbNull = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTarget = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ckbStatus = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ckbStatus);
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.btnDetail);
            this.splitContainer1.Panel1.Controls.Add(this.txtTarget);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txtTargetID);
            this.splitContainer1.Panel1.Controls.Add(this.btnSend);
            this.splitContainer1.Panel1.Controls.Add(this.rtxtReply);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtReporter);
            this.splitContainer1.Panel1.Controls.Add(this.rtxtReason);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1498, 844);
            this.splitContainer1.SplitterDistance = 449;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Location = new System.Drawing.Point(1096, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(381, 334);
            this.listBox1.TabIndex = 17;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 68);
            this.button1.TabIndex = 16;
            this.button1.Text = "假回覆資料";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSetData
            // 
            this.btnSetData.Location = new System.Drawing.Point(457, 307);
            this.btnSetData.Name = "btnSetData";
            this.btnSetData.Size = new System.Drawing.Size(110, 68);
            this.btnSetData.TabIndex = 15;
            this.btnSetData.Text = "假清單資料";
            this.btnSetData.UseVisualStyleBackColor = true;
            this.btnSetData.Click += new System.EventHandler(this.btnSetData_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 64);
            this.label7.TabIndex = 14;
            this.label7.Text = "被檢舉ID: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(432, 28);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(135, 92);
            this.btnDetail.TabIndex = 13;
            this.btnDetail.Text = "詳細內容/設定屏蔽";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // txtTarget
            // 
            this.txtTarget.Enabled = false;
            this.txtTarget.Location = new System.Drawing.Point(174, 28);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(214, 39);
            this.txtTarget.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(1091, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 64);
            this.label5.TabIndex = 11;
            this.label5.Text = "常用回覆: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTargetID
            // 
            this.txtTargetID.Location = new System.Drawing.Point(174, 81);
            this.txtTargetID.Name = "txtTargetID";
            this.txtTargetID.Size = new System.Drawing.Size(214, 39);
            this.txtTargetID.TabIndex = 9;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(940, 30);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(136, 42);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "送出Email";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtxtReply
            // 
            this.rtxtReply.Location = new System.Drawing.Point(637, 81);
            this.rtxtReply.Name = "rtxtReply";
            this.rtxtReply.Size = new System.Drawing.Size(439, 347);
            this.rtxtReply.TabIndex = 7;
            this.rtxtReply.Text = "";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(632, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 64);
            this.label4.TabIndex = 6;
            this.label4.Text = "意見回覆: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReporter
            // 
            this.txtReporter.Location = new System.Drawing.Point(174, 136);
            this.txtReporter.Name = "txtReporter";
            this.txtReporter.Size = new System.Drawing.Size(393, 39);
            this.txtReporter.TabIndex = 5;
            // 
            // rtxtReason
            // 
            this.rtxtReason.Location = new System.Drawing.Point(174, 181);
            this.rtxtReason.Name = "rtxtReason";
            this.rtxtReason.Size = new System.Drawing.Size(393, 247);
            this.rtxtReason.TabIndex = 4;
            this.rtxtReason.Text = "";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 64);
            this.label3.TabIndex = 3;
            this.label3.Text = "檢舉人: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 64);
            this.label2.TabIndex = 2;
            this.label2.Text = "檢舉事由: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "被檢舉對象: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnRefresh);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.btnSetData);
            this.splitContainer2.Panel1.Controls.Add(this.cmbStatus);
            this.splitContainer2.Panel1.Controls.Add(this.txtSearch);
            this.splitContainer2.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer2.Panel1.Controls.Add(this.label10);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.cmbNull);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.cmbTarget);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(1498, 391);
            this.splitContainer2.SplitterDistance = 577;
            this.splitContainer2.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(47, 262);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(163, 39);
            this.txtSearch.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(230, 262);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(154, 39);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "理由搜尋";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 30);
            this.label10.TabIndex = 7;
            this.label10.Text = "理由有無內容:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 30);
            this.label9.TabIndex = 6;
            this.label9.Text = "檢舉對象:";
            // 
            // cmbNull
            // 
            this.cmbNull.FormattingEnabled = true;
            this.cmbNull.Location = new System.Drawing.Point(216, 196);
            this.cmbNull.Name = "cmbNull";
            this.cmbNull.Size = new System.Drawing.Size(168, 38);
            this.cmbNull.TabIndex = 4;
            this.cmbNull.SelectedIndexChanged += new System.EventHandler(this.cmbTarget_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 30);
            this.label6.TabIndex = 2;
            this.label6.Text = "搜尋條件";
            // 
            // cmbTarget
            // 
            this.cmbTarget.FormattingEnabled = true;
            this.cmbTarget.Location = new System.Drawing.Point(216, 142);
            this.cmbTarget.Name = "cmbTarget";
            this.cmbTarget.Size = new System.Drawing.Size(168, 38);
            this.cmbTarget.TabIndex = 1;
            this.cmbTarget.SelectedIndexChanged += new System.EventHandler(this.cmbTarget_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(917, 391);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(216, 84);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(168, 38);
            this.cmbStatus.TabIndex = 17;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbTarget_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 30);
            this.label8.TabIndex = 18;
            this.label8.Text = "處理狀態:";
            // 
            // ckbStatus
            // 
            this.ckbStatus.AutoSize = true;
            this.ckbStatus.Location = new System.Drawing.Point(47, 377);
            this.ckbStatus.Name = "ckbStatus";
            this.ckbStatus.Size = new System.Drawing.Size(111, 34);
            this.ckbStatus.TabIndex = 18;
            this.ckbStatus.Text = "已處理";
            this.ckbStatus.UseVisualStyleBackColor = true;
            this.ckbStatus.CheckedChanged += new System.EventHandler(this.ckbStatus_CheckedChanged);
            this.ckbStatus.Click += new System.EventHandler(this.ckbStatus_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(230, 322);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(154, 39);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "重整";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 844);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReporter;
        private System.Windows.Forms.RichTextBox rtxtReason;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtxtReply;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTargetID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTarget;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.ComboBox cmbNull;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnSetData;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.CheckBox ckbStatus;
        private System.Windows.Forms.Button btnRefresh;
    }
}