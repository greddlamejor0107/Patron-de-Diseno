using OCP.Class.OCP.Class;

namespace OCP.Class
{
    public class HybridCourse : Course
    {
        public override void Subscribe(Student std)
        {
            Console.WriteLine("Incrito al curso hybrido");
        }
    }

}
