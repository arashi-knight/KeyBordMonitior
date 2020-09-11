namespace KeyBordMonitor
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏小图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_Save = new System.Windows.Forms.Timer(this.components);
            this.timer_midnight = new System.Windows.Forms.Timer(this.components);
            this.timer_gc = new System.Windows.Forms.Timer(this.components);
            this.uiSymbolButton_refresh = new Sunny.UI.UISymbolButton();
            this.uiToolTip1 = new Sunny.UI.UIToolTip(this.components);
            this.uiLabel_lastSave = new Sunny.UI.UILabel();
            this.Footer.SuspendLayout();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.uiSymbolButton_refresh);
            this.Footer.Controls.Add(this.uiLabel_lastSave);
            this.Footer.Location = new System.Drawing.Point(186, 720);
            this.Footer.Size = new System.Drawing.Size(838, 39);
            // 
            // Header
            // 
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Location = new System.Drawing.Point(0, 35);
            this.Header.Size = new System.Drawing.Size(1024, 106);
            // 
            // Aside
            // 
            this.Aside.Location = new System.Drawing.Point(0, 141);
            this.Aside.ShowOneNode = true;
            this.Aside.Size = new System.Drawing.Size(186, 618);
            this.Aside.Style = Sunny.UI.UIStyle.Custom;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "keyBordMonitor";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示主界面ToolStripMenuItem,
            this.隐藏主界面ToolStripMenuItem,
            this.隐藏小图标ToolStripMenuItem,
            this.退出程序ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 100);
            // 
            // 显示主界面ToolStripMenuItem
            // 
            this.显示主界面ToolStripMenuItem.Name = "显示主界面ToolStripMenuItem";
            this.显示主界面ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.显示主界面ToolStripMenuItem.Text = "显示主界面";
            this.显示主界面ToolStripMenuItem.Click += new System.EventHandler(this.显示主界面ToolStripMenuItem_Click);
            // 
            // 隐藏主界面ToolStripMenuItem
            // 
            this.隐藏主界面ToolStripMenuItem.Name = "隐藏主界面ToolStripMenuItem";
            this.隐藏主界面ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.隐藏主界面ToolStripMenuItem.Text = "隐藏主界面";
            this.隐藏主界面ToolStripMenuItem.Click += new System.EventHandler(this.隐藏主界面ToolStripMenuItem_Click);
            // 
            // 隐藏小图标ToolStripMenuItem
            // 
            this.隐藏小图标ToolStripMenuItem.Name = "隐藏小图标ToolStripMenuItem";
            this.隐藏小图标ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.隐藏小图标ToolStripMenuItem.Text = "隐藏小图标";
            this.隐藏小图标ToolStripMenuItem.Click += new System.EventHandler(this.隐藏小图标ToolStripMenuItem_Click);
            // 
            // 退出程序ToolStripMenuItem
            // 
            this.退出程序ToolStripMenuItem.Name = "退出程序ToolStripMenuItem";
            this.退出程序ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.退出程序ToolStripMenuItem.Text = "退出程序";
            this.退出程序ToolStripMenuItem.Click += new System.EventHandler(this.退出程序ToolStripMenuItem_Click);
            // 
            // timer_Save
            // 
            this.timer_Save.Interval = 3600000;
            this.timer_Save.Tick += new System.EventHandler(this.timer_Save_Tick);
            // 
            // timer_midnight
            // 
            this.timer_midnight.Interval = 3600000;
            this.timer_midnight.Tick += new System.EventHandler(this.timer_midnight_Tick);
            // 
            // timer_gc
            // 
            this.timer_gc.Interval = 10000;
            this.timer_gc.Tick += new System.EventHandler(this.timer_gc_Tick);
            // 
            // uiSymbolButton_refresh
            // 
            this.uiSymbolButton_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_refresh.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolButton_refresh.IsCircle = true;
            this.uiSymbolButton_refresh.Location = new System.Drawing.Point(439, 0);
            this.uiSymbolButton_refresh.Name = "uiSymbolButton_refresh";
            this.uiSymbolButton_refresh.Size = new System.Drawing.Size(39, 36);
            this.uiSymbolButton_refresh.Symbol = 61473;
            this.uiSymbolButton_refresh.TabIndex = 1;
            this.uiToolTip1.SetToolTip(this.uiSymbolButton_refresh, "刷新数据");
            this.uiSymbolButton_refresh.Click += new System.EventHandler(this.uiSymbolButton_refresh_Click);
            // 
            // uiToolTip1
            // 
            this.uiToolTip1.BackColor = System.Drawing.Color.White;
            this.uiToolTip1.ForeColor = System.Drawing.Color.Black;
            this.uiToolTip1.OwnerDraw = true;
            // 
            // uiLabel_lastSave
            // 
            this.uiLabel_lastSave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel_lastSave.Location = new System.Drawing.Point(473, 6);
            this.uiLabel_lastSave.Name = "uiLabel_lastSave";
            this.uiLabel_lastSave.Size = new System.Drawing.Size(365, 31);
            this.uiLabel_lastSave.TabIndex = 0;
            this.uiLabel_lastSave.Text = "上次更新时间为:";
            this.uiLabel_lastSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 759);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = true;
            this.Text = "键盘监控";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Controls.SetChildIndex(this.Header, 0);
            this.Controls.SetChildIndex(this.Aside, 0);
            this.Controls.SetChildIndex(this.Footer, 0);
            this.Footer.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示主界面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隐藏主界面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隐藏小图标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出程序ToolStripMenuItem;
        private System.Windows.Forms.Timer timer_Save;
        private System.Windows.Forms.Timer timer_midnight;
        private System.Windows.Forms.Timer timer_gc;
        private Sunny.UI.UISymbolButton uiSymbolButton_refresh;
        private Sunny.UI.UIToolTip uiToolTip1;
        private Sunny.UI.UILabel uiLabel_lastSave;
    }
}

