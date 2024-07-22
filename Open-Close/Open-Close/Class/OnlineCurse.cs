using OCP.Class.OCP.Class;

namespace OCP.Class
{
    public class OnlineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            Console.WriteLine("Estudiante Inscrito en el curso en linea o online");
        }
    }
}
