using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace _GZFramework.Demo.Library
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    [ComVisible(true)]
    public sealed class AssemblyModuleAttribute : Attribute
    {
        public string ModuleName { get; set; }

        public string ModulePNG { get; set; }

        /// <summary>
        /// 模块信息
        /// </summary>
        /// <param name="sModuleName">模块名称</param>
        /// <param name="sModulePNG">模块图片PNG格式，eg:System_32x32.png,值为：System</param>
        public AssemblyModuleAttribute(string sModuleName, string sModulePNG)
        {
            ModuleName = sModuleName;
            ModulePNG = sModulePNG;
        }

    }
}
