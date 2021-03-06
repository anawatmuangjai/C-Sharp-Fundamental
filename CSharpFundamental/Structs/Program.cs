﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize:
            CoOrds coords1 = new CoOrds();
            CoOrds coords2 = new CoOrds(10, 10);

            //Display results
            Console.Write("CoOrds 1 :");
            Console.WriteLine("x = {0}, y = {1}", coords1.x, coords1.y);

            Console.Write("CoOrds 2 :");
            Console.WriteLine("x = {0}, y = {1}", coords2.x, coords2.y);

            Console.ReadKey();
        }

        public struct CoOrds
        {
            public int x, y;
            public CoOrds(int p1, int p2)
            {
                x = p1;
                y = p2;
            }
        }
    }
}
