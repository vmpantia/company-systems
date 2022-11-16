CREATE TABLE [dbo].[Request_LST]
(
	[RequestID]    VARCHAR(15)      NOT NULL PRIMARY KEY,
	[FunctionID]   VARCHAR(6)       NOT NULL,
	--Common Columns in Tables
	[Status]       VARCHAR(2)       NOT NULL,
	[CreatedDate]  DATETIME         NULL,
	[CreatedBy]    UNIQUEIDENTIFIER NULL,
	[ModifiedDate] DATETIME         NULL,
	[ModifiedBy]   UNIQUEIDENTIFIER NULL,
	[ApprovedDate] DATETIME         NULL,
	[ApprovedBy]   UNIQUEIDENTIFIER NULL
)
