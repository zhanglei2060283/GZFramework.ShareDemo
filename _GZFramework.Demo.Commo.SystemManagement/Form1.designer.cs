namespace _GZFramework.Demo.SystemManagement
{
    partial class Form1
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
            this.txtAccount = new DevExpress.XtraEditors.TextEdit();
            this.LCItem_Account = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_Account = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txts_Account = new DevExpress.XtraEditors.TextEdit();
            this.LCItems_Account = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.LCItem_Password = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_Password = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txts_Password = new DevExpress.XtraEditors.TextEdit();
            this.LCItems_Password = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.LCItem_UserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txts_UserName = new DevExpress.XtraEditors.TextEdit();
            this.LCItems_UserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.LCItem_Phone = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txts_Phone = new DevExpress.XtraEditors.TextEdit();
            this.LCItems_Phone = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.LCItem_Email = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txts_Email = new DevExpress.XtraEditors.TextEdit();
            this.LCItems_Email = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtIsAdmain = new DevExpress.XtraEditors.CheckEdit();
            this.LCItem_IsAdmain = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_IsAdmain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txts_IsAdmain = new DevExpress.XtraEditors.TextEdit();
            this.LCItems_IsAdmain = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtIsLock = new DevExpress.XtraEditors.CheckEdit();
            this.LCItem_IsLock = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_IsLock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txts_IsLock = new DevExpress.XtraEditors.TextEdit();
            this.LCItems_IsLock = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtCreateUser = new DevExpress.XtraEditors.TextEdit();
            this.LCItem_CreateUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_CreateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCreateDate = new DevExpress.XtraEditors.DateEdit();
            this.LCItem_CreateDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_CreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtLastUpdateUser = new DevExpress.XtraEditors.TextEdit();
            this.LCItem_LastUpdateUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_LastUpdateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtLastUpdateDate = new DevExpress.XtraEditors.DateEdit();
            this.LCItem_LastUpdateDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_LastUpdateDate = new DevExpress.XtraGrid.Columns.GridColumn();


            this.gcMainData = new DevExpress.XtraGrid.GridControl();
            this.gvMainData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LC_Search = new DevExpress.XtraLayout.LayoutControl();
            this.LCGroup_Search = new DevExpress.XtraLayout.LayoutControlGroup();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Clear = new DevExpress.XtraEditors.SimpleButton();
            this.LC_Edit = new DevExpress.XtraLayout.LayoutControl();
            this.LCGroup_Edit = new DevExpress.XtraLayout.LayoutControlGroup();

            ((System.ComponentModel.ISupportInitialize)(this.pan_Summary)).BeginInit();
            this.pan_Summary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tp_Search.SuspendLayout();
            this.tp_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tc_Data)).BeginInit();
            this.tc_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMainData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMainData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LC_Search)).BeginInit();
            this.LC_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LCGroup_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LC_Edit)).BeginInit();
            this.LC_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LCGroup_Edit)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_Summary
            // 
            this.pan_Summary.Controls.Add(this.LC_Edit);
            this.pan_Summary.Dock = System.Windows.Forms.DockStyle.Fill;

            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Clear);
            this.panelControl1.Controls.Add(this.btn_Search);
            this.panelControl1.Controls.Add(this.LC_Search);
            this.panelControl1.Size = new System.Drawing.Size(947, 91);
            // 
            // tp_Search
            // 
            this.tp_Search.Appearance.PageClient.BackColor = System.Drawing.Color.DarkRed;
            this.tp_Search.Appearance.PageClient.Options.UseBackColor = true;
            this.tp_Search.Controls.Add(this.gcMainData);
            this.tp_Search.Controls.SetChildIndex(this.panelControl1, 0);
            this.tp_Search.Controls.SetChildIndex(this.gcMainData, 0);




            // 
            // tc_Data
            // 
            this.tc_Data.Size = new System.Drawing.Size(953, 612);
            // 
            // gcMainData
            // 
            this.gcMainData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMainData.Location = new System.Drawing.Point(0, 74);
            this.gcMainData.MainView = this.gvMainData;
            this.gcMainData.Name = "gcMainData";
            this.gcMainData.Size = new System.Drawing.Size(947, 509);
            this.gcMainData.TabIndex = 1;
            this.gcMainData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMainData});
            // 
            // gvMainData
            // 
            this.gvMainData.GridControl = this.gcMainData;
            this.gvMainData.Name = "gvMainData";
            this.gvMainData.OptionsBehavior.Editable = false;
            this.gvMainData.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvMainData.OptionsView.ColumnAutoWidth = false;
            this.gvMainData.OptionsView.ShowGroupPanel = false;
            this.gvMainData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
						this.gc_Account,
			this.gc_Password,
			this.gc_UserName,
			this.gc_Phone,
			this.gc_Email,
			this.gc_IsAdmain,
			this.gc_IsLock,
			this.gc_CreateUser,
			this.gc_CreateDate,
			this.gc_LastUpdateUser,
			this.gc_LastUpdateDate,});


            this.gc_Account.Caption = "账号";
            this.gc_Account.Name = "gc_Account";
            this.gc_Account.FieldName = "Account";
            this.gc_Account.Visible = true;
            this.gc_Account.VisibleIndex = 0;
            this.gc_Password.Caption = "密码";
            this.gc_Password.Name = "gc_Password";
            this.gc_Password.FieldName = "Password";
            this.gc_Password.Visible = true;
            this.gc_Password.VisibleIndex = 1;
            this.gc_UserName.Caption = "名称";
            this.gc_UserName.Name = "gc_UserName";
            this.gc_UserName.FieldName = "UserName";
            this.gc_UserName.Visible = true;
            this.gc_UserName.VisibleIndex = 2;
            this.gc_Phone.Caption = "电话";
            this.gc_Phone.Name = "gc_Phone";
            this.gc_Phone.FieldName = "Phone";
            this.gc_Phone.Visible = true;
            this.gc_Phone.VisibleIndex = 3;
            this.gc_Email.Caption = "Email";
            this.gc_Email.Name = "gc_Email";
            this.gc_Email.FieldName = "Email";
            this.gc_Email.Visible = true;
            this.gc_Email.VisibleIndex = 4;
            this.gc_IsAdmain.Caption = "是否是管理员";
            this.gc_IsAdmain.Name = "gc_IsAdmain";
            this.gc_IsAdmain.FieldName = "IsAdmain";
            this.gc_IsAdmain.Visible = true;
            this.gc_IsAdmain.VisibleIndex = 5;
            this.gc_IsLock.Caption = "锁定";
            this.gc_IsLock.Name = "gc_IsLock";
            this.gc_IsLock.FieldName = "IsLock";
            this.gc_IsLock.Visible = true;
            this.gc_IsLock.VisibleIndex = 6;
            this.gc_CreateUser.Caption = "创建人";
            this.gc_CreateUser.Name = "gc_CreateUser";
            this.gc_CreateUser.FieldName = "CreateUser";
            this.gc_CreateUser.Visible = true;
            this.gc_CreateUser.VisibleIndex = 7;
            this.gc_CreateDate.Caption = "创建日期";
            this.gc_CreateDate.Name = "gc_CreateDate";
            this.gc_CreateDate.FieldName = "CreateDate";
            this.gc_CreateDate.Visible = true;
            this.gc_CreateDate.VisibleIndex = 8;
            this.gc_LastUpdateUser.Caption = "修改人";
            this.gc_LastUpdateUser.Name = "gc_LastUpdateUser";
            this.gc_LastUpdateUser.FieldName = "LastUpdateUser";
            this.gc_LastUpdateUser.Visible = true;
            this.gc_LastUpdateUser.VisibleIndex = 9;
            this.gc_LastUpdateDate.Caption = "修改日期";
            this.gc_LastUpdateDate.Name = "gc_LastUpdateDate";
            this.gc_LastUpdateDate.FieldName = "LastUpdateDate";
            this.gc_LastUpdateDate.Visible = true;
            this.gc_LastUpdateDate.VisibleIndex = 10;

            // 
            // LC_Search
            // 
            this.LC_Search.Controls.Add(this.txts_IsLock);
            this.LC_Search.Controls.Add(this.txts_IsAdmain);
            this.LC_Search.Controls.Add(this.txts_Email);
            this.LC_Search.Controls.Add(this.txts_Phone);
            this.LC_Search.Controls.Add(this.txts_UserName);
            this.LC_Search.Controls.Add(this.txts_Password);
            this.LC_Search.Controls.Add(this.txts_Account);

            this.LC_Search.Dock = System.Windows.Forms.DockStyle.Left;
            this.LC_Search.Location = new System.Drawing.Point(2, 2);
            this.LC_Search.Name = "LC_Search";
            this.LC_Search.Root = this.LCGroup_Search;
            this.LC_Search.Size = new System.Drawing.Size(661, 70);
            this.LC_Search.TabIndex = 0;
            this.LC_Search.Text = "layoutControl1";
            // 
            // LCGroup_Search
            // 
            this.LCGroup_Search.AppearanceItemCaption.Options.UseTextOptions = true;
            this.LCGroup_Search.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.LCGroup_Search.CustomizationFormText = "LCGroup_Search";
            this.LCGroup_Search.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.LCGroup_Search.GroupBordersVisible = false;
            this.LCGroup_Search.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
						this.LCItems_Account,
			this.LCItems_Password,
			this.LCItems_UserName,
			this.LCItems_Phone,
			this.LCItems_Email,
			this.LCItems_IsAdmain,
			this.LCItems_IsLock,});

            this.LCGroup_Search.Location = new System.Drawing.Point(0, 0);
            this.LCGroup_Search.Name = "LCGroup_Search";
            this.LCGroup_Search.Size = new System.Drawing.Size(240, 70);
            this.LCGroup_Search.Text = "LCGroup_Search";
            this.LCGroup_Search.TextVisible = false;

            this.txts_Account.Properties.MaxLength = 20;
            this.txts_Account.Properties.ValidateOnEnterKey = true;
            this.txts_Account.StyleController = this.LC_Search;
            this.txts_Account.Name = "txts_Account";
            this.txts_Password.Properties.MaxLength = 200;
            this.txts_Password.Properties.ValidateOnEnterKey = true;
            this.txts_Password.StyleController = this.LC_Search;
            this.txts_Password.Name = "txts_Password";
            this.txts_UserName.Properties.MaxLength = 40;
            this.txts_UserName.Properties.ValidateOnEnterKey = true;
            this.txts_UserName.StyleController = this.LC_Search;
            this.txts_UserName.Name = "txts_UserName";
            this.txts_Phone.Properties.MaxLength = 20;
            this.txts_Phone.Properties.ValidateOnEnterKey = true;
            this.txts_Phone.StyleController = this.LC_Search;
            this.txts_Phone.Name = "txts_Phone";
            this.txts_Email.Properties.MaxLength = 400;
            this.txts_Email.Properties.ValidateOnEnterKey = true;
            this.txts_Email.StyleController = this.LC_Search;
            this.txts_Email.Name = "txts_Email";
            this.txts_IsAdmain.Properties.MaxLength = 1;
            this.txts_IsAdmain.Properties.ValidateOnEnterKey = true;
            this.txts_IsAdmain.StyleController = this.LC_Search;
            this.txts_IsAdmain.Name = "txts_IsAdmain";
            this.txts_IsLock.Properties.MaxLength = 1;
            this.txts_IsLock.Properties.ValidateOnEnterKey = true;
            this.txts_IsLock.StyleController = this.LC_Search;
            this.txts_IsLock.Name = "txts_IsLock";


            this.LCItems_Account.Control = this.txts_Account;
            this.LCItems_Account.CustomizationFormText = "账号";
            this.LCItems_Account.Location = new System.Drawing.Point(0, 0);
            this.LCItems_Account.Name = "LCItem_Account";
            this.LCItems_Account.Size = new System.Drawing.Size(160, 24);
            this.LCItems_Account.Text = "账号";
            this.LCItems_Account.TextSize = new System.Drawing.Size(36, 14);
            this.LCItems_Password.Control = this.txts_Password;
            this.LCItems_Password.CustomizationFormText = "密码";
            this.LCItems_Password.Location = new System.Drawing.Point(160, 0);
            this.LCItems_Password.Name = "LCItem_Password";
            this.LCItems_Password.Size = new System.Drawing.Size(160, 24);
            this.LCItems_Password.Text = "密码";
            this.LCItems_Password.TextSize = new System.Drawing.Size(36, 14);
            this.LCItems_UserName.Control = this.txts_UserName;
            this.LCItems_UserName.CustomizationFormText = "名称";
            this.LCItems_UserName.Location = new System.Drawing.Point(320, 0);
            this.LCItems_UserName.Name = "LCItem_UserName";
            this.LCItems_UserName.Size = new System.Drawing.Size(160, 24);
            this.LCItems_UserName.Text = "名称";
            this.LCItems_UserName.TextSize = new System.Drawing.Size(36, 14);
            this.LCItems_Phone.Control = this.txts_Phone;
            this.LCItems_Phone.CustomizationFormText = "电话";
            this.LCItems_Phone.Location = new System.Drawing.Point(480, 0);
            this.LCItems_Phone.Name = "LCItem_Phone";
            this.LCItems_Phone.Size = new System.Drawing.Size(160, 24);
            this.LCItems_Phone.Text = "电话";
            this.LCItems_Phone.TextSize = new System.Drawing.Size(36, 14);
            this.LCItems_Email.Control = this.txts_Email;
            this.LCItems_Email.CustomizationFormText = "Email";
            this.LCItems_Email.Location = new System.Drawing.Point(0, 24);
            this.LCItems_Email.Name = "LCItem_Email";
            this.LCItems_Email.Size = new System.Drawing.Size(160, 24);
            this.LCItems_Email.Text = "Email";
            this.LCItems_Email.TextSize = new System.Drawing.Size(36, 14);
            this.LCItems_IsAdmain.Control = this.txts_IsAdmain;
            this.LCItems_IsAdmain.CustomizationFormText = "是否是管理员";
            this.LCItems_IsAdmain.Location = new System.Drawing.Point(160, 24);
            this.LCItems_IsAdmain.Name = "LCItem_IsAdmain";
            this.LCItems_IsAdmain.Size = new System.Drawing.Size(160, 24);
            this.LCItems_IsAdmain.Text = "是否是管理员";
            this.LCItems_IsAdmain.TextSize = new System.Drawing.Size(36, 14);
            this.LCItems_IsLock.Control = this.txts_IsLock;
            this.LCItems_IsLock.CustomizationFormText = "锁定";
            this.LCItems_IsLock.Location = new System.Drawing.Point(320, 24);
            this.LCItems_IsLock.Name = "LCItem_IsLock";
            this.LCItems_IsLock.Size = new System.Drawing.Size(160, 24);
            this.LCItems_IsLock.Text = "锁定";
            this.LCItems_IsLock.TextSize = new System.Drawing.Size(36, 14);


            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(665, 17);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 41);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "查找";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(764, 17);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 41);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "清空";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // LC_Edit
            // 
            this.LC_Edit.Controls.Add(this.txtLastUpdateDate);
            this.LC_Edit.Controls.Add(this.txtLastUpdateUser);
            this.LC_Edit.Controls.Add(this.txtCreateDate);
            this.LC_Edit.Controls.Add(this.txtCreateUser);
            this.LC_Edit.Controls.Add(this.txtIsLock);
            this.LC_Edit.Controls.Add(this.txtIsAdmain);
            this.LC_Edit.Controls.Add(this.txtEmail);
            this.LC_Edit.Controls.Add(this.txtPhone);
            this.LC_Edit.Controls.Add(this.txtUserName);
            this.LC_Edit.Controls.Add(this.txtPassword);
            this.LC_Edit.Controls.Add(this.txtAccount);

            this.LC_Edit.Location = new System.Drawing.Point(5, 5);
            this.LC_Edit.Name = "LC_Edit";
            this.LC_Edit.Root = this.LCGroup_Edit;
            this.LC_Edit.Size = new System.Drawing.Size(661, 120);
            this.LC_Edit.TabIndex = 0;
            this.LC_Edit.Text = "layoutControl1";

            this.txtAccount.Properties.MaxLength = 20;
            this.txtAccount.Properties.ValidateOnEnterKey = true;
            this.txtAccount.StyleController = this.LC_Edit;
            this.txtAccount.Name = "txtAccount";
            this.txtPassword.Properties.MaxLength = 200;
            this.txtPassword.Properties.ValidateOnEnterKey = true;
            this.txtPassword.StyleController = this.LC_Edit;
            this.txtPassword.Name = "txtPassword";
            this.txtUserName.Properties.MaxLength = 40;
            this.txtUserName.Properties.ValidateOnEnterKey = true;
            this.txtUserName.StyleController = this.LC_Edit;
            this.txtUserName.Name = "txtUserName";
            this.txtPhone.Properties.MaxLength = 20;
            this.txtPhone.Properties.ValidateOnEnterKey = true;
            this.txtPhone.StyleController = this.LC_Edit;
            this.txtPhone.Name = "txtPhone";
            this.txtEmail.Properties.MaxLength = 400;
            this.txtEmail.Properties.ValidateOnEnterKey = true;
            this.txtEmail.StyleController = this.LC_Edit;
            this.txtEmail.Name = "txtEmail";
            this.txtIsAdmain.EditValue = null;
            this.txtIsAdmain.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.txtIsAdmain.Properties.Caption = "是否是管理员";
            this.txtIsAdmain.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.txtIsAdmain.Properties.ValueChecked = "Y";
            this.txtIsAdmain.Properties.ValueUnchecked = "N";
            this.txtIsAdmain.StyleController = this.LC_Edit;
            this.txtIsAdmain.Name = "txtIsAdmain";
            this.txtIsLock.EditValue = null;
            this.txtIsLock.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.txtIsLock.Properties.Caption = "锁定";
            this.txtIsLock.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.txtIsLock.Properties.ValueChecked = "Y";
            this.txtIsLock.Properties.ValueUnchecked = "N";
            this.txtIsLock.StyleController = this.LC_Edit;
            this.txtIsLock.Name = "txtIsLock";
            this.txtCreateUser.Properties.MaxLength = 20;
            this.txtCreateUser.Properties.ValidateOnEnterKey = true;
            this.txtCreateUser.StyleController = this.LC_Edit;
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateDate.EditValue = null;
            this.txtCreateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCreateDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCreateDate.Properties.MaxValue = new System.DateTime(2200, 1, 1, 0, 0, 0, 0);
            this.txtCreateDate.Properties.MinValue = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txtCreateDate.Properties.ValidateOnEnterKey = true;
            this.txtCreateDate.StyleController = this.LC_Edit;
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtLastUpdateUser.Properties.MaxLength = 20;
            this.txtLastUpdateUser.Properties.ValidateOnEnterKey = true;
            this.txtLastUpdateUser.StyleController = this.LC_Edit;
            this.txtLastUpdateUser.Name = "txtLastUpdateUser";
            this.txtLastUpdateDate.EditValue = null;
            this.txtLastUpdateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtLastUpdateDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtLastUpdateDate.Properties.MaxValue = new System.DateTime(2200, 1, 1, 0, 0, 0, 0);
            this.txtLastUpdateDate.Properties.MinValue = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txtLastUpdateDate.Properties.ValidateOnEnterKey = true;
            this.txtLastUpdateDate.StyleController = this.LC_Edit;
            this.txtLastUpdateDate.Name = "txtLastUpdateDate";

            // 
            // LCGroup_Edit
            // 
            this.LCGroup_Edit.AppearanceItemCaption.Options.UseTextOptions = true;
            this.LCGroup_Edit.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.LCGroup_Edit.CustomizationFormText = "LCGroup_Edit";
            this.LCGroup_Edit.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.LCGroup_Edit.GroupBordersVisible = false;
            this.LCGroup_Edit.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
						this.LCItem_Account,
			this.LCItem_Password,
			this.LCItem_UserName,
			this.LCItem_Phone,
			this.LCItem_Email,
			this.LCItem_IsAdmain,
			this.LCItem_IsLock,
			this.LCItem_CreateUser,
			this.LCItem_CreateDate,
			this.LCItem_LastUpdateUser,
			this.LCItem_LastUpdateDate,});

            this.LCGroup_Edit.Location = new System.Drawing.Point(0, 0);
            this.LCGroup_Edit.Name = "LCGroup_Edit";
            this.LCGroup_Edit.Size = new System.Drawing.Size(661, 579);
            this.LCGroup_Edit.Text = "LCGroup_Edit";
            this.LCGroup_Edit.TextVisible = false;
            this.LCItem_Account.Control = this.txtAccount;
            this.LCItem_Account.CustomizationFormText = "账号";
            this.LCItem_Account.Location = new System.Drawing.Point(0, 0);
            this.LCItem_Account.Name = "LCItem_Account";
            this.LCItem_Account.Size = new System.Drawing.Size(160, 24);
            this.LCItem_Account.Text = "账号";
            this.LCItem_Account.TextSize = new System.Drawing.Size(36, 14);
            this.LCItem_Password.Control = this.txtPassword;
            this.LCItem_Password.CustomizationFormText = "密码";
            this.LCItem_Password.Location = new System.Drawing.Point(160, 0);
            this.LCItem_Password.Name = "LCItem_Password";
            this.LCItem_Password.Size = new System.Drawing.Size(160, 24);
            this.LCItem_Password.Text = "密码";
            this.LCItem_Password.TextSize = new System.Drawing.Size(36, 14);
            this.LCItem_UserName.Control = this.txtUserName;
            this.LCItem_UserName.CustomizationFormText = "名称";
            this.LCItem_UserName.Location = new System.Drawing.Point(320, 0);
            this.LCItem_UserName.Name = "LCItem_UserName";
            this.LCItem_UserName.Size = new System.Drawing.Size(160, 24);
            this.LCItem_UserName.Text = "名称";
            this.LCItem_UserName.TextSize = new System.Drawing.Size(36, 14);
            this.LCItem_Phone.Control = this.txtPhone;
            this.LCItem_Phone.CustomizationFormText = "电话";
            this.LCItem_Phone.Location = new System.Drawing.Point(480, 0);
            this.LCItem_Phone.Name = "LCItem_Phone";
            this.LCItem_Phone.Size = new System.Drawing.Size(160, 24);
            this.LCItem_Phone.Text = "电话";
            this.LCItem_Phone.TextSize = new System.Drawing.Size(36, 14);
            this.LCItem_Email.Control = this.txtEmail;
            this.LCItem_Email.CustomizationFormText = "Email";
            this.LCItem_Email.Location = new System.Drawing.Point(0, 24);
            this.LCItem_Email.Name = "LCItem_Email";
            this.LCItem_Email.Size = new System.Drawing.Size(160, 24);
            this.LCItem_Email.Text = "Email";
            this.LCItem_Email.TextSize = new System.Drawing.Size(36, 14);
            this.LCItem_IsAdmain.Control = this.txtIsAdmain;
            this.LCItem_IsAdmain.CustomizationFormText = "是否是管理员";
            this.LCItem_IsAdmain.Location = new System.Drawing.Point(160, 24);
            this.LCItem_IsAdmain.Name = "LCItem_IsAdmain";
            this.LCItem_IsAdmain.Size = new System.Drawing.Size(160, 24);
            this.LCItem_IsAdmain.Text = "是否是管理员";
            this.LCItem_IsAdmain.TextSize = new System.Drawing.Size(36, 14);
            this.LCItem_IsLock.Control = this.txtIsLock;
            this.LCItem_IsLock.CustomizationFormText = "锁定";
            this.LCItem_IsLock.Location = new System.Drawing.Point(320, 24);
            this.LCItem_IsLock.Name = "LCItem_IsLock";
            this.LCItem_IsLock.Size = new System.Drawing.Size(160, 24);
            this.LCItem_IsLock.Text = "锁定";
            this.LCItem_IsLock.TextSize = new System.Drawing.Size(36, 14);
            this.LCItem_CreateUser.Control = this.txtCreateUser;
            this.LCItem_CreateUser.CustomizationFormText = "创建人";
            this.LCItem_CreateUser.Location = new System.Drawing.Point(480, 24);
            this.LCItem_CreateUser.Name = "LCItem_CreateUser";
            this.LCItem_CreateUser.Size = new System.Drawing.Size(160, 24);
            this.LCItem_CreateUser.Text = "创建人";
            this.LCItem_CreateUser.TextSize = new System.Drawing.Size(36, 14);
            this.LCItem_CreateDate.Control = this.txtCreateDate;
            this.LCItem_CreateDate.CustomizationFormText = "创建日期";
            this.LCItem_CreateDate.Location = new System.Drawing.Point(0, 48);
            this.LCItem_CreateDate.Name = "LCItem_CreateDate";
            this.LCItem_CreateDate.Size = new System.Drawing.Size(160, 24);
            this.LCItem_CreateDate.Text = "创建日期";
            this.LCItem_CreateDate.TextSize = new System.Drawing.Size(36, 14);
            this.LCItem_LastUpdateUser.Control = this.txtLastUpdateUser;
            this.LCItem_LastUpdateUser.CustomizationFormText = "修改人";
            this.LCItem_LastUpdateUser.Location = new System.Drawing.Point(160, 48);
            this.LCItem_LastUpdateUser.Name = "LCItem_LastUpdateUser";
            this.LCItem_LastUpdateUser.Size = new System.Drawing.Size(160, 24);
            this.LCItem_LastUpdateUser.Text = "修改人";
            this.LCItem_LastUpdateUser.TextSize = new System.Drawing.Size(36, 14);
            this.LCItem_LastUpdateDate.Control = this.txtLastUpdateDate;
            this.LCItem_LastUpdateDate.CustomizationFormText = "修改日期";
            this.LCItem_LastUpdateDate.Location = new System.Drawing.Point(320, 48);
            this.LCItem_LastUpdateDate.Name = "LCItem_LastUpdateDate";
            this.LCItem_LastUpdateDate.Size = new System.Drawing.Size(160, 24);
            this.LCItem_LastUpdateDate.Text = "修改日期";
            this.LCItem_LastUpdateDate.TextSize = new System.Drawing.Size(36, 14);

            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 616);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pan_Summary)).EndInit();
            this.pan_Summary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.tp_Search.ResumeLayout(false);
            this.tp_Edit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tc_Data)).EndInit();
            this.tc_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMainData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMainData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LC_Search)).EndInit();
            this.LC_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LCGroup_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LC_Edit)).EndInit();
            this.LC_Edit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LCGroup_Edit)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcMainData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMainData;
        private DevExpress.XtraEditors.SimpleButton btn_Clear;
        private DevExpress.XtraEditors.SimpleButton btn_Search;
        private DevExpress.XtraLayout.LayoutControl LC_Search;

        private DevExpress.XtraLayout.LayoutControlGroup LCGroup_Search;

        private DevExpress.XtraLayout.LayoutControl LC_Edit;

        private DevExpress.XtraLayout.LayoutControlGroup LCGroup_Edit;


        private DevExpress.XtraEditors.TextEdit txtAccount;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_Account;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Account;
        private DevExpress.XtraEditors.TextEdit txts_Account;
        private DevExpress.XtraLayout.LayoutControlItem LCItems_Account;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_Password;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Password;
        private DevExpress.XtraEditors.TextEdit txts_Password;
        private DevExpress.XtraLayout.LayoutControlItem LCItems_Password;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_UserName;
        private DevExpress.XtraGrid.Columns.GridColumn gc_UserName;
        private DevExpress.XtraEditors.TextEdit txts_UserName;
        private DevExpress.XtraLayout.LayoutControlItem LCItems_UserName;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_Phone;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Phone;
        private DevExpress.XtraEditors.TextEdit txts_Phone;
        private DevExpress.XtraLayout.LayoutControlItem LCItems_Phone;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_Email;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Email;
        private DevExpress.XtraEditors.TextEdit txts_Email;
        private DevExpress.XtraLayout.LayoutControlItem LCItems_Email;
        private DevExpress.XtraEditors.CheckEdit txtIsAdmain;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_IsAdmain;
        private DevExpress.XtraGrid.Columns.GridColumn gc_IsAdmain;
        private DevExpress.XtraEditors.TextEdit txts_IsAdmain;
        private DevExpress.XtraLayout.LayoutControlItem LCItems_IsAdmain;
        private DevExpress.XtraEditors.CheckEdit txtIsLock;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_IsLock;
        private DevExpress.XtraGrid.Columns.GridColumn gc_IsLock;
        private DevExpress.XtraEditors.TextEdit txts_IsLock;
        private DevExpress.XtraLayout.LayoutControlItem LCItems_IsLock;
        private DevExpress.XtraEditors.TextEdit txtCreateUser;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_CreateUser;
        private DevExpress.XtraGrid.Columns.GridColumn gc_CreateUser;
        private DevExpress.XtraEditors.DateEdit txtCreateDate;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_CreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn gc_CreateDate;
        private DevExpress.XtraEditors.TextEdit txtLastUpdateUser;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_LastUpdateUser;
        private DevExpress.XtraGrid.Columns.GridColumn gc_LastUpdateUser;
        private DevExpress.XtraEditors.DateEdit txtLastUpdateDate;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_LastUpdateDate;
        private DevExpress.XtraGrid.Columns.GridColumn gc_LastUpdateDate;


    }
}