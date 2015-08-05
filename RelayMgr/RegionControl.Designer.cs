namespace RelayMgr
{
    partial class RegionControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Line = new System.Windows.Forms.Label();
            this.btn_PowerFlash = new System.Windows.Forms.Button();
            this.btn_Flash = new System.Windows.Forms.Button();
            this.btn_PowerSwitch = new System.Windows.Forms.Button();
            this.btn_Run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 37);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "线路：";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(70, 43);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(41, 12);
            this.lbl_Address.TabIndex = 5;
            this.lbl_Address.Text = "label3";
            // 
            // lbl_Line
            // 
            this.lbl_Line.AutoSize = true;
            this.lbl_Line.Location = new System.Drawing.Point(231, 43);
            this.lbl_Line.Name = "lbl_Line";
            this.lbl_Line.Size = new System.Drawing.Size(0, 12);
            this.lbl_Line.TabIndex = 6;
            // 
            // btn_PowerFlash
            // 
            this.btn_PowerFlash.Location = new System.Drawing.Point(105, 68);
            this.btn_PowerFlash.Name = "btn_PowerFlash";
            this.btn_PowerFlash.Size = new System.Drawing.Size(75, 37);
            this.btn_PowerFlash.TabIndex = 8;
            this.btn_PowerFlash.Text = "点动 ON->OFF";
            this.btn_PowerFlash.UseVisualStyleBackColor = true;
            // 
            // btn_Flash
            // 
            this.btn_Flash.Location = new System.Drawing.Point(186, 68);
            this.btn_Flash.Name = "btn_Flash";
            this.btn_Flash.Size = new System.Drawing.Size(75, 37);
            this.btn_Flash.TabIndex = 9;
            this.btn_Flash.Text = "点动 OFF->ON";
            this.btn_Flash.UseVisualStyleBackColor = true;
            // 
            // btn_PowerSwitch
            // 
            this.btn_PowerSwitch.Location = new System.Drawing.Point(274, 68);
            this.btn_PowerSwitch.Name = "btn_PowerSwitch";
            this.btn_PowerSwitch.Size = new System.Drawing.Size(75, 37);
            this.btn_PowerSwitch.TabIndex = 10;
            this.btn_PowerSwitch.Text = "--";
            this.btn_PowerSwitch.UseVisualStyleBackColor = true;
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(15, 68);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(75, 37);
            this.btn_Run.TabIndex = 11;
            this.btn_Run.Text = "执行";
            this.btn_Run.UseVisualStyleBackColor = true;
            // 
            // RegionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.btn_PowerSwitch);
            this.Controls.Add(this.btn_Flash);
            this.Controls.Add(this.btn_PowerFlash);
            this.Controls.Add(this.lbl_Line);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "RegionControl";
            this.Padding = new System.Windows.Forms.Padding(3, 3, 4, 4);
            this.Size = new System.Drawing.Size(356, 112);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbl_Address;
        public System.Windows.Forms.Label lbl_Line;
        public System.Windows.Forms.Button btn_PowerFlash;
        public System.Windows.Forms.Button btn_Flash;
        public System.Windows.Forms.Button btn_PowerSwitch;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_Run;
    }
}
