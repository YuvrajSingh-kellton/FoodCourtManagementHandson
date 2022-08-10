using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FoodCourtManagement
{
    public class Sales
    {
        public Sales()
        {
            FileStream fs = new FileStream(@"D:\CSFiles\Sales.txt", FileMode.OpenOrCreate);
        TOP:
            Console.WriteLine("1. Adding new Sales");
            Console.WriteLine("2. Edit existing Sales");
            Console.WriteLine("3. View details of Sales");
            Console.WriteLine("4. Show all Sales");
            Console.WriteLine("5. For Exit()");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Add(fs);
                    fs.Close();
                    break;
                case 2:
                    Edit(fs);
                    fs.Close();
                    File.Delete(@"D:\CSFiles\Sales.txt");
                    File.Move(@"D:\CSFiles\Sales1.txt", @"D:\CSFiles\Sales.txt");
                    break;
                case 3:
                    ShowOne(fs);
                    fs.Close();
                    break;
                case 4:
                    ShowAll(fs);
                    fs.Close();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Entered wrong option");
                    goto TOP;
            }
        }
        void Add(FileStream fs)
        {
            StreamWriter sw = new StreamWriter(fs);
            Console.Write("Enter in this order(FoodCategory GeneratedRupees) - ");
            sw.WriteLine(Console.ReadLine());
            sw.Close();
        }
        void Edit(FileStream fs)
        {
            StreamReader sr = new StreamReader(fs);
            Console.Write("Existing Value - ");
            string existingvalue = Console.ReadLine();
            Console.Write("Replace it with - ");
            string currentValue = Console.ReadLine();
            string store = sr.ReadToEnd();
            if (store.Contains(existingvalue))
            {
                store.Replace(existingvalue, currentValue);
            }
            using (FileStream fs2 = new FileStream(@"D:\CSFiles\Sales1.txt", FileMode.Create, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(fs2);
                sw.WriteLine(store);
            }
            sr.Close();
        }
        void ShowOne(FileStream fs)
        {
            Console.Write("Enter sales category of which you want to see details - ");
            string ans = Console.ReadLine();
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() > 0)
            {
                string value = sr.ReadLine();
                if (value.Contains(ans))
                {
                    Console.WriteLine(value);
                }
            }
            sr.Close();
        }
        static void ShowAll(FileStream fs)
        {
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() > 0)
            {
                Console.WriteLine(sr.ReadLine());
            }
        }
    }
}