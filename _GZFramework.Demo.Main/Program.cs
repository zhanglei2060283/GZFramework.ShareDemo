using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _GZFramework.Demo.Main
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.ApplicationExit += Application_ApplicationExit;
            Application.ThreadException += Application_ThreadException;
            Application.SetCompatibleTextRenderingDefault(false);
            GZFramework.UI.Dev.SplashScreenServer.ShowForm(null);//跳转窗体
            new _GZFramework.Demo.Library.Config.Config();

            Application.Run(new frmMain());
        }

        static void Application_ApplicationExit(object sender, EventArgs e)
        {
            _GZFramework.Demo.Library.MyClass.ApplicationEx.Exit();
        }
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            GZFramework.UI.Dev.WaiteServer.CloseWaite();
            if (e.Exception.InnerException != null)
                _GZFramework.Demo.Library.MyClass.Msg.Warning(e.Exception.InnerException.Message);
            else
                _GZFramework.Demo.Library.MyClass.Msg.Warning(e.Exception.Message);
        }
    }
}
