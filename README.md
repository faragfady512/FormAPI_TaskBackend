# FormApi__Backend

## Overview

FormApi__Backend is a .NET 5 Web API application that serves as the backend for managing programs, application templates, workflows, and previews based on Figma designs. This project implements CRUD (Create, Read, Update, Delete) APIs and stores data in a SQL Server database. It also utilizes dependency injection for better code organization.

This project follows the generic repository pattern for data access, making it highly maintainable and scalable. It leverages AutoMapper for efficient data mapping and Entity Framework Core for robust data handling.

## Table of Contents

- [Features](#features)
- [Getting Started](#getting-started)
- [API Endpoints](#api-endpoints)
- [Database Setup](#database-setup)
- [Dependencies](#dependencies)



## Features

### Tab 1 - Program

- **POST**: Create a new program.
- **GET**: Retrieve program information.
- **GET[id]**: Retrieve program information by id.
- **PUT**: Update program details.
  ![2 1 Program details](https://github.com/faragfady512/FormAPI_TaskBackend/assets/62870970/898a8e1b-bfaa-4e12-846e-13bc3cac8825)
### Tab 2 - Application Template

- **GET**: Retrieve application template user information.
- **PUT**: Update application template user details.
![3  Application template ✅](https://github.com/faragfady512/FormAPI_TaskBackend/assets/62870970/1384c073-b10d-42f3-af54-83271cb7cc5e)
### Tab 3 - Workflow

- **GET**: Retrieve workflow information.
- **PUT**: Update workflow details.
  ![4  Workflow ✅](https://github.com/faragfady512/FormAPI_TaskBackend/assets/62870970/96153973-7598-4c08-a013-56d1529ddbf2)

### Tab 4 - Education and Work Experience

- **GET**: Retrieve workflow information.
- **PUT**: Update workflow details.
![Education and Work Experience form](https://github.com/faragfady512/FormAPI_TaskBackend/assets/62870970/5bb5451f-845b-434a-bf3e-f94858b27d9e)
### Tab 5 - Question

- **GET**: Retrieve Question information.
- **PUT**: Update Question details.


### Tab 4 - Preview

- **GETAll**: Retrieve a summary of program details.
![5  Preview ✅](https://github.com/faragfady512/FormAPI_TaskBackend/assets/62870970/a46a15fa-8972-41cf-9e57-1535aa5ce0c2)

## Getting Started

Follow these steps to set up and run the FormApi__Backend project locally:

1. Clone this repository:

   ```bash
   git clone https://github.com/faragfady512/FormApi__TaskBackend.git

## Database Setup

Before running FormApi__Backend, make sure you have SQL Server installed and create a database for this project. Follow these steps:

1. **Install SQL Server**:
   If you don't have SQL Server installed, download and install [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads).

2. **Create a Database**:
   Create a new database for this project using SQL Server Management Studio (SSMS) or your preferred SQL management tool.

3. **Update Connection String**:
   Update the database connection string in the `appsettings.json` file with your SQL Server configuration. Replace `YourDatabaseName`, `YourUsername`, and `YourPassword` with your actual database information.

   Example connection string:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost;Database=YourDatabaseName;User Id=YourUsername;Password=YourPassword;"
   }
## Dependencies

FormApi__Backend relies on the following dependencies:

- **.NET 5**: The application is built on .NET 5, which provides a powerful runtime and a wide range of libraries for developing robust web applications.

- **Entity Framework Core**: Entity Framework Core is the primary framework used for data access in this project. It allows for seamless interaction with the database, simplifying database-related operations and improving data management.

- **AutoMapper**: AutoMapper is used to simplify the mapping between data transfer objects (DTOs) and models within the application. This enhances code maintainability and readability by reducing the complexity of data mapping.

- **Other Dependencies**: In addition to the mentioned dependencies, there may be other specific dependencies relevant to your project. Be sure to include any such dependencies in this section along with their roles in the project.

Make sure to have these dependencies properly configured in your development environment to run the project successfully.

