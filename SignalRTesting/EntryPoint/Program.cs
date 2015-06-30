using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            for (int i = 0; i < 24; i++)
            {
                list.Add(i);
            }

            list.Shuffle();

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
