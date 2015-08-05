using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RelayMgr
{
    public partial class frmDev : frmBase
    {
        private int devid;

        public int DevID
        {
            get { return devid; }
            set 
            { devid = value; }
        }

        public frmDev()
        {
            InitializeComponent();
            if (Localization.HasLang)
            {
                if (Localization.Lang == "English")
                {
                    cb_DefAction.Items.Clear();
                    cb_DefAction.Items.Add("Power OFF");
                    cb_DefAction.Items.Add("Power ON");
                }

            }
            cb_DefAction.SelectedIndex = 0;
            cb_IO.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lv_Group.SelectedItems.Count!=1)
            {
                MessageBox.Show("请选择一个分组!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.lv_Group.Focus();
                return;
            }
            else
            if (this.txtName.Text.Equals(""))
            {
                MessageBox.Show("请输入设备名称!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtName.Focus();
                return;
            }
            else if (this.txtAddress.Text.Equals(""))
            {
                MessageBox.Show("请输入设备地址!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtAddress.Focus();
                return;
            }
            else if (this.txtLine.Text.Equals(""))
            {
                MessageBox.Show("请输入设备线路!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtLine.Focus();
                return;
            }
            //try
            //{
            //    if (ckb_ThresholdH.Checked)
            //    {
            //        Convert.ToDecimal(txt_ThresholdH.Text);
            //    }
            //    if (ckb_ThresholdL.Checked)
            //    {
            //        Convert.ToDecimal(txt_ThresholdL.Text);
            //    }
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.Message);
            //    return;
            //}
            this.DialogResult=DialogResult.OK;
        }

    }
}
