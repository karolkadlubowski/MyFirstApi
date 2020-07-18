using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librus.models
{
    [Table("Subjects")]
    public class Subject
    {

        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public Subject(string name)
        {
            Name = name;
        }

        public Subject(){}
    }
}
