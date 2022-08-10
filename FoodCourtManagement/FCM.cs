using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourtManagement
{
    public class FCM
    {
        public FCM()
        {
        UP:
            Console.WriteLine("1. Manage Food Items");
            Console.WriteLine("2. Manage Food Category");
            Console.WriteLine("3. Manage Food Sales");
            Console.WriteLine("4. Reports Of Food Items, Food Category, Sales");
            Console.WriteLine("5. Exit ()");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    FoodItems foodItemsObj = new FoodItems();
                    break;
                case 2:
                    FoodCategory foodCategoryObj = new FoodCategory();
                    break;
                case 3:
                    Sales salesObj = new Sales();
                    break;
                case 4:
                    Reports reports = new Reports();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Entered wrong option please try again..");
                    goto UP;
            }
            goto UP;
        }
    }
}