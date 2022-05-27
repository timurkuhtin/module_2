using Module_2.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2
{
    public class ApartmentsForRent 
    {
        
        public IRent[] entrance;

        public ApartmentsForRent(IRent[] Entrance)
        {
            entrance = Entrance;
        }

        public void AllInfo()
        {
            for (int i = 0; i < entrance.Length; i++)
            {
                entrance[i].Info();
            }
            Console.WriteLine("___________________________________________________");
        }

        public void FiltfilterByPrice()
        {
            IRent[] result = entrance;
            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if ((result[i].Price > result[j].Price))
                    {
                        IRent temp;
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].Freedom) 
                {
                    result[i].Info();
                }
            }
            Console.WriteLine("___________________________________________________");
        }

        public void FiltfilterByNumberOfRooms()
        {
            IRent[] result = entrance;
            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if ((result[i].NumberOfRooms > result[j].NumberOfRooms))
                    {
                        IRent temp;
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].Freedom)
                {
                    result[i].Info();
                }
            }
            Console.WriteLine("___________________________________________________");
        }

        public void FindByPrice(int min, int max)
        {
            IRent[] results = new IRent[15];
            for (int i = 0; i < entrance.Length; i++)
            {                
                if ((entrance[i].Price > min) && (entrance[i].Price < max) && (entrance[i].Freedom))
                {
                    for (int j = 0; j < results.Length; j++) 
                    {
                        if (results[j] == null)
                        {
                            results[j] = entrance[i];
                            break;
                        }
                    }
                }                
            }
            int k = 0;
            while(results[k] != null)
            { 
                results[k].Info();                
                k++;
            }
            Console.WriteLine("___________________________________________________");
        }

        public void Rent(int Number)
        {
            if (entrance[Number - 1].Freedom)
            {
                entrance[Number - 1].Freedom = false;
                Console.WriteLine("Deal booked, make payment.");
            }
            else
            {
                Console.WriteLine("the apartment under this number is occupied");
            }
        }
    }
}
