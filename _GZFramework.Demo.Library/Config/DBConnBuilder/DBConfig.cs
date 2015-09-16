

using _GZFramework.Demo.Business;
using _GZFramework.Demo.Common;
using _GZFramework.Demo.Library.MyClass;
using GZFramework.DB.Core;
using System.Collections.Generic;
using System.Data.Common;
using System.Windows.Forms;
namespace _GZFramework.Demo.Library.Config.DBConnBuilder
{
    public class DBConfig : GZFramework.DB.Core.IDBConfig
    {
    
        Dictionary<string, IDatabase> dic;
        public DBConfig()
        {
            dic = new Dictionary<string, IDatabase>();

            bool success = LoadSysConfig();

            if (success == false)//没有数据库配置
            {
                GZFramework.UI.Dev.SplashScreenServer.CloseForm();//跳转窗体
                if (frmDBConfig.ShowForm() == DialogResult.OK)
                {
                    
                    success = LoadSysConfig();
                    if (success == false)
                        ApplicationEx.Exit();
                }
                else
                    ApplicationEx.Exit();

                GZFramework.UI.Dev.SplashScreenServer.ShowForm(null);//跳转窗体
            }
        }

        bool LoadSysConfig()
        {
            INIDBConfig i = new INIDBConfig();
            string DBCode = i.GetDBCode();
            string ConnnectionString = i.GetConnStr();
            string ProviderName = i.GetProviderName();
            var validate = DatabaseFactory.Validate(ConnnectionString, ProviderName);
            if (validate == true)
            {
                CommonData.DBCode = DBCode;
                var v = DatabaseFactory.CreateDatabase(ConnnectionString, ProviderName);
                dic.Add(DBCode, v);
            }
            return validate;
        }

        public IDatabase GetDBConnectionInfo(string DBCode)
        {
            if (dic.ContainsKey(DBCode))
                return dic[DBCode];
            else
            {
                //获得新的数据库对象
                IDB config = null;
                string ConnnectionString = config.GetConnectionStr();
                string ProviderName = config.ProviderName;
                var v = DatabaseFactory.CreateDatabase(ConnnectionString, ProviderName);
                dic.Add(DBCode, v);
                return v;
            }

            //IDB config = null;
            //if (DBCode == "MSSQLTest")
            //{
            //    config = new DB_SQL()
            //    {
            //        Server = "(local)",
            //        DataBase = "MSSQLTest",
            //        UserID = "sa",
            //        Password = "test"
            //    };
            //}
            //if (DBCode == "SQLiteTest")
            //{
            //    config = new DB_SQLite()
            //    {
            //        DataSource = string.Format("{0}\\DB\\SQLiteTest.db3", Globals.BaseDirectory)
            //    };
            //}
            //if (DBCode == "AccessTest")
            //{
            //    config = new DB_Access()
            //    {
            //        DataSource = string.Format("{0}\\DB\\AccessTest.mdb", Globals.BaseDirectory)
            //    };
            //}

            //if (config != null)
            //{

            //    ConnnectionString = config.GetConnectionStr();
            //    ProviderName = config.ProviderName;
            //}
        }


    }
}
