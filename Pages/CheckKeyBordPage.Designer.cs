namespace KeyBordMonitor.Pages
{
    partial class CheckKeyBordPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckKeyBordPage));
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiCheckBox_quickJump = new Sunny.UI.UICheckBox();
            this.uiCheckBox_keyJump = new Sunny.UI.UICheckBox();
            this.uiLabel_count = new Sunny.UI.UILabel();
            this.uiTextBox_xy = new Sunny.UI.UITextBox();
            this.uiLabel_xy = new Sunny.UI.UILabel();
            this.uiTextBox_key = new Sunny.UI.UITextBox();
            this.uiLabel_key = new Sunny.UI.UILabel();
            this.uiButton_next = new Sunny.UI.UIButton();
            this.uiButton_back = new Sunny.UI.UIButton();
            this.uiButton_contiueCheck = new Sunny.UI.UIButton();
            this.uiButton_endCheck = new Sunny.UI.UIButton();
            this.uiButton_stopCheck = new Sunny.UI.UIButton();
            this.uiButton_startCheck = new Sunny.UI.UIButton();
            this.picturebox_keyBord = new System.Windows.Forms.PictureBox();
            this.pictureBox_site = new System.Windows.Forms.PictureBox();
            this.uiToolTip1 = new Sunny.UI.UIToolTip(this.components);
            this.uiCheckBox_isIgnore = new Sunny.UI.UICheckBox();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_keyBord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_site)).BeginInit();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiCheckBox_isIgnore);
            this.uiGroupBox1.Controls.Add(this.uiCheckBox_quickJump);
            this.uiGroupBox1.Controls.Add(this.uiCheckBox_keyJump);
            this.uiGroupBox1.Controls.Add(this.uiLabel_count);
            this.uiGroupBox1.Controls.Add(this.uiTextBox_xy);
            this.uiGroupBox1.Controls.Add(this.uiLabel_xy);
            this.uiGroupBox1.Controls.Add(this.uiTextBox_key);
            this.uiGroupBox1.Controls.Add(this.uiLabel_key);
            this.uiGroupBox1.Controls.Add(this.uiButton_next);
            this.uiGroupBox1.Controls.Add(this.uiButton_back);
            this.uiGroupBox1.Controls.Add(this.uiButton_contiueCheck);
            this.uiGroupBox1.Controls.Add(this.uiButton_endCheck);
            this.uiGroupBox1.Controls.Add(this.uiButton_stopCheck);
            this.uiGroupBox1.Controls.Add(this.uiButton_startCheck);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 35);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(1066, 158);
            this.uiGroupBox1.TabIndex = 0;
            this.uiGroupBox1.Text = "设置";
            // 
            // uiCheckBox_quickJump
            // 
            this.uiCheckBox_quickJump.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox_quickJump.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBox_quickJump.Location = new System.Drawing.Point(842, 99);
            this.uiCheckBox_quickJump.Name = "uiCheckBox_quickJump";
            this.uiCheckBox_quickJump.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox_quickJump.Size = new System.Drawing.Size(150, 35);
            this.uiCheckBox_quickJump.TabIndex = 12;
            this.uiCheckBox_quickJump.Text = "快捷跳转";
            this.uiToolTip1.SetToolTip(this.uiCheckBox_quickJump, "当再次点击相同位置时（双击），跳转到下一个按键");
            this.uiCheckBox_quickJump.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.uiCheckBox_quickJump_ValueChanged);
            // 
            // uiCheckBox_keyJump
            // 
            this.uiCheckBox_keyJump.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox_keyJump.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBox_keyJump.Location = new System.Drawing.Point(842, 48);
            this.uiCheckBox_keyJump.Name = "uiCheckBox_keyJump";
            this.uiCheckBox_keyJump.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox_keyJump.Size = new System.Drawing.Size(150, 35);
            this.uiCheckBox_keyJump.TabIndex = 11;
            this.uiCheckBox_keyJump.Text = "按键跳转";
            this.uiToolTip1.SetToolTip(this.uiCheckBox_keyJump, "当键盘按下响应按键时，跳转到该按键");
            this.uiCheckBox_keyJump.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.uiCheckBox_keyJump_ValueChanged);
            // 
            // uiLabel_count
            // 
            this.uiLabel_count.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_count.Location = new System.Drawing.Point(729, 37);
            this.uiLabel_count.Name = "uiLabel_count";
            this.uiLabel_count.Size = new System.Drawing.Size(92, 34);
            this.uiLabel_count.TabIndex = 10;
            this.uiLabel_count.Text = "0/0";
            this.uiLabel_count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox_xy
            // 
            this.uiTextBox_xy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_xy.FillColor = System.Drawing.Color.White;
            this.uiTextBox_xy.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextBox_xy.Location = new System.Drawing.Point(580, 74);
            this.uiTextBox_xy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_xy.Maximum = 2147483647D;
            this.uiTextBox_xy.Minimum = -2147483648D;
            this.uiTextBox_xy.Name = "uiTextBox_xy";
            this.uiTextBox_xy.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_xy.ReadOnly = true;
            this.uiTextBox_xy.Size = new System.Drawing.Size(210, 34);
            this.uiTextBox_xy.TabIndex = 9;
            // 
            // uiLabel_xy
            // 
            this.uiLabel_xy.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_xy.Location = new System.Drawing.Point(512, 74);
            this.uiLabel_xy.Name = "uiLabel_xy";
            this.uiLabel_xy.Size = new System.Drawing.Size(61, 34);
            this.uiLabel_xy.TabIndex = 8;
            this.uiLabel_xy.Text = "坐标";
            this.uiLabel_xy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox_key
            // 
            this.uiTextBox_key.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_key.FillColor = System.Drawing.Color.White;
            this.uiTextBox_key.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextBox_key.Location = new System.Drawing.Point(580, 37);
            this.uiTextBox_key.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_key.Maximum = 2147483647D;
            this.uiTextBox_key.Minimum = -2147483648D;
            this.uiTextBox_key.Name = "uiTextBox_key";
            this.uiTextBox_key.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_key.ReadOnly = true;
            this.uiTextBox_key.Size = new System.Drawing.Size(142, 34);
            this.uiTextBox_key.TabIndex = 7;
            // 
            // uiLabel_key
            // 
            this.uiLabel_key.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_key.Location = new System.Drawing.Point(512, 37);
            this.uiLabel_key.Name = "uiLabel_key";
            this.uiLabel_key.Size = new System.Drawing.Size(61, 34);
            this.uiLabel_key.TabIndex = 6;
            this.uiLabel_key.Text = "键位";
            this.uiLabel_key.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiButton_next
            // 
            this.uiButton_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_next.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton_next.Location = new System.Drawing.Point(410, 73);
            this.uiButton_next.Name = "uiButton_next";
            this.uiButton_next.Radius = 10;
            this.uiButton_next.Size = new System.Drawing.Size(59, 35);
            this.uiButton_next.TabIndex = 5;
            this.uiButton_next.Text = "→";
            this.uiButton_next.Click += new System.EventHandler(this.uiButton_next_Click);
            // 
            // uiButton_back
            // 
            this.uiButton_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_back.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton_back.Location = new System.Drawing.Point(326, 73);
            this.uiButton_back.Name = "uiButton_back";
            this.uiButton_back.Radius = 10;
            this.uiButton_back.Size = new System.Drawing.Size(59, 35);
            this.uiButton_back.TabIndex = 4;
            this.uiButton_back.Text = "←";
            this.uiButton_back.Click += new System.EventHandler(this.uiButton_back_Click);
            // 
            // uiButton_contiueCheck
            // 
            this.uiButton_contiueCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_contiueCheck.Enabled = false;
            this.uiButton_contiueCheck.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton_contiueCheck.Location = new System.Drawing.Point(165, 48);
            this.uiButton_contiueCheck.Name = "uiButton_contiueCheck";
            this.uiButton_contiueCheck.Radius = 10;
            this.uiButton_contiueCheck.Size = new System.Drawing.Size(100, 35);
            this.uiButton_contiueCheck.TabIndex = 3;
            this.uiButton_contiueCheck.Text = "继续校对";
            this.uiButton_contiueCheck.Click += new System.EventHandler(this.uiButton_contiueCheck_Click);
            // 
            // uiButton_endCheck
            // 
            this.uiButton_endCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_endCheck.Enabled = false;
            this.uiButton_endCheck.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton_endCheck.Location = new System.Drawing.Point(43, 99);
            this.uiButton_endCheck.Name = "uiButton_endCheck";
            this.uiButton_endCheck.Radius = 10;
            this.uiButton_endCheck.Size = new System.Drawing.Size(100, 35);
            this.uiButton_endCheck.TabIndex = 2;
            this.uiButton_endCheck.Text = "结束校对";
            this.uiButton_endCheck.Click += new System.EventHandler(this.uiButton_endCheck_Click);
            // 
            // uiButton_stopCheck
            // 
            this.uiButton_stopCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_stopCheck.Enabled = false;
            this.uiButton_stopCheck.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton_stopCheck.Location = new System.Drawing.Point(165, 99);
            this.uiButton_stopCheck.Name = "uiButton_stopCheck";
            this.uiButton_stopCheck.Radius = 10;
            this.uiButton_stopCheck.Size = new System.Drawing.Size(100, 35);
            this.uiButton_stopCheck.TabIndex = 1;
            this.uiButton_stopCheck.Text = "暂停校对";
            this.uiButton_stopCheck.Click += new System.EventHandler(this.uiButton_stopCheck_Click);
            // 
            // uiButton_startCheck
            // 
            this.uiButton_startCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_startCheck.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton_startCheck.Location = new System.Drawing.Point(43, 48);
            this.uiButton_startCheck.Name = "uiButton_startCheck";
            this.uiButton_startCheck.Radius = 10;
            this.uiButton_startCheck.Size = new System.Drawing.Size(100, 35);
            this.uiButton_startCheck.TabIndex = 0;
            this.uiButton_startCheck.Text = "开始校对";
            this.uiButton_startCheck.Click += new System.EventHandler(this.uiButton_startCheck_Click);
            // 
            // picturebox_keyBord
            // 
            this.picturebox_keyBord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturebox_keyBord.Image = global::KeyBordMonitor.Properties.Resources.KeyBord;
            this.picturebox_keyBord.Location = new System.Drawing.Point(0, 193);
            this.picturebox_keyBord.Name = "picturebox_keyBord";
            this.picturebox_keyBord.Size = new System.Drawing.Size(1066, 512);
            this.picturebox_keyBord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox_keyBord.TabIndex = 1;
            this.picturebox_keyBord.TabStop = false;
            this.picturebox_keyBord.Click += new System.EventHandler(this.keyBord_Click);
            // 
            // pictureBox_site
            // 
            this.pictureBox_site.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_site.Image = global::KeyBordMonitor.Properties.Resources.CheckSite;
            this.pictureBox_site.Location = new System.Drawing.Point(3, 201);
            this.pictureBox_site.Name = "pictureBox_site";
            this.pictureBox_site.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_site.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_site.TabIndex = 2;
            this.pictureBox_site.TabStop = false;
            this.pictureBox_site.Click += new System.EventHandler(this.pictureBox_site_Click);
            // 
            // uiToolTip1
            // 
            this.uiToolTip1.BackColor = System.Drawing.Color.White;
            this.uiToolTip1.ForeColor = System.Drawing.Color.Black;
            this.uiToolTip1.OwnerDraw = true;
            // 
            // uiCheckBox_isIgnore
            // 
            this.uiCheckBox_isIgnore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox_isIgnore.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBox_isIgnore.Location = new System.Drawing.Point(517, 116);
            this.uiCheckBox_isIgnore.Name = "uiCheckBox_isIgnore";
            this.uiCheckBox_isIgnore.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox_isIgnore.Size = new System.Drawing.Size(150, 29);
            this.uiCheckBox_isIgnore.TabIndex = 13;
            this.uiCheckBox_isIgnore.Text = "是否忽略";
            this.uiToolTip1.SetToolTip(this.uiCheckBox_isIgnore, "你在条形图，热力图中将不会看到该按键的数据");
            this.uiCheckBox_isIgnore.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.uiCheckBox_isIgnore_ValueChanged);
            // 
            // CheckKeyBordPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 705);
            this.Controls.Add(this.pictureBox_site);
            this.Controls.Add(this.picturebox_keyBord);
            this.Controls.Add(this.uiGroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CheckKeyBordPage";
            this.Text = "CheckKeyBordPage";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CheckKeyBordPage_KeyUp);
            this.uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_keyBord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_site)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.PictureBox picturebox_keyBord;
        private Sunny.UI.UITextBox uiTextBox_key;
        private Sunny.UI.UILabel uiLabel_key;
        private Sunny.UI.UIButton uiButton_next;
        private Sunny.UI.UIButton uiButton_back;
        private Sunny.UI.UIButton uiButton_contiueCheck;
        private Sunny.UI.UIButton uiButton_endCheck;
        private Sunny.UI.UIButton uiButton_stopCheck;
        private Sunny.UI.UIButton uiButton_startCheck;
        private Sunny.UI.UICheckBox uiCheckBox_quickJump;
        private Sunny.UI.UICheckBox uiCheckBox_keyJump;
        private Sunny.UI.UILabel uiLabel_count;
        private Sunny.UI.UITextBox uiTextBox_xy;
        private Sunny.UI.UILabel uiLabel_xy;
        private System.Windows.Forms.PictureBox pictureBox_site;
        private Sunny.UI.UIToolTip uiToolTip1;
        private Sunny.UI.UICheckBox uiCheckBox_isIgnore;
    }
}