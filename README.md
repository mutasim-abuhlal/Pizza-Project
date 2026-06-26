# 🍕 Pizza Ordering System - C# WinForms

## 📌 Project Overview

Pizza Ordering System is a simple desktop application built using **C# Windows Forms (WinForms)**.

The project allows users to customize their pizza by selecting different options such as:

- Pizza size
- Crust type
- Toppings
- Eating method
- Number of pizzas

The application then calculates and displays the total order price.

This project was created as a practice project to improve understanding of C# programming and building GUI applications.

---

## 🎯 Project Objectives

### 1. Practice OOP Concepts in a Real Project

The project helps practice Object-Oriented Programming concepts by building a real-life application scenario.

It demonstrates:

- Creating a Windows Form application
- Organizing functionality using methods
- Working with objects and controls
- Encapsulating different operations into separate functions

Examples:

- Price calculation methods
- Updating order information
- Resetting order state

---

### 2. Demonstrates Divide and Conquer Concept

The project applies the idea of **Divide and Conquer** by dividing the pizza ordering process into smaller tasks.

Instead of calculating everything in one large block, the logic is separated into different methods:

- `CalculateTotalSize()`
  - Calculates the pizza size price

- `CalculateTotalCrust()`
  - Calculates the crust price

- `CalculateTotalToppings()`
  - Calculates toppings cost

- `CalculateTotalPrice()`
  - Combines all parts to get the final price

This makes the code easier to read and maintain.

---

### 3. Calculate Total Amount For Each Order

The system calculates the total price depending on the customer's choices.

The calculation includes:

- Selected pizza size
- Crust type
- Extra toppings
- Number of pizzas

Example:
Pizza Size Price

  -Crust Price
  -Toppings Price
  × Quantity

= Total Order Amount
---

## ✨ Features

- Select pizza size:
  - Small
  - Medium
  - Large

- Select crust type:
  - Thin crust
  - Thick crust

- Add toppings:
  - Extra Cheese
  - Onion
  - Mushrooms
  - Olives
  - Tomatoes
  - Green Peppers

- Choose:
  - Eat In
  - Take Out

- Display order summary:
  - Size
  - Crust
  - Toppings
  - Total price

- Change pizza quantity and update total price

- Reset the order form

---

## 🛠️ Technologies Used

- C#
- Windows Forms (WinForms)
- .NET Framework

---

## ⚠️ Data Storage Limitations

This project does **not support data storage functionality**.

The application does not include:

- File storage
- Database connection
- Saving previous orders

All order information exists only while the application is running.

---

## 🚀 Possible Future Improvements

Future versions could include:

- Saving orders in a database
- Customer information management
- Order history
- Login system
- More pizza options
- Better project architecture using separate classes

---

## 📚 Learning Purpose

This project demonstrates:

- C# WinForms development
- Event handling
- GUI programming
- Basic software organization
- Breaking problems into smaller methods
- Price calculation logic
