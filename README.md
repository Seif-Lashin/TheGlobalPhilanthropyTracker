# 🌍 The Global Philanthropy & Impact Tracker

A Windows Forms desktop application built with **C# and MS SQL Server** that helps a non-profit organization manage humanitarian initiatives, track supporter contributions, monitor expenditures, and generate impact analytics.

---

## 📋 Project Overview

The system allows the organization to:
- Set up and manage humanitarian initiatives across sectors (health, ecology, disaster relief, etc.)
- Register supporters and process their financial contributions
- Log expenditures per initiative and track funding progress
- Generate contribution receipts and impact summaries
- Run analytical queries to surface insights (top sectors, inactive initiatives, top contributors, and more)

---

## 🗂️ Project Structure

```
TheGlobalPhilanthropyTracker/
├── Database/
│   ├── schema.sql              # Table definitions (DDL)
│   └── seed.sql                # Sample data
├── Models/                     # C# classes mirroring DB tables
│   ├── Sector.cs
│   ├── Initiative.cs
│   ├── Supporter.cs
│   ├── Contribution.cs
│   ├── Expenditure.cs
│   └── Vendor.cs
├── Repositories/               # SQL query logic
│   ├── DatabaseConfig.cs       # Shared connection string
│   ├── InitiativeRepository.cs
│   ├── SupporterRepository.cs
│   ├── FinanceRepository.cs
│   ├── AnalyticsRepositoryA.cs
│   └── AnalyticsRepositoryB.cs
└── UI/
    ├── MainForm.cs
    └── Tabs/
        ├── SetupTab.cs
        ├── SupporterTab.cs
        ├── FinanceTab.cs
        ├── AnalyticsATab.cs
        └── AnalyticsBTab.cs
```

---

## 🚀 Getting Started

### 1. Clone the Repository into Visual Studio

1. Open **Visual Studio**
2. On the start screen, click **"Clone a repository"**
3. Paste the repository URL and choose a local path
4. Click **Clone** — Visual Studio will open the solution automatically

> Alternatively: **File → Clone Repository** from inside Visual Studio.

---

### 2. Set Up the Database (please view first 3 min [here](https://www.youtube.com/watch?v=T8Mq8_Y7tgY))

#### Step 1 — Open SQL Server Object Explorer

In Visual Studio, go to:
**View → SQL Server Object Explorer**

#### Step 2 — Connect to Local SQL Server

1. Click the **Add SQL Server** button (plug icon)
2. In the connection dialog, set:
   - **Server Name:** `.` *(a single dot — this targets your local SQL Server instance)*
   - **Authentication:** Windows Authentication
   - ✅ Check **"Trust Server Certificate"**
3. Click **Connect**

#### Step 3 — Create the Database

1. Right-click on **Databases** under your local server
2. Select **"Add New Database"**
3. Name it exactly: `TheGlobalPhilanthropyTracker`
4. Click **OK**

#### Step 4 — Run the Schema Script

1. In SQL Server Object Explorer, right-click the `TheGlobalPhilanthropyTracker` database
2. Select **"New Query"**
3. Open `Database/schema.sql` from Solution Explorer, copy its contents, and paste into the query window
4. Click the green **▶ Run** button (or press `Ctrl+Shift+E`)

#### Step 5 — Seed the Data

1. Open another new query on the same database
2. Copy the contents of `Database/seed.sql` and paste into the query window
3. Run it

---

## ⚠️ Important — Read Before Coding

### Do NOT modify these files:
| File | Reason |
|------|--------|
| `Database/schema.sql` | Defines the agreed-upon table structure for the whole team |
| `Database/seed.sql` | Shared test data — changes affect everyone |
| `Repositories/DatabaseConfig.cs` | Contains the single shared connection string |

> Modifying any of the above can break other team members' work. Treat them as **read-only**.

---

### ✅ Using the Connection String in Your Repository

Every repository file should use the connection string from `DatabaseConfig.cs`. Do **not** hardcode your own connection string.

Here's how to use it in your repository class:

```csharp
using System.Data.SqlClient;

public class YourRepository
{
    private readonly string _connectionString = DatabaseConfig.ConnectionString;

    public void YourMethod()
    {
        using (SqlConnection conn = new SqlConnection(_connectionString))
        {
            conn.Open();
            // Write your SQL command here
        }
    }
}
```

`DatabaseConfig.cs` already points to `localhost (.)` and the database `TheGlobalPhilanthropyTracker` with Trust Certificate enabled — you don't need to change anything.


## 🛠️ Tech Stack

- **Language:** C# (.NET Windows Forms)
- **Database:** Microsoft SQL Server (local instance)
- **IDE:** Visual Studio
- **Data Access:** ADO.NET (`SqlConnection`, `SqlCommand`, `SqlDataAdapter`)
