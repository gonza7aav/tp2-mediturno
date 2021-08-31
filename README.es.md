# tp2-mediturno

<div align='center'>

[Inglés](README.en.md)

</div>

Proyecto universitario presentado para la cátedra _Taller de Programación II_, es por ese motivo que se encuentra completamente en español.

Una aplicación de escritorio de gestión turnos e historial médico con un sistema integrado de usuarios. Fue desarrollado en _C#_ con uso de _WinForms_, _Entity Framework_, _SQL Server_, y _RDLC Report Designer_ siguiendo una arquitectura de tres capas. Se puede encontrar adjunto la [Especificación de requerimientos](SRS.md) del proyecto.

## 🚧 Requisitos

- _[.NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472)_
- _[SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)_

## 🛠️ Instalación

1. Descargar la [release final](https://github.com/gonza7aav/tp2-mediturno/releases)

2. Crear la base de datos ejecutando el archivo `database/DB_MediTurno.sql` en _SQL Server_

3. Ejecutar todos los scripts que se encuentran en `database/StoredProcedures`

4. Instalar la aplicación ejecutando `setup.exe`

## 🚀 Ejecución

Es necesario que el servicio de SQL Server este corriendo

### 🔑 Acceso

| Perfil              | Usuario |
| ------------------- | ------- |
| Super Administrador | sup     |
| Administrador       | adm     |
| Gerente             | ger     |
| Médico              | med     |
| Secretario          | sec     |

(\*) Para la sencillez de la demo, todas las contraseñas son "12345678"

## 📝 Licencia

Copyright © 2020 _Aguirre Gonzalo Adolfo_.
Este proyecto se encuentra bajo la licencia _[MIT](LICENSE)_.
