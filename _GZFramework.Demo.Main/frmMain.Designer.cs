namespace _GZFramework.Demo.Main
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbi_Close = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.bsi_Modules = new DevExpress.XtraBars.BarSubItem();
            this.bci_FullScreen = new DevExpress.XtraBars.BarCheckItem();
            this.bsi_Windows = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpg_Nav = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpg_Function = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpg_DataNav = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AllowMdiChildButtons = false;
            this.ribbonControl1.AllowMinimizeRibbon = false;
            this.ribbonControl1.AllowTrimPageText = false;
            this.ribbonControl1.AutoHideEmptyItems = true;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbi_Close,
            this.barButtonItem5,
            this.ribbonGalleryBarItem1,
            this.bsi_Modules,
            this.bci_FullScreen,
            this.bsi_Windows});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 31;
            this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(858, 125);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbi_Close
            // 
            this.bbi_Close.Caption = "关闭";
            this.bbi_Close.Glyph = ((System.Drawing.Image)(resources.GetObject("bbi_Close.Glyph")));
            this.bbi_Close.Id = 3;
            this.bbi_Close.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbi_Close.LargeGlyph")));
            this.bbi_Close.Name = "bbi_Close";
            this.bbi_Close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Close_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "关于";
            this.barButtonItem5.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.Glyph")));
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.LargeGlyph")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1";
            this.ribbonGalleryBarItem1.Id = 8;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // bsi_Modules
            // 
            this.bsi_Modules.Caption = "模块";
            this.bsi_Modules.Glyph = ((System.Drawing.Image)(resources.GetObject("bsi_Modules.Glyph")));
            this.bsi_Modules.Id = 22;
            this.bsi_Modules.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bsi_Modules.LargeGlyph")));
            this.bsi_Modules.Name = "bsi_Modules";
            // 
            // bci_FullScreen
            // 
            this.bci_FullScreen.Caption = "全屏";
            this.bci_FullScreen.Id = 29;
            this.bci_FullScreen.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F11);
            this.bci_FullScreen.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bci_FullScreen.LargeGlyph")));
            this.bci_FullScreen.Name = "bci_FullScreen";
            this.bci_FullScreen.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bci_FullScreen_CheckedChanged);
            // 
            // bsi_Windows
            // 
            this.bsi_Windows.Caption = "窗口";
            this.bsi_Windows.Glyph = ((System.Drawing.Image)(resources.GetObject("bsi_Windows.Glyph")));
            this.bsi_Windows.Id = 30;
            this.bsi_Windows.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bsi_Windows.LargeGlyph")));
            this.bsi_Windows.Name = "bsi_Windows";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpg_Nav,
            this.rpg_Function,
            this.rpg_DataNav,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "操作区";
            // 
            // rpg_Nav
            // 
            this.rpg_Nav.ItemLinks.Add(this.bsi_Modules);
            this.rpg_Nav.ItemLinks.Add(this.bsi_Windows);
            this.rpg_Nav.Name = "rpg_Nav";
            this.rpg_Nav.Text = "导航";
            // 
            // rpg_Function
            // 
            this.rpg_Function.Name = "rpg_Function";
            this.rpg_Function.Text = "操作区";
            // 
            // rpg_DataNav
            // 
            this.rpg_DataNav.Name = "rpg_DataNav";
            this.rpg_DataNav.Text = "快捷操作";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbi_Close);
            this.ribbonPageGroup3.ItemLinks.Add(this.bci_FullScreen);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "视图";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "帮助";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.ribbonGalleryBarItem1);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "皮肤";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabbedMdiManager1.FloatOnDrag = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabbedMdiManager1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            this.xtraTabbedMdiManager1.MdiParent = this;
            this.xtraTabbedMdiManager1.ShowFloatingDropHint = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabbedMdiManager1.BeginFloating += new DevExpress.XtraTabbedMdi.FloatingCancelEventHandler(this.xtraTabbedMdiManager1_BeginFloating);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.navBarControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 125);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(146, 365);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "导航";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = null;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Location = new System.Drawing.Point(2, 22);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.NavigationPaneGroupClientHeight = 10;
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 142;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(142, 341);
            this.navBarControl1.TabIndex = 6;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 490);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主窗体";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpg_Nav;
        private DevExpress.XtraBars.BarButtonItem bbi_Close;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpg_Function;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpg_DataNav;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraBars.BarSubItem bsi_Modules;
        private DevExpress.XtraBars.BarCheckItem bci_FullScreen;
        private DevExpress.XtraBars.BarMdiChildrenListItem bsi_Windows;
        public DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;

    }
}