using System;
using System.Collections.Generic;
using System.Linq;
namespace Assign5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> PrimeMinister = new Dictionary<int,string>();
            PrimeMinister.Add(1998, "Atal Bihari Vajpayee");
            PrimeMinister.Add(2014, "Narendra Modi");
            PrimeMinister.Add(2004, "Manmohan Singh");

            Console.WriteLine(PrimeMinister[2004]);

            PrimeMinister.Add(2019, "Narendra Modi");
            Console.WriteLine();


            var val = from ele in PrimeMinister
                      orderby ele.Key ascending
                      select ele;

            foreach (var item in val)
            {
                Console.WriteLine(item);
            }


        }
    }
}
