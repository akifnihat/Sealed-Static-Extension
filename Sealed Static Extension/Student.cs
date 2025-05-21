
using System.Text.RegularExpressions;

namespace Sealed_Static_Extension
{
    public class Student
    {
        private string _fullName;
        private string _groupNo;
        public int Age { get; set; }

        public string Fullname
        {
            get => _fullName;
            set
            {
                if (!value.CheckFullname())
                    throw new ArgumentException("FullName formati yanlisdir");

                _fullName = value.Trim();
            }
        }

        public string GroupNo
        {
            get => _groupNo;
            set
            {
                if (!value.IsValidGroupNo())
                    throw new ArgumentException("GroupNo formati duzgun deyil");

                _groupNo = value;
            }
        }

        public Student(string fullname, string groupNo, int age)
        {
            Fullname = fullname;
            GroupNo = groupNo;
            Age = age;
        }

        public override string ToString()
        {
            return $"Fullname: {Fullname}, GroupNo: {GroupNo}, Age: {Age}";
        }

        public virtual void DoHomeWork()
        {
            Console.WriteLine("Metod isledildi");
        }
    }
}
