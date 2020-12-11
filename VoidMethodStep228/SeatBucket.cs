using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodStep228
{
    class SeatBucket
    {
        public int Alpha { get; set; }
        public int bravo { get; set; }

        public void Add()
        {
            int whatNumber = Alpha + bravo;
            Console.WriteLine("Math Operation : " + whatNumber + "\nDisplaying second int : " + bravo);
        }
    }
}
