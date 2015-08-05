using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace RelayMgr
{
    class DBPool
    {

        /// <summary>
        /// 插入串口名到串口池
        /// </summary>
        /// <param name="COMName"></param>
        public static void DBCOMPoolInsert(string COMName,string GroupID)
        {
            string sql = "REPLACE into SerialPool (SerialPort,GroupID) values('{0}','{1}')";
            string sError = string.Empty;
            try
            {
                SQLiteHelper.UpdateData(out sError, string.Format(sql, COMName,GroupID), true);
            }
            catch
            { }
        }
/// <summary>
/// 删除串口池中指定的串口
/// </summary>
/// <param name="COMName"></param>
        public static void DBCOMPoolRemove(string COMName)
        {
            string sql = "delete from SerialPool where SerialPort='{0}'";
            string sError = string.Empty;
            SQLiteHelper.UpdateData(out sError, string.Format(sql, COMName), true);
        }
/// <summary>
/// 查询串口池中的所有串口名
/// </summary>
/// <returns></returns>
        public static DataTable DBSerialAll()
        {
            string sql = "select * from SerialPool";
            string sError = string.Empty;
            return SQLiteHelper.GetDataTable(out sError, sql);
        }
        /// <summary>
        /// 查询串口池中的指定组下的串口
        /// </summary>
        /// <returns></returns>
        public static DataTable DBSerialByGroup(string GroupID)
        {
            string sql = "select * from SerialPool where GroupID='{0}'";
            string sError = string.Empty;
            DataTable dt = new DataTable();
            return SQLiteHelper.GetDataTable(out sError, string.Format(sql, GroupID));
        }

        /// <summary>
        /// 查询串口池中的串口重名
        /// </summary>
        /// <returns></returns>
        public static bool DBSerialExists(string SerialName)
        {
            string sql = "select * from SerialPool where SerialPort='{0}'";
            string sError = string.Empty;
            DataTable dt = new DataTable();
            dt=SQLiteHelper.GetDataTable(out sError, string.Format(sql, SerialName));
            return dt.Rows.Count > 0;
        }

        /// <summary>
        /// 检查TCP端口重名
        /// </summary>
        /// <param name="COMName"></param>
        public static bool DBTCPExists(string HostEntry)
        {
            string sql = "select * from TCPPool where HostEntry='{0}'";
            string sError = string.Empty;
            DataTable dt = new DataTable();
            dt = SQLiteHelper.GetDataTable(out sError, string.Format(sql, HostEntry));
            return dt.Rows.Count > 0;
        }

        /// <summary>
        /// 插入串口名到串口池
        /// </summary>
        /// <param name="COMName"></param>
        public static void DBTCPPoolInsert(string HostEntry,string GroupID)
        {
            string sql = "REPLACE into TCPPool (HostEntry,GroupID) values('{0}','{1}')";
            string sError = string.Empty;
            try
            {
                SQLiteHelper.UpdateData(out sError, string.Format(sql, HostEntry,GroupID), true);
            }
            catch
            { }
        }
        /// <summary>
        /// 删除串口池中指定的串口
        /// </summary>
        /// <param name="COMName"></param>
        public static void DBTCPPoolRemove(string HostEntry)
        {
            string sql = "delete from TCPPool where HostEntry='{0}'";
            string sError = string.Empty;
            SQLiteHelper.UpdateData(out sError, string.Format(sql, HostEntry), true);
        }
        /// <summary>
        /// 查询串口池中的所有串口名
        /// </summary>
        /// <returns></returns>
        public static DataTable DBTCPAll()
        {
            string sql = "select * from TCPPool";
            string sError = string.Empty;
            return SQLiteHelper.GetDataTable(out sError, sql);
        }

        /// <summary>
        /// 查询TCP池中的指定的端口
        /// </summary>
        /// <returns></returns>
        public static DataTable DBTCPByGroup(string GroupID)
        {
            string sql = "select * from TCPPool where GroupID='{0}'";
            string sError = string.Empty;
            return SQLiteHelper.GetDataTable(out sError, string.Format(sql, GroupID));
        }
    }
}
