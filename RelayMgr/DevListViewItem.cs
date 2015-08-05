using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace RelayMgr
{
    public class DevListViewItem : ListViewItem
    {
        /// <summary>
        /// 设备地址
        /// </summary>
        public short uAddress;
        /// <summary>
        /// 设备线路
        /// </summary>
        public int uLine;
        /// <summary>
        /// 标题
        /// </summary>
        public string Title;
        /// <summary>
        /// 执行组动作时，默认动作
        /// 仅能执行ON、OFF
        /// </summary>
        public int DefAction;
        /// <summary>
        /// 设备输入输出类型；0为输出、1为输入
        /// </summary>
        public int DevIO;
        /////最后接受到的命令的时间
        public bool bOnRun;
        public bool bOffRun;

        public string OnRunAction;
        public string OffRunAction;

        public string Item_Action;
        /// <summary>
        /// 点动间隔
        /// </summary>
        public int uPowerFlash;
        public byte[] msg = new byte[8];
        //是否正在闪烁
        public bool bFlash = false;

        public Decimal ThresholdH = 0;//阀值高
        public Decimal ThresholdL = 0;//阀值低
        public long LastTime;
        public int ImgGroup = 0;//图标组
        ///第一次运行
        public bool firstRun = true;

        public List<iCore_Value> ActionList = new List<iCore_Value>();
    }
}
