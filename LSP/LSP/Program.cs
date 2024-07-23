using LSP.Class;

public class Program
{
    static void Main(string[] args)
    {
        Course onlineCourse = new OnlineCourse { CourseId = 3, Title = "Sql principiantes" };
        Course offlineCourse = new OfflineCOurse { CourseId = 7, Title = "sql Intermedio" };
        Course hybridCourse = new HybridCOurse { CourseId = 5, Title = "Sql Avanzado" };

        Student student = new Student { StudentID = 1, Name = "Delio" };

        onlineCourse.Subscribe(student);
        offlineCourse.Subscribe(student);
        hybridCourse.Subscribe(student);
        Console.WriteLine(onlineCourse.GetCourseDetails());
        Console.WriteLine(offlineCourse.GetCourseDetails());
        Console.WriteLine(hybridCourse.GetCourseDetails());
    }
}