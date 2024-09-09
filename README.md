# BusStationManagement

**BusStationManagement** is a Windows Forms application built using .NET Framework, designed to manage bus station operations such as managing bus routes, ticketing, and simulating bus travels along predefined schedules and routes. It integrates with a database to store information related to buses, routes, schedules, drivers, and tickets, providing a complete management tool for bus station administrators.

## Table of Contents

- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Simulation](#simulation)
- [Database](#database)
- [Contributing](#contributing)

## Features

- **Route Management**: Create and manage bus routes between various destinations.
- **Schedule Management**: Assign buses and drivers to routes, and set up travel schedules.
- **Ticketing**: Manage ticket sales, seats, and passengers.
- **Bus Route Simulation**: Simulate a bus traveling along a scheduled route, tracking stops and adjusting seat occupancy dynamically.

## Prerequisites

To run the project, you'll need:

- Visual Studio 2019 or later
- .NET Framework 4.7.2 or higher
- SQL Server for database management

## Installation

1. **Clone the repository:**

    ```bash
    git clone https://github.com/furiouskopan/BusStationManagement.git
    ```

2. **Open the project in Visual Studio:**

    - Launch Visual Studio.
    - Open the `.sln` file from the cloned repository.

3. **Restore NuGet Packages:**

    - Visual Studio should automatically restore the required NuGet packages when the solution is built.
    - If not, restore them manually using:

    ```bash
    Tools > NuGet Package Manager > Manage NuGet Packages for Solution
    ```

4. **Configure the Database:**

    - Open `App.config` and update the connection string to point to your SQL Server instance.

5. **Build the Project:**

    - Build the project using `Ctrl + Shift + B` or via the Build menu in Visual Studio.

6. **Run the Application:**

    - Once the project is successfully built, run the application using `F5` or via the Start button in Visual Studio.

## Usage

### Managing Routes and Schedules:

- From the main interface, you can manage bus routes and schedules, add or remove routes, and assign buses and drivers to routes.

### Simulating Bus Travel:

- Navigate to the simulation feature, choose a route from the drop-down list, and start the simulation to visualize bus stops along the route.
- You can monitor the progress of the simulation and view seat availability in real-time.

### Ticketing and Seats:

- Manage tickets and seat reservations, assign passengers to seats, and track ticket sales.

## Project Structure

The project is structured as follows:

- **Forms**: Contains the UI forms, including `MainForm`, `SimulationForm`, and management forms for routes, schedules, and tickets.
- **Services**: Business logic for handling operations such as bus simulations, seat management, and ticket processing.
- **Models**: Contains the data models representing buses, routes, schedules, tickets, drivers, and more.
- **Data**: Database context (`BusManagementContext`) for managing the database interactions using Entity Framework.

### Key Classes

- **BusSimulationService**: Handles the core logic for simulating a bus traveling along a predefined route.
- **Schedule**, **Ticket**, **Route**: Core models representing the scheduling and ticketing system.
- **Destination**, **Driver**, **Bus**: Models for destinations, buses, and drivers that form the backbone of the simulation.

## Simulation

The bus simulation system allows users to simulate a bus's travel through various stops on a route. The simulation system is implemented in the `BusSimulationService` and controlled via the `SimulationForm`. Features include:

- Simulating stop arrivals.
- Tracking ticket status and marking seats as occupied/unoccupied.
- Delay simulation to mimic real-world travel time between stops.

### Example Simulation Flow

1. **Start Simulation**: Choose a route and click "Start Simulation" to begin.
2. **Track Progress**: Watch the simulation progress and view real-time updates on seat availability and stop arrival.
3. **Stop Simulation**: Click "Stop Simulation" to end the simulation early.

## Database

The project uses Entity Framework to interact with a SQL Server database. Some key tables include:

- **Routes**: Stores information about bus routes.
- **Schedules**: Holds scheduling details for buses, including assigned routes and drivers.
- **Tickets**: Manages ticket reservations, prices, and seat assignments.

### Running Database Migrations

1. Ensure the database connection string is properly configured in `App.config`.
2. Use the Entity Framework migrations to create the database schema:

    ```bash
    Update-Database
    ```

## Contributing

Contributions are welcome! If you'd like to contribute:

1. Fork the repository.
2. Create a new feature branch.
3. Submit a pull request with a detailed description of the changes.
