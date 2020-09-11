using KeyBordMonitor.Data;
using KeyBordMonitor.Helper;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyBordMonitor.Pages
{
    public partial class CheckKeyBordPage : UIForm
    {
        //是否开始校对
        private bool isCheck = false;
        //是否按键跳转
        private bool isJump = false;
        //是否快捷下一个
        private bool isQuickNext = false;
        //校对进度
        private int checkStep = -1;

		public CheckKeyBordPage()
        {
            InitializeComponent();

			Init();
        }
		/// <summary>
		/// 初始化
		/// </summary>
        public override void Init()
        {
            base.Init();
			
			//初始化picturebox_site
			pictureBox_site.BackColor = Color.Transparent;
			pictureBox_site.Parent = picturebox_keyBord;
			pictureBox_site.Location = new Point(0, 0);

		}

		#region 面板操作

		/// <summary>
		/// 更新面板数据
		/// </summary>
		private void updatePage()
		{
			//更新面板数据
			uiTextBox_key.Text = KeyData_Today.todayData.KeyDatas[checkStep].Key_name;
			uiTextBox_xy.Text = KeyData_Today.todayData.KeyDatas[checkStep].Key_x + "||" + KeyData_Today.todayData.KeyDatas[checkStep].Key_y;
			uiLabel_count.Text = (checkStep + 1).ToString() + "/" + KeyData_Today.todayData.KeyDatas.Count.ToString();
			uiCheckBox_isIgnore.Checked = KeyData_Today.todayData.KeyDatas[checkStep].IsIgnore;
		}
		/// <summary>
		/// 清空面板数据
		/// </summary>
		private void clearCheck()
		{
			//清空面板数据
			uiTextBox_key.Text = "";
			uiTextBox_xy.Text = "";
			uiLabel_count.Text = "0/0";

			//指示标志归位
			pictureBox_site.Location = new Point(0, 0);
		}
		/// <summary>
		/// 更新site位置
		/// </summary>
		private void updateSite()
		{
			//更新指示标志位置
			int[] a = xyChange(new int[2] { KeyData_Today.todayData.KeyDatas[checkStep].Key_x, KeyData_Today.todayData.KeyDatas[checkStep].Key_y });
			pictureBox_site.Location = new Point(a[0], a[1]) - new Size(pictureBox_site.Width / 2, pictureBox_site.Height / 2);
		}

		#endregion

		#region 坐标操作

		/// <summary>
		/// 获得xy坐标
		/// </summary>
		/// <returns></returns>
		private int[] getXY()
		{
			int originalWidth = this.picturebox_keyBord.Image.Width;
			int originalHeight = this.picturebox_keyBord.Image.Height;

			PropertyInfo rectangleProperty = this.picturebox_keyBord.GetType().GetProperty("ImageRectangle", BindingFlags.Instance | BindingFlags.NonPublic);
			Rectangle rectangle = (Rectangle)rectangleProperty.GetValue(this.picturebox_keyBord, null);

			int currentWidth = rectangle.Width;
			int currentHeight = rectangle.Height;

			double rate = (double)currentHeight / (double)originalHeight;

			int black_left_width = (currentWidth == this.picturebox_keyBord.Width) ? 0 : (this.picturebox_keyBord.Width - currentWidth) / 2;
			int black_top_height = (currentHeight == this.picturebox_keyBord.Height) ? 0 : (this.picturebox_keyBord.Height - currentHeight) / 2;

			int zoom_x = picturebox_keyBord.PointToClient(Control.MousePosition).X - black_left_width;
			int zoom_y = picturebox_keyBord.PointToClient(Control.MousePosition).Y - black_top_height;

			double original_x = (double)zoom_x / rate;
			double original_y = (double)zoom_y / rate;

			int[] a = new int[2] { (int)original_x, (int)original_y };

			return a;
		}
		/// <summary>
		/// 转换成图像坐标
		/// </summary>
		/// <param name="xy"></param>
		/// <returns></returns>
		private int[] xyChange(int[] xy)
		{
			int originalWidth = this.picturebox_keyBord.Image.Width;
			int originalHeight = this.picturebox_keyBord.Image.Height;

			PropertyInfo rectangleProperty = this.picturebox_keyBord.GetType().GetProperty("ImageRectangle", BindingFlags.Instance | BindingFlags.NonPublic);
			Rectangle rectangle = (Rectangle)rectangleProperty.GetValue(this.picturebox_keyBord, null);

			int currentWidth = rectangle.Width;
			int currentHeight = rectangle.Height;

			int black_left_width = (currentWidth == this.picturebox_keyBord.Width) ? 0 : (this.picturebox_keyBord.Width - currentWidth) / 2;
			int black_top_height = (currentHeight == this.picturebox_keyBord.Height) ? 0 : (this.picturebox_keyBord.Height - currentHeight) / 2;

			double rate = (double)currentHeight / (double)originalHeight;

			return new int[2] { (int)(xy[0] * rate) + black_left_width, (int)(xy[1] * rate) + black_top_height };
		}

		#endregion

		#region 按键触发

		/// <summary>
		/// 开始-结束-继续-暂停
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void uiButton_startCheck_Click(object sender, EventArgs e)
        {
			isCheck = true;
			checkStep = 0;

			updatePage();
			updateSite();

			//更新按键状态
			uiButton_startCheck.Enabled = false;
			uiButton_endCheck.Enabled = true;
			uiButton_contiueCheck.Enabled = false;
			uiButton_stopCheck.Enabled = true;

        }
        private void uiButton_endCheck_Click(object sender, EventArgs e)
        {
			isCheck = false;
			checkStep = -1;
			clearCheck();

			//更新按键状态
			uiButton_startCheck.Enabled = true;
			uiButton_endCheck.Enabled = false;
			uiButton_contiueCheck.Enabled = false;
			uiButton_stopCheck.Enabled = false;

			//更新XML文档
			KeyData_Today.SaveKeyData();
		}
        private void uiButton_contiueCheck_Click(object sender, EventArgs e)
        {
			isCheck = true;

			//更新按键状态
			uiButton_startCheck.Enabled = false;
			uiButton_endCheck.Enabled = true;
			uiButton_contiueCheck.Enabled = false;
			uiButton_stopCheck.Enabled = true;
		}
        private void uiButton_stopCheck_Click(object sender, EventArgs e)
        {
			isCheck = false;

			//更新按键状态
			uiButton_startCheck.Enabled = false;
			uiButton_endCheck.Enabled = true;
			uiButton_contiueCheck.Enabled = true;
			uiButton_stopCheck.Enabled = false;
		}
		/// <summary>
		/// 前进or后退
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void uiButton_back_Click(object sender, EventArgs e)
        {
			if (isCheck)
			{
				if (checkStep > 0 && checkStep <= KeyData_Today.todayData.KeyDatas.Count - 1)
				{
					checkStep--;
					updatePage();
					updateSite();
				}
			}
		}
        private void uiButton_next_Click(object sender, EventArgs e)
        {
			if (isCheck)
			{
				if (checkStep >= 0 && checkStep < KeyData_Today.todayData.KeyDatas.Count - 1)
				{
					checkStep++;
					updatePage();
					updateSite();
				}
			}
		}
		/// <summary>
		/// 设置是否忽略按钮
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="value"></param>
		private void uiCheckBox_isIgnore_ValueChanged(object sender, bool value)
		{
			KeyData_Total.totalData.KeyDatas[checkStep].IsIgnore = value;
			KeyData_Today.todayData.KeyDatas[checkStep].IsIgnore = value;
		}


		#endregion

		#region 跳转

		/// <summary>
		/// 是否按键跳转
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="value"></param>
		private void uiCheckBox_keyJump_ValueChanged(object sender, bool value)
		{
			isJump = value;
		}
		/// <summary>
		/// 是否快捷跳转
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="value"></param>
		private void uiCheckBox_quickJump_ValueChanged(object sender, bool value)
		{
			isQuickNext = value;
		}
		/// <summary>
		/// 按键跳转
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckKeyBordPage_KeyUp(object sender, KeyEventArgs e)
		{
			Console.WriteLine(e.KeyCode.ToString());
			if (isCheck && isJump)
			{
				int i = KeyData_Today.FindKey(e.KeyCode.ToString());
				if (i != -1)
				{
					checkStep = i;
					updatePage();
					updateSite();
				}
			}
		}
		/// <summary>
		/// 快捷跳转
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pictureBox_site_Click(object sender, EventArgs e)
		{
			if (isCheck && isQuickNext)
			{
				if (checkStep >= 0 && checkStep < KeyData_Today.todayData.KeyDatas.Count - 1)
				{
					checkStep++;
					updatePage();
					updateSite();
				}
			}
		}

		#endregion

		/// <summary>
		/// 点击面板，获得坐标
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void keyBord_Click(object sender, EventArgs e)
        {
            if (isCheck)
            {
				//放置pictureBox_site
				pictureBox_site.Location = picturebox_keyBord.PointToClient(Control.MousePosition)
					- new Size(pictureBox_site.Width / 2, pictureBox_site.Height / 2);
				//更新坐标
				int[] xy = getXY();
				uiTextBox_xy.Text = xy[0].ToString() + "||" + xy[1].ToString();
				KeyData_Today.todayData.KeyDatas[checkStep].Key_x = xy[0];
				KeyData_Today.todayData.KeyDatas[checkStep].Key_y = xy[1];
				//更新面板
				updatePage();
			}
		}
    
	}
}
