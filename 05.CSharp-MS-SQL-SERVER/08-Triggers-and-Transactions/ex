--01-Creat-Tabl-Logs
CREATE TRIGGER tr_AddToLogsOnAccountUpdate
ON [Accounts] FOR UPDATE
AS
INSERT INTO [Logs] VALUES
(
	(SELECT [Id] FROM inserted), 
	(SELECT [Balance] FROM deleted), 
	(SELECT [Balance] FROM inserted)
)

--02-Create-Table-Emails
CREATE TRIGGER tr_CreateNewEmailOnNewLogEntry
ON [Logs] FOR INSERT
AS
INSERT INTO [NotificationEmails] VALUES
(
	(SELECT [AccountId] FROM inserted),
	(SELECT 'Balance change for account: ' + CAST([AccountId] AS VARCHAR(255)) FROM inserted),
	(SELECT 'On ' + 
			FORMAT(GETDATE(), 'MMM dd yyyy h:mmtt') + 
			' your balance was changed from ' + 
			CAST([OldSum] AS VARCHAR(255)) + 
			' to ' + 
			CAST([NewSum] AS VARCHAR(255)) + 
			'.' 
	FROM inserted)
)

--03-Deposit-Money
CREATE PROC usp_DepositMoney
(@accountId INT, @moneyAmount DECIMAL(18, 4))
AS
	IF (@moneyAmount < 0) THROW 50001, 'Invalid amount', 1
	UPDATE [Accounts]
	SET [Balance] += @moneyAmount
	WHERE [Id] = @accountId
  
--04-Withdraw-Money-Procedure
CREATE PROC usp_WithdrawMoney (@accountId INT, @moneyAmount DECIMAL(15,4))
	AS
	BEGIN TRANSACTION

		DECLARE @isFound INT = (SELECT Id FROM Accounts WHERE Id = @accountId)
		IF (@moneyAmount < 0)	
		BEGIN
		ROLLBACK;
			THROW 51000, 'Invalid MoneyAmout', 1			
		END
		ELSE IF (@isFound IS NULL)
		BEGIN
		ROLLBACK;
			THROW 51001, 'Invalid AccountId', 1				
		END
		ELSE			
		BEGIN
		UPDATE	Accounts
		SET Balance -= @moneyAmount
		WHERE @accountId = Id
		END
		COMMIT

--05-Mone-Transfer
CREATE PROC usp_TransferMoney (@senderId INT, @receiverId INT , @amount DECIMAL (15,4))
	AS
BEGIN TRANSACTION
		
		DECLARE @senderAccount INT = (SELECT id FROM Accounts WHERE @senderId = id)
		DECLARE @senderAccountBalance DECIMAL (15,4) = (SELECT Balance FROM Accounts WHERE @senderId = id)
		DECLARE @recieverAccount INT = (SELECT id FROM Accounts WHERE @receiverId = id)

	 IF (@senderAccount IS NULL)
	 BEGIN
	 ROLLBACK;
		THROW 50001,'Invalid senderAccount', 1
	 END
	 ELSE IF (@recieverAccount IS NULL)
	 BEGIN
	 ROLLBACK;
		THROW 50002,'Invalid recieverAccount', 1	
	 END
	 ELSE IF (@senderAccountBalance IS NULL)	
	 BEGIN
	 ROLLBACK;
		THROW 50003,'Invalid Balance', 1	
	 END
	  ELSE IF (@amount < 0)
	 BEGIN
	 ROLLBACK;
		THROW 50004, 'Ivalid amount of money', 1
	 END

	 UPDATE Accounts
	 SET Balance -= @amount
	 WHERE id = @senderId

	 UPDATE Accounts
	 SET Balance += @amount
	 WHERE id = @receiverId
	 COMMIT

--07-Massive-Shopping
DECLARE @gameName NVARCHAR(50) = 'Safflower'
DECLARE @username NVARCHAR(50) = 'Stamat'

DECLARE @userGameId INT = (
  SELECT ug.Id
  FROM UsersGames AS ug
    JOIN Users AS u
      ON ug.UserId = u.Id
    JOIN Games AS g
      ON ug.GameId = g.Id
  WHERE u.Username = @username AND g.Name = @gameName)

DECLARE @userGameLevel INT = (SELECT Level
                              FROM UsersGames
                              WHERE Id = @userGameId)
