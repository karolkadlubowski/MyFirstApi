using SQLite;

namespace Librus.models
{
    [Table("Students")]
    public class Student
    {
        public Student(){}

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
    }
}
