using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = (message) => Console.WriteLine("Sir " + message);
            string text = Console.ReadLine();
            string[] names = text.Split(' ');
            for (int i = 0; i < names.Length; i++)
            {
                if(!names[i].Equals(""))
                    print(names[i]);
            }
            Console.ReadKey();
        }
    }
}
