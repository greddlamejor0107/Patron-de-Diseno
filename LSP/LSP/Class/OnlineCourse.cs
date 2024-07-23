
namespace LSP.Class
{
    public class OnlineCourse : Course
    {
        public override string GetCourseDetails()
        {
            return $"Online COurse: {Title}";
        }

        public override void Subscribe(Student std)
        {
            Console.WriteLine("Ha sido inscrito en el curso Online o en linea");
        }
    }

}
