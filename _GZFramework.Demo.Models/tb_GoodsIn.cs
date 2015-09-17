/**************************************************************************
    ====================GZFramwork【Winfrom快速开发框架】====================
	-- 作者：Garson_Zhang  QQ：382237285  QQ交流群：288706356
    -- 博客地址:http://www.cnblogs.com/GarsonZhang/
 
	-- CLR版本： 4.0.30319.42000
	-- 创建时间：2015-09-17 10:52:26
	-- 创建年月：2015
**************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GZFramework.DB.ModelAttribute;

namespace _GZFramework.Demo.Models
{

    /// <summary>
    /// ORM模型, 数据表:tb_GoodsInDetail
    /// GZFrameworkCodeGenerate代码生成器自动生成
    /// 时间：2015-09-17 10:52
    /// </summary>
    [ModelStruct(tb_GoodsInDetail._TableName)]
    public sealed class tb_GoodsInDetail
    {
        public const string _TableName = "tb_GoodsInDetail";

        /// <summary>
        /// 自增字段
        /// </summary>
        [ModelPrimaryKey]
        public const string isid = "isid";

        /// <summary>
        /// 单据号码
        /// </summary>
        [ModelForeignKey]
        public const string DocNo = "DocNo";

        /// <summary>
        /// 时间戳
        /// </summary>
        [ModelRowversion]
        public const string rowversion = "rowversion";

        /// <summary>
        /// 商品编号
        /// </summary>
        [ModelEditField]
        public const string GoodsID = "GoodsID";

        /// <summary>
        /// 商品名称
        /// </summary>
        [ModelEditField]
        public const string GoodsName = "GoodsName";

        /// <summary>
        /// 存放仓库
        /// </summary>
        [ModelEditField]
        public const string SID = "SID";

        /// <summary>
        /// 存放仓位
        /// </summary>
        [ModelEditField]
        public const string AID = "AID";

        /// <summary>
        /// 数量
        /// </summary>
        [ModelEditField]
        public const string Qty = "Qty";

        /// <summary>
        /// 备注
        /// </summary>
        [ModelEditField]
        public const string Remark = "Remark";

        /// <summary>
        /// 创建人
        /// </summary>
        [ModelEditField]
        public const string CreateUser = "CreateUser";

        /// <summary>
        /// 创建日期
        /// </summary>
        [ModelEditField]
        public const string CreateDate = "CreateDate";

        /// <summary>
        /// 修改人
        /// </summary>
        [ModelEditField]
        public const string LastUpdateUser = "LastUpdateUser";

        /// <summary>
        /// 修改日期
        /// </summary>
        [ModelEditField]
        public const string LastUpdateDate = "LastUpdateDate";

    }


    /// <summary>
    /// ORM模型, 数据表:tb_GoodsIn
    /// GZFrameworkCodeGenerate代码生成器自动生成
    /// 时间：2015-09-17 10:52
    /// </summary>
    [ModelStruct(tb_GoodsIn._TableName)]
    public sealed class tb_GoodsIn
    {
        public const string _TableName = "tb_GoodsIn";

        /// <summary>
        /// 自增字段
        /// </summary>
        public const string isid = "isid";

        /// <summary>
        /// 时间戳
        /// </summary>
        [ModelRowversion]
        public const string rowversion = "rowversion";

        /// <summary>
        /// 单据号码
        /// </summary>
        [ModelPrimaryKey]
        public const string DocNo = "DocNo";

        /// <summary>
        /// 入库日期
        /// </summary>
        [ModelEditField]
        public const string DocDate = "DocDate";

        /// <summary>
        /// 入库人
        /// </summary>
        [ModelEditField]
        public const string OperationUser = "OperationUser";

        /// <summary>
        /// 供应商
        /// </summary>
        [ModelEditField]
        public const string Supplier = "Supplier";

        /// <summary>
        /// 种类
        /// </summary>
        [ModelEditField]
        public const string GoodsType = "GoodsType";

        /// <summary>
        /// 备注
        /// </summary>
        [ModelEditField]
        public const string Remark = "Remark";

        /// <summary>
        /// 创建人
        /// </summary>
        [ModelEditField]
        public const string CreateUser = "CreateUser";

        /// <summary>
        /// 创建日期
        /// </summary>
        [ModelEditField]
        public const string CreateDate = "CreateDate";

        /// <summary>
        /// 修改人
        /// </summary>
        [ModelEditField]
        public const string LastUpdateUser = "LastUpdateUser";

        /// <summary>
        /// 修改日期
        /// </summary>
        [ModelEditField]
        public const string LastUpdateDate = "LastUpdateDate";

    }



}
