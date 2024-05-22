--trae todos los datos de la tabla
SELECT * FROM Users
--Medics
INSERT INTO Users VALUES(
,'La Maquina'
, 'Julian'
, 'Jasarevic'
,'j@j.com'
,'holahola'
,GETDATE()
,GETDATE()
,1
)
--Admins
INSERT INTO Users VALUES(
'Admin'
, 'Julian'
, 'Jasarevic'
, 40767314
,'j@j.com'
,'1'
,'ADMINISTRADOR'
,1
,GETDATE()
,GETDATE()

)

--Cambia la clave, cambia la fecha de modificación , actualiza el cambiar clave
UPDATE Usuarios SET
CLAVE = 'jogadinha',  
UpdateUp = getdate(),
cambiarclave = 0
WHERE id = 2


DELETE FROM Users WHERE id = 2