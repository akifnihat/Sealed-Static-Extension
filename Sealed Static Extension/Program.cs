﻿namespace Sealed_Static_Extension
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

            Student student1 = new ProgrammingStudent("Akif Tagiyev", "P305", 21);
            Student student2 = new DesignStudent("Leo Messi", "P305", 37);
            student1.DoHomeWork();
            student2.DoHomeWork();
        }
    }
}
