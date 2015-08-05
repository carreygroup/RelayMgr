using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RelayMgr
{
    public partial class frmAbout : frmBase
    {
        public frmAbout()
        {
            InitializeComponent();

            string iniFile = string.Empty;
            string WelcomeImg = string.Empty;
            iniFile = System.Environment.CurrentDirectory + "\\config.ini";
            if (System.IO.File.Exists(iniFile))
            {
                lbl_Service.Text = "服务商： " + INIFile.ReadValue(iniFile, "SYSTEM", "service");
                WelcomeImg = INIFile.ReadValue(iniFile, "SYSTEM", "Welcome");
            }
            if (!WelcomeImg.Equals(string.Empty))
            {
                pictureBox1.Load(WelcomeImg);
            }
        }

        public frmAbout(string Info)
        {
            InitializeComponent();

            string iniFile = string.Empty;
            string WelcomeImg = string.Empty;
            iniFile = System.Environment.CurrentDirectory + "\\config.ini";
            if (System.IO.File.Exists(iniFile))
            {
                lbl_Service.Text = "服务商： " + INIFile.ReadValue(iniFile, "SYSTEM", "service");
                WelcomeImg = INIFile.ReadValue(iniFile, "SYSTEM", "Welcome");
            }
            if (!WelcomeImg.Equals(string.Empty))
            {
                pictureBox1.Load(WelcomeImg);
            }
            lb_Info.Text = Info;
            txt_SN.Visible = true;
            txt_SN.Text = Authorize.GetSerial();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
