# 🚗 Car Renting

![Visual Studio](https://img.shields.io/badge/Built%20With-Visual%20Studio%202026-blueviolet?logo=visualstudio)
![.NET](https://img.shields.io/badge/.NET-WinForms-orange?logo=dotnet)
![SQL Server](https://img.shields.io/badge/Database-SQL%20Server-red?logo=microsoftsqlserver)
![License: Free](https://img.shields.io/badge/license-Educational-lightgrey)

**Car Renting** is a simple Windows Forms application that provides a functional car-rental management system with separate user and administrator roles. The application demonstrates WinForms UI, SQL Server connectivity, and complete CRUD functionality in C#.

---

## ✨ Features

### **User Side**
- **🔐 Registration & Authentication**
  - **Comprehensive Registration:** New users must register with full details including Name, Email, Residential Address, Mobile Number, Username, and Password (no duplicates will be allowed).
  - **Auto-Redirection:** Upon successful registration, users are automatically redirected to the Login screen. Once logged in, they are taken directly to the Booking Interface.

- **🚙 Booking Workflow**
  - **Category-Based Selection:** Users start by selecting a vehicle category (e.g., **Sedan, Luxury, SUV, Pick-Drop**).
  - **Date & Availability Check:**
    - A dedicated Date Panel opens to select "From Date" and "To Date".
    - The system filters the fleet and displays only those vehicles available for the selected dates.
  - **Invoice Generation:**
    - Clicking "Book Now" generates an instant invoice displaying **Car Model**, **Total Days** and **Total Bill** etc.
    - Clicking "Submit" confirms the booking and adds it to the **"My Bookings"** section.

- **💳 Payments & History**
  - **My Bookings:** A dedicated section where users can view their booking history.
  - **Action Buttons:** Users can choose to either **Pay** or **Cancel** a booking.
  - **Dummy Payment Gateway:**
    - If "Pay Now" is selected, a simulation payment screen appears.
    - Supports two payment modes: **Debit/ Credit Card** OR **UPI/ QR**.

### **Admin Side**
- **🛡️ Admin Dashboard**
  - **Fixed Login:** Secure access via credentials (Username: `admin`, Password: `admin123`).
  - **Central Hub:** The admin dashboard serves as the main controller, linking to all management subsystems.

- **🛠️ Management Modules (CRUD)**
  - **Car Management:** Full control to Add, Update, Delete, or View vehicles in the fleet.
  - **User Management:** Monitor and manage registered user accounts.
  - **Rental Management:** Oversee all active and past rental records.

- **💰 Revenue Analytics**
  - **Revenue Section:** A Dedicated screen that calculates and displays the **Total Revenue** generated from all completed bookings.
    
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
   - Load the `final.sln` file.

3. **Update SQL Connection**
   - Replace the local connection string path with yours inside the code.

4. **Tables**
 
| Name             | Column                                                                                                |
|------------------|-------------------------------------------------------------------------------------------------------|
| carManegement    | Id , brand , model , rentPerDay , availability , type , ImagePath                                     |
| userManagement   | Id , fullName , mobileNo , email , address , userName , password                                      |
| rentalManagement | Id , CarModel , TotalDays , FromDate , ToDate , RentPerDay , TotalBilling , PaymentStatus , username  |

5. **Run the Project**
   - Press `ctrl + F5` or click `Start`.

> ⚠️ *Ensure SQL Server is installed and the required tables exist. You may need to create them manually based on code.*

---

## 🙌 Acknowledgments

- Project by **coder-dev-sys**
- Slight assistance via AI-coding tools
