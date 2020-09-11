using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using KeyBordMonitor.Data;
using KeyBordMonitor.Helper;
using KeyBordMonitor.Pages;
using Sunny.UI;

namespace KeyBordMonitor
{
    public partial class Setting : UITitlePage
    {

        public Setting()
        {
            InitializeComponent();

            Init();
        }

        #region 初始化相关

        /// <summary>
        /// 初始化
        /// </summary>
        public override void Init()
        {
            base.Init();
            //读取配置文件
            ConfigureData.LoadConfigure();
            //初始化开关
            InitSwitch();
            //查看开机启动项是否改变
            UpdateAutoOpen();
        }
        /// <summary>
        /// 初始化开关
        /// </summary>
        public void InitSwitch()
        {
            uiSwitch_autoOpen.Active = ConfigureData.configure.isAutoOpen;
            uiSwitch_hideIcon.Active = ConfigureData.configure.isHideIcon;
            uiSwitch_isLog.Active = ConfigureData.configure.IsLog;
        }
        /// <summary>
        /// 判断程序是否改变了位置，并更新位置
        /// </summary>
        private void UpdateAutoOpen()
        {
            //如果程序地址/程序名变更
            if(ConfigureData.configure.EXEPath != Process.GetCurrentProcess().MainModule.FileName)
            {
                //如果是开机启动，需要重新设置
                if (ConfigureData.configure.isAutoOpen)
                {
                    //删除原有的开机启动项
                    SystemHelper.SetAutoRun(ConfigureData.configure.EXEPath, ConfigureData.configure.EXEName, false);
                    //获得新的地址
                    //程序地址
                    string path = Process.GetCurrentProcess().MainModule.FileName;
                    //程序名字
                    string name = System.IO.Path.GetFileName(path);
                    //重新设置新的开机启动项
                    if (!SystemHelper.IsSetAutoRun(path, name))
                    {
                        SystemHelper.SetAutoRun(path, name, true);
                    }
                }
                //更新EXEPath和EXEName
                ConfigureData.configure.EXEPath = Process.GetCurrentProcess().MainModule.FileName;
                ConfigureData.configure.EXEName = System.IO.Path.GetFileName(ConfigureData.configure.EXEPath);
                //更新XML文档
                ConfigureData.SaveConfigure();
            }
        }

        #endregion

        #region 基础设置&热力图设置

        /// <summary>
        /// 开机启动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="value"></param>
        private void uiSwitch_autoOpen_MouseClick(object sender, MouseEventArgs e)
        {
            //程序地址
            string path = Process.GetCurrentProcess().MainModule.FileName;
            //程序名字
            string name = System.IO.Path.GetFileName(path);
            //更新配置表
            ConfigureData.configure.isAutoOpen = uiSwitch_autoOpen.Active;
            ConfigureData.SaveConfigure();
            //设置程序是否自启动
            SystemHelper.SetAutoRun(path, name, uiSwitch_autoOpen.Active);
        }
        /// <summary>
        /// 隐藏小图标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="value"></param>
        private void uiSwitch_hideIcon_MouseClick(object sender, MouseEventArgs e)
        {
            ConfigureData.configure.isHideIcon = uiSwitch_hideIcon.Active;
            //更新XML文档
            ConfigureData.SaveConfigure();
        }
        /// <summary>
        /// 是否记录日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="value"></param>
        private void uiSwitch_isLog_ValueChanged(object sender, bool value)
        {
            ConfigureData.configure.IsLog = value;
        }
        /// <summary>
        /// 校对热力图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiSymbolButton_checkKeyBord_Click(object sender, EventArgs e)
        {
            CheckKeyBordPage checkKeyBord = new CheckKeyBordPage();
            checkKeyBord.ShowDialog();
        }
        /// <summary>
        /// 格式化数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiSymbolButton_clear_Click(object sender, EventArgs e)
        {
            List<string> items = new List<string> { "仅格式化计数数据", "格式化所有数据(包括坐标)" };
            int select = -1;
            if (this.ShowSelectDialog(ref select, items))
            {
                if (select == 0)//仅格式化计数数据
                {
                    KeyData_DailyData.Reset();
                    KeyData_Today.ResetCount();
                    KeyData_Total.ResetCount();
                }
                else if (select == 1)//格式化所有
                {
                    KeyData_DailyData.Reset();
                    KeyData_Today.Reset();
                    KeyData_Total.Reset();
                }
            }
        }
        /// <summary>
        /// 废物的小小梦想
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiSymbolButton_tea_Click(object sender, EventArgs e)
        {
            Tea tea = new Tea();
            tea.ShowDialog();
        }


        #endregion
        /// <summary>
        /// 导出为EXCEL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiSymbolButton_exportExcel_Click(object sender, EventArgs e)
        {
            string str = KeyData_DailyData.ExportToExcel();
            KeyData_Today.ExportToExcel();
            KeyData_Total.ExportToExcel();
            System.Diagnostics.Process.Start(Path.GetDirectoryName(str));
        }
    }
}
 