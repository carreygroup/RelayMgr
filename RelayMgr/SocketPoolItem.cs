using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO.Ports;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net;

namespace RelayMgr
{
    class SocketPoolItem
    {
        public Socket mySocket;
        public Thread myThread;
    }
}
