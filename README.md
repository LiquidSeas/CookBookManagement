# Cook-Book-Management
This project is a comprehensive Cookbook management system designed to handle ingredients, recipes, and recipe types. It allows users to add, edit, delete, and search for ingredients, recipes, and recipe types through a user-friendly interface.

# Cookbook Management System
# Project Overview
The Cookbook Management System is a comprehensive application designed to handle ingredients, recipes, and recipe types. Users can add, edit, delete, and search for ingredients, recipes, and recipe types through a user-friendly interface.

# Solution Structure
The solution, named CookBook, consists of three main projects:

# Data Access Layer:

# Contracts: 
Defines interfaces that different repositories must implement.
Repositories: Contains classes that implement database operations.
Domain Model:Represents the entities used within the system, such as ingredients, recipes, and recipe types. These models facilitate data transfer between the database and the application.

# CookBook:
Hosts resources that facilitate communication between the user interface (UI) and the database.
Design Patterns Used
Observer Design Pattern:

Custom event handlers capture and handle errors during SQL connection operations, ensuring users are informed of any issues during database interactions.
# Dependency Injection:

Facilitates the initialization of forms and allows easy navigation between forms. Promotes a modular and testable codebase by registering forms in the dependency injection container.
# Repository Design Pattern:

Manages interactions with both SQL and text file databases, abstracting data access logic and providing a clean separation between business logic and data access code.
# Programming Principles Used
Separation of Concerns:

Data handling classes are managed in a separate project from the user interface classes, ensuring clear division of responsibilities and easier maintenance.
Form Validation:

Prevents storing empty or invalid entries in the database, ensuring data integrity and improving user experience.
KISS and DRY Principles:

The project follows the "Keep It Simple, Stupid" (KISS) and "Don't Repeat Yourself" (DRY) principles, resulting in simple, easy-to-debug, clean, and reusable code.
Logging:

A logging class records error messages and the time of occurrence when an error event is raised, aiding in diagnosing and troubleshooting issues efficiently.
Debugging Modes:

Utilizes debugging modes like "step into" and "step over" to locate and fix bugs effectively.
# Technologies Used
Dapper:

A micro ORM used for database operations, enabling efficient data handling with minimal boilerplate code.
SQL Server:

A relational database management system used to store and manage data for ingredients, recipes, and recipe types.
Windows Forms:

A UI framework used to create the desktop application, providing a user-friendly interface for managing cookbook data.
