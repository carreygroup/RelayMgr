using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RelayMgr
{
   public  class DBiCoreVal
    {
       public DBiCoreVal()
        {

        }
        public void Dispose()
        {

        }
       /// <summary>
        ///DB   查询所有设备类型的方法
       /// </summary>
       /// <returns></returns>
       public static DataTable DBQueryValByItem(string DevID)
       {
           string sql;
           //sql = "select * where DevID={0}";

           sql = "select * from iCore where DevID='{0}'";
           string sError = string.Empty;
           return SQLiteHelper.GetDataTable(out sError,string.Format(sql, DevID));

       }
       /// <summary>
       /// 插入设备类型的方法
       /// </summary>
       /// <param name="tt"></param>
       public static void DBiCoreInsert(string DevID, string Command, string Value)
       {
           string sql = "REPLACE into iCore (DevID,Command,Value) values('{0}','{1}','{2}')";
           string sError = string.Empty;
           SQLiteHelper.UpdateData(out sError, string.Format(sql, DevID, Command, Value), true);
       }

       /// <summary>
       /// 修改设备类型的方法
       /// </summary>
       /// <param name="tt"></param>
       //public static void DBTasksUPdate(string TaskType, string Time, string Action, string id)
       //{
       //    string sql = "update iCore set TaskType='{0}',Time='{1}',Action='{2}' where ID='{3}'";
       //    string sError = string.Empty;
       //    SQLiteHelper.UpdateData(out sError, string.Format(sql,TaskType, Time, Action, id), true);
       //}

       /// <summary>
       /// 删除设备类型的方法
       /// </summary>
       /// <param name="ttId"></param>
       public static void DBiCoreValDelete(string id)
       {
           string sql = "delete from iCore where ID='{0}'";
           string sError = string.Empty;
           SQLiteHelper.UpdateData(out sError, string.Format(sql, id), true);

       }

       /// <summary>
       /// 删除设备下的Tasks的方法
       /// </summary>
       /// <param name="ttId"></param>
       public static void DBiCoreValDeleteByDevID(string DevID)
       {
           string sql = "delete from iCore where DevID='{0}'";
           string sError = string.Empty;
           SQLiteHelper.UpdateData(out sError, string.Format(sql, DevID), true);

       }
    }
}
