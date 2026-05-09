---
name: "Feature / Component Development"
about: "Use this template for new features, enhancements, or component work requiring DB, repo, and UI changes."
title: "[Feature]: "
labels: ["Feature", "Enhancement"]
assignees: []
---

## 📌 Overview
> Brief 1-2 sentence description of the feature or component being developed.

**Labels:** `Feature` | `Enhancement` | `Database` | `UI`

---

## 🛠 Functional Requirements (FRs)
*Specific goals this task must accomplish (referencing the assignment sheet).*
- **FR#:** [Requirement Title/Description]
- **FR#:** [Requirement Title/Description]

---

## 🏗 Technical Implementation Plan

### 1. Database & Model Layer
- [ ] **DDL Updates:** (e.g., Create/Alter table `TableName`)
- [ ] **C# Model:** Create `ModelName.cs` with relevant properties and constructors.

### 2. Repository Layer (SQL Logic)
- [ ] **Method:** `MethodName()` -> Implements `SELECT/INSERT/UPDATE/DELETE`.
- [ ] **Method:** `MethodName()` -> Implements complex logic (Joins/Aggregates).

### 3. UI Layer (Windows Forms)
- [ ] **Layout:** Add controls (DataGridView, Buttons, TextBoxes) to `TabName`.
- [ ] **Binding:** Connect UI elements to the Repo methods.
- [ ] **Validation:** Ensure user input is cleaned/validated before hitting the DB.

---

## ✅ Acceptance Criteria (Definition of Done)
- [ ] The code compiles without errors.
- [ ] Data is successfully saved to and retrieved from the SQL Server.
- [ ] UI elements are properly aligned and follow the project's visual style.
- [ ] No "Hardcoded" connection strings (use a central config/class).

---

## 🔗 Resources & References
- *Related Issues:* # (Link other issues here)
- *Documentation:* [Link to any specific SQL logic or library used]*
