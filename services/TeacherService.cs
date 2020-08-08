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

        bool AddStudent(string name, string surname);

        bool AddExistingStudent(Student student, int subjectId);

        bool DeleteStudentFromTheCourse(Student student, int subjectId);

        bool DeleteStudentDefenitely(Student student);
    }

    public class TeacherService : ITeacherService
    {
        public TeacherService(Teacher leadTeacher)
        {
            Students = new List<Student>();
            this.LeadTeacher = leadTeacher;
            this.database = new Database();
            var studentSubjectList = this.database.StudentSubjectRepository.GetWhere(s => s.SubjectId == LeadTeacher.SubjectId);
            foreach (StudentSubject studentSubject in studentSubjectList)
                Students.Add(database.StudentRepository.Get(studentSubject.StudentId));
        }

        public Teacher LeadTeacher { get; }
        public List<Student> Students { get; set; }
        private IDatabase database { get;}

        public bool AddStudent(string name, string surname)
        {
            var studentList = database.StudentRepository.GetAll();
            foreach(Student student in studentList)
            {
                if (name == student.Name && surname == student.Surname)
                    return false;
            }
            return ( database.StudentRepository.Insert(new Student(name, surname)) && database.StudentSubjectRepository.Insert(new StudentSubject(database.StudentRepository.GetWhere(student => (student.Name==name && student.Surname==surname)).First().Id,LeadTeacher.SubjectId)));
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

        public bool DeleteStudentFromTheCourse(Student student, int subjectId)
            => database.StudentSubjectRepository.DeleteRange(database.StudentSubjectRepository.GetWhere(studentSubject => studentSubject.StudentId == student.Id && studentSubject.SubjectId == subjectId).ToList());
        
        public bool DeleteStudentDefenitely(Student student)
        {
            bool isDeletedFromStudentSubject = database.StudentSubjectRepository.DeleteRange(database.StudentSubjectRepository.GetWhere(ss => ss.StudentId == student.Id).ToList());
            bool isDeletedFromStudents = database.StudentRepository.Delete(student);
            return isDeletedFromStudents && isDeletedFromStudentSubject;
        }

    }
}
