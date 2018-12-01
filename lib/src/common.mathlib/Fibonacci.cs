using System;

namespace Common.MathLib
{
    public class Fibonacci
    {
        public static int GetBinonacciNumber(int nth)
        {
            switch (nth)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
            }

            var idx = 1;
            int prev = 0, current = 1;
            while(idx < nth)
            {
                var tmp = prev + current;
                prev = current;
                current = tmp;
                idx++;
            }
            return current;
        }
    }
}
