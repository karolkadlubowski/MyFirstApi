using Librus.data;
using Librus.models;
using System.Collections.Generic;
using System.Linq;

namespace Librus.services
{
    public interface ITeacherService
    {
        Teacher LeadTeacher { get; }
        List<Student> Students { get; set; }

        bool AddStudent(string name, string surname, int subjectId);

        bool AddExistingStudent(Student student, int subjectId);
    }

    public class TeacherService : ITeacherService
    {
        public TeacherService(Teacher leadTeacher)
        {
            this.LeadTeacher = leadTeacher;
            this.database = new Database();
            Students = this.database.StudentRepository.GetWhere(s => s.SubjectId == this.LeadTeacher.SubjectId).ToList();
        }

        public Teacher LeadTeacher { get; }
        public List<Student> Students { get; set; }
        private IDatabase database { get;}

        public bool AddStudent(string name, string surname, int subjectId)
        {
            var studentList = database.StudentRepository.GetAll();
            foreach(Student student in studentList)
            {
                if (name == student.Name && surname == student.Surname)
                    return false;
            }
            return ( database.StudentRepository.Insert(new Student(name, surname, subjectId)) && database.StudentSubjectRepository.Insert(new StudentSubject(database.StudentRepository.GetWhere(student => (student.Name==name && student.Surname==surname)).First().Id,LeadTeacher.SubjectId)));
        }

        public bool AddExistingStudent(Student student, int subjectId)
        {
            var studentSubjects = database.StudentSubjectRepository.GetWhere(s => s.StudentId == student.Id && s.SubjectId == subjectId);
            if (studentSubjects.ToList().Count == 0)
            {
                return database.StudentSubjectRepository.Insert(new StudentSubject(student.Id, subjectId));
            }
            return false;
        }
    }
}
