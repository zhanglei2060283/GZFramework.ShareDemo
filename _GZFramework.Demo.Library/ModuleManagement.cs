using GZFramework.UI.Dev.LibForm;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _GZFramework.Demo.Library
{
    [InheritedExport(typeof(ModuleManagement))]
    public abstract class ModuleManagement
    {
        protected ModuleFunctionCollection FunctionCollection;
        public ModuleManagement()
        {
            FunctionCollection = new ModuleFunctionCollection();

            //获得模块信息
            System.Reflection.Assembly s = this.GetType().Assembly;
            AssemblyModuleAttribute ModuleInfo = (AssemblyModuleAttribute)AssemblyModuleAttribute.GetCustomAttribute(s, typeof(AssemblyModuleAttribute));
            
            ModuleID = s.GetName().Name;
            ModuleName = ModuleInfo.ModuleName;
            ImgPath = ModuleInfo.ModulePNG;
            
        }

        public string ModuleID { get; private set; }
        public string ModuleName{get;private set;}
        public string ImgPath{get;private set;}

            

        public List<ModuleFunction> Functions { get { return FunctionCollection.funs; } }

    }
}