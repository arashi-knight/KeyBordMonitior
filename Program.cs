using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyBordMonitor
{
    static class Program
    {
        //防止程序运行多个实例的方法有多种,如:通过使用互斥量和进程名等.而我想要实现的是:在程序运行多个实例时激活的是第一个实例,使其获得焦点,并在前端显示.
        //主要用到两个API 函数:
        //ShowWindowAsync 该函数设置由不同线程产生的窗口的显示状态。 
        //SetForegroundWindow 该函数将创建指定窗口的线程设置到前台，并且激活该窗口。键盘输入转向该窗口，并为用户改各种可视的记号。系统给创建前台窗口的线程分配的权限稍高于其他线程。
        /// <summary> 
        /// 该函数设置由不同线程产生的窗口的显示状态。 
        /// </summary> 
        /// <param name="hWnd">窗口句柄</param> 
        /// <param name="cmdShow">指定窗口如何显示。查看允许值列表，请查阅ShowWlndow函数的说明部分。</param> 
        /// <returns>如果函数原来可见，返回值为非零；如果函数原来被隐藏，返回值为零。</returns> 
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string className, string frmText);
        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);
        [DllImport("user32.dll", EntryPoint = "ShowWindow", CharSet = CharSet.Auto)]
        public static extern int ShowWindow(IntPtr hwnd, int showWay);
        [DllImport("user32.dll ", SetLastError = true)]
        static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);
        /// <summary> 
        /// 该函数将创建指定窗口的线程设置到前台，并且激活该窗口。键盘输入转向该窗口，并为用户改各种可视的记号。系统给创建前台窗口的线程分配的权限稍高于其他线程。 
        /// </summary> 
        /// <param name="hWnd">将被激活并被调入前台的窗口句柄。</param> 
        /// <returns>如果窗口设入了前台，返回值为非零；如果窗口未被设入前台，返回值为零。</returns> 
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        /// <summary>
        /// 根据句柄查找进程ID
        /// </summary>
        /// <param name="hwnd"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("User32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        public static extern int GetWindowThreadProcessId(IntPtr hwnd, out int ID);
        private const int WS_SHOWNORMAL = 1;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process instance = RunningInstance();
            if (RunningInstance() != null)
            {
                HandleRunningInstance(instance);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        /// <summary>
        /// 返回相同运行路径的 Process
        /// </summary>
        /// <returns></returns>
        private static Process RunningInstance()
        {
            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(current.ProcessName);
            //遍历与当前进程名称相同的进程列表 
            foreach (Process process in processes)
            {
                //如果实例已经存在则忽略当前进程 
                if (process.Id != current.Id)
                {
                    //保证要打开的进程同已经存在的进程来自同一文件路径
                    if (Assembly.GetExecutingAssembly().Location.Replace("/", "\\") == current.MainModule.FileName)
                    {
                        //返回已经存在的进程
                        return process;
                    }
                }
            }
            return null;
        }

        /// <summary> 
        /// 显示已运行的程序。 
        /// </summary> 
        public static void HandleRunningInstance(Process instance)
        {
            //MessageBox.Show("ID:"+instance.Id .ToString()+"--句柄"+instance.MainWindowHandle.ToString() + "--正常窗口" + WS_SHOWNORMAL + "--" + ShowWindowAsync(instance.MainWindowHandle, WS_SHOWNORMAL) + "--" + SetForegroundWindow(instance.MainWindowHandle));
            //ShowWindowAsync(instance.MainWindowHandle, WS_SHOWNORMAL); //显示，可以注释掉 
            //放到前端 
            string s = instance.MainWindowHandle.ToString();
            string ss = instance.Handle.ToString();
            if (s == "0")
            {
                System.Diagnostics.Process proc = System.Diagnostics.Process.GetCurrentProcess();
                Process[] Proes = System.Diagnostics.Process.GetProcessesByName(proc.ProcessName);
                foreach (System.Diagnostics.Process otherProc in Proes)
                {
                    if (proc.Id != otherProc.Id)
                    {
                        IntPtr hWnd = otherProc.MainWindowHandle;//注意这里hWnd代表的是窗口句柄，不是进程句柄
                        if (hWnd.ToInt32() == 0)
                        {
                            hWnd = FindWindow(null, "键盘监控");//我理解为主窗体的Text（不知道对不对哈）,这里注意一定不是进程名哦
                            int id = -1;
                            GetWindowThreadProcessId(hWnd, out id);
                            if (id == otherProc.Id)
                            {
                                ShowWindow(hWnd, 5);//5代表窗体执行show();
                                ShowWindow(hWnd, 1);//1代表窗体执行this.WindowState = FormWindowState.Normal;
                                break;
                            }
                        }
                        //此处获取的hWnd即为之前运行程序的主窗口句柄，再使用其他函数打开窗体                       
                        break;
                    }
                }
            }
            else
            {
                ShowWindow(instance.MainWindowHandle, 1);//1代表窗体执行this.WindowState = FormWindowState.Normal;也可以用WS_SHOWNORMAL,这个是自己定义的常量,看上面定义，照顾小白我才没有用哦
            }
        }
    }
}