using System;
using System.Collections.Generic;
using System.Text;
using System.Data ;
//using Community.CsharpSqlite;
//using Community.CsharpSqlite.SQLiteClient;
using System.Data.SQLite;

namespace RelayMgr
{
    public class DBVItems
    {
        public DBVItems()
        {

        }
        public void Dispose()
        {

        }

        /// <summary>
        /// 查询所有设备分组的方法
        /// </summary>
        /// <returns></returns>
        public static string DBGetVItemGroup(string vItemID)
        {
            string sql = "select * from VItem where ID='{0}'";
            string sError = string.Empty;
            DataTable dt = SQLiteHelper.GetDataTable(out sError, string.Format(sql, vItemID));
            return dt.Rows[0]["TypeID"].ToString();
        }
        /// <summary>
        ///根据设备类型ID  查询所有虚拟设备的方法
        /// </summary>
        /// <param name="rtid">设备类型编号</param>
        /// <returns></returns>
        public static DataTable DBQueryVItemsByType(string typeid)
        {
            string sql = "select * from VItem where TypeID='{0}'";
            string sError = string.Empty;
            return SQLiteHelper.GetDataTable(out sError, string.Format(sql, typeid));
        }

        /// <summary>
        /// 插入设备的方法
        /// </summary>
        /// <param name="t"></param>
        public static void DBVItemInsert(string Name, string TypeID, string Interface)
        {
            string sql = "REPLACE into VItem (Name,TypeID,Interface) values('{0}','{1}','{2}')";
            string sError = string.Empty;
            try
            {
                SQLiteHelper.UpdateData(out sError, string.Format(sql, Name, TypeID, Interface), true);
            }
            catch
            { }
        }

        /// <summary>
        /// 修改设备的方法
        /// </summary>
        /// <param name="t"></param>
        public static void DBVItemUpdate(string ID, string Name, string TypeID, string Interface)
        {
            string sql = "update VItem set Name='{0}',TypeID='{1}',Interface='{2}' where ID='{3}'";
            string sError = string.Empty;
            SQLiteHelper.UpdateData(out sError, string.Format(sql, Name, TypeID, Interface, ID), true);
        }

        /// <summary>
        /// 删除VItem的方法
        /// </summary>
        /// <param name="tId"></param>
        public static void DBVItemDelete(string rId)
        {
            DBCommands.DBCMDDeleteByPID(rId);
            string sql = "delete from VItem where ID='{0}'";
            string sError = string.Empty;
            SQLiteHelper.UpdateData(out sError, string.Format(sql, rId), true);
        }

        /// <summary>
        /// 查询所有输出设备的方法
        /// </summary>
        /// <returns></returns>
        public static DataTable DBVItemAll()
        {
            string sql = "select * from VItem";
            string sError = string.Empty;
            return SQLiteHelper.GetDataTable(out sError, sql);
        }

    }
}
