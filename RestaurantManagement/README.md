
## Setup Instructions

1. **Create the database**  
   Open **SQL Server Management Studio (SSMS)** and create a new database named:
   ```
   RestaurantDB
   ```

2. **Run Database Migration**  
   Open the project `RestaurantManagement` and go to:  
   `Tools` > `NuGet Package Manager` > `Package Manager Console` > `Default project`: DataLayer  
   Then run the following command:
   ```bash
   Update-Database
   ```

3. **Default Account**  
   Use the following credentials to log in:
   ```
   Username: admin
   Password: Admin@123
   ```

## Requirements

- Microsoft Visual Studio 2022  
- Microsoft SQL Server 2019
