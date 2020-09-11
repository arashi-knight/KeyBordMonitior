using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyBordMonitor.Data;
using Sunny.UI;

namespace KeyBordMonitor
{
    public partial class BarChartData : UITitlePage
    {
        //数据上限
        private int MaxValue = int.MaxValue;
        //数据下限
        private int MinValue = int.MinValue;

        public BarChartData()
        {
            InitializeComponent();
        }

        #region 按键触发

        /// <summary>
        /// 当天数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton_today_Click(object sender, EventArgs e)
        {
            //初始化Option
            UIBarOption option = new UIBarOption();
            option.Title = new UITitle();
            option.Title.Text = "今日数据";
            option.Title.SubText = "BarChart";

            //添加数据
            int MaxCount = int.MinValue;
            int MinCount = int.MaxValue;

            var series = new UIBarSeries();
            series.Name = "Today";
            foreach (Key_Today key in KeyData_Today.todayData.KeyDatas)
            {
                //判断是否跳过数据(不在上下限之内或者被忽略)
                if (!IsInRange(key.Key_count) || key.IsIgnore)
                {
                    continue;
                }
                //获取最大最小数据
                MaxCount = MaxCount > key.Key_count ? MaxCount : key.Key_count;
                MinCount = MinCount < key.Key_count ? MinCount : key.Key_count;
                //获取常规数据
                series.AddData(key.Key_count);
                option.XAxis.Data.Add(key.Key_name);
            }
            option.Series.Add(series);
            //添加最大最小数据线
            if (MaxCount != int.MinValue)
                option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Red, Name = "最大为" + MaxCount, Value = MaxCount });
            if (MinCount != int.MaxValue)
                option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Blue, Name = "最小为" + MinCount, Value = MinCount, Left = UILeftAlignment.Right });

            //x轴上不显示标签
            option.XAxis.AxisLabel.Show = false;
            //显示tip
            option.ToolTip = new UIBarToolTip();
            //其他设置
            option.YAxis.Scale = true;
            option.XAxis.Name = "键名";
            option.YAxis.Name = "数值";

            uiBarChart1.SetOption(option);

            //更新详细信息
            uiLabel_total.Text = "总数：" + KeyData_Today.todayData.Total;
            uiLabel_date.Text = "日期：" + KeyData_Today.todayData.Date;


        }
        /// <summary>
        /// 总数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton_total_Click(object sender, EventArgs e)
        {
            //初始化Option
            UIBarOption option = new UIBarOption();
            option.Title = new UITitle();
            option.Title.Text = "总数据";
            option.Title.SubText = "BarChart";

            //添加数据
            int MaxCount = int.MinValue;
            int MinCount = int.MaxValue;

            var series = new UIBarSeries();
            series.Name = "Total";
            foreach (Key_Total key in KeyData_Total.totalData.KeyDatas)
            {
                //判断是否跳过数据(不在上下限之内或者被忽略)
                if (!IsInRange(key.Key_count) || key.IsIgnore)
                {
                    continue;
                }
                //获取最大最小数据
                MaxCount = MaxCount > key.Key_count ? MaxCount : key.Key_count;
                MinCount = MinCount < key.Key_count ? MinCount : key.Key_count;
                //获取常规数据
                series.AddData(key.Key_count);
                option.XAxis.Data.Add(key.Key_name);
            }
            option.Series.Add(series);
            //添加最大最小数据线
            if (MaxCount != int.MinValue)
                option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Red, Name = "最大为" + MaxCount, Value = MaxCount });
            if (MinCount != int.MaxValue)
                option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Blue, Name = "最小为" + MinCount, Value = MinCount, Left = UILeftAlignment.Right });

            //x轴上不显示标签
            option.XAxis.AxisLabel.Show = false;
            //显示tip
            option.ToolTip = new UIBarToolTip();
            //其他设置
            option.YAxis.Scale = true;
            option.XAxis.Name = "键名";
            option.YAxis.Name = "数值";

            uiBarChart1.SetOption(option);
            //更新数据面板
            uiLabel_total.Text = "总数：" + KeyData_Total.totalData.Total;
            uiLabel_date.Text = "日期：" + KeyData_Total.totalData.StartDate + "至" + KeyData_Total.totalData.EndDate;

        }
        /// <summary>
        /// 每日数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton_daily_Click(object sender, EventArgs e)
        {

            //添加数据
            int MaxCount = int.MinValue;
            int MinCount = int.MaxValue;
            Daily daily = null;

            List<string> items = new List<string>() { "7日", "15日", "30日" };
            int index = 0;
            int day = 0;
            if (this.ShowSelectDialog(ref index, items))
            {
                //根据index，确定day变量大小
                switch (index)
                {
                    case 0:
                        day = 7;
                        break;
                    case 1:
                        day = 15;
                        break;
                    case 2:
                        day = 30;
                        break;
                }

                //初始化Option
                UIBarOption option = new UIBarOption();
                option.Title = new UITitle();
                option.Title.Text = "每日数据";
                option.Title.SubText = "BarChart";

                //添加数据
                var series = new UIBarSeries();
                series.Name = "Total";

                int x = -1;
                for(int i = -day; i <= -1; i++)
                {
                    x = KeyData_DailyData.FindByRange(DateTime.Now.AddDays(i).Date.ToString("yyyy-MM-dd"), day);
                    if (x != -1)
                    {
                        daily = KeyData_DailyData.dailyData.dailies[x];
                        //获取常规数据
                        series.AddData(daily.Total);
                        option.XAxis.Data.Add(daily.Date);
                        //获取最大最小数据
                        MaxCount = MaxCount > daily.Total ? MaxCount : daily.Total;
                        MinCount = MinCount < daily.Total ? MinCount : daily.Total;

                    }
                    else
                    {
                        //自动补完
                        series.AddData(0);
                        option.XAxis.Data.Add(DateTime.Now.AddDays(i).Date.ToString("yyyy-MM-dd"));
                    }

                }

                //更新数据面板
                uiLabel_total.Text = "总数：不做计算";
                uiLabel_date.Text = "日期：" + DateTime.Now.AddDays(-day).Date.ToString("yyyy-MM-dd") + "至" + KeyData_DailyData.dailyData.EndDate;
                option.Series.Add(series);

                //添加最大最小数据线
                if(MaxCount != int.MinValue)
                    option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Red, Name = "最大为" + MaxCount, Value = MaxCount });
                if(MinCount != int.MaxValue)
                    option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Blue, Name = "最小为" + MinCount, Value = MinCount, Left = UILeftAlignment.Right });


                //x轴上不显示标签
                option.XAxis.AxisLabel.Show = false;
                //显示tip
                option.ToolTip = new UIBarToolTip();
                //其他设置
                option.YAxis.Scale = true;
                option.XAxis.Name = "日期";
                option.YAxis.Name = "数值";

                uiBarChart1.SetOption(option);


            }
        }

        #endregion

        #region 上下限

        /// <summary>
        /// 上下限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiTextBox_min_TextChanged(object sender, EventArgs e)
        {
            if(uiTextBox_min.Text == "")
            {
                MinValue = int.MinValue;
                return;
            }
            MinValue = uiTextBox_min.IntValue;

        }
        private void uiTextBox_max_TextChanged(object sender, EventArgs e)
        {
            if(uiTextBox_max.Text == "")
            {
                MaxValue = int.MaxValue;
                return;
            }
            MaxValue = uiTextBox_max.IntValue;
        }
        /// <summary>
        /// 该值是否在上下限之内
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        private bool IsInRange(int count)
        {
            if(count <= MaxValue && count >= MinValue)
            {
                return true;
            }
            return false;
        }

        #endregion

    }
}
