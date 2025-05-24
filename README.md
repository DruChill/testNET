# MiCrudApi

<a href="http://ponticloud.web.app/">
  <img  src="https://github.com/DruChill/testNET/blob/main/View%20API.jpeg?raw=true" alt="Logo" />
</a>

A simple CRUD API built with ASP.NET Core and MySQL using Entity Framework Core.

## Prerequisites

- .NET 8.0
- MySQL Server
- Visual Studio Code or preferred IDE

## Installation

1. Clone the repository:
```bash
git clone https://github.com/yourusername/MiCrudApi.git
cd MiCrudApi
```

2. Update the connection string in `appsettings.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=midb;User=root;Password=yourpassword;"
  }
}
```

3. Install dependencies:
```bash
dotnet restore
```

4. Run migrations:
```bash
dotnet ef database update
```

## Running the Application

1. Start the application:
```bash
dotnet run
```

2. Open Swagger UI:
- Navigate to `http://localhost:5282/swagger`

## API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET    | /api/Person | Get all persons |
| GET    | /api/Person/{id} | Get person by ID |
| POST   | /api/Person | Create new person |
| PUT    | /api/Person/{id} | Update person |
| DELETE | /api/Person/{id} | Delete person |

## Technologies Used

- ASP.NET Core 8.0
- Entity Framework Core
- MySQL
- Swagger/OpenAPI

## Project Structure

```
MiCrudApi/
├── Controllers/
│   └── PersonController.cs
├── Models/
│   └── Person.cs
├── Data/
│   └── AppDbContext.cs
├── Program.cs
├── appsettings.json
└── MiCrudApi.csproj
```

## License

This project is licensed under the MIT License.
