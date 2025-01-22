
# Library Management System

## Overview

This project implements a simple **Library Management System** using **C#**. It allows users to manage books and eBooks in a library through a console-based application. The system includes functionality for adding, removing, searching, and listing books, and it uses design patterns and object-oriented programming principles for better code structure and maintainability.

### Features:
- **Add, Remove, Search, and List Books**: Basic CRUD operations for managing books in the library.
- **Book and EBook Classes**: Support for both physical books and eBooks with inheritance.
- **Singleton Pattern**: Ensures a single instance of the LibraryManager class.
- **Factory Pattern**: Used for creating Book or EBook objects based on user input.

## Key Components:
1. **Book Class**: Represents a book with attributes like `title`, `author`, `isbn`, and `available`.
2. **EBook Class**: A subclass of `Book`, with an additional attribute `fileSize` (for eBook file size in MB).
3. **Library Class**: Holds a list of books and provides methods to add, remove, search, and list books.
4. **LibraryManager Class**: Manages user input and interacts with the `Library` class.
5. **BookFactory Class**: Generates instances of `Book` or `EBook` based on input parameters.

## How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/Nithish2030/LibraryManagementSystem
   ```
   
2. Open the project in Visual Studio or your preferred C# IDE.

3. Build and run the project to see the menu and interact with the system.

## Expected Output:
- Users can interact through a text-based interface to:
  - Add new books and eBooks.
  - Remove books by ISBN.
  - Search for books by title.
  - List all available books and their details.
![Screenshot (6)](https://github.com/user-attachments/assets/dd71f23e-2896-44e3-8bc1-9c86ad61eb93)
![Screenshot (7)](https://github.com/user-attachments/assets/2975a867-5190-4709-bdac-c6b563b5479e)



  
## Technologies Used:
- **C#**
- **Console Application**
- **Object-Oriented Programming (OOP)** principles
- **Design Patterns**: Singleton, Factory

---
