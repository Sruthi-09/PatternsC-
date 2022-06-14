using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class Student
    {
        private ICollege CollegeSource;

        public Student(ICollege CollegeSource)
        {
            this.CollegeSource = CollegeSource;
        }

        public void ShowCollegeList()
        {
            List<string> college = CollegeSource.GetCollegeList();

            Console.WriteLine("College List");
            foreach (var c in college)
            {
                Console.Write(c);
            }

        }
    }

    public interface ICollege
    {
        List<string> GetCollegeList();
    }

    public class Admissions
    {
        public string[][] Getcolleges()
        {
            string[][] colleges = new string[3][];

            colleges[0] = new string[] {"1", "Vignan University", "Guntur" };
            colleges[1] = new string[] {"2","KL University", "Vijayawada" };
            colleges[2] = new string[] {"3","SRM University", "Amaravati" };
            return colleges;
        }
    }
    public class Management : Admissions,ICollege
    {
        public List<string> GetCollegeList()
        {
            List<string> CollegeList = new List<string>();
            string[][] colleges = Getcolleges();
            foreach (string[] college in colleges)
            {
                CollegeList.Add(college[0]);
                CollegeList.Add(".");
                CollegeList.Add(college[1]);
                CollegeList.Add(",");
                CollegeList.Add(college[2]);
                CollegeList.Add("\n");
            }

            return CollegeList;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ICollege ICollege = new Management();
            Student s = new Student(ICollege);
            s.ShowCollegeList();

            Console.ReadKey();

        }
    }
}
