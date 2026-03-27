# ShipServicesApp

A showcase ASP.NET Core MVC + API application for managing ship services such as Ship Agencies, Port Captaincy, Crew Supply, Supply Services, Ship Repairs, Customs Clearance, Underwater Services, Husbanding, and Tank Cleaning.  
This demo features a modern Bootstrap UI, a full set of sample data, working REST APIs (with Swagger), and is suitable for demos, learning, or as a template for a more complete app.

---

## **Features**

- 📈 Modern responsive UI with Bootstrap 5 and card-based dashboards
- 💡 Sample data for all modules, ready to demo
- 🛳️ Module coverage: Ship Agencies, Port Captaincy, Crew Supply, Supply Services, Ship Repairs, Customs Clearance, Underwater/Diving, Husbanding, Tank Cleaning
- 🌐 RESTful JSON APIs for each module (`/api/ModuleApiController`)
- 🔄 Swagger UI for live API testing (`/swagger`)
- 🎉 Easily extendable: add database, authentication, or more logic

---

## **Getting Started**

### **1. Prerequisites**

- [.NET 7 SDK or later](https://dotnet.microsoft.com/download)
- (Optional) [Visual Studio 2022+](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

### **2. Clone the Repository**

```bash
git clone https://github.com/your-username/ShipServicesApp.git
cd ShipServicesApp
```

### **3. Build & Run**

```bash
dotnet restore
dotnet run
```

_The app default launches on http://localhost:5145 (your port may vary)._

---


## **Project Structure**

```
ShipServicesApp/
├── Controllers/         # UI controllers and API controllers
│   ├── ...Controller.cs
│   └── api/ModuleApiController.cs
├── Models/              # Model classes
├── Services/            # DemoDataService with all in-memory demo data
├── Views/               # Razor Views, module dashboards
│   └── Shared/_Layout.cshtml
├── Program.cs
├── README.md
└── .gitignore
```

---

## **How to Use**

- **UI Demo (MVC):**  
  Open browser to [http://localhost:5145/ShipAgency](http://localhost:5145/ShipAgency) or any module (see sidebar).
- **API Demo (Swagger):**  
  Browse to [http://localhost:5145/swagger](http://localhost:5145/swagger) for a full API playground.
- **Sample Data:**  
  Each section (Ship Agencies, etc.) comes pre-populated with realistic sample data for demo purposes.

---


## **Customization & Extensibility**

- Add your branding, logos, or images as needed (e.g. in `Views/Home/Index.cshtml`)
- Extend the in-memory `DemoDataService` or connect to a real database
- Add authentication (ASP.NET Identity) or role-based access control if needed

---

## **Contributing**

Pull requests and feedback welcome!  
If you find a bug or want a new feature, open an issue or PR.

---

## **License**

MIT License

---

> **Tip:**  
> For a cleaner repo, ensure your `.gitignore` includes `bin/`, `obj/`, and `*.user` files.
