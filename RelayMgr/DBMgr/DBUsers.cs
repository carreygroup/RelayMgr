using System;
using System.Collections.Generic;
using System.Text;

namespace RelayMgr
{
    class DBUsers
    {
        /// <summary>
        ///DB   查询密码的方法
        /// </summary>
        /// <returns></returns>
        /// <summary>
        public static bool DBQueryUsers(string username,string password)
        {
            string sql = "select * from Users where username='{0}' and password='{1}'";
            string sError = string.Empty;
            System.Data.DataTable dt=SQLiteHelper.GetDataTable(out sError, string.Format(sql, username, password));
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 插入用户的方法
        /// </summary>
        /// <param name="tt"></param>
        public static void DBUsersInsert(string UserName, string Password)
        {
            string sql = "REPLACE into Users (username,password) values('{0}','{1}')";
            string sError = string.Empty;
            SQLiteHelper.UpdateData(out sError, string.Format(sql, UserName, Password), true);
        }

        /// <summary>
        /// 修改用户的方法
        /// </summary>
        /// <param name="tt"></param>
        public static void DBUsersUPdate(string UserName, string Password)
        {
            string sql = "update Users set password='{1}' where username='{0}'";
            string sError = string.Empty;
            SQLiteHelper.UpdateData(out sError, string.Format(sql, UserName, Password), true);
        }

        /// <summary>
        /// 删除用户的方法
        /// </summary>
        /// <param name="ttId"></param>
        public static void DBUsersDelete(string username)
        {
            string sql = "delete from Users where username='{0}'";
            string sError = string.Empty;
            SQLiteHelper.UpdateData(out sError, string.Format(sql, username), true);

        }
    }
}