DECLARE @itemsCost MONEY, @availableCash MONEY, @minLevel INT, @maxLevel INT

SET @minLevel = 11
SET @maxLevel = 12
SET @availableCash = (SELECT Cash
                      FROM UsersGames
                      WHERE Id = @userGameId)
SET @itemsCost = (SELECT SUM(Price)
                  FROM Items
                  WHERE MinLevel BETWEEN @minLevel AND @maxLevel)

IF (@availableCash >= @itemsCost AND @userGameLevel >= @maxLevel)

  BEGIN
    BEGIN TRANSACTION
    UPDATE UsersGames
    SET Cash -= @itemsCost
    WHERE Id = @userGameId
    IF (@@ROWCOUNT <> 1)
      BEGIN
        ROLLBACK
        RAISERROR ('Could not make payment', 16, 1)
      END
    ELSE
      BEGIN
        INSERT INTO UserGameItems (ItemId, UserGameId)
          (SELECT
             Id,
             @userGameId
           FROM Items
           WHERE MinLevel BETWEEN @minLevel AND @maxLevel)

        IF ((SELECT COUNT(*)
             FROM Items
             WHERE MinLevel BETWEEN @minLevel AND @maxLevel) <> @@ROWCOUNT)
          BEGIN
            ROLLBACK;
            RAISERROR ('Could not buy items', 16, 1)
          END
        ELSE COMMIT;
      END
  END

SET @minLevel = 19
SET @maxLevel = 21
SET @availableCash = (SELECT Cash
                      FROM UsersGames
                      WHERE Id = @userGameId)
SET @itemsCost = (SELECT SUM(Price)
                  FROM Items
                  WHERE MinLevel BETWEEN @minLevel AND @maxLevel)

IF (@availableCash >= @itemsCost AND @userGameLevel >= @maxLevel)

  BEGIN
    BEGIN TRANSACTION
    UPDATE UsersGames
    SET Cash -= @itemsCost
    WHERE Id = @userGameId

    IF (@@ROWCOUNT <> 1)
      BEGIN
        ROLLBACK
        RAISERROR ('Could not make payment', 16, 1)
      END
    ELSE
      BEGIN
        INSERT INTO UserGameItems (ItemId, UserGameId)
          (SELECT
             Id,
             @userGameId
           FROM Items
           WHERE MinLevel BETWEEN @minLevel AND @maxLevel)

        IF ((SELECT COUNT(*)
             FROM Items
             WHERE MinLevel BETWEEN @minLevel AND @maxLevel) <> @@ROWCOUNT)
          BEGIN
            ROLLBACK
            RAISERROR ('Could not buy items', 16, 1)
          END
        ELSE COMMIT;
      END
  END

SELECT i.Name AS [Item Name]
FROM UserGameItems AS ugi
  JOIN Items AS i
    ON i.Id = ugi.ItemId
  JOIN UsersGames AS ug
    ON ug.Id = ugi.UserGameId
  JOIN Games AS g
    ON g.Id = ug.GameId
WHERE g.Name = @gameName
ORDER BY [Item Name]

--08-Employees-with-Three-Projects
CREATE OR ALTER PROCEDURE usp_AssignProject(@employeeId INT, @projectId INT)
AS
BEGIN TRANSACTION
DECLARE @ErrorMessage VARCHAR(35) = 'The employee has too many projects!' 
DECLARE @ErrorSeverity INT = 16
DECLARE @ErrorState INT = 1
 IF((SELECT COUNT(*) 
  FROM EmployeesProjects 
  WHERE EmployeeID = @employeeId)>=3)
    BEGIN
	 RAISERROR (@ErrorMessage, 
               @ErrorSeverity, 
               @ErrorState
               );
	ROLLBACK
	END
 ELSE
   BEGIN
   INSERT INTO EmployeesProjects (EmployeeID,ProjectID)VALUES
   (@employeeId,@projectId)
   END
COMMIT

--09-Delete-Employees
CREATE OR ALTER TRIGGER tr_AddRecordsToDeltedEmployeesTable
ON Employees FOR DELETE
AS
  Insert INTO Deleted_Employees(FirstName,LastName,MiddleName,JobTitle,DepartmentId,Salary)
    SELECT FirstName
	      ,LastName
		  ,MiddleName
		  ,JobTitle
		  ,DepartmentId
		  ,Salary
  FROM deleted
