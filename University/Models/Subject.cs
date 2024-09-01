namespace University.Models
{
    public class Subject(List<Student> students)
    {
        public int SubjectCode { get; set; }
        public string SubjectName { get; set; }

        public List<Student> Students { get; set; }

    }
}
