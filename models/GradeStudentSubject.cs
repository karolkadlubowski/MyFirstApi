using SQLite;

namespace Librus.models
{
    [Table("GradeStudentSubject")]
    public class GradeStudentSubject
    {
        public int Id { get; set; }

        public int Grade { get; set; }

        public int StudentId { get; set; }

        public int SubjectId { get; set; }
    }
}
