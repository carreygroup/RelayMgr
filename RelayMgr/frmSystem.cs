using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RelayMgr
{
    public partial class frmSystem : frmBase
    {
        private string UID = string.Empty;
        public frmSystem(string user)
        {
            InitializeComponent();
            LoadConfig();

            UID = user;
            if (UID.Equals("user"))
            {
                cb_Connection_Pool.Visible = false;
                tp_System.TabPages.Remove(tabPage1);

            }
            if(IsExistKey("RelayMgr"))
            {
                cb_AutoRun.Checked=true;
            }
        }


        private void btn_OK_Click(object sender, EventArgs e)
        {
            string iniFile = string.Empty;
            iniFile = System.Environment.CurrentDirectory + "\\config.ini";
            if (System.IO.File.Exists(iniFile))
            {
                INIFile.Writue(iniFile, "CONNECTION", "POOL", cb_Connection_Pool.Checked.ToString());
                if (!UID.Equals("user"))
                {
                    int ibutton = 0;
                    if (cb_btn_Item.Checked)
                    {
                        ibutton += 01;
                    }
                    if (cb_btn_Window.Checked)
                    {
                        ibutton += 02;
                    }
                    if (cb_btn_Board.Checked)
                    {
                        ibutton += 04;
                    }
                    if (cb_btn_BUS.Checked)
                    {
                        ibutton += 08;
                    }
                    if (cb_btn_Manual.Checked)
                    {
                        ibutton += 16;
                    }

                    INIFile.Writue(iniFile, "SYSTEM", "iButton", ibutton.ToString());
                }
            }
            this.DialogResult=DialogResult.OK;
        }

        private void LoadConfig()
        {
            string iniFile = string.Empty;
            iniFile = System.Environment.CurrentDirectory + "\\config.ini";
            if (System.IO.File.Exists(iniFile))
            {
                string Pool = INIFile.ReadValue(iniFile, "CONNECTION", "POOL");
                if (!UID.Equals("user"))
                {
                    try
                    {
                        int ibutton = Convert.ToInt32(INIFile.ReadValue(iniFile, "SYSTEM", "iButton"));

                        if (Convert.ToBoolean(ibutton & 01)) cb_btn_Item.Checked = true;
                        if (Convert.ToBoolean(ibutton & 02)) cb_btn_Window.Checked = true;
                        if (Convert.ToBoolean(ibutton & 04)) cb_btn_Board.Checked = true;
                        if (Convert.ToBoolean(ibutton & 08)) cb_btn_BUS.Checked = true;
                        if (Convert.ToBoolean(ibutton & 16)) cb_btn_Manual.Checked = true;

                    }
                    catch { }
                }
                if (!Pool.Equals(""))
                {
                    cb_Connection_Pool.Checked = Convert.ToBoolean(Pool);
                }
            }
        }

        //判断是否已经存在此键值,此处可以在Form_Load中来使用。       
        //如果存在，菜单[开机自动运行]前面可以打上对钩        
        //如果不存在，则不操作        
        private bool IsExistKey(string keyName)
        {
            bool _exist = false;
            RegistryKey hklm = Registry.LocalMachine;
            RegistryKey runs = hklm.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            //注意此处用的是GetValueNames()            
            string[] runsName = runs.GetValueNames();
            foreach (string strName in runsName)
            {
                if (strName.ToUpper() == keyName.ToUpper())
                {
                    _exist = true;
                    return _exist;
                }
            }
            return _exist;
        }
        private bool WriteKey(string keyName, string keyValue)
        {
            RegistryKey hklm = Registry.LocalMachine;
            //定义hklm指向注册表的LocalMachine,其中Software\Microsoft\Windows\CurrentVersion\Run就是关系到系统中随系统启动而启动的程序，通称启动项              
            RegistryKey run = hklm.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
            try
            {
                //将我们的程序加进去                 
                run.SetValue(keyName, keyValue);
                //注意，一定要关闭，注册表应用。                 
                hklm.Close();
                return true;
            }
            catch //这是捕获异常的              
            {
                return false;
            }
        }
        //删除键值        
        private void DeleteKey(string keyName)
        {
            RegistryKey hklm = Registry.LocalMachine;
            RegistryKey runs = hklm.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            try
            {
                //注意此处用的是GetValueNames()                
                string[] runsName = runs.GetValueNames();
                foreach (string strName in runsName)
                {
                    if (strName.ToUpper() == keyName.ToUpper())
                        runs.DeleteValue(strName, false);
                }
            }
            catch { }
        }

        private void cb_AutoRun_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_AutoRun.Checked)
            {
                //应该程序的路径            
                string keyValue = Application.ExecutablePath;
                WriteKey("RelayMgr", keyValue);
            }
            else
            {
                DeleteKey("RelayMgr");
            }
        }

        private void btn_SetPassword_Click(object sender, EventArgs e)
        {
            DBUsers.DBUsersUPdate(UID, txt_PWD.Text);
        }
    }
}
