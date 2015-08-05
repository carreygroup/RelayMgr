using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.InteropServices;

namespace RelayMgr
{
    /// <summary>
    /// 本地化类
    /// </summary>
    public static class Localization
    {
        //MessageBox.Show(System.Globalization.CultureInfo.InstalledUICulture.NativeName);   
        //MessageBox.Show(System.Environment.OSVersion.ToString());
        //1，就是当前所在区域，可以用上面的方法获得   
        //2，OS   当前选择的默认语言，可以用GetSystemDefaultLangID   
        //3，OS   系统自己的语言，可以从GetSystemDefaultLCID   或   GetOEMCP   获得
        //都没有参数，所以可以简单调用，936:简体中文,949:韩文 比如：
        //int   i   =   GetSystemDefaultLangID();
        [DllImport("kernel32.dll", EntryPoint = "GetSystemDefaultLangID")]
        public static extern short GetSystemDefaultLangID();

        [DllImport("kernel32.dll", EntryPoint = "GetSystemDefaultLCID")]
        public static extern int GetSystemDefaultLCID();

        [DllImport("kernel32.dll", EntryPoint = "GetOEMCP")]
        public static extern int GetOEMCP();   

        #region Property;
        public static string Lang { get; private set; }
        public static bool HasLang { get; set; }        
        #endregion //Property

        
        #region Attribute;
        private static Dictionary<string, Dictionary<string, string>> forms = new Dictionary<string, Dictionary<string, string>>();
        private static Dictionary<string, string> menu = new Dictionary<string, string>();
        private static Dictionary<string, string> toolbar = new Dictionary<string, string>();
        private static Dictionary<string, string> dialog = new Dictionary<string, string>();
        private static Dictionary<string, string> m_string = new Dictionary<string, string>();
        #endregion //Attribute

        
        #region Method;
        public static void AddForm(string formName)
        {
            forms.Add(formName, new Dictionary<string, string>());
            //formMap.Add(formName, count++);
        }

        /**//// <summary>
        /// 加载语言文件
        /// </summary>
        /// <param name="lang">语言</param>
        /// <returns></returns>
        public static bool Load(string lang)
        {
            string path = "";
            Localization.Lang = "Simplified Chinese";

            menu.Clear();
            toolbar.Clear();
            dialog.Clear();
            //exception.Clear();
            foreach (Dictionary<string, string> form in forms.Values)
                form.Clear();
            
            switch (lang)
            {
                case "zh":                   
                    path = @"resources/lang-zh.xml";
                    break;
                case "en":                  
                    path = @"resources/lang-en.xml";
                    break;
                case "cht":
                    path = @"resources/lang-cht.xml";
                    break;
                default:                    
                    path = @"resources/lang-zh.xml";
                    break;
            }

            return readLanguage(path);
        }

        public static void AutoLang()
        {
            short i = GetSystemDefaultLangID();
            switch(i) 
            {
                case 0x0404://繁体
                case 0x0c04:
                    LoadLang("cht");
                    break;
                case 0x0804://简体
                    LoadLang("cn");
                    break;
                default ://其他语言，显示英文
                    LoadLang("en");
                    break;
            }
        }

        #endregion //Method

        #region Function
        private static bool LoadLang(string lang)
        {
            if (!Localization.Load(lang))
            {
                //MessageBox.Show("无法加载语言配置文件, 将显示中文.", "错误", MessageBoxButtons.OK,
                //    MessageBoxIcon.Exclamation);
                Localization.HasLang = false;
            }
            else
                Localization.HasLang = true;
            return Localization.HasLang;
        }

        private static bool readLanguage(string path)
        {
            // Read the language file
            XmlReader reader;
            try
            {
                reader = XmlReader.Create(path);
            }
            catch (Exception)
            {
                return false;
            }

            // Begin to parase
            try
            {
                reader.ReadToFollowing("AirControl");
                Localization.Lang = reader.GetAttribute("language");

                paraseXml(reader, "Menu", menu);
                paraseXml(reader, "Toolbar", toolbar);
  
                foreach (string formName in forms.Keys)
                {
                    paraseXml(reader, formName, forms[formName]);
                }
                paraseXml(reader, "Dialog", dialog);               
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private static void paraseXml(XmlReader reader, string item, Dictionary<string, string> obj)
        {
            // Get the attribute key & value 
            reader.ReadToFollowing(item);

            XmlReader subreader = reader.ReadSubtree();
            while (subreader.Read())
            {
                if (subreader.NodeType == XmlNodeType.Element && subreader.Name == "Item")
                    obj.Add(subreader.GetAttribute("key"), subreader.GetAttribute("value"));
            }
        }
        #endregion //Function

        #region Property
        public static Dictionary<string, string> Menu
        {
            get
            {
                return menu;
            }
            private set
            { }
        }

        public static Dictionary<string, string> Toolbar
        {
            get
            {
                return toolbar;
            }
            private set
            { }
        }

        public static Dictionary<string, Dictionary<string, string>> Forms
        {
            get
            {
                return forms;
            }
            private set
            { }
        }
 
        public static Dictionary<string, string> Dialog
        {
            get
            {
                return dialog;
            }
            private set
            { }
        }
        #endregion //Property
    }
}