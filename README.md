#  Furniture Factory Management API

A Web API for managing **products**, **components**, and **subcomponents** in a furniture factory system. Built using **ASP.NET Core 9**, **Entity Framework Core**, and **Onion Architecture**.

---
🚀  Project Demo (https://youtu.be/HNxPPtqzXnQ)

📋  Front End file (https://github.com/EMahmoudNabil/ui-react-app)


## 🩱 Architecture Overview

* ASP.NET Core 9 Web API
* Entity Framework Core (Code First)
* Onion Architecture (Domain, Application, Infrastructure, API layers)
* Repository Pattern & Unit of Work
* AutoMapper for object mapping

---

## 🔌 Database Configuration

Ensure **SQL Server** is installed locally or remotely.

Update your `appsettings.json` file in the **API** project to match your SQL Server setup:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=DESKTOP-8JFRNPP\\SQLEXPRESS;Database=Api_Task_Techtroll;Trusted_Connection=True;Encrypt=False;"
}
```

> 💡 Replace `DESKTOP-8JFRNPP\\SQLEXPRESS` with your machine or server name if necessary.

---

## ⚙️ Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/your-username/Api-Task-Techtroll.git
cd Api-Task-Techtroll
```

### 2. Install Dependencies

```bash
dotnet restore
```

### 3. Apply Database Migrations

Using CLI:

```bash
dotnet ef database update --project "Infrastructure" --startup-project "API"
```

Or using Visual Studio Package Manager Console:

```powershell
Update-Database -Project "Api_Task_Techtroll.co.Infrastructure" -StartupProject "Api_Task_Techtroll.co.API"
```

### 4. Run the Application

Via CLI:

```bash
dotnet run --project "API"
```

Or simply press `F5` in Visual Studio.

---

## 🛠 API Endpoints

| Resource      | Method | Endpoint            | Description           |
| ------------- | ------ | ------------------- | --------------------- |
| Products      | GET    | `/api/Product`      | Get all products      |
| Products      | POST   | `/api/Product`      | Create a new product  |
| Components    | GET    | `/api/Component`    | Get all components    |
| Subcomponents | GET    | `/api/Subcomponent` | Get all subcomponents |

> ✅ All endpoints follow RESTful principles.

---

## 🧪 Technologies & Libraries Used

* ASP.NET Core 9
* Entity Framework Core
* AutoMapper
* SQL Server
* FluentValidation / Data Annotations
* Swagger (optional)

---
## 📸 Screenshots

### Architecture Back End  
![Architecture Back End ](<img width="493" height="561" alt="image" src="https://github.com/user-attachments/assets/14872c48-7126-4a16-a0bc-9e9467d90b11" />
)

### EndPoint
![EndPoint](<img width="534" height="439" alt="2" src="https://github.com/user-attachments/assets/f93aad7b-49b8-48ad-bd39-51e77be29752" />
)

)

## 📌 Notes

* The database must be created manually if it doesn't exist.
* Swagger is not included by default. To enable it, install `Swashbuckle.AspNetCore` via NuGet.

---

## 👨‍💻 Author

**Mahmoud Nabil**
*Full Stack Developer – Assessment Task*
