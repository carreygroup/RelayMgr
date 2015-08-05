using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RelayMgr
{
    public partial class frmConnection : frmBase
    {
        public frmConnection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 枚举串口
        /// </summary>
        private void EnumCOMPort()
        {
            cb_SerialPort.Items.Clear();
            cb_SerialPort.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if (cb_SerialPort.Items.Count > 0)
            {
                cb_SerialPort.SelectedIndex = 0;
            }
        }

        private void frmConnection_Load(object sender, EventArgs e)
        {
            string iniFile = string.Empty;
            iniFile = System.Environment.CurrentDirectory + "\\config.ini";
            if (System.IO.File.Exists(iniFile))
            {
                txtIP.Text = INIFile.ReadValue(iniFile, "CONNECTION", "DOMAIN");
                nud_Delay.Value = Convert.ToInt32(INIFile.ReadValue(iniFile, "CONNECTION", "Delay"));
                txtPort.Text = INIFile.ReadValue(iniFile, "CONNECTION", "PORT");
                cb_SerialPort.Text = INIFile.ReadValue(iniFile, "CONNECTION", "SerialPort");
                cb_AutoConnection.Checked = Convert.ToBoolean(INIFile.ReadValue(iniFile, "CONNECTION", "AutoConnection"));

                string connectmode = INIFile.ReadValue(iniFile, "CONNECTION", "CONNMODE");

                if (connectmode == "0")
                {
                    rbCOM.Checked = true;
                }
                else
                    if (connectmode == "1")
                    {
                        rbNetWork.Checked = true;

                    }

            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            string iniFile = string.Empty;
            iniFile = System.Environment.CurrentDirectory + "\\config.ini";
            if (System.IO.File.Exists(iniFile))
            {
                INIFile.Writue(iniFile, "CONNECTION", "DOMAIN", txtIP.Text);
                INIFile.Writue(iniFile, "CONNECTION", "Delay", nud_Delay.Value.ToString());
                INIFile.Writue(iniFile, "CONNECTION", "PORT", txtPort.Text);
                INIFile.Writue(iniFile, "CONNECTION", "SerialPort", cb_SerialPort.Text);
                INIFile.Writue(iniFile, "CONNECTION", "AutoConnection", cb_AutoConnection.Checked.ToString());
                if (rbCOM.Checked)
                {
                    INIFile.Writue(iniFile, "CONNECTION", "CONNMODE", "0");
                }
                else
                    if (rbNetWork.Checked)
                {
                    INIFile.Writue(iniFile, "CONNECTION", "CONNMODE", "1");

                }
                
            }
        }

        private void cb_SerialPort_DropDown(object sender, EventArgs e)
        {
            EnumCOMPort();
        }
    }
}
