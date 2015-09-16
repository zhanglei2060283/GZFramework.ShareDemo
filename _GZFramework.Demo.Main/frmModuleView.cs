using _GZFramework.Demo.Library;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
//======================================================================
//        版权所有@GarsonZhang
//        文件名 :frmModuleView              									
//		  .NET版本：4.0
//        创建人：GarsonZhang  QQ：382237285
//        创建日期：2015-07-11 10:09:51
//        描述 :窗体
//======================================================================
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _GZFramework.Demo.Main
{



    public partial class frmModuleView : XtraForm
    {
        IMain MDIForm;
        public frmModuleView(IMain MDIfrm)
        {
            InitializeComponent();
            MDIForm = MDIfrm;
        }

        const int btnWidth = 85;
        const int btnHeight = 97;
        public void UpdateModule(NavBarGroup group)
        {

            this.SuspendLayout();
            flowLayoutPanel1.Controls.Clear();
            int cellNum = 0;
            if (group != null)
            {
                NavBarItem item;
                foreach (NavBarItemLink itemLink in group.VisibleItemLinks)
                {
                    item = itemLink.Item;
                    SimpleButton btn = new SimpleButton();
                    btn.Text = item.Caption;

                    btn.Appearance.Options.UseTextOptions = true;
                    btn.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                    btn.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
                    btn.Image = _GZFramework.Demo.Library.MyClass.LoadUIImage.LoadFunctionButtonImg((item.Tag as ModuleFunction).FunctionPng);
                    btn.Margin = new System.Windows.Forms.Padding(5);
                    btn.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
                    btn.Size = new System.Drawing.Size(btnWidth, btnHeight);


                    btn.Tag = item.Tag;

                    btn.Click += btn_Click;


                    flowLayoutPanel1.Controls.Add(btn);
                }
                this.Text = group.Caption;
            }

            this.Activate();
            this.ResumeLayout();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ModuleFunction fun = (sender as SimpleButton).Tag as ModuleFunction;

            MDIForm.ShowChildForm(fun);
        }
    }

}
