
using System;

namespace CovjeceNeLjutiSe
{
    class Program
    {
        static void Main(string[] args)
        {
          Random random = new Random();
           int bacanje = random.Next(1, 7);
            int bacanje1 = random.Next(1, 7);
            int bacanje2 = random.Next(1, 7);
            Console.WriteLine(bacanje);
            Console.WriteLine(bacanje1);
            Console.WriteLine(bacanje2);

            Console.ReadKey();
            Console.Beep();
        }
    }
}