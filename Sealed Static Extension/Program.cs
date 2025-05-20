namespace Sealed_Static_Extension
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student student = new Student("Abbas Quliyev", "P216", 21);
                Console.WriteLine(student);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xeta: " + ex.Message);
            }
        }
    }
}
