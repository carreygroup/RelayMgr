using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RelayMgr
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            AddForm();
            //if (Authorize.GetValidityUUID(Authorize.GetLicense()))
            //{
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                string user = string.Empty;

                if (args.Length == 0)
                {
                    user = "user";
                }
                else
                {
                    if (args[0] == "token")
                    {
                        user = "admin";
                    }
                }
                //user = "admin";
                SplashAppContext context = new SplashAppContext(new RelayMgr(false,user), new Splash());
                Application.Run(context);
            //}
            //else if (Authorize.GetValidityDemo(Authorize.GetLicense()))
            //{
            //    Application.EnableVisualStyles();
            //    Application.SetCompatibleTextRenderingDefault(false);
            //    SplashAppContext context = new SplashAppContext(new RelayMgr(true), new Splash());
            //    Application.Run(context);
            //}
            //else
            //{
            //    Application.EnableVisualStyles();
            //    Application.SetCompatibleTextRenderingDefault(false);
            //    Application.Run(new frmAbout("授权已失效，更多信息请联系工程商"));

            //}

            
        }

        //添加所有窗体用于本地化(按XML中顺序)
        private static void AddForm()
        {
            Localization.AddForm("RelayMgr");
            Localization.AddForm("frmPWD");
            Localization.AddForm("frmVItem");
            Localization.AddForm("frmSystem");
            Localization.AddForm("frmPool");
            Localization.AddForm("frmDevType");
            Localization.AddForm("frmDev");
            Localization.AddForm("frmCommands");
            Localization.AddForm("frmAddTask");
            Localization.AddForm("frmAction");
            Localization.AddForm("frmAbout");
            Localization.AddForm("frmConnection");

            string iniFile = string.Empty;
            string Lang = string.Empty;
            iniFile = System.Environment.CurrentDirectory + "\\config.ini";
            if (System.IO.File.Exists(iniFile))
            {
                Lang = INIFile.ReadValue(iniFile, "SYSTEM", "Lang");

            }
            if (!Lang.Equals(string.Empty))
            {
                if (!Localization.Load(Lang))
                {
                    MessageBox.Show("无法加载语言配置文件, 将显示中文.", "错误", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    Localization.HasLang = false;
                }
                else
                    Localization.HasLang = true;
            }
            else
            {
                Localization.AutoLang();
            }
        }
    }
}
