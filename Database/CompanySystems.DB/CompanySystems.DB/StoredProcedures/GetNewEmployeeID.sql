--Created By: Vincent M. Pantia
--Created Date: 20220623
--Description: Get New Employee from Employee Table

CREATE PROCEDURE [dbo].[GetNewEmployeeID]
AS
BEGIN
	--Get Date Today (ex: 202201)
	DECLARE @DateToday VARCHAR(6) = FORMAT(GETDATE(), 'yyyyMM')
	DECLARE @No INT = 1
	DECLARE @NewEmployeeID VARCHAR(15)
	DECLARE @LatestEmployeeID VARCHAR(15)

	--If the Employee Table is Empty set @No to 0
	IF ((SELECT COUNT(*) FROM Employee_MST) > 0)
	BEGIN
		SET @LatestEmployeeID = (SELECT TOP 1 EmployeeID FROM Employee_MST ORDER BY EmployeeID DESC)
		SET @No = @LatestEmployeeID + 1
	END
	
	--Get New EmployeeID
	SET @NewEmployeeID = CONCAT('EMP', @DateToday, FORMAT(@No, '000000'))

	SELECT @NewEmployeeID
END



