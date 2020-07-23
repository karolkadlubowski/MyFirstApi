using Librus.data;
using Librus.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librus.services
{
    public interface IAuthService
    {
        Teacher Login(string username, string password);

        bool Register(string username, string password, string subject);
    }

    public class AuthService : IAuthService
    {
        public AuthService()
        {
            this.database = new Database();
        }

        IDatabase database { get; }
        public Teacher Login(string username, string password)
        {
            var teachers = database.TeacherRepository.GetAll();
            foreach (Teacher teacher in teachers)
            {
                if (teacher.Login == username && teacher.Password == password)
                    return teacher;
            }
            return null;
        }

        public bool Register(string username, string password, string subject)
        {

            var teachers = database.TeacherRepository.GetAll();
            var subjects = database.SubjectRepository.GetAll();
            foreach (Teacher teacher in teachers)
            {
                if (teacher.Login == username)
                    return false;
            }
            int subjectId = subjects.First(s => s.Name == subject).Id;
            var newteacher = new Teacher(username, password, subjectId);
            return database.TeacherRepository.Insert(newteacher);
        }
    }
}