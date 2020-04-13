using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class Program
    {
        class Person
        {
            public string FirName;
            public string LasName;
            public int maxMark;
            public Person(string f,string l,int max)
            {
                this.FirName = f;
                this.LasName = l;
                this.maxMark = max;
            }
            public void write()
            {
                Console.WriteLine(this.FirName + " " + this.LasName);
            }
        }
        static int Max(int[] n,Func<int,int,bool>isbigger)
        {
            int max = n[0];
            for (int i = 0; i < n.Length - 1; i++) 
            {
                if (isbigger(n[i + 1], max))
                    max = n[i + 1];
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入学生信息：");
            Func<int, int, bool> isbigger = (a, b) => a > b;
            string line = Console.ReadLine();
            List<Person> people = new List<Person>();
            //string text = null;
            while (line != "END")
            {
                string[] input = line.Split(' ');
                int[] score = new int[4];
                for (int i = 0, j = 2; i < 4; i++, j++)
                {
                    score[i] = int.Parse(input[j]);
                }
                int maxscore = Max(score, isbigger);
                people.Add(new Person(input[0], input[1], maxscore));
                line = Console.ReadLine();
            }
            Func<Person, bool> isExcellent = person => person.maxMark == 6;
            foreach (Person p in people)
            {
                if (isExcellent(p))
                    p.write();
            }
            Console.ReadKey();
        }
    }
}
