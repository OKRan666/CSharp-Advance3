using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void output(int a,int b,Predicate<int> EorO)
        {
            for(int i = a;i<=b;i++)
            {
                if (EorO(i))
                    Console.Write("{0} ", i);
            }
        }
        static void Main(string[] args)
        {
            Predicate<int> odd = (a) => a % 2 != 0;
            Predicate<int> even = (b) => b % 2 == 0;
            Console.WriteLine("请输入边界值(用空格分开)");
            string[] num = Console.ReadLine().Split(' ');
            int min = int.Parse(num[0]);
            int max = int.Parse(num[1]);
            Console.WriteLine("请输入odd/even来表达目的数字的奇偶性");
            string type = Console.ReadLine();
            if (type.Equals("odd")) 
                output(min, max, odd);
            else if (type.Equals("even"))
                output(min, max, even);
            else
                Console.WriteLine("输入无效!");
            Console.ReadKey();

        }
    }
}
