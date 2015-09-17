CREATE TABLE [dbo].[sys_DataSN](
	[isid] [int] IDENTITY(1,1) NOT NULL,
	[DataCode] [varchar](10) NOT NULL,
	[Length] [int] NOT NULL,
	[MaxID] [int] NULL,
 CONSTRAINT [PK_SYS_DATASN] PRIMARY KEY CLUSTERED 
(
	[DataCode] ASC,
	[Length] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'自增字段' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_DataSN', @level2type=N'COLUMN',@level2name=N'isid'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单据标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_DataSN', @level2type=N'COLUMN',@level2name=N'DataCode'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'长度' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_DataSN', @level2type=N'COLUMN',@level2name=N'Length'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最大号码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_DataSN', @level2type=N'COLUMN',@level2name=N'MaxID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单据号码表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sys_DataSN'
GO



create procedure [dbo].[sys_GetDataSN] 
    @DataCode VARCHAR(10),
    @Length INT =4 --预设4位长度 
AS
BEGIN
/*-------------------------------------------------------------------------------------
  程序说明:返回单据号码
  返回结果:MAX_NO
  -------------------------------------------------------------------------------------
--delete FROM sys_DataSN
select FROM sys_DataSN

---测试--------

sys_GetDataSN 'BANK','Y'
sys_GetDataSN 'DEPT','Y' 
sys_GetDataSN 'GGX','Y' 
sys_GetDataSN 'A',4 
sys_GetDataSN 'A',5 

sys_GetDataSN 'A02-A-','Y' 
sys_GetDataSN 'A02-B-','Y' 

sys_GetDataSN 'CS','N',6 

-------------------------------------------------------------------------------------*/
	DECLARE @Value INT,@RetValue VARCHAR(50)

	SELECT @Value=MaxID FROM sys_DataSN WHERE DataCode=@DataCode AND [Length]=@Length

	IF (@Value IS NULL)
	BEGIN
	    SELECT @Value=0
		INSERT INTO sys_DataSN(DataCode,[Length],MaxID) 
		VALUES (@DataCode,@Length,0)
	END


	SET @Value=ISNULL(@Value,0)+1 /*取最大值+1,为返回的流水号,过滤掉带4的号码*/

	WHILE(CHARINDEX('4',@Value)>0)
	BEGIN
		SET @Value=@Value+1
	END
	WHILE(CHARINDEX('47',@Value)>0)/*过滤掉带47的号码*/
	BEGIN
		SET @Value=@Value+1
	END
	
	UPDATE sys_DataSN SET MaxID=@Value WHERE DataCode=@DataCode AND [Length]=@Length /*更新流水号*/

	SET @RetValue=RIGHT(REPLACE(SPACE(@Length),' ','0')+CAST(@Value AS VARCHAR),@Length)	

	SELECT @RetValue AS MAX_NO
  -----------------------------------------END--------------------------------------------
END

GO


