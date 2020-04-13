using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Problem4
{
    class Program
    {
        static int[] evenfirst(int[]nums,Predicate<int>iseven)
        {
            List<int> odd = new List<int>();
            List<int> even = new List<int>();
            for(int i = 0;i<nums.Length;i++)
            {
                if (iseven(nums[i]))
                    even.Add(nums[i]);
                else
                    odd.Add(nums[i]);
            }
            even.Sort();
            odd.Sort();
            int k = even.Count + odd.Count;
            int[] result = new int[k];
            for(int j = 0;j<even.Count;j++)
            {
                result[j] = even[j];
            }
            for (int j = 0; j < odd.Count; j++)
            {
                result[j + even.Count] = odd[j];
            }
            return result;
        }
        static void Main(string[] args)
        {
            Predicate<int> iseven = (x) => x % 2 == 0;
            Console.WriteLine("请输入一串数字（用空格分隔）");
            //string z = Console.ReadLine();
            //string[] nums = z.Split(' ');
            //int[] input = new int[nums.Length];
            //for(int i = 0;i<nums.Length;i++)
            //{
            //    input[i] = int.Parse(nums[i]);
            //}
            //使用Linq表示
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            input = evenfirst(input, iseven);
            for (int j = 0; j < input.Length; j++)
                Console.Write("{0} ", input[j]);
            Console.ReadKey();
        }
    }
}
