# distributor

Take a look to Third-party_licenses.md to see the third-party licenses :+1:

[School essay link](http://tesine.marconirovereto.it/dettagli.html?2016.5BI.9)
<br /><br />

## Purpose

This is a system to record, manage, and optimize the distribution of any type of magazine to a newsstand network. By using a C# software the user can easily manage, through an user interface, the _database_ and adding fields or query it. The user can add distributors, newsstands, magazines, and create tasks for distribute or recover magazines, all through UI. It also provide to invoice the sold magazines.

##How it works

- **Database _db.sql_**
  _db.sql_ is the database, it include tables, relations and data.

- **_db.dll_ library**
  _db.dll_ develop specifics functions to manage this specific database, like procedure executions, queries, and stored functions executions. _db.dll_ use _MySql.Data.dll_, an official library that provides methods and functions to connect to a MySQL database.

- **_dbinterface.exe_ - Windows form interface**
  _dbinterface.exe_ is C# software which interfaces with _db.dll_ library, that provides an User Interface that make the database "Human-Usable".

##Used technologies

*   MySQL
*   Visual Studio (C# solution )
*   GIT (version control system)

>Work in develop...
