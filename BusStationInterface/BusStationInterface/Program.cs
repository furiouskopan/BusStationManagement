using BusStationInterface.Data;
using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace BusStationInterface
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Create an instance of your DbContext
            using (var context = new BusManagementContext())
            {
                // Apply pending migrations to create/update the database
                context.Database.Migrate();
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Forms.LoginForm());
            //Application.Run(new Forms.TicketReportsForm());
            Application.Run(new Form1());
        }
    }
}
