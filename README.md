# 🚗 Car Renting

![Visual Studio](https://img.shields.io/badge/Built%20With-Visual%20Studio%202022-blueviolet?logo=visualstudio)
![.NET](https://img.shields.io/badge/.NET-WinForms-orange?logo=dotnet)
![SQL Server](https://img.shields.io/badge/Database-SQL%20Server-red?logo=microsoftsqlserver)
![License: Free](https://img.shields.io/badge/license-Educational-lightgrey)

**Car Renting** is a simple Windows Forms application that provides a functional car-rental management system with separate user and administrator roles. The application demonstrates WinForms UI, SQL Server connectivity, and complete CRUD functionality in C#.

---

## ✨ Features
- **User Side :**  
  - **Registration & Login**  
    - New users will have to register with a unique username/password (no duplicates will be allowed).  
    - Registered users can log in to access the booking interface.  
  - **Vehicle Listing & Booking**  
    - Available vehicles are displayed in The List.  
    - By clicking a vehicle row will auto-populate booking fields (Vehicle ID, Brand, Model, etc).  
    - Users have to select “From Date” and “To Date” before booking and the app calculates total days and total bill automatically.  
    - Real-time availability check: if a vehicle is unavailable, booking is blocked and an error message is shown.  

- **Admin Side :**  
  - **Fixed Admin Login**  
    - Username: `admin`  
    - Password: `admin123@`  
    - Successful login opens the Admin Dashboard.  
  - **Dashboard with Counters**  
    - Three main buttons which even displays record counts: 
    1. **Vehicle Management**
        - View all registered vehicles.  
        - Add new vehicles (Brand, Model, Rent Per Day, Availability).  
        - Edit or delete or clear existing vehicles. 
    2. **User Management**  
        - View all registered users.  
        - Insert or Edit user accounts.    
    3. **Rental Management**  
        - View all bookings (Booking ID, Customer Name, Vehicle Model, From/To dates, Total Bill).
        - Insert or Cancel bookings as completed.  

---

## 📦 Tech Stack

| Layer                 | Technologies Used                                   |  
|-----------------------|-----------------------------------------------------|
| Language & Framework  |  C# (WinForms)                                      |
| Database              | Microsoft SQL Server 2022 (Connected Architecture)  |
| Data Access           | `Microsoft.Data.SqlClient` NuGet package  	        |

---

## ⚙️ Setup Instructions (Quick)

1. **Clone the repository**
   ```bash
   git clone https://github.com/Coder-dev-sys/Car_Renting.git
   ```

2. **Open in Visual Studio 2022**
   - Load the `Car_Renting.sln` file.

3. **Update SQL Connection**
   - Replace the local connection string path with yours inside the code.

4. **Tables**
 
| Name             | Column                                                       |
|------------------|--------------------------------------------------------------|
| carManegement    | Id , brand , model , rentPerDay , availability               |
| userManagement   | Id , fullName , mobileNo , address , userName , password     |
| rentalManagement | Id , custFullName , carModel , fromDate , toDate , rentBill  |

5. **Run the Project**
   - Press `F5` or click `Start`.

> ⚠️ *Ensure SQL Server is installed and the required tables exist. You may need to create them manually based on code.*

---

## 🙌 Acknowledgments

- Project by **coder-dev-sys**
- Slight assistance via AI-coding tools
