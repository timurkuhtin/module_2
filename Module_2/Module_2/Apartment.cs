using Module_2.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2
{
    public class Apartment : Object, IRent
    {
        public int Price = 0;
        public int Number = 0;
        public int NumberOfRooms = 0;
        public bool Freedom = true;

        int IRent.Price => Price;
        bool IRent.Freedom { get => Freedom; set { Freedom = value; } }
        int IRent.NumberOfRooms => NumberOfRooms; 

        public Apartment(int number, int price, bool freedom)
        {
            Number = number;
            Price = price;
            Freedom = freedom;
        }

        public Apartment()
        {
        }

        public void Info()
        { 
            if (this.Freedom)
            {
                Console.WriteLine("Apartment number: {0}, Price:{1}, Freedom{2}, ", this.Number, this.Price, this.Freedom);
            }
            else
            {
                Console.WriteLine("Apartment number: {0}, The apartment is not for rent", this.Number);
            }
        }
    }
}
