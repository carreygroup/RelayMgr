using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RelayMgr
{
    public partial class frmPool : frmBase
    {
        public frmPool()
        {
            InitializeComponent();
            EnumCOMPort();
            //LoadSerialItems();
            //LoadTCPItems();
            LoadGroup();
        }

        private void LoadGroup()
        {
            lv_Group.Items.Clear();
            DataTable dt = DBDevType.DBDevTypeQuery();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem node = new ListViewItem();
                node.Text = row["Name"].ToString();
                node.Tag = row["ID"].ToString();
                node.ImageIndex = 0;
                lv_Group.Items.Add(node);
            }

        }
        /// <summary>
        /// 枚举串口
        /// </summary>
        private void EnumCOMPort()
        {
            cb_SerialPort.Items.Clear();
            cb_SerialPort.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if (cb_SerialPort.Items.Count > 0)
            {
                cb_SerialPort.SelectedIndex = 0;
            }
        }

        private void LoadSerialItems()
        {
            DataTable dt = new DataTable();
            dt = DBPool.DBSerialByGroup(GetGroupID());
            lv_SerialPort.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = dr["SerialPort"].ToString();
                lvi.ImageIndex = 0;
                lv_SerialPort.Items.Add(lvi);

            }

        }

        private void LoadTCPItems()
        {
            DataTable dt = new DataTable();
            dt = DBPool.DBTCPByGroup(GetGroupID());
            lv_NetWork.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = dr["HostEntry"].ToString();
                lvi.ImageIndex = 1;
                lv_NetWork.Items.Add(lvi);

            }
        }

        private string GetGroupID()
        {

            return lv_Group.SelectedItems[0].Tag.ToString();

        }
        private void btn_COM_Add_Click(object sender, EventArgs e)
        {
            if (lv_Group.SelectedItems.Count != 1)
            {
                MessageBox.Show("请选择一个分组!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.lv_Group.Focus();
                return;
            }

            if ((!cb_SerialPort.Text.Equals(string.Empty)) && (!DBPool.DBSerialExists(cb_SerialPort.Text)))
            {
                DBPool.DBCOMPoolInsert(cb_SerialPort.Text, GetGroupID());
                LoadSerialItems();
            }
            else
            {
                MessageBox.Show("添加失败", "错误");
            }
        }

        private void btn_COM_Remove_Click(object sender, EventArgs e)
        {
            if (lv_SerialPort.SelectedItems.Count > 0)
            {
                DBPool.DBCOMPoolRemove(lv_SerialPort.SelectedItems[0].Text);
                LoadSerialItems();
            }
        }

        private void btn_NetWork_Add_Click(object sender, EventArgs e)
        {
            if (lv_Group.SelectedItems.Count != 1)
            {
                MessageBox.Show("请选择一个分组!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.lv_Group.Focus();
                return;
            }

            if (txt_Host.Text.Equals(string.Empty))
            {
                MessageBox.Show("主机信息为空", "错误");
                return;
            }

            if(!isHostEntry(txt_Host.Text))
            {
                MessageBox.Show("主机地址无效 格式示例：192.168.1.1:5000", "错误");
                return;

            }
            if(DBPool.DBTCPExists(txt_Host.Text))
            {
                MessageBox.Show("主机信息已存在", "错误");
                return;
            }
            try
            {
                DBPool.DBTCPPoolInsert(txt_Host.Text, GetGroupID());
                LoadTCPItems();
            }
            catch
            {
                MessageBox.Show("添加失败", "错误");
            }
        }
        //判断IP信息是否有效
        private bool isHostEntry(string HostEntry)
        {
            string[] tmpHostEntry = HostEntry.Split(':');
            try
            {
                int tmpPort=Convert.ToInt32(tmpHostEntry[1]);
                if ((tmpPort > 0) && (tmpPort < 65536))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
            return false;

        }
        private void btn_NetWork_Remove_Click(object sender, EventArgs e)
        {
            if (lv_NetWork.SelectedItems.Count > 0)
            {
                DBPool.DBTCPPoolRemove(lv_NetWork.SelectedItems[0].Text);
                LoadTCPItems();
            }
        }

        private void cb_SerialPort_DropDown(object sender, EventArgs e)
        {
            EnumCOMPort();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lv_Group_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Group.SelectedItems.Count > 0)
            {
                LoadSerialItems();
                LoadTCPItems();
            }
        }

    }
}
