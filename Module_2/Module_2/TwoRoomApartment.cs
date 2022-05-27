using Module_2.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2
{
    public class TwoRoomApartment : Apartment, IRent
    {
        public new int Price;

        public new bool Freedom;

        public new int NumberOfRooms = 2;

        public TwoRoomApartment(int number, int price, bool freedom) : base(number, price, freedom)
        {
            Number = number;
            Price = price;
            Freedom = freedom;
        }

        public new void Info()
        {

            if (this.Freedom)
            {
                Console.WriteLine("Apartment number: {0}, Price:{1}, Freedom{2}, Two room", this.Number, this.Price, this.Freedom);
            }
            else
            {
                Console.WriteLine("Apartment number: {0}, The apartment is not for rent", this.Number);
            }
        }
    }
}
