using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RelayMgr
{
   public  class DBTasks
    {
       public DBTasks()
        {

        }
        public void Dispose()
        {

        }
       /// <summary>
        ///DB   查询所有设备类型的方法
       /// </summary>
       /// <returns></returns>
       public static DataTable DBTasksAll()
       {
           string sql;
           sql = "select task.ID,task.Time,task.Action,task.TaskType,Dev.Name,Dev.Address,Dev.Line from Tasks task inner join devices dev on task.DevID=dev.ID";
           string sError = string.Empty;
           return SQLiteHelper.GetDataTable(out sError, sql);

       }
       /// <summary>
        ///DB   查询所有设备类型的方法
       /// </summary>
       /// <returns></returns>
       public static DataTable DBQueryTasksByItem(string DevID)
       {
           string sql;
           sql = "select task.ID,task.Time,task.Action,task.TaskType,Dev.Name,Dev.Address,Dev.Line from Tasks task inner join devices dev on task.DevID=dev.ID where DevID={0}";

           //sql = "select * from Tasks where DevID='{0}'";
           string sError = string.Empty;
           return SQLiteHelper.GetDataTable(out sError,string.Format(sql, DevID));

       }
       /// <summary>
       /// 插入设备类型的方法
       /// </summary>
       /// <param name="tt"></param>
       public static void DBTasksInsert(string DevID,string TaskType,string Time,string Action)
       {
           string sql = "REPLACE into Tasks (DevID,TaskType,Time,Action) values('{0}','{1}','{2}','{3}')";
           string sError = string.Empty;
           SQLiteHelper.UpdateData(out sError, string.Format(sql, DevID, TaskType, Time, Action), true);
       }

       /// <summary>
       /// 修改设备类型的方法
       /// </summary>
       /// <param name="tt"></param>
       public static void DBTasksUPdate(string TaskType, string Time, string Action, string id)
       {
           string sql = "update Tasks set TaskType='{0}',Time='{1}',Action='{2}' where ID='{3}'";
           string sError = string.Empty;
           SQLiteHelper.UpdateData(out sError, string.Format(sql,TaskType, Time, Action, id), true);
       }

       /// <summary>
       /// 删除设备类型的方法
       /// </summary>
       /// <param name="ttId"></param>
       public static void DBTasksDelete(string id)
       {
           string sql = "delete from Tasks where ID='{0}'";
           string sError = string.Empty;
           SQLiteHelper.UpdateData(out sError, string.Format(sql, id), true);

       }

       /// <summary>
       /// 删除设备下的Tasks的方法
       /// </summary>
       /// <param name="ttId"></param>
       public static void DBTasksDeleteByDevID(string DevID)
       {
           string sql = "delete from Tasks where DevID='{0}'";
           string sError = string.Empty;
           SQLiteHelper.UpdateData(out sError, string.Format(sql, DevID), true);

       }
    }
}
