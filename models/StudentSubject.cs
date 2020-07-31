using SQLite;

namespace Librus.models
{
    [Table("StudentSubject")]
    public class StudentSubject
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int StudentId { get; set; }

        public int SubjectId { get; set; }
    }
}
