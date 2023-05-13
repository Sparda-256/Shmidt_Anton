using System.Text.RegularExpressions;

namespace Pz_Delegate
{
    delegate string TestDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Group = "а";
            Pupil pupil = new Pupil();
            pupil.Klas = "7";
            TestDelegate testDelegate = new TestDelegate(pupil.GetKlas);
            testDelegate += student.GetGroup;
            foreach (TestDelegate method in testDelegate.GetInvocationList())
            {
                Console.Write(method());
            }
        }
    }
    internal class Student
    {
        private string group;
        public string Group { set { group = value; } }
        public string GetGroup()
        {
            return group;
        }
    }
    class Pupil
    {
        private string klas;
        public string Klas { set { klas = value; } }
        public string GetKlas()
        {
            return klas;
        }
    }
}