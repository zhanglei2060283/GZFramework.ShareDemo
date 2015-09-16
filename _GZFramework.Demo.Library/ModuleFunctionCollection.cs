using System;
using System.Collections.Generic;
using System.Linq;

namespace _GZFramework.Demo.Library
{
    public class ModuleFunctionCollection
    {
        public List<ModuleFunction> funs;
        public ModuleFunctionCollection()
        {
            funs = new List<ModuleFunction>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FormType">子窗体类,必须继承自frmBaseFunction</param>
        /// <param name="Text">子窗体名称</param>
        /// <param name="PNGName">图片大小为64x64</param>
        public void AddFunction(Type FormType, string Text, string PNGName)
        {
            ModuleFunction fun = new ModuleFunction(FormType, Text, PNGName);
            funs.Add(fun);
        }
    }
}
