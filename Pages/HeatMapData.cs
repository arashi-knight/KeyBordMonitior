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
using KeyBordMonitor.Helper;
using Sunny.UI;

namespace KeyBordMonitor
{
    public partial class HeatMapData : UITitlePage
    {
        /// <summary>
        /// 选择生成热力图的类型：0为无，1为今日数据，2为总数据
        /// </summary>
        private int todayOrTotal = 0;

        public HeatMapData()
        {
            InitializeComponent();
        }

        #region 按钮点击事件

        /// <summary>
        /// 创建热力图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton_create_Click(object sender, EventArgs e)
        {
            if(todayOrTotal == 1 || todayOrTotal == 2)
            {
                //加载图片
                Bitmap bitmap = (Bitmap)Properties.Resources.KeyBord;
                //创建热力图
                HeatMapImage heatMapImage = new HeatMapImage(bitmap.Width, bitmap.Height, 150, 30);
                //加载数据
                if (todayOrTotal == 1)
                {
                    foreach (Key_Today key in KeyData_Today.todayData.KeyDatas)
                    {
                        //判断是否跳过数据
                        if (key.IsIgnore)
                        {
                            continue;
                        }
                        heatMapImage.SetAData(new DataType(key.Key_x, key.Key_y, key.Key_count));
                    }
                    //更新详细信息
                    uiLabel_total.Text = "总数：" + KeyData_Today.todayData.Total;
                    uiLabel_date.Text = "日期：" + KeyData_Today.todayData.Date;

                }
                else if(todayOrTotal == 2)
                {
                    for (int i = 0; i < KeyData_Total.totalData.KeyDatas.Count && i < KeyData_Today.todayData.KeyDatas.Count; i++)
                    {
                        //判断是否跳过数据
                        if (KeyData_Today.todayData.KeyDatas[i].IsIgnore)
                        {
                            continue;
                        }
                        heatMapImage.SetAData(new DataType(KeyData_Today.todayData.KeyDatas[i].Key_x, KeyData_Today.todayData.KeyDatas[i].Key_y, KeyData_Total.totalData.KeyDatas[i].Key_count));
                    }
                    //更新数据面板
                    uiLabel_total.Text = "总数：" + KeyData_Total.totalData.Total;
                    uiLabel_date.Text = "日期：" + KeyData_Total.totalData.StartDate + "至" + KeyData_Total.totalData.EndDate;

                }

                Bitmap img = heatMapImage.GetHeatMap(bitmap);

                pictureBox1.Image = img;

                pictureBox1.Refresh();

                uiButton_save.Enabled = true;
            }
        }
        /// <summary>
        /// 保存热力图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton_save_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "请选择保存所在文件夹";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    //警告不能为空
                    this.ShowErrorDialog("路径不能为空");
                    return;
                }
                //保存
                pictureBox1.Image.Save(dialog.SelectedPath + "\\KeyBord_" + DateTime.Now.ToString("MM-dd-HH-mm-ss") + ".jpg");
                System.Diagnostics.Process.Start(dialog.SelectedPath);
            }
        }
        /// <summary>
        /// 重置图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton_ReSet_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = (Bitmap)Properties.Resources.KeyBord;
            uiButton_save.Enabled = false;
        }
        /// <summary>
        /// 设置要显示的是总数据还是今日数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="value"></param>
        private void uiCheckBox_todayData_ValueChanged(object sender, bool value)
        {
            if (value)
            {
                uiCheckBox_totalData.Checked = false;
                todayOrTotal = 1;
            }
            else
            {
                todayOrTotal = 0;
            }
        }
        private void uiCheckBox_totalData_ValueChanged(object sender, bool value)
        {
            if (value)
            {
                uiCheckBox_todayData.Checked = false;
                todayOrTotal = 2;
            }
            else
            {
                todayOrTotal = 0;
            }
        }

        #endregion

    }
}
