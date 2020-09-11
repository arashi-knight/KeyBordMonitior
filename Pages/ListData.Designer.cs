namespace KeyBordMonitor
{
    partial class ListData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiPanel_data = new Sunny.UI.UIPanel();
            this.uiLabel_date = new Sunny.UI.UILabel();
            this.uiLabel_total = new Sunny.UI.UILabel();
            this.uiButton_today = new Sunny.UI.UIButton();
            this.uiButton_daily = new Sunny.UI.UIButton();
            this.uiButton_total = new Sunny.UI.UIButton();
            this.uiPagination1 = new Sunny.UI.UIPagination();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.PagePanel.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.uiPanel_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.uiDataGridView1);
            this.PagePanel.Controls.Add(this.uiGroupBox1);
            this.PagePanel.Controls.Add(this.uiPagination1);
            this.PagePanel.Size = new System.Drawing.Size(838, 544);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiPanel_data);
            this.uiGroupBox1.Controls.Add(this.uiButton_today);
            this.uiGroupBox1.Controls.Add(this.uiButton_daily);
            this.uiGroupBox1.Controls.Add(this.uiButton_total);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(838, 84);
            this.uiGroupBox1.TabIndex = 3;
            this.uiGroupBox1.Text = "设置";
            // 
            // uiPanel_data
            // 
            this.uiPanel_data.Controls.Add(this.uiLabel_date);
            this.uiPanel_data.Controls.Add(this.uiLabel_total);
            this.uiPanel_data.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel_data.Location = new System.Drawing.Point(458, 20);
            this.uiPanel_data.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel_data.Name = "uiPanel_data";
            this.uiPanel_data.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel_data.Size = new System.Drawing.Size(376, 59);
            this.uiPanel_data.TabIndex = 4;
            this.uiPanel_data.Text = null;
            // 
            // uiLabel_date
            // 
            this.uiLabel_date.AutoSize = true;
            this.uiLabel_date.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_date.Location = new System.Drawing.Point(14, 27);
            this.uiLabel_date.Name = "uiLabel_date";
            this.uiLabel_date.Size = new System.Drawing.Size(52, 27);
            this.uiLabel_date.TabIndex = 1;
            this.uiLabel_date.Text = "日期";
            this.uiLabel_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_total
            // 
            this.uiLabel_total.AutoSize = true;
            this.uiLabel_total.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_total.Location = new System.Drawing.Point(14, 0);
            this.uiLabel_total.Name = "uiLabel_total";
            this.uiLabel_total.Size = new System.Drawing.Size(52, 27);
            this.uiLabel_total.TabIndex = 0;
            this.uiLabel_total.Text = "总数";
            this.uiLabel_total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiButton_today
            // 
            this.uiButton_today.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_today.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton_today.Location = new System.Drawing.Point(15, 35);
            this.uiButton_today.Name = "uiButton_today";
            this.uiButton_today.Radius = 15;
            this.uiButton_today.Size = new System.Drawing.Size(100, 35);
            this.uiButton_today.TabIndex = 3;
            this.uiButton_today.Text = "今日数据";
            this.uiButton_today.Click += new System.EventHandler(this.uiButton_today_Click);
            // 
            // uiButton_daily
            // 
            this.uiButton_daily.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_daily.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton_daily.Location = new System.Drawing.Point(227, 35);
            this.uiButton_daily.Name = "uiButton_daily";
            this.uiButton_daily.Radius = 15;
            this.uiButton_daily.Size = new System.Drawing.Size(100, 35);
            this.uiButton_daily.TabIndex = 2;
            this.uiButton_daily.Text = "每日数据";
            this.uiButton_daily.Click += new System.EventHandler(this.uiButton_daily_Click);
            // 
            // uiButton_total
            // 
            this.uiButton_total.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_total.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton_total.Location = new System.Drawing.Point(121, 35);
            this.uiButton_total.Name = "uiButton_total";
            this.uiButton_total.Radius = 15;
            this.uiButton_total.Size = new System.Drawing.Size(100, 35);
            this.uiButton_total.TabIndex = 1;
            this.uiButton_total.Text = "总数据";
            this.uiButton_total.Click += new System.EventHandler(this.uiButton_total_Click);
            // 
            // uiPagination1
            // 
            this.uiPagination1.ActivePage = 50;
            this.uiPagination1.CausesValidation = false;
            this.uiPagination1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPagination1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPagination1.Location = new System.Drawing.Point(0, 508);
            this.uiPagination1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPagination1.Name = "uiPagination1";
            this.uiPagination1.PagerCount = 13;
            this.uiPagination1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPagination1.Size = new System.Drawing.Size(838, 36);
            this.uiPagination1.TabIndex = 4;
            this.uiPagination1.Text = "uiPagination1";
            this.uiPagination1.PageChanged += new Sunny.UI.UIPagination.OnPageChangeEventHandler(this.uiPagination1_PageChanged);
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(0, 84);
            this.uiDataGridView1.Name = "uiDataGridView1";
            this.uiDataGridView1.RowHeadersVisible = false;
            this.uiDataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.uiDataGridView1.RowTemplate.Height = 29;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.ShowGridLine = true;
            this.uiDataGridView1.Size = new System.Drawing.Size(838, 424);
            this.uiDataGridView1.TabIndex = 5;
            // 
            // ListData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 579);
            this.Name = "ListData";
            this.Symbol = 61451;
            this.Text = "表格";
            this.PagePanel.ResumeLayout(false);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiPanel_data.ResumeLayout(false);
            this.uiPanel_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIButton uiButton_today;
        private Sunny.UI.UIButton uiButton_daily;
        private Sunny.UI.UIButton uiButton_total;
        private Sunny.UI.UIPagination uiPagination1;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UIPanel uiPanel_data;
        private Sunny.UI.UILabel uiLabel_date;
        private Sunny.UI.UILabel uiLabel_total;
    }
}