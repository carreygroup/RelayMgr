namespace RelayMgr
{
    partial class frmPool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPool));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_SerialPort = new System.Windows.Forms.ComboBox();
            this.lv_SerialPort = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_COM_Add = new System.Windows.Forms.Button();
            this.btn_COM_Remove = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Host = new System.Windows.Forms.TextBox();
            this.lv_NetWork = new System.Windows.Forms.ListView();
            this.btn_NetWork_Remove = new System.Windows.Forms.Button();
            this.btn_NetWork_Add = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lv_Group = new System.Windows.Forms.ListView();
            this.il_Category = new System.Windows.Forms.ImageList(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_SerialPort);
            this.groupBox1.Controls.Add(this.lv_SerialPort);
            this.groupBox1.Controls.Add(this.btn_COM_Add);
            this.groupBox1.Controls.Add(this.btn_COM_Remove);
            this.groupBox1.Location = new System.Drawing.Point(6, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口池";
            // 
            // cb_SerialPort
            // 
            this.cb_SerialPort.FormattingEnabled = true;
            this.cb_SerialPort.Location = new System.Drawing.Point(6, 273);
            this.cb_SerialPort.Name = "cb_SerialPort";
            this.cb_SerialPort.Size = new System.Drawing.Size(284, 20);
            this.cb_SerialPort.TabIndex = 3;
            this.cb_SerialPort.DropDown += new System.EventHandler(this.cb_SerialPort_DropDown);
            // 
            // lv_SerialPort
            // 
            this.lv_SerialPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.lv_SerialPort.LargeImageList = this.imageList1;
            this.lv_SerialPort.Location = new System.Drawing.Point(3, 17);
            this.lv_SerialPort.Name = "lv_SerialPort";
            this.lv_SerialPort.Size = new System.Drawing.Size(290, 250);
            this.lv_SerialPort.TabIndex = 2;
            this.lv_SerialPort.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1525.gif");
            this.imageList1.Images.SetKeyName(1, "20071208005434705.png");
            // 
            // btn_COM_Add
            // 
            this.btn_COM_Add.Location = new System.Drawing.Point(134, 302);
            this.btn_COM_Add.Name = "btn_COM_Add";
            this.btn_COM_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_COM_Add.TabIndex = 1;
            this.btn_COM_Add.Text = "添加";
            this.btn_COM_Add.UseVisualStyleBackColor = true;
            this.btn_COM_Add.Click += new System.EventHandler(this.btn_COM_Add_Click);
            // 
            // btn_COM_Remove
            // 
            this.btn_COM_Remove.Location = new System.Drawing.Point(215, 302);
            this.btn_COM_Remove.Name = "btn_COM_Remove";
            this.btn_COM_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_COM_Remove.TabIndex = 0;
            this.btn_COM_Remove.Text = "删除";
            this.btn_COM_Remove.UseVisualStyleBackColor = true;
            this.btn_COM_Remove.Click += new System.EventHandler(this.btn_COM_Remove_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Host);
            this.groupBox2.Controls.Add(this.lv_NetWork);
            this.groupBox2.Controls.Add(this.btn_NetWork_Remove);
            this.groupBox2.Controls.Add(this.btn_NetWork_Add);
            this.groupBox2.Location = new System.Drawing.Point(308, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 331);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "网络池";
            // 
            // txt_Host
            // 
            this.txt_Host.Location = new System.Drawing.Point(3, 273);
            this.txt_Host.Name = "txt_Host";
            this.txt_Host.Size = new System.Drawing.Size(294, 21);
            this.txt_Host.TabIndex = 5;
            // 
            // lv_NetWork
            // 
            this.lv_NetWork.Dock = System.Windows.Forms.DockStyle.Top;
            this.lv_NetWork.LargeImageList = this.imageList1;
            this.lv_NetWork.Location = new System.Drawing.Point(3, 17);
            this.lv_NetWork.Name = "lv_NetWork";
            this.lv_NetWork.Size = new System.Drawing.Size(297, 250);
            this.lv_NetWork.TabIndex = 4;
            this.lv_NetWork.UseCompatibleStateImageBehavior = false;
            // 
            // btn_NetWork_Remove
            // 
            this.btn_NetWork_Remove.Location = new System.Drawing.Point(225, 302);
            this.btn_NetWork_Remove.Name = "btn_NetWork_Remove";
            this.btn_NetWork_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_NetWork_Remove.TabIndex = 3;
            this.btn_NetWork_Remove.Text = "删除";
            this.btn_NetWork_Remove.UseVisualStyleBackColor = true;
            this.btn_NetWork_Remove.Click += new System.EventHandler(this.btn_NetWork_Remove_Click);
            // 
            // btn_NetWork_Add
            // 
            this.btn_NetWork_Add.Location = new System.Drawing.Point(144, 302);
            this.btn_NetWork_Add.Name = "btn_NetWork_Add";
            this.btn_NetWork_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_NetWork_Add.TabIndex = 2;
            this.btn_NetWork_Add.Text = "添加";
            this.btn_NetWork_Add.UseVisualStyleBackColor = true;
            this.btn_NetWork_Add.Click += new System.EventHandler(this.btn_NetWork_Add_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(520, 540);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "关闭";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lv_Group);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(621, 159);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "分组";
            // 
            // lv_Group
            // 
            this.lv_Group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Group.LargeImageList = this.il_Category;
            this.lv_Group.Location = new System.Drawing.Point(3, 17);
            this.lv_Group.Name = "lv_Group";
            this.lv_Group.Size = new System.Drawing.Size(615, 139);
            this.lv_Group.TabIndex = 0;
            this.lv_Group.UseCompatibleStateImageBehavior = false;
            this.lv_Group.SelectedIndexChanged += new System.EventHandler(this.lv_Group_SelectedIndexChanged);
            // 
            // il_Category
            // 
            this.il_Category.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_Category.ImageStream")));
            this.il_Category.TransparentColor = System.Drawing.Color.Transparent;
            this.il_Category.Images.SetKeyName(0, "dreamesp Icon 34.ico");
            this.il_Category.Images.SetKeyName(1, "Junior Icon 72.ico");
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Location = new System.Drawing.Point(9, 177);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(621, 357);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "连接池";
            // 
            // frmPool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 571);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "连接池";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_COM_Add;
        private System.Windows.Forms.Button btn_COM_Remove;
        private System.Windows.Forms.Button btn_NetWork_Remove;
        private System.Windows.Forms.Button btn_NetWork_Add;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.ListView lv_SerialPort;
        private System.Windows.Forms.ListView lv_NetWork;
        private System.Windows.Forms.ComboBox cb_SerialPort;
        private System.Windows.Forms.TextBox txt_Host;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lv_Group;
        private System.Windows.Forms.ImageList il_Category;
    }
}