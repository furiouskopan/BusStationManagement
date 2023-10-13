﻿using BusStationInterface.Data;
using BusStationInterface.Models;
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
    //public Bus GetBusById(int busID)
    //{
    //    using (var context = new BusManagementContext())
    //    {
    //        return context.Buses.FirstOrDefault(b => b.BusID == busID);
    //    }
    //}
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
    //public Driver GetDriverById(int driverID)
    //{
    //    using (var context = new BusManagementContext())
    //    {
    //        return context.Drivers.FirstOrDefault(b => b.DriverID == driverID);
    //    }
    //}

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

