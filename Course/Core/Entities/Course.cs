namespace Course.Core.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Rating { get; set; }
        public float Duration { get; set; }
        public string Level { get; set; }
        public string Language { get; set; }
        public float Price { get; set; }
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
    }
}
