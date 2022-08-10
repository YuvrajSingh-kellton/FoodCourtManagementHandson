using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FoodCourtManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Food Court Management App");
            Console.WriteLine("Do You Want to go in the App: Yes Or No");
            string option = Console.ReadLine();
            if(option == "No" || option == "NO" || option == "no")
            {
                return;
            }
            FCM fcmobj = new FCM();
        
        }
    }
}