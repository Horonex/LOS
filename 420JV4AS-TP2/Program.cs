using System;
using System.Collections.Generic;

namespace _420JV4AS_TP2
{

    class Program
    {
        static void Main(string[] args)
        {
            var observers = new List<Pos>()
            {
                new Pos(2,4),
                new Pos(8,13),
                new Pos (13,13)
            };
            var obstacles = new List<Pos>()
            {
                new Pos(1,1),
                new Pos(1, 2),
                new Pos(2, 1),
                new Pos(8, 8),
                new Pos(8, 7),
                new Pos(7, 8),
                new Pos(1, 8),
                new Pos(2, 8),
                new Pos(1, 7),
                new Pos(8, 1),
                new Pos(8, 2),
                new Pos(7, 1),
                new Pos(14, 1),
                new Pos(14, 2),
                new Pos(14, 3),
                new Pos(14, 4),
                new Pos(11,11),
                new Pos(11,12),
                new Pos(11,13),
                new Pos(11,14),
                new Pos(11,15),
                new Pos(11,16),
                new Pos(9,15),
                new Pos(8,15),
                new Pos(7,15),
                new Pos(6,15),
                new Pos(5,15),
            };


            char exit = 'a';
            //while(exit!='e')
            {

              

                //x=Console.Read();
                //y=Console.Read();

                Data.Init(20, 20);
               
                foreach(var p in obstacles)
                {
                    Data.SwitchOcupation(p.x, p.y);
                }

                foreach(var p in observers)
                {
                    Data.BressenhamAll(p.x,p.y);
                }
                Data.Draw();

                int s = Console.Read();
                exit = (char)s;
                
            }
        }
    }
}
