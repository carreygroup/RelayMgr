using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RelayMgr
{
   public  class DBDevType
    {
        public DBDevType()
        {

        }
        public void Dispose()
        {

        }
       /// <summary>
        ///DB   查询所有设备类型的方法
       /// </summary>
       /// <returns></returns>
       public static DataTable DBDevTypeQuery()
       {
           string sql;
           sql = "select * from DevType";
           string sError = string.Empty;
           return SQLiteHelper.GetDataTable(out sError, sql);

       }

       /// <summary>
       /// 插入设备类型的方法
       /// </summary>
       /// <param name="tt"></param>
       public static void DBDevTypInsert(string Name,string imggroup)
       {
           string sql = "REPLACE into DevType (name,imgGroup) values('{0}','{1}')";
           string sError = string.Empty;
           SQLiteHelper.UpdateData(out sError, string.Format(sql,Name,imggroup), true);
       }

       /// <summary>
       /// 修改设备类型的方法
       /// </summary>
       /// <param name="tt"></param>
       public static void DBDevTypeUPdate(string name, string id,string imggroup)
       {
           string sql = "update DevType set Name='{0}',imgGroup='{1}' where ID='{2}'";
           string sError = string.Empty;
           SQLiteHelper.UpdateData(out sError, string.Format(sql,name,imggroup,id), true);
       }

       /// <summary>
       /// 删除设备类型的方法
       /// </summary>
       /// <param name="ttId"></param>
       public static void DBDevTypeDelete(int rtId)
       {
           DBDevices.DBDevDeleteByDevType(rtId.ToString());

           string sql = "delete from DevType where ID='{0}'";
           string sError = string.Empty;
           SQLiteHelper.UpdateData(out sError, string.Format(sql, rtId), true);

       }
    }
}
