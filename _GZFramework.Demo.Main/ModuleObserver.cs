using DevExpress.XtraNavBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _GZFramework.Demo.Main
{
    public class ModuleObserver
    {
        Form Parent { get; set; }
        frmModuleView CurrentModule;
        public ModuleObserver(Form frm, NavBarControl Nav)
        {
            Parent = frm;
            Nav.ActiveGroupChanged += NavBar_ActiveGroupChanged;
            Nav.MouseClick += NavBar_MouseClick;
        }

        private void NavBar_MouseClick(object sender, MouseEventArgs e)
        {
            NavBarControl nav = (sender as NavBarControl);//取到NavBarControl对象引用
            NavBarHitInfo hh = nav.CalcHitInfo(e.Location);//计算点击区域的对象

            NavBarGroup group = hh.Group;

            bool InGroup = hh.InGroup;
            bool InGroupCaption = hh.InGroupCaption;
            if (InGroup && InGroupCaption)//点击导航分组按钮
            {
                try
                {
                    if (group != nav.ActiveGroup)
                    {
                        nav.ActiveGroup = group;
                    }

                    else
                    {
                        if (CurrentModule != null)
                            CurrentModule.Activate();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void NavBar_ActiveGroupChanged(object sender, NavBarGroupEventArgs e)
        {
            SowModule(e.Group);
        }

        

        public void SowModule(NavBarGroup group)
        {

            if (CurrentModule == null)
            {
                //初始化模块容器
                CurrentModule = new frmModuleView(Parent as IMain)
                {
                    MdiParent = Parent,
                    ControlBox = false,
                    WindowState = FormWindowState.Maximized
                };
            }
            CurrentModule.UpdateModule(group);

            CurrentModule.Show();

        }
    }
}
