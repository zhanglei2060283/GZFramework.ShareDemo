using _GZFramework.Demo.Models;
using GZFramework.DB.Lib;
using System;
using System.Data;
namespace _GZFramework.Demo.Business.Base
{
    public abstract class bllBase : bllBusinessBase<dalBase>, IBLL
    {
        protected string DBCode { get { return dal.DBCode; } }
        public bllBase(Type sMainModel, params Type[] sDetailModel)
            : base(sMainModel, sDetailModel)
        {
            dal.DBCode = GenerateDBCode();
            
        }

        public bllBase(Type sMainModel, string DocCode, int Length, params Type[] sDetailModel)
            : base(sMainModel, DocCode, Length, sDetailModel)
        {
            dal.DBCode = GenerateDBCode();
        }

        
        protected abstract string GenerateDBCode();


        protected override void BeforUpdate(GZFramework.DB.Core.IDatabase db, System.Data.DataSet data)
        {
            //DateTime time = dal.GetServerTime(db);
            //foreach (DataTable dt in data.Tables)
            //{
            //    foreach (DataRow dr in dt.Select("", "", DataViewRowState.ModifiedCurrent))
            //    {
            //        dr["LastUpdateUser"] = Loginer.CurrentLoginer.Account;
            //        dr["LastUpdateDate"] = time;
            //    }
            //    foreach (DataRow dr in dt.Select("", "", DataViewRowState.Added))
            //    {
            //        dr["CreateUser"] = Loginer.CurrentLoginer.Account;
            //        dr["CreateDate"] = time;
            //        dr["LastUpdateUser"] = Loginer.CurrentLoginer.Account;
            //        dr["LastUpdateDate"] = time;
            //    }
            //}

            //base.BeforUpdate(db, data);
        }

    }

}
