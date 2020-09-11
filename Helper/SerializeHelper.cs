using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using KeyBordMonitor.Data;
using Sunny.UI;

namespace KeyBordMonitor.Helper
{
    public static class SerializeHelper
    {
        public static string EXEpath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Data";

        /// <summary>
        /// 将目标序列化为XML格式的文件，请确保要创建的文件不存在！
        /// </summary>
        /// <typeparam name="T">需要序列号的目标类型</typeparam>
        /// <param name="filePath">保存的文件路径</param>
        /// <param name="target">序列号的目标</param>
        /// <param name="fileMode">文件操作模式</param>
        public static void Serializer<T>(string filePath, T target, FileMode fileMode)
        {
            filePath = EXEpath + "\\" + filePath;

            try
            {
                if (!Directory.Exists(EXEpath))
                {
                    Directory.CreateDirectory(EXEpath);
                }

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));     //初始化工具
                FileStream fileStream = new FileStream(filePath, fileMode);     //使用文件流创建文件
                xmlSerializer.Serialize(fileStream, target);    //序列化并保存
                fileStream.Close();     //关闭文件流
                fileStream.Dispose();   //销毁文件流
            }
            catch(Exception x)
            {
                //记录日志
                if (ConfigureData.configure.IsLog)
                {
                    LogHelper.Error(x.Message);
                }
                throw;
            }
        }

        /// <summary>
        /// 将XML格式的文件反序列化为目标类型的数据
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <param name="filePath">文件路径</param>
        /// <returns>返回目标类型的数据</returns>
        public static T Deserializer<T>(string filePath)
        {
            filePath = EXEpath + "\\" + filePath;

            T result;
            try
            {
                if (!Directory.Exists(EXEpath))
                {
                    Directory.CreateDirectory(EXEpath);
                }

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));     //初始化工具
                FileStream fileStream = new FileStream(filePath, FileMode.Open);    //使用文件流打开文件
                result = (T)xmlSerializer.Deserialize(fileStream);    //反序列化并保存
                fileStream.Close();     //关闭文件流
                fileStream.Dispose();   //销毁文件流
            }
            catch (Exception x)
            {
                //记录日志
                if (ConfigureData.configure.IsLog)
                {
                    LogHelper.Error(x.Message);
                }
                throw;
            }

            return result;      //返回目标
        }
        /// <summary>
        /// 文件是否存在
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static bool Exist(string filePath)
        {
            filePath = EXEpath + "\\" + filePath;
            if (File.Exists(filePath))
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
