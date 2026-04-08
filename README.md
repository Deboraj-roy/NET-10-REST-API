# 🚀 SimpleApi — .NET 10 Minimal REST API

A clean, production-style REST API built with **ASP.NET Core (.NET 10)** using **Minimal APIs**, **Entity Framework Core**, and **SQL Server**.

This project demonstrates modern .NET backend practices with a simple CRUD example.

---

## 📌 Features

* ✅ ASP.NET Core **.NET 10 Minimal API**
* ✅ RESTful CRUD endpoints
* ✅ Entity Framework Core
* ✅ SQL Server integration
* ✅ DTO pattern (no entity exposure)
* ✅ Async database operations
* ✅ Swagger API documentation
* ✅ Clean feature-based structure
* ✅ Copy-paste runnable project

---

## 🧱 Tech Stack

| Layer         | Technology             |
| ------------- | ---------------------- |
| Backend       | ASP.NET Core (.NET 10) |
| ORM           | Entity Framework Core  |
| Database      | SQL Server             |
| API Style     | Minimal API            |
| Documentation | Swagger / OpenAPI      |

---

## 📁 Project Structure

```
SimpleApi
│
├── Data
│   └── AppDbContext.cs
│
├── Models
│   └── Product.cs
│
├── DTOs
│   └── ProductDto.cs
│
├── Endpoints
│   └── ProductEndpoints.cs
│
├── Program.cs
├── appsettings.json
└── README.md
```

---

## ⚙️ Prerequisites

Install the following:

* [.NET 10 SDK](https://dotnet.microsoft.com/)
* SQL Server (LocalDB or full instance)
* Visual Studio / VS Code

Verify installation:

```bash
dotnet --version
```

---

## 🔧 Setup Instructions

### 1️⃣ Clone Repository

```bash
git clone <your-repo-url>
cd SimpleApi
```

---

### 2️⃣ Install Dependencies

```bash
dotnet restore
```

---

### 3️⃣ Configure Database

Edit **appsettings.json**:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=SimpleApiDb;Trusted_Connection=True;TrustServerCertificate=True"
}
```

Update credentials if needed.

---

### 4️⃣ Create Database (EF Core)

Install EF CLI (one time only):

```bash
dotnet tool install --global dotnet-ef
```

Create migration:

```bash
dotnet ef migrations add InitialCreate
```

Apply migration:

```bash
dotnet ef database update
```

---

### 5️⃣ Run Application

```bash
dotnet run
```

API will start at:

```
https://localhost:<port>
```

---

## 📖 Swagger API Documentation

Open in browser:

```
https://localhost:<port>/swagger
```

You can test all endpoints directly from Swagger UI.

---

## 🌐 API Endpoints

Base route:

```
/api/products
```

| Method | Endpoint             | Description       |
| ------ | -------------------- | ----------------- |
| GET    | `/api/products`      | Get all products  |
| GET    | `/api/products/{id}` | Get product by id |
| POST   | `/api/products`      | Create product    |
| PUT    | `/api/products/{id}` | Update product    |
| DELETE | `/api/products/{id}` | Delete product    |

---

## 🧠 Example Request (POST)

```json
{
  "name": "Laptop",
  "price": 1200
}
```

---

## 🏗️ Architecture Notes

### Minimal API Approach

Endpoints are grouped using extension methods instead of MVC controllers for simplicity and performance.

### DTO Pattern

Entities are never exposed directly to avoid overposting and enable API versioning.

### Async First

All database calls use async operations to improve scalability.

---

## ⚠️ Common Issues

### Database Connection Error

Ensure SQL Server is running and connection string is correct.

### Migration Fails

Try:

```bash
dotnet ef database drop
dotnet ef database update
```

---

## 🚀 Future Improvements

Planned production enhancements:

* JWT Authentication
* Role-based authorization
* Request validation (FluentValidation)
* Global exception handling middleware
* Logging with Serilog
* Pagination & filtering
* Docker support
* CI/CD pipeline
* AWS deployment (ECS + RDS)

---

## 🐳 Docker (Optional Future)

```bash
dotnet publish -c Release -o publish
docker build -t simpleapi .
```
