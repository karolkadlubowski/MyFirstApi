using SQLite;

namespace Librus.models
{
    [Table("GradeStudentSubject")]
    public class GradeStudentSubject
    {
        public GradeStudentSubject(int gradeId, int studentId, int subjectId, string description)
        {
            GradeId = gradeId;
            StudentId = studentId;
            SubjectId = subjectId;
            Description = description;
        }

        public GradeStudentSubject() { }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int GradeId { get; set; }

        public int StudentId { get; set; }

        public int SubjectId { get; set; }

        public string Description { get; set; }
    }
}
