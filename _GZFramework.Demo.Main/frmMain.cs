using _GZFramework.Demo.Common;
using _GZFramework.Demo.Library;
using _GZFramework.Demo.Library.MyClass;
using _GZFramework.Demo.Models;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraNavBar;
using DevExpress.XtraTab;
using GZFramework.UI.Dev;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace _GZFramework.Demo.Main
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm, IMain
    {
        ModuleObserver Modules;

        public frmMain()
        {
            InitializeComponent();

            if (INISystemConfig.GetWindowState() == "Y")
                this.WindowState = FormWindowState.Maximized;

            new GZFramework.UI.Dev.RibbonButton.RibbonLoad(ribbonPage1, rpg_Function, rpg_DataNav);


            SkinTools.InitSkinGallery(ribbonGalleryBarItem1);
            
            this.FormClosing += frmMain_FormClosing;

            RefreshModule();
        }


        void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                INISystemConfig.SetWindowState("Y");
            else
                INISystemConfig.SetWindowState("");
        }



        private void frmMain_Load(object sender, EventArgs e)
        {
            WaiteServer.CloseWaite();
            Modules = new ModuleObserver(this, navBarControl1);
            if (navBarControl1.ActiveGroup != null)
                Modules.SowModule(navBarControl1.ActiveGroup);
        }


        public void ShowChildForm(ModuleFunction fun)
        {
            WaiteServer.ShowWaite(this);
            Form frm = fun.LoadForm(this);
            frm.Text = fun.FunctionName;
            frm.Icon = LoadUIImage.LoadFormIcon(fun.FunctionPng);
            frm.Show();
            frm.Activate();
            // 设置当前 tab页的 图标,我这里也默认取navBar中的Item中的图标
            xtraTabbedMdiManager1.Pages[frm].Image = LoadUIImage.LoadMDIImg_TabPag(fun.FunctionPng);
            WaiteServer.CloseWaite();
            
        }

        public void RefreshModule()
        {
            navBarControl1.Items.Clear();
            navBarControl1.Groups.Clear();

            bsi_Modules.LinksPersistInfo.Clear();


            ModuleFunctionsPool LocalFunction = new LoadModuleFunctions().GetLocalAllModules(AppDomain.CurrentDomain.BaseDirectory);

            navBarControl1.BeginInit();
            NavBarGroup group;
            string ModuleID;


            foreach (var v in LocalFunction.Modules)
            {
                //添加模块到navBarControl1        
                group = navBarControl1.Groups.Add();
                group.Caption = v.ModuleName;
                group.SmallImage = LoadUIImage.LoadNavBarImage_Group(ConvertEx.ToString(v.ImgPath));
                group.Tag = v.ModuleID;

                //添加模块到bbi_Module
                BarSubItem BSI = new BarSubItem()
                {
                    Caption = v.ModuleName,
                    Glyph = LoadUIImage.LoadNavBarImage_Group(ConvertEx.ToString(v.ImgPath))
                };
                this.ribbonControl1.Items.Add(BSI);
                bsi_Modules.AddItem(BSI);

                ModuleID = v.ModuleID;

                foreach (var fun in v.Functions)
                {
                    if (fun == null) continue;
                    fun.UserAuthority = 1073741823;

                    //添加功能到navBarControl1
                    NavBarItem item = navBarControl1.Items.Add();
                    item.Caption = fun.FunctionName;
                    item.Tag = fun;
                    item.SmallImage = LoadUIImage.LoadNavBarImage_Item(fun.FunctionPng);


                    item.LinkClicked += item_LinkClicked;
                    group.ItemLinks.Add(item);


                    //添加功能到bbi_Module
                    var bbif = new DevExpress.XtraBars.BarButtonItem()
                    {
                        Caption = fun.FunctionName,
                        Tag = fun,
                        Glyph = LoadUIImage.LoadNavBarImage_Item(fun.FunctionPng)
                    };
                    bbif.ItemClick += bbi_ItemClick;
                    this.ribbonControl1.Items.Add(bbif);

                    BSI.AddItem(bbif);
                }

                if (group.ItemLinks.Count == 0)
                    navBarControl1.Groups.Remove(group);
            }


            navBarControl1.EndInit();
        }

        private void bbi_ItemClick(object sender, ItemClickEventArgs e)
        {
            ModuleFunction fun = e.Item.Tag as ModuleFunction;
            ShowChildForm(fun);
        }

        private void item_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            ModuleFunction fun = (sender as NavBarItem).Tag as ModuleFunction;
            ShowChildForm(fun);
        }


        //全屏
        private void bci_FullScreen_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (bci_FullScreen.Checked)
            {
                this.groupControl1.Hide();
                navBarControl1.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed;
            }
            else
            {
                this.groupControl1.Show();
                navBarControl1.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded;
            }
        }
        //关闭窗体
        private void bbi_Close_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = xtraTabbedMdiManager1.SelectedPage.MdiChild;
            if (frm is frmModuleView) return;
            else
                frm.Close();
        }

      
    }
}
