using System;
using System.Diagnostics;

namespace VezbanjeGita
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Some additional text");
            Console.WriteLine("Hello World again!");
            Console.WriteLine("Some changes from serveerr!!");
            Console.WriteLine("Some changes from locaaal!");

            double [] niz = {1, 2, 3, 5, 1, 9 , 3, 3, 5, 1, 9, 3, 5, 1, 9, 3, 5, 1, 9, 3, 5, 1, 9, 3, 5, 1, 9, 3, 5, 1, 9};
            double sum= 0;
            double sum2= 0;
            var watch = Stopwatch.StartNew();
            for(int i=0;i<niz.Length;i++)
            {
                sum+= niz[i];

            }
            watch.Stop();

            var watch2 = Stopwatch.StartNew();

            foreach(var el in niz)
            {
                sum2+=el;
            }
            watch2.Stop();



            Console.WriteLine("Elapsed={0}, {1}", watch.Elapsed, sum);
            Console.WriteLine("Elapsed={0}, {1}", watch2.Elapsed, sum2);
        }
    }
}
