
namespace LSP.Class
{
    public class OfflineCOurse : Course
    {
        public override string GetCourseDetails()
        {
            return $"Offline Course: {Title}";
        }

        public override void Subscribe(Student std)
        {
            Console.WriteLine("Ha sido inscrito en el curso offline");
        }
    }
}
