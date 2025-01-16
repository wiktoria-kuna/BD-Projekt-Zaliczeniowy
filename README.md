# Projekt zaliczeniowy  
**Temat projektu**: System zarządzania biblioteką.  
**Wykonała**: Wiktoria Kuna grupa L6

## Instalacja i wymagania ##
- Visual Studio 2022
- SQL Server 2022
- SQL Server Managament Studio 20
- .NET 9.0
### Pakiety NuGet ###
- Microsoft.AspNetCore.Identity.Entity.FrameworkCore
- Microsoft.AspNetCore.Identity.UI
- Microsoft.EntityFrameworkCore
- Microsoft.Entity.FrameworkCore.Sqlite
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore/Tpp;s
- Microsoft.VisualStudio.Web.CodeGeneration.Design
### Połączenie z bazą danych ###
``` sharp
"ConnectionStrings": {
  "Biblioteka": "Server=nazwa_serwera;Database=BibliotekaDb;Trusted_Connection=True;TrustServerCertificate=True"
}
```
#### Utworzenie bazy danych ####
`add-migration "nazwa" `\
`update-database`
### Przykładowi użytkownicy ###
- **Admin**:\
  Email: `admin@admin.com`\
  Hasło: `Admin!1`
- **Użytkownik**:\
  Email: `user@user.com`\
  Hasło: `User!1`
## Opis działania aplikacji z punktu widzenia użytkownika ##
Po wejściu na stronę użytkownik zostaje przekierowany na stronę główną, gdzie
wyświetlone są informacje o projekcie i konta użytkowników.
Na pasku nawigacji są zakładki: Biblioteka (strona główna), Książki, Wypożyczanie,
Kontakt, Role.
### Opis zakładek i ich funkcjonalności ###
#### Książki ####
Książki są główną encją w aplikacji. Zakładka jest dostępna dla każdego, bez konieczności
logowania.
Po wejściu w zakładke zostaną wyświetlone zawarte w bazie danych książki. Każda książka
ma: Tytuł, Opis, Autora i Kategorię. Admin ma możliwość dodania nowej książki,
edytowania istniejących i usuwania. Zwykły użytkownik i osoby niezalogowane, oprócz
przeglądania listy, mogą również zobaczyć szczegóły.
#### Wypożyczanie ####
Zakładka dostępna tylko dla zalogowanych użytkowników.
W zakładce Wypożyczanie są wyświetlone wypożyczone książki. Każde wypożyczenie
składa się z Daty wypożyczenia, Daty oddania i Książki. Każdy zalogowany użytkownik
może zobaczyć listę wypożyczonych książek, dodać nowe wypożyczenie oraz zobaczyć
szczegóły. Tylko admin może wykonywać pozostałe czynności, takie jak edycja i usuwanie.
#### Kontakt ####
W zakładce, dostępnej bez konieczności logowania, wyświetlone są dane kontaktowe z
pracownikami biblioteki. Wszystkie akcje związane z tą encją są dostępne tylko dla
admina, tzn. Dodawanie, edycja, szczegóły i usuwanie.
#### Role ####
Zakładka, dostępna tylko dla admina, służy do dodawania i przeglądania ról, dostępnych
podczas rejestracji.
### Proces logowania i rejestracji ###
Podczas rejestracji użytkownik jest proszony o podanie swojego imienia, nazwisko, emaila
i hasła. Dodatkowo na rzecz projektu dostępny jest wybór roli. Po utworzeniu konta
użytkownik może się zalogować i wylogować.
