CREATE TABLE [dbo].[Employee_MST]
(
	[InternalID]            UNIQUEIDENTIFIER  NOT NULL PRIMARY KEY,
	[EmployeeID]            VARCHAR(15)       NOT NULL,
	[FirstName]             VARCHAR(30)       NOT NULL,
	[MiddleName]            VARCHAR(30)       NULL,
	[LastName]              VARCHAR(30)       NOT NULL,
	[BirthDate]             DATETIME          NOT NULL,
	[Gender]                VARCHAR(6)        NOT NULL,
	[CivilStatus]           VARCHAR(9)        NOT NULL,
	--Employment Details    
	[EmployeeStatus]        VARCHAR(15)       NOT NULL,
	[EmployeeType]          VARCHAR(15)       NOT NULL,
	[Department_InternalID] UNIQUEIDENTIFIER  NOT NULL,
	--Common Columns in Tables
	[Status]                INT               NOT NULL,
	[CreatedDate]           DATETIME          NULL,
	[ModifiedDate]          DATETIME          NULL
)
