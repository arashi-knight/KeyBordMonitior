namespace KeyBordMonitor
{
    partial class BarChartData
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
            this.uiBarChart1 = new Sunny.UI.UIBarChart();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiPanel_data = new Sunny.UI.UIPanel();
            this.uiLabel_date = new Sunny.UI.UILabel();
            this.uiLabel_total = new Sunny.UI.UILabel();
            this.uiButton_today = new Sunny.UI.UIButton();
            this.uiButton_daily = new Sunny.UI.UIButton();
            this.uiButton_total = new Sunny.UI.UIButton();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.uiTextBox_min = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiTextBox_max = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.PagePanel.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.uiPanel_data.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.uiPanel_data);
            this.PagePanel.Controls.Add(this.uiBarChart1);
            this.PagePanel.Controls.Add(this.uiGroupBox1);
            this.PagePanel.Size = new System.Drawing.Size(858, 504);
            // 
            // uiBarChart1
            // 
            this.uiBarChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiBarChart1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.uiBarChart1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiBarChart1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.uiBarChart1.Location = new System.Drawing.Point(0, 85);
            this.uiBarChart1.Name = "uiBarChart1";
            this.uiBarChart1.Option = null;
            this.uiBarChart1.Size = new System.Drawing.Size(858, 419);
            this.uiBarChart1.TabIndex = 0;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiGroupBox2);
            this.uiGroupBox1.Controls.Add(this.uiButton_today);
            this.uiGroupBox1.Controls.Add(this.uiButton_daily);
            this.uiGroupBox1.Controls.Add(this.uiButton_total);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(858, 85);
            this.uiGroupBox1.TabIndex = 1;
            this.uiGroupBox1.Text = "设置";
            // 
            // uiPanel_data
            // 
            this.uiPanel_data.Controls.Add(this.uiLabel_date);
            this.uiPanel_data.Controls.Add(this.uiLabel_total);
            this.uiPanel_data.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.uiPanel_data.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel_data.Location = new System.Drawing.Point(598, 90);
            this.uiPanel_data.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel_data.Name = "uiPanel_data";
            this.uiPanel_data.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel_data.Size = new System.Drawing.Size(256, 50);
            this.uiPanel_data.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel_data.TabIndex = 5;
            this.uiPanel_data.Text = null;
            // 
            // uiLabel_date
            // 
            this.uiLabel_date.AutoSize = true;
            this.uiLabel_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.uiLabel_date.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel_date.Location = new System.Drawing.Point(3, 27);
            this.uiLabel_date.Name = "uiLabel_date";
            this.uiLabel_date.Size = new System.Drawing.Size(39, 20);
            this.uiLabel_date.TabIndex = 1;
            this.uiLabel_date.Text = "日期";
            this.uiLabel_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_total
            // 
            this.uiLabel_total.AutoSize = true;
            this.uiLabel_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.uiLabel_total.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel_total.Location = new System.Drawing.Point(3, 0);
            this.uiLabel_total.Name = "uiLabel_total";
            this.uiLabel_total.Size = new System.Drawing.Size(39, 20);
            this.uiLabel_total.TabIndex = 0;
            this.uiLabel_total.Text = "总数";
            this.uiLabel_total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiButton_today
            // 
            this.uiButton_today.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_today.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton_today.Location = new System.Drawing.Point(12, 39);
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
            this.uiButton_daily.Location = new System.Drawing.Point(224, 39);
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
            this.uiButton_total.Location = new System.Drawing.Point(118, 39);
            this.uiButton_total.Name = "uiButton_total";
            this.uiButton_total.Radius = 15;
            this.uiButton_total.Size = new System.Drawing.Size(100, 35);
            this.uiButton_total.TabIndex = 1;
            this.uiButton_total.Text = "总数据";
            this.uiButton_total.Click += new System.EventHandler(this.uiButton_total_Click);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.uiTextBox_max);
            this.uiGroupBox2.Controls.Add(this.uiLabel2);
            this.uiGroupBox2.Controls.Add(this.uiTextBox_min);
            this.uiGroupBox2.Controls.Add(this.uiLabel1);
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox2.Location = new System.Drawing.Point(343, 18);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(511, 62);
            this.uiGroupBox2.TabIndex = 4;
            this.uiGroupBox2.Text = "显示范围";
            // 
            // uiTextBox_min
            // 
            this.uiTextBox_min.CanEmpty = true;
            this.uiTextBox_min.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_min.FillColor = System.Drawing.Color.White;
            this.uiTextBox_min.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_min.Location = new System.Drawing.Point(75, 25);
            this.uiTextBox_min.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_min.Maximum = 2147483647D;
            this.uiTextBox_min.Minimum = -2147483648D;
            this.uiTextBox_min.Name = "uiTextBox_min";
            this.uiTextBox_min.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_min.Size = new System.Drawing.Size(150, 31);
            this.uiTextBox_min.TabIndex = 0;
            this.uiTextBox_min.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.uiTextBox_min.Watermark = "不设下限";
            this.uiTextBox_min.TextChanged += new System.EventHandler(this.uiTextBox_min_TextChanged);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(14, 25);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(64, 31);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "最小:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiTextBox_max
            // 
            this.uiTextBox_max.CanEmpty = true;
            this.uiTextBox_max.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_max.FillColor = System.Drawing.Color.White;
            this.uiTextBox_max.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_max.Location = new System.Drawing.Point(306, 25);
            this.uiTextBox_max.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_max.Maximum = 2147483647D;
            this.uiTextBox_max.Minimum = -2147483648D;
            this.uiTextBox_max.Name = "uiTextBox_max";
            this.uiTextBox_max.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_max.Size = new System.Drawing.Size(150, 31);
            this.uiTextBox_max.TabIndex = 2;
            this.uiTextBox_max.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.uiTextBox_max.Watermark = "不设上限";
            this.uiTextBox_max.TextChanged += new System.EventHandler(this.uiTextBox_max_TextChanged);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(245, 25);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(64, 31);
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "最大:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BarChartData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 539);
            this.Name = "BarChartData";
            this.Symbol = 61568;
            this.Text = "条形图";
            this.PagePanel.ResumeLayout(false);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiPanel_data.ResumeLayout(false);
            this.uiPanel_data.PerformLayout();
            this.uiGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIButton uiButton_total;
        private Sunny.UI.UIBarChart uiBarChart1;
        private Sunny.UI.UIButton uiButton_daily;
        private Sunny.UI.UIButton uiButton_today;
        private Sunny.UI.UIPanel uiPanel_data;
        private Sunny.UI.UILabel uiLabel_date;
        private Sunny.UI.UILabel uiLabel_total;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UITextBox uiTextBox_max;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox uiTextBox_min;
        private Sunny.UI.UILabel uiLabel1;
    }
}