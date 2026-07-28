# 💰 FinanceHub API

A production-ready Personal Finance REST API built with **ASP.NET Core 8** following **Clean Architecture**, **CQRS**, and **Domain-Driven Design (DDD)** principles.

The project aims to simulate a real-world backend used by fintech companies, demonstrating best practices for scalable, maintainable, and testable software.

---

## 🚀 Technologies

- ASP.NET Core 8
- C#
- Clean Architecture
- CQRS
- MediatR
- Entity Framework Core
- Dapper
- SQL Server
- JWT Authentication
- FluentValidation
- AutoMapper
- Serilog
- Swagger / OpenAPI
- Docker
- xUnit
- GitHub Actions

---

## 📂 Solution Structure

```
FinanceHub
│
├── src
│   ├── FinanceHub.Api
│   ├── FinanceHub.Application
│   ├── FinanceHub.Domain
│   ├── FinanceHub.Infrastructure
│   ├── FinanceHub.Persistence
│   └── FinanceHub.Shared
│
├── tests
│   ├── FinanceHub.UnitTests
│   └── FinanceHub.IntegrationTests
│
└── FinanceHub.sln
```

---

## 🏛 Architecture

This project follows the principles of **Clean Architecture**.

```
Presentation
      │
      ▼
Application
      │
      ▼
Domain
      ▲
      │
Infrastructure
      │
Persistence
```

Dependencies always point inward.

---

## ✨ Features

- User Authentication (JWT)
- User Registration
- Account Management
- Categories
- Income & Expense Transactions
- Credit Cards
- Financial Goals
- Investments
- Dashboard
- Reports
- Global Exception Handling
- Request Validation
- Logging

---

## 🔐 Authentication

JWT Bearer Authentication with:

- Access Token
- Role-based Authorization

---

## 🧪 Tests

- Unit Tests
- Integration Tests

---

## 📦 Running the project

Clone the repository

```bash
git clone https://github.com/aquilesfalcaoo/FinanceHub.git
```

Restore packages

```bash
dotnet restore
```

Run the API

```bash
dotnet run --project src/FinanceHub.Api
```

---

## 📖 API Documentation

Swagger UI

```
/swagger
```

---
