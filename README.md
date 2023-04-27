# rest_api_shop
ASP.NET Core C# Rest Api - shop

Projekt przedstawia proste REST API wykonane w technologii ASP.NET Core, wykorzystujące ORM EntityFramework,<br />
służące do zarządzania produktami w sklepie.<br /> 
Użytkownik ma możliwość:
- Dodania:  /api/Shop/Add
- Edycji:  /api/Shop/Edit
- Pobrania jednego lub wszystkich produktów z listy:  /api/Shop/GetOne oraz /api/Shop/GetAll
- Usuwania produktów z sklepu: /api/Shop/Delete
<br />

Struktura tabeli bazy danych:
- id
- nazwa produktu
- data utworzenia
- data edycji
- opis artykułu
- cena
<br />

Dane przechowywane są w bazie danych Microsoft SQL Server. <br />
Do utworzenia bazy użyłem EntityFramewor (migracja bazy danych: Add-Migration, Update-Database) <br />
Pliki bazy danych zamiesciłem również w katalogu Baza_pliki. 

--------------------------------------------------------------------

The project presents a simple REST API made in ASP.NET Core technology, using the EntityFramework ORM, <br />
used to manage products in the store. <br />
The user has the option:
- to add: /api/Shop/Add
- to edit /api/Shop/Edit
- Downloading one or all products from the list:  /api/Shop/GetOne and /api/Shop/GetAll
- Removing products from the store: /api/Shop/Delete
<br />

Structure of the database table:
- id
- product name
- creation date
- date of editing
- description
- price
<br />

The data is stored in a Microsoft SQL Server database.<br />
To create the database, I used EntityFramewor (database migration: Add-Migration, Update-Database) <br />
I also placed the database files in the Baza_pliki directory. 


