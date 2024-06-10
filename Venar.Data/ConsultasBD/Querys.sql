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




SELECT * FROM Admins
--INSERTAR UN ADMINISTRADOR A LA BASE DE DATOS (cambiar valores)

--1. Insertar el nuevo usuario en la tabla Users
INSERT INTO [dbo].[Users] (UserName, Password, UserType, Mail)
VALUES ('admin', '1', 'ADMIN', 'jjasarevic@iiconcepcion.edu.ar');

--2. Declarar una variable para almacenar el UserId del nuevo usuario
DECLARE @UserId INT;

--3. Obtener el UserId del usuario recién creado
SELECT @UserId = UserId FROM [dbo].[Users] WHERE UserName = 'admin';

--4. Insertar el nuevo administrador en la tabla Admins
INSERT INTO [dbo].[Admins] (UserId, Name, LastName, Dni, Mail, UserType, CreatedAt, UpdatedAt)
VALUES (@UserId, 'Julian', 'Jasarevic', '40767314', 'jjasarevic@iiconcepcion.edu.ar', 'ADMIN', GETDATE(), GETDATE());

------------------------------------------
--INSERTAR UN MEDICO A LA BASE DE DATOS (cambiar valores)
-- Insertar el nuevo usuario en la tabla Users
INSERT INTO [dbo].[Users] (UserName, Password, UserType, Email)
VALUES ('medicUserName', 'hashedPassword', 'MEDIC', 'medic@example.com');

-- Declarar una variable para almacenar el UserId del nuevo usuario
DECLARE @UserId INT;

-- Obtener el UserId del usuario recién creado
SELECT @UserId = UserId FROM [dbo].[Users] WHERE UserName = 'medicUserName';

-- Insertar el nuevo médico en la tabla Medics
INSERT INTO [dbo].[Medics] (UserId, Name, LastName, Dni, Mail, Specialty, MedicalRegistration, CreatedAt, UpdatedAt)
VALUES (@UserId, 'MedicFirstName', 'MedicLastName', '87654321', 'medic@example.com', 'Cardiology', '12345', GETDATE(), GETDATE());









