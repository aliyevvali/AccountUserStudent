using PraktikaTask.Models;
using System;
using System.Text.RegularExpressions;

namespace PraktikaTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Emil daxil edin :");
            string email = Console.ReadLine();
            Console.WriteLine("Password daxil edin :");
            string password = Console.ReadLine();
            User user1 = new User(email,password);
            Console.WriteLine("ShowInfo-->1 \nCreate new group-->2");
            int choice;

            do
            {
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        user1.ShowInfo();
                        break;
                    case 2:

                    default:
                        break;
                }
            } while (choice!=0);
                
           
            

        }
    }
}
