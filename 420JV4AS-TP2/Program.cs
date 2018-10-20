using System;

namespace _420JV4AS_TP2
{

    class Program
    {
        static void Main(string[] args)
        {
            char exit = 'a';
            while(exit!='e')
            {
                int x=10;
                int y=14;

                //x=Console.Read();
                //y=Console.Read();

                Data.Init(20, 20);
                Data.SwitchOcupation(1, 1);
                Data.SwitchOcupation(1, 2);
                Data.SwitchOcupation(2, 1);
                Data.SwitchOcupation(8, 8);
                Data.SwitchOcupation(8, 7);
                Data.SwitchOcupation(7, 8);
                Data.SwitchOcupation(1, 8);
                Data.SwitchOcupation(2, 8);
                Data.SwitchOcupation(1, 7);
                Data.SwitchOcupation(8, 1);
                Data.SwitchOcupation(8, 2);
                Data.SwitchOcupation(7, 1);

                Data.SwitchOcupation(14, 1);
                Data.SwitchOcupation(14, 2);
                Data.SwitchOcupation(14, 3);
                Data.SwitchOcupation(14, 4);
                //Data.BressenhamOnce(3, 2, 0, 2);
                Data.BressenhamAll(x,y);
                Data.Draw();

                int s = Console.Read();
                exit = (char)s;
                
            }
        }
    }
}
