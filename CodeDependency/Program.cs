using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Anand");
            user.PrintName();

            user.ChangeName("Namdev");
            user.PrintName();
        }
    }
}
