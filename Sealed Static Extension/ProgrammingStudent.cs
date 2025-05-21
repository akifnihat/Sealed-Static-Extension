
namespace Sealed_Static_Extension
{
    public class ProgrammingStudent:Student
    {
        public ProgrammingStudent(string fullname, string groupNo, int age) : base(fullname, groupNo, age)
        {
        }

        public override void DoHomeWork()
        {
            Console.WriteLine("Programming metodu isledildi");
        }

    }
}
