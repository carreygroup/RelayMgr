using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net;
using CSharpWin;
using libZPlay;

namespace RelayMgr
{
    //class SerialPool
    //{
    //    public SerialPort serialPort = null;
    //    public string SerialName = string.Empty;
    //}

    //class NetworkPool
    //{
    //    public Socket socketClient = null;
    //    public string SocketAddress = string.Empty;
    //    public string SocketPort = string.Empty;
    //}

    public partial class RelayMgr : frmBase
    {
        //public static byte[] txtrecmsg = new byte[8];
        /// <summary>
        /// 继电器属性
        /// 串口用
        /// </summary>
        //private static short Address;
        //private static int Line;
        //private static RelayType type;
        private class POWERFLASH
        {
            public int con;
            public short address;
            public int line;
        }
        private List<POWERFLASH> m_PowerFlash = new List<POWERFLASH>();

        //private static byte[] m_SendCMD=new byte[8];
        //private static byte[] m_TEMPCMD = new byte[8];
        //private static int Index = 0;

        //private static string PORT_NAME = "COM1";
        private static SerialPort serialPort = null;

        private static int m_Hour = 0;
        //private static SerialPort PostSP = null;

        private List<SerialPort> l_SerialPorts = new List<SerialPort>();//串口池
        private static List<Socket> l_Sockets = new List<Socket>();
        //private List<Thread> l_ClientThreads = new List<Thread>();

        private const int BAUD_RATE = 57600;

        private const int ReadTimeout = 50;
        private const int WriteTimeout = 50;

        private int deviation_temp = 0;
        private int deviation_hm = 0;
        private bool m_isDemo = true;//演示版本
        private bool m_UsePool = false;//使用连接池
        private bool m_UseSafetyOperations = true;
        private bool m_ActiveQuery = true;
        private bool m_AutoConnection=false;
        private bool m_Reconnection = false;

        private DevListViewItem PrivFlashItem=new DevListViewItem();

        private bool bConnected = false;

        RegionControl P_regionControl;

        private static List<byte[]> CMDLIST=new List<byte[]>();
        private static List<byte[]> InQuireCMDLIST = new List<byte[]>();
        private static int InQuireIndex = 0;//查询索引

        private int Transport = 0;//传输模式，0双向传输，1单向传输
        /// <summary>
        /// 查询开关，避免开关指令无法执行
        /// </summary>
        //private bool CanQuire = false;
        /// <summary>
        /// 任务列表锁定
        /// </summary>
        private bool TaskLock = false;

        private string UID = string.Empty;
        /// <summary>
        /// 本页面lv_Items中的所有地址
        /// </summary>
        private List<short> CurrentAddr=new List<short>();

        private frmDebug fdebug = new frmDebug();

        public bool ReceiveEventFlag = false;  //接收事件是否有效 false表示有效
        /// <summary>
        /// 更新事件
        /// </summary>
        /// <param name="msg"></param>
        public delegate void HandleInterfaceUpdataDelegate(byte[] msg);
        private HandleInterfaceUpdataDelegate interfaceUpdataHandle;

        private void LangMenuAndToolbar()
        {
            // Refresh the menu language
            try
            {
                foreach (ToolStripMenuItem topItem in mnu_Main.Items)
                {
                    topItem.Text = Localization.Menu[topItem.Name];
                    foreach (ToolStripItem item in topItem.DropDownItems)
                    {
                        if (item is ToolStripMenuItem)
                        {
                            string text = "";
                            if (Localization.Menu.TryGetValue(item.Name, out text))
                                item.Text = text;
                        }
                    }
                }
            }
            catch { }
        }


        public RelayMgr(bool Demo,string user)
        {
            InitializeComponent();

            LangMenuAndToolbar();

            UID = user;

            if (UID.Equals("user"))
            {
                lv_Category.ContextMenuStrip = null;
                lv_Items.ContextMenuStrip = null;
                lv_DIItems.ContextMenuStrip = null;
                lv_TaskMgr.ContextMenuStrip = null;
                mnu_pool.Visible = false;
            }
            string SkinFile=string.Empty;
            string iniFile = string.Empty;
            iniFile = System.Environment.CurrentDirectory + "\\config.ini";
            if (System.IO.File.Exists(iniFile))
            {
                this.Text =INIFile.ReadValue(iniFile, "SYSTEM", "title");
                SkinFile = INIFile.ReadValue(iniFile, "SYSTEM", "SkinFile");
            }
            if(SkinFile.Equals(string.Empty))
            {
                SkinFile="MP10.ssk";
            }
            SkinFile = System.Environment.CurrentDirectory + "\\"+SkinFile;
            skinEngine1.SkinFile = SkinFile;
            ShowView();
            
            LoadConfig();
            if (m_UsePool)
            {
                gb_quickConn.Enabled = false;
                gb_quickConn.Visible = false;
                pl_PoolInfo.Dock = DockStyle.Left;
                pl_PoolInfo.Width = 1000;
                pl_PoolInfo.Visible = false;
                btn_InfoPanel.Visible = true;
            }
            else
            {
                EnumCOMPort();
            }

            //LoadLv_ItemsImage();
            LoadCategoryImage();
            LoadDOImage();
            LoadDIImage();

            LoadDevTypes();
            //lv_Category.Items[0].Selected = true;
            //lv_Category.Focus();
            tm_AllowAction.Enabled = true;
        }

        private void LoadCategoryImage()
        {
            string ImgFile = string.Empty;
            string ImgPath = string.Empty;
            int i = 0;
            ImgPath = System.Environment.CurrentDirectory + "\\images\\Category\\";
            il_Category.Images.Clear();
            bool FileExists=false;
            do
            {
                try
                {
                    ImgFile = ImgPath + i.ToString() + ".jpg";
                    if (System.IO.File.Exists(ImgFile))
                    {
                        System.Drawing.Image bmp = System.Drawing.Image.FromFile(ImgFile);
                        il_Category.Images.Add(bmp);
                        FileExists = true;
                        i++;
                    }
                    else
                        FileExists = false;
                }
                catch (Exception e)
                {
                    //MessageBox.Show(e.Message);
                    FileExists = false;
                }
            } while (FileExists);
        
        }

        private void LoadDOImage()
        {
            string ImgFile = string.Empty;
            string ImgPath = string.Empty;
            int i = 0;
            ImgPath = System.Environment.CurrentDirectory + "\\images\\DO\\";
            il_Items.Images.Clear();
            bool FileExists = false;
            do
            {
                try
                {
                    ImgFile = ImgPath + i.ToString() + ".jpg";
                    if (System.IO.File.Exists(ImgFile))
                    {
                        System.Drawing.Image bmp = System.Drawing.Image.FromFile(ImgFile);
                        il_Items.Images.Add(bmp);
                        FileExists = true;
                        i++;
                    }
                    else
                        FileExists = false;
                }
                catch (Exception e)
                {
                    //MessageBox.Show(e.Message);
                    FileExists = false;
                }
            } while (FileExists);

        }

        private void LoadDIImage()
        {
            string ImgFile = string.Empty;
            string ImgPath = string.Empty;
            int i = 0;
            ImgPath = System.Environment.CurrentDirectory + "\\images\\DI\\";
            il_InputItems.Images.Clear();
            bool FileExists = false;
            do
            {
                try
                {
                    ImgFile = ImgPath + i.ToString() + ".jpg";
                    if (System.IO.File.Exists(ImgFile))
                    {
                        System.Drawing.Image bmp = System.Drawing.Image.FromFile(ImgFile);
                        il_InputItems.Images.Add(bmp);
                        FileExists = true;
                        i++;
                    }
                    else
                        FileExists = false;
                }
                catch (Exception e)
                {
                    FileExists = false;
                }
            } while (FileExists);

        }

