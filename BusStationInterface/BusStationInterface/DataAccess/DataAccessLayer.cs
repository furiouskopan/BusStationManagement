using BusStationInterface.Data;
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
    public Bus GetBusById(int busID)
    {
        using (var context = new BusManagementContext())
        {
            return context.Buses.FirstOrDefault(b => b.BusID == busID);
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
    public Driver GetDriverById(int driverID)
    {
        using (var context = new BusManagementContext())
        {
            return context.Drivers.FirstOrDefault(b => b.DriverID == driverID);
        }
    }
}

