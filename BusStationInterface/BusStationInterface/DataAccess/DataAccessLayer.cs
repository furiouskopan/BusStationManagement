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
}

