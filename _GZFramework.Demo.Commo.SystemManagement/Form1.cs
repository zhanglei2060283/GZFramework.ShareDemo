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

namespace _GZFramework.Demo.SystemManagement
{
    public partial class Form1 : frmBaseDataBusiness
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += frm_Load;
            //实例化必须，bllBusinessBase必须替换为bll层自己继承的子类(指定正确的dal.DBCode)，建议封装重写到项目bll层
            //_bll = new bllBusinessBase(typeof(dt_MyUser));
            _bll = new bllBaseSystem(typeof(dt_MyUser));
        }
        private void frm_Load(object sender, EventArgs e)
        {
            _SummaryView = gvMainData;//必须赋值
            base.AddControlsOnAddKey(txtAccount);

            base.AddControlsOnlyRead(txtCreateUser, txtCreateDate, txtLastUpdateUser, txtLastUpdateDate);
        }
        //查询
        private void btn_Search_Click(object sender, EventArgs e)
        {
            var p = ParametersProvide.New();

            if (!String.IsNullOrEmpty(txts_Account.Text)) p.AddParameter("@Account", 0, txts_Account.Text);
            if (!String.IsNullOrEmpty(txts_Password.Text)) p.AddParameter("@Password", 0, txts_Password.Text);
            if (!String.IsNullOrEmpty(txts_UserName.Text)) p.AddParameter("@UserName", 0, txts_UserName.Text);
            if (!String.IsNullOrEmpty(txts_Phone.Text)) p.AddParameter("@Phone", 0, txts_Phone.Text);
            if (!String.IsNullOrEmpty(txts_Email.Text)) p.AddParameter("@Email", 0, txts_Email.Text);
            if (!String.IsNullOrEmpty(txts_IsAdmain.Text)) p.AddParameter("@IsAdmain", 0, txts_IsAdmain.Text);
            if (!String.IsNullOrEmpty(txts_IsLock.Text)) p.AddParameter("@IsLock", 0, txts_IsLock.Text);


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
                       & LibraryTools.IsNotEmpBaseEdit(txtAccount, "账号不能为空！")
                       & LibraryTools.IsNotEmpBaseEdit(txtPassword, "密码不能为空！")
                       & LibraryTools.IsNotEmpBaseEdit(txtUserName, "名称不能为空！");


            return Validate;
        }


        #region 其他常用
        //绑定明细页数据
        public override void DoBoundEditData()
        {
            base.DoBoundEditData();


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
