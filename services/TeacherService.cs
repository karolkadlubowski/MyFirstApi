using Librus.data;
using Librus.models;
using System.Collections.Generic;
using System.Linq;

namespace Librus.services
{
    public interface ITeacherService
    {
        Teacher LeadTeacher { get; }
        List<Student> Teachers { get; set; }

        bool AddStudent(string name, string surname, int subjectId);
    }

    public class TeacherService : ITeacherService
    {
        public TeacherService(Teacher leadTeacher)
        {
            this.LeadTeacher = leadTeacher;
            this.database = new Database();
            Teachers = this.database.StudentRepository.GetAll().ToList();
        }

        public Teacher LeadTeacher { get; }
        public List<Student> Teachers { get; set; }
        private IDatabase database { get;}

        public bool AddStudent(string name, string surname, int subjectId)
            => database.StudentRepository.Insert(new Student(name, surname, subjectId));

    }
}
