using System;
using System.Collections.Generic;
using System.IO;


namespace _420JV4AS_TP2
{

    class Program
    {

        static void Main(string[] args)
        {
            var observers = new List<Pos>()
            {
                new Pos(2,4),
                //new Pos(8,13),
                new Pos (11,9)
            };
            Data.ReadObstacleMap();
            foreach (var p in observers)
            {
                Data.BressenhamAll(p.x, p.y);
            }
            Data.Draw(0);
            Console.ReadKey();


        }
    }
}
