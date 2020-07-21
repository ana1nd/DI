using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationService notificationService = new NotificationService();
            User user = new User("Anand", notificationService);
            user.PrintName();

            user.ChangeName("Namdev");
            user.PrintName();
        }
    }
}
