using System;
namespace Algorithms.Recursion
{
    public class TowerOfHanoi
    {
        public void TOH(int a, char from, char aux, char to)
        {
            if (a == 1)
            {
                Console.WriteLine("Move disc 1 from {0} to {1} using {2}", from, to, aux);
            }
            else
            {
                TOH(a - 1, from, to, aux);
                Console.WriteLine("Move disc {0} from {1} to {2} using {3}", a, from, to, aux);
                TOH(a - 1, aux, from, to);
            }
        }
    }

}