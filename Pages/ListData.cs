using KeyBordMonitor.Data;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyBordMonitor
{
    public partial class ListData : UITitlePage
    {

        public ListData()
        {
            InitializeComponent();
        }

        private void uiPagination1_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            uiDataGridView1.DataSource = pagingSource;
        }

        #region 按钮触发

        /// <summary>
        /// 当天数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton_today_Click(object sender, EventArgs e)
        {
            //清除旧数据
            uiDataGridView1.ClearAll();
            uiPagination1.DataSource = null;
            //添加新列
            uiDataGridView1.AddColumn("键名", "Key_name").SetFixedMode(100);
            uiDataGridView1.AddColumn("计数", "Key_count").SetFixedMode(200);
            uiDataGridView1.AddColumn("热力图X坐标", "Key_x").SetFixedMode(150);
            uiDataGridView1.AddColumn("热力图Y坐标", "Key_y").SetFixedMode(150);
            uiDataGridView1.AddColumn("是否忽略", "IsIgnore");
            uiDataGridView1.ReadOnly = true;
            //绑定数据
            uiPagination1.DataSource = KeyData_Today.todayData.KeyDatas;
            uiPagination1.ActivePage = 1;
            //更新DataGridView
            uiDataGridView1.DataSource = uiPagination1.PageDataSource;
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
            //清除旧数据
            uiDataGridView1.ClearAll();
            uiPagination1.DataSource = null;
            //添加新列
            uiDataGridView1.AddColumn("键名", "Key_name").SetFixedMode(100);
            uiDataGridView1.AddColumn("计数", "Key_count").SetFixedMode(200);
            uiDataGridView1.AddColumn("是否忽略", "IsIgnore");
            uiDataGridView1.ReadOnly = true;
            //绑定数据
            uiPagination1.DataSource = KeyData_Total.totalData.KeyDatas;
            uiPagination1.ActivePage = 1;
            //更新DataGridView
            uiDataGridView1.DataSource = uiPagination1.PageDataSource;
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
            //清除旧数据
            uiDataGridView1.ClearAll();
            uiPagination1.DataSource = null;
            //添加新列
            uiDataGridView1.AddColumn("日期", "Date").SetFixedMode(200);
            uiDataGridView1.AddColumn("总数", "Total").SetFixedMode(200);
            uiDataGridView1.ReadOnly = true;
            //绑定数据
            if(KeyData_DailyData.dailyData.dailies.Count != 0)
            {
                uiPagination1.DataSource = KeyData_DailyData.dailyData.dailies;
                uiPagination1.ActivePage = 1;
            }
            else
            {
                uiPagination1.DataSource = KeyData_DailyData.dailyData.dailies;
                uiPagination1.ActivePage = 1;
                //设置数据面板为空
                uiLabel_total.Text = "总数：暂无数据";
                uiLabel_date.Text = "日期：暂无数据";

                return;
            }

            //更新DataGridView
            uiDataGridView1.DataSource = uiPagination1.PageDataSource;
            //更新数据面板
            uiLabel_total.Text = "总数：不做计算";
            uiLabel_date.Text = "日期：" + KeyData_DailyData.dailyData.StartDate + "至" + KeyData_DailyData.dailyData.EndDate;
        }

        #endregion

    }
}
