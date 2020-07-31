using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DependencyInjection
{
    public class User
    {
        public string Username { get; set; }

        private ConsoleNotification consoleNotification;

        public User (String name)
        {
            this.Username = name;
            this.consoleNotification = new ConsoleNotification();
        }

        public void PrintName()
        {
            Console.WriteLine($"Name of user is: {this.Username}");
        }

        public void ChangeName(string name)
        {
            this.Username = name;
            this.consoleNotification.ChangedName(this);
        }
    }
}
