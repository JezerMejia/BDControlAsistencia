SET IDENTITY_INSERT BDSistemaEyS.dbo.Cargo ON;
INSERT INTO BDSistemaEyS.dbo.Cargo (
idCargo, nombreCargo, descripcionCargo
)
VALUES (
1, 'Diseñador Web', 'Diseña webs increíbles'
);
SET IDENTITY_INSERT BDSistemaEyS.dbo.Cargo OFF;
GO

SET IDENTITY_INSERT BDSistemaEyS.dbo.Departamento ON;
INSERT INTO BDSistemaEyS.dbo.Departamento (
idDepartamento, nombreDepartamento, descripcionDepartamento,
extensionDepartamento
)
VALUES (
1, 'Diseño', 'Departamento enfocado en el diseño.',
'336'
);
SET IDENTITY_INSERT BDSistemaEyS.dbo.Departamento OFF;
GO

SET IDENTITY_INSERT BDSistemaEyS.dbo.Horario ON;
INSERT INTO BDSistemaEyS.dbo.Horario (
idHorario, nombreHorario,
lunesInicio, lunesSalida,
martesInicio, martesSalida,
miercolesInicio, miercolesSalida,
juevesInicio, juevesSalida,
viernesInicio, viernesSalida,
sabadoInicio, sabadoSalida,
domingoInicio, domingoSalida
)
VALUES (
1, 'Horario común (8AM-5PM)',
'8:00', '17:00',
'8:00', '17:00',
'8:00', '17:00',
'8:00', '17:00',
'8:00', '17:00',
'8:00', '12:00',
'8:00', '12:00'
);
SET IDENTITY_INSERT BDSistemaEyS.dbo.Horario OFF;
GO

SET IDENTITY_INSERT BDSistemaEyS.dbo.Empleado ON;
INSERT INTO BDSistemaEyS.dbo.Empleado (
idEmpleado, primerNombre, segundoNombre,
primerApellido, segundoApellido, fechaIngreso,
pinEmpleado, cedulaEmpleado, emailPersonal,
emailEmpresarial, telefonoEmpleado,
idCargo, idDepartamento, idHorario
)
VALUES (
29812, 'Juan', 'Ezequiel',
'Pérez', 'Jiménez', '2022-04-29',
'1212', '0010405021900A', 'juan.ezequiel@gmail.com',
NULL, '98129023',
1, 1, 1
);
SET IDENTITY_INSERT BDSistemaEyS.dbo.Empleado OFF;
GO

INSERT INTO BDSistemaEyS.dbo.Asistencia (
fechaAsistencia, HoraEntrada, horaSalida, idEmpleado
)
VALUES (
'2022-04-30', '8:10', '13:45',
29812
);
GO