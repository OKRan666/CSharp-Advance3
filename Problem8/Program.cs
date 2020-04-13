using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    class Program
    {
        class Student
        {
            public string FirName;
            public string LasName;
            public int WeakTimes;
            public Student (string f,string l,int w)
            {
                FirName = f;
                LasName = l;
                WeakTimes = w;
            }
            public void write()
            {
                Console.WriteLine(this.FirName + " " + this.LasName);
            }
        }
        public static int weakTimes(int[] grades,Func<int,bool>isweak)
        {
            int result = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                if (isweak(grades[i]))
                    result++;
            }
            return result;
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Console.WriteLine("请输入学生信息，以END结束（用空格分隔）");
            string line = Console.ReadLine();
            Func<int, bool> IsWeak = (a) => a <= 3;
            while (line != "END")
            {
                string[] input = line.Split(' ');
                int[] score = new int[4];
                for (int i = 0, j = 2; i < 4; i++, j++)
                {
                    score[i] = int.Parse(input[j]);
                }
                int weaktimes = weakTimes(score, IsWeak);
                students.Add(new Student(input[0], input[1], weaktimes));
                line = Console.ReadLine();
            }
            var result = from s in students
                         where s.WeakTimes >= 2
                         select s;
            foreach (var re in result)
            {
                re.write();
            }
            Console.ReadKey();
        }
    }
}
