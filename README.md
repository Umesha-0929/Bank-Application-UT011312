# 🏦 Bank Application

A simple **C# Console-based Banking Application** developed to practice fundamental C# programming concepts and basic banking operations.

The application allows users to view account information, check their balance, deposit money, withdraw money and view transaction history through a simple console menu.

## ✨ Features

- 🏦 View account details
- 💰 Check current account balance
- ➕ Deposit money
- ➖ Withdraw money
- 📋 View transaction history
- ❌ Exit the application
- ✅ Basic validation for deposit and withdrawal amounts
- 🔄 Menu-driven banking operations

## 🛠️ Technology

- **C#**
- **.NET**
- **Console Application**
- **Visual Studio**

## 💡 Concepts Practiced

This project helped me practice important C# fundamentals including:

- Variables and data types
- `decimal` for monetary values
- User input with `Console.ReadLine()`
- Conditional statements
- `if / else`
- `switch`
- `while` loops
- `foreach` loops
- `List<T>`
- Classes and objects
- Properties
- Methods
- Basic encapsulation

## 🏦 Banking Operations

### View Account

Displays basic account information such as:

- Bank name
- Account holder
- Account number

### Check Balance

Displays the current account balance.

### Deposit

Users can enter a deposit amount.

The application:
- Validates that the amount is greater than zero.
- Updates the account balance.
- Records the transaction.

### Withdraw

Users can enter a withdrawal amount.

The application checks that:
- The amount is greater than zero.
- The withdrawal does not exceed the available balance.

### Transactions

The application keeps a list of deposit and withdrawal transactions during the current program session.

## 📂 Project Structure

```text
Bank-Application-UT011312/
│
├── .gitignore
├── ConsoleApp2.csproj
├── ConsoleApp2.sln
└── Program.cs
```

## ▶️ How to Run

### 1. Clone the repository

```bash
git clone <repository-url>
```

### 2. Open the project

Open the `.sln` file using **Visual Studio**.

### 3. Run the application

Run the project using:

```bash
dotnet run
```

Or run it directly from Visual Studio.

## 🎯 Project Purpose

The purpose of this project was to build a simple banking application while gaining practical experience with **C# programming fundamentals, control flow, collections, methods and basic object-oriented programming**.

## 📚 Learning Outcome

Through this project, I gained hands-on experience in creating a console application and implementing basic banking operations using C#.

---

⭐ A C# learning project focused on fundamental programming and banking operations.
