USE GD1C2019
GO

CREATE FUNCTION mavema_pie.func_login (@username NVARCHAR(50),@pass NVARCHAR(50))
RETURNS int
AS 
BEGIN
    DECLARE @pass_enc varbinary(256);
	DECLARE @valor int;
	BEGIN
		SELECT @pass_enc = HASHBYTES('SHA2_256', @pass);
	END

	SELECT @valor = 1
	FROM mavema_pie.login
	WHERE logi_username = @username and logi_password = @pass_enc and logi_activo = 1;

	if (@VALOR IS NULL)
	begin
		SET @valor = 0;
	end

	return @valor;
END

