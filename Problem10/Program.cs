using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class Program
    {
        class Student
        {
            public string FacNum;
            public string Name;
            public Student(string s)
            {
                string[] info = s.Split(' ');
                this.FacNum = info[0];
                this.Name = info[1] + " " + info[2];
            }
        }
        class StuSpecialties
        {
            public string SpecialtyName;
            public string FacNum;
            public StuSpecialties(string s)
            {
                string[] info = s.Split(' ');
                this.FacNum = info[2];
                this.SpecialtyName = info[0] + " " + info[1];
            }
        }
        class JoinedSwithS
        {
            public string Name;
            public string FacNum;
            public string Specialty;
            public JoinedSwithS(string n,string f,string s)
            {
                this.Name = n;
                this.FacNum = f;
                this.Specialty = s;
            }
        }
        static void Main(string[] args)
        {
            List<StuSpecialties> stuSpecialties = new List<StuSpecialties>();
            List<Student> students = new List<Student>();
            List<JoinedSwithS> joined = new List<JoinedSwithS>();
            Console.WriteLine("请输入相关信息");
            string line = Console.ReadLine();
            while (line != "Students:") 
            {
                stuSpecialties.Add(new StuSpecialties(line));
                line = Console.ReadLine();
            }
            line = Console.ReadLine();
            while (line != "END") 
            {
                students.Add(new Student(line));
                line = Console.ReadLine();
            }
            foreach(Student student in students)
            {
                foreach(StuSpecialties specialties in stuSpecialties)
                {
                    if (student.FacNum == specialties.FacNum)
                    {
                        joined.Add(new JoinedSwithS(student.Name, student.FacNum, specialties.SpecialtyName));
                    }
                }
            }

            Func<JoinedSwithS, string> name = join => join.Name;
            Func<JoinedSwithS, string> specialty = join2 => join2.Specialty;

            joined = joined.OrderBy(name).ThenByDescending(specialty).ToList();

            foreach(JoinedSwithS j in joined)
            {
                Console.WriteLine(j.Name + " " + j.FacNum + " " + j.Specialty);
            }
            Console.ReadKey();
        }
    }
}
