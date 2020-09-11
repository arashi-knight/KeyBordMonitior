using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyBordMonitor.Data;
using KeyBordMonitor.Helper;
using Sunny.UI;

namespace KeyBordMonitor
{
    public partial class Form1 : UIAsideHeaderMainFooterFrame
    {
        //定义钩子
        private UserActivityHook keyboardHook;
        //是否是从隐藏中打开
        private bool IsShowByHide = false;


        public Form1()
        {
            InitializeComponent();

            Aside.CreateNode(AddPage(new Setting()), 61459, 24);
            Aside.CreateNode(AddPage(new BarChartData()), 61568, 24);
            Aside.CreateNode(AddPage(new ListData()), 61451, 24);
            Aside.CreateNode(AddPage(new HeatMapData()), 61502, 24);
            
            Init();
        }

        #region 初始化相关

        /// <summary>
        /// 初始化
        /// </summary>
        public override void Init()
        {
            base.Init();

            //加载钩子
            keyboardHook = new UserActivityHook();
            keyboardHook.KeyUp += new KeyEventHandler(hook_KeyUp);

            //判断是否是自启动
            AutoRun();
            //加载键盘数据
            LoadKeyData();
            //判断是否过天
            CheckDate();
        }
        /// <summary>
        /// 判断是否隐藏托盘图标
        /// </summary>
        private void HideIcon()
        {
            //判断是否隐藏图标
            if(ConfigureData.configure.isHideIcon)
            {
                notifyIcon1.Visible = true;
            }
            else
            {
                notifyIcon1.Visible = false;
            }
        }
        /// <summary>
        /// 判断是否是来自开机启动
        /// </summary>
        private void AutoRun()
        {
            //如果是自启动
            if (SystemHelper.IsAutoRun())
            {
                IsShowByHide = true;
                HideForm();
                //判断是否隐藏托盘图标
                HideIcon();
            }
            else
            {
                this.Show();
            }
        }
        /// <summary>
        /// 第一次显示后执行，要是是开机启动的，就隐藏，否则展示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Shown(object sender, EventArgs e)
        {
            AutoRun();
        }

        #endregion

        #region 计数相关

        /// <summary>
        /// 键盘hook触发（键位抬起触发），相应变量递增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hook_KeyUp(object sender, KeyEventArgs e)
        {
            KeyData_Today.Increase(e.KeyCode.ToString());
        }
        /// <summary>
        /// 加载键盘数据
        /// </summary>
        private void LoadKeyData()
        {
            KeyData_DailyData.LoadKeyData();
            KeyData_Today.LoadKeyData();
            KeyData_Total.LoadKeyData();
        }
        /// <summary>
        /// 计时器，到点保存一次，并且检查是否过天
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Save_Tick(object sender, EventArgs e)
        {
            //判断是否开启午夜计时器
            //获得距离午夜的时间
            int time = DateTime.Now.AddDays(1).Date.Millisecond - DateTime.Now.Millisecond;
            //如果时间小于固定计时器的时间，则开启
            if(time < timer_Save.Interval)
            {
                timer_midnight.Interval = time + 10000;//定时器设置为第二天过十秒，稳一点
                timer_midnight.Enabled = true;
            }

            //保存数据
            SaveData();
        }
        /// <summary>
        /// 午夜计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_midnight_Tick(object sender, EventArgs e)
        {
            //更新数据
            SaveData();
            //关闭计时器
            timer_midnight.Enabled = false;

        }
        /// <summary>
        /// 刷新数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiSymbolButton_refresh_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        /// <summary>
        /// 判断是否过天
        /// </summary>
        private bool CheckDate()
        {
            //如果记录的天数已经过了，清空并重新记录。
            if(KeyData_Today.todayData.Date != DateTime.Now.ToString("yyyy-MM-dd"))
            {
                //先更新总数据和每日数据
                KeyData_Total.UpdateData();
                KeyData_DailyData.UpdateData();
                //保存并重置当天数据
                KeyData_Today.ResetCount();
                //保存数据
                KeyData_Today.SaveKeyData();
                KeyData_Total.SaveKeyData();
                KeyData_DailyData.SaveKeyData();

                return true;
            }
            return false;
        }
        /// <summary>
        /// 保存数据
        /// </summary>
        private void SaveData()
        {
            //判断是否过天
            if (!CheckDate())
            {
                //保存数据
                KeyData_Today.SaveKeyData();
                KeyData_Total.SaveKeyData();
                KeyData_DailyData.SaveKeyData();
            }
            //更新label
            uiLabel_lastSave.Text = "上次更新时间为：" + DateTime.Now.ToString("MM月dd日HH时mm分ss秒");
            //记录日志
            if (ConfigureData.configure.IsLog)
            {
                LogHelper.Info("保存记录");
            }

        }

        #endregion

        #region 小图标相关

        /// <summary>
        /// 如果显示界面，则显示小图标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="state"></param>
        private void Form1_Activated(object sender, EventArgs e)
        {
            if (IsShowByHide) {
                IsShowByHide = false;
                if (!notifyIcon1.Visible)
                {
                    notifyIcon1.Visible = true;
                }
            }
        }
        private void 显示主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!this.Visible)
                this.Show();  
            //重绘
            this.Refresh();
        }

        private void 隐藏主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 将窗体变为最小化
            HideForm();
        }

        private void 隐藏小图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
        }

        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// 双击图标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!this.Visible)
                this.Show();
            //重绘
            this.Refresh();
        }

        #endregion

        #region 隐藏窗体

        /// <summary>
        /// 最小化到托盘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 注意判断关闭事件reason来源于窗体按钮，否则用菜单退出时无法退出!
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // 取消关闭窗体
                e.Cancel = true;
                // 将窗体变为最小化
                HideForm();
            }
        }
        private void HideForm()
        {
            // 将窗体变为最小化
            this.Hide();
            IsShowByHide = true;
            //重绘
            this.Refresh();
            //释放窗体资源
            ClearMemory();
        }

        #endregion

        #region 内存回收

        [DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize")]
        public static extern int SetProcessWorkingSetSize(IntPtr process, int minSize, int maxSize);
        /// <summary>
        /// 释放内存
        /// </summary>
        public static void ClearMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
            }
        }
        /// <summary>
        /// 定时器回收
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_gc_Tick(object sender, EventArgs e)
        {
            ClearMemory();
        }

        #endregion

    }
}
