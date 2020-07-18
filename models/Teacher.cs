using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Librus.models
{
    [Table("Teachers")]
    public class Teacher
    {
        [PrimaryKey,AutoIncrement]

        public int Id { get; set; }
        public string Login { get; set; }

        public string Password { get; set; }

        public int SubjectId { get; set; }
    }
}
