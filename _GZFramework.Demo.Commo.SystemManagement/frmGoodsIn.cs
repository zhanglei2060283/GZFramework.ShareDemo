using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GZFramework.DB.Core;
using GZFramework.DB.Lib;
using GZFramework.UI.Dev.Common;
using GZFramework.UI.Dev.LibForm;
using _GZFramework.Demo.Business.Base;
using _GZFramework.Demo.Models;

namespace _GZFramework.Demo.SystemManagement
{
    public partial class frmGoodsIn : frmBaseDataBusiness
    {
        public frmGoodsIn()
        {
            InitializeComponent();
            this.Load += frm_Load;
            //实例化必须，bllBusinessBase必须替换为bll层自己继承的子类(指定正确的dal.DBCode)，建议封装重写到项目bll层
            //_bll = new bllBusinessBase(typeof(tb_GoodsIn),"GI",6,typeof(tb_GoodsInDetail));
            _bll = new bllBaseSystem(typeof(tb_GoodsIn), "GI", 6, typeof(tb_GoodsInDetail));
        }
        private void frm_Load(object sender, EventArgs e)
        {
            _SummaryView = gvMainData;//必须赋值
            base.AddControlsOnAddKey(txtDocDate, txtOperationUser);

            base.AddControlsOnlyRead(txtDocNo, txtCreateUser, txtCreateDate, txtLastUpdateUser, txtLastUpdateDate);
        }
        //查询
        private void btn_Search_Click(object sender, EventArgs e)
        {
            var p = ParametersProvide.New();

            if (!String.IsNullOrEmpty(txts_DocNo.Text)) p.AddParameter("@DocNo", 0, txts_DocNo.Text);
            if (!String.IsNullOrEmpty(txts_DocDate.Text)) p.AddParameter("@DocDate", 0, txts_DocDate.Text);
            if (!String.IsNullOrEmpty(txts_OperationUser.Text)) p.AddParameter("@OperationUser", 0, txts_OperationUser.Text);
            if (!String.IsNullOrEmpty(txts_Supplier.Text)) p.AddParameter("@Supplier", 0, txts_Supplier.Text);
            if (!String.IsNullOrEmpty(txts_GoodsType.Text)) p.AddParameter("@GoodsType", 0, txts_GoodsType.Text);


            DataTable dt = _bll.Search(p);

            gcMainData.DataSource = dt;
            if (gvMainData.RowCount < 100)//行数过多会很耗时
                gvMainData.BestFitColumns();
        }
        //清空条件
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            LibraryTools.DoClearPanel(LC_Search);
        }


        //保存前检查
        protected override bool ValidateBeforSave()
        {
            bool Validate = true
                       & LibraryTools.IsNotEmpBaseEdit(txtDocDate, "入库日期不能为空！")
                       & LibraryTools.IsNotEmpBaseEdit(txtOperationUser, "入库人不能为空！");

            Validate = Validate & !gv_Detail_tb_GoodsInDetail.HasColumnErrors & gv_Detail_tb_GoodsInDetail.ValidateEditor();

            return Validate;
        }


