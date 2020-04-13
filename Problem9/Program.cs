using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    class Program
    {
        class Person
        {
            public string FirName;
            public string LasName;
            public int group;
            public Person(string f,string l,string g)
            {
                this.FirName = f;
                this.LasName = l;
                this.group = int.Parse(g);
            }
        }
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            Console.WriteLine("请输入个人信息");
            string line = Console.ReadLine();
            while (line != "END")
            {
                string[] s = line.Split(' ');
                people.Add(new Person(s[0], s[1], s[2]));
                line = Console.ReadLine();
            }
            Func<Person, int> GbyG = p => p.group;
            people = people.OrderBy(GbyG).ToList();
            var result = people.GroupBy(GbyG);
            foreach(var res in result)
            {
                Console.Write(res.ToArray()[0].group + " - ");
                foreach (var a in res)
                {
                    if (a != res.ToArray()[res.Count() - 1]) 
                        Console.Write(a.FirName + " " + a.LasName + ", ");
                    else
                        Console.Write(a.FirName + " " + a.LasName);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
