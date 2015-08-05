using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RelayMgr
{
    public class Splash : Form
    {
        private PictureBox pictureBox2;
        private IContainer components = null;

        public Splash()
        {
            this.InitializeComponent();

            string WelcomeImg = string.Empty;
            string iniFile = string.Empty;
            iniFile = System.Environment.CurrentDirectory + "\\config.ini";
            if (System.IO.File.Exists(iniFile))
            {
                WelcomeImg = INIFile.ReadValue(iniFile, "SYSTEM", "Welcome");

            }
            if (!WelcomeImg.Equals(string.Empty))
            {
                pictureBox2.Load(WelcomeImg);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::RelayMgr.Properties.Resources._095Z13A0_0;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(401, 266);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Splash
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(401, 266);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

