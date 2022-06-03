using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2
{
    internal class ConsoleService
    {
        public void Do(bool flag, ApartmentsForRent home)
        {
            Console.WriteLine("Make your choice:\n1) All info of entrance\n2) Filter available apartments by price\n3) Filter available apartments by number of rooms\n4) Find By Price\n5) Rent\n6) Close the program");
            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    home.AllInfo();
                    break;
                case "2":
                    home.FiltfilterByPrice();
                    break;
                case "3":
                    home.FiltfilterByNumberOfRooms();
                    break;
                case "4":
                    Console.WriteLine("Enter the minimum price");
                    string min = Console.ReadLine();
                    Console.WriteLine("Enter the maximum price");
                    string max = Console.ReadLine();
                    home.FindByPrice(Convert.ToInt32(min), Convert.ToInt32(max));
                    break;
                case "5":
                    Console.WriteLine("Enter the number of apartment");
                    string number = Console.ReadLine();
                    home.Rent(Convert.ToInt32(number));
                    break;
                case "6":
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Make a choice from the options\n");
                    break;
            }
        }
    }
}
