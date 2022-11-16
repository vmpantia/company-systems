--Created By: Vincent M. Pantia
--Created Date: 20220623
--Description: Get New RequestID from Request Table

CREATE PROCEDURE [dbo].[GetNewRequestID]
AS
BEGIN
	--Get Date Today (ex: 20220101)
	DECLARE @DateToday VARCHAR(8) = FORMAT(GETDATE(), 'yyyyMMdd')
	DECLARE @No INT = 1
	DECLARE @NewRequestID VARCHAR(15)
	DECLARE @LatestRequestID VARCHAR(15)

	--If the Request Table is Empty set @No to 0
	IF ((SELECT COUNT(*) FROM Request_LST) > 0)
	BEGIN
		SET @LatestRequestID = (SELECT TOP 1 RequestID FROM Request_LST ORDER BY RequestID DESC)
		SET @No = @LatestRequestID + 1
	END
	
	--Get New RequestID
	SET @NewRequestID = CONCAT(@DateToday, FORMAT(@No, '0000000'))

	SELECT @NewRequestID
END



