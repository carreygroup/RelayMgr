using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Collections.Generic;

namespace RelayMgr
{
	/// <summary>
	/// Summary description for WorkerClass.
	/// </summary>
	public class WorkerClass
	{
		/// <summary>
		/// Usually a form or a winform control that implements "Invoke/BeginInvode"
		/// </summary>
		ContainerControl m_sender = null;

		/// <summary>
		/// Messages sent in - this is implementation specific
		/// </summary>
		List<Socket> m_tmpSocket=null;

		/// <summary>
		/// The delegate method (callback) on the sender to call
		/// </summary>
		Delegate m_senderDelegate = null;

		/// <summary>
		/// Constructor used by caller using ThreadPool
		/// </summary>
		public WorkerClass()
		{
		}
		/// <summary>
		/// Constructor called by calle using ThreadPool OR ThreadStart
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="totalMessages"></param>
		/// <param name="sp"></param>
        public WorkerClass(ContainerControl sender, Delegate senderDelegate, List<Socket> tmpSocket)
		{
			m_sender = sender;
			m_senderDelegate = senderDelegate;
			m_tmpSocket = tmpSocket;
		}

		/// <summary>
		/// Another constructor using the params array pattern. Used by ThreadPool or ThreadStart
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="senderDelegate"></param>
		/// <param name="list"></param>
		public WorkerClass ( ContainerControl sender, Delegate senderDelegate, params object[] list)
		{
			m_sender = sender;
			m_senderDelegate = senderDelegate;
            m_tmpSocket = (List<Socket>)list.GetValue(0);
		}

		/// <summary>
		/// Method for ThreadPool QueueWorkerItem
		/// </summary>
		/// <param name="obj"></param>
		public void RunProcess ( object obj )
		{
			Thread.CurrentThread.IsBackground = true; //make them a daemon
			object[] objArray = (object[]) obj;
			m_sender = (System.Windows.Forms.Form) objArray[0];
			m_senderDelegate = (System.Delegate) objArray[1];
            m_tmpSocket = (List<Socket>)objArray[2];

			LocalRunProcess();
		}

		/// <summary>
		/// Method for ThreadStart delegate
		/// </summary>
		public void RunProcess()
		{
			Thread.CurrentThread.IsBackground = true; //make them a daemon
			LocalRunProcess();
		}

		/// <summary>
		/// Local Method for the actual work.
		/// </summary>
		private void LocalRunProcess()
		{
            while (true)
            {
                try
                {
                    byte[] arrRecMsg = new byte[8];
                    foreach (Socket sc in m_tmpSocket)
                    {
                        Thread.Sleep(50);

                        int length = sc.Receive(arrRecMsg);
                        if (length == 8)
                        {
                            //SetDevState(arrRecMsg);
                            //this.Invoke(interfaceUpdataHandle, arrRecMsg);
                            //m_sender.BeginInvoke(m_senderDelegate, new object[] { arrRecMsg });
                        }

                        m_sender.BeginInvoke(m_senderDelegate, new object[] { arrRecMsg });
                    }
                    m_sender.BeginInvoke(m_senderDelegate, new object[] { arrRecMsg });
                }
                catch { }
            }
		}

	}

}

