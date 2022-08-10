using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FoodCourtManagement
{
    public class Reports
    {
        public Reports()
        {
            using (FileStream fs = new FileStream(@"D:\CSFiles\FoodItems.txt", FileMode.Open))
            {
                StreamReader sr = new StreamReader(fs);
                while (sr.Peek() > 0)
                {
                    Console.WriteLine("Report of Food Items");
                    Console.WriteLine(sr.ReadLine());
                }
            }
            using (FileStream fs = new FileStream(@"D:\CSFiles\FoodCategory.txt", FileMode.Open))
            {
                StreamReader sr = new StreamReader(fs);
                while (sr.Peek() > 0)
                {
                    Console.WriteLine("Report of Food Category");
                    Console.WriteLine(sr.ReadLine());
                }
            }
            using (FileStream fs = new FileStream(@"D:\CSFiles\Sales.txt", FileMode.Open))
            {
                StreamReader sr = new StreamReader(fs);
                while (sr.Peek() > 0)
                {
                    Console.WriteLine("Sales Report");
                    Console.WriteLine(sr.ReadLine());
                }
            }
        }
    }
}