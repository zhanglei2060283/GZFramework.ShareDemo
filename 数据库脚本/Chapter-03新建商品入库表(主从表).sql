if exists (select 1
            from  sysobjects
           where  id = object_id('tb_GoodsIn')
            and   type = 'U')
   drop table tb_GoodsIn
go

/*==============================================================*/
/* Table: tb_GoodsIn                                            */
/*==============================================================*/
create table tb_GoodsIn (
   isid                 int                  identity,
   rowversion           timestamp            null,
   DocNo                varchar(20)          not null,
   DocDate              datetime             null,
   OperationUser        varchar(20)          null,
   Supplier             nvarchar(50)         null,
   GoodsType            varchar(10)          null,
   Remark               nvarchar(200)        null,
   CreateUser           varchar(20)          null,
   CreateDate           datetime             null,
   LastUpdateUser       varchar(20)          null,
   LastUpdateDate       datetime             null,
   constraint PK_TB_GOODSIN primary key (DocNo)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('tb_GoodsIn') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'tb_GoodsIn' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   '商品入库', 
   'user', @CurrentUser, 'table', 'tb_GoodsIn'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('tb_GoodsIn')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'isid')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'tb_GoodsIn', 'column', 'isid'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '自增字段',
   'user', @CurrentUser, 'table', 'tb_GoodsIn', 'column', 'isid'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('tb_GoodsIn')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'rowversion')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'tb_GoodsIn', 'column', 'rowversion'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '时间戳',
   'user', @CurrentUser, 'table', 'tb_GoodsIn', 'column', 'rowversion'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('tb_GoodsIn')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'DocNo')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'tb_GoodsIn', 'column', 'DocNo'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '单据号码',
   'user', @CurrentUser, 'table', 'tb_GoodsIn', 'column', 'DocNo'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('tb_GoodsIn')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'DocDate')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'tb_GoodsIn', 'column', 'DocDate'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '入库日期',
   'user', @CurrentUser, 'table', 'tb_GoodsIn', 'column', 'DocDate'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('tb_GoodsIn')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'OperationUser')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'tb_GoodsIn', 'column', 'OperationUser'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '入库人',
   'user', @CurrentUser, 'table', 'tb_GoodsIn', 'column', 'OperationUser'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('tb_GoodsIn')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Supplier')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'tb_GoodsIn', 'column', 'Supplier'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '供应商',
   'user', @CurrentUser, 'table', 'tb_GoodsIn', 'column', 'Supplier'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('tb_GoodsIn')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'GoodsType')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'tb_GoodsIn', 'column', 'GoodsType'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '种类',
   'user', @CurrentUser, 'table', 'tb_GoodsIn', 'column', 'GoodsType'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('tb_GoodsIn')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Remark')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'tb_GoodsIn', 'column', 'Remark'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '备注',
   'user', @CurrentUser, 'table', 'tb_GoodsIn', 'column', 'Remark'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('tb_GoodsIn')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CreateUser')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'tb_GoodsIn', 'column', 'CreateUser'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '创建人',
   'user', @CurrentUser, 'table', 'tb_GoodsIn', 'column', 'CreateUser'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('tb_GoodsIn')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CreateDate')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'tb_GoodsIn', 'column', 'CreateDate'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '创建日期',
   'user', @CurrentUser, 'table', 'tb_GoodsIn', 'column', 'CreateDate'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('tb_GoodsIn')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LastUpdateUser')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'tb_GoodsIn', 'column', 'LastUpdateUser'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '修改人',
   'user', @CurrentUser, 'table', 'tb_GoodsIn', 'column', 'LastUpdateUser'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('tb_GoodsIn')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LastUpdateDate')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'tb_GoodsIn', 'column', 'LastUpdateDate'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '修改日期',
   'user', @CurrentUser, 'table', 'tb_GoodsIn', 'column', 'LastUpdateDate'
go




if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tb_GoodsInDetail') and o.name = 'FK_TB_GOODS_REFERENCE_TB_GOODS')
alter table tb_GoodsInDetail
   drop constraint FK_TB_GOODS_REFERENCE_TB_GOODS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tb_GoodsInDetail')
            and   type = 'U')
   drop table tb_GoodsInDetail
go

/*==============================================================*/
/* Table: tb_GoodsInDetail                                      */
/*==============================================================*/
create table tb_GoodsInDetail (
   isid                 int                  identity,
   DocNo                varchar(20)          null,
   rowversion           timestamp            null,
   GoodsID              varchar(11)          null,
   GoodsName            nvarchar(50)         null,
   SID                  varchar(20)          null,
   AID                  varchar(20)          null,
   Qty                  int                  null,
   Remark               nvarchar(200)        null,
   CreateUser           varchar(20)          null,
   CreateDate           datetime             null,
   LastUpdateUser       varchar(20)          null,
   LastUpdateDate       datetime             null,
   constraint PK_TB_GOODSINDETAIL primary key (isid)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('tb_GoodsInDetail') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   '商品入库明细', 
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('tb_GoodsInDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'isid')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail', 'column', 'isid'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '自增字段',
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail', 'column', 'isid'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('tb_GoodsInDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'DocNo')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail', 'column', 'DocNo'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '单据号码',
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail', 'column', 'DocNo'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('tb_GoodsInDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'rowversion')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail', 'column', 'rowversion'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '时间戳',
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail', 'column', 'rowversion'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('tb_GoodsInDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'GoodsID')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail', 'column', 'GoodsID'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '商品编号',
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail', 'column', 'GoodsID'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('tb_GoodsInDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'GoodsName')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail', 'column', 'GoodsName'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '商品名称',
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail', 'column', 'GoodsName'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('tb_GoodsInDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'SID')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail', 'column', 'SID'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '存放仓库',
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail', 'column', 'SID'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('tb_GoodsInDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'AID')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail', 'column', 'AID'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '存放仓位',
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail', 'column', 'AID'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('tb_GoodsInDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Qty')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail', 'column', 'Qty'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '数量',
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail', 'column', 'Qty'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('tb_GoodsInDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Remark')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail', 'column', 'Remark'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '备注',
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail', 'column', 'Remark'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('tb_GoodsInDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CreateUser')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail', 'column', 'CreateUser'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '创建人',
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail', 'column', 'CreateUser'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('tb_GoodsInDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CreateDate')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail', 'column', 'CreateDate'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '创建日期',
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail', 'column', 'CreateDate'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('tb_GoodsInDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LastUpdateUser')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail', 'column', 'LastUpdateUser'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '修改人',
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail', 'column', 'LastUpdateUser'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('tb_GoodsInDetail')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'LastUpdateDate')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail', 'column', 'LastUpdateDate'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '修改日期',
   'user', @CurrentUser, 'table', 'tb_GoodsInDetail', 'column', 'LastUpdateDate'
go

alter table tb_GoodsInDetail
   add constraint FK_TB_GOODS_REFERENCE_TB_GOODS foreign key (DocNo)
      references tb_GoodsIn (DocNo)
go
