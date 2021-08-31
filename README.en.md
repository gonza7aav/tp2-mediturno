# tp2-mediturno

<div align='center'>

[Spanish](README.es.md)

</div>

University project for the _Programming Workshop I_, for this reason it's completely in Spanish.

An desktop app for medical appointment management and clinical history with an user system built-in. It was developed in _C#_ with _WinForms_, _Entity Framework_, _SQL Server_, and _RDLC Report Designer_ following a three-tier architecture. You can find attached the [Software Requirements Specification](SRS.md) of the project.

## 🚧 Prerequisites

- _[.NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472)_
- _[SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)_

## 🛠️ Install

1. Download the [final release](https://github.com/gonza7aav/tp2-mediturno/releases)

2. Create the database running the file `database/DB_MediTurno.sql` in _SQL Server_

3. Run every script inside `database/StoredProcedures`

4. Install the app running `setup.exe`

## 🚀 Usage

It is necessary that the _SQL Server_ service is running

### 🔑 Login

| Profile     | Username |
| ----------- | -------- |
| Super Admin | sup      |
| Admin       | adm      |
| Manager     | ger      |
| Medic       | med      |
| Clerk       | sec      |

(\*) For demo's simplicity, all password are "12345678"

## 📝 License

Copyright © 2020 _Aguirre Gonzalo Adolfo_.
This project is _[MIT](LICENSE)_ licensed
