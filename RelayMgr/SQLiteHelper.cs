using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Windows.Forms;

namespace RelayMgr
{
    public abstract class SQLiteHelper
    {
       public static string ConnSqlLiteDbPath = string.Empty;
       public static string ConnString
       {
           get
           {
               //ConnSqlLiteDbPath = System.Environment.CurrentDirectory + "\\DevMgr.dat";

               ConnSqlLiteDbPath = Application.StartupPath + "\\DevMgr.dat";
               return string.Format(@"Data Source={0}", ConnSqlLiteDbPath);

               //ConnSqlLiteDbPath = System.Environment.CurrentDirectory + "\\DevMgr.dat";
               //return string.Format("Version=3,uri=file:{0}", ConnSqlLiteDbPath);            
           }
       }

       public static SQLiteDataReader GetDataReader(out string sError, string sSQL)
       {
           SQLiteDataReader dr = null;
           sError = string.Empty;
           try
           {
               SQLiteConnection conn = new SQLiteConnection(ConnString);
               conn.Open();
               SQLiteCommand cmd = new SQLiteCommand();
               cmd.CommandText = sSQL;
               cmd.Connection = conn;
               dr = cmd.ExecuteReader();
               return dr;
           }
           catch (Exception ex)
           {
               sError = ex.Message;
           }
           return dr;
       }
       // 取datatable
       public static DataTable GetDataTable(out string sError, string sSQL)
       {
           DataTable dt = null;
           sError = string.Empty;
           try
           {
               SQLiteConnection conn = new SQLiteConnection(ConnString);
               conn.Open();
               SQLiteCommand cmd = new SQLiteCommand();
               cmd.CommandText = sSQL;
               cmd.Connection = conn;
               SQLiteDataAdapter dao = new SQLiteDataAdapter(cmd);
               dt = new DataTable();
               dao.Fill(dt);
           }
           catch (Exception ex)
           {
               sError = ex.Message;
           }
           return dt;
       }

       // 执行insert,update,delete 动作，也可以使用事务
       public static bool UpdateData(out string sError, string sSQL,bool bUseTransaction)
       {
           int iResult = 0;
           sError = string.Empty;
           if (!bUseTransaction)
           {
               try
               {
                   SQLiteConnection conn = new SQLiteConnection(ConnString);
                   conn.Open();
                   SQLiteCommand comm = new SQLiteCommand();
                   comm.Connection = conn;
                   comm.CommandText = sSQL;
                   iResult = comm.ExecuteNonQuery();
               }
               catch (Exception ex)
               {
                   sError = ex.Message;
                   iResult = -1;
               }
           }
           else // 使用事务
           {
               DbTransaction trans =null;
               try
               {
                   SQLiteConnection conn = new SQLiteConnection(ConnString);
                   conn.Open();
                   trans = conn.BeginTransaction();
                   SQLiteCommand comm = new SQLiteCommand();
                   comm.CommandText = sSQL;
                   comm.Connection = conn;
                   iResult = comm.ExecuteNonQuery();
                   trans.Commit();
               }
               catch (Exception ex)
               {
                   sError = ex.Message;
                   iResult = -1;
                   trans.Rollback();
               }
           }
           return iResult>0;
       }
    }
}