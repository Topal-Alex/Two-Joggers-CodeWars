using System;
using System.Linq;


namespace ConsoleApplication1
{
    class  Program
    {
        static void Main(string[] args)
        {
            NbrOfLaps(6, 3);

        }
        public static Tuple<int, int> NbrOfLaps(int x, int y)
        {
            int gcd = x;
            while(gcd%y != 0)
            {
                gcd+=x;
            }
  
            
            
            return new Tuple<int, int>(gcd/x, gcd/y);
        }
    }
}