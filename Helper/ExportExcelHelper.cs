//调用这个作者的
//https://www.cnblogs.com/zjbky/p/13098082.html
//

using KeyBordMonitor.Data;
using KeyBordMonitor.Helper;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

public class ExportExcelHelper
{
    public static string EXEPATH = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "EXCEL";


    /// <summary>
    /// 返回生成Excel文件byte流
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static byte[] GenExcelFileStream<T>(List<T> dataList,string ExcelName) where T : class
    {
        try
        {
            if (!Directory.Exists(EXEPATH))
            {
                Directory.CreateDirectory(EXEPATH);
            }
            var workbook = GenExcelWorkbook(dataList);
            var filePath = EXEPATH + "\\" + ExcelName;
            FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
            workbook.Write(stream);
            workbook.Close();
            stream.Close();

            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            var bytes = new byte[fileStream.Length];
            fileStream.Read(bytes, 0, bytes.Length);

            fileStream.Close();
            File.Delete(filePath);

            return bytes;
        }
        catch(Exception x)
        {
            if (ConfigureData.configure.IsLog)
            {
                LogHelper.Error(x.Message);
            }
            return null;
        }


    }

    /// <summary>
    /// 返回生成Excel文件地址
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="dataList"></param>
    /// <returns></returns>
    public static string GenExcelFile<T>(List<T> dataList,string ExcelName) where T : class
    {
        try
        {
            if (!Directory.Exists(EXEPATH))
            {
                Directory.CreateDirectory(EXEPATH);
            }
            var workbook = GenExcelWorkbook(dataList);
            var fileName = EXEPATH + "\\" + ExcelName;
            FileStream stream = new FileStream(fileName, FileMode.Create);
            workbook.Write(stream);
            workbook.Close();
            stream.Close();
            return fileName;
        }
        catch(Exception x)
        {
            if (ConfigureData.configure.IsLog)
            {
                LogHelper.Error(x.Message);
            }
            return null;
        }

    }

    /// <summary>
    /// 生成Workbook
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="dataList"></param>
    /// <returns></returns>
    private static XSSFWorkbook GenExcelWorkbook<T>(List<T> dataList)
    {
        try
        {
            var type = typeof(T);
            var props = type.GetProperties()
                .Where(t => t.GetCustomAttributes(typeof(ExportFieldAttribute)).Any())
                .ToArray();
            if (!props.Any())
            {
                throw new Exception("导出失败，导出模板中未标记要导出的数据列！");
            }
            var headerList = new List<ExportHeader>();
            foreach (var propertyInfo in props)
            {
                var exportAtt = (ExportFieldAttribute)propertyInfo.GetCustomAttributes(typeof(ExportFieldAttribute)).First();
                ExportHeader header = new ExportHeader()
                {
                    PropertyName = propertyInfo.Name,
                    HeaderName = exportAtt.Name,
                    Sort = exportAtt.Sort
                };
                headerList.Add(header);
            }

            headerList = headerList.OrderBy(t => t.Sort).ToList();

            XSSFWorkbook workbook = new XSSFWorkbook();
            var sheet = workbook.CreateSheet();

            //创建表头
            var rowIndex = 0;
            var sheetHeadRow = sheet.CreateRow(rowIndex);
            for (int i = 0; i < headerList.Count; i++)
            {
                var cell = sheetHeadRow.CreateCell(i);
                cell.SetCellValue(headerList[i].HeaderName);
            }
            rowIndex++;

            //写入数据
            foreach (var dataItem in dataList)
            {
                var dataProps = typeof(T).GetProperties();

                var sheetRow = sheet.CreateRow(rowIndex);
                for (int i = 0; i < headerList.Count; i++)
                {
                    var cell = sheetRow.CreateCell(i);
                    var value = dataProps.First(t => t.Name == headerList[i].PropertyName).GetValue(dataItem)?.ToString();
                    cell.SetCellValue(value);
                }

                rowIndex++;
            }
            return workbook;
        }
        catch(Exception x)
        {
            if (ConfigureData.configure.IsLog)
            {
                LogHelper.Error(x.Message);
            }
            return null;
        }



    }

    private class ExportHeader
    {
        /// <summary>
        /// 导出字段属性名称
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// 导出字段标题名称
        /// </summary>
        public string HeaderName { get; set; }

        /// <summary>
        /// 导出字段显示顺序
        /// </summary>
        public int Sort { get; set; }
    }
}



/// <summary>
/// 导出字段标识
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class ExportFieldAttribute : System.Attribute
{
    /// <summary>
    /// 导出字段顺序
    /// </summary>
    public int Sort { get; set; }

    /// <summary>
    /// 导出字段名称
    /// </summary>
    public string Name { get; set; }

}