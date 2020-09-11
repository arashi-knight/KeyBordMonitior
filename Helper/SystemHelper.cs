using KeyBordMonitor.Data;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyBordMonitor.Helper
{
    public sealed class SystemHelper
    {
        private SystemHelper() { }

        /// <summary>
        /// 设置程序开机启动
        /// </summary>
        /// <param name="strAppPath">应用程序exe所在文件夹</param>
        /// <param name="strAppName">应用程序exe名称</param>
        /// <param name="bIsAutoRun">自动运行状态</param>
        public static void SetAutoRun(string strAppPath, string strAppName, bool bIsAutoRun)
        {
            //添加参数
            strAppPath = strAppPath + " -autorun";
            Console.WriteLine(strAppPath);
            try
            {
                if (string.IsNullOrWhiteSpace(strAppPath)
                    || string.IsNullOrWhiteSpace(strAppName))
                {
                    throw new Exception("应用程序路径或名称为空！");
                }

                RegistryKey reg = Registry.CurrentUser;
                RegistryKey run = reg.CreateSubKey(@"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\");

                if (bIsAutoRun)
                {
                    run.SetValue(strAppName, strAppPath);
                }
                else
                {
                    if (null != run.GetValue(strAppName))
                    {
                        run.DeleteValue(strAppName);
                    }
                }

                run.Close();
                reg.Close();
            }
            catch (Exception ex)
            {
                //记录日志
                if (ConfigureData.configure.IsLog)
                {
                    LogHelper.Error(ex.Message);
                }
                throw new Exception(ex.Message, ex);
            }
        }
        /// <summary>
        /// 判断是否设置了开机启动
        /// </summary>
        /// <param name="strAppPath">应用程序路径</param>
        /// <param name="strAppName">应用程序名称</param>
        /// <returns></returns>
        public static bool IsSetAutoRun(string strAppPath, string strAppName)
        {
            //添加参数
            strAppPath = strAppPath + " -autorun";

            try
            {
                RegistryKey reg = Registry.CurrentUser;
                RegistryKey software = reg.OpenSubKey(@"SOFTWARE");
                RegistryKey run = reg.OpenSubKey(@"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\");
                object key = run.GetValue(strAppName);
                software.Close();
                run.Close();
                if (null == key || !strAppPath.Equals(key.ToString()))
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                //记录日志
                if (ConfigureData.configure.IsLog)
                {
                    LogHelper.Error(ex.Message);
                }
                throw new Exception(ex.Message, ex);
            }
        }
        /// <summary>
        /// 判断是否是开机启动的
        /// </summary>
        /// <returns></returns>
        public static bool IsAutoRun()
        {

            string[] strArgs = Environment.GetCommandLineArgs();
            if (strArgs.Length > 1 && strArgs[1].Equals("-autorun"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
