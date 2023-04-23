<h1 align="center">SQL Explorer</h1>!

![github](https://user-images.githubusercontent.com/116961227/233852156-3d06b147-e4c5-4343-a67d-939bac280764.png)

<p align="center">
  <img src="https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C# Badge"/>
  <img src="https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white" alt=".NET Badge"/>
</p>

# 📖 Project Overview
The SQL application is a C# program that provides a graphical user interface (GUI) for exploring the contents of a SQL Server database. The application allows users to connect to a SQL Server instance, execute queries, and view the results in a DataGridView control. The application uses ADO.NET and async/await to provide efficient interaction with the database.

# ✔️ Features
The SQL application includes the following features:
- Connection management: users can connect to a SQL Server instance using Windows authentication or a SQL Server login.
- Query execution: users can execute SQL queries and view the results in a DataGridView control.
- Fake data generation: the application provides a utility method for generating fake data and inserting it into the database for practice purposes.
- Asynchronous execution: the application uses async/await to avoid blocking the UI thread when interacting with the database.

## 🚀 Getting Started
1. Open the solution file (.sln).
2. Build the project in Realese (x86) or Release (x64).

## 🧪 Usage
```
1. Change the connection string in the Constants.cs class to your own database. The one in this code is an example database stored locally on my machine.
2. Change the table in the ConnectAsync method
```

## Demonstration
https://user-images.githubusercontent.com/116961227/233852640-7aebeeff-2a7f-4b7e-aca2-6a41a4bd2ba1.mp4
