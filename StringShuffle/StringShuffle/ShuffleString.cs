using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringShuffle
{
    internal class ShuffleString
    {
        public static void shuffle()
        {
            string str = "This is my string";
            List<string> list = new List<string>();
            string[] words = str.Split(" ");
            Random random = new Random();
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
