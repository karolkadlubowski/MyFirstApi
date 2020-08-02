using SQLite;

namespace Librus.models
{
    [Table("Students")]
    public class Student
    {
        public Student(){}

        public Student(string name, string surname, int subjectId)
        {
            Name = name;
            Surname = surname;
            SubjectId = subjectId;
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int SubjectId { get; set; }
    }
}
