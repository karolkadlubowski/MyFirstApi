using SQLite;

namespace Librus.models
{
    [Table("Grades")]
    public class Grade
    {
        public Grade(){}

        public Grade(string value)
        {
            Value = value;
        }

        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }

        public string Value { get; set; }
    }
}
