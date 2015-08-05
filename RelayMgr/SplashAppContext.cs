using System;
using System.Windows.Forms;
namespace RelayMgr
{
    public class SplashAppContext : ApplicationContext
    {
        private Form mainForm;
        private Timer splashTimer;

        public SplashAppContext(Form mainForm, Form splashForm) : base(splashForm)
        {
            this.mainForm = null;
            this.splashTimer = new Timer();
            this.mainForm = mainForm;
            this.splashTimer.Tick += new EventHandler(this.SplashTimeUp);
            this.splashTimer.Interval = 2000;
            this.splashTimer.Enabled = true;
        }

        protected override void OnMainFormClosed(object sender, EventArgs e)
        {
            if (sender is Splash)
            {
                base.MainForm = this.mainForm;
                base.MainForm.Show();
            }
            else if (sender is RelayMgr)
            {
                base.OnMainFormClosed(sender, e);
            }
        }

        private void SplashTimeUp(object sender, EventArgs e)
        {
            this.splashTimer.Enabled = false;
            this.splashTimer.Dispose();
            base.MainForm.Close();
        }

        public int SecondsSplashShown
        {
            set
            {
                this.splashTimer.Interval = value * 1000;
            }
        }
    }
}

