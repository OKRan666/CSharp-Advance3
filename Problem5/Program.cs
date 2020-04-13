using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        class Person
        {
            public string FirName;
            public string LasName;
            public Person(string s)
            {
                string[] names = s.Split(' ');
                this.FirName = names[0];
                this.LasName = names[1];
            }
            public void write()
            {
                Console.WriteLine(this.FirName+" "+this.LasName);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入学生信息：");
            List<Person> persons = new List<Person>();
            string input = Console.ReadLine();
            while (!input.Equals("END")) 
            {
                persons.Add(new Person(input));
                input = Console.ReadLine();
            }
            Func<Person, string> fisname = personA => personA.FirName;
            Func<Person, string> lasname = personB => personB.LasName;

            var result = persons.OrderBy(lasname).ThenByDescending(fisname);
            

            //var result = from n in persons
            //             orderby n.LasName
            //             thenbydescending
            //             select n;

            persons = result.ToList();
            for (int i = 0; i < persons.Count; i++)
                persons[i].write();  
            
            Console.ReadKey(); 
        }
    }
}
