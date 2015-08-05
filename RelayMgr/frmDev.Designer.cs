namespace RelayMgr
{
    partial class frmDev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDev));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("1", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("2", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("3", 2);
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.NumericUpDown();
            this.txtLine = new System.Windows.Forms.NumericUpDown();
            this.lbl_Group = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lv_Group = new System.Windows.Forms.ListView();
            this.lb_Action = new System.Windows.Forms.Label();
            this.cb_DefAction = new System.Windows.Forms.ComboBox();
            this.cb_IO = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PowerFlash = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_btn_Action = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ImageGroup = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLine)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "设备名称:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(72, 169);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 21);
            this.txtName.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(222, 16);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(304, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "设备地址:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "值地址:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(72, 222);
            this.txtAddress.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtAddress.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(109, 21);
            this.txtAddress.TabIndex = 8;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAddress.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(252, 222);
            this.txtLine.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.txtLine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(118, 21);
            this.txtLine.TabIndex = 9;
            this.txtLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLine.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_Group
            // 
            this.lbl_Group.AutoSize = true;
            this.lbl_Group.Location = new System.Drawing.Point(13, 22);
            this.lbl_Group.Name = "lbl_Group";
            this.lbl_Group.Size = new System.Drawing.Size(59, 12);
            this.lbl_Group.TabIndex = 10;
            this.lbl_Group.Text = "设备分组:";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "db.png");
            this.imageList1.Images.SetKeyName(1, "angrydd.png");
            this.imageList1.Images.SetKeyName(2, "computer-server-rack_mount.png");
            // 
            // lv_Group
            // 
            this.lv_Group.HideSelection = false;
            this.lv_Group.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lv_Group.LargeImageList = this.imageList1;
            this.lv_Group.Location = new System.Drawing.Point(15, 38);
            this.lv_Group.MultiSelect = false;
            this.lv_Group.Name = "lv_Group";
            this.lv_Group.Size = new System.Drawing.Size(356, 121);
            this.lv_Group.TabIndex = 11;
            this.lv_Group.UseCompatibleStateImageBehavior = false;
            // 
            // lb_Action
            // 
            this.lb_Action.AutoSize = true;
            this.lb_Action.Location = new System.Drawing.Point(13, 254);
            this.lb_Action.Name = "lb_Action";
            this.lb_Action.Size = new System.Drawing.Size(95, 12);
            this.lb_Action.TabIndex = 12;
            this.lb_Action.Text = "组执行默认动作:";
            // 
            // cb_DefAction
            // 
            this.cb_DefAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_DefAction.FormattingEnabled = true;
            this.cb_DefAction.Items.AddRange(new object[] {
            "关",
            "开"});
            this.cb_DefAction.Location = new System.Drawing.Point(109, 251);
            this.cb_DefAction.Name = "cb_DefAction";
            this.cb_DefAction.Size = new System.Drawing.Size(72, 20);
            this.cb_DefAction.TabIndex = 13;
            // 
            // cb_IO
            // 
            this.cb_IO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_IO.FormattingEnabled = true;
            this.cb_IO.Items.AddRange(new object[] {
            "DO",
            "DI",
            "AD"});
            this.cb_IO.Location = new System.Drawing.Point(72, 196);
            this.cb_IO.Name = "cb_IO";
            this.cb_IO.Size = new System.Drawing.Size(109, 20);
            this.cb_IO.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "项目类型:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "点动延时:";
            // 
            // txt_PowerFlash
            // 
            this.txt_PowerFlash.Location = new System.Drawing.Point(252, 251);
            this.txt_PowerFlash.Name = "txt_PowerFlash";
            this.txt_PowerFlash.Size = new System.Drawing.Size(92, 21);
            this.txt_PowerFlash.TabIndex = 21;
            this.txt_PowerFlash.Text = "0";
            this.txt_PowerFlash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "秒";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_btn_Action);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_ImageGroup);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lv_Group);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtLine);
            this.groupBox1.Controls.Add(this.txt_PowerFlash);
            this.groupBox1.Controls.Add(this.lbl_Group);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lb_Action);
            this.groupBox1.Controls.Add(this.cb_DefAction);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_IO);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(382, 312);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "属性";
            // 
            // cb_btn_Action
            // 
            this.cb_btn_Action.Enabled = false;
            this.cb_btn_Action.FormattingEnabled = true;
            this.cb_btn_Action.Location = new System.Drawing.Point(72, 281);
            this.cb_btn_Action.Name = "cb_btn_Action";
            this.cb_btn_Action.Size = new System.Drawing.Size(294, 20);
            this.cb_btn_Action.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 25;
            this.label8.Text = "点击动作：";
            // 
            // txt_ImageGroup
            // 
            this.txt_ImageGroup.Location = new System.Drawing.Point(252, 195);
            this.txt_ImageGroup.Name = "txt_ImageGroup";
            this.txt_ImageGroup.Size = new System.Drawing.Size(118, 21);
            this.txt_ImageGroup.TabIndex = 24;
            this.txt_ImageGroup.Text = "0";
            this.txt_ImageGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "图标组：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 330);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 50);
            this.panel1.TabIndex = 30;
            // 
            // frmDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 380);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设备信息";
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLine)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown txtAddress;
        public System.Windows.Forms.NumericUpDown txtLine;
        public System.Windows.Forms.Label lbl_Group;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.ListView lv_Group;
        public System.Windows.Forms.ComboBox cb_DefAction;
        public System.Windows.Forms.ComboBox cb_IO;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lb_Action;
        public System.Windows.Forms.TextBox txt_PowerFlash;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_ImageGroup;
        public System.Windows.Forms.ComboBox cb_btn_Action;
        private System.Windows.Forms.Label label8;
    }
}