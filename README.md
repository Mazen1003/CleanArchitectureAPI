# Clean Architecture API

## Beskrivning

Detta projekt är ett REST API byggt i **ASP.NET Core 8** enligt principerna för **Clean Architecture**. API:et använder **CQRS** med **MediatR** och **Entity Framework Core** för att hantera produkter och kategorier i en SQL Server-databas.

## Tekniker

- ASP.NET Core 8
- C#
- Entity Framework Core
- SQL Server
- MediatR (CQRS)
- Swagger / OpenAPI
- Git & GitHub

## Projektstruktur

Projektet är uppdelat i fyra lager enligt Clean Architecture:

```
CleanArchitecture
│
├── CleanArchitecture.API
│   ├── Controllers
│   └── Program.cs
│
├── CleanArchitecture.Application
│   ├── Features
│   │   └── Products
│   │       ├── Commands
│   │       └── Queries
│
├── CleanArchitecture.Domain
│   ├── Entities
│   └── Interfaces
│
└── CleanArchitecture.Infrastructure
    ├── Data
    └── Repositories
```

## Funktioner

API:et innehåller full CRUD-funktionalitet för produkter.

- Hämta alla produkter
- Hämta produkt via ID
- Skapa ny produkt
- Uppdatera produkt
- Ta bort produkt

## Databas

Projektet använder **Entity Framework Core Code First** tillsammans med **SQL Server**.

Migrationer används för att skapa databasen.

Kör följande kommandon:

```bash
dotnet ef database update --project CleanArchitecture.Infrastructure --startup-project CleanArchitecture
```

## Starta projektet

1. Klona repot

```bash
git clone https://github.com/Mazen1003/CleanArchitectureApi.git
```

2. Öppna lösningen i Visual Studio.

3. Kontrollera att connection string i `appsettings.json` pekar på din SQL Server-instans.

4. Kör migrationen:

```bash
dotnet ef database update
```

5. Starta projektet.

Swagger öppnas automatiskt där API:et kan testas.

## API Endpoints

| Method | Endpoint | Beskrivning |
|---------|----------|-------------|
| GET | /api/products | Hämta alla produkter |
| GET | /api/products/{id} | Hämta produkt via ID |
| POST | /api/products | Skapa produkt |
| PUT | /api/products/{id} | Uppdatera produkt |
| DELETE | /api/products/{id} | Ta bort produkt |

## Designmönster

Projektet använder:

- Clean Architecture
- Repository Pattern
- Dependency Injection
- CQRS
- MediatR

## GitHub

Projektet versionshanteras med Git och GitHub.

- Publikt repository
- Minst fem meningsfulla commits
- Branch protection på `main`
- Pull Requests används för ändringar

## Författare

Mazen
