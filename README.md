# 50.0-changeCode

## 📌 Project Overview
This project is an **internal company program** used to generate or convert **product codes** based on predefined business rules.

Each section of the product code represents specific product attributes defined by the company, such as color and product dimensions.  
The program helps ensure that product codes are generated consistently and do not conflict with existing codes.

> ⚠️ Note: This is an internal system. The overall design and rules were created by the company.  
> My role focuses on implementing required logic, maintaining existing code, and learning the system.

---

## 🧩 Product Code Structure
An example of the product code format:


Where:
- `CCC` → Color code  
- `WWW` → Width  
- `LLL` → Length  
- `TTT` → Thickness  

*(The actual format and parameters are defined internally by the company.)*

---

## 🧪 Example Input / Output

**Input Parameters**
- Color Code: `101`
- Width: `120`
- Length: `240`
- Thickness: `015`

**Generated Product Code**
101120240015

This example demonstrates how the program combines internal parameters into a standardized product code while ensuring no duplication with existing codes.

---

## ⚙️ Features
- Generate new product codes based on internal parameters
- Check existing product codes to prevent duplication
- Follow company-defined business rules for product identification

---

## 🛠 Tech Stack
- Programming Language: **Visual Basic**
- IDE: **Visual Studio**
- Environment: Internal company system

---

## 🚀 How It Works (High Level)
1. Read product parameters defined by internal rules
2. Check existing product codes to avoid duplication
3. Generate a new product code that follows the company format
4. Output the code for internal use

---

## 🎯 Use Cases
- Internal product management
- Manufacturing and production tracking
- Inventory and ERP-related processes

---

## 📚 What I Learned
- Understanding and working with **existing (legacy) codebases**
- Checking old product codes to **avoid duplication**
- Generating new codes based on **internal parameters and business rules**
- Learning a **new programming language (Visual Basic)** on the job
- Gaining experience working with **real-world internal systems**

---

## 🔮 Future Improvements
- Refactor and clean up the existing codebase for better readability
- Improve naming conventions for variables and functions
- Reduce duplicated logic by extracting reusable functions
- Add comments and documentation for complex logic
- Add input validation to prevent invalid parameters
- Improve error handling and logging
- Add basic unit tests to increase reliability
- Optimize performance if the dataset grows larger

---

## 👤 My Role
- Implemented required logic based on internal specifications
- Maintained and updated existing code
- Ensured new product codes do not duplicate existing ones
- Learned Visual Basic and Visual Studio in a real production environment

---

## 📄 License
This project is for **internal company use** and learning purposes.
