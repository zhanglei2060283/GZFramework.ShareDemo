using _GZFramework.Demo.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;

namespace _GZFramework.Demo.Main
{
    public class ModuleFunctionsPool
    {
        [ImportMany(typeof(ModuleManagement))]
        public List<ModuleManagement> Modules { get; set; }

        public Dictionary<string, ModuleFunction> lstFunction = new Dictionary<string, ModuleFunction>();

        ///// <summary>
        ///// 获得指定模块指定功能的窗体生成类，用于得到功能窗体提供者
        ///// </summary>
        ///// <param name="ModuleID"></param>
        ///// <param name="FunctionID"></param>
        ///// <returns></returns>
        //public ModuleFunction GetFunctionFormProvider(string ModuleID, string FunctionID)
        //{
        //    if (lstFunction.Count == 0)
        //    {
        //        foreach (ModuleManagement FunPools in Modules)
        //        {
        //            foreach (ModuleFunction fn in FunPools.Functions)
        //            {
        //                lstFunction.Add(String.Format("{0}.{1}", fn.ModuleID, fn.FunctionID), fn);
        //            }
        //        }
        //    }
        //    string Key = String.Format("{0}.{1}", ModuleID, FunctionID);
        //    if (lstFunction.ContainsKey(Key))
        //        return lstFunction[Key];
        //    else
        //        return null;
        //}
    }

    public class LoadModuleFunctions
    {
        public LoadModuleFunctions()
        { 
        }
        ///// <summary>
        ///// 获得制定模块所有功能列表
        ///// </summary>
        ///// <param name="Path"></param>
        ///// <param name="DLLName"></param>
        ///// <returns></returns>
        //public IEnumerable<ModuleFunction> GetModuleFunction(string Path, string DLLName)
        //{
        //    ModuleFunctionsPool module = new ModuleFunctionsPool();
        //    var catalogs = new DirectoryCatalog(Path, DLLName);
        //    var container = new CompositionContainer(catalogs);
        //    container.ComposeParts(module);

        //    foreach (ModuleManagement FunPools in module.Modules)
        //    {
        //        foreach (ModuleFunction fn in FunPools.Functions)
        //        {
        //            yield return fn;
        //        }
        //    }
        //}

        /// <summary>
        /// 获得本地模块列表
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="DLLName"></param>
        /// <returns></returns>
        public ModuleFunctionsPool GetLocalAllModules(string Path)
        {
            if (!System.IO.Directory.Exists(Path))
                System.IO.Directory.CreateDirectory(Path);

            ModuleFunctionsPool module = new ModuleFunctionsPool();
            var catalogs = new DirectoryCatalog(Path);
            var container = new CompositionContainer(catalogs);
            container.ComposeParts(module);

            return module;

        }



    }
}