        private void RelayMgr_Load(object sender, EventArgs e)
        {
            //if (!m_isDemo)
            //{
            //    btn_Lockthis.Visible = true;
            //    ShowLockScreen(true);
            //}
        }
        /// <summary>
        /// 读入连接配置
        /// </summary>
        private void LoadConfig()
        {
            try
            {
                string iniFile = string.Empty;
                iniFile = System.Environment.CurrentDirectory + "\\config.ini";
                if (System.IO.File.Exists(iniFile))
                {
                    if (INIFile.ReadValue(iniFile, "SYSTEM", "showtimer") == "true")
                    {
                        ShowTimer();
                    }

                    txtIP.Text = INIFile.ReadValue(iniFile, "CONNECTION", "DOMAIN");
                    txtPort.Text = INIFile.ReadValue(iniFile, "CONNECTION", "PORT");
                    cb_SerialPort.Text = INIFile.ReadValue(iniFile, "CONNECTION", "SerialPort");
                    nud_Delay.Value = Convert.ToInt32(INIFile.ReadValue(iniFile, "CONNECTION", "Delay"));
                    cb_Band.Text = INIFile.ReadValue(iniFile, "CONNECTION", "Baud");
                    string connectmode = INIFile.ReadValue(iniFile, "CONNECTION", "CONNMODE");


                    Transport = Convert.ToInt32(INIFile.ReadValue(iniFile, "SYSTEM", "Transport"));

                    m_UsePool = Convert.ToBoolean(INIFile.ReadValue(iniFile, "CONNECTION", "POOL"));
                    m_UseSafetyOperations = Convert.ToBoolean(INIFile.ReadValue(iniFile, "SYSTEM", "UseSafetyOperations"));
                    m_ActiveQuery = Convert.ToBoolean(INIFile.ReadValue(iniFile, "SYSTEM", "ActiveQuery"));

                    try
                    {
                        deviation_temp = Convert.ToInt32(INIFile.ReadValue(iniFile, "SYSTEM", "Transport"));

                    }
                    catch { }

                    try
                    {
                        deviation_hm = Convert.ToInt32(INIFile.ReadValue(iniFile, "SYSTEM", "Transport"));

                    }
                    catch { }
                    //try
                    //{
                        int ibutton = Convert.ToInt32(INIFile.ReadValue(iniFile, "SYSTEM", "iButton"));

                        if (Convert.ToBoolean(ibutton & 01))
                        {
                            btnPowerON.Visible = true;
                            btnPowerOFF.Visible = true;
                        }
                        if (Convert.ToBoolean(ibutton & 02))
                        {
                            btnPowerONAll.Visible = true;
                            btnPowerOFFAll.Visible = true;
                        }
                        if (Convert.ToBoolean(ibutton & 04))
                        {
                            btnPowerON_Board.Visible = true;
                            btnPowerOFF_Board.Visible = true;
                        }
                        if (Convert.ToBoolean(ibutton & 08))
                        {
                            btnPowerOFF_BUS.Visible = true;
                            btnPowerON_BUS.Visible = true;
                        }
                        if (Convert.ToBoolean(ibutton & 16))
                        {
                            btn_Manual.Visible = true;
                        }

                    //}
                    //catch { }

                    if (connectmode == "0")
                    {
                        rb_COM.Checked = true;
                    }
                    else
                        if (connectmode == "1")
                        {
                            rb_TCP.Checked = true;

                        }
                        else
                            if (connectmode == "2")
                            {
                                rb_UDP.Checked = true;

                            }
                            else
                                if (connectmode == "2")
                                {
                                    rb_UDP.Checked = true;

                                }
                    m_AutoConnection = Convert.ToBoolean(INIFile.ReadValue(iniFile, "CONNECTION", "AutoConnection"));
                    if (m_AutoConnection)
                    {

                        BeginListen();
                    }
                    m_Reconnection = Convert.ToBoolean(INIFile.ReadValue(iniFile, "CONNECTION", "Reconnection"));
                }
            }
            catch { }
        }
        /// <summary>
        /// 枚举串口
        /// </summary>
        private void EnumCOMPort()
        {
            cb_SerialPort.Items.Clear();
            cb_SerialPort.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if(cb_SerialPort.Items.Count>0)
            {
                cb_SerialPort.SelectedIndex = 0;
            }
        }
        /// <summary>
        /// 装载设备分组列表
        /// </summary>
        private void LoadDevTypes()
        {
            lv_Category.Items.Clear();
            DevTypeViewItem alldev = new DevTypeViewItem();
            alldev.Text = "所有设备";
            alldev.Tag = "999999";
            alldev.ImageIndex = 0;
            lv_Category.Items.Add(alldev);
            DataTable dt = DBDevType.DBDevTypeQuery();
            foreach (DataRow row in dt.Rows)
            {
                DevTypeViewItem node = new DevTypeViewItem();
                node.Text=row["Name"].ToString();
                node.Tag = row["ID"].ToString();
                node.imgGroup = 0;
                try
                {
                    node.imgGroup=Convert.ToInt32(row["imgGroup"].ToString());
                }
                catch { }
                node.ImageIndex = 2 * node.imgGroup;

                lv_Category.Items.Add(node);
            }
        }
        /// <summary>
        /// 设备分组增加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnu_DevTypeAdd_Click(object sender, EventArgs e)
        {
            frmDevType fdt = new frmDevType();
            if (fdt.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string Name = fdt.txtName.Text;
                    string imggroup = fdt.txt_ImgGroup.Text;
                    DBDevType.DBDevTypInsert(Name,imggroup);
                    LoadDevTypes();
                }
                catch (Exception err)
                {
                    fdebug.AddInfo("mnu_DevTypeAdd_Click() " + err.Message );
                    //MessageBox.Show(err.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// 设备分组修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnu_DevTypeModify_Click(object sender, EventArgs e)
        {
            if (lv_Category.SelectedItems.Count > 0 && lv_Category.SelectedItems[0].Tag.ToString() != "999999")
            {
                frmDevType fdt = new frmDevType();
                fdt.txtName.Text = lv_Category.SelectedItems[0].Text;
                fdt.txt_ImgGroup.Text = ((DevTypeViewItem)(lv_Category.SelectedItems[0])).imgGroup.ToString();
                if (fdt.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string ID = this.lv_Category.SelectedItems[0].Tag.ToString();
                        string Name = fdt.txtName.Text;
                        string imggroup = fdt.txt_ImgGroup.Text;
                        DBDevType.DBDevTypeUPdate(Name, ID,imggroup);
                        lv_Category.SelectedItems[0].Text = Name;
                    }
                    catch (Exception err)
                    {
                        fdebug.AddInfo("mnu_DevTypeModify_Click() " + err.Message);
                        //MessageBox.Show(err.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("请选中你要修改的项!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// 设备分组删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnu_DevTypeRemove_Click(object sender, EventArgs e)
        {
            if (lv_Category.SelectedItems.Count > 0 && lv_Category.SelectedItems[0].Tag.ToString() != "999999")
            {
                DBDevType.DBDevTypeDelete(Convert.ToInt32(lv_Category.SelectedItems[0].Tag));
                lv_Category.SelectedItems[0].Remove();
            }
            else
            {
                MessageBox.Show("请选中你要删除的项!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// 主窗体关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 类型选择改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lv_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDevices();
            LoadInputDevices();
            LoadGroupTasks();
            InQuire();
            if (m_UsePool)
            {
                if(lv_Category.SelectedItems.Count > 0)
                {
                    EndListen();
                    foreach (DevTypeViewItem lvi in lv_Category.Items)
                    {
                        lvi.ImageIndex =2*lvi.imgGroup;
                    }
                    if (BeginListen())
                    {
                        lv_Category.SelectedItems[0].ImageIndex +=1;

                    }
                }
            }
            timer_INQUIRE.Interval = 100;
            timer_INQUIRE.Enabled = true;
        }
        /// <summary>
        /// 装载输出设备列表
        /// </summary>
        private void LoadDevices()
        {
            tm_AllowAction.Enabled = true;

            if (lv_Category.SelectedItems.Count > 0)
            {
                DataTable dt = new DataTable();
                if (lv_Category.SelectedItems[0].Tag.ToString() == "999999")
                {
                    dt = DBDevices.DBDevAll();
                    CurrentAddr.Clear();
                    CurrentAddr = DBDevices.QueryAllDevicesAddress();
                }
                else
                {
                    dt = DBDevices.DBQueryDevicesByType(lv_Category.SelectedItems[0].Tag.ToString());
                    CurrentAddr.Clear();
                    CurrentAddr = DBDevices.DBQueryDevicesAddress(lv_Category.SelectedItems[0].Tag.ToString());
                }
                lv_Items.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    DevListViewItem node = new DevListViewItem();
                    node.Text = row["Name"].ToString();
                    node.Title=row["Name"].ToString();
                    node.Tag = row["ID"].ToString();
                    node.uAddress = Convert.ToInt16(row["Address"]);
                    node.uLine = Convert.ToInt32(row["Line"]);
                    node.Item_Action = row["Item_Action"].ToString();

                    DataTable adt = new DataTable();
                    adt = DBiCoreVal.DBQueryValByItem(row["ID"].ToString());
                    foreach (DataRow dr in adt.Rows)
                    {
                        iCore_Value icv = new iCore_Value();
                        icv.CMD = dr["Command"].ToString();
                        icv.Value=Convert.ToDecimal(dr["Value"]);
                        node.ActionList.Add(icv);
                    }

                    try
                    {
                        node.DefAction = Convert.ToInt32(row["DefAction"]);
                    }
                    catch
                    {
                        node.DefAction = 0;
                    }
                    try
                    {
                        node.ImgGroup = Convert.ToInt32(row["ImgGroup"]);
                    }
                    catch
                    {
                        node.ImgGroup = 0;
                    }
                    try
                    {
                        node.DevIO = Convert.ToInt32(row["IO"]);
                    }
                    catch
                    {
                        node.DevIO = 0;
                    }
                    try
                    {
                        node.uPowerFlash = Convert.ToInt32(row["powerflash"]);
                    }
                    catch
                    {
                        node.uPowerFlash = 1;
                    }
                    lv_Items.Items.Add(node);
                }
                UnknownStatus();
            }
        }

         /// <summary>
        /// 装载输入设备列表
        /// </summary>
        private void LoadInputDevices()
        {
            tm_AllowAction.Enabled = true;

            if (lv_Category.SelectedItems.Count > 0)
            {
                DataTable dt = new DataTable();
                if (lv_Category.SelectedItems[0].Tag.ToString() == "999999")
                {
                    dt = DBDevices.DBInputDevAll();
                }
                else
                {
                    dt = DBDevices.DBQueryInputDevicesByType(lv_Category.SelectedItems[0].Tag.ToString());
                }
                lv_DIItems.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    DevListViewItem node = new DevListViewItem();
                    node.Text = row["Name"].ToString();
                    node.Title = row["Name"].ToString();
                    node.Tag = row["ID"].ToString();
                    node.uAddress = Convert.ToInt16(row["Address"]);
                    node.uLine = Convert.ToInt32(row["Line"]);

                    DataTable adt = new DataTable();
                    adt = DBiCoreVal.DBQueryValByItem(row["ID"].ToString());
                    foreach (DataRow dr in adt.Rows)
                    {
                        iCore_Value icv = new iCore_Value();
                        icv.CMD = dr["Command"].ToString();
                        icv.Value = Convert.ToDecimal(dr["Command"]);
                        node.ActionList.Add(icv);
                    }

                    try
                    {
                        node.DefAction = Convert.ToInt32(row["DefAction"]);
                    }
                    catch
                    {
                        node.DefAction = 0;
                    }
                    try
                    {
                        node.ImgGroup = Convert.ToInt32(row["ImgGroup"]);
                    }
                    catch
                    {
                        node.ImgGroup = 0;
                    }
                    try
                    {
                        node.DevIO = Convert.ToInt32(row["IO"]);
                    }
                    catch
                    {
                        node.DevIO = 0;
                    }
                    lv_DIItems.Items.Add(node);
                }
                UnknownStatus();
            }
        }
        /// <summary>
        /// 将lv_Items中的设备状态置成未知
        /// </summary>
        private void UnknownStatus()
        {
            try
            {
                foreach (DevListViewItem item in lv_Items.Items)
                {
                    if (Transport == 1)
                    {
                        if (bConnected)
                        {
                            item.ImageIndex = 3 * item.ImgGroup + 0;
                        }
                        else
                        {
                            item.ImageIndex = 3 * item.ImgGroup + 2;
                        }
                    }
                    else
                    {
                        item.ImageIndex = 3 * item.ImgGroup + 2;
                    }
                }

                foreach (DevListViewItem item in lv_DIItems.Items)
                {
                    item.ImageIndex = 3 * item.ImgGroup + 2;
                }
            }
            catch { }
        }
        /// <summary>
        /// 设备增加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnu_DevAdd_Click(object sender, EventArgs e)
        {
            string TypeID;
            TypeID = lv_Category.SelectedItems[0].Tag.ToString();

            frmDev fdt = new frmDev();
            //fdt.lbl_Group.Visible = true;
            //fdt.lv_Group.Visible = true;
            fdt.lv_Group.Items.Clear();
            DataTable dt = DBDevType.DBDevTypeQuery();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem node = new ListViewItem();
                node.Text = row["Name"].ToString();
                node.Tag = row["ID"].ToString();
                if (node.Tag.ToString() == TypeID)
                {
                    node.Selected = true;
                }
                node.ImageIndex = 2;
                fdt.lv_Group.Items.Add(node);
            }

            if (fdt.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string Name = fdt.txtName.Text;
                    string Address = fdt.txtAddress.Value.ToString();
                    string Line = fdt.txtLine.Value.ToString();
                    int DefAction = fdt.cb_DefAction.SelectedIndex;
                    int DevIO = fdt.cb_IO.SelectedIndex;
                    string powerflash = fdt.txt_PowerFlash.Text;
                    string ImgGroup = fdt.txt_ImageGroup.Text;
                    string Item_Action = fdt.cb_btn_Action.Text;

                    DBDevices.DBDevInsert(Name, fdt.lv_Group.SelectedItems[0].Tag.ToString(), Address, Line, DefAction.ToString(), DevIO.ToString(), powerflash, ImgGroup, Item_Action,"0");
                    LoadDevices();
                    LoadInputDevices();
                }
                catch (Exception err)
                {
                    fdebug.AddInfo("mnu_DevAdd_Click() " + err.Message );
                    //MessageBox.Show(err.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            //}
        }
        /// <summary>
        /// 设备修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnu_DevModify_Click(object sender, EventArgs e)
        {
            if (lv_Items.SelectedItems.Count > 0)
            {
                string TypeID;
                if (lv_Category.SelectedItems[0].Tag.ToString() == "999999")
                {
                    TypeID = DBDevices.DBGetDevGroup(lv_Items.SelectedItems[0].Tag.ToString());
                }
                else
                {
                    TypeID = lv_Category.SelectedItems[0].Tag.ToString();
                }
                frmDev fdt = new frmDev();
                //装载设备信息窗口分组
                fdt.lv_Group.Items.Clear();
                DataTable dt = DBDevType.DBDevTypeQuery();
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem node = new ListViewItem();
                    node.Text = row["Name"].ToString();
                    node.Tag = row["ID"].ToString();
                    node.ImageIndex = 2;
                    if (node.Tag.ToString().Equals(TypeID))
                    {
                        node.Selected = true;
                    }
                    fdt.lv_Group.Items.Add(node);
                }
                DevListViewItem mlvi = (DevListViewItem)lv_Items.SelectedItems[0];
                fdt.txtName.Text = mlvi.Title;
                fdt.txtAddress.Value = Convert.ToInt32(mlvi.uAddress);
                fdt.txtLine.Value = Convert.ToInt32(mlvi.uLine);
                fdt.cb_DefAction.SelectedIndex = Convert.ToInt32(mlvi.DefAction);
                fdt.cb_IO.SelectedIndex = Convert.ToInt32(mlvi.DevIO);

                fdt.DevID =Convert.ToInt32(mlvi.Tag);
                fdt.txt_ImageGroup.Text = mlvi.ImgGroup.ToString();
                fdt.txt_PowerFlash.Text = mlvi.uPowerFlash.ToString();
                fdt.cb_btn_Action.Text = mlvi.Item_Action;

                if (fdt.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string Name = fdt.txtName.Text;
                        string Address = fdt.txtAddress.Value.ToString();
                        string Line = fdt.txtLine.Value.ToString();
                        int DefAction = fdt.cb_DefAction.SelectedIndex;
                        int DevIO=fdt.cb_IO.SelectedIndex;
                        string powerflash = fdt.txt_PowerFlash.Text;
                        string ImgGroup = fdt.txt_ImageGroup.Text;
                        string Item_Action = fdt.cb_btn_Action.Text;
                        int ibutton = 0;
                        DBDevices.DBDevUpdate(mlvi.Tag.ToString(), Name, Address, Line, DefAction.ToString(), DevIO.ToString(), fdt.lv_Group.SelectedItems[0].Tag.ToString(), powerflash, ImgGroup, Item_Action,ibutton.ToString());
                        //mlvi.Text = Name;
                        //mlvi.uAddress = Convert.ToInt16(Address);
                        //mlvi.uLine = Convert.ToInt32(Line);
                        LoadDevices();
                        LoadInputDevices();

                    }
                    catch (Exception err)
                    {
                        fdebug.AddInfo("mnu_DevModify_Click() " + err.Message );
                    }
                }
            }
            else
            {
                MessageBox.Show("请首先选择类别与项目!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// 设备删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnu_DevRemove_Click(object sender, EventArgs e)
        {
            if (lv_Items.SelectedItems.Count > 0)
            {
                foreach (DevListViewItem mlvi in lv_Items.SelectedItems)
                {
                    DBDevices.DBDevDelete(mlvi.Tag.ToString());
                    mlvi.Remove();
                }
            }
            else
            {
                MessageBox.Show("请首先选择类别与项目!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// 查询寄存器
        /// </summary>
        private void InQuireReg()
        {

            try
            {
                foreach (short addr in CurrentAddr)
                {
                    byte[] tempCMD = new byte[8];
                    tempCMD = Relay.CreateCMD(addr, 3, RelayType.QUERYREG);

                    InQuireCMDLIST.Add(tempCMD);
                    tempCMD = Relay.CreateCMD(addr, 4, RelayType.QUERYREG);

                    InQuireCMDLIST.Add(tempCMD);
                }
            }
            catch { }

        }
        //查询IO量
        private void InQuire()
        {
            //获取当前界面中所有地址

            try
            {
                InQuireCMDLIST.Clear();
                InQuireIndex = 0;

                foreach (short addr in CurrentAddr)
                {
                    byte[] tempCMD = new byte[8];
                    tempCMD = Relay.CreateCMD(addr, 0, RelayType.INQUIRE);
                    InQuireCMDLIST.Add(tempCMD);

                    //tempCMD = Relay.CreateCMD(addr, 2, RelayType.INQUIRE);
                    //CMDLIST.Add(tempCMD);
                }

                //byte[] add2 = new byte[]{0x02,0x03,0x00,0x00,0x00,0x08,0x44,0x3F};
                //byte[] add3 = new byte[] { 0x03, 0x03, 0x00, 0x00, 0x00, 0x08, 0x45, 0xEE };
                //CMDLIST.Add(add2);
                //CMDLIST.Add(add3);
                InQuireReg();
            }
            catch { }

            //如果某项目10秒未接到过状态指令，就可任务此项目故障
            foreach (DevListViewItem mlvi in lv_Items.Items)
            {
                if ((DateTime.Now.Ticks / 10000000) - mlvi.LastTime > 10)
                {
                    mlvi.ImageIndex = 3 * mlvi.ImgGroup + 2;
                }
            }

            //如果某项目10秒未接到过状态指令，就可任务此项目故障
            foreach (DevListViewItem mlvi in lv_DIItems.Items)
            {
                if ((DateTime.Now.Ticks / 10000000) - mlvi.LastTime > 10)
                {
                    mlvi.ImageIndex = 3 * mlvi.ImgGroup + 2;
                }
            }
        }
        /// <summary>
        /// 延时函数
        /// </summary>
        /// <param name="delayTime">需要延时多少毫秒</param>
        /// <returns></returns>
        public static bool Delay(int delayTime)
        {
            DateTime now = DateTime.Now;
            int s;
            do
            {
                TimeSpan spand = DateTime.Now - now;
                s = spand.Milliseconds;
                Application.DoEvents();
            }
            while (s < delayTime);
            return true;
        }
        /// <summary>
        /// 设备启动函数
        /// </summary>
        private void PowerON()
        {
            if (lv_Items.SelectedItems.Count>0)
            {
                if (lv_Items.SelectedItems.Count == 1)
                {
                    DevListViewItem mlvi = (DevListViewItem)lv_Items.SelectedItems[0];
                    SendCMD(mlvi.uAddress, mlvi.uLine, RelayType.ON);
                    if (Transport == 1)
                    {
                        mlvi.ImageIndex =3*mlvi.ImgGroup+1;
                    }
                }

                else
                {
                    GroupSelectedSwitch(lv_Items.SelectedItems, RelayType.GROUPON);
                }
            }
            else
            {
                MessageBox.Show("请选择你要开启的设备!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// 设备关闭
        /// </summary>
        private void PowerOFF()
        {
            if (lv_Items.SelectedItems.Count > 0)
            {
                if (lv_Items.SelectedItems.Count == 1)
                {
                    DevListViewItem mlvi = (DevListViewItem)lv_Items.SelectedItems[0];
                    SendCMD(mlvi.uAddress, mlvi.uLine, RelayType.OFF);
                    if (Transport == 1)
                    {
                        mlvi.ImageIndex = 3*mlvi.ImgGroup+0;
                    }
                }

                else
                {
                    GroupSelectedSwitch(lv_Items.SelectedItems, RelayType.GROUPOFF);
                }

            }
            else
            {
                MessageBox.Show("请选择你要停止的设备!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// 向指定端口发送指令
        /// </summary>
        /// <param name="_Address"></param>
        /// <param name="_Line"></param>
        /// <param name="_type"></param>
        private void SendCMD(short _Address, int _Line, RelayType _type)
        {
            byte[] tempCMD = new byte[8];
            tempCMD = Relay.CreateCMD(_Address, _Line, _type);
            SendCMDToBUS(tempCMD);

        }
        /// <summary>
        /// 设备点动  ON-OFF
        /// </summary>
        /// <param name="_Address"></param>
        /// <param name="_Line"></param>
        /// <param name="_type"></param>
        private void SendCMDByIncling(short _Address, int _Line, int times)
        {
            byte[] tempCMD = new byte[8];
            tempCMD = Relay.CreateCMDByInching(_Address, _Line, times);
            SendCMDToBUS(tempCMD);
        }


        /// <summary>
        /// 设备点动
        /// </summary>
        /// <param name="_Address"></param>
        /// <param name="_Line"></param>
        /// <param name="_type"></param>
        private void SendCMDByOFFIncling(short _Address, int _Line, int times)
        {
            byte[] tempCMD = new byte[8];
            tempCMD = Relay.CreateCMDByOFFInching(_Address, _Line, times);
            SendCMDToBUS(tempCMD);
        }

        /// <summary>
        /// 向指定端口发送指令
        /// </summary>
        /// <param name="_Address"></param>
        /// <param name="_Line"></param>
        /// <param name="_type"></param>
        private void SendCMDByFlash(short _Address, int _Line, int times)
        {
            byte[] tempCMD = new byte[8];
            tempCMD = Relay.CreateCMDByFlash(_Address, _Line, times);
            SendCMDToBUS(tempCMD);
        }

        //写一个发送信息到服务端的方法
        public void clientSendMsg(byte[] txtCMsg)
        {
            //获取文本框txtCMsg输入的内容
            //string strClientSendMsg = txtCMsg;
            //将输入的内容字符串转换为机器可以识别的byte数组
            //byte[] arrClientSendMsg = System.Text.Encoding.UTF8.GetBytes(strClientSendMsg);
            //调用客户端套接字发送byte数组
            try
            {
                socketClient.Send(txtCMsg);
            }
            catch(Exception e)
            {
                //fdebug.AddInfo(e.Message);
                EndListen();
            }
        }
        /// <summary>
        /// 串口线程主体
        /// </summary>
        private void Switch(byte[] m_SendCMD)
        {
            try
            {            
                ReceiveEventFlag = true;        //关闭接收事件
                serialPort.DiscardInBuffer();         //清空接收缓冲区    

                if (serialPort == null)
                {
                    if (MessageBox.Show("系统未连接端口，现在是否连接？", "提问", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        BeginListen();
                    }
                }

                if (serialPort.IsOpen)
                {
                    serialPort.Write(m_SendCMD, 0, m_SendCMD.Length);
                }
            }
            catch(Exception e)
            {
                EndListen();
                //fdebug.AddInfo(e.Message);
            }
            ReceiveEventFlag = false;       //打开事件

        }

        private void SendCMDToBUS(byte[] CMD)
        {
            string hex = BitConverter.ToString(CMD);
            fdebug.AddInfo(hex);

            timer_INQUIRE.Enabled = false;
            if (m_UsePool)
            {
                SendToSerialPool(CMD);//发送到所有串口
                SendToTcpPool(CMD);//发送到所有网络池
            }
            else
            {
                if (rb_COM.Checked)
                {
                    //Thread thread = new Thread(new ThreadStart(Switch));
                    //thread.SetApartmentState(ApartmentState.STA);
                    //thread.Start();
                    Switch(CMD);
                }
                if (rb_TCP.Checked)
                {
                    clientSendMsg(CMD);
                }
                if (rb_UDP.Checked)
                {
                    UDP_Client_Send(CMD);

                }
            }
            timer_INQUIRE.Enabled = true;
        }

        private void SendInQuireCMDToBUS(byte[] CMD)
        {
            string hex = BitConverter.ToString(CMD);
            fdebug.AddInfo(hex);

            if (m_UsePool)
            {
                SendToSerialPool(CMD);//发送到所有串口
                SendToTcpPool(CMD);//发送到所有网络池
            }
            else
            {
                if (rb_COM.Checked)
                {
                    //Thread thread = new Thread(new ThreadStart(Switch));
                    //thread.SetApartmentState(ApartmentState.STA);
                    //thread.Start();
                    Switch(CMD);
                }
                if (rb_TCP.Checked)
                {
                    clientSendMsg(CMD);
                }
                if (rb_UDP.Checked)
                {
                    UDP_Client_Send(CMD);

                }
            }
        }

        private void SendToTcpPool(byte[] CMD)
        {
            foreach (Socket sk in l_Sockets)
            {
                try
                {
                    sk.Send(CMD);
                }
                catch 
                {
                    try
                    {
                        //IPEndPoint ep = (IPEndPoint)sk.RemoteEndPoint;

                        //sk.Close();
                        //l_Sockets.Find(sk).i
                        //l_Sockets.Remove(sk);
                        //sk.Connect(ep.Address,ep.Port);
                    }
                    catch (Exception e)
                    {
                        txt_PoolInfo.AppendText(sk.RemoteEndPoint + " " + e.Message + "(" + DateTime.Now + ")\r\n");
                    }
                }
            }


        }
        private void SendToSerialPool(byte[] CMD)
        {

            ReceiveEventFlag = true;        //关闭接收事件

            foreach (SerialPort sp in l_SerialPorts)
            {
                try
                {
                    sp.DiscardInBuffer();         //清空接收缓冲区  
                    //if (sp.IsOpen)
                    {
                        sp.Write(CMD, 0, CMD.Length);
                    }
                }
                catch
                {
                    try
                    {
                        sp.Open();
                    }
                    catch(Exception e)
                    {
                        txt_PoolInfo.AppendText(e.Message +"("+ DateTime.Now+")\r\n");
                    }
                }

            }
            ReceiveEventFlag = false;       //打开事件

        }
        /// <summary>
        /// 变更按钮状态
        /// </summary>
        /// <param name="Enable"></param>
        private void EnableBtn(bool Enable)
        {
            btnPowerON.Enabled = Enable;
            btnPowerOFF.Enabled = Enable;
            btnPowerON_Board.Enabled = Enable;
            btnPowerOFF_Board.Enabled = Enable;
            btnPowerONAll.Enabled = Enable;
            btnPowerOFFAll.Enabled = Enable;
            btnPowerOFF_BUS.Enabled = Enable;
            btnPowerON_BUS.Enabled = Enable;

            btn_TaskRun.Enabled = Enable;
            if (Enable)
            {
                lbl_Connected.ForeColor = Color.Green;
                lbl_Connected.Text = "已成功连接";
            }
            else
            {
                lbl_Connected.ForeColor = Color.Red;
                lbl_Connected.Text = "连接关闭";
                tssl_Info.Text = "";
            }

            bConnected = Enable;
        }
        private void SaveConnectCfg()
        {
            string iniFile = string.Empty;
            iniFile = System.Environment.CurrentDirectory + "\\config.ini";
            if (System.IO.File.Exists(iniFile))
            {
                INIFile.Writue(iniFile, "CONNECTION", "DOMAIN", txtIP.Text);
                INIFile.Writue(iniFile, "CONNECTION", "PORT", txtPort.Text);
                INIFile.Writue(iniFile, "CONNECTION", "SerialPort", cb_SerialPort.Text);
                INIFile.Writue(iniFile, "CONNECTION", "Baud", cb_Band.Text);
            }

        }

        private bool BeginListen()
        {
            bool ret = false;
            if (m_UsePool)
            {
                DataTable dt = new DataTable();
                if (lv_Category.SelectedItems.Count > 0)
                {
                    if (lv_Category.SelectedItems[0].Tag.ToString() == "999999")
                    {
                        dt = DBPool.DBSerialAll();
                    }
                    else
                    {
                        dt = DBPool.DBSerialByGroup(lv_Category.SelectedItems[0].Tag.ToString());
                    }
                }
                
                
                //启动串口池
                if(dt.Rows.Count>0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        SerialPort sp = new SerialPort(dr["SerialPort"].ToString(), 9600, Parity.None, 8);
                        try
                        {               
                            sp.ReceivedBytesThreshold = 8;
                            sp.ReadBufferSize = 8;
                            sp.WriteBufferSize = 8;
                            sp.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);//DataReceived事件委托
                            //读写时间超时 
                            sp.DtrEnable = true;
                            sp.RtsEnable = true;
                            sp.ReadTimeout = ReadTimeout;
                            sp.WriteTimeout = WriteTimeout;
                            sp.Open();
                            l_SerialPorts.Add(sp);
                        }
                        catch (Exception e)
                        {

                            txt_PoolInfo.AppendText(e.Message + "("+DateTime.Now + ")\r\n");
                        }


                    }
                    //interfaceUpdataHandle = new HandleInterfaceUpdataDelegate(SetDevState);
                }
                if (lv_Category.SelectedItems.Count > 0)
                {
                    if (lv_Category.SelectedItems[0].Tag.ToString() == "999999")
                    {
                        dt = DBPool.DBTCPAll();
                    }
                    else
                    {
                        dt = DBPool.DBTCPByGroup(lv_Category.SelectedItems[0].Tag.ToString());
                    }
                }
                
                //启动TCP池
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        try
                        {
                            string[] tmpHostEntry = dr["HostEntry"].ToString().Split(':');
                            //定义一个套字节监听  包含3个参数(IP4寻址协议,流式连接,TCP协议)
                            Socket tmpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                            //客户端同样 需要获取文本框中的IP地址
                            string strDomain = tmpHostEntry[0];
                            string ipAddress =string.Empty;
                            System.Text.RegularExpressions.Regex check = new System.Text.RegularExpressions.Regex(@"^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$");

                            if (!check.IsMatch(strDomain))
                            {
                                IPHostEntry hostEntry = Dns.Resolve(strDomain);
                                IPEndPoint ipEndPoint = new IPEndPoint(hostEntry.AddressList[0], 0);
                                //这就是你想要的
                                ipAddress = ipEndPoint.Address.ToString();
                            }
                            else
                            {
                                ipAddress=strDomain;
                            }
                            IPAddress ipaddress = IPAddress.Parse(ipAddress);
                            //将获取的ip地址和端口号绑定到网络节点endpoint上
                            IPEndPoint endpoint = new IPEndPoint(ipaddress, int.Parse(tmpHostEntry[1]));
                            //注意: 这里是客服端套接字连接到Connect网络节点 不是Bind
                            tmpSocket.Connect(endpoint);
                            //new一个新线程 调用下面的接受服务端发来信息的方法RecMsg
                            //Thread tmpthreadClient = new Thread(RecMsg);
                            //将窗体线程设置为与后台同步
                            //tmpthreadClient.IsBackground = true;
                            //启动线程
                            //tmpthreadClient.Start();
                            HandleInterfaceUpdataDelegate hud = new HandleInterfaceUpdataDelegate(SetDevState);
                            l_Sockets.Add(tmpSocket);

                            object obj = new object[] { this, hud, l_Sockets };
                            WorkerClass wc = new WorkerClass();
                            bool rc = ThreadPool.QueueUserWorkItem(new WaitCallback(wc.RunProcess), obj);

                            ThreadPool.QueueUserWorkItem(new WaitCallback(wc.RunProcess), obj);
                            //l_ClientThreads.Add(tmpthreadClient);
                        }
                        catch (Exception e)
                        {
                            txt_PoolInfo.AppendText(dr["HostEntry"].ToString() + " " + e.Message + "(" + DateTime.Now + ")\r\n");

                        }
                    }
                        //interfaceUpdataHandle = new HandleInterfaceUpdataDelegate(SetDevState);      
                }
                int ConCount=l_SerialPorts.Count + l_Sockets.Count;
                if (ConCount > 0)
                {
                    interfaceUpdataHandle = new HandleInterfaceUpdataDelegate(SetDevState); 

                    tssl_Info.Text = "已成功连接" + ConCount.ToString() + "个端口";
                    btnBeginListen.Enabled = false;
                    btnEndListen.Enabled = true;
                    UnknownStatus();
                    EnableBtn(true);
                    ret = true;
                }
                else
                {
                    tssl_Info.Text = "没有连接端口";
                }

            }
            else
            {
                if (rb_TCP.Checked)
                {
                    try
                    {
                        if (TCP_Connect(txtIP.Text, txtPort.Text))
                        {
                            btnBeginListen.Enabled = false;
                            btnEndListen.Enabled = true;
                            EnableBtn(true);
                            UnknownStatus();
                            EnableBtn(true);
                            ret = true;
                            rb_COM.Enabled = false;
                            rb_TCP.Enabled = false;
                            rb_UDP.Enabled = false;
                            txtPort.Enabled = false;
                            txtIP.Enabled = false;
                        }

                    }
                    catch (Exception err)
                    {
                        fdebug.AddInfo("btnBeginListen_Click() " + err.Message);
                        // MessageBox.Show(err.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    if (rb_UDP.Checked)
                    {
                        UDPServer_Start(txtIP.Text, txtPort.Text);

                        btnBeginListen.Enabled = false;
                        btnEndListen.Enabled = true;
                        EnableBtn(true);
                        rb_COM.Enabled = false;
                        rb_TCP.Enabled = false;
                        rb_UDP.Enabled = false;
                        txtPort.Enabled = false;
                        txtIP.Enabled = false;
                    }
                else
                    if (rb_COM.Checked)
                    {
                        try
                        {
                            if (serialPort == null)
                            {
                                int band = 9600;
                                if (cb_Band.Text.Equals("Flex Wire"))
                                {
                                    band = 115200;
                                }
                                else
                                    band=Convert.ToInt32(cb_Band.Text);

                                serialPort = new SerialPort(cb_SerialPort.Text,band , Parity.None, 8);
                                serialPort.ReceivedBytesThreshold = 8;
                                serialPort.ReadBufferSize = 8;
                                serialPort.WriteBufferSize = 8;
                                serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);//DataReceived事件委托
                                //读写时间超时 
                                serialPort.DtrEnable = true;
                                serialPort.RtsEnable = true;
                                serialPort.ReadTimeout = ReadTimeout;
                                serialPort.WriteTimeout = WriteTimeout;
                                serialPort.Open();
                            }
                            btnBeginListen.Enabled = false;
                            btnEndListen.Enabled = true;

                            UnknownStatus();
                            EnableBtn(true);
                            ret = true;
                            interfaceUpdataHandle = new HandleInterfaceUpdataDelegate(SetDevState);
                            rb_COM.Enabled = false;
                            cb_SerialPort.Enabled = false;
                            rb_TCP.Enabled = false;
                            rb_UDP.Enabled = false;
                            
                        }
                        catch (Exception err)
                        {
                            fdebug.AddInfo("btnBeginListen_Click() " + err.Message );
                            //MessageBox.Show(err.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                SaveConnectCfg();
            }
            timer_INQUIRE.Interval = 100;
            timer_INQUIRE.Enabled = true;
            timer_watchdog.Enabled = m_Reconnection;
            return ret;
        }
        /// <summary>
        /// 连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBeginListen_Click(object sender, EventArgs e)
        {
            BeginListen();
        }
        /// <summary>
        /// 断开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEndListen_Click(object sender, EventArgs e)
        {
            EndListen();
        }
        private void EndListen()
        {
            Abort();

            btnBeginListen.Enabled = true;
            btnEndListen.Enabled = false;

            EnableBtn(false);
            timer_INQUIRE.Enabled = false;
            UnknownStatus();
            EnableBtn(false);
            timer_watchdog.Enabled = false;
            if (!m_UsePool)
            {
                if (rb_COM.Checked)
                {
                    rb_COM.Enabled = true;
                    cb_SerialPort.Enabled = true;
                    rb_TCP.Enabled = true;
                    rb_UDP.Enabled = true;
                }
                else
                {
                    rb_COM.Enabled = true;
                    rb_TCP.Enabled = true;
                    rb_UDP.Enabled = true;
                    txtIP.Enabled = true;
                    txtPort.Enabled = true;
                }
            }
        }
        private void iCore_Run(List<iCore_Value> liv, decimal Value)
        {
            if (liv.Count > 0)
            {
                foreach (iCore_Value iv in liv)
                {
                    RunAction(iv.CMD);
                }
            }
        }
        /// <summary>
        /// 变更设备状态
        /// </summary>
        /// <param name="statemsg"></param>
        private void SetDevState(byte[] statemsg)
        {
            string hex = BitConverter.ToString(statemsg);
            fdebug.AddInfo(hex);

            if (statemsg[0] == 0x22)
            {
                int sum = 0;
                for (int i = 0; i <= 6; i++)
                {
                    sum = sum + statemsg[i];
                }
                if (statemsg[7] == (byte)(sum % 256))
                {
                    if (statemsg[2] == 0x0A)//寄存器
                    {
                        foreach (DevListViewItem item in lv_DIItems.Items)
                        {

                            if ((statemsg[1] == item.uAddress) && (statemsg[3] == item.uLine))
                            {
                                if (statemsg[3] == 4)
                                {
                                    item.LastTime = DateTime.Now.Ticks / 10000000;
                                    if (item.msg != statemsg)
                                    {
                                        item.Text = item.Title + "\r\n湿度：" + (statemsg[6] - deviation_hm).ToString();
                                        item.msg = statemsg;
                                        decimal tv = Convert.ToDecimal(statemsg[6].ToString());
                                        iCore_Run(item.ActionList, tv);
                                    }
                                }

                                if (statemsg[3] == 3)
                                {

                                    item.LastTime = DateTime.Now.Ticks / 10000000;
                                    if ((item.msg[4] != statemsg[4]) || (item.msg[6] != statemsg[6]))
                                    {
                                        item.Text = item.Title + "\r\n温度：" + (statemsg[6] - deviation_temp).ToString() + "." + statemsg[5].ToString();
                                        item.msg = statemsg;
                                        decimal tv = Convert.ToDecimal(statemsg[6].ToString() + "." + statemsg[5].ToString());
                                        iCore_Run(item.ActionList, tv);
                                    }

                                    //item.ImageIndex = 3 * item.ImgGroup + devstate;
                                }
                            }
                        }
                    }

                    if (statemsg[2] == 0x11)//湿度类 DHT11
                    {
                        //statemsg[4]  湿度
                        //statemsg[6]  温度
                        foreach (DevListViewItem item in lv_DIItems.Items)
                        {

                            if ((statemsg[1] == item.uAddress) && (statemsg[3] == item.uLine))
                            {
                                int devstate = 0;
                                if (statemsg[6] == 0)
                                {
                                    devstate = 0;
                                }
                                else
                                {
                                    devstate = 1;
                                }


                                item.LastTime = DateTime.Now.Ticks / 10000000;
                                if (item.msg!= statemsg)
                                {
                                    item.Text = item.Title + "\r\n湿度：" + (statemsg[6] - deviation_hm).ToString();
                                    item.msg = statemsg;
                                    decimal tv = Convert.ToDecimal(statemsg[6].ToString());
                                    iCore_Run(item.ActionList, tv);
                                }

                                item.ImageIndex = 3 * item.ImgGroup + devstate;
                            }
                        }
                    }
                    if (statemsg[2] == 0x12)//温度类 DS18B20
                    {
                        //statemsg[5]  温度小数
                        //statemsg[6]  温度整数
                        foreach (DevListViewItem item in lv_DIItems.Items)
                        {
                            if ((statemsg[1] == item.uAddress) && (statemsg[3] == item.uLine))
                            {
                                int devstate = 0;
                                if (statemsg[6] == 0)
                                {
                                    devstate = 0;
                                }
                                else
                                {
                                    devstate = 1;
                                }


                                item.LastTime = DateTime.Now.Ticks / 10000000;
                                if ((item.msg[4] != statemsg[4]) || (item.msg[6] != statemsg[6]))
                                {
                                    item.Text = item.Title + "\r\n温度：" + (statemsg[6] - deviation_temp).ToString() + "." + statemsg[5].ToString();
                                    item.msg = statemsg;
                                    decimal tv = Convert.ToDecimal(statemsg[6].ToString() + "." + statemsg[5].ToString());
                                    iCore_Run(item.ActionList, tv);
                                }

                                item.ImageIndex = 3 * item.ImgGroup + devstate;
                            }
                            item.firstRun = false;
                        }
                    }
                    if (statemsg[2] == 0x10)//IO量 继电器类及输入检测类状态数据
                    {
                        foreach (DevListViewItem item in lv_Items.Items)
                        {
                            if (statemsg[1] == item.uAddress)
                            {
                                int devstate = Relay.GetState(statemsg, item.uLine);
                                item.LastTime = DateTime.Now.Ticks / 10000000;

                                if (item.msg != statemsg)
                                {
                                    item.msg = statemsg;
                                    iCore_Run(item.ActionList, devstate);

                                }
                                item.ImageIndex = 3 * item.ImgGroup + devstate;

                            }
                        }

                        //输入项目
                        foreach (DevListViewItem item in lv_DIItems.Items)
                        {
                            if (statemsg[1] == item.uAddress)
                            {
                                int devstate = Relay.GetInputState(statemsg, item.uLine);

                                item.LastTime = DateTime.Now.Ticks / 10000000;

                                if (item.msg != statemsg)
                                {
                                    item.msg = statemsg;
                                    iCore_Run(item.ActionList, devstate);

                                }
                                item.ImageIndex = 3 * item.ImgGroup + devstate;
                            }
                        }
                    }
                }
            }
            //else
            //{
            //    //RX:01 03 10 1F 40 1F 41 1F 43 1F 44 1F 47 1F 48 00 00 00 00 27 2E 
            //    int addr = statemsg[0];
            //    int op = statemsg[1];
            //    int count = statemsg[2];
            //    if ((op == 0x03) && (count == 0x10))
            //    {
            //        int[] value=new int[8];
            //        value[0] = statemsg[3] << 8 + statemsg[4];
            //        value[1] = statemsg[5] << 8 + statemsg[6];
            //        value[2] = statemsg[7] << 8 + statemsg[8];
            //        value[3] = statemsg[9] << 8 + statemsg[10];
            //        value[4] = statemsg[11] << 8 + statemsg[12];
            //        value[5] = statemsg[13] << 8 + statemsg[14];
            //        value[6] = statemsg[15] << 8 + statemsg[16];
            //        value[7] = statemsg[17] << 8 + statemsg[18];

            //        foreach (DevListViewItem item in lv_Items.Items)
            //        {
            //            item.Text = "电流：" + (value[item.uLine]/1000).ToString()+" A";
            //        }
            //    }

            //}
        }

        private void RunGroup(string Group)
        {
            DataTable dt = DBDevices.DBQueryDevicesByGroup(Group);//获取组下面的所有项目
            foreach (DataRow row in dt.Rows)
            {
                try
                {
                    RelayType rt = RelayType.OFF;
                    if (Convert.ToBoolean(row["DefAction"]))
                    {
                        rt = RelayType.ON;
                    }
                    //MessageBox.Show(row["Address"].ToString());
                    SendCMD(Convert.ToInt16(row["Address"]), Convert.ToInt16(row["Line"]), rt);

                }
                catch { }
            }
        }
        //终止
        private void Abort()
        {
            try
            {
                if (m_UsePool)
                {
                    if (l_SerialPorts.Count > 0)                //关闭所有串口
                    {
                        foreach (SerialPort sp in l_SerialPorts)
                        {
                            sp.Close();
                        }
                        l_SerialPorts.Clear();
                    }
                    if (l_Sockets.Count > 0)                    //关闭Socket
                    {
                        foreach (Socket sc in l_Sockets)
                        {
                            sc.Close();
                        }
                    }
                }
                else
                {
                    try
                    {
                        if (socketClient.Connected)
                        {
                            //终止线程
                            threadClient.Abort();
                            //关闭socket
                            socketClient.Close();

                            threadClient = null;
                            socketClient = null;
                        }
                    }
                    catch { };

                    try
                    {
                        if (serialPort.IsOpen)
                        {
                            serialPort.Close();
                            serialPort = null;
                        }
                    }
                    catch { };

                    try
                    {
                        UDPServer_Stop();
                    }
                    catch { }
                }
            }
            catch { }
        }

        //DataReceived事件委托方法
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (ReceiveEventFlag) return;
            try
            {
                if (m_UsePool)
                {
                    foreach (SerialPort sp in l_SerialPorts)
                    {
                        byte[] ds = new byte[sp.BytesToRead];

                        int len = sp.Read(ds, 0, ds.Length);

                        if (len > 0)
                        {
                            //SetDevState(ds);
                            this.Invoke(interfaceUpdataHandle, ds);
                        }
                    }
                }
                else
                {
                    byte[] ds = new byte[serialPort.BytesToRead];

                    int len = serialPort.Read(ds, 0, ds.Length);

                    if (len > 0)
                    {
                        //SetDevState(ds);
                        this.Invoke(interfaceUpdataHandle, ds);
                    }
                }
            }
            catch(Exception err)
            {
                EndListen();
                //fdebug.AddInfo(err.Message);
            }
        }

        private void btnPowerON_Click(object sender, EventArgs e)
        {
            PowerON();
        }

        private void btnPowerOFF_Click(object sender, EventArgs e)
        {
            PowerOFF();
        }

        private void timer_INQUIRE_Tick(object sender, EventArgs e)
        {
            if (Transport == 0)
            {
                if (InQuireCMDLIST.Count > 0)
                {
                    if (InQuireIndex < (InQuireCMDLIST.Count))
                    {
                        SendInQuireCMDToBUS(InQuireCMDLIST[InQuireIndex]);
                        InQuireIndex++;
                    }
                    else
                    {
                        InQuireIndex = 0;
                        if (!m_ActiveQuery)
                            timer_INQUIRE.Interval = 1000;
                        else
                            timer_INQUIRE.Interval = Convert.ToInt32(nud_Delay.Value);
                    }
                }
            }
        }

        private void btnPowerOFF_Board_Click(object sender, EventArgs e)
        {
            Delay(100);
            foreach (short addr in CurrentAddr)
            {
                SendCMD(addr, 0x0000, RelayType.BYTECTRL);
            }
            if (Transport == 1)
            {
                foreach (DevListViewItem mlvi in lv_Items.Items)
                {
                    mlvi.ImageIndex = 3*mlvi.ImgGroup+0;
                }
            }
        }

        private void btnPowerON_Board_Click(object sender, EventArgs e)
        {
            Delay(100);
            foreach (short addr in CurrentAddr)
            {
                SendCMD(addr, 0xFFFF, RelayType.BYTECTRL);
            }
            if (Transport == 1)
            { 
                foreach(DevListViewItem mlvi in lv_Items.Items)
                {
                    mlvi.ImageIndex = 3*mlvi.ImgGroup+1;
                }
            }
        }

        private void btnPowerONAll_Click(object sender, EventArgs e)
        {
            GroupAllSwitch(lv_Items.Items, RelayType.GROUPON);
        }

        private void btnPowerOFFAll_Click(object sender, EventArgs e)
        {
            GroupAllSwitch(lv_Items.Items, RelayType.GROUPOFF);
        }
        //已选项目执行组命令
        private void GroupSelectedSwitch(ListView.SelectedListViewItemCollection Items, RelayType SW)
        {
            Delay(100);
            foreach (short addr in CurrentAddr)
            {
                int uLine = 0;
                foreach (DevListViewItem item in Items)
                {
                    if (item.uAddress == addr)
                    {
                        uLine += 1 << (item.uLine - 1);

                        if ((Transport == 1) && (SW == RelayType.GROUPON))
                        {
                            item.ImageIndex =3*item.ImgGroup+1;
                        }
                        if ((Transport == 1) && (SW == RelayType.GROUPOFF))
                        {
                            item.ImageIndex = 3 * item.ImgGroup + 0;
                        }
                    }
                }

                SendCMD(addr, uLine, SW);
            }
        }
        private void GroupAllSwitch(ListView.ListViewItemCollection Items,RelayType SW)
        {
            Delay(100);
            foreach (short addr in CurrentAddr)
            {
                int uLine = 0;
                foreach (DevListViewItem item in Items)
                {
                    if (item.uAddress == addr)
                    {
                        uLine += 1 << (item.uLine - 1);
                        //MessageBox.Show(uLine.ToString());

                        if ((Transport == 1) && (SW == RelayType.GROUPON))
                        {
                            item.ImageIndex = 3 * item.ImgGroup + 1;
                        }
                        if ((Transport == 1) && (SW == RelayType.GROUPOFF))
                        {
                            item.ImageIndex = 3 * item.ImgGroup + 0;
                        }
                    }
                }

                SendCMD(addr, uLine, SW);
            }
        }

        
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDevices();
            LoadInputDevices();
            InQuire();
        }

        private void mnu_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnu_Help_Click(object sender, EventArgs e)
        {
            Process.Start("IEXPLORE.EXE", "http://www.doqu8.com");//调用IE打开指定网页
        }

        private void mnu_About_Click(object sender, EventArgs e)
        {
            frmAbout ab = new frmAbout();
            ab.ShowDialog();
        }
        /// <summary>
        /// 任务增加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnu_AddTask_Click(object sender, EventArgs e)
        {
            frmAddTask fat = new frmAddTask();
            fat.Default();
            if (fat.ShowDialog() == DialogResult.OK)
            {
                string datetime=string .Empty;
                switch(fat.cb_TaskType.SelectedIndex)
                {                    
                    case 0:
                        datetime="每日;"+fat.mtxt_Time.Text;
                        break;
                    case 1:
                        datetime=fat.dt_Date.Value.Date.ToShortDateString()+";"+fat.mtxt_Time.Text;
                        break;

                    //default:
                    //    datetime="每日;"+fat.mtxt_Time.Text;
                    //    break;
                }
                DBTasks.DBTasksInsert(lv_Items.SelectedItems[0].Tag.ToString(), fat.cb_TaskType.Text, datetime, fat.cb_Action.Text);
                LoadTasks();
            }
        }
        /// <summary>
        /// 装载任务
        /// </summary>
        private void LoadTasks()
        {
            if (TaskLock)
            {
                return;
            }
            DataTable dt = new DataTable();
            if (lv_Items.SelectedItems.Count > 0)
            {
                dt = DBTasks.DBQueryTasksByItem(lv_Items.SelectedItems[0].Tag.ToString());

                lv_TaskMgr.Items.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    DevListViewItem node = new DevListViewItem();
                    node.Text = row["Name"].ToString();
                    node.Tag = row["ID"].ToString();
                    node.uAddress = Convert.ToInt16(row["Address"]);
                    node.uLine = Convert.ToInt32(row["Line"]);
                    node.SubItems.Add(row["Time"].ToString());
                    node.SubItems.Add(row["TaskType"].ToString());
                    node.SubItems.Add(row["Action"].ToString());
                    node.Checked = true;
                    lv_TaskMgr.Items.Add(node);
                }
            }
            else
            {
                //dt = DBTasks.DBTasksAll();
                LoadGroupTasks();
            }


        }
        /// <summary>
        /// 装载分组任务
        /// </summary>
        private void LoadGroupTasks()
        {
            if (TaskLock)
            {
                return;
            }
            DataTable dt = new DataTable();
            if (lv_Category.SelectedItems.Count > 0)
            {
                if (lv_Category.SelectedItems[0].Tag.ToString() == "999999")
                {
                    dt = DBTasks.DBTasksAll();

                    lv_TaskMgr.Items.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        DevListViewItem node = new DevListViewItem();
                        node.Text = row["Name"].ToString();
                        node.Tag = row["ID"].ToString();
                        node.uAddress = Convert.ToInt16(row["Address"]);
                        node.uLine = Convert.ToInt32(row["Line"]);
                        node.SubItems.Add(row["Time"].ToString());
                        node.SubItems.Add(row["TaskType"].ToString());
                        node.SubItems.Add(row["Action"].ToString());
                        node.Checked = true;
                        lv_TaskMgr.Items.Add(node);
                    }
                }
                else
                {
                    lv_TaskMgr.Items.Clear();
                    foreach (DevListViewItem mlvi in lv_Items.Items)
                    {
                        dt = DBTasks.DBQueryTasksByItem(mlvi.Tag.ToString());
                        foreach (DataRow row in dt.Rows)
                        {
                            DevListViewItem node = new DevListViewItem();
                            node.Text = row["Name"].ToString();
                            node.Tag = row["ID"].ToString();
                            node.uAddress = Convert.ToInt16(row["Address"]);
                            node.uLine = Convert.ToInt32(row["Line"]);
                            node.SubItems.Add(row["Time"].ToString());
                            node.SubItems.Add(row["TaskType"].ToString());
                            node.SubItems.Add(row["Action"].ToString());
                            node.Checked = true;
                            lv_TaskMgr.Items.Add(node);
                        }
                    }
                }
            }

        }
        private void mnu_TaskMgr_Click(object sender, EventArgs e)
        {
            mnu_TaskMgr.Checked=!mnu_TaskMgr.Checked;
            pl_TaskMgr.Visible = mnu_TaskMgr.Checked;

            string iniFile = string.Empty;
            iniFile = System.Environment.CurrentDirectory + "\\config.ini";
            if (System.IO.File.Exists(iniFile))
            {
                INIFile.Writue(iniFile, "VIEW", "ShowTasks", mnu_TaskMgr.Checked.ToString());
            }
        }

        private void btn_TaskRun_Click(object sender, EventArgs e)
        {
            timer_Task.Enabled = true;
            btn_TaskRun.Enabled = false;
            btn_TaskStop.Enabled = true;
        }
        /// <summary>
        /// 删除任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnu_RemoveTask_Click(object sender, EventArgs e)
        {
            if (lv_TaskMgr.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lvi in lv_TaskMgr.SelectedItems)
                {
                    DBTasks.DBTasksDelete(lvi.Tag.ToString());
                    lvi.Remove();
                }
            }
            else
            {
                MessageBox.Show("请选择你要删除的任务!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// 任务修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnu_modifyTask_Click(object sender, EventArgs e)
        {
            if (lv_TaskMgr.SelectedItems.Count > 0)
            {

                frmAddTask fat = new frmAddTask();
                string[] dt = lv_TaskMgr.SelectedItems[0].SubItems[1].Text.Split(';');
                if (dt[0] != "每日")
                {
                    fat.dt_Date.Value = Convert.ToDateTime(dt[0]);
                }

                fat.mtxt_Time.Text = dt[1];
                if (lv_TaskMgr.SelectedItems[0].SubItems[2].Text == "每日执行")
                {
                    fat.cb_TaskType.SelectedIndex = 0;
                }
                else
                {
                    fat.cb_TaskType.SelectedIndex = 1;
                }
                int index = 0;
                switch (lv_TaskMgr.SelectedItems[0].SubItems[3].Text)
                {
                    case "启动":
                        index = 0;
                        break;
                    case "关闭":
                        index = 1;
                        break;
                    case "状态翻转":
                        index = 2;
                        break;
                }
                fat.cb_Action.SelectedIndex = index;

                if (fat.ShowDialog() == DialogResult.OK)
                {
                    string datetime = string.Empty;
                    switch (fat.cb_TaskType.SelectedIndex)
                    {
                        case 0:
                            datetime = "每日;" + fat.mtxt_Time.Text;
                            break;
                        case 1:
                            datetime = fat.dt_Date.Value.Date.ToShortDateString() + ";" + fat.mtxt_Time.Text;
                            break;
                        default:
                            datetime = "每日;" + fat.mtxt_Time.Text;
                            break;
                    }
                    DBTasks.DBTasksUPdate(fat.cb_TaskType.Text, datetime, fat.cb_Action.Text, lv_TaskMgr.SelectedItems[0].Tag.ToString());
                    LoadTasks();
                }
            }
            else
            {
                MessageBox.Show("请选择你要修改的任务!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lv_Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void mnu_CheckedAll_Click(object sender, EventArgs e)
        {
            CheckedAll(true);
        }
        private void CheckedAll(bool Checked)
        {
            if (lv_TaskMgr.Items.Count > 0)
            {
                foreach (ListViewItem lvi in lv_TaskMgr.Items)
                {

                    lvi.Checked = Checked;
                }
            }
        }

        private void mnu_UNCheckedAll_Click(object sender, EventArgs e)
        {
            CheckedAll(false);
        }

        private void mnu_AllTasks_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DBTasks.DBTasksAll();

            lv_TaskMgr.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                DevListViewItem node = new DevListViewItem();
                node.Text = row["Name"].ToString();
                node.Tag = row["ID"].ToString();
                node.uAddress = Convert.ToInt16(row["Address"]);
                node.uLine = Convert.ToInt32(row["Line"]);
                node.SubItems.Add(row["Time"].ToString());
                node.SubItems.Add(row["TaskType"].ToString());
                node.SubItems.Add(row["Action"].ToString());
                node.Checked = true;
                lv_TaskMgr.Items.Add(node);

            }
        }
        /// <summary>
        /// 定时器执行任务-主体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Task_Tick(object sender, EventArgs e)
        {            
            foreach (DevListViewItem lvi in lv_TaskMgr.CheckedItems)
            {
                bool taskrun=false;

                string[] dt = lvi.SubItems[1].Text.Split(';');
                DateTime dtnow = DateTime.Now;
                DateTime dttask = new DateTime();

                if (lvi.SubItems[2].Text.Equals("每日执行"))
                {
                    dttask = Convert.ToDateTime(dt[1]);
                    if (dtnow.Hour == dttask.Hour && dtnow.Minute == dttask.Minute && dtnow.Second == dttask.Second)
                    {
                        taskrun=true;
                    }
                }
                else
                {
                    dttask =Convert.ToDateTime(dt[0]+" "+dt[1]);
                    if (dtnow.Hour == dttask.Hour && dtnow.Minute == dttask.Minute && dtnow.Second == dttask.Second && dtnow.Year == dttask.Year && dtnow.Month == dttask.Month && dttask.Day == dttask.Day)
                    {
                        taskrun = true;
                    }
                }
                if(taskrun)
                {
                    switch (lvi.SubItems[3].Text)
                    {
                        case "启动":
                            TaskPowerON(lvi.uAddress, lvi.uLine);
                            break;
                        case "关闭":
                            TaskPowerOFF(lvi.uAddress, lvi.uLine);
                            break;
                        case "状态翻转":
                            //MessageBox.Show("状态翻转");
                            break;
                    }
                }

            }
        }

        private void btn_TaskStop_Click(object sender, EventArgs e)
        {
            timer_Task.Enabled = false;
            btn_TaskRun.Enabled = true;
            btn_TaskStop.Enabled = false;
        }

        private void TaskPowerON(short Address, int Line)
        {
            SendCMD(Address, Line, RelayType.ON);
        }

        private void TaskPowerOFF(short Address,int Line)
        {
            SendCMD(Address, Line, RelayType.OFF);
        }

        private void mnu_TaskLock_Click(object sender, EventArgs e)
        {
            mnu_TaskLock.Checked = !mnu_TaskLock.Checked;
            TaskLock = mnu_TaskLock.Checked;
            LockTaskList(!TaskLock);
        }
        /// <summary>
        /// 装载任务列表
        /// </summary>
        /// <param name="Enable"></param>
        private void LockTaskList(bool Enable)
        {
            mnu_modifyTask.Enabled=Enable;
            mnu_RemoveTask.Enabled=Enable;
            mnu_AllTasks.Enabled=Enable;
            mnu_CheckedAll.Enabled=Enable;
            mnu_UNCheckedAll.Enabled = Enable;
        }

        private void rbCOM_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rb_COM.Checked)
            {
                txtIP.Enabled = false;
                txtPort.Enabled = false;
                cb_SerialPort.Enabled = true;
                cb_Band.Enabled = true;
                cb_SerialPort.Items.Clear();
                cb_SerialPort.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            }
        }

        private void rbNetWork_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rb_TCP.Checked)
            {
                txtIP.Enabled = true;
                txtPort.Enabled = true;
                cb_Band.Enabled = false;
                cb_SerialPort.Enabled = false;
            }
        }

        #region "网络部分"
        /// <summary>
        /// 网络连接部分
        /// </summary>
        private Socket socketClient = null;
        Thread threadClient = null;
        public bool TCP_Connect(string IP, string Port)
        {
            try
            {
                //定义一个套字节监听  包含3个参数(IP4寻址协议,流式连接,TCP协议)
                socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //客户端同样 需要获取文本框中的IP地址
                string strDomain = IP;

                string ipAddress = string.Empty;
                System.Text.RegularExpressions.Regex check = new System.Text.RegularExpressions.Regex(@"^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$");

                if (!check.IsMatch(strDomain))
                {
                    IPHostEntry hostEntry = Dns.Resolve(strDomain);
                    IPEndPoint ipEndPoint = new IPEndPoint(hostEntry.AddressList[0], 0);
                    //这就是你想要的
                    ipAddress = ipEndPoint.Address.ToString();
                }
                else
                {
                    ipAddress = strDomain;
                }

                IPAddress ipaddress = IPAddress.Parse(ipAddress);
                //将获取的ip地址和端口号绑定到网络节点endpoint上
                IPEndPoint endpoint = new IPEndPoint(ipaddress, int.Parse(Port));
                //注意: 这里是客服端套接字连接到Connect网络节点 不是Bind
                socketClient.Connect(endpoint);
                //new一个新线程 调用下面的接受服务端发来信息的方法RecMsg
                threadClient = new Thread(RecMsg);
                //将窗体线程设置为与后台同步
                threadClient.IsBackground = true;
                //启动线程
                threadClient.Start();
                interfaceUpdataHandle = new HandleInterfaceUpdataDelegate(SetDevState);
                return true;
            }
            catch (Exception err)
            {
                fdebug.AddInfo("Connect() " + err.Message );
                //MessageBox.Show(err.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        ////网络连接 消息接收
        //定义一个接受服务端发来信息的方法
        private void RecMsg()
        {
            while (true) //持续监听服务端发来的消息
            {
                try
                {
                    //客户端 定义一个1M的byte数组空间
                    byte[] arrRecMsg = new byte[8];
                    //定义byte数组的长度
                    int length = socketClient.Receive(arrRecMsg);
                    if (length == 8)
                    {
                        //SetDevState(arrRecMsg);
                        this.Invoke(interfaceUpdataHandle, arrRecMsg);
                    }
                    //arrRecMsg 接收到的物理数据

                    //将byte数组转换为人可以看懂的字符串
                    //string strRecMsg = System.Text.Encoding.UTF8.GetString(arrRecMsg, 0, length);
                }
                catch(Exception e)
                {
                    //fdebug.AddInfo(e.Message);
                    EndListen();
                }

            }
        }


        Thread UDPThread = null;
        int UDP_Server_Port = 0;
        string UDP_IP = string.Empty;
        private void UDPServer_Start(string IP,string Port)
        {
            UDP_Server_Port = Convert.ToInt32(Port);

            string strDomain = IP;

            string ipAddress = string.Empty;
            System.Text.RegularExpressions.Regex check = new System.Text.RegularExpressions.Regex(@"^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$");

            if (!check.IsMatch(strDomain))
            {
                IPHostEntry hostEntry = Dns.Resolve(strDomain);
                IPEndPoint ipEndPoint = new IPEndPoint(hostEntry.AddressList[0], 0);
                //这就是你想要的
                UDP_IP = ipEndPoint.Address.ToString();
            }
            else
            {
                UDP_IP = strDomain;
            } 

            UDPThread = new Thread(new ThreadStart(ThreadCallBack));
            UDPThread.Start();
            interfaceUpdataHandle = new HandleInterfaceUpdataDelegate(SetDevState);
        }
        UdpClient UDPSVR = null;
        IPEndPoint iep = null;

        private void ThreadCallBack()
        {
            UDPSVR = new UdpClient(UDP_Server_Port);
            iep = new IPEndPoint(IPAddress.Any, UDP_Server_Port);
            while (true)
            {
                byte[] bData = UDPSVR.Receive(ref iep);
                this.Invoke(interfaceUpdataHandle, bData);
            }

            //server.Close();
            //server = null;
        }

        private void UDPServer_Stop()
        {
            if (UDPSVR != null)
            {
                UDPSVR.Close();
                UDPSVR = null;
            }

            if (UDPThread != null)
            {
                UDPThread.Abort();
                Thread.Sleep(30);
                UDPThread = null;
            }
        }

        private void UDP_Client_Send(byte[] m_SendCMD)
        {


            IPAddress ipaddress = IPAddress.Parse(UDP_IP);

            IPEndPoint endpoint = new IPEndPoint(ipaddress, UDP_Server_Port);

            UdpClient client = new UdpClient();
            client.Send(m_SendCMD, m_SendCMD.Length, endpoint);
            client.Close();
            client = null;
        }
        #endregion

        private void nud_Delay_ValueChanged(object sender, EventArgs e)
        {
            timer_INQUIRE.Interval =Convert.ToInt32(nud_Delay.Value);
        }

        private void mnu_ShowTimer_Click(object sender, EventArgs e)
        {
            ShowTimer();
        }
        private void ShowTimer()
        {
            Process.Start("Timer.EXE");//调用时钟
        }

        private void mnu_GroupTasks_Click(object sender, EventArgs e)
        {
            frmAddTask fat = new frmAddTask();
            fat.Default();
            if (fat.ShowDialog() == DialogResult.OK)
            {
                string datetime = string.Empty;
                switch (fat.cb_TaskType.SelectedIndex)
                {
                    case 0:
                        datetime = "每日;" + fat.mtxt_Time.Text;
                        break;
                    case 1:
                        datetime = fat.dt_Date.Value.Date.ToShortDateString() + ";" + fat.mtxt_Time.Text;
                        break;

                    //default:
                    //    datetime="每日;"+fat.mtxt_Time.Text;
                    //    break;
                }
                foreach (DevListViewItem mlvi in lv_Items.Items)
                {
                    DBTasks.DBTasksInsert(mlvi.Tag.ToString(), fat.cb_TaskType.Text, datetime, fat.cb_Action.Text);
                }
                LoadTasks();
            }
        }

        private void PowerSwitch()
        {
            if (((DevListViewItem)lv_Items.SelectedItems[0]).ImageIndex == 3 * ((DevListViewItem)lv_Items.SelectedItems[0]).ImgGroup + 1)
            {
                PowerOFF();
                P_regionControl.btn_PowerSwitch.Text = "启动";
            }
            else
            {
                PowerON();
                P_regionControl.btn_PowerSwitch.Text = "停止";
            }
            
        }

        private void OnFlash()
        {
            if (lv_Items.SelectedItems.Count > 0)
            {
                if (lv_Items.SelectedItems.Count == 1)
                {
                    DevListViewItem mlvi = (DevListViewItem)lv_Items.SelectedItems[0];
                    SendCMDByOFFIncling(mlvi.uAddress, mlvi.uLine, mlvi.uPowerFlash);
                }
            }
            else
            {
                MessageBox.Show("请选择你要开启的设备!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 设备启动函数
        /// </summary>
        private void FlashDev(bool flash)
        {
            if (lv_Items.SelectedItems.Count > 0)
            {
                if (lv_Items.SelectedItems.Count == 1)
                {
                    DevListViewItem mlvi = (DevListViewItem)lv_Items.SelectedItems[0];
                    int uLine = 0;
                    if (flash)
                    {
                        uLine += 1 << (mlvi.uLine - 1);
                    }
                    SendCMDByFlash(mlvi.uAddress, uLine, mlvi.uPowerFlash);
                }

            }
            else
            {
                MessageBox.Show("请选择你要闪烁的设备!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cb_SerialPort_DropDown(object sender, EventArgs e)
        {
            EnumCOMPort();
        }

        private void lv_Items_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (lv_Items.SelectedItems.Count == 1)
                {
                    if (m_UseSafetyOperations)
                    {
                        PopupControlHost _regionHost;
                        RegionControl _regionControl = new RegionControl();

                        _regionControl.label1.Visible = true;
                        _regionControl.label2.Visible = true;
                        _regionControl.lbl_Address.Visible = true;
                        _regionControl.lbl_Line.Visible = true;


                            _regionControl.btn_Run.Visible = true;
                            _regionControl.btn_Run.Text = "手动";

                        _regionControl.lbl_Address.Text = ((DevListViewItem)lv_Items.SelectedItems[0]).uAddress.ToString();
                        _regionControl.lbl_Line.Text = ((DevListViewItem)lv_Items.SelectedItems[0]).uLine.ToString();


                            //if (((DevListViewItem)lv_Items.SelectedItems[0]).uPowerFlash > 0)
                            //{
                            //    _regionControl.btn_PowerSwitch.Visible = false;
                            //    _regionControl.btn_PowerFlash.Visible = true;
                            //    _regionControl.btn_Flash.Visible = true;

                            //    if (((DevListViewItem)lv_Items.SelectedItems[0]).bFlash)
                            //    {
                            //        //_regionControl.btn_Flash.Text = "停止闪烁";
                            //        _regionControl.btn_Flash.Enabled = false;
                            //        _regionControl.btn_PowerFlash.Enabled = false;
                            //    }
                            //    else
                            //    {
                            //        //_regionControl.btn_Flash.Text = "闪烁";
                            //        _regionControl.btn_Flash.Enabled = true;
                            //        _regionControl.btn_PowerFlash.Enabled = true;
                            //    }
                            //}

                            //if (((DevListViewItem)lv_Items.SelectedItems[0]).uPowerFlash == 0)
                            //{
                            //    _regionControl.btn_PowerSwitch.Visible = true;
                            //    _regionControl.btn_Flash.Visible = false;
                            //    _regionControl.btn_PowerFlash.Visible = false;

                                if (((DevListViewItem)lv_Items.SelectedItems[0]).ImageIndex == 3 * ((DevListViewItem)lv_Items.SelectedItems[0]).ImgGroup + 1)
                                {
                                    _regionControl.btn_PowerSwitch.Text = "停止";
                                    //_regionControl.btn_PowerFlash.Enabled = false;
                                    //_regionControl.btn_Flash.Visible = false;
                                }
                                else
                                {
                                    _regionControl.btn_PowerSwitch.Text = "启动";
                                    //_regionControl.btn_PowerFlash.Enabled = true;
                                    //_regionControl.btn_Flash.Visible = true;
                                }
                            //}
                        _regionControl.btn_Run.MouseDown += delegate(object s, MouseEventArgs ee)
                        {
                            PowerON();
                        };
                        _regionControl.btn_Run.MouseUp += delegate(object s, MouseEventArgs ee)
                        {
                            PowerOFF();
                        };
                        _regionControl.btn_PowerSwitch.Click += delegate(object s, EventArgs ee)
                        {
                            PowerSwitch();
                        };
                        _regionControl.btn_PowerFlash.Click += delegate(object s, EventArgs ee)
                        {
                            OnPowerFlash();
                        };
                        _regionControl.btn_Flash.Click += delegate(object s, EventArgs ee)
                        {
                            OnFlash();
                        };
                        _regionHost = new PopupControlHost(_regionControl);

                        _regionHost.ChangeRegion = true;//设置显示区域。
                        _regionHost.Opacity = 0.8F;//设置透明度。

                        Rectangle rc = new Rectangle();
                        rc = lv_Items.SelectedItems[0].Bounds;
                        _regionHost.Show(lv_Items, rc, true);

                        P_regionControl = _regionControl;
                    }
                    else
                    {
                        if (((DevListViewItem)lv_Items.SelectedItems[0]).uPowerFlash > 0)
                        {
                            OnPowerFlash();

                        }
                        else
                        {
                            if (((DevListViewItem)lv_Items.SelectedItems[0]).ImageIndex == 3 * ((DevListViewItem)lv_Items.SelectedItems[0]).ImgGroup + 1)
                            {
                                PowerOFF();
                            }
                            else
                            {
                                PowerON();
                            }
                        }

                    }
                }
            }
            else
            {
                //MessageBox.Show("你按下鼠标右键", "提示");
            }
        }

        private void OnPowerFlash()
        {
            if (lv_Items.SelectedItems.Count > 0)
            {
                if (lv_Items.SelectedItems.Count == 1)
                {
                    DevListViewItem mlvi = (DevListViewItem)lv_Items.SelectedItems[0];
                    BackPowerInching(mlvi.uAddress, mlvi.uLine, mlvi.uPowerFlash);
                }
            }
            else
            {
                MessageBox.Show("请选择你要开启的设备!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void mnu_System_Click(object sender, EventArgs e)
        {
            frmSystem fs = new frmSystem(UID);
            if (fs.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void mnu_RunAction_Click(object sender, EventArgs e)
        {
            foreach (DevListViewItem mlvi in lv_Items.Items)
            {
                RelayType rt = RelayType.OFF;
                if (Convert.ToBoolean(mlvi.DefAction))
                {
                    rt = RelayType.ON;
                }
                SendCMD(mlvi.uAddress, mlvi.uLine, rt);
            }
        }

        private void mnu_InputAdd_Click(object sender, EventArgs e)
        {
            frmDev fdt = new frmDev();
            //fdt.lbl_Group.Visible = true;
            //fdt.lv_Group.Visible = true;
            fdt.lv_Group.Items.Clear();
            DataTable dt = DBDevType.DBDevTypeQuery();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem node = new ListViewItem();
                node.Text = row["Name"].ToString();
                node.Tag = row["ID"].ToString();
                node.ImageIndex = 2;
                fdt.lv_Group.Items.Add(node);
                fdt.cb_IO.SelectedIndex = 1;
                fdt.cb_DefAction.Visible = false;
                fdt.lb_Action.Visible = false;

                fdt.txt_PowerFlash.Visible = false;
                fdt.label4.Visible = false;
                fdt.label6.Visible = false;
            }

            if (fdt.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string Name = fdt.txtName.Text;
                    string Address = fdt.txtAddress.Value.ToString();
                    string Line = fdt.txtLine.Value.ToString();
                    int DefAction = fdt.cb_DefAction.SelectedIndex;
                    int DevIO = fdt.cb_IO.SelectedIndex;

                    string powerflash = fdt.txt_PowerFlash.Text;
                    string ImgGroup = fdt.txt_ImageGroup.Text;
                    string Item_Action = fdt.cb_btn_Action.Text;
                    int ibutton = 0;
                    DBDevices.DBDevInsert(Name, fdt.lv_Group.SelectedItems[0].Tag.ToString(), Address, Line, DefAction.ToString(), DevIO.ToString(), powerflash, ImgGroup, Item_Action,ibutton.ToString());
                    LoadDevices();
                    LoadInputDevices();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void mnu_InputModify_Click(object sender, EventArgs e)
        {
            if (lv_DIItems.SelectedItems.Count > 0)
            {
                string TypeID;
                if (lv_Category.SelectedItems[0].Tag.ToString() == "999999")
                {
                    TypeID = DBDevices.DBGetDevGroup(lv_DIItems.SelectedItems[0].Tag.ToString());
                }
                else
                {
                    TypeID = lv_Category.SelectedItems[0].Tag.ToString();
                }
                frmDev fdt = new frmDev();
                //装载设备信息窗口分组
                fdt.lv_Group.Items.Clear();
                DataTable dt = DBDevType.DBDevTypeQuery();
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem node = new ListViewItem();
                    node.Text = row["Name"].ToString();
                    node.Tag = row["ID"].ToString();
                    node.ImageIndex = 2;
                    if (node.Tag.ToString().Equals(TypeID))
                    {
                        node.Selected = true;
                    }
                    fdt.lv_Group.Items.Add(node);
                }
                DevListViewItem mlvi = (DevListViewItem)lv_DIItems.SelectedItems[0];
                fdt.txtName.Text = mlvi.Title;
                fdt.txtAddress.Value = Convert.ToInt32(mlvi.uAddress);
                fdt.txtLine.Value = Convert.ToInt32(mlvi.uLine);
                fdt.cb_DefAction.SelectedIndex = Convert.ToInt32(mlvi.DefAction);
                fdt.cb_IO.SelectedIndex = Convert.ToInt32(mlvi.DevIO);
                fdt.txt_ImageGroup.Text = mlvi.ImgGroup.ToString();

                fdt.cb_DefAction.Visible = false;
                fdt.lb_Action.Visible = false;
                fdt.txt_PowerFlash.Visible = false;
                fdt.label4.Visible = false;
                fdt.label6.Visible = false;
                fdt.cb_btn_Action.Text = mlvi.Item_Action;

                if (fdt.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string Name = fdt.txtName.Text;
                        string Address = fdt.txtAddress.Value.ToString();
                        string Line = fdt.txtLine.Value.ToString();
                        int DefAction = fdt.cb_DefAction.SelectedIndex;
                        int DevIO = fdt.cb_IO.SelectedIndex;

                        string powerflash = fdt.txt_PowerFlash.Text;
                        string ImgGroup = fdt.txt_ImageGroup.Text;
                        string Item_Action = fdt.cb_btn_Action.Text;
                        int ibutton = 0;
                        DBDevices.DBDevUpdate(mlvi.Tag.ToString(), Name, Address, Line, DefAction.ToString(), DevIO.ToString(), fdt.lv_Group.SelectedItems[0].Tag.ToString(), powerflash, ImgGroup, Item_Action,ibutton.ToString());
                        //mlvi.Text = Name;
                        //mlvi.uAddress = Convert.ToInt16(Address);
                        //mlvi.uLine = Convert.ToInt32(Line);
                        LoadDevices();
                        LoadInputDevices();

                    }
                    catch (Exception err)
                    {
                        fdebug.AddInfo("mnu_InputModify_Click() " + err.Message );
                        //MessageBox.Show(err.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("请首先选择类别与项目!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mnu_InputRemove_Click(object sender, EventArgs e)
        {
            if (lv_DIItems.SelectedItems.Count > 0)
            {
                foreach (DevListViewItem mlvi in lv_DIItems.SelectedItems)
                {
                    DBDevices.DBDevDelete(mlvi.Tag.ToString());
                    mlvi.Remove();
                }
            }
            else
            {
                MessageBox.Show("请首先选择类别与项目!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mnu_InputMgr_Click(object sender, EventArgs e)
        {
            mnu_InputMgr.Checked = !mnu_InputMgr.Checked;
            pl_InputMgr.Visible = mnu_InputMgr.Checked;

            string iniFile = string.Empty;
            iniFile = System.Environment.CurrentDirectory + "\\config.ini";
            if (System.IO.File.Exists(iniFile))
            {
                INIFile.Writue(iniFile, "VIEW", "ShowInput", mnu_InputMgr.Checked.ToString());
            }
        }

        private void lv_Category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.Alt)
            {
                //lbl_SEND.Visible = true;
                fdebug.Show();
            }
            else
            {
                //lbl_SEND.Visible = false;
                //lbl_Receive.Visible = false;
            }
        }

        /// <summary>
        /// 向指定端口发送指令
        /// </summary>
        /// <param name="_Address"></param>
        /// <param name="_Line"></param>
        /// <param name="_type"></param>
        private void SendCMD(short _Address, short OH, short OL, short _type)
        {
            byte[] tempCMD = new byte[8];
            tempCMD = Relay.CreateCMD(_Address, OH, OL, _type);
            SendCMDToBUS(tempCMD);
        }


        private void PlaySound(string filename)
        {
            ZPlay player = new ZPlay();
            // open file
            if (player.OpenFile(filename, TStreamFormat.sfAutodetect) == false)
            {
                MessageBox.Show(player.GetError());
                return;
            }
            // start playing
            player.StartPlayback();
        }

        //}
        /// <summary>
        /// 设备启动函数
        /// </summary>
        private void BackPowerON(short Address,short Line)
        {
            SendCMD(Address, Line, RelayType.ON);
        }
        /// <summary>
        /// 设备关闭
        /// </summary>
        private void BackPowerOFF(short Address, short Line)
        {
            SendCMD(Address, Line, RelayType.OFF);
        }
        /// <summary>
        /// 后台点动
        /// </summary>
        private void BackPowerInching(short Address, int Line, int times)
        {
            SendCMDByIncling(Address, Line, times);
        }


        /// <summary>
        /// 设备闪烁
        /// </summary>
        private void BackFlashDev(short Address, short Line, int times)
        {
            int uLine = 0;
            uLine += 1 << (Line - 1);
            SendCMDByFlash(Address, uLine, times);
        }

        private void RunAction(string Action)
        {
            string[] temp=Action.Split(';');
            if (temp[0] == "RUNITEM")
            {
                DataTable dt = DBDevices.DBQueryDevicesByName(temp[1]);
                short Address=Convert.ToInt16(dt.Rows[0]["Address"]);
                short line=Convert.ToInt16(dt.Rows[0]["Line"]);
                int flash = Convert.ToInt32(dt.Rows[0]["powerflash"]);
                if (temp[2] == "启动")
                {
                    BackPowerON(Address,line);
                }
                if (temp[2] == "停止")
                {
                    BackPowerOFF(Address, line);
                }
                if (temp[2] == "点动")
                {
                    BackPowerInching(Address, line, flash);
                }
                if (temp[2] == "闪烁")
                {
                    BackFlashDev(Address, line, flash);
                }
            }
            if (temp[0] == "RUNGROUP")
            {
                RunGroup(temp[1]);
            }
            if (temp[0] == "PLAYSOUND")
            {
                PlaySound(temp[1]);
            }
            if (temp[0] == "EXEC")
            {
                Process.Start(temp[1]);//调用程序
            }
            if (temp[0] == "RUNCMD")
            {
                string[] ohl=temp[3].Split(',');
                SendCMD(Convert.ToInt16(temp[1]), Convert.ToInt16(ohl[0]), Convert.ToInt16(ohl[1]), Convert.ToInt16(temp[2]));
            }
            if (temp[0] == "RUNCUSTOM")
            {
                string[] hex = temp[1].Split(',');
                int i = 0, count = hex.Length;
                byte[] tempCMD;
                if (count > 0)
                {
                    tempCMD = new byte[count];
                    for (i = 0; i < count; i++)
                    {
                        tempCMD[i] =(byte)uint.Parse(hex[i], System.Globalization.NumberStyles.AllowHexSpecifier);
                    }
                }
                else
                {

                    tempCMD = new byte[1];
                    tempCMD[0] = (byte)uint.Parse(temp[1], System.Globalization.NumberStyles.AllowHexSpecifier);
                }
                SendCMDToBUS(tempCMD);
            }
        }

        private void mnu_Restore_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!m_isDemo)
            {
                ShowLockScreen(false);
            }
         }
        private void LockSystem(bool enable)
        {
            mnu_Main.Enabled = enable;
            pl_Top.Enabled = enable;
            pl_Backgroud.Enabled = enable;
        }
        private void ShowLockScreen(bool Show_Cancel)
        {
            frmPWD fpwd = new frmPWD(UID);
            fpwd.Top = this.Top;
            fpwd.Left = this.Left;
            fpwd.Height = this.Height;
            fpwd.Width = this.Width;
            fpwd.ShowInTaskbar = false;
            fpwd.btn_Cancel.Visible = Show_Cancel;
            fpwd.ShowDialog();
        }


        private void ShowView()
        {
            string iniFile = string.Empty;
            iniFile = System.Environment.CurrentDirectory + "\\config.ini";
            if (System.IO.File.Exists(iniFile))
            {
                try
                {
                    bool Ck = Convert.ToBoolean(INIFile.ReadValue(iniFile, "VIEW", "ShowTasks"));
                    mnu_TaskMgr.Checked = Ck;
                    pl_TaskMgr.Visible = Ck;
                }
                catch { }
                try
                {
                    bool Ck = Convert.ToBoolean(INIFile.ReadValue(iniFile, "VIEW", "ShowInput"));
                    mnu_InputMgr.Checked =Ck;
                    pl_InputMgr.Visible =Ck;
                }
                catch { }
            }

        }

        private List<byte[]> PostAction(string Action)
        {
            List<byte[]> lb=new List<byte[]>();

            string[] temp = Action.Split(';');
            if (temp[0] == "RUNITEM")
            {
                DataTable dt = DBDevices.DBQueryDevicesByName(temp[1]);
                short Address = Convert.ToInt16(dt.Rows[0]["Address"]);
                short line = Convert.ToInt16(dt.Rows[0]["Line"]);
                int flash = Convert.ToInt32(dt.Rows[0]["powerflash"]);
                if (temp[2] == "启动")
                {
                    BackPowerON(Address, line);
                }
                if (temp[2] == "停止")
                {
                    BackPowerOFF(Address, line);
                }
                if (temp[2] == "点动")
                {
                    BackPowerInching(Address, line, flash);
                }
                if (temp[2] == "闪烁")
                {
                    BackFlashDev(Address, line, flash);
                }
            }
            if (temp[0] == "RUNGROUP")
            {
                RunGroup(temp[1]);
            }
            if (temp[0] == "PLAYSOUND")
            {
                PlaySound(temp[1]);
            }
            if (temp[0] == "EXEC")
            {
                Process.Start(temp[1]);//调用程序
            }
            if (temp[0] == "RUNCMD")
            {
                string[] ohl = temp[3].Split(',');
                byte[] tempCMD = new byte[8];
                tempCMD = Relay.CreateCMD(Convert.ToInt16(temp[1]), Convert.ToInt16(ohl[0]), Convert.ToInt16(ohl[1]), Convert.ToInt16(temp[2]));
                lb.Add(tempCMD);
            }
            if (temp[0] == "RUNCUSTOM")
            {
                string[] hex = temp[1].Split(',');
                int i = 0, count = hex.Length;
                byte[] tempCMD;
                if (count > 0)
                {
                    tempCMD = new byte[count];
                    for (i = 0; i < count; i++)
                    {
                        tempCMD[i] = (byte)uint.Parse(hex[i], System.Globalization.NumberStyles.AllowHexSpecifier);
                    }
                }
                else
                {

                    tempCMD = new byte[1];
                    tempCMD[0] = (byte)uint.Parse(temp[1], System.Globalization.NumberStyles.AllowHexSpecifier);
                }
                lb.Add(tempCMD);
            }
            return lb;
        }

        private void mnu_ConnecSetting_Click(object sender, EventArgs e)
        {
            frmConnection fc = new frmConnection();
            if (fc.ShowDialog() == DialogResult.OK)
            {



            }
        }

        private void mnu_BeginListen_Click(object sender, EventArgs e)
        {
            LoadConfig();
            BeginListen();
        }

        private void tm_AllowAction_Tick(object sender, EventArgs e)
        {
            tm_AllowAction.Enabled = false;
        }

        private void mnu_pool_Click(object sender, EventArgs e)
        {
            frmPool fp = new frmPool();
            fp.ShowDialog();
        }

        private void btn_PoolInfo_Clear_Click(object sender, EventArgs e)
        {
            txt_PoolInfo.Clear();
        }

        private void btn_PoolInfo_Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void btnPowerON_BUS_Click(object sender, EventArgs e)
        {
            SendCMD(0xFF, 0xFFFF, RelayType.BYTECTRL);

            if (Transport == 1)
            {
                foreach (DevListViewItem mlvi in lv_Items.Items)
                {
                    mlvi.ImageIndex = 3*mlvi.ImgGroup+1;
                }
            }
        }

        private void btnPowerOFF_BUS_Click(object sender, EventArgs e)
        {
            SendCMD(0xFF, 0x0000, RelayType.BYTECTRL);

            if (Transport == 1)
            {
                foreach (DevListViewItem mlvi in lv_Items.Items)
                {
                    mlvi.ImageIndex = 3*mlvi.ImgGroup+1;
                }
            }
        }

        private void btn_InfoPanel_Click(object sender, EventArgs e)
        {
            pl_PoolInfo.Visible = !pl_PoolInfo.Visible;
        }

        private void TimeService()
        {
            try
            {
                DateTime dt = new DateTime();
                dt = DateTime.Now;

                byte[] tempCMD = new byte[15];
                tempCMD = Relay.CreateCMDBySet(0xFF, (byte)0x02, (byte)0x00, (byte)0x01, (byte)0x00, (byte)(dt.Year - 2000), (byte)dt.Month, (byte)dt.DayOfWeek, (byte)dt.Day, (byte)dt.Hour, (byte)dt.Minute, (byte)dt.Second);
                SendCMDToBUS(tempCMD);

            }
            catch (Exception err)
            {
                //MessageBox.Show(err.Message);
            }

        }

        private void tm_TimeService_Tick(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;

            if (m_Hour != dt.Hour)
            {
                TimeService();
                m_Hour = dt.Hour;
            }

        }

        private void mnu_Actions_Click(object sender, EventArgs e)
        {
            frmiCore fc = new frmiCore();
            fc.LoadItemAction(lv_Items.SelectedItems[0].Tag.ToString());
            fc.ShowDialog();
        }

        private void mnu_iActions_Click(object sender, EventArgs e)
        {
            frmiCore fc = new frmiCore();
            fc.LoadItemAction(lv_DIItems.SelectedItems[0].Tag.ToString());
            fc.ShowDialog();
        }

        private void btn_Manual_MouseDown(object sender, MouseEventArgs e)
        {
            PowerON();
        }

        private void btn_Manual_MouseUp(object sender, MouseEventArgs e)
        {
            PowerOFF();
        }

        private void timer_watchdog_Tick(object sender, EventArgs e)
        {
            if (m_AutoConnection)
            {
                if (!bConnected)
                {
                    BeginListen();

                }
            }
        }

        private void rb_UDP_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rb_UDP.Checked)
            {
                txtIP.Enabled = true;
                txtPort.Enabled = true;
                cb_Band.Enabled = false;
                cb_SerialPort.Enabled = false;
            }
        }

    }
}
