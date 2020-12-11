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
            seat.Alpha = 4;
            seat.bravo = 4;
            seat.Add();
            Console.ReadLine();
        }
    }
}
