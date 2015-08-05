using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RelayMgr
{
    public partial class frmPWD : frmBase
    {
        private string UID = string.Empty;

        public frmPWD(string user)
        {
            InitializeComponent();
            UID = user;
        }

        private void frmPWD_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.8;
        }

        private void btn_UnLock_Click(object sender, EventArgs e)
        {
            if (DBUsers.DBQueryUsers(UID, txtPWD.Text))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("解锁码错误");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
