using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        public static int Compare(int a, int b, Func<int, int, bool> comp )
        {
            int min = a;
            if (comp(a, b))
                min = b;
            return min;
        }

       
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一串数字（用空格分隔）");
            Func<int, int, bool> compare = (num1, num2) => num1 > num2;
            //string numbers = Console.ReadLine();
            //string[] nums = numbers.Split(' ');
            //List<int> n = new List<int>();
            //for(int i =0;i<nums.Length;i++)
            //{
            //    if (nums[i] != "")
            //        n.Add(int.Parse(nums[i]));
            //}
            //使用LINQ表达
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int min = n[0];
            for(int i=0;i<n.LongCount()-1;i++)
            {
                min = Compare(min, n[i + 1], compare);
            }
            Console.Write("最小值为："+min);
            Console.ReadKey();
        }
    }
}
