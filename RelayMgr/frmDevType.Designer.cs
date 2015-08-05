namespace RelayMgr
{
    partial class frmDevType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevType));
            this.gbTT = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTTName = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ImgGroup = new System.Windows.Forms.TextBox();
            this.gbTT.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTT
            // 
            this.gbTT.Controls.Add(this.txt_ImgGroup);
            this.gbTT.Controls.Add(this.label1);
            this.gbTT.Controls.Add(this.txtName);
            this.gbTT.Controls.Add(this.lblTTName);
            this.gbTT.Location = new System.Drawing.Point(12, 12);
            this.gbTT.Name = "gbTT";
            this.gbTT.Size = new System.Drawing.Size(357, 89);
            this.gbTT.TabIndex = 18;
            this.gbTT.TabStop = false;
            this.gbTT.Text = "组信息";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(256, 21);
            this.txtName.TabIndex = 0;
            // 
            // lblTTName
            // 
            this.lblTTName.AutoSize = true;
            this.lblTTName.Location = new System.Drawing.Point(20, 24);
            this.lblTTName.Name = "lblTTName";
            this.lblTTName.Size = new System.Drawing.Size(47, 12);
            this.lblTTName.TabIndex = 4;
            this.lblTTName.Text = "组名称:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(213, 116);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(294, 116);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "图标组：";
            // 
            // txt_ImgGroup
            // 
            this.txt_ImgGroup.Location = new System.Drawing.Point(85, 52);
            this.txt_ImgGroup.Name = "txt_ImgGroup";
            this.txt_ImgGroup.Size = new System.Drawing.Size(100, 21);
            this.txt_ImgGroup.TabIndex = 6;
            this.txt_ImgGroup.Text = "0";
            // 
            // frmDevType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 152);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbTT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDevType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设备组";
            this.gbTT.ResumeLayout(false);
            this.gbTT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTT;
        private System.Windows.Forms.Label lblTTName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_ImgGroup;
    }
}