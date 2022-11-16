CREATE TABLE [dbo].[Define_MST]
(
	[InternalID]   UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	[Section]      VARCHAR(30)      NOT NULL,
	[Name]         VARCHAR(30)      NOT NULL,
	[Value]        VARCHAR(30)      NOT NULL,
	[Description]  VARCHAR(30)      NULL,
	--Common Columns in Tables
	[Status]       INT              NOT NULL,
	[CreatedDate]  DATETIME         NULL,
	[ModifiedDate] DATETIME         NULL
)
