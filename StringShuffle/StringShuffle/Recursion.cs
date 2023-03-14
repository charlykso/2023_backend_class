using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringShuffle
{
    internal class Recursion
    {
        public static int recursion(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * recursion(num - 1);
        }
    }
}

