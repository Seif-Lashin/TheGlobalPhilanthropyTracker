# C# Development Conventions & Project Guidelines

This document outlines the coding standards, naming conventions, and workflow requirements for the database-driven WinForms application. All team members must adhere to these standards to ensure code maintainability and seamless integration.

## 1. Project Architecture (Layered Pattern)
To keep the code organized, we will separate logic into three distinct layers:

* **Models**: Plain Old CLR Objects (POCOs) representing database tables.
* **Repositories (Data Access Layer)**: Classes containing raw SQL queries using `SqlConnection`, `SqlCommand`, and `SqlDataReader`.
* **UI (Presentation Layer)**: Windows Forms (Drag & Drop) that call the Repository methods.

---

## 2. Naming Conventions

### 2.1 C# Code
* **Classes/Methods**: `PascalCase` (e.g., `AddInitiative`, `SupporterRepository`)
* **Variables/Parameters**: `camelCase` (e.g., `fundingAmount`, `initiativeId`)
* **Private Fields**: `_camelCase` with underscore (e.g., `_connectionString`)
* **Namespaces**: `PascalCase` matching folder structure (e.g., `ProjectName.Repositories`)

### 2.2 WinForms Controls
All UI controls must be renamed from their default (e.g., `button1`) to include a functional prefix:

| Control | Prefix | Example |
| :--- | :--- | :--- |
| **Button** | `btn` | `btnSubmitContribution`, `btnDeleteInitiative` |
| **TextBox** | `txt` | `txtSupporterEmail`, `txtInitiativeTitle` |
| **Label** | `lbl` | `lblStatusMessage`, `lblTotalFunding` |
| **DataGridView** | `dgv` | `dgvMainOutput`, `dgvSupporters` |
| **ComboBox** | `cmb` | `cmbSectorSelection` |
| **CheckBox** | `chk` | `chkIsActive` |
| **NumericUpDown**| `num` | `numAmount` |

---

## 3. Database & SQL Standards
* **Keywords**: Use `UPPERCASE` for SQL keywords (e.g., `SELECT`, `FROM`, `WHERE`, `JOIN`).
* **Table/Column Names**: Match the physical ERD (e.g., `Initiatives`, `SupporterID`).
* **Safety**: **NEVER** use string concatenation for queries. Always use **Parameters** to prevent SQL Injection.
    * *Bad*: `string sql = "SELECT * FROM Users WHERE ID = " + id;`
    * *Good*: `cmd.CommandText = "SELECT * FROM Users WHERE ID = @id"; cmd.Parameters.AddWithValue("@id", id);`
