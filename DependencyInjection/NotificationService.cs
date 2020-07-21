using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class NotificationService : INotificationService
    {
        public void NotifyChangedUserName(User newUser)
        {
            Console.WriteLine($"New username is {newUser.Username}");
        }
    }
}
