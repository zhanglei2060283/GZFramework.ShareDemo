using GZFramework.UI.Dev.LibForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _GZFramework.Demo.Library
{
    public class ModuleFunction
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FormType">子窗体类,必须继承自frmBaseFunction</param>
        /// <param name="Text">子窗体名称</param>
        /// <param name="PNGName">图片大小为64x64</param>
        public ModuleFunction(Type FormType, string Text, string PNGName)
        {
            ChildForm = FormType;//子窗体类
            FunctionName = Text;//子窗体名称
            FunctionPng = PNGName;//图片大小为64x64
        }

        #region 属性
        /// <summary>
        /// 子窗体类
        /// </summary>
        private Type ChildForm { get; set; }

        /// <summary>
        /// 当前功能名称
        /// </summary>
        public string FunctionName
        {
            get;
            set;
        }

        /// <summary>
        /// 图片名称
        /// </summary>
        public string FunctionPng { get; set; }

        /// <summary>
        /// 当前功能ID
        /// </summary>
        public string FunctionID
        {
            get
            {
                return ChildForm.Name;
            }
        }

        /// <summary>
        /// 当前功能所在模块ID（DLL名称）
        /// </summary>
        public string ModuleID
        {
            get
            {
                return ChildForm.Assembly.GetName().Name;
            }
        }

        #endregion

        public Form LoadForm(Form MIDParent)
        {
            if (frmFun == null)
            {
                try
                {
                    frmFun = ChildForm.Assembly.CreateInstance(ChildForm.FullName) as Form;
                    frmFun.Text = FunctionName;
                    if (MIDParent != null)
                    {
                        frmFun.MdiParent = MIDParent;
                    }
                }
                catch (Exception ex)
                {
                    throw ex.InnerException;
                }
            }
            return frmFun;
        }


        /// <summary>
        /// 当前用户该功能的权限
        /// </summary>
        public int UserAuthority { get; set; }

        private Form _frm;
        protected Form frmFun
        {
            get
            {
                return _frm;
            }
            set
            {
                _frm = value;
                if (_frm == null) return;

                //窗体权限1073741823,最多支持30个权限
                (_frm as frmBaseChild).UserAuthority = UserAuthority;

                _frm.FormClosing += _frm_FormClosing;
            }
        }
        void _frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmFun = null;
        }

    }
}
