using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class User
    {
        public string Username { get; set; }

        public INotificationService notificationService;
        public User (string name, INotificationService notificationService)
        {
            this.Username = name;
            this.notificationService = notificationService;
        }

        public void ChangeName(string newName)
        {
            this.Username = newName;
            this.notificationService.NotifyChangedUserName(this);
        }

        public void PrintName()
        {
            Console.WriteLine($"Current user name is {this.Username}");
        }
    }
}
