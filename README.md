# EventEase - Cloud-Based Event Booking System

Welcome to **EventEase**, a cloud-based web application that allows users to book events online with ease. Built with **ASP.NET Core MVC**, the system integrates with **Azure Blob Storage** for secure image uploads and uses **Entity Framework Core** for database operations.

## 🚀 Features

- ✅ Add and manage bookings
- ✅ Display confirmation messages after booking
- ✅ Upload and manage images via Azure Blob Storage
- ✅ Validate booking inputs with real-time feedback
- ✅ Search bookings by event name or ID
- ✅ Prevent double bookings
- ✅ Hosted on Microsoft Azure (if deployed)

## 🔧 Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server LocalDB
- Azure Blob Storage
- Bootstrap (UI styling)

## 📁 Project Structure

```bash
ST10384670Cloud2/
│
├── Controllers/
│   └── BookingsController.cs       # Handles booking logic
│
├── Models/
│   └── Bookings.cs                 # Booking data model
│
├── Services/
│   └── BlobStorageServices.cs     # Azure blob service logic
│
├── Views/
│   ├── Bookings/
│   │   ├── Add.cshtml             # Booking form
│   │   ├── Index.cshtml           # List of bookings
│   │   └── BookingConfirmation.cshtml (optional)
│
├── wwwroot/                       # Static files (CSS, JS, images)
│
├── appsettings.json              # Configuration file with DB and Azure keys
├── Program.cs                    # Main application startup
├── Startup.cs (if used)          # Configuration (for .NET 5 or earlier)
└── README.md                     # Project documentation
