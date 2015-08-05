using System;
using System.Collections.Generic;
using System.Text;
using System.Data ;
//using Community.CsharpSqlite;
//using Community.CsharpSqlite.SQLiteClient;
using System.Data.SQLite;

namespace RelayMgr
{
    public class DBCommands
    {
        public DBCommands()
       {

       }
       public void Dispose()
       {

       }
        /// <summary>
       /// DA  根据父ID，查找所有命令
       /// </summary>
       /// <param name="PID">父ID</param>
       /// <returns></returns>
       public static DataTable DBQueryCMDByPID(string PID)
       {
           string sql = "select * from Commands where PID='{0}'";
           string sError = string.Empty;
           return SQLiteHelper.GetDataTable(out sError, string.Format(sql, PID));
       }

        /// <summary>
        /// 插入命令
        /// </summary>
        /// <param name="t"></param>
        public static void DBCMDInsert(string PID, string Command)
        {
            string sql = "REPLACE into Commands (PID,Command) values('{0}','{1}')";
            string sError = string.Empty;
            try
            {
                SQLiteHelper.UpdateData(out sError, string.Format(sql, PID, Command), true);
            }
            catch
            { }
        }
        /// <summary>
        /// 删除指定PID下的所有命令
        /// </summary>
        /// <param name="tId"></param>
        public static void DBCMDDeleteByPID(string PID)
        {
            string sql = "delete from Commands where PID='{0}'";
            string sError = string.Empty;
            SQLiteHelper.UpdateData(out sError, string.Format(sql, PID), true);
        }

        /// <summary>
        /// 删除一条命令
        /// </summary>
        /// <param name="tId"></param>
        public static void DBCMDDelete(string ID)
        {
            string sql = "delete from Commands where ID='{0}'";
            string sError = string.Empty;
            SQLiteHelper.UpdateData(out sError, string.Format(sql, ID), true);  
        }
    }
}
