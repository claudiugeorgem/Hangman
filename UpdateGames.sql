CREATE PROCEDURE [dbo].UpdateGames
	@Username nvarchar(50),
	@Password nvarchar(50),
	@Games bingint
AS
BEGIN
	UPDATE Users SET Games=@Games WHERE Username=@Username AND Password=@Password
END