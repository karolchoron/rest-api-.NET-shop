# 🛍️ ASP.NET Core C# Rest API - Shop

### PL version bellow

The project presents a simple REST API made in **ASP.NET Core** technology, using the **EntityFramework ORM**,<br />
used to manage products in the store. <br />

## 🛠️ Features

✅ **Adding products**: `/api/Shop/Add`
✅ **Editing products**: `/api/Shop/Edit`
✅ **Fetching products**: `/api/Shop/GetOne` and `/api/Shop/GetAll`
✅ **Removing products**: `/api/Shop/Delete`

## 🗄️ Database Structure

- 🆔 **ID**
- 📦 **Product Name**
- 🕒 **Creation Date**
- ✏️ **Edit Date**
- 📝 **Description**
- 💰 **Price**

The data is stored in a **Microsoft SQL Server** database.<br />
To create the database, I used **EntityFramework** (database migration: `Add-Migration`, `Update-Database`).<br />
I also placed the database files in the `Baza_pliki` directory.

---

## PL

Projekt przedstawia proste **REST API** wykonane w technologii **ASP.NET Core**, wykorzystujące **ORM EntityFramework**,<br />
służące do zarządzania produktami w sklepie.<br />

## 🛠️ Funkcjonalności

✅ **Dodanie produktu**: `/api/Shop/Add`
✅ **Edycja produktu**: `/api/Shop/Edit`
✅ **Pobranie produktów**: `/api/Shop/GetOne` oraz `/api/Shop/GetAll`
✅ **Usuwanie produktów**: `/api/Shop/Delete`

## 🗄️ Struktura bazy danych

- 🆔 **ID**
- 📦 **Nazwa Produktu**
- 🕒 **Data Utworzenia**
- ✏️ **Data Edycji**
- 📝 **Opis Artykułu**
- 💰 **Cena**

Dane przechowywane są w **bazie danych Microsoft SQL Server**.<br />
Do utworzenia bazy użyłem **EntityFramework** (migracja bazy danych: `Add-Migration`, `Update-Database`).<br />
Pliki bazy danych zamieściłem również w katalogu `Baza_pliki`. 🚀

