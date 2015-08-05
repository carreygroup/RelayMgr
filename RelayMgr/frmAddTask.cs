using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RelayMgr
{
    public partial class frmAddTask : frmBase
    {
        public frmAddTask()
        {
            InitializeComponent();
        }

        private void frmAddTask_Load(object sender, EventArgs e)
        {

        }
        public void Default()
        {
            dt_Date.Value = DateTime.Now;
            mtxt_Time.Text = "00:00:00";
            cb_Action.SelectedIndex = 0;
            cb_TaskType.SelectedIndex = 0;
        }

        private void cb_TaskType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_TaskType.SelectedIndex)
            {
                case 0:
                    dt_Date.Enabled = false;
                    break;
                case 1:
                    dt_Date.Enabled = true;
                    break;
                default:
                    return;
            }
        }
    }
}
