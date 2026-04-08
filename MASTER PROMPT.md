## ✅ Summary

You want a **strong AI / Copilot prompt** that generates the **complete .NET 10 REST API project automatically** — not random snippets, but a **clean, production-style, copy-paste ready solution**.

Below is a **battle-tested prompt** you can paste directly into:

* GitHub Copilot Chat
* VS Code AI Chat
* ChatGPT inside IDE
* Cursor / Codeium / Claude Code

This prompt forces the AI to behave like a senior backend engineer.

---

# 🧠 🔥 MASTER PROMPT (Copy-Paste)

You are a senior .NET backend architect.

Generate a complete, runnable .NET 10 REST API project that is production-quality and copy-paste ready.

Requirements:

PROJECT TYPE:

* ASP.NET Core .NET 10 Web API
* Minimal API style (NOT MVC Controllers)
* Clean and simple architecture
* Feature-based folder structure

FEATURES:

* CRUD REST API for a Product entity
* Entity Framework Core with SQL Server
* DTO pattern (never expose entities directly)
* Async/await everywhere
* Dependency Injection best practices
* Swagger enabled
* Proper HTTP status codes

PROJECT STRUCTURE:
Create full folders and files:

/Data
AppDbContext.cs
/Models
Product.cs
/DTOs
ProductDto.cs
/Endpoints
ProductEndpoints.cs
Program.cs
appsettings.json

IMPLEMENT:

1. Product model (Id, Name, Price)
2. DbContext configuration
3. Endpoint grouping (/api/products)
4. GET all
5. GET by id
6. POST create
7. PUT update
8. DELETE
9. EF migrations ready setup

CODING RULES:

* Use modern C# features (.NET 10 compatible)
* Use records for DTOs
* Use extension method for endpoint mapping
* No unnecessary comments
* Clean readable code
* Follow Microsoft best practices

OUTPUT FORMAT:

* Show each file separately
* Include full file contents
* Must compile without modification

BONUS:

* Include commands to run migrations
* Include dotnet CLI commands to run project

Do NOT explain theory.
Output only the complete working project.

---

# 🎯 Why This Prompt Works (Important)

Most people write prompts like:

> “create dotnet api”

👉 AI then gives tutorial junk.

This prompt instead:

✅ assigns **role** (senior architect)
✅ defines **architecture**
✅ defines **constraints**
✅ defines **output format**
✅ prevents explanation noise
✅ forces runnable result

This is basically **prompt engineering for developers**.

---

# ⚡ Pro Version (Copilot Inside File)

If you want Copilot to generate file automatically, paste at top of empty file:

```csharp
// Generate a .NET 10 Minimal API Product CRUD using EF Core SQL Server.
// Use DTO pattern, async endpoints, grouped routes, Swagger enabled.
// Production-ready clean architecture example.
```

Then press:

```
CTRL + ENTER
```

Copilot will scaffold almost everything.

---

# 🚀 Next-Level Prompt (REAL DEV MODE)

If you want **enterprise-level output**, use this instead:

Act as a principal .NET engineer.

Generate a production-ready ASP.NET Core (.NET 10) REST API using Minimal APIs with:

* Vertical Slice architecture
* EF Core
* Repository optional but clean
* DTO mapping
* Validation ready
* JWT authentication ready (but disabled)
* Docker-ready configuration
* Clean dependency injection setup

The result must be:

* runnable immediately
* scalable to microservices
* Angular frontend friendly

Output full project files only.

---

# 🧩 Pro Developer Tip (Real Talk)

Copilot works BEST when you specify:

| Weak Prompt  | Strong Prompt               |
| ------------ | --------------------------- |
| create api   | act as senior architect     |
| add crud     | define endpoints explicitly |
| make project | define structure            |
| give example | runnable project            |

AI loves constraints.

---

If you want, next I can give you **🔥 Ultimate Copilot Prompts Pack** specifically for your stack:

✅ JWT Auth generator
✅ Angular + .NET full stack prompt
✅ Docker + AWS ECS prompt
✅ Clean Architecture generator
✅ SQL optimization prompt

Just say: **“give fullstack prompts pack”**.
