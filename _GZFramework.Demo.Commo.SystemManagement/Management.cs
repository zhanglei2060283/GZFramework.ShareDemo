using _GZFramework.Demo.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _GZFramework.Demo.SystemManagement
{
    public class Management : ModuleManagement
    {

        public Management()
        {
            FunctionCollection.AddFunction(typeof(frmMyUser), "用户管理", "Function_Account");
            FunctionCollection.AddFunction(typeof(frmGoodsIn), "商品入库", "");
        }
    }
}
