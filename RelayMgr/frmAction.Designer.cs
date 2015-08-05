namespace RelayMgr
{
    partial class frmAction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAction));
            this.rb_PlaySound = new System.Windows.Forms.RadioButton();
            this.rb_RunProgram = new System.Windows.Forms.RadioButton();
            this.gb_PlaySound = new System.Windows.Forms.GroupBox();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Sound = new System.Windows.Forms.Button();
            this.txt_Sound = new System.Windows.Forms.TextBox();
            this.gb_Program = new System.Windows.Forms.GroupBox();
            this.txt_Program = new System.Windows.Forms.TextBox();
            this.btn_Program = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.ofd_OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.txt_Value = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gb_PlaySound.SuspendLayout();
            this.gb_Program.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_PlaySound
            // 
            this.rb_PlaySound.AutoSize = true;
            this.rb_PlaySound.Location = new System.Drawing.Point(14, 45);
            this.rb_PlaySound.Name = "rb_PlaySound";
            this.rb_PlaySound.Size = new System.Drawing.Size(71, 16);
            this.rb_PlaySound.TabIndex = 3;
            this.rb_PlaySound.TabStop = true;
            this.rb_PlaySound.Text = "播放声音";
            this.rb_PlaySound.UseVisualStyleBackColor = true;
            this.rb_PlaySound.CheckedChanged += new System.EventHandler(this.ItemCheckedChange);
            // 
            // rb_RunProgram
            // 
            this.rb_RunProgram.AutoSize = true;
            this.rb_RunProgram.Location = new System.Drawing.Point(14, 124);
            this.rb_RunProgram.Name = "rb_RunProgram";
            this.rb_RunProgram.Size = new System.Drawing.Size(95, 16);
            this.rb_RunProgram.TabIndex = 4;
            this.rb_RunProgram.TabStop = true;
            this.rb_RunProgram.Text = "执行外部程序";
            this.rb_RunProgram.UseVisualStyleBackColor = true;
            this.rb_RunProgram.CheckedChanged += new System.EventHandler(this.ItemCheckedChange);
            // 
            // gb_PlaySound
            // 
            this.gb_PlaySound.Controls.Add(this.btn_Play);
            this.gb_PlaySound.Controls.Add(this.btn_Sound);
            this.gb_PlaySound.Controls.Add(this.txt_Sound);
            this.gb_PlaySound.Enabled = false;
            this.gb_PlaySound.Location = new System.Drawing.Point(33, 69);
            this.gb_PlaySound.Name = "gb_PlaySound";
            this.gb_PlaySound.Size = new System.Drawing.Size(509, 49);
            this.gb_PlaySound.TabIndex = 6;
            this.gb_PlaySound.TabStop = false;
            this.gb_PlaySound.Text = "声音文件";
            // 
            // btn_Play
            // 
            this.btn_Play.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Play.Location = new System.Drawing.Point(450, 20);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(42, 23);
            this.btn_Play.TabIndex = 2;
            this.btn_Play.Text = "播放";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Sound
            // 
            this.btn_Sound.Location = new System.Drawing.Point(402, 20);
            this.btn_Sound.Name = "btn_Sound";
            this.btn_Sound.Size = new System.Drawing.Size(42, 23);
            this.btn_Sound.TabIndex = 1;
            this.btn_Sound.Text = "...";
            this.btn_Sound.UseVisualStyleBackColor = true;
            this.btn_Sound.Click += new System.EventHandler(this.btn_Sound_Click);
            // 
            // txt_Sound
            // 
            this.txt_Sound.Location = new System.Drawing.Point(12, 22);
            this.txt_Sound.Name = "txt_Sound";
            this.txt_Sound.Size = new System.Drawing.Size(384, 21);
            this.txt_Sound.TabIndex = 0;
            // 
            // gb_Program
            // 
            this.gb_Program.Controls.Add(this.txt_Program);
            this.gb_Program.Controls.Add(this.btn_Program);
            this.gb_Program.Enabled = false;
            this.gb_Program.Location = new System.Drawing.Point(33, 147);
            this.gb_Program.Name = "gb_Program";
            this.gb_Program.Size = new System.Drawing.Size(509, 50);
            this.gb_Program.TabIndex = 7;
            this.gb_Program.TabStop = false;
            this.gb_Program.Text = "程序";
            // 
            // txt_Program
            // 
            this.txt_Program.Location = new System.Drawing.Point(12, 20);
            this.txt_Program.Name = "txt_Program";
            this.txt_Program.Size = new System.Drawing.Size(432, 21);
            this.txt_Program.TabIndex = 1;
            // 
            // btn_Program
            // 
            this.btn_Program.Location = new System.Drawing.Point(450, 18);
            this.btn_Program.Name = "btn_Program";
            this.btn_Program.Size = new System.Drawing.Size(42, 23);
            this.btn_Program.TabIndex = 0;
            this.btn_Program.Text = "...";
            this.btn_Program.UseVisualStyleBackColor = true;
            this.btn_Program.Click += new System.EventHandler(this.btn_Program_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(450, 222);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(369, 222);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 9;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // ofd_OpenFile
            // 
            this.ofd_OpenFile.Filter = "所有文件|*.*";
            // 
            // txt_Value
            // 
            this.txt_Value.Location = new System.Drawing.Point(43, 11);
            this.txt_Value.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Value.Name = "txt_Value";
            this.txt_Value.Size = new System.Drawing.Size(164, 21);
            this.txt_Value.TabIndex = 12;
            this.txt_Value.Text = "0";
            this.txt_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "值:";
            // 
            // frmAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 262);
            this.Controls.Add(this.txt_Value);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gb_PlaySound);
            this.Controls.Add(this.rb_PlaySound);
            this.Controls.Add(this.rb_RunProgram);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.gb_Program);
            this.Controls.Add(this.btn_Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "执行...";
            this.Load += new System.EventHandler(this.frmAction_Load);
            this.gb_PlaySound.ResumeLayout(false);
            this.gb_PlaySound.PerformLayout();
            this.gb_Program.ResumeLayout(false);
            this.gb_Program.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_PlaySound;
        private System.Windows.Forms.RadioButton rb_RunProgram;
        private System.Windows.Forms.GroupBox gb_PlaySound;
        private System.Windows.Forms.GroupBox gb_Program;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Sound;
        private System.Windows.Forms.TextBox txt_Sound;
        private System.Windows.Forms.TextBox txt_Program;
        private System.Windows.Forms.Button btn_Program;
        private System.Windows.Forms.OpenFileDialog ofd_OpenFile;
        private System.Windows.Forms.Button btn_Play;
        public System.Windows.Forms.TextBox txt_Value;
        private System.Windows.Forms.Label label7;
    }
}