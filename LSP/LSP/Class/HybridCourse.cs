﻿
namespace LSP.Class
{
    public class HybridCOurse : Course
    {
        public override string GetCourseDetails()
        {
            return $"Hybrid Course: {Title}";
        }

        public override void Subscribe(Student std)
        {
            Console.WriteLine("Ha sido inscrito en el curso Hybrido o modificado");
        }
    }
}
