using KeyBordMonitor.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace KeyBordMonitor.Data
{
    public static class KeyData_Total
    {
        //今日数据
        public static KeyList_Total totalData = new KeyList_Total();
        //XML文件名字
        private static string XMLName = "totalData.xml";
        //EXCEL文件名字
        private static string ExcelName = "totalData.xlsx";

        /// <summary>
        /// 根据key值返回所在位置
        /// </summary>
        /// <param name="key">要查找的key值</param>
        /// <returns>list中所在的位置，如果没找到，返回-1</returns>
        public static int FindKey(string key)
        {
            for (int i = 0; i < totalData.KeyDatas.Count; i++)
            {
                if (key == totalData.KeyDatas[i].Key_name)
                {
                    return i;
                }
            }
            //如果没找到，返回-1
            return -1;
        }
        /// <summary>
        /// 序列化读入数据
        /// </summary>
        /// <param name="dataSet"></param>
        public static void LoadKeyData()
        {
            //若XML文件存在，从XML文件中序列化读入
            if (SerializeHelper.Exist(XMLName))
            {
                totalData = SerializeHelper.Deserializer<KeyList_Total>(XMLName);
            }
            //若不存在，初始化，并保存
            else
            {
                //初始化
                totalData = new KeyList_Total(new List<Key_Total> {
                                               new Key_Total(Keys.A),//0
											   new Key_Total(Keys.B),//1
											   new Key_Total(Keys.C),//2
											   new Key_Total(Keys.D),//3
											   new Key_Total(Keys.E),	//4
											   new Key_Total(Keys.F),//5
											   new Key_Total(Keys.G),//6
											   new Key_Total(Keys.H),//7
											   new Key_Total(Keys.I),//8
											   new Key_Total(Keys.J),//9
											   new Key_Total(Keys.K),//10
											   new Key_Total(Keys.L),//11
											   new Key_Total(Keys.M),//12
											   new Key_Total(Keys.N),//13
											   new Key_Total(Keys.O),//14
											   new Key_Total(Keys.P),//15
											   new Key_Total(Keys.Q),//16
											   new Key_Total(Keys.R),//17
											   new Key_Total(Keys.S),//18
											   new Key_Total(Keys.T),//19
											   new Key_Total(Keys.U),//20
											   new Key_Total(Keys.V),//21
											   new Key_Total(Keys.W),//22
											   new Key_Total(Keys.X),//23
											   new Key_Total(Keys.Y),//24
											   new Key_Total(Keys.Z),//25


											   new Key_Total(Keys.Back),//26
											   new Key_Total(Keys.Capital),//27 ------大小写
											   new Key_Total(Keys.ControlKey),//28 ------ Ctrl
											   new Key_Total(Keys.Delete),//29 ----- Delete
											   new Key_Total(Keys.Decimal),//30 ------ 句号
											   new Key_Total(Keys.Divide),//31 ------除
											   new Key_Total(Keys.End),//32 ----END
											   new Key_Total(Keys.Enter),//33 
											   new Key_Total(Keys.Escape),//34
											   new Key_Total(Keys.Home),//35 -----Home
											   new Key_Total(Keys.Insert),//36
											   new Key_Total(Keys.LMenu),//37 -----左ALT
											   new Key_Total(Keys.RMenu),//38 -----右ALT
											   new Key_Total(Keys.LShiftKey),//39
											   new Key_Total(Keys.RShiftKey),//40
											   new Key_Total(Keys.LWin),//41
											   new Key_Total(Keys.RWin),//42
											   new Key_Total(Keys.PageDown),//43
											   new Key_Total(Keys.PageUp),//44
											   new Key_Total(Keys.Space),//45
											   new Key_Total(Keys.Subtract),//46
											   new Key_Total(Keys.Tab),
                                               new Key_Total(Keys.Separator),

                                               new Key_Total(Keys.NumLock),
                                               new Key_Total(Keys.NumPad0),
                                               new Key_Total(Keys.NumPad1),
                                               new Key_Total(Keys.NumPad2),
                                               new Key_Total(Keys.NumPad3),
                                               new Key_Total(Keys.NumPad4),
                                               new Key_Total(Keys.NumPad5),
                                               new Key_Total(Keys.NumPad6),
                                               new Key_Total(Keys.NumPad7),
                                               new Key_Total(Keys.NumPad8),
                                               new Key_Total(Keys.NumPad9),

                                               new Key_Total(Keys.Up),
                                               new Key_Total(Keys.Down),
                                               new Key_Total(Keys.Left),
                                               new Key_Total(Keys.Right),

                                               new Key_Total(Keys.F1),
                                               new Key_Total(Keys.F2),
                                               new Key_Total(Keys.F3),
                                               new Key_Total(Keys.F4),
                                               new Key_Total(Keys.F5),
                                               new Key_Total(Keys.F6),
                                               new Key_Total(Keys.F7),
                                               new Key_Total(Keys.F8),
                                               new Key_Total(Keys.F9),
                                               new Key_Total(Keys.F10),
                                               new Key_Total(Keys.F11),
                                               new Key_Total(Keys.F12),

                                               new Key_Total(Keys.D0),
                                               new Key_Total(Keys.D1),
                                               new Key_Total(Keys.D2),
                                               new Key_Total(Keys.D3),
                                               new Key_Total(Keys.D4),
                                               new Key_Total(Keys.D5),
                                               new Key_Total(Keys.D6),
                                               new Key_Total(Keys.D7),
                                               new Key_Total(Keys.D8),
                                               new Key_Total(Keys.D9),

                                               new Key_Total(Keys.Multiply),
                                               new Key_Total(Keys.Add),
                                               new Key_Total(Keys.Oem1),
                                               new Key_Total(Keys.Oem5),
                                               new Key_Total(Keys.Oem6),
                                               new Key_Total(Keys.Oem7),
                                               new Key_Total(Keys.OemOpenBrackets),
                                               new Key_Total(Keys.OemQuestion),
                                               new Key_Total(Keys.OemPeriod),
                                               new Key_Total(Keys.Oemcomma),
                                               new Key_Total(Keys.Oemtilde),
                                               new Key_Total(Keys.ShiftKey),
                                               new Key_Total(Keys.Oemplus),
                                               new Key_Total(Keys.OemMinus)


                });
                //保存
                SaveKeyData();
            }

        }
        /// <summary>
        /// 通过序列化，保存数据
        /// </summary>
        public static void SaveKeyData()
        {
            SerializeHelper.Serializer<KeyList_Total>(XMLName, totalData, FileMode.Create);
        }
        /// <summary>
        /// 设置为null，减少内存占用
        /// </summary>
        public static void Clear()
        {
            totalData = null;
        }
        /// <summary>
        /// 重置
        /// </summary>
        public static void Reset()
        {
            //初始化
            totalData = new KeyList_Total(new List<Key_Total> {
                                               new Key_Total(Keys.A),//0
											   new Key_Total(Keys.B),//1
											   new Key_Total(Keys.C),//2
											   new Key_Total(Keys.D),//3
											   new Key_Total(Keys.E),	//4
											   new Key_Total(Keys.F),//5
											   new Key_Total(Keys.G),//6
											   new Key_Total(Keys.H),//7
											   new Key_Total(Keys.I),//8
											   new Key_Total(Keys.J),//9
											   new Key_Total(Keys.K),//10
											   new Key_Total(Keys.L),//11
											   new Key_Total(Keys.M),//12
											   new Key_Total(Keys.N),//13
											   new Key_Total(Keys.O),//14
											   new Key_Total(Keys.P),//15
											   new Key_Total(Keys.Q),//16
											   new Key_Total(Keys.R),//17
											   new Key_Total(Keys.S),//18
											   new Key_Total(Keys.T),//19
											   new Key_Total(Keys.U),//20
											   new Key_Total(Keys.V),//21
											   new Key_Total(Keys.W),//22
											   new Key_Total(Keys.X),//23
											   new Key_Total(Keys.Y),//24
											   new Key_Total(Keys.Z),//25


											   new Key_Total(Keys.Back),//26
											   new Key_Total(Keys.Capital),//27 ------大小写
											   new Key_Total(Keys.ControlKey),//28 ------ Ctrl
											   new Key_Total(Keys.Delete),//29 ----- Delete
											   new Key_Total(Keys.Decimal),//30 ------ 句号
											   new Key_Total(Keys.Divide),//31 ------除
											   new Key_Total(Keys.End),//32 ----END
											   new Key_Total(Keys.Enter),//33 
											   new Key_Total(Keys.Escape),//34
											   new Key_Total(Keys.Home),//35 -----Home
											   new Key_Total(Keys.Insert),//36
											   new Key_Total(Keys.LMenu),//37 -----左ALT
											   new Key_Total(Keys.RMenu),//38 -----右ALT
											   new Key_Total(Keys.LShiftKey),//39
											   new Key_Total(Keys.RShiftKey),//40
											   new Key_Total(Keys.LWin),//41
											   new Key_Total(Keys.RWin),//42
											   new Key_Total(Keys.PageDown),//43
											   new Key_Total(Keys.PageUp),//44
											   new Key_Total(Keys.Space),//45
											   new Key_Total(Keys.Subtract),//46
											   new Key_Total(Keys.Tab),
                                               new Key_Total(Keys.Separator),

                                               new Key_Total(Keys.NumLock),
                                               new Key_Total(Keys.NumPad0),
                                               new Key_Total(Keys.NumPad1),
                                               new Key_Total(Keys.NumPad2),
                                               new Key_Total(Keys.NumPad3),
                                               new Key_Total(Keys.NumPad4),
                                               new Key_Total(Keys.NumPad5),
                                               new Key_Total(Keys.NumPad6),
                                               new Key_Total(Keys.NumPad7),
                                               new Key_Total(Keys.NumPad8),
                                               new Key_Total(Keys.NumPad9),

                                               new Key_Total(Keys.Up),
                                               new Key_Total(Keys.Down),
                                               new Key_Total(Keys.Left),
                                               new Key_Total(Keys.Right),

                                               new Key_Total(Keys.F1),
                                               new Key_Total(Keys.F2),
                                               new Key_Total(Keys.F3),
                                               new Key_Total(Keys.F4),
                                               new Key_Total(Keys.F5),
                                               new Key_Total(Keys.F6),
                                               new Key_Total(Keys.F7),
                                               new Key_Total(Keys.F8),
                                               new Key_Total(Keys.F9),
                                               new Key_Total(Keys.F10),
                                               new Key_Total(Keys.F11),
                                               new Key_Total(Keys.F12),

                                               new Key_Total(Keys.D0),
                                               new Key_Total(Keys.D1),
                                               new Key_Total(Keys.D2),
                                               new Key_Total(Keys.D3),
                                               new Key_Total(Keys.D4),
                                               new Key_Total(Keys.D5),
                                               new Key_Total(Keys.D6),
                                               new Key_Total(Keys.D7),
                                               new Key_Total(Keys.D8),
                                               new Key_Total(Keys.D9),

                                               new Key_Total(Keys.Multiply),
                                               new Key_Total(Keys.Add),
                                               new Key_Total(Keys.Oem1),
                                               new Key_Total(Keys.Oem5),
                                               new Key_Total(Keys.Oem6),
                                               new Key_Total(Keys.Oem7),
                                               new Key_Total(Keys.OemOpenBrackets),
                                               new Key_Total(Keys.OemQuestion),
                                               new Key_Total(Keys.OemPeriod),
                                               new Key_Total(Keys.Oemcomma),
                                               new Key_Total(Keys.Oemtilde),
                                               new Key_Total(Keys.ShiftKey),
                                               new Key_Total(Keys.Oemplus),
                                               new Key_Total(Keys.OemMinus)


                });
            //保存
            SaveKeyData();
        }
        /// <summary>
        /// 重置计数数据
        /// </summary>
        public static void ResetCount()
        {
            for(int i = 0;i< totalData.KeyDatas.Count; i++)
            {
                totalData.KeyDatas[i].Key_count = 0;
            }
            totalData.Total = 0;
            totalData.StartDate = DateTime.Today.ToString("yyyy-MM-dd");
            totalData.EndDate = DateTime.Today.ToString("yyyy-MM-dd");

            SaveKeyData();
        }
        /// <summary>
        /// 过了一天，更新数据（把昨天的当天数据加到总数据里）
        /// </summary>
        public static void UpdateData()
        {
            //更新结束日期
            totalData.EndDate = KeyData_Today.todayData.Date;
            //更新数据
            totalData.Total += KeyData_Today.todayData.Total;

            for(int i = 0; i < totalData.KeyDatas.Count && i < KeyData_Today.todayData.KeyDatas.Count; i++)
            {
                totalData.KeyDatas[i].Key_count += KeyData_Today.todayData.KeyDatas[i].Key_count;
            }

        }
        /// <summary>
        /// 导出到EXCEL
        /// </summary>
        public static string ExportToExcel()
        {
            return ExportExcelHelper.GenExcelFile<Key_Total>(totalData.KeyDatas, ExcelName);
        }
    }

    /// <summary>
    /// 按键数据
    /// </summary>
    public class KeyList_Total
    {
        public KeyList_Total(List<Key_Total> keyDatas)
        {
            KeyDatas = keyDatas;
            Total = 0;
            StartDate = DateTime.Today.ToString("yyyy-MM-dd");
            EndDate = DateTime.Today.ToString("yyyy-MM-dd");
        }

        public KeyList_Total()
        {
            
        }

        /// <summary>
        /// 按键数据列表
        /// </summary>
        public List<Key_Total> KeyDatas { get; set; }
        /// <summary>
        /// 总数
        /// </summary>
        public int Total { get; set; }
        /// <summary>
        /// 开始日期
        /// </summary>
        public string StartDate { get; set; }
        /// <summary>
        /// 结束日期
        /// </summary>
        public string EndDate { get; set; }
    }

    /// <summary>
    /// 按键数据格式
    /// </summary>
    public class Key_Total
    {
        public Key_Total()
        {
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="key"></param> 
        public Key_Total(Keys key)
        {
            Key_name = key.ToString();
            Key_count = 0;
            IsIgnore = false;
        }
        
        /// <summary>
        /// 键名
        /// </summary>
        [ExportField(Name = "键位",Sort = 0)]
        public string Key_name { get; set; }
        /// <summary>
        /// 所有的计数
        /// </summary>
        [ExportField(Name = "计数", Sort = 1)]
        public int Key_count { get; set; }
        /// <summary>
        /// 是否忽略该按键
        /// </summary>
        [ExportField(Name = "是否忽略", Sort = 2)]
        public bool IsIgnore { get; set; }

    }
}
