## Utility Bill Manager

A lightweight RESTful API for tracking utility bills — including usage, cost, and account details. Built with ASP.NET Core and EF Core, this project calculates cost per kWh and stores billing data in a local SQLite database.

It includes full Swagger integration for easy testing and serves as a foundation for future full-stack billing or reporting tools.

---

## Features

- View all utility bills
- Fetch a specific bill by ID
- Add new utility bills
- Automatically calculates cost per kWh
- Integrated Swagger UI for easy API testing
- Uses a local SQLite database via EF Core

---

## Tech Stack

- **C# / ASP.NET Core** – RESTful API backend  
- **Entity Framework Core** – ORM for database access  
- **SQLite** – Lightweight local database  
- **Swagger (Swashbuckle)** – API documentation and testing  

---

## Project Structure

| File | Purpose |
|------|---------|
| `Program.cs` | Configures services, middleware, Swagger, and maps controller routes |
| `Models/Bill.cs` | Defines the data model for a utility bill |
| `Data/BillContext.cs` | EF Core DB context with `DbSet<Bill>` |
| `Controllers/BillsController.cs` | API controller with endpoints for retrieving and creating bills |
| `Migrations/` | EF Core migration scripts to set up the database schema |
| `launchSettings.json` | Dev launch settings including Swagger auto-open |

---

## Endpoints

### `GET /api/bills`
Returns all utility bills in the database.

---

### `GET /api/bills/{id}`
Returns a single bill by ID.  
Returns `404 Not Found` if the bill does not exist.

---

### `POST /api/bills`
Creates a new utility bill.  
Example request body:

```json
{
  "account": "ACME-001",
  "meter": "Meter-A",
  "usageKwh": 350.75,
  "costUsd": 45.32,
  "billDate": "2025-04-01T00:00:00"
}
```

---

## Running the App

1. **Clone the repository**

   ```bash
   git clone https://github.com/your-username/UtilityBillManager.git
   cd UtilityBillManager
   ```

2. **Build and run the project**

   Make sure you have the .NET SDK installed (preferably .NET 8 or newer):

   ```bash
   dotnet build
   dotnet run
   ```

3. **Access the API**

   Open your browser and go to:

   ```
   https://localhost:7144/swagger
   ```

   This opens the Swagger UI, where you can interact with the API endpoints visually and test them without Postman or curl.

---

## What I Learned

This project helped reinforce my understanding of:

- ✅ Structuring a scalable ASP.NET Core Web API project
- ✅ Using dependency injection for cleaner service management
- ✅ Creating and managing a local SQLite database with Entity Framework Core
- ✅ Building RESTful routes with `[ApiController]` and route attributes
- ✅ Documenting and testing APIs using Swagger
- ✅ Writing and applying EF Core migrations to manage schema

---

## Future Improvements

- [ ] Add support for `PUT` and `DELETE` endpoints  
- [ ] Implement input validation using `DataAnnotations`  
- [ ] Add search and filtering (e.g., filter by date, account, or cost)  
- [ ] Write unit tests for controller logic  
- [ ] Create a Blazor or React frontend  
- [ ] Deploy to Docker or Azure App Services

---

## License

This project is intended for educational and learning purposes only.  
No license is applied yet — feel free to fork and experiment.

---
