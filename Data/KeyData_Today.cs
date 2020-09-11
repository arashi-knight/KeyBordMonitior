using KeyBordMonitor.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace KeyBordMonitor.Data
{

    public static class KeyData_Today
    {
        //今日数据
        public static KeyList_Today todayData = new KeyList_Today();
        //XML文件名字
        private static string XMLName = "todayData.xml";
        //EXCEL文件名字
        private static string ExcelName = "todayData.xlsx";

        /// <summary>
        /// 根据key值返回所在位置
        /// </summary>
        /// <param name="key">要查找的key值</param>
        /// <returns>list中所在的位置，如果没找到，返回-1</returns>
        public static int FindKey(string key)
        {
            for(int i = 0; i < todayData.KeyDatas.Count; i++)
            {
                if(key == todayData.KeyDatas[i].Key_name)
                {
                    return i;
                }
            }
            //如果没找到，返回-1
            return -1;
        }
        /// <summary>
        /// key按键次数+1
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int Increase(string key)
        {
            int i = FindKey(key);
            if(i != -1 && !todayData.KeyDatas[i].IsIgnore)
            {
                todayData.KeyDatas[i].Key_count++;
                todayData.Total++;
                return i;
            }
            else
            {
                return -1;
            }
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
                todayData = SerializeHelper.Deserializer<KeyList_Today>(XMLName);
            }
            //若不存在，初始化，并保存
            else
            {
                //初始化
                todayData = new KeyList_Today(new List<Key_Today> {
                                               new Key_Today(Keys.A),//0
											   new Key_Today(Keys.B),//1
											   new Key_Today(Keys.C),//2
											   new Key_Today(Keys.D),//3
											   new Key_Today(Keys.E),	//4
											   new Key_Today(Keys.F),//5
											   new Key_Today(Keys.G),//6
											   new Key_Today(Keys.H),//7
											   new Key_Today(Keys.I),//8
											   new Key_Today(Keys.J),//9
											   new Key_Today(Keys.K),//10
											   new Key_Today(Keys.L),//11
											   new Key_Today(Keys.M),//12
											   new Key_Today(Keys.N),//13
											   new Key_Today(Keys.O),//14
											   new Key_Today(Keys.P),//15
											   new Key_Today(Keys.Q),//16
											   new Key_Today(Keys.R),//17
											   new Key_Today(Keys.S),//18
											   new Key_Today(Keys.T),//19
											   new Key_Today(Keys.U),//20
											   new Key_Today(Keys.V),//21
											   new Key_Today(Keys.W),//22
											   new Key_Today(Keys.X),//23
											   new Key_Today(Keys.Y),//24
											   new Key_Today(Keys.Z),//25


											   new Key_Today(Keys.Back),//26
											   new Key_Today(Keys.Capital),//27 ------大小写
											   new Key_Today(Keys.ControlKey),//28 ------ Ctrl
											   new Key_Today(Keys.Delete),//29 ----- Delete
											   new Key_Today(Keys.Decimal),//30 ------ 句号
											   new Key_Today(Keys.Divide),//31 ------除
											   new Key_Today(Keys.End),//32 ----END
											   new Key_Today(Keys.Enter),//33 
											   new Key_Today(Keys.Escape),//34
											   new Key_Today(Keys.Home),//35 -----Home
											   new Key_Today(Keys.Insert),//36
											   new Key_Today(Keys.LMenu),//37 -----左ALT
											   new Key_Today(Keys.RMenu),//38 -----右ALT
											   new Key_Today(Keys.LShiftKey),//39
											   new Key_Today(Keys.RShiftKey),//40
											   new Key_Today(Keys.LWin),//41
											   new Key_Today(Keys.RWin),//42
											   new Key_Today(Keys.PageDown),//43
											   new Key_Today(Keys.PageUp),//44
											   new Key_Today(Keys.Space),//45
											   new Key_Today(Keys.Subtract),//46
											   new Key_Today(Keys.Tab),
                                               new Key_Today(Keys.Separator),

                                               new Key_Today(Keys.NumLock),
                                               new Key_Today(Keys.NumPad0),
                                               new Key_Today(Keys.NumPad1),
                                               new Key_Today(Keys.NumPad2),
                                               new Key_Today(Keys.NumPad3),
                                               new Key_Today(Keys.NumPad4),
                                               new Key_Today(Keys.NumPad5),
                                               new Key_Today(Keys.NumPad6),
                                               new Key_Today(Keys.NumPad7),
                                               new Key_Today(Keys.NumPad8),
                                               new Key_Today(Keys.NumPad9),

                                               new Key_Today(Keys.Up),
                                               new Key_Today(Keys.Down),
                                               new Key_Today(Keys.Left),
                                               new Key_Today(Keys.Right),

                                               new Key_Today(Keys.F1),
                                               new Key_Today(Keys.F2),
                                               new Key_Today(Keys.F3),
                                               new Key_Today(Keys.F4),
                                               new Key_Today(Keys.F5),
                                               new Key_Today(Keys.F6),
                                               new Key_Today(Keys.F7),
                                               new Key_Today(Keys.F8),
                                               new Key_Today(Keys.F9),
                                               new Key_Today(Keys.F10),
                                               new Key_Today(Keys.F11),
                                               new Key_Today(Keys.F12),

                                               new Key_Today(Keys.D0),
                                               new Key_Today(Keys.D1),
                                               new Key_Today(Keys.D2),
                                               new Key_Today(Keys.D3),
                                               new Key_Today(Keys.D4),
                                               new Key_Today(Keys.D5),
                                               new Key_Today(Keys.D6),
                                               new Key_Today(Keys.D7),
                                               new Key_Today(Keys.D8),
                                               new Key_Today(Keys.D9),

                                               new Key_Today(Keys.Multiply),
                                               new Key_Today(Keys.Add),
                                               new Key_Today(Keys.Oem1),
                                               new Key_Today(Keys.Oem5),
                                               new Key_Today(Keys.Oem6),
                                               new Key_Today(Keys.Oem7),
                                               new Key_Today(Keys.OemOpenBrackets),
                                               new Key_Today(Keys.OemQuestion),
                                               new Key_Today(Keys.OemPeriod),
                                               new Key_Today(Keys.Oemcomma),
                                               new Key_Today(Keys.Oemtilde),
                                               new Key_Today(Keys.ShiftKey),
                                               new Key_Today(Keys.Oemplus),
                                               new Key_Today(Keys.OemMinus)


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
            SerializeHelper.Serializer<KeyList_Today>(XMLName, todayData, FileMode.Create);
        }
        /// <summary>
        /// 设为null，减少内存占用
        /// </summary>
        public static void Clear()
        {
            todayData = null;
        }
        /// <summary>
        /// 重置当天计数数据
        /// </summary>
        public static void ResetCount()
        {
            //初始化
            for(int i = 0; i < todayData.KeyDatas.Count; i++)
            {
                todayData.KeyDatas[i].Key_count = 0;
            }
            todayData.Total = 0;
            todayData.Date = DateTime.Now.ToString("yyyy-MM-dd");
            //保存
            SaveKeyData();
        }
        /// <summary>
        /// 重置
        /// </summary>
        public static void Reset()
        {
            //初始化
            todayData = new KeyList_Today(new List<Key_Today> {
                                               new Key_Today(Keys.A),//0
											   new Key_Today(Keys.B),//1
											   new Key_Today(Keys.C),//2
											   new Key_Today(Keys.D),//3
											   new Key_Today(Keys.E),	//4
											   new Key_Today(Keys.F),//5
											   new Key_Today(Keys.G),//6
											   new Key_Today(Keys.H),//7
											   new Key_Today(Keys.I),//8
											   new Key_Today(Keys.J),//9
											   new Key_Today(Keys.K),//10
											   new Key_Today(Keys.L),//11
											   new Key_Today(Keys.M),//12
											   new Key_Today(Keys.N),//13
											   new Key_Today(Keys.O),//14
											   new Key_Today(Keys.P),//15
											   new Key_Today(Keys.Q),//16
											   new Key_Today(Keys.R),//17
											   new Key_Today(Keys.S),//18
											   new Key_Today(Keys.T),//19
											   new Key_Today(Keys.U),//20
											   new Key_Today(Keys.V),//21
											   new Key_Today(Keys.W),//22
											   new Key_Today(Keys.X),//23
											   new Key_Today(Keys.Y),//24
											   new Key_Today(Keys.Z),//25


											   new Key_Today(Keys.Back),//26
											   new Key_Today(Keys.Capital),//27 ------大小写
											   new Key_Today(Keys.ControlKey),//28 ------ Ctrl
											   new Key_Today(Keys.Delete),//29 ----- Delete
											   new Key_Today(Keys.Decimal),//30 ------ 句号
											   new Key_Today(Keys.Divide),//31 ------除
											   new Key_Today(Keys.End),//32 ----END
											   new Key_Today(Keys.Enter),//33 
											   new Key_Today(Keys.Escape),//34
											   new Key_Today(Keys.Home),//35 -----Home
											   new Key_Today(Keys.Insert),//36
											   new Key_Today(Keys.LMenu),//37 -----左ALT
											   new Key_Today(Keys.RMenu),//38 -----右ALT
											   new Key_Today(Keys.LShiftKey),//39
											   new Key_Today(Keys.RShiftKey),//40
											   new Key_Today(Keys.LWin),//41
											   new Key_Today(Keys.RWin),//42
											   new Key_Today(Keys.PageDown),//43
											   new Key_Today(Keys.PageUp),//44
											   new Key_Today(Keys.Space),//45
											   new Key_Today(Keys.Subtract),//46
											   new Key_Today(Keys.Tab),
                                               new Key_Today(Keys.Separator),

                                               new Key_Today(Keys.NumLock),
                                               new Key_Today(Keys.NumPad0),
                                               new Key_Today(Keys.NumPad1),
                                               new Key_Today(Keys.NumPad2),
                                               new Key_Today(Keys.NumPad3),
                                               new Key_Today(Keys.NumPad4),
                                               new Key_Today(Keys.NumPad5),
                                               new Key_Today(Keys.NumPad6),
                                               new Key_Today(Keys.NumPad7),
                                               new Key_Today(Keys.NumPad8),
                                               new Key_Today(Keys.NumPad9),

                                               new Key_Today(Keys.Up),
                                               new Key_Today(Keys.Down),
                                               new Key_Today(Keys.Left),
                                               new Key_Today(Keys.Right),

                                               new Key_Today(Keys.F1),
                                               new Key_Today(Keys.F2),
                                               new Key_Today(Keys.F3),
                                               new Key_Today(Keys.F4),
                                               new Key_Today(Keys.F5),
                                               new Key_Today(Keys.F6),
                                               new Key_Today(Keys.F7),
                                               new Key_Today(Keys.F8),
                                               new Key_Today(Keys.F9),
                                               new Key_Today(Keys.F10),
                                               new Key_Today(Keys.F11),
                                               new Key_Today(Keys.F12),

                                               new Key_Today(Keys.D0),
                                               new Key_Today(Keys.D1),
                                               new Key_Today(Keys.D2),
                                               new Key_Today(Keys.D3),
                                               new Key_Today(Keys.D4),
                                               new Key_Today(Keys.D5),
                                               new Key_Today(Keys.D6),
                                               new Key_Today(Keys.D7),
                                               new Key_Today(Keys.D8),
                                               new Key_Today(Keys.D9),

                                               new Key_Today(Keys.Multiply),
                                               new Key_Today(Keys.Add),
                                               new Key_Today(Keys.Oem1),
                                               new Key_Today(Keys.Oem5),
                                               new Key_Today(Keys.Oem6),
                                               new Key_Today(Keys.Oem7),
                                               new Key_Today(Keys.OemOpenBrackets),
                                               new Key_Today(Keys.OemQuestion),
                                               new Key_Today(Keys.OemPeriod),
                                               new Key_Today(Keys.Oemcomma),
                                               new Key_Today(Keys.Oemtilde),
                                               new Key_Today(Keys.ShiftKey),
                                               new Key_Today(Keys.Oemplus),
                                               new Key_Today(Keys.OemMinus)


                });
            //保存
            SaveKeyData();
        }
        /// <summary>
        /// 导出到EXCEL
        /// </summary>
        public static string ExportToExcel()
        {
            return ExportExcelHelper.GenExcelFile<Key_Today>(todayData.KeyDatas, ExcelName);
        }
    }


    [Serializable]
    public class KeyList_Today
    {
        public KeyList_Today(List<Key_Today> keyDatas)
        {
            KeyDatas = keyDatas;
            Total = 0;
            Date = DateTime.Today.ToString("yyyy-MM-dd");
        }

        public KeyList_Today()
        {
            
        }

        /// <summary>
        /// 按键数据列表
        /// </summary>
        public List<Key_Today> KeyDatas { get; set; }
        /// <summary>
        /// 总数
        /// </summary>
        public int Total { get; set; }
        /// <summary>
        /// 当天日期
        /// </summary>
        public string Date { get; set; }

    }

    [Serializable]
    /// <summary>
    /// 按键数据格式
    /// </summary>
    public class Key_Today
    {
        public Key_Today()
        {
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="key"></param> 
        public Key_Today(Keys key)
        {
            Key_name = key.ToString();
            Key_count = 0;
            Key_x = 0;
            Key_y = 0;
            IsIgnore = false;
        }

        /// <summary>
        /// 键位
        /// </summary>
        [ExportField(Name = "键位", Sort = 0)]
        public string Key_name { get; set; }
        /// <summary>
        /// 当天的计数
        /// </summary>
        [ExportField(Name = "计数", Sort = 1)]
        public int Key_count { get; set; }
        /// <summary>
        /// 热力图上x轴坐标
        /// </summary>
        [ExportField(Name = "X坐标", Sort = 2)]
        public int Key_x { get; set; }
        /// <summary>
        /// 热力图上y轴坐标
        /// </summary>
        [ExportField(Name = "Y坐标", Sort = 3)]
        public int Key_y { get; set; }
        /// <summary>
        /// 是否忽略该按键
        /// </summary>
        [ExportField(Name = "是否忽略", Sort = 4)]
        public bool IsIgnore { get; set; }
    }
    

}
