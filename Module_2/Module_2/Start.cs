using Module_2.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2
{
    public class Start
    {
        public void Go()
        {
            bool flag = true;
            Apartment apartment = new Apartment();
            ThreeRoomApartment First = new ThreeRoomApartment(1, 15000, true);
            OneRoomApartment Second = new OneRoomApartment(2, 5000, true);
            TwoRoomApartment Third = new TwoRoomApartment(3, 5300, false);
            ThreeRoomApartment Fourth = new ThreeRoomApartment(4, 14000, true);
            OneRoomApartment Fifth = new OneRoomApartment(5, 3000, true);
            TwoRoomApartment Sixth = new TwoRoomApartment(6, 8000, true);
            ThreeRoomApartment Seventh = new ThreeRoomApartment(7, 13500, false);
            OneRoomApartment Eighth = new OneRoomApartment(8, 8000, true);
            TwoRoomApartment Ninth = new TwoRoomApartment(9, 9100, false);
            ThreeRoomApartment Tenth = new ThreeRoomApartment(10, 8000, true);
            OneRoomApartment Eleventh = new OneRoomApartment(11, 6000, true);
            TwoRoomApartment Twelfth = new TwoRoomApartment(12, 7200, true);
            ThreeRoomApartment Thirteenth = new ThreeRoomApartment(13, 11000, true);
            OneRoomApartment Fourteenth = new OneRoomApartment(14, 5800, false);
            TwoRoomApartment Fifteenth = new TwoRoomApartment(15, 8500, true);
            IRent[] entrance = new IRent[15] { First, Second, Third, Fourth, Fifth, Sixth, Seventh, Eighth, Ninth, Tenth, Eleventh, Twelfth, Thirteenth, Fourteenth, Fifteenth };
            ApartmentsForRent home1 = new ApartmentsForRent(entrance);
            ConsoleService consoleService = new ConsoleService();

            apartment.Info();
            Console.WriteLine("___________________________________________________");

            while (flag)
            {
                consoleService.Do(flag, home1);
            }
        }
    }
}
