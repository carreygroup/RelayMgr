using System;
using System.Collections.Generic;
using System.Text;
using System.Data ;
//using Community.CsharpSqlite;
//using Community.CsharpSqlite.SQLiteClient;
using System.Data.SQLite;

namespace RelayMgr
{
    public class DBDevices
    {
       public DBDevices()
       {

       }
       public void Dispose()
       {

       }
       /// <summary>
       /// DA  根据设备类型ID  查询所有输出设备的方法
       /// </summary>
       /// <param name="rtid">设备类型编号</param>
       /// <returns></returns>
       public static DataTable DBQueryDevicesByName(string devName)
       {
           string sql = "select * from Devices where Name='{0}' and IO='0'";
           string sError = string.Empty;
           return SQLiteHelper.GetDataTable(out sError, string.Format(sql, devName));
       }
       /// <summary>
       /// DA  根据设备类型ID  查询所有输出设备的方法
       /// </summary>
       /// <param name="rtid">设备类型编号</param>
       /// <returns></returns>
       public static DataTable DBQueryDevicesByType(string typeid)
       {
           string sql = "select * from Devices where TypeID='{0}' and IO='0'";
           string sError = string.Empty;
           return SQLiteHelper.GetDataTable(out sError, string.Format(sql, typeid));
       }

       /// <summary>
       /// DA  根据设备类型ID  查询所有输出设备的方法
       /// </summary>
       /// <param name="rtid">设备类型编号</param>
       /// <returns></returns>
       public static DataTable DBQueryDevicesByGroup(string GroupName)
       {
           string sql = "select * from DevType where Name='{0}'";
           //string sql = "select * from Devices inner join DevType dt on ID=dt.ID where IO='0' and dt.Name='{0}'";
           string sError = string.Empty;
           DataTable dt=SQLiteHelper.GetDataTable(out sError, string.Format(sql, GroupName));

           sql = "select * from Devices where IO='0' and TypeID='{0}'";
           sError = string.Empty;
           return SQLiteHelper.GetDataTable(out sError, string.Format(sql, dt.Rows[0]["ID"]));
       }

       /// <summary>
       /// DA  根据设备类型  查询所有输入设备的方法
       /// </summary>
       /// <param name="rtid">设备类型编号</param>
       /// <returns></returns>
       public static DataTable DBQueryInputDevicesByType(string typeid)
       {
           string sql = "select * from Devices where TypeID='{0}' and IO='1'";
           string sError = string.Empty;
           return SQLiteHelper.GetDataTable(out sError, string.Format(sql, typeid));
       }

       /// <summary>
       /// DA  根据设备类型  查询所有输入设备的方法
       /// </summary>
       /// <param name="rtid">设备类型编号</param>
       /// <returns></returns>
       public static DataTable DBQueryADDevicesByType(string typeid)
       {
           string sql = "select * from Devices where TypeID='{0}' and IO='2'";
           string sError = string.Empty;
           return SQLiteHelper.GetDataTable(out sError, string.Format(sql, typeid));
       }

        /// <summary>
        /// 查询所有输出设备的地址
        /// </summary>
       /// <param name="typeid">设备类型编号</param>
        /// <returns></returns>
        public static List<short> DBQueryDevicesAddress(string typeid)
        {
            List<short> Lcr = new List<short>();
            string sql = "select distinct Address from Devices where TypeID={0}";
            string sError = string.Empty;
            SQLiteDataReader dt = SQLiteHelper.GetDataReader(out sError, string.Format(sql, typeid));
            while (dt.Read())
            {
                Lcr.Add(Convert.ToInt16(dt["Address"]));
            }
            return Lcr;
        }

        /// <summary>
        /// 查询所有设备的地址
        /// </summary>
        /// <returns></returns>
        public static List<short> QueryAllDevicesAddress()
        {
            List<short> Lcr = new List<short>();
            string sql = "select distinct Address from Devices";
            string sError = string.Empty;
            SQLiteDataReader dt = SQLiteHelper.GetDataReader(out sError,sql);
            while (dt.Read())
            {
                Lcr.Add(Convert.ToInt16(dt["Address"]));
            }
            return Lcr;
        }

