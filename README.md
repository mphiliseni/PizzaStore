# PizzaStore API



<img width="1436" alt="Screenshot 2025-05-06 at 15 22 44" src="https://github.com/user-attachments/assets/56535713-b3e5-4cd7-8fd5-f6da0ead0651" />

Here’s a formative README file for the **PizzaStore API**, tailored to provide a comprehensive overview of the project:

---

# PizzaStore API

Welcome to the **PizzaStore API**, a backend service built to streamline the operations of a pizza store. This API, developed entirely in **C#**, provides robust functionality for managing pizza orders, menus, and customer details.

## Table of Contents
- [Overview](#overview)
- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Running the API](#running-the-api)
- [API Endpoints](#api-endpoints)
- [Technologies Used](#technologies-used)
- [Contributing](#contributing)
- [License](#license)

---

## Overview

The **PizzaStore API** is a comprehensive backend solution that allows a pizza store to manage its operations efficiently. It handles orders, maintains the menu, and provides customer management capabilities for a seamless ordering experience.

## Features

- **Menu Management**: Add, update, and remove pizza items from the menu.
- **Order Processing**: Place, update, and track pizza orders in real-time.
- **Customer Management**: Manage customer information and order history.
- **Secure API**: Built-in authentication and authorization for secure access.
- **Scalable Design**: Modular architecture to support future growth.

## Getting Started

### Prerequisites

Before you begin, ensure you have the following installed on your machine:

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or any other supported database
- [Git](https://git-scm.com/)

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/mphiliseni/PizzaStore.git
   cd PizzaStore
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

3. Set up the database:
   - Update the `appsettings.json` file with your database connection string.
   - Apply migrations to create the database schema:
     ```bash
     dotnet ef database update
     ```

### Running the API

1. Start the development server:
   ```bash
   dotnet run
   ```

2. The API will be available at `https://localhost:5001` or `http://localhost:5000`.

## API Endpoints

Below are some of the key API endpoints:

- **GET /api/menu**: Retrieve the list of available pizzas.
- **POST /api/menu**: Add a new pizza to the menu.
- **PUT /api/menu/{id}**: Update a pizza's details.
- **DELETE /api/menu/{id}**: Remove a pizza from the menu.

- **POST /api/orders**: Place a new order.
- **GET /api/orders/{id}**: Retrieve order details by ID.
- **PATCH /api/orders/{id}/status**: Update the status of an order.

- **GET /api/customers**: Retrieve a list of customers.
- **GET /api/customers/{id}**: Retrieve details of a specific customer.

For detailed documentation, refer to the Swagger UI available at `https://localhost:5001/swagger`.

## Technologies Used

- **Language**: C#
- **Framework**: ASP.NET Core
- **Database**: SQL Server or other supported databases
- **ORM**: Entity Framework Core

## Contributing

We welcome contributions to the **PizzaStore API**! To contribute:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-name`).
3. Commit your changes (`git commit -m 'Add some feature'`).
4. Push the branch (`git push origin feature-name`).
5. Open a Pull Request.

## License

This project is licensed under the [MIT License](LICENSE).

---

