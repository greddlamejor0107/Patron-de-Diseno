using OCP.Class.OCP.Class;

namespace OCP.Class
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student { StudentId = 5, StudentName = "Junior" };
            Course onlineCourse = new OnlineCourse();
            Course offlineCourse = new OfflineCourse();
            Course hybridCourse = new HybridCourse();

            onlineCourse.Subscribe(student);
            offlineCourse.Subscribe(student);
            hybridCourse.Subscribe(student);
        }
    }
}