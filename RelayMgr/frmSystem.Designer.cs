namespace RelayMgr
{
    partial class frmSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSystem));
            this.tp_System = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cb_Connection_Pool = new System.Windows.Forms.CheckBox();
            this.btn_SetPassword = new System.Windows.Forms.Button();
            this.txt_PWD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_AutoRun = new System.Windows.Forms.CheckBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cb_btn_Item = new System.Windows.Forms.CheckBox();
            this.cb_btn_Window = new System.Windows.Forms.CheckBox();
            this.cb_btn_Board = new System.Windows.Forms.CheckBox();
            this.cb_btn_BUS = new System.Windows.Forms.CheckBox();
            this.cb_btn_Manual = new System.Windows.Forms.CheckBox();
            this.tp_System.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tp_System
            // 
            this.tp_System.Controls.Add(this.tabPage3);
            this.tp_System.Controls.Add(this.tabPage1);
            this.tp_System.Location = new System.Drawing.Point(12, 12);
            this.tp_System.Name = "tp_System";
            this.tp_System.SelectedIndex = 0;
            this.tp_System.Size = new System.Drawing.Size(437, 250);
            this.tp_System.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cb_Connection_Pool);
            this.tabPage3.Controls.Add(this.btn_SetPassword);
            this.tabPage3.Controls.Add(this.txt_PWD);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.cb_AutoRun);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(429, 224);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "常规";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cb_Connection_Pool
            // 
            this.cb_Connection_Pool.AutoSize = true;
            this.cb_Connection_Pool.Location = new System.Drawing.Point(31, 55);
            this.cb_Connection_Pool.Name = "cb_Connection_Pool";
            this.cb_Connection_Pool.Size = new System.Drawing.Size(84, 16);
            this.cb_Connection_Pool.TabIndex = 4;
            this.cb_Connection_Pool.Text = "使用连接池";
            this.cb_Connection_Pool.UseVisualStyleBackColor = true;
            // 
            // btn_SetPassword
            // 
            this.btn_SetPassword.Location = new System.Drawing.Point(333, 173);
            this.btn_SetPassword.Name = "btn_SetPassword";
            this.btn_SetPassword.Size = new System.Drawing.Size(75, 23);
            this.btn_SetPassword.TabIndex = 3;
            this.btn_SetPassword.Text = "设置";
            this.btn_SetPassword.UseVisualStyleBackColor = true;
            this.btn_SetPassword.Click += new System.EventHandler(this.btn_SetPassword_Click);
            // 
            // txt_PWD
            // 
            this.txt_PWD.Location = new System.Drawing.Point(86, 175);
            this.txt_PWD.Name = "txt_PWD";
            this.txt_PWD.Size = new System.Drawing.Size(241, 21);
            this.txt_PWD.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "解锁码：";
            // 
            // cb_AutoRun
            // 
            this.cb_AutoRun.AutoSize = true;
            this.cb_AutoRun.Location = new System.Drawing.Point(31, 22);
            this.cb_AutoRun.Name = "cb_AutoRun";
            this.cb_AutoRun.Size = new System.Drawing.Size(96, 16);
            this.cb_AutoRun.TabIndex = 0;
            this.cb_AutoRun.Text = "开机自动运行";
            this.cb_AutoRun.UseVisualStyleBackColor = true;
            this.cb_AutoRun.CheckedChanged += new System.EventHandler(this.cb_AutoRun_CheckedChanged);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(289, 282);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(370, 282);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // ofd
            // 
            this.ofd.Filter = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg|JPEG|*.jpeg|PNG|*.png|ICON|*.ico";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cb_btn_Manual);
            this.tabPage1.Controls.Add(this.cb_btn_BUS);
            this.tabPage1.Controls.Add(this.cb_btn_Board);
            this.tabPage1.Controls.Add(this.cb_btn_Window);
            this.tabPage1.Controls.Add(this.cb_btn_Item);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(429, 224);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "界面按钮";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cb_btn_Item
            // 
            this.cb_btn_Item.AutoSize = true;
            this.cb_btn_Item.Location = new System.Drawing.Point(17, 17);
            this.cb_btn_Item.Name = "cb_btn_Item";
            this.cb_btn_Item.Size = new System.Drawing.Size(96, 16);
            this.cb_btn_Item.TabIndex = 0;
            this.cb_btn_Item.Text = "单项操作按钮";
            this.cb_btn_Item.UseVisualStyleBackColor = true;
            // 
            // cb_btn_Window
            // 
            this.cb_btn_Window.AutoSize = true;
            this.cb_btn_Window.Location = new System.Drawing.Point(119, 17);
            this.cb_btn_Window.Name = "cb_btn_Window";
            this.cb_btn_Window.Size = new System.Drawing.Size(96, 16);
            this.cb_btn_Window.TabIndex = 1;
            this.cb_btn_Window.Text = "界面操作按钮";
            this.cb_btn_Window.UseVisualStyleBackColor = true;
            // 
            // cb_btn_Board
            // 
            this.cb_btn_Board.AutoSize = true;
            this.cb_btn_Board.Location = new System.Drawing.Point(221, 17);
            this.cb_btn_Board.Name = "cb_btn_Board";
            this.cb_btn_Board.Size = new System.Drawing.Size(96, 16);
            this.cb_btn_Board.TabIndex = 2;
            this.cb_btn_Board.Text = "板卡操作按钮";
            this.cb_btn_Board.UseVisualStyleBackColor = true;
            // 
            // cb_btn_BUS
            // 
            this.cb_btn_BUS.AutoSize = true;
            this.cb_btn_BUS.Location = new System.Drawing.Point(323, 17);
            this.cb_btn_BUS.Name = "cb_btn_BUS";
            this.cb_btn_BUS.Size = new System.Drawing.Size(96, 16);
            this.cb_btn_BUS.TabIndex = 4;
            this.cb_btn_BUS.Text = "总线操作按钮";
            this.cb_btn_BUS.UseVisualStyleBackColor = true;
            // 
            // cb_btn_Manual
            // 
            this.cb_btn_Manual.AutoSize = true;
            this.cb_btn_Manual.Location = new System.Drawing.Point(17, 39);
            this.cb_btn_Manual.Name = "cb_btn_Manual";
            this.cb_btn_Manual.Size = new System.Drawing.Size(96, 16);
            this.cb_btn_Manual.TabIndex = 5;
            this.cb_btn_Manual.Text = "手动操作按钮";
            this.cb_btn_Manual.UseVisualStyleBackColor = true;
            // 
            // frmSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 317);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.tp_System);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统设置";
            this.tp_System.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tp_System;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox cb_AutoRun;
        private System.Windows.Forms.Button btn_SetPassword;
        private System.Windows.Forms.TextBox txt_PWD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cb_Connection_Pool;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox cb_btn_Manual;
        private System.Windows.Forms.CheckBox cb_btn_BUS;
        private System.Windows.Forms.CheckBox cb_btn_Board;
        private System.Windows.Forms.CheckBox cb_btn_Window;
        private System.Windows.Forms.CheckBox cb_btn_Item;
    }
}