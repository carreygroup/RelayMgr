using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RelayMgr
{
    public partial class frmiCore : frmBase
    {
        private string devid;

        public frmiCore()
        {
            InitializeComponent();
            if (Localization.HasLang)
            {
                if (Localization.Lang == "English")
                {


                }

            }
        }
        public void LoadItemAction(string DevID)
        {
            devid = DevID;
            lv_Actions.Items.Clear();
            DataTable dt = new DataTable();
            dt = DBiCoreVal.DBQueryValByItem(DevID);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = row["Value"].ToString();
                lvi.SubItems.Add(row["Command"].ToString());
                lvi.Tag = row["ID"].ToString();
                lv_Actions.Items.Add(lvi);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            this.DialogResult=DialogResult.OK;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frmAction fa = new frmAction();
            try
            {
                //fa.SetAction(btn_ONAction.Tag.ToString());
            }
            catch { }

            if (fa.ShowDialog() == DialogResult.OK)
            {
                //btn_ONAction.Tag = fa.GetAction();
                DBiCoreVal.DBiCoreInsert(devid, fa.GetAction(), fa.txt_Value.Text);
                LoadItemAction(devid);
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                DBiCoreVal.DBiCoreValDelete(lv_Actions.SelectedItems[0].Tag.ToString());
                LoadItemAction(devid);
            }
            catch { }
        }

    }
}
