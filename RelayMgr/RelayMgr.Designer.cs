namespace RelayMgr
{
    partial class RelayMgr
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("大厅", 1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("生产厂房", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("办公楼", 1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("宿舍区", 1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("厂前区", 1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelayMgr));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Lockthis = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lbl_Connected = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEndListen = new System.Windows.Forms.Button();
            this.btnBeginListen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_SerialPort = new System.Windows.Forms.ComboBox();
            this.nud_Delay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lv_Category = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.cm_Category = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_DevTypeAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DevTypeModify = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DevTypeRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_GroupTasks = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_RunAction = new System.Windows.Forms.ToolStripMenuItem();
            this.il_Category = new System.Windows.Forms.ImageList(this.components);
            this.cm_Items = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_DevAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DevModify = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DevRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_Actions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_AddTask = new System.Windows.Forms.ToolStripMenuItem();
            this.显示方式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.il_Items = new System.Windows.Forms.ImageList(this.components);
            this.il_VItems = new System.Windows.Forms.ImageList(this.components);
            this.btnPowerOFF_Board = new System.Windows.Forms.Button();
            this.btnPowerOFFAll = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPowerON_Board = new System.Windows.Forms.Button();
            this.btnPowerON = new System.Windows.Forms.Button();
            this.btnPowerOFF = new System.Windows.Forms.Button();
            this.btnPowerONAll = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Manual = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbUNKNOWN = new System.Windows.Forms.PictureBox();
            this.pbON = new System.Windows.Forms.PictureBox();
            this.pbOFF = new System.Windows.Forms.PictureBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.mnu_Main = new System.Windows.Forms.MenuStrip();
            this.mnu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_BeginListen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_View = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_TaskMgr = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_InputMgr = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ShowTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_System = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_pool = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ConnecSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.timer_INQUIRE = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tab_Control = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pl_OutPutItems = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.lv_Items = new CSharpWin.ListViewEx();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnPowerOFF_BUS = new System.Windows.Forms.Button();
            this.btnPowerON_BUS = new System.Windows.Forms.Button();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.pl_InputMgr = new System.Windows.Forms.Panel();
            this.lv_DIItems = new System.Windows.Forms.ListView();
            this.cm_InputItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_InputAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_InputModify = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_InputRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_iActions = new System.Windows.Forms.ToolStripMenuItem();
            this.il_InputItems = new System.Windows.Forms.ImageList(this.components);
            this.panel11 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pl_Left = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pl_Backgroud = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pl_TaskMgr = new System.Windows.Forms.Panel();
            this.lv_TaskMgr = new System.Windows.Forms.ListView();
            this.ch_itemName = new System.Windows.Forms.ColumnHeader();
            this.ch_TaskTime = new System.Windows.Forms.ColumnHeader();
            this.ch_taskType = new System.Windows.Forms.ColumnHeader();
            this.ch_Action = new System.Windows.Forms.ColumnHeader();
            this.cm_TaskMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_modifyTask = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_RemoveTask = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_AllTasks = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_CheckedAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_UNCheckedAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_TaskLock = new System.Windows.Forms.ToolStripMenuItem();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_TaskStop = new System.Windows.Forms.Button();
            this.btn_TaskRun = new System.Windows.Forms.Button();
            this.pl_Top = new System.Windows.Forms.Panel();
            this.btn_InfoPanel = new System.Windows.Forms.Button();
            this.pl_PoolInfo = new System.Windows.Forms.Panel();
            this.txt_PoolInfo = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_PoolInfo_Save = new System.Windows.Forms.Button();
            this.btn_PoolInfo_Clear = new System.Windows.Forms.Button();
            this.gb_quickConn = new System.Windows.Forms.GroupBox();
            this.rb_UDP = new System.Windows.Forms.RadioButton();
            this.cb_Band = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_TCP = new System.Windows.Forms.RadioButton();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.rb_COM = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.timer_Task = new System.Windows.Forms.Timer(this.components);
            this.cms_notifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_Restore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.cms_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_AllowAction = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl_Info = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tm_TimeService = new System.Windows.Forms.Timer(this.components);
            this.timer_watchdog = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Delay)).BeginInit();
            this.cm_Category.SuspendLayout();
            this.cm_Items.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUNKNOWN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOFF)).BeginInit();
            this.mnu_Main.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tab_Control.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pl_OutPutItems.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.pl_InputMgr.SuspendLayout();
            this.cm_InputItems.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.pl_Left.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pl_Backgroud.SuspendLayout();
            this.pl_TaskMgr.SuspendLayout();
            this.cm_TaskMgr.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pl_Top.SuspendLayout();
            this.pl_PoolInfo.SuspendLayout();
            this.panel5.SuspendLayout();
            this.gb_quickConn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.cms_notifyIcon.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Lockthis);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.lbl_Connected);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 805);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 54);
            this.panel1.TabIndex = 0;
            // 
            // btn_Lockthis
            // 
            this.btn_Lockthis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Lockthis.Location = new System.Drawing.Point(827, 11);
            this.btn_Lockthis.Name = "btn_Lockthis";
            this.btn_Lockthis.Size = new System.Drawing.Size(75, 34);
            this.btn_Lockthis.TabIndex = 17;
            this.btn_Lockthis.Text = "锁定";
            this.btn_Lockthis.UseVisualStyleBackColor = true;
            this.btn_Lockthis.Visible = false;
            this.btn_Lockthis.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1021, 5);
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // lbl_Connected
            // 
            this.lbl_Connected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Connected.AutoSize = true;
            this.lbl_Connected.Font = new System.Drawing.Font("黑体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Connected.ForeColor = System.Drawing.Color.Red;
            this.lbl_Connected.Location = new System.Drawing.Point(387, 18);
            this.lbl_Connected.Name = "lbl_Connected";
            this.lbl_Connected.Size = new System.Drawing.Size(124, 27);
            this.lbl_Connected.TabIndex = 16;
            this.lbl_Connected.Text = "连接关闭";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(934, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "退出";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEndListen
            // 
            this.btnEndListen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEndListen.Enabled = false;
            this.btnEndListen.Location = new System.Drawing.Point(934, 11);
            this.btnEndListen.Name = "btnEndListen";
            this.btnEndListen.Size = new System.Drawing.Size(75, 52);
            this.btnEndListen.TabIndex = 8;
            this.btnEndListen.Text = "断开";
            this.btnEndListen.UseVisualStyleBackColor = true;
            this.btnEndListen.Click += new System.EventHandler(this.btnEndListen_Click);
            // 
            // btnBeginListen
            // 
            this.btnBeginListen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBeginListen.Location = new System.Drawing.Point(853, 11);
            this.btnBeginListen.Name = "btnBeginListen";
            this.btnBeginListen.Size = new System.Drawing.Size(75, 52);
            this.btnBeginListen.TabIndex = 7;
            this.btnBeginListen.Text = "连接";
            this.btnBeginListen.UseVisualStyleBackColor = true;
            this.btnBeginListen.Click += new System.EventHandler(this.btnBeginListen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "毫秒";
            // 
            // cb_SerialPort
            // 
            this.cb_SerialPort.FormattingEnabled = true;
            this.cb_SerialPort.Location = new System.Drawing.Point(174, 43);
            this.cb_SerialPort.Name = "cb_SerialPort";
            this.cb_SerialPort.Size = new System.Drawing.Size(93, 20);
            this.cb_SerialPort.TabIndex = 2;
            this.cb_SerialPort.DropDown += new System.EventHandler(this.cb_SerialPort_DropDown);
            // 
            // nud_Delay
            // 
            this.nud_Delay.Location = new System.Drawing.Point(29, 44);
            this.nud_Delay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_Delay.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_Delay.Name = "nud_Delay";
            this.nud_Delay.Size = new System.Drawing.Size(77, 21);
            this.nud_Delay.TabIndex = 5;
            this.nud_Delay.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nud_Delay.ValueChanged += new System.EventHandler(this.nud_Delay_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "指令发送延时：";
            // 
            // lv_Category
            // 
            this.lv_Category.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lv_Category.ContextMenuStrip = this.cm_Category;
            this.lv_Category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Category.FullRowSelect = true;
            this.lv_Category.GridLines = true;
            this.lv_Category.HideSelection = false;
            this.lv_Category.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.lv_Category.LargeImageList = this.il_Category;
            this.lv_Category.Location = new System.Drawing.Point(0, 24);
            this.lv_Category.MultiSelect = false;
            this.lv_Category.Name = "lv_Category";
            this.lv_Category.Size = new System.Drawing.Size(106, 560);
            this.lv_Category.SmallImageList = this.il_Category;
            this.lv_Category.TabIndex = 1;
            this.lv_Category.UseCompatibleStateImageBehavior = false;
            this.lv_Category.SelectedIndexChanged += new System.EventHandler(this.lv_Category_SelectedIndexChanged);
            this.lv_Category.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_Category_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "类别";
            this.columnHeader1.Width = 137;
            // 
            // cm_Category
            // 
            this.cm_Category.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_DevTypeAdd,
            this.mnu_DevTypeModify,
            this.mnu_DevTypeRemove,
            this.toolStripMenuItem5,
            this.mnu_GroupTasks,
            this.toolStripMenuItem6,
            this.mnu_RunAction});
            this.cm_Category.Name = "cm_Category";
            this.cm_Category.Size = new System.Drawing.Size(125, 126);
            // 
            // mnu_DevTypeAdd
            // 
            this.mnu_DevTypeAdd.Name = "mnu_DevTypeAdd";
            this.mnu_DevTypeAdd.Size = new System.Drawing.Size(124, 22);
            this.mnu_DevTypeAdd.Text = "增加分组";
            this.mnu_DevTypeAdd.Click += new System.EventHandler(this.mnu_DevTypeAdd_Click);
            // 
            // mnu_DevTypeModify
            // 
            this.mnu_DevTypeModify.Name = "mnu_DevTypeModify";
            this.mnu_DevTypeModify.Size = new System.Drawing.Size(124, 22);
            this.mnu_DevTypeModify.Text = "修改分组";
            this.mnu_DevTypeModify.Click += new System.EventHandler(this.mnu_DevTypeModify_Click);
            // 
            // mnu_DevTypeRemove
            // 
            this.mnu_DevTypeRemove.Name = "mnu_DevTypeRemove";
            this.mnu_DevTypeRemove.Size = new System.Drawing.Size(124, 22);
            this.mnu_DevTypeRemove.Text = "删除分组";
            this.mnu_DevTypeRemove.Click += new System.EventHandler(this.mnu_DevTypeRemove_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(121, 6);
            // 
            // mnu_GroupTasks
            // 
            this.mnu_GroupTasks.Name = "mnu_GroupTasks";
            this.mnu_GroupTasks.Size = new System.Drawing.Size(124, 22);
            this.mnu_GroupTasks.Text = "添加任务";
            this.mnu_GroupTasks.Click += new System.EventHandler(this.mnu_GroupTasks_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(121, 6);
            // 
            // mnu_RunAction
            // 
            this.mnu_RunAction.Name = "mnu_RunAction";
            this.mnu_RunAction.Size = new System.Drawing.Size(124, 22);
            this.mnu_RunAction.Text = "执行本组";
            this.mnu_RunAction.Click += new System.EventHandler(this.mnu_RunAction_Click);
            // 
            // il_Category
            // 
            this.il_Category.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_Category.ImageStream")));
            this.il_Category.TransparentColor = System.Drawing.Color.Transparent;
            this.il_Category.Images.SetKeyName(0, "dreamesp Icon 34.ico");
            this.il_Category.Images.SetKeyName(1, "Junior Icon 72.ico");
            // 
            // cm_Items
            // 
            this.cm_Items.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_DevAdd,
            this.mnu_DevModify,
            this.mnu_DevRemove,
            this.toolStripMenuItem2,
            this.mnu_Actions,
            this.toolStripMenuItem10,
            this.mnu_AddTask,
            this.显示方式ToolStripMenuItem});
            this.cm_Items.Name = "cm_Items";
            this.cm_Items.Size = new System.Drawing.Size(125, 148);
            // 
            // mnu_DevAdd
            // 
            this.mnu_DevAdd.Name = "mnu_DevAdd";
            this.mnu_DevAdd.Size = new System.Drawing.Size(124, 22);
            this.mnu_DevAdd.Text = "添加项目";
            this.mnu_DevAdd.Click += new System.EventHandler(this.mnu_DevAdd_Click);
            // 
            // mnu_DevModify
            // 
            this.mnu_DevModify.Name = "mnu_DevModify";
            this.mnu_DevModify.Size = new System.Drawing.Size(124, 22);
            this.mnu_DevModify.Text = "修改项目";
            this.mnu_DevModify.Click += new System.EventHandler(this.mnu_DevModify_Click);
            // 
            // mnu_DevRemove
            // 
            this.mnu_DevRemove.Name = "mnu_DevRemove";
            this.mnu_DevRemove.Size = new System.Drawing.Size(124, 22);
            this.mnu_DevRemove.Text = "删除项目";
            this.mnu_DevRemove.Click += new System.EventHandler(this.mnu_DevRemove_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(121, 6);
            // 
            // mnu_Actions
            // 
            this.mnu_Actions.Name = "mnu_Actions";
            this.mnu_Actions.Size = new System.Drawing.Size(124, 22);
            this.mnu_Actions.Text = "执行器";
            this.mnu_Actions.Click += new System.EventHandler(this.mnu_Actions_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(121, 6);
            // 
            // mnu_AddTask
            // 
            this.mnu_AddTask.Name = "mnu_AddTask";
            this.mnu_AddTask.Size = new System.Drawing.Size(124, 22);
            this.mnu_AddTask.Text = "添加任务";
            this.mnu_AddTask.Click += new System.EventHandler(this.mnu_AddTask_Click);
            // 
            // 显示方式ToolStripMenuItem
            // 
            this.显示方式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.大图标ToolStripMenuItem,
            this.列表ToolStripMenuItem});
            this.显示方式ToolStripMenuItem.Name = "显示方式ToolStripMenuItem";
            this.显示方式ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.显示方式ToolStripMenuItem.Text = "显示方式";
            // 
            // 大图标ToolStripMenuItem
            // 
            this.大图标ToolStripMenuItem.Name = "大图标ToolStripMenuItem";
            this.大图标ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.大图标ToolStripMenuItem.Text = "大图标";
            // 
            // 列表ToolStripMenuItem
            // 
            this.列表ToolStripMenuItem.Name = "列表ToolStripMenuItem";
            this.列表ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.列表ToolStripMenuItem.Text = "列表";
            // 
            // il_Items
            // 
            this.il_Items.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_Items.ImageStream")));
            this.il_Items.TransparentColor = System.Drawing.Color.Transparent;
            this.il_Items.Images.SetKeyName(0, "chinaz3.png");
            this.il_Items.Images.SetKeyName(1, "chinaz5.png");
            this.il_Items.Images.SetKeyName(2, "chinaz15.png");
            // 
            // il_VItems
            // 
            this.il_VItems.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_VItems.ImageStream")));
            this.il_VItems.TransparentColor = System.Drawing.Color.Transparent;
            this.il_VItems.Images.SetKeyName(0, "Folder Wineup.png");
            // 
            // btnPowerOFF_Board
            // 
            this.btnPowerOFF_Board.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPowerOFF_Board.BackColor = System.Drawing.Color.Red;
            this.btnPowerOFF_Board.Enabled = false;
            this.btnPowerOFF_Board.ForeColor = System.Drawing.Color.White;
            this.btnPowerOFF_Board.Location = new System.Drawing.Point(14, 180);
            this.btnPowerOFF_Board.Name = "btnPowerOFF_Board";
            this.btnPowerOFF_Board.Size = new System.Drawing.Size(101, 24);
            this.btnPowerOFF_Board.TabIndex = 8;
            this.btnPowerOFF_Board.Text = "全部关闭(板卡)";
            this.btnPowerOFF_Board.UseVisualStyleBackColor = false;
            this.btnPowerOFF_Board.Visible = false;
            this.btnPowerOFF_Board.Click += new System.EventHandler(this.btnPowerOFF_Board_Click);
            // 
            // btnPowerOFFAll
            // 
            this.btnPowerOFFAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPowerOFFAll.BackColor = System.Drawing.Color.Red;
            this.btnPowerOFFAll.Enabled = false;
            this.btnPowerOFFAll.ForeColor = System.Drawing.Color.White;
            this.btnPowerOFFAll.Location = new System.Drawing.Point(14, 123);
            this.btnPowerOFFAll.Name = "btnPowerOFFAll";
            this.btnPowerOFFAll.Size = new System.Drawing.Size(101, 23);
            this.btnPowerOFFAll.TabIndex = 10;
            this.btnPowerOFFAll.Text = "全部关闭(界面)";
            this.btnPowerOFFAll.UseVisualStyleBackColor = false;
            this.btnPowerOFFAll.Visible = false;
            this.btnPowerOFFAll.Click += new System.EventHandler(this.btnPowerOFFAll_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRefresh.ForeColor = System.Drawing.Color.Yellow;
            this.btnRefresh.Location = new System.Drawing.Point(14, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 22);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPowerON_Board
            // 
            this.btnPowerON_Board.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPowerON_Board.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPowerON_Board.Enabled = false;
            this.btnPowerON_Board.ForeColor = System.Drawing.Color.Yellow;
            this.btnPowerON_Board.Location = new System.Drawing.Point(14, 152);
            this.btnPowerON_Board.Name = "btnPowerON_Board";
            this.btnPowerON_Board.Size = new System.Drawing.Size(101, 22);
            this.btnPowerON_Board.TabIndex = 7;
            this.btnPowerON_Board.Text = "全部启动(板卡)";
            this.btnPowerON_Board.UseVisualStyleBackColor = false;
            this.btnPowerON_Board.Visible = false;
            this.btnPowerON_Board.Click += new System.EventHandler(this.btnPowerON_Board_Click);
            // 
            // btnPowerON
            // 
            this.btnPowerON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPowerON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPowerON.Enabled = false;
            this.btnPowerON.ForeColor = System.Drawing.Color.Yellow;
            this.btnPowerON.Location = new System.Drawing.Point(14, 35);
            this.btnPowerON.Name = "btnPowerON";
            this.btnPowerON.Size = new System.Drawing.Size(101, 24);
            this.btnPowerON.TabIndex = 1;
            this.btnPowerON.Text = "启动(项目)";
            this.btnPowerON.UseVisualStyleBackColor = false;
            this.btnPowerON.Visible = false;
            this.btnPowerON.Click += new System.EventHandler(this.btnPowerON_Click);
            // 
            // btnPowerOFF
            // 
            this.btnPowerOFF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPowerOFF.BackColor = System.Drawing.Color.Red;
            this.btnPowerOFF.Enabled = false;
            this.btnPowerOFF.ForeColor = System.Drawing.Color.White;
            this.btnPowerOFF.Location = new System.Drawing.Point(14, 65);
            this.btnPowerOFF.Name = "btnPowerOFF";
            this.btnPowerOFF.Size = new System.Drawing.Size(101, 23);
            this.btnPowerOFF.TabIndex = 2;
            this.btnPowerOFF.Text = "关闭(项目)";
            this.btnPowerOFF.UseVisualStyleBackColor = false;
            this.btnPowerOFF.Visible = false;
            this.btnPowerOFF.Click += new System.EventHandler(this.btnPowerOFF_Click);
            // 
            // btnPowerONAll
            // 
            this.btnPowerONAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPowerONAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPowerONAll.Enabled = false;
            this.btnPowerONAll.ForeColor = System.Drawing.Color.Yellow;
            this.btnPowerONAll.Location = new System.Drawing.Point(14, 94);
            this.btnPowerONAll.Name = "btnPowerONAll";
            this.btnPowerONAll.Size = new System.Drawing.Size(101, 23);
            this.btnPowerONAll.TabIndex = 9;
            this.btnPowerONAll.Text = "全部启动(界面)";
            this.btnPowerONAll.UseVisualStyleBackColor = false;
            this.btnPowerONAll.Visible = false;
            this.btnPowerONAll.Click += new System.EventHandler(this.btnPowerONAll_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Manual);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pbUNKNOWN);
            this.panel3.Controls.Add(this.pbON);
            this.panel3.Controls.Add(this.pbOFF);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(896, 46);
            this.panel3.TabIndex = 3;
            // 
            // btn_Manual
            // 
            this.btn_Manual.Location = new System.Drawing.Point(323, 10);
            this.btn_Manual.Name = "btn_Manual";
            this.btn_Manual.Size = new System.Drawing.Size(98, 33);
            this.btn_Manual.TabIndex = 8;
            this.btn_Manual.Text = "手动";
            this.btn_Manual.UseVisualStyleBackColor = true;
            this.btn_Manual.Visible = false;
            this.btn_Manual.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Manual_MouseDown);
            this.btn_Manual.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Manual_MouseUp);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(896, 5);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "未知";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "开启";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "关闭";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "图例：";
            // 
            // pbUNKNOWN
            // 
            this.pbUNKNOWN.Image = ((System.Drawing.Image)(resources.GetObject("pbUNKNOWN.Image")));
            this.pbUNKNOWN.Location = new System.Drawing.Point(220, 9);
            this.pbUNKNOWN.Name = "pbUNKNOWN";
            this.pbUNKNOWN.Size = new System.Drawing.Size(34, 34);
            this.pbUNKNOWN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUNKNOWN.TabIndex = 2;
            this.pbUNKNOWN.TabStop = false;
            // 
            // pbON
            // 
            this.pbON.Image = ((System.Drawing.Image)(resources.GetObject("pbON.Image")));
            this.pbON.Location = new System.Drawing.Point(145, 9);
            this.pbON.Name = "pbON";
            this.pbON.Size = new System.Drawing.Size(34, 34);
            this.pbON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbON.TabIndex = 1;
            this.pbON.TabStop = false;
            // 
            // pbOFF
            // 
            this.pbOFF.Image = ((System.Drawing.Image)(resources.GetObject("pbOFF.Image")));
            this.pbOFF.Location = new System.Drawing.Point(70, 9);
            this.pbOFF.Name = "pbOFF";
            this.pbOFF.Size = new System.Drawing.Size(34, 34);
            this.pbOFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOFF.TabIndex = 0;
            this.pbOFF.TabStop = false;
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = "";
            // 
            // mnu_Main
            // 
            this.mnu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_File,
            this.mnu_View,
            this.mnu_Settings,
            this.mnu_Help});
            this.mnu_Main.Location = new System.Drawing.Point(0, 0);
            this.mnu_Main.Name = "mnu_Main";
            this.mnu_Main.Size = new System.Drawing.Size(1021, 25);
            this.mnu_Main.TabIndex = 5;
            this.mnu_Main.Text = "menuStrip1";
            // 
            // mnu_File
            // 
            this.mnu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_BeginListen,
            this.toolStripMenuItem9,
            this.mnu_Exit});
            this.mnu_File.Name = "mnu_File";
            this.mnu_File.Size = new System.Drawing.Size(44, 21);
            this.mnu_File.Text = "文件";
            // 
            // mnu_BeginListen
            // 
            this.mnu_BeginListen.Name = "mnu_BeginListen";
            this.mnu_BeginListen.Size = new System.Drawing.Size(100, 22);
            this.mnu_BeginListen.Text = "连接";
            this.mnu_BeginListen.Click += new System.EventHandler(this.mnu_BeginListen_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(97, 6);
            // 
            // mnu_Exit
            // 
            this.mnu_Exit.Name = "mnu_Exit";
            this.mnu_Exit.Size = new System.Drawing.Size(100, 22);
            this.mnu_Exit.Text = "退出";
            this.mnu_Exit.Click += new System.EventHandler(this.mnu_Exit_Click);
            // 
            // mnu_View
            // 
            this.mnu_View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_TaskMgr,
            this.mnu_InputMgr,
            this.mnu_ShowTimer});
            this.mnu_View.Name = "mnu_View";
            this.mnu_View.Size = new System.Drawing.Size(44, 21);
            this.mnu_View.Text = "查看";
            // 
            // mnu_TaskMgr
            // 
            this.mnu_TaskMgr.Checked = true;
            this.mnu_TaskMgr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnu_TaskMgr.Name = "mnu_TaskMgr";
            this.mnu_TaskMgr.Size = new System.Drawing.Size(136, 22);
            this.mnu_TaskMgr.Text = "任务管理器";
            this.mnu_TaskMgr.Click += new System.EventHandler(this.mnu_TaskMgr_Click);
            // 
            // mnu_InputMgr
            // 
            this.mnu_InputMgr.Checked = true;
            this.mnu_InputMgr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnu_InputMgr.Name = "mnu_InputMgr";
            this.mnu_InputMgr.Size = new System.Drawing.Size(136, 22);
            this.mnu_InputMgr.Text = "输入项目";
            this.mnu_InputMgr.Click += new System.EventHandler(this.mnu_InputMgr_Click);
            // 
            // mnu_ShowTimer
            // 
            this.mnu_ShowTimer.Name = "mnu_ShowTimer";
            this.mnu_ShowTimer.Size = new System.Drawing.Size(136, 22);
            this.mnu_ShowTimer.Text = "显示时钟";
            this.mnu_ShowTimer.Click += new System.EventHandler(this.mnu_ShowTimer_Click);
            // 
            // mnu_Settings
            // 
            this.mnu_Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_System,
            this.mnu_pool,
            this.mnu_ConnecSetting});
            this.mnu_Settings.Name = "mnu_Settings";
            this.mnu_Settings.Size = new System.Drawing.Size(44, 21);
            this.mnu_Settings.Text = "设置";
            // 
            // mnu_System
            // 
            this.mnu_System.Name = "mnu_System";
            this.mnu_System.Size = new System.Drawing.Size(136, 22);
            this.mnu_System.Text = "系统设置";
            this.mnu_System.Click += new System.EventHandler(this.mnu_System_Click);
            // 
            // mnu_pool
            // 
            this.mnu_pool.Name = "mnu_pool";
            this.mnu_pool.Size = new System.Drawing.Size(136, 22);
            this.mnu_pool.Text = "连接池设置";
            this.mnu_pool.Click += new System.EventHandler(this.mnu_pool_Click);
            // 
            // mnu_ConnecSetting
            // 
            this.mnu_ConnecSetting.Name = "mnu_ConnecSetting";
            this.mnu_ConnecSetting.Size = new System.Drawing.Size(136, 22);
            this.mnu_ConnecSetting.Text = "连接设置";
            this.mnu_ConnecSetting.Visible = false;
            this.mnu_ConnecSetting.Click += new System.EventHandler(this.mnu_ConnecSetting_Click);
            // 
            // mnu_Help
            // 
            this.mnu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_About,
            this.toolStripMenuItem1});
            this.mnu_Help.Name = "mnu_Help";
            this.mnu_Help.Size = new System.Drawing.Size(44, 21);
            this.mnu_Help.Text = "帮助";
            // 
            // mnu_About
            // 
            this.mnu_About.Name = "mnu_About";
            this.mnu_About.Size = new System.Drawing.Size(109, 22);
            this.mnu_About.Text = "关于...";
            this.mnu_About.Click += new System.EventHandler(this.mnu_About_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(106, 6);
            // 
            // timer_INQUIRE
            // 
            this.timer_INQUIRE.Tick += new System.EventHandler(this.timer_INQUIRE_Tick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.splitter2);
            this.panel4.Controls.Add(this.pl_Left);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1021, 584);
            this.panel4.TabIndex = 6;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.tab_Control);
            this.panel9.Controls.Add(this.splitter3);
            this.panel9.Controls.Add(this.pl_InputMgr);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(111, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(910, 584);
            this.panel9.TabIndex = 7;
            // 
            // tab_Control
            // 
            this.tab_Control.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tab_Control.Controls.Add(this.tabPage1);
            this.tab_Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Control.Location = new System.Drawing.Point(0, 24);
            this.tab_Control.Multiline = true;
            this.tab_Control.Name = "tab_Control";
            this.tab_Control.Padding = new System.Drawing.Point(12, 6);
            this.tab_Control.SelectedIndex = 0;
            this.tab_Control.Size = new System.Drawing.Size(910, 384);
            this.tab_Control.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pl_OutPutItems);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(902, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "IO输出";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pl_OutPutItems
            // 
            this.pl_OutPutItems.Controls.Add(this.panel13);
            this.pl_OutPutItems.Controls.Add(this.panel3);
            this.pl_OutPutItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_OutPutItems.Location = new System.Drawing.Point(3, 3);
            this.pl_OutPutItems.Name = "pl_OutPutItems";
            this.pl_OutPutItems.Size = new System.Drawing.Size(896, 346);
            this.pl_OutPutItems.TabIndex = 8;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.lv_Items);
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(896, 300);
            this.panel13.TabIndex = 5;
            // 
            // lv_Items
            // 
            this.lv_Items.ContextMenuStrip = this.cm_Items;
            this.lv_Items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Items.LargeImageList = this.il_Items;
            this.lv_Items.Location = new System.Drawing.Point(0, 0);
            this.lv_Items.Name = "lv_Items";
            this.lv_Items.OwnerDraw = true;
            this.lv_Items.SelectedColor = System.Drawing.Color.DodgerBlue;
            this.lv_Items.Size = new System.Drawing.Size(776, 300);
            this.lv_Items.TabIndex = 4;
            this.lv_Items.UseCompatibleStateImageBehavior = false;
            this.lv_Items.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_Items_MouseClick);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btnPowerOFF_BUS);
            this.panel14.Controls.Add(this.btnPowerON_BUS);
            this.panel14.Controls.Add(this.btnPowerOFF_Board);
            this.panel14.Controls.Add(this.btnRefresh);
            this.panel14.Controls.Add(this.btnPowerON);
            this.panel14.Controls.Add(this.btnPowerOFF);
            this.panel14.Controls.Add(this.btnPowerONAll);
            this.panel14.Controls.Add(this.btnPowerOFFAll);
            this.panel14.Controls.Add(this.btnPowerON_Board);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel14.Location = new System.Drawing.Point(776, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(120, 300);
            this.panel14.TabIndex = 5;
            // 
            // btnPowerOFF_BUS
            // 
            this.btnPowerOFF_BUS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPowerOFF_BUS.BackColor = System.Drawing.Color.Red;
            this.btnPowerOFF_BUS.Enabled = false;
            this.btnPowerOFF_BUS.ForeColor = System.Drawing.Color.White;
            this.btnPowerOFF_BUS.Location = new System.Drawing.Point(14, 238);
            this.btnPowerOFF_BUS.Name = "btnPowerOFF_BUS";
            this.btnPowerOFF_BUS.Size = new System.Drawing.Size(101, 24);
            this.btnPowerOFF_BUS.TabIndex = 12;
            this.btnPowerOFF_BUS.Text = "全部关闭(总线)";
            this.btnPowerOFF_BUS.UseVisualStyleBackColor = false;
            this.btnPowerOFF_BUS.Visible = false;
            this.btnPowerOFF_BUS.Click += new System.EventHandler(this.btnPowerOFF_BUS_Click);
            // 
            // btnPowerON_BUS
            // 
            this.btnPowerON_BUS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPowerON_BUS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPowerON_BUS.Enabled = false;
            this.btnPowerON_BUS.ForeColor = System.Drawing.Color.Yellow;
            this.btnPowerON_BUS.Location = new System.Drawing.Point(14, 210);
            this.btnPowerON_BUS.Name = "btnPowerON_BUS";
            this.btnPowerON_BUS.Size = new System.Drawing.Size(101, 22);
            this.btnPowerON_BUS.TabIndex = 11;
            this.btnPowerON_BUS.Text = "全部启动(总线)";
            this.btnPowerON_BUS.UseVisualStyleBackColor = false;
            this.btnPowerON_BUS.Visible = false;
            this.btnPowerON_BUS.Click += new System.EventHandler(this.btnPowerON_BUS_Click);
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter3.Location = new System.Drawing.Point(0, 408);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(910, 5);
            this.splitter3.TabIndex = 7;
            this.splitter3.TabStop = false;
            // 
            // pl_InputMgr
            // 
            this.pl_InputMgr.Controls.Add(this.lv_DIItems);
            this.pl_InputMgr.Controls.Add(this.panel11);
            this.pl_InputMgr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pl_InputMgr.Location = new System.Drawing.Point(0, 413);
            this.pl_InputMgr.Name = "pl_InputMgr";
            this.pl_InputMgr.Size = new System.Drawing.Size(910, 171);
            this.pl_InputMgr.TabIndex = 6;
            // 
            // lv_DIItems
            // 
            this.lv_DIItems.ContextMenuStrip = this.cm_InputItems;
            this.lv_DIItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_DIItems.LargeImageList = this.il_InputItems;
            this.lv_DIItems.Location = new System.Drawing.Point(0, 24);
            this.lv_DIItems.Name = "lv_DIItems";
            this.lv_DIItems.Size = new System.Drawing.Size(910, 147);
            this.lv_DIItems.TabIndex = 0;
            this.lv_DIItems.UseCompatibleStateImageBehavior = false;
            // 
            // cm_InputItems
            // 
            this.cm_InputItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_InputAdd,
            this.mnu_InputModify,
            this.mnu_InputRemove,
            this.toolStripMenuItem11,
            this.mnu_iActions});
            this.cm_InputItems.Name = "cm_Items";
            this.cm_InputItems.Size = new System.Drawing.Size(125, 98);
            // 
            // mnu_InputAdd
            // 
            this.mnu_InputAdd.Name = "mnu_InputAdd";
            this.mnu_InputAdd.Size = new System.Drawing.Size(124, 22);
            this.mnu_InputAdd.Text = "添加项目";
            this.mnu_InputAdd.Click += new System.EventHandler(this.mnu_InputAdd_Click);
            // 
            // mnu_InputModify
            // 
            this.mnu_InputModify.Name = "mnu_InputModify";
            this.mnu_InputModify.Size = new System.Drawing.Size(124, 22);
            this.mnu_InputModify.Text = "修改项目";
            this.mnu_InputModify.Click += new System.EventHandler(this.mnu_InputModify_Click);
            // 
            // mnu_InputRemove
            // 
            this.mnu_InputRemove.Name = "mnu_InputRemove";
            this.mnu_InputRemove.Size = new System.Drawing.Size(124, 22);
            this.mnu_InputRemove.Text = "删除项目";
            this.mnu_InputRemove.Click += new System.EventHandler(this.mnu_InputRemove_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(121, 6);
            // 
            // mnu_iActions
            // 
            this.mnu_iActions.Name = "mnu_iActions";
            this.mnu_iActions.Size = new System.Drawing.Size(124, 22);
            this.mnu_iActions.Text = "执行器";
            this.mnu_iActions.Click += new System.EventHandler(this.mnu_iActions_Click);
            // 
            // il_InputItems
            // 
            this.il_InputItems.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_InputItems.ImageStream")));
            this.il_InputItems.TransparentColor = System.Drawing.Color.Transparent;
            this.il_InputItems.Images.SetKeyName(0, "3.png");
            this.il_InputItems.Images.SetKeyName(1, "2.png");
            this.il_InputItems.Images.SetKeyName(2, "1.png");
            this.il_InputItems.Images.SetKeyName(3, "temp.png");
            this.il_InputItems.Images.SetKeyName(4, "湿度.png");
            this.il_InputItems.Images.SetKeyName(5, "20090318230121808.png");
            this.il_InputItems.Images.SetKeyName(6, "boss.png");
            this.il_InputItems.Images.SetKeyName(7, "byebye.png");
            this.il_InputItems.Images.SetKeyName(8, "after_boom.png");
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label11);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(910, 24);
            this.panel11.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "传感器";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label10);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(910, 24);
            this.panel10.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "控制器";
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.splitter2.Location = new System.Drawing.Point(106, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(5, 584);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // pl_Left
            // 
            this.pl_Left.Controls.Add(this.lv_Category);
            this.pl_Left.Controls.Add(this.panel8);
            this.pl_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_Left.Location = new System.Drawing.Point(0, 0);
            this.pl_Left.Name = "pl_Left";
            this.pl_Left.Size = new System.Drawing.Size(106, 584);
            this.pl_Left.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(106, 24);
            this.panel8.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "分组";
            // 
            // pl_Backgroud
            // 
            this.pl_Backgroud.Controls.Add(this.splitter1);
            this.pl_Backgroud.Controls.Add(this.panel4);
            this.pl_Backgroud.Controls.Add(this.pl_TaskMgr);
            this.pl_Backgroud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_Backgroud.Location = new System.Drawing.Point(0, 105);
            this.pl_Backgroud.Name = "pl_Backgroud";
            this.pl_Backgroud.Size = new System.Drawing.Size(1021, 700);
            this.pl_Backgroud.TabIndex = 7;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 579);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1021, 5);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pl_TaskMgr
            // 
            this.pl_TaskMgr.Controls.Add(this.lv_TaskMgr);
            this.pl_TaskMgr.Controls.Add(this.panel6);
            this.pl_TaskMgr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pl_TaskMgr.Location = new System.Drawing.Point(0, 584);
            this.pl_TaskMgr.Name = "pl_TaskMgr";
            this.pl_TaskMgr.Size = new System.Drawing.Size(1021, 116);
            this.pl_TaskMgr.TabIndex = 0;
            // 
            // lv_TaskMgr
            // 
            this.lv_TaskMgr.CheckBoxes = true;
            this.lv_TaskMgr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_itemName,
            this.ch_TaskTime,
            this.ch_taskType,
            this.ch_Action});
            this.lv_TaskMgr.ContextMenuStrip = this.cm_TaskMgr;
            this.lv_TaskMgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_TaskMgr.FullRowSelect = true;
            this.lv_TaskMgr.GridLines = true;
            this.lv_TaskMgr.Location = new System.Drawing.Point(0, 0);
            this.lv_TaskMgr.Name = "lv_TaskMgr";
            this.lv_TaskMgr.Size = new System.Drawing.Size(882, 116);
            this.lv_TaskMgr.TabIndex = 1;
            this.lv_TaskMgr.UseCompatibleStateImageBehavior = false;
            this.lv_TaskMgr.View = System.Windows.Forms.View.Details;
            // 
            // ch_itemName
            // 
            this.ch_itemName.Text = "项目";
            this.ch_itemName.Width = 100;
            // 
            // ch_TaskTime
            // 
            this.ch_TaskTime.Text = "时间";
            this.ch_TaskTime.Width = 250;
            // 
            // ch_taskType
            // 
            this.ch_taskType.Text = "任务类型";
            this.ch_taskType.Width = 100;
            // 
            // ch_Action
            // 
            this.ch_Action.Text = "动作";
            this.ch_Action.Width = 100;
            // 
            // cm_TaskMgr
            // 
            this.cm_TaskMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_modifyTask,
            this.mnu_RemoveTask,
            this.toolStripSeparator1,
            this.mnu_AllTasks,
            this.toolStripMenuItem3,
            this.mnu_CheckedAll,
            this.mnu_UNCheckedAll,
            this.toolStripMenuItem4,
            this.mnu_TaskLock});
            this.cm_TaskMgr.Name = "cm_Items";
            this.cm_TaskMgr.Size = new System.Drawing.Size(125, 154);
            // 
            // mnu_modifyTask
            // 
            this.mnu_modifyTask.Name = "mnu_modifyTask";
            this.mnu_modifyTask.Size = new System.Drawing.Size(124, 22);
            this.mnu_modifyTask.Text = "修改任务";
            this.mnu_modifyTask.Click += new System.EventHandler(this.mnu_modifyTask_Click);
            // 
            // mnu_RemoveTask
            // 
            this.mnu_RemoveTask.Name = "mnu_RemoveTask";
            this.mnu_RemoveTask.Size = new System.Drawing.Size(124, 22);
            this.mnu_RemoveTask.Text = "删除任务";
            this.mnu_RemoveTask.Click += new System.EventHandler(this.mnu_RemoveTask_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // mnu_AllTasks
            // 
            this.mnu_AllTasks.Name = "mnu_AllTasks";
            this.mnu_AllTasks.Size = new System.Drawing.Size(124, 22);
            this.mnu_AllTasks.Text = "所有任务";
            this.mnu_AllTasks.Click += new System.EventHandler(this.mnu_AllTasks_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(121, 6);
            // 
            // mnu_CheckedAll
            // 
            this.mnu_CheckedAll.Name = "mnu_CheckedAll";
            this.mnu_CheckedAll.Size = new System.Drawing.Size(124, 22);
            this.mnu_CheckedAll.Text = "勾选所有";
            this.mnu_CheckedAll.Click += new System.EventHandler(this.mnu_CheckedAll_Click);
            // 
            // mnu_UNCheckedAll
            // 
            this.mnu_UNCheckedAll.Name = "mnu_UNCheckedAll";
            this.mnu_UNCheckedAll.Size = new System.Drawing.Size(124, 22);
            this.mnu_UNCheckedAll.Text = "取消勾选";
            this.mnu_UNCheckedAll.Click += new System.EventHandler(this.mnu_UNCheckedAll_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(121, 6);
            // 
            // mnu_TaskLock
            // 
            this.mnu_TaskLock.Name = "mnu_TaskLock";
            this.mnu_TaskLock.Size = new System.Drawing.Size(124, 22);
            this.mnu_TaskLock.Text = "锁定列表";
            this.mnu_TaskLock.Click += new System.EventHandler(this.mnu_TaskLock_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_TaskStop);
            this.panel6.Controls.Add(this.btn_TaskRun);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(882, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(139, 116);
            this.panel6.TabIndex = 0;
            // 
            // btn_TaskStop
            // 
            this.btn_TaskStop.BackColor = System.Drawing.Color.Red;
            this.btn_TaskStop.Enabled = false;
            this.btn_TaskStop.ForeColor = System.Drawing.Color.White;
            this.btn_TaskStop.Location = new System.Drawing.Point(15, 61);
            this.btn_TaskStop.Name = "btn_TaskStop";
            this.btn_TaskStop.Size = new System.Drawing.Size(110, 38);
            this.btn_TaskStop.TabIndex = 1;
            this.btn_TaskStop.Text = "停止任务";
            this.btn_TaskStop.UseVisualStyleBackColor = false;
            this.btn_TaskStop.Click += new System.EventHandler(this.btn_TaskStop_Click);
            // 
            // btn_TaskRun
            // 
            this.btn_TaskRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_TaskRun.Enabled = false;
            this.btn_TaskRun.ForeColor = System.Drawing.Color.Yellow;
            this.btn_TaskRun.Location = new System.Drawing.Point(15, 16);
            this.btn_TaskRun.Name = "btn_TaskRun";
            this.btn_TaskRun.Size = new System.Drawing.Size(110, 39);
            this.btn_TaskRun.TabIndex = 0;
            this.btn_TaskRun.Text = "执行任务";
            this.btn_TaskRun.UseVisualStyleBackColor = false;
            this.btn_TaskRun.Click += new System.EventHandler(this.btn_TaskRun_Click);
            // 
            // pl_Top
            // 
            this.pl_Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pl_Top.Controls.Add(this.btn_InfoPanel);
            this.pl_Top.Controls.Add(this.pl_PoolInfo);
            this.pl_Top.Controls.Add(this.gb_quickConn);
            this.pl_Top.Controls.Add(this.pictureBox5);
            this.pl_Top.Controls.Add(this.btnEndListen);
            this.pl_Top.Controls.Add(this.btnBeginListen);
            this.pl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_Top.Location = new System.Drawing.Point(0, 25);
            this.pl_Top.Name = "pl_Top";
            this.pl_Top.Size = new System.Drawing.Size(1021, 80);
            this.pl_Top.TabIndex = 8;
            // 
            // btn_InfoPanel
            // 
            this.btn_InfoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_InfoPanel.Location = new System.Drawing.Point(698, 0);
            this.btn_InfoPanel.Name = "btn_InfoPanel";
            this.btn_InfoPanel.Size = new System.Drawing.Size(11, 75);
            this.btn_InfoPanel.TabIndex = 20;
            this.btn_InfoPanel.Text = "|";
            this.btn_InfoPanel.UseVisualStyleBackColor = true;
            this.btn_InfoPanel.Visible = false;
            this.btn_InfoPanel.Click += new System.EventHandler(this.btn_InfoPanel_Click);
            // 
            // pl_PoolInfo
            // 
            this.pl_PoolInfo.Controls.Add(this.txt_PoolInfo);
            this.pl_PoolInfo.Controls.Add(this.panel5);
            this.pl_PoolInfo.Location = new System.Drawing.Point(704, 10);
            this.pl_PoolInfo.Name = "pl_PoolInfo";
            this.pl_PoolInfo.Size = new System.Drawing.Size(131, 59);
            this.pl_PoolInfo.TabIndex = 19;
            this.pl_PoolInfo.Visible = false;
            // 
            // txt_PoolInfo
            // 
            this.txt_PoolInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_PoolInfo.ForeColor = System.Drawing.Color.Red;
            this.txt_PoolInfo.Location = new System.Drawing.Point(0, 0);
            this.txt_PoolInfo.Multiline = true;
            this.txt_PoolInfo.Name = "txt_PoolInfo";
            this.txt_PoolInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_PoolInfo.Size = new System.Drawing.Size(99, 59);
            this.txt_PoolInfo.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_PoolInfo_Save);
            this.panel5.Controls.Add(this.btn_PoolInfo_Clear);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(99, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(32, 59);
            this.panel5.TabIndex = 2;
            // 
            // btn_PoolInfo_Save
            // 
            this.btn_PoolInfo_Save.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PoolInfo_Save.Location = new System.Drawing.Point(0, 23);
            this.btn_PoolInfo_Save.Name = "btn_PoolInfo_Save";
            this.btn_PoolInfo_Save.Size = new System.Drawing.Size(32, 23);
            this.btn_PoolInfo_Save.TabIndex = 1;
            this.btn_PoolInfo_Save.Text = "S";
            this.btn_PoolInfo_Save.UseVisualStyleBackColor = true;
            this.btn_PoolInfo_Save.Visible = false;
            this.btn_PoolInfo_Save.Click += new System.EventHandler(this.btn_PoolInfo_Save_Click);
            // 
            // btn_PoolInfo_Clear
            // 
            this.btn_PoolInfo_Clear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PoolInfo_Clear.Location = new System.Drawing.Point(0, 0);
            this.btn_PoolInfo_Clear.Name = "btn_PoolInfo_Clear";
            this.btn_PoolInfo_Clear.Size = new System.Drawing.Size(32, 23);
            this.btn_PoolInfo_Clear.TabIndex = 0;
            this.btn_PoolInfo_Clear.Text = "C";
            this.btn_PoolInfo_Clear.UseVisualStyleBackColor = true;
            this.btn_PoolInfo_Clear.Click += new System.EventHandler(this.btn_PoolInfo_Clear_Click);
            // 
            // gb_quickConn
            // 
            this.gb_quickConn.Controls.Add(this.rb_UDP);
            this.gb_quickConn.Controls.Add(this.cb_Band);
            this.gb_quickConn.Controls.Add(this.label12);
            this.gb_quickConn.Controls.Add(this.cb_SerialPort);
            this.gb_quickConn.Controls.Add(this.nud_Delay);
            this.gb_quickConn.Controls.Add(this.label3);
            this.gb_quickConn.Controls.Add(this.txtPort);
            this.gb_quickConn.Controls.Add(this.label2);
            this.gb_quickConn.Controls.Add(this.label1);
            this.gb_quickConn.Controls.Add(this.rb_TCP);
            this.gb_quickConn.Controls.Add(this.txtIP);
            this.gb_quickConn.Controls.Add(this.rb_COM);
            this.gb_quickConn.Controls.Add(this.label8);
            this.gb_quickConn.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_quickConn.Location = new System.Drawing.Point(0, 0);
            this.gb_quickConn.Name = "gb_quickConn";
            this.gb_quickConn.Size = new System.Drawing.Size(698, 75);
            this.gb_quickConn.TabIndex = 18;
            this.gb_quickConn.TabStop = false;
            this.gb_quickConn.Text = "快速连接";
            // 
            // rb_UDP
            // 
            this.rb_UDP.AutoSize = true;
            this.rb_UDP.Location = new System.Drawing.Point(494, 21);
            this.rb_UDP.Name = "rb_UDP";
            this.rb_UDP.Size = new System.Drawing.Size(47, 16);
            this.rb_UDP.TabIndex = 18;
            this.rb_UDP.TabStop = true;
            this.rb_UDP.Text = "全网";
            this.rb_UDP.UseVisualStyleBackColor = true;
            this.rb_UDP.CheckedChanged += new System.EventHandler(this.rb_UDP_CheckedChanged);
            // 
            // cb_Band
            // 
            this.cb_Band.FormattingEnabled = true;
            this.cb_Band.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "Flex Wire"});
            this.cb_Band.Location = new System.Drawing.Point(286, 43);
            this.cb_Band.Name = "cb_Band";
            this.cb_Band.Size = new System.Drawing.Size(93, 20);
            this.cb_Band.TabIndex = 17;
            this.cb_Band.Text = "9600";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(284, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 16;
            this.label12.Text = "波特率";
            // 
            // txtPort
            // 
            this.txtPort.Enabled = false;
            this.txtPort.Location = new System.Drawing.Point(636, 44);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(46, 21);
            this.txtPort.TabIndex = 15;
            this.txtPort.Text = "9990";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(595, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "端口:";
            // 
            // rb_TCP
            // 
            this.rb_TCP.AutoSize = true;
            this.rb_TCP.Location = new System.Drawing.Point(414, 21);
            this.rb_TCP.Name = "rb_TCP";
            this.rb_TCP.Size = new System.Drawing.Size(47, 16);
            this.rb_TCP.TabIndex = 10;
            this.rb_TCP.Text = "单点";
            this.rb_TCP.UseVisualStyleBackColor = true;
            this.rb_TCP.CheckedChanged += new System.EventHandler(this.rbNetWork_CheckedChanged);
            // 
            // txtIP
            // 
            this.txtIP.Enabled = false;
            this.txtIP.Location = new System.Drawing.Point(441, 43);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(148, 21);
            this.txtIP.TabIndex = 13;
            this.txtIP.Text = "127.0.0.1";
            // 
            // rb_COM
            // 
            this.rb_COM.AutoSize = true;
            this.rb_COM.Checked = true;
            this.rb_COM.Location = new System.Drawing.Point(174, 22);
            this.rb_COM.Name = "rb_COM";
            this.rb_COM.Size = new System.Drawing.Size(71, 16);
            this.rb_COM.TabIndex = 11;
            this.rb_COM.TabStop = true;
            this.rb_COM.Text = "串口连接";
            this.rb_COM.UseVisualStyleBackColor = true;
            this.rb_COM.CheckedChanged += new System.EventHandler(this.rbCOM_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(412, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "IP:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox5.Location = new System.Drawing.Point(0, 75);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1021, 5);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // timer_Task
            // 
            this.timer_Task.Interval = 1000;
            this.timer_Task.Tick += new System.EventHandler(this.timer_Task_Tick);
            // 
            // cms_notifyIcon
            // 
            this.cms_notifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Restore,
            this.toolStripMenuItem7,
            this.cms_Exit});
            this.cms_notifyIcon.Name = "cms_notifyIcon";
            this.cms_notifyIcon.Size = new System.Drawing.Size(101, 54);
            // 
            // mnu_Restore
            // 
            this.mnu_Restore.Name = "mnu_Restore";
            this.mnu_Restore.Size = new System.Drawing.Size(100, 22);
            this.mnu_Restore.Text = "还原";
            this.mnu_Restore.Click += new System.EventHandler(this.mnu_Restore_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(97, 6);
            // 
            // cms_Exit
            // 
            this.cms_Exit.Name = "cms_Exit";
            this.cms_Exit.Size = new System.Drawing.Size(100, 22);
            this.cms_Exit.Text = "退出";
            this.cms_Exit.Click += new System.EventHandler(this.mnu_Exit_Click);
            // 
            // tm_AllowAction
            // 
            this.tm_AllowAction.Interval = 5000;
            this.tm_AllowAction.Tick += new System.EventHandler(this.tm_AllowAction_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_Info});
            this.statusStrip1.Location = new System.Drawing.Point(0, 859);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1021, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl_Info
            // 
            this.tssl_Info.Name = "tssl_Info";
            this.tssl_Info.Size = new System.Drawing.Size(0, 17);
            // 
            // tm_TimeService
            // 
            this.tm_TimeService.Enabled = true;
            this.tm_TimeService.Interval = 600000;
            this.tm_TimeService.Tick += new System.EventHandler(this.tm_TimeService_Tick);
            // 
            // timer_watchdog
            // 
            this.timer_watchdog.Enabled = true;
            this.timer_watchdog.Interval = 1000;
            this.timer_watchdog.Tick += new System.EventHandler(this.timer_watchdog_Tick);
            // 
            // RelayMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 881);
            this.Controls.Add(this.pl_Backgroud);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pl_Top);
            this.Controls.Add(this.mnu_Main);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RelayMgr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "智能开关管理 - 北京凯睿瑞驰科技有限公司";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelayMgr_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RelayMgr_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Delay)).EndInit();
            this.cm_Category.ResumeLayout(false);
            this.cm_Items.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUNKNOWN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOFF)).EndInit();
            this.mnu_Main.ResumeLayout(false);
            this.mnu_Main.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.tab_Control.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pl_OutPutItems.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.pl_InputMgr.ResumeLayout(false);
            this.cm_InputItems.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.pl_Left.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.pl_Backgroud.ResumeLayout(false);
            this.pl_TaskMgr.ResumeLayout(false);
            this.cm_TaskMgr.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.pl_Top.ResumeLayout(false);
            this.pl_PoolInfo.ResumeLayout(false);
            this.pl_PoolInfo.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.gb_quickConn.ResumeLayout(false);
            this.gb_quickConn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.cms_notifyIcon.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lv_Category;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cb_SerialPort;
        private System.Windows.Forms.Button btnEndListen;
        private System.Windows.Forms.Button btnBeginListen;
        private System.Windows.Forms.ContextMenuStrip cm_Category;
        private System.Windows.Forms.ToolStripMenuItem mnu_DevTypeAdd;
        private System.Windows.Forms.ToolStripMenuItem mnu_DevTypeModify;
        private System.Windows.Forms.ToolStripMenuItem mnu_DevTypeRemove;
        private System.Windows.Forms.ContextMenuStrip cm_Items;
        private System.Windows.Forms.ToolStripMenuItem mnu_DevAdd;
        private System.Windows.Forms.ToolStripMenuItem mnu_DevModify;
        private System.Windows.Forms.ToolStripMenuItem mnu_DevRemove;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ImageList il_Category;
        private System.Windows.Forms.ImageList il_Items;
        private System.Windows.Forms.Button btnPowerOFF;
        private System.Windows.Forms.Button btnPowerON;
        private System.Windows.Forms.Button btnRefresh;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.MenuStrip mnu_Main;
        private System.Windows.Forms.ToolStripMenuItem mnu_File;
        private System.Windows.Forms.ToolStripMenuItem mnu_Exit;
        private System.Windows.Forms.ToolStripMenuItem mnu_Help;
        private System.Windows.Forms.ToolStripMenuItem mnu_About;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer_INQUIRE;
        private System.Windows.Forms.NumericUpDown nud_Delay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPowerOFF_Board;
        private System.Windows.Forms.Button btnPowerON_Board;
        private System.Windows.Forms.PictureBox pbUNKNOWN;
        private System.Windows.Forms.PictureBox pbON;
        private System.Windows.Forms.PictureBox pbOFF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPowerOFFAll;
        private System.Windows.Forms.Button btnPowerONAll;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pl_Backgroud;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pl_TaskMgr;
        private System.Windows.Forms.Panel pl_Top;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListView lv_TaskMgr;
        private System.Windows.Forms.ColumnHeader ch_itemName;
        private System.Windows.Forms.ColumnHeader ch_TaskTime;
        private System.Windows.Forms.ColumnHeader ch_taskType;
        private System.Windows.Forms.ColumnHeader ch_Action;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnu_AddTask;
        private System.Windows.Forms.ToolStripMenuItem mnu_View;
        private System.Windows.Forms.ToolStripMenuItem mnu_TaskMgr;
        private System.Windows.Forms.Button btn_TaskRun;
        private System.Windows.Forms.Button btn_TaskStop;
        private System.Windows.Forms.ContextMenuStrip cm_TaskMgr;
        private System.Windows.Forms.ToolStripMenuItem mnu_modifyTask;
        private System.Windows.Forms.ToolStripMenuItem mnu_RemoveTask;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnu_AllTasks;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnu_CheckedAll;
        private System.Windows.Forms.ToolStripMenuItem mnu_UNCheckedAll;
        private System.Windows.Forms.Timer timer_Task;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mnu_TaskLock;
        private System.Windows.Forms.RadioButton rb_TCP;
        private System.Windows.Forms.RadioButton rb_COM;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem mnu_ShowTimer;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pl_Left;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem mnu_GroupTasks;
        private CSharpWin.ListViewEx lv_Items;
        private System.Windows.Forms.ToolStripMenuItem mnu_Settings;
        private System.Windows.Forms.ToolStripMenuItem mnu_System;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem mnu_RunAction;
        private System.Windows.Forms.ListView lv_DIItems;
        private System.Windows.Forms.Panel pl_InputMgr;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ImageList il_InputItems;
        private System.Windows.Forms.ContextMenuStrip cm_InputItems;
        private System.Windows.Forms.ToolStripMenuItem mnu_InputAdd;
        private System.Windows.Forms.ToolStripMenuItem mnu_InputModify;
        private System.Windows.Forms.ToolStripMenuItem mnu_InputRemove;
        private System.Windows.Forms.Label lbl_Connected;
        private System.Windows.Forms.ToolStripMenuItem mnu_InputMgr;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.ContextMenuStrip cms_notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem cms_Exit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem mnu_Restore;
        private System.Windows.Forms.Button btn_Lockthis;
        private System.Windows.Forms.ToolStripMenuItem 显示方式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大图标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 列表ToolStripMenuItem;
        private System.Windows.Forms.Panel pl_OutPutItems;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.ImageList il_VItems;
        private System.Windows.Forms.TabControl tab_Control;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem mnu_ConnecSetting;
        private System.Windows.Forms.ToolStripMenuItem mnu_BeginListen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.Timer tm_AllowAction;
        private System.Windows.Forms.ToolStripMenuItem mnu_pool;
        private System.Windows.Forms.GroupBox gb_quickConn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Info;
        private System.Windows.Forms.Panel pl_PoolInfo;
        private System.Windows.Forms.TextBox txt_PoolInfo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_PoolInfo_Clear;
        private System.Windows.Forms.Button btn_PoolInfo_Save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnPowerOFF_BUS;
        private System.Windows.Forms.Button btnPowerON_BUS;
        private System.Windows.Forms.Button btn_InfoPanel;
        private System.Windows.Forms.Timer tm_TimeService;
        private System.Windows.Forms.ToolStripMenuItem mnu_Actions;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem mnu_iActions;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_Band;
        private System.Windows.Forms.Button btn_Manual;
        private System.Windows.Forms.Timer timer_watchdog;
        private System.Windows.Forms.RadioButton rb_UDP;
    }
}