        /// <summary>
        /// 插入设备的方法
        /// </summary>
        /// <param name="t"></param>
        public static void DBDevInsert(string Name, string TypeID, string Address, string Line, string DefAction, string DevIO, string PowerFlash, string ImgGroup, string Item_Action,string iButton)
        {
            string sql = "REPLACE into Devices (Name,TypeID,Address,Line,DefAction,IO,powerflash,ImgGroup,Item_Action,iButton) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')";
            string sError = string.Empty;
            try
            {
                SQLiteHelper.UpdateData(out sError, string.Format(sql, Name, TypeID, Address, Line, DefAction, DevIO, PowerFlash, ImgGroup, Item_Action, iButton), true);
            }
            catch
            { }
        }

        /// <summary>
        /// 修改设备的方法
        /// </summary>
        /// <param name="t"></param>
        public static void DBDevUpdate(string ID, string Name, string Address, string Line, string DefAction, string DevIO, string TypeID, string PowerFlash, string ImgGroup, string Item_Action, string iButton)
        {
            string sql = "update Devices set Name='{0}',Address='{1}',Line='{2}',TypeID='{3}',DefAction='{4}',IO='{5}',powerflash='{6}',ImgGroup='{7}' ,Item_Action='{8}' ,iButton='{9}' where ID='{10}'";
            string sError = string.Empty;
            SQLiteHelper.UpdateData(out sError, string.Format(sql, Name, Address, Line, TypeID, DefAction, DevIO, PowerFlash, ImgGroup, Item_Action, iButton,ID), true);  
        }

        /// <summary>
        /// 删除设备的方法
        /// </summary>
        /// <param name="tId"></param>
        public static void DBDevDelete(string rId)
        {
            DBTasks.DBTasksDeleteByDevID(rId);

            string sql = "delete from Devices where ID='{0}'";
            string sError = string.Empty;
            SQLiteHelper.UpdateData(out sError, string.Format(sql, rId), true);  
        }

        /// <summary>
        /// 删除分类下所有设备的方法
        /// </summary>
        /// <param name="tId"></param>
        public static void DBDevDeleteByDevType(string TypeID)
        {
            string sql = "delete from Devices where TypeID='{0}'";
            string sError = string.Empty;
            SQLiteHelper.UpdateData(out sError, string.Format(sql, TypeID), true);
        }

        /// <summary>
        /// 查询所有输出设备的方法
        /// </summary>
        /// <returns></returns>
        public static DataTable DBDevAll()
        {
            string sql = "select * from Devices where IO='0'";
            string sError = string.Empty;
            return  SQLiteHelper.GetDataTable(out sError, sql);
        }

        /// <summary>
        /// 查询所有输入设备的方法
        /// </summary>
        /// <returns></returns>
        public static DataTable DBInputDevAll()
        {
            string sql = "select * from Devices where IO='1'";
            string sError = string.Empty;
            return SQLiteHelper.GetDataTable(out sError, sql);
        }
        /// <summary>
        /// 查询所有输入设备的方法
        /// </summary>
        /// <returns></returns>
        public static DataTable DBADDevAll()
        {
            string sql = "select * from Devices where IO='2'";
            string sError = string.Empty;
            return SQLiteHelper.GetDataTable(out sError, sql);
        }
        /// <summary>
        /// 查询所有设备分组的方法
        /// </summary>
        /// <returns></returns>
        public static string DBGetDevGroup(string DevID)
        {
            string sql = "select * from Devices where ID='{0}'";
            string sError = string.Empty;
            DataTable dt=SQLiteHelper.GetDataTable(out sError, string.Format(sql, DevID));
            return dt.Rows[0]["TypeID"].ToString();
        }
    }
}
