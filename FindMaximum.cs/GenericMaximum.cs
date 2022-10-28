using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum.cs
{
    class GenericMaximum<T> where T:IComparable
    {
        public T[] value;
        public GenericMaximum(T[] value)
        {
            this.value = value;
        }
        public void toPrint<T>(T[] value)
        {
            foreach(var item in value)
            {
                Console.Write(item);
            }
            Console.Write("---------------");
        }
    }
}
