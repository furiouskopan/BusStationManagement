using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationInterface.Utilities
{
    public static class UserSession
    {
        public static int CurrentEmployeeId { get; private set; }
        public static string CurrentUserRole { get; private set; }
        public static string CurrentEmployeeName { get; private set; }

        public static void StartSession(int employeeId, string role, string name)
        {
            CurrentEmployeeId = employeeId;
            CurrentUserRole = role;
            CurrentEmployeeName = name;
        }

        public static void EndSession()
        {
            CurrentEmployeeId = 0;
            CurrentUserRole = null;
            CurrentEmployeeName = null;
        }
    }
}
