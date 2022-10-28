using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JustTimePass
{
   class UCprintmax
    {
        public void toPrint<T>(T[] inputArray)
        {
            foreach(T element in inputArray)
            {
                Console.Write(element);

            }
            Console.Write("-----------------");
        }
        public void toPrint(int[] intArray)
        {
            foreach(int element in intArray)
            {
                Console.Write(element);
            }
            Console.Write("---------------");
        }
        public void toPrint(double[] doubleArray)
        {
            foreach (double element in doubleArray)
            {
                Console.Write(element);
            }
            Console.Write("---------------");
        }
        public void toPrint(char[] charArray)
        {
            foreach(char element in charArray)
            {
                Console.Write(element);
            }
            Console.Write("---------------");
        }
    }
}
