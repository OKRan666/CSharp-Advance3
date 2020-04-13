using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem6
{
    class Program
    {
        class Person
        {
            public string FirName;
            public string LasName;
            public int count;  //记录出现的顺序
            public Person(string f, string l , int n)
            {
                this.FirName = f;
                this.LasName = l;
                this.count = n;
            }
            public void write()
            {
                Console.WriteLine(this.FirName + " " + this.LasName);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入学生信息：");
            List<Person> person = new List<Person>();
            string line = Console.ReadLine();
            string text = null;
            while(line!="END")
            {
                text = text + " " + line;
                line = Console.ReadLine();
            }
            string pattern = @"([A-Z][a-z]+)\s([A-Z][a-z]+)\s[a-zA-Z0-9]+@[g][m][a][i][l][.][c][o][m]";
            //MatchCollection mc = Regex.Matches(text, pattern);
            int i = 1;
            foreach(Match m in Regex.Matches(text,pattern))
            {
                person.Add(new Person(m.Groups[1].Value, m.Groups[2].Value, i));
                i++;
            }

            //count属性排序
            var result = person.OrderBy(per => per.count);
            person = result.ToList();
            foreach (Person per in person)
                per.write();
            Console.ReadKey();
        }
    }
}
