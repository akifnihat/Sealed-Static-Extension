
namespace Sealed_Static_Extension
{
    public class DesignStudent:Student
    {
        public DesignStudent(string fullname, string groupNo, int age) : base(fullname, groupNo, age)
        {
        }

        public override void DoHomeWork()
        {
            Console.WriteLine("Design metodu isledildi");
        }

    }
}
