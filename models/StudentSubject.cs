using SQLite;

namespace Librus.models
{
    [Table("StudentSubject")]
    public class StudentSubject
    {
        public StudentSubject() { }
        public StudentSubject(int studentId, int subjectId)
        {
            StudentId = studentId;
            SubjectId = subjectId;
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int StudentId { get; set; }

        public int SubjectId { get; set; }
    }
}
