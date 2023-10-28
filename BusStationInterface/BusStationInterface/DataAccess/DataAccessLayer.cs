using BusStationInterface.Data;
using BusStationInterface.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

public class BusDataAccess
{
    public List<Bus> GetBuses()
    {
        using (var context = new BusManagementContext())
        {
            return context.Buses.ToList();
        }
    }
    public void UpdateBus(Bus updatedBus)
    {
        using (var context = new BusManagementContext())
        {
            context.Buses.Update(updatedBus);
            context.SaveChanges();
        }
    }
    public void AddBus(Bus newBus)
    {
        using (var context = new BusManagementContext())
        {
            context.Buses.Add(newBus);
            context.SaveChanges();
        }
    }
    public void DeleteBus(int busID)
    {
        using (var context = new BusManagementContext())
        {
            Bus busToDelete = context.Buses.FirstOrDefault(b => b.BusID == busID);
            if (busToDelete != null)
            {
                context.Buses.Remove(busToDelete);
                context.SaveChanges();
            }
        }
    }
}
public class DriverDataAccess
{
    public List<Driver> GetDrivers()
    {
        using (var context = new BusManagementContext())
        {
            return context.Drivers.ToList();
        }
    }
    public void UpdateDriver(Driver updatedDriver)
    {
        using (var context = new BusManagementContext())
        {
            context.Drivers.Update(updatedDriver);
            context.SaveChanges();
        }
    }
    public void AddDriver(Driver newDriver)
    {
        using (var context = new BusManagementContext())
        {
            context.Drivers.Add(newDriver);
            context.SaveChanges();
        }
    }
    public void DeleteDriver(int driverID)
    {
        using (var context = new BusManagementContext())
        {
            Driver driver = context.Drivers.FirstOrDefault(d => d.DriverID == driverID);
            if (driver != null)
            {
                context.Drivers.Remove(driver);
                context.SaveChanges();
            }
        }
    }
}
public class DestinationDataAccess
{
    public List<Destination> GetDestinations()
    {
        using (var context = new BusManagementContext())
        {
            return context.Destinations.ToList();
        }
    }

    public void UpdateDestination(Destination updatedDestination)
    {
        using (var context = new BusManagementContext())
        {
            context.Destinations.Update(updatedDestination);
            context.SaveChanges();
        }
    }

    public void AddDestination(Destination newDestination)
    {
        using (var context = new BusManagementContext())
        {
            context.Destinations.Add(newDestination);
            context.SaveChanges();
        }
    }

    public void DeleteDestination(int destinationID)
    {
        using (var context = new BusManagementContext())
        {
            Destination destination = context.Destinations.FirstOrDefault(d => d.DestinationID == destinationID);
            if (destination != null)
            {
                context.Destinations.Remove(destination);
                context.SaveChanges();
            }
        }
    }
}
public class RouteDataAccess
{
    public List<Route> GetRoutes()
    {
        using (var context = new BusManagementContext())
        {
            return context.Routes.ToList();
        }
    }

    public void UpdateRoute(Route updatedRoute)
    {
        using (var context = new BusManagementContext())
        {
            context.Routes.Update(updatedRoute);
            context.SaveChanges();
        }
    }
    public void AddRoute(Route newRoute)
    {
        using (var context = new BusManagementContext())
        {
            context.Routes.Add(newRoute);
            context.SaveChanges();
        }
    }
    public void DeleteRoute(int routeID)
    {
        using (var context = new BusManagementContext())
        {
            Route routeToDelete = context.Routes.FirstOrDefault(r => r.RouteID == routeID);
            if (routeToDelete != null)
            {
                context.Routes.Remove(routeToDelete);
                context.SaveChanges();
            }
        }
    }
    // Method to retrieve routes with related data.
    public List<Route> GetRoutesIncludingDestinations()
    {
        using (var context = new BusManagementContext())
        {
            return context.Routes.Include(r => r.StartDestination).Include(r => r.EndDestination).ToList();
        }
    }
}
public class RouteDetailDataAccess
{
    public List<RouteDetail> GetRouteDetails(int routeId)
    {
        using (var context = new BusManagementContext())
        {
            return context.RouteDetails
                          .Include(rd => rd.Location) // This ensures the Destination data is loaded.
                          .Where(rd => rd.RouteID == routeId)
                          .ToList();
        }
    }
}

public class ScheduleDataAccess
{
    public List<Schedule> GetSchedules()
    {
        using (var context = new BusManagementContext())
        {
            return context.Schedules
                .Include(s => s.StartDestination)
                .Include(s => s.EndDestination)
                .Include(s => s.Bus)
                .Include(s => s.Route)
                    .ThenInclude(r => r.StartDestination)
                .Include(s => s.Route)
                    .ThenInclude(r => r.EndDestination)
                .Include(s => s.Driver)
                .ToList();
        }
    }

    public void UpdateSchedule(Schedule updatedSchedule)
    {
        using (var context = new BusManagementContext())
        {
            context.Schedules.Update(updatedSchedule);
            context.SaveChanges();
        }
    }

    public void AddSchedule(Schedule newSchedule)
    {
        using (var context = new BusManagementContext())
        {
            context.Schedules.Add(newSchedule);
            context.SaveChanges();
        }
    }

    public void DeleteSchedule(int scheduleID)
    {
        using (var context = new BusManagementContext())
        {
            Schedule scheduleToDelete = context.Schedules.FirstOrDefault(s => s.ScheduleID == scheduleID);
            if (scheduleToDelete != null)
            {
                context.Schedules.Remove(scheduleToDelete);
                context.SaveChanges();
            }
        }
    }
}

