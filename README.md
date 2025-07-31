#  Furniture Factory Management API

Web API to manage products, components, and subcomponents for a furniture factory, built using ASP.NET Core 9, Onion Architecture, and Entity Framework Core.

---

## 🧱 Architecture

- ASP.NET Core 9 Web API
- Entity Framework Core + Code First
- Onion Architecture (Domain, Application, Infrastructure, API)
- Repository Pattern + Unit of Work
- AutoMapper

---

## 🔌 Database Connection

Ensure you have **SQL Server** installed locally or remotely.

Open `appsettings.json` inside the `API` project and make sure this connection string is configured correctly:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=DESKTOP-8JFRNPP\\SQLEXPRESS;Database=Api_Task_Techtroll;Trusted_Connection=True;Encrypt=False;"
}
