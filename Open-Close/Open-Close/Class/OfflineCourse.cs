using OCP.Class.OCP.Class;

namespace OCP.Class
{
    public class OfflineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            Console.WriteLine("Estudiante inscrito en el curso que no esta en linea o offline");
        }
    }

}
