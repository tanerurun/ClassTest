﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerveReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1= sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);


            Console.ReadKey();

        }
    }
}
