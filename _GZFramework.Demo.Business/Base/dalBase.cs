using GZFramework.DB.Core;
using GZFramework.DB.Lib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _GZFramework.Demo.Business.Base
{
    
    public class dalBase : dalBusinessBase
    {
      
        public dalBase()
        {
            
        }
        //获取流水单号
        public override string GetDataSN(IDatabase db, string sDocCode, int sLength)
        {
            return sDocCode + db.ExecuteScalarSP<string>("sys_GetDataSN",
                new { DataCode = sDocCode, Length = sLength });
        }


        //自定义提交
        protected override void CustomerUpdate(IDatabase db, System.Data.DataSet data, ref bool IsHandle)
        {
            base.CustomerUpdate(db, data, ref IsHandle);
        }

        //获取系统时间，建议从服务器获取
        public override DateTime GetServerTime(IDatabase db)
        {
            string sql = "SELECT GETDATE()";
            return db.ExecuteScalar<DateTime>(sql);
        }
    
    }
}
