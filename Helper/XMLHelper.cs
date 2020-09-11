using KeyBordMonitor.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace KeyBordMonitor.Helper
{
    public class XMLHelper
    {
		//xml保存地址（程序所在的文件夹）（开机启动，必须要绝对路径草）
		private static string XMlPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"Data\";


		/// <summary>
		/// 初始化xml文档，创建users文件
		/// </summary>
		public static void CreateXmlFile(string XMLName)
		{
			XmlDocument xmlDocument = new XmlDocument();
			//创建类型声明节点
			XmlNode node = xmlDocument.CreateXmlDeclaration("1.0", "utf-8", "");
			xmlDocument.AppendChild(node);
			//创建根节点
			XmlNode root = xmlDocument.CreateElement("KeyBord");
			xmlDocument.AppendChild(root);
			//创建xml文件
			try
			{
				if (!Directory.Exists(XMlPath))
				{
					Directory.CreateDirectory(XMlPath);
				}
				xmlDocument.Save(XMlPath + XMLName);
			}
			catch (Exception e)
			{
				if (ConfigureData.configure.IsLog)
				{
					LogHelper.Error(e.Message);
				}
			}
		}
		/// <summary>
		/// 在parentNode节点下创建子节点，并返回子节点
		/// </summary>
		/// <param name="xmlDocument"></param>
		/// <param name="parentNode"></param>
		/// <param name="key"></param>
		/// <param name="value"></param>
		/// <returns>返回子节点</returns>
		public static XmlNode CreateNode(XmlDocument xmlDocument, XmlNode parentNode, string key, object value)
		{
			XmlNode node = xmlDocument.CreateNode(XmlNodeType.Element, key, null);
			node.InnerText = value.ToString();
			parentNode.AppendChild(node);
			return node;
		}
		/// <summary>
		/// 更新XML文档，基础的
		/// </summary>
		/// <param name="XMLName"></param>
		/// <param name="keys"></param>
		/// <param name="values"></param>
		public static void UpdateXML(string XMLName,List<string> keys,List<string> values)
        {
			//若XML文件不存在，创建XML文件并初始化
			if (!File.Exists(XMlPath + XMLName))
			{
				CreateXmlFile(XMLName);
			}
			//读取XML文件
			XmlDocument document = new XmlDocument();
			document.Load(XMlPath + XMLName);

			XmlNodeList node = null;
			for(int i = 0;i < keys.Count && i < values.Count; i++)
            {
				node = document.GetElementsByTagName(keys[i]);
				if(node.Count != 0)
                {
					node[0].InnerText = values[i];
                }
                else
                {
					CreateNode(document, document.FirstChild, keys[i], values[i]);
                }
			}
			document.Save(XMlPath + XMLName);

		}
		/// <summary>
		/// 更新key节点下，多个value值
		/// </summary>
		/// <param name="XMLName"></param>
		/// <param name="keys"></param>
		/// <param name="values"></param>
		public static void UpdateXML(string XMLName,List<string> keys,List<List<string>> values)
        {

        }
		/// <summary>
		/// 根据XML名字，返回DataSet
		/// </summary>
		/// <param name="XMLName"></param>
		/// <returns></returns>
		public static DataSet GetXML(string XMLName)
        {
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(XMlPath + XMLName);
			return dataSet;
        }
		/// <summary>
		/// 根据XML名字和keys值，返回value的list
		/// </summary>
		/// <param name="XMLName">XML名字</param>
		/// <param name="keys">要查询的key值</param>
		/// <returns></returns>
		public static List<string> GetNodes(string XMLName,List<string> keys)
        {
			List<string> values = new List<string>();

			//若XML文件不存在，返回null
			if (!File.Exists(XMlPath + XMLName))
			{
				return null;
			}

			//读取XML文件
			XmlDocument document = new XmlDocument();
			document.Load(XMlPath + XMLName);

			XmlNodeList nodeList = null;
			for (int i = 0; i < keys.Count; i++)
			{
				nodeList = document.GetElementsByTagName(keys[i]);
				if (nodeList.Count != 0)
				{
					//如果key值存在，取第一个key对应的value
					values.Add(nodeList[0].InnerText);
				}
				else
				{
					//如果key值不存在，取""
					values.Add("");
				}
			}

			return values;
		}
		/// <summary>
		/// 根据XML名字和keys值，返回value
		/// </summary>
		/// <param name="XMLName">XML文件名字</param>
		/// <param name="keys">查找的key</param>
		/// <returns></returns>
		public static string GetNode(string XMLName,string keys)
		{
			string values = null;

			//若XML文件不存在，返回null
			if (!File.Exists(XMlPath + XMLName))
			{
				return null;
			}

			//读取XML文件
			XmlDocument document = new XmlDocument();
			document.Load(XMlPath + XMLName);

			XmlNodeList nodeList = null;

			nodeList = document.GetElementsByTagName(keys);
			if (nodeList.Count != 0)
			{
				//如果key值存在，取第一个key对应的value
				values = nodeList[0].InnerText;
			}

			return values;
		}
	}
}
