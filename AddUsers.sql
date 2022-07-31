CREATE PROCEDURE [dbo].AddUsers
	@Username nvarchar(50),
	@Password nvarchar(50),
	@Games bingint
AS
BEGIN
	INSERT INTO Users (Username, Password, Games) VALUES (@Ussername, @Password, 0)
END