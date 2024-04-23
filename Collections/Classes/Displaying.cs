using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Classes
{
    internal class Displaying
    {
        public static void Display(int[] arr)
        {
            foreach (int it in arr)
                Console.WriteLine(it);
        }

        public static void Display(List<int> list)
        {
            foreach (int it in list)
                Console.WriteLine(it);
        }
    }
}
