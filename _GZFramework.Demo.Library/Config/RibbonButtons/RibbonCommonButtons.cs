using GZFramework.UI.Dev.RibbonButton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _GZFramework.Demo.Library.Config.RibbonButtons
{
    internal class RibbonCommonButtons : IRibbonCommonButtons, IDisposable
    {

        private RibbonItemButton _btnView;
        public RibbonItemButtonBase btnView
        {
            get
            {
                if (_btnView == null)
                {
                    _btnView = new RibbonItemButton()
                    {
                        name = "btnView",
                        Caption = "查看",
                        ImgFileName = "ribbonitem_View",
                        BeginGroup = false
                    };
                }
                return _btnView;
            }
        }

        private RibbonItemButton _btnRefresh;
        public RibbonItemButtonBase btnRefresh
        {
            get
            {
                if (_btnRefresh == null)
                {
                    _btnRefresh = new RibbonItemButton()
                    {
                        name = "btnRefresh",
                        Caption = "刷新",
                        ImgFileName = "ribbonitem_Refresh",
                        BeginGroup = false
                    };
                }
                return _btnRefresh;
            }
        }
        private RibbonItemButton _btnADD;
        public RibbonItemButtonBase btnADD
        {
            get
            {
                if (_btnADD == null)
                {
                    _btnADD = new RibbonItemButton()
                    {
                        name = "btnAdd",
                        Caption = "新增",
                        ImgFileName = "ribbonitem_Add",
                        Shortcut = Keys.Control | Keys.N
                    };
                }
                return _btnADD;
            }
        }


        private RibbonItemButton _btnDelete;
        public RibbonItemButtonBase btnDelete
        {
            get
            {
                if (_btnDelete == null)
                {
                    _btnDelete = new RibbonItemButton()
                    {
                        name = "btnDelete",
                        Caption = "删除",
                        ImgFileName = "ribbonitem_Delete",
                        BeginGroup = false
                    };
                }
                return _btnDelete;
            }
        }
        private RibbonItemButton _btnEdit;
        public RibbonItemButtonBase btnEdit
        {
            get
            {
                if (_btnEdit == null)
                {
                    _btnEdit = new RibbonItemButton()
                    {
                        name = "btnEdit",
                        Caption = "修改",
                        ImgFileName = "ribbonitem_Edit",
                        Shortcut = Keys.Control | Keys.E
                    };
                }
                return _btnEdit;
            }
        }
        private RibbonItemButton _btnSave;
        public RibbonItemButtonBase btnSave
        {
            get
            {
                if (_btnSave == null)
                {
                    _btnSave = new RibbonItemButton()
                    {
                        name = "btn_Save",
                        Caption = "保存",
                        ImgFileName = "ribbonitem_Save",
                        Shortcut = Keys.Control | Keys.S
                    };
                }
                return _btnSave;
            }
        }
        private RibbonItemButton _btnSaveAndClose;
        public RibbonItemButtonBase btnSaveAndClose
        {
            get
            {
                if (_btnSaveAndClose == null)
                {
                    _btnSaveAndClose = new RibbonItemButton()
                    {
                        name = "btn_SaveAndClose",
                        Caption = "保存并关闭",
                        ImgFileName = "ribbonitem_SaveAndClose",
                        Shortcut = Keys.None
                    };
                }
                return _btnSaveAndClose;
            }
        }


        private RibbonItemButton _btnApproval;
        public RibbonItemButtonBase btnApproval
        {
            get
            {
                if (_btnApproval == null)
                {
                    _btnApproval = new RibbonItemButton()
                    {
                        name = "btn_Approval",
                        Caption = "审核",
                        ImgFileName = "ribbonitem_Approval",
                        Shortcut = Keys.None
                    };
                }
                return _btnApproval;
            }
        }


        private RibbonItemButton _btnCancel;
        public RibbonItemButtonBase btnCancel
        {
            get
            {
                if (_btnCancel == null)
                {
                    _btnCancel = new RibbonItemButton()
                    {
                        name = "btn_Calcel",
                        Caption = "取消",
                        ImgFileName = "ribbonitem_Return",
                        Shortcut = Keys.Control | Keys.Back
                    };
                }
                return _btnCancel;
            }
        }



        private RibbonItemButton _btnPreview;
        public RibbonItemButtonBase btnPreview
        {
            get
            {
                if (_btnPreview == null)
                {
                    _btnPreview = new RibbonItemButton()
                    {
                        name = "btn_Preview",
                        Caption = "打印预览",
                        ImgFileName = "ribbonitem_Preview",
                        Shortcut = Keys.None
                    };
                }
                return _btnPreview;
            }
        }
        private RibbonItemButton _btnExport;
        public RibbonItemButtonBase btnExport
        {
            get
            {
                if (_btnExport == null)
                {
                    _btnExport = new RibbonItemButton()
                    {
                        name = "btn_Export",
                        Caption = "导出",
                        ImgFileName = "ribbonitem_Export",
                        Shortcut = Keys.None
                    };
                }
                return _btnExport;
            }
        }
        public void Dispose()
        {
            if (_btnView != null)
            {
                _btnView.Dispose();
                _btnView = null;
            }
            if (_btnRefresh != null)
            {
                _btnRefresh.Dispose();
                _btnRefresh = null;
            }
            if (_btnADD != null)
            {
                _btnADD.Dispose();
                _btnADD = null;
            }
            if (_btnDelete != null)
            {
                _btnDelete.Dispose();
                _btnDelete = null;
            }
            if (_btnEdit != null)
            {
                _btnEdit.Dispose();
                _btnEdit = null;
            }
            if (_btnSave != null)
            {
                _btnSave.Dispose();
                _btnSave = null;
            }
            if (_btnSaveAndClose != null)
            {
                _btnSaveAndClose.Dispose();
                _btnSaveAndClose = null;
            }
            if (_btnApproval != null)
            {
                _btnApproval.Dispose();
                _btnApproval = null;
            }
            if (_btnCancel != null)
            {
                _btnCancel.Dispose();
                _btnCancel = null;
            }
            if (_btnPreview != null)
            {
                _btnPreview.Dispose();
                _btnPreview = null;
            }
            if (_btnExport != null)
            {
                _btnExport.Dispose();
                _btnExport = null;
            }
        }
    }
}
