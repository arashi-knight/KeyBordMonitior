using KeyBordMonitor.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KeyBordMonitor.Data
{
    public static class KeyData_DailyData
    {

        //定义静态变量
        public static DailyList dailyData = new DailyList();
        //XML文件名字
        private static string XMLName = "dailyData.xml";
        //Excel文件名字
        private static string ExcelName = "dailyData.xlsx";

        /// <summary>
        /// 序列化读入数据
        /// </summary>
        /// <param name="dataSet"></param>
        public static void LoadKeyData()
        {
            //若XML文件存在，从XML文件中序列化读入
            if (SerializeHelper.Exist(XMLName))
            {
                /*XmlSerializer ser = new XmlSerializer(typeof(DailyList));
                dailyData = (DailyList)ser.Deserialize(File.OpenRead(XMLPath));*/
                dailyData = SerializeHelper.Deserializer<DailyList>(XMLName);
            }
            //若不存在，初始化，并保存
            else
            {
                //初始化
                //这个本来就初始化了，所以不变了
                //保存
                SaveKeyData();
            }

        }
        /// <summary>
        /// 通过序列化，保存数据
        /// </summary>
        public static void SaveKeyData()
        {
            /*XmlSerializer ser = new XmlSerializer(typeof(DailyList));
            FileStream fs = File.Create(XMLPath);
            ser.Serialize(fs, dailyData);
            fs.Close();
            fs.Dispose();*/
            SerializeHelper.Serializer<DailyList>(XMLName, dailyData, FileMode.Create);
        }
        /// <summary>
        /// 设置为null，减少内存占用
        /// </summary>
        public static void Clear()
        {
            dailyData = null;
        }
        /// <summary>
        /// 重置
        /// </summary>
        public static void Reset()
        {
            //初始化
            dailyData = new DailyList();
            //保存
            SaveKeyData();
        }
        /// <summary>
        /// 过了一天，数据递增
        /// </summary>
        public static void UpdateData()
        {
            //更新结束日期
            dailyData.EndDate = KeyData_Today.todayData.Date;
            //更新数据
            dailyData.dailies.Add(new Daily(KeyData_Today.todayData.Total, KeyData_Today.todayData.Date));
        }
        /// <summary>
        /// 根据范围搜索是否存在日期
        /// </summary>
        /// <param name="Date">搜索的日期</param>
        /// <param name="range">范围</param>
        /// <returns>存在范围所在位置，不存在返回-1</returns>
        public static int FindByRange(string Date,int range)
        {
            for(int i = dailyData.dailies.Count-1;i >= dailyData.dailies.Count-range && i > 0; i--)
            {
                if (dailyData.dailies[i].Date.Equals(Date))
                {
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// 导出到EXCEL
        /// </summary>
        public static string ExportToExcel()
        {
            return ExportExcelHelper.GenExcelFile<Daily>(dailyData.dailies, ExcelName);
        }

    }

    [Serializable]
    public class DailyList
    {
        public DailyList()
        {
            this.dailies = new List<Daily> { };
            StartDate = DateTime.Today.ToString("yyyy-MM-dd");
            EndDate = DateTime.Today.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// 每日数据列表
        /// </summary>
        public List<Daily> dailies { get; set; }
        /// <summary>
        /// 开始日期
        /// </summary>
        public string StartDate { get; set; }
        /// <summary>
        /// 结束日期
        /// </summary>
        public string EndDate { get; set; }
    }

    [Serializable]
    /// <summary>
    /// 每日的总数记录
    /// </summary>
    public class Daily
    {
        public Daily()
        {

        }

        public Daily(int total, string date)
        {
            Total = total;
            Date = date;
        }

        /// <summary>
        /// 当天总数
        /// </summary>
        [ExportField(Name = "当天总数", Sort = 0)]
        public int Total { get; set; }
        /// <summary>
        /// 当天日期
        /// </summary>
        [ExportField(Name = "当天日期", Sort = 1)]
        public string Date { get; set; }
    }
}
