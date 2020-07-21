using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class ConsoleNotification
    {
        public void ChangedName(User user)
        {
            Console.WriteLine($"The name is changed to: {user.Username}");
        }
    }
}
