# Grocery Inventory Management System

## Overview
This project implements a Grocery Inventory Management System, designed to help manage the inventory of a grocery store. The system includes features such as adding new items, displaying all inventory items, clearing the inventory, and deleting specific items. The project demonstrates various Object-Oriented Programming (OOP) concepts including inheritance, encapsulation, polymorphism, and abstraction.

## Table of Contents
- [Project Structure](#project-structure)
- [OOP Concepts](#oop-concepts)
- [Classes and Responsibilities](#classes-and-responsibilities)
- [Usage](#usage)
- [Author](#author)

## Project Structure
The project consists of the following files:
- `Program.cs`: The main entry point of the application.
- `Grocery.cs`: Defines the `Grocery` class.
- `Inventory.cs`: Defines the `Inventory` class.
- `InventoryList.cs`: Defines the `InventoryList` class.
- `IPerson.cs`: Defines the `IPerson` interface.
- `Item.cs`: Defines the `Item` class.
- `Person.cs`: Defines the `Person` class.

## OOP Concepts
The project covers the following OOP concepts:

### Inheritance
- `Person` class inherits from `IPerson`.
- `Grocery` class inherits from `Person`.
- `Inventory` class inherits from `Item`.
- `InventoryList` class inherits from `Inventory`.

### Encapsulation
- Use of properties to encapsulate the fields in each class, providing getters and setters.

### Polymorphism
- Implementing method overriding in classes that inherit from a base class or implement an interface (though not explicitly shown, the design allows for future extension).

### Abstraction
- The `IPerson` interface abstracts the concept of a person, which is implemented by the `Person` class.

## Classes and Responsibilities

### Grocery
- Inherits from `Person`.
- Represents a grocery store with properties such as `storeName`, `storeAddress`, `storeOpenTime`, `storeCloseTime`, and `inventoryList`.

### Inventory
- Inherits from `Item`.
- Represents a list of items in the inventory with a default constructor to initialize the list.

### InventoryList
- Inherits from `Inventory`.
- Manages a list of `Inventory` objects and provides an `Output` method to display inventory details and calculate total price.

### IPerson
- An interface that defines the properties `firstName` and `lastName`.

### Item
- Represents an item with properties such as `itemName`, `quantityInStock`, and `pricePerUnit`.

### Person
- Implements the `IPerson` interface.
- Represents a person with properties `firstName` and `lastName`.

## Usage
To run the application:
1. Clone the repository or download the project files.
2. Open the project in your preferred C# IDE (e.g., Visual Studio).
3. Build and run the project.

Upon running, you will be presented with a menu to:
1. Add a new item to the inventory.
2. Display all inventory items.
3. Clear the inventory.
4. Delete an item from the inventory.
5. Exit the application.

Follow the prompts to interact with the inventory management system.

## Author
- **Name:** Nithish Jagadeesan
- **Email:** [nithish.jagadeesan@gmail.com](mailto:nithish.jagadeesan@gmail.com)

Date: 23-02-2023
