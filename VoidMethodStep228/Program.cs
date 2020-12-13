using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodStep228
{
    class Program
    {
        static void Main(string[] args)
        {
            SeatBucket seat = new SeatBucket();
            seat.Add(4,  5);
            seat.Add(alpha: 6, bravo: 7);

            Console.ReadLine();
        }
    }
}
