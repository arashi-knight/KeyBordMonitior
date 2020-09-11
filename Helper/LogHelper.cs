using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace KeyBordMonitor.Helper
{
    public class LogHelper
    {
        //在网站根目录下创建日志目录(bin文件夹→debug文件夹→logs文件夹)
        public static string path = AppDomain.CurrentDomain.BaseDirectory;

        //死锁
        public static object loglock = new object();
        /// <summary>
        /// 记录DEBUG
        /// </summary>
        /// <param name="content"></param>
        public static void Debug(string content)
        {
            WriteLog("DEBUG", content);
        }
        /// <summary>
        /// 记录信息
        /// </summary>
        /// <param name="content"></param>
        public static void Info(string content)
        {
            WriteLog("INFO", content);
        }
        /// <summary>
        /// 记录报错
        /// </summary>
        /// <param name="content"></param>
        public static void Error(string content)
        {
            WriteLog("ERROR", content);
        }

        protected static void WriteLog(string type, string content)
        {
            lock (loglock)
            {
                if (!Directory.Exists(path))//如果日志目录不存在就创建
                {
                    Directory.CreateDirectory(path);
                }

                string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff");//获取当前系统时间
                string filename = path +"MonitiorLog" + ".log";//用日期对日志文件命名

                //创建或打开日志文件，向日志文件末尾追加记录
                StreamWriter mySw = File.AppendText(filename);

                //向日志文件写入内容
                string write_content = time + " " + type + ": " + content;
                mySw.WriteLine(write_content);

                //关闭日志文件
                mySw.Close();
            }
        }
    }
}