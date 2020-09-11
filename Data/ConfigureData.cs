using KeyBordMonitor.Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KeyBordMonitor.Data
{
    public static class ConfigureData
    {
        /// <summary>
        /// XML文件的名字
        /// </summary>
        private static string XMLName = "Setting.xml";
        /// <summary>
        /// 配置数据
        /// </summary>
        public static Configure configure = new Configure();

        /// <summary>
        /// 保存配置文件
        /// </summary>
        public static void SaveConfigure()
        {
            SerializeHelper.Serializer<Configure>(XMLName, configure, FileMode.Create);
        }
        /// <summary>
        /// 读取配置文件
        /// </summary>
        public static void LoadConfigure()
        {
            if (SerializeHelper.Exist(XMLName))
            {
                configure = SerializeHelper.Deserializer<Configure>(XMLName);
            }
            else
            {
                SaveConfigure();
            }
        }

    }

    
    
    
    [Serializable]
    /// <summary>
    /// 程序配置属性
    /// </summary>
    public class Configure
    {
        /// <summary>
        /// 是否开机自动启动 默认为false
        /// </summary>
        [XmlElement("IsAutoOpen")]
        public bool isAutoOpen { get; set; }
        /// <summary>
        /// 是否隐藏icon 默认为false
        /// </summary>
        [XmlElement("IsHideIcon")]
        public bool isHideIcon { get; set; }
        /// <summary>
        /// 程序地址
        /// </summary>
        [XmlElement("EXEPath")]
        public string EXEPath { get; set; }
        /// <summary>
        /// 程序名
        /// </summary>
        [XmlElement("EXEName")]
        public string EXEName { get; set; }
        /// <summary>
        /// 是否记录日志 默认为true
        /// </summary>
        [XmlElement("IsLog")]
        public bool IsLog { get; set; }

        public Configure()
        {
            isAutoOpen = false;
            isHideIcon = false;
            EXEPath = Process.GetCurrentProcess().MainModule.FileName;
            EXEName = System.IO.Path.GetFileName(EXEPath);
            IsLog = true;
        }
    }
}
