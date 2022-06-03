using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2.interfaces
{
    public interface IRent
    {
        public int Price { get; }
        public bool Freedom { get; set; }
        public int NumberOfRooms { get; }
        public void Info();
    }
}
