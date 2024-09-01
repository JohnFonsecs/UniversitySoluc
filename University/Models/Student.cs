namespace University.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

    }
}
