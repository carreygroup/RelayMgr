using System;
using System.Collections.Generic;
using System.Text;

namespace RelayMgr
{
    public class iCore_Value
    {
        private int devid;
        private int start_hour;
        private int end_hour;
        private int start_minute;
        private int end_minute;
        private decimal val;
        private string cmd;

        public iCore_Value()
        {
        }

        public int DevID
        {
            get { return devid; }
            set { devid = value; }
        }
        public decimal Value
        {
            get { return val; }
            set { val = value; }
        }
        public string CMD
        {
            get { return cmd; }
            set { cmd = value; }
        }
    }
}
