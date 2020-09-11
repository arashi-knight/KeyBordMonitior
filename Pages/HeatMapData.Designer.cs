namespace KeyBordMonitor
{
    partial class HeatMapData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeatMapData));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiButton_ReSet = new Sunny.UI.UIButton();
            this.uiButton_save = new Sunny.UI.UIButton();
            this.uiButton_create = new Sunny.UI.UIButton();
            this.uiPanel_data = new Sunny.UI.UIPanel();
            this.uiLabel_date = new Sunny.UI.UILabel();
            this.uiLabel_total = new Sunny.UI.UILabel();
            this.uiCheckBox_totalData = new Sunny.UI.UICheckBox();
            this.uiCheckBox_todayData = new Sunny.UI.UICheckBox();
            this.PagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.uiPanel_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.pictureBox1);
            this.PagePanel.Controls.Add(this.uiGroupBox1);
            this.PagePanel.Size = new System.Drawing.Size(838, 544);
            this.PagePanel.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(838, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiPanel_data);
            this.uiGroupBox1.Controls.Add(this.uiButton_ReSet);
            this.uiGroupBox1.Controls.Add(this.uiButton_save);
            this.uiGroupBox1.Controls.Add(this.uiButton_create);
            this.uiGroupBox1.Controls.Add(this.uiCheckBox_totalData);
            this.uiGroupBox1.Controls.Add(this.uiCheckBox_todayData);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(838, 91);
            this.uiGroupBox1.TabIndex = 4;
            this.uiGroupBox1.Text = "设置";
            // 
            // uiButton_ReSet
            // 
            this.uiButton_ReSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_ReSet.Enabled = false;
            this.uiButton_ReSet.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton_ReSet.Location = new System.Drawing.Point(342, 35);
            this.uiButton_ReSet.Name = "uiButton_ReSet";
            this.uiButton_ReSet.Radius = 15;
            this.uiButton_ReSet.Size = new System.Drawing.Size(100, 35);
            this.uiButton_ReSet.TabIndex = 9;
            this.uiButton_ReSet.Text = "重置";
            this.uiButton_ReSet.Click += new System.EventHandler(this.uiButton_ReSet_Click);
            // 
            // uiButton_save
            // 
            this.uiButton_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_save.Enabled = false;
            this.uiButton_save.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton_save.Location = new System.Drawing.Point(236, 35);
            this.uiButton_save.Name = "uiButton_save";
            this.uiButton_save.Radius = 15;
            this.uiButton_save.Size = new System.Drawing.Size(100, 35);
            this.uiButton_save.TabIndex = 5;
            this.uiButton_save.Text = "保存";
            this.uiButton_save.Click += new System.EventHandler(this.uiButton_save_Click);
            // 
            // uiButton_create
            // 
            this.uiButton_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_create.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton_create.Location = new System.Drawing.Point(130, 35);
            this.uiButton_create.Name = "uiButton_create";
            this.uiButton_create.Radius = 15;
            this.uiButton_create.Size = new System.Drawing.Size(100, 35);
            this.uiButton_create.TabIndex = 4;
            this.uiButton_create.Text = "生成";
            this.uiButton_create.Click += new System.EventHandler(this.uiButton_create_Click);
            // 
            // uiPanel_data
            // 
            this.uiPanel_data.Controls.Add(this.uiLabel_date);
            this.uiPanel_data.Controls.Add(this.uiLabel_total);
            this.uiPanel_data.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel_data.Location = new System.Drawing.Point(449, 24);
            this.uiPanel_data.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel_data.Name = "uiPanel_data";
            this.uiPanel_data.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel_data.Size = new System.Drawing.Size(385, 59);
            this.uiPanel_data.TabIndex = 8;
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
            // uiCheckBox_totalData
            // 
            this.uiCheckBox_totalData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox_totalData.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBox_totalData.Location = new System.Drawing.Point(12, 56);
            this.uiCheckBox_totalData.Name = "uiCheckBox_totalData";
            this.uiCheckBox_totalData.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox_totalData.Size = new System.Drawing.Size(150, 29);
            this.uiCheckBox_totalData.TabIndex = 7;
            this.uiCheckBox_totalData.Text = "总数据";
            this.uiCheckBox_totalData.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.uiCheckBox_totalData_ValueChanged);
            // 
            // uiCheckBox_todayData
            // 
            this.uiCheckBox_todayData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox_todayData.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBox_todayData.Location = new System.Drawing.Point(12, 27);
            this.uiCheckBox_todayData.Name = "uiCheckBox_todayData";
            this.uiCheckBox_todayData.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox_todayData.Size = new System.Drawing.Size(150, 29);
            this.uiCheckBox_todayData.TabIndex = 6;
            this.uiCheckBox_todayData.Text = "今日数据";
            this.uiCheckBox_todayData.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.uiCheckBox_todayData_ValueChanged);
            // 
            // HeatMapData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 579);
            this.Name = "HeatMapData";
            this.Symbol = 61502;
            this.Text = "热力图";
            this.PagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiPanel_data.ResumeLayout(false);
            this.uiPanel_data.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIButton uiButton_save;
        private Sunny.UI.UIButton uiButton_create;
        private Sunny.UI.UICheckBox uiCheckBox_totalData;
        private Sunny.UI.UICheckBox uiCheckBox_todayData;
        private Sunny.UI.UIPanel uiPanel_data;
        private Sunny.UI.UILabel uiLabel_date;
        private Sunny.UI.UILabel uiLabel_total;
        private Sunny.UI.UIButton uiButton_ReSet;
    }
}