        private void gv_Detail_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            string TableName = (sender as DevExpress.XtraGrid.Views.Grid.GridView).GridControl.DataSource.ToString();
            (sender as DevExpress.XtraGrid.Views.Grid.GridView).SetRowCellValue(e.RowHandle, _bll.DetailModel[TableName].ForeignKey, EditData.Tables[_bll.SummaryModel.TableName].Rows[0][_bll.SummaryModel.PrimaryKey]);
        }
        private void gc_Detail_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Remove)
            {
                e.Handled = Msg.AskQuestion("是否确定要删除选中行？") == false;
            }
        }

        private void gv_Detail_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (Object.Equals(view.FocusedColumn.Tag, "NotNull"))
            {
                if (Object.Equals(string.Empty, e.Value) || Object.Equals(null, e.Value) || Object.Equals(DBNull.Value, e.Value))
                {
                    e.Valid = false;
                    e.ErrorText = view.FocusedColumn.Caption + "不能为空！";
                }
            }
        }

        private void gv_Detail_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            bool V = true;

            foreach (DevExpress.XtraGrid.Columns.GridColumn column in view.Columns)
            {
                if (Object.Equals(column.Tag, "NotNull"))
                {
                    if (String.IsNullOrEmpty(view.GetFocusedRowCellDisplayText(column)))
                    {
                        view.SetColumnError(column, column.Caption + "不能为空!");
                        V = V & false;
                    }
                }
            }
            e.Valid = V;
        }

        private void gv_Detail_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            //去掉验证行失败时弹出的确认框
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }


        #region 其他常用
        //绑定明细页数据
        public override void DoBoundEditData()
        {
            base.DoBoundEditData();

            gc_Detail_tb_GoodsInDetail.DataSource = EditData.Tables[tb_GoodsInDetail._TableName];

            //其他绑定
            //LibraryTools.DoBindingEditorPanel(pan_Summary, EditData.Tables[_bll.SummaryTableName], "txt");
            //txxtPassword.EditValue = EditData.Tables[_bll.SummaryTableName].Rows[0][dt_MyUser.Password];
            //gc_Detail.DataSource = EditData.Tables[dt_MyUserRole._TableName];    
        }

        //获得详细数据，明细也
        public override DataSet GetEditData(string KeyValue)
        {
            return base.GetEditData(KeyValue);
        }

        /// <summary>
        /// 设置窗体的基础权限从FunctionAuthorityCommon类中取，例如(默认)：
        /// return FunctionAuthorityCommon.VIEW//查看
        ///       + FunctionAuthorityCommon.ADD//新增
        ///       + FunctionAuthorityCommon.EDIT//修改
        ///       + FunctionAuthorityCommon.DELETE//删除
        ///       + FunctionAuthorityCommon.Save//保存
        ///       + FunctionAuthorityCommon.Cancel;//取消
        /// </summary>
        protected override int CurrentAuthority
        {
            get
            {
                return base.CurrentAuthority;
            }
        }

        //自定义窗体权限按钮
        public override void IniButton()
        {
            base.IniButton();
        }

        //窗体状态改变后
        protected override void DataStateChanged(FormDataState NewState)
        {
            base.DataStateChanged(NewState);
        }
        //窗体状态改时
        protected override void DataStateChanging(FormDataState OldState, FormDataState NewState)
        {
            base.DataStateChanging(OldState, NewState);
        }



        /// <summary>
        /// 设置按钮可用状态，如果已经在ControlOnlyReads或SetControlAccessable中添加，这里不需要重新设置
        /// </summary>
        /// <param name="Edit"></param>
        protected override void SetControlAccessable(bool Edit)
        {
            //LibraryTools.SetControlAccessable(tp_Edit, Edit);
            base.SetControlAccessable(Edit);

        }
        #endregion

        #region 操作事件，不需要的可以删除
        /// <summary>
        /// 查询
        /// </summary>
        public override void DoView(object sender)
        {
            base.DoView(sender);
        }

        /// <summary>
        /// 刷新
        /// </summary>
        public override void DoRefresh(object sender)
        {
            base.DoRefresh(sender);
        }

        /// <summary>
        /// 新增
        /// </summary>
        public override void DoAdd(object sender)
        {
            base.DoAdd(sender);
        }

        /// <summary>
        /// 删除
        /// </summary>
        public override void DoDelete(object sender)
        {
            base.DoDelete(sender);
        }

        /// <summary>
        /// 修改
        /// </summary>
        public override void DoEdit(object sender)
        {
            base.DoEdit(sender);
        }

        /// <summary>
        /// 保存
        /// </summary>
        public override void DoSave(object sender)
        {
            base.DoSave(sender);
        }

        /// <summary>
        /// 保存并关闭
        /// </summary>
        public override void DoSaveAndClose(object sender)
        {
            base.DoSaveAndClose(sender);
        }

        /// <summary>
        /// 审核
        /// </summary>
        public override void DoApproval(object sender)
        {
            base.DoApproval(sender);
        }

        /// <summary>
        /// 返回取消
        /// </summary>
        public override void DoCancel(object sender)
        {
            base.DoCancel(sender);
        }

        /// <summary>
        /// 打印预览
        /// </summary>
        public override void DoPreview(object sender)
        {
            base.DoPreview(sender);
        }

        /// <summary>
        /// 导出数据
        /// </summary>
        public override void DoExport(object sender)
        {
            base.DoExport(sender);
        }

        #endregion



    }
}
