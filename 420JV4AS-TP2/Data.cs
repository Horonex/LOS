using System;

namespace _420JV4AS_TP2
{
    static class Data
    {
        static bool[,] gridOcuppied = new bool[,] {
            { false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false }};

        static char[,] gridOutput = new char[,]{
            {'?','?','?','?','?','?','?','?','?','?' },
            {'?','?','?','?','?','?','?','?','?','?' },
            {'?','?','?','?','?','?','?','?','?','?' },
            {'?','?','?','?','?','?','?','?','?','?' },
            {'?','?','?','?','?','?','?','?','?','?' },
            {'?','?','?','?','?','?','?','?','?','?' },
            {'?','?','?','?','?','?','?','?','?','?' },
            {'?','?','?','?','?','?','?','?','?','?' },
            {'?','?','?','?','?','?','?','?','?','?' },
            {'?','?','?','?','?','?','?','?','?','?' }};

        static char vissible = ' ';
        static char invissible = '.';
        static char observer = 'o';
        static char obstacle = 'H';
        static char defaultC = '?';


        static public void Init(int x,int y)
        {
            gridOcuppied = new bool[x, y];
            gridOutput = new char[x, y];
            for(int i=0;i<x;i++)
            {
                for (int j = 0; j < y; j++)
                {
                    gridOcuppied[i,j] = false;
                    gridOutput[i, j] = defaultC;
                }
            }

        }

        static public void SwitchOcupation(int x,int y)
        {
            gridOcuppied[x, y] = !gridOcuppied[x, y];
            gridOutput[x, y] = obstacle;
        }

        static public void BressenhamAll(int ox, int oy)
        {
            int lenght = gridOutput.GetLength(0);
            int hight = gridOutput.GetLength(1);
            for(int i=0;i<lenght;i++)
            {
                BressenhamOnce(ox, oy, i, 0);
                BressenhamOnce(ox, oy, i, lenght-1);
            }
            for(int j =1;j<hight-1;j++)
            {
                BressenhamOnce(ox, oy, 0, j);
                BressenhamOnce(ox, oy, hight-1, j);

            }
            gridOutput[ox, oy] = observer;
        }

        static public void BressenhamOnce(int x1, int y1, int  x2, int y2)
        {
            PlotLine(x1, y1, x2, y2);
        }

        static public void PlotLineLow(int x0, int y0, int x1, int y1)
        {
            char c = vissible;
            int dx = x1 - x0;
            int dy = y1 - y0;
            int yi = 1;
            if (dy < 0)
            {
                yi = -1;
                dy = -dy;
            }
            int D = 2 * dy - dx;
            int y = y0;
            for (int i = x0; i <= x1; i++)
            {
                if (gridOutput[i, y] == defaultC || gridOutput[i, y] == invissible)
                    gridOutput[i, y] = c;
                if (gridOcuppied[i, y])
                {
                    c = invissible;
                    gridOutput[i, y] = obstacle;
                }
                if (D > 0)
                {
                    y = y + yi;
                    D = D - 2 * dx;
                }
                D = D + 2 * dy;
            }

        }
        static public void PlotLineLow(int x1, int y1, int x0, int y0,bool rev)
        {           
            char c = vissible;
           
            int dx = x1 - x0;
            int dy = y1 - y0;
            int yi = 1;
            int ax = x1 + x0;
            int ay = y1 + y0;
            if (dy < 0)
            {
                yi = -1;
                dy = -dy;
            }
            int D = 2 * dy - dx;
            int y = y0;
            for (int i = x0; i <= x1; i++)
            {
                if (gridOutput[ax - i, ay - y] == defaultC || gridOutput[ax - i, ay - y] == invissible)
                    gridOutput[ax - i, ay - y] = c;
                if (gridOcuppied[ax - i, ay - y])
                {
                    c = invissible;
                    gridOutput[ax-i, ay-y] = obstacle;
                }
                if (D > 0)
                {
                    y = y + yi;
                    D = D - 2 * dx;
                }
                D = D + 2 * dy;
            }
        }
        static public void PlotLineHigh(int x0, int y0, int x1, int y1)
        {
            char c = vissible;
            int dx = x1 - x0;
            int dy = y1 - y0;
            int xi = 1;
            if (dx < 0)
            {
                xi = -1;
                dx = -dx;
            }
            int D = 2 * dx - dy;
            int x = x0;
            for (int i = y0; i <= y1; i++)
            {
                if (gridOutput[x, i] == defaultC || gridOutput[x, i] == invissible)
                    gridOutput[x, i] = c;
                if (gridOcuppied[x, i])
                {
                    c = invissible;
                    gridOutput[x, i] = obstacle;
                }
                if (D > 0)
                {
                    x = x + xi;
                    D = D - 2 * dy;
                }
                D = D + 2 * dx;
            }
        }
        static public void PlotLineHigh(int x1, int y1, int x0, int y0,bool rev)
        {
            char c = vissible;
            int dx = x1 - x0;
            int dy = y1 - y0;
            int xi = 1;
            int ax = x1 + x0;
            int ay = y1 + y0;
            if (dx < 0)
            {
                xi = -1;
                dx = -dx;
            }
            int D = 2 * dx - dy;
            int x = x0;
            for (int i = y0; i <= y1; i++)
            {
                if(gridOutput[ax - x, ay - i]== defaultC || gridOutput[ax - x, ay - i] == invissible)
                gridOutput[ax-x, ay-i] = c;
                if (gridOcuppied[ax-x,ay- i])
                {
                    c = invissible;
                    gridOutput[ax-x, ay-i] = obstacle;
                }
                if (D > 0)
                {
                    x = x + xi;
                    D = D - 2 * dy;
                }
                D = D + 2 * dx;
            }
        }

        static public void PlotLine(int x0, int y0, int x1, int y1)
        {
            if( Math.Abs(y1-y0)< Math.Abs(x1 - x0))
            {
                if (x0 > x1)
                {
                    //rev
                    PlotLineLow(x0, y0, x1, y1,true);
                }
                else
                {
                    
                    PlotLineLow( x0, y0,x1, y1);
                }   
            }
            else
            {
                if(y0>y1)
                {
                    //rev
                    PlotLineHigh(x0, y0, x1, y1,true);
                }
                else
                {
                    PlotLineHigh(x0, y0, x1, y1);
                }
            }
        }


        static public void Draw()
        {
            for(int i=0;i< gridOutput.GetLength(0);i++)
            {
                for(int j=0;j< gridOutput.GetLength(1);j++)
                {
                    Console.Write(gridOutput[j, i] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}














