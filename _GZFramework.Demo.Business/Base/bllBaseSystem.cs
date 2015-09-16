using _GZFramework.Demo.Models;
using System;

namespace _GZFramework.Demo.Business.Base
{
    public class bllBaseSystem : bllBase
    {
        public bllBaseSystem(Type sMainModel, params Type[] sDetailModel)
            : base(sMainModel, sDetailModel)
        {

        }
        public bllBaseSystem(Type sMainModel, string DocCode, int Length, params Type[] sDetailModel)
            : base(sMainModel, DocCode, Length, sDetailModel)
        {

        }
        // ˝æ›ø‚±‡∫≈
        protected override string GenerateDBCode()
        {
            //_GZFramework.Demo.Library.Config.DBConnBuilder.DBConfig÷–≈‰÷√
            return CommonData.DBCode;
        }

    
    }
}
