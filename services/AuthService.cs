using Librus.data;
using Librus.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            password = GenerateHash(password);
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
            if (password.Count()==0 || subject.Count()==0)
                return false;
            var teachers = database.TeacherRepository.GetAll();
            var subjects = database.SubjectRepository.GetAll();
            foreach (Teacher teacher in teachers)
            {
                if (teacher.Login == username)
                    return false;
            }
            int subjectId = subjects.First(s => s.Name == subject).Id;
            var newteacher = new Teacher(username, GenerateHash(password), subjectId);
            return database.TeacherRepository.Insert(newteacher);
        }

        private string GenerateHash(string password)
        {
            byte[] passwordBinary = Encoding.UTF8.GetBytes(password);
            byte[] passwordHashBinary;
            using (SHA512 sha512 = SHA512.Create())
            {
                passwordHashBinary = sha512.ComputeHash(passwordBinary);
            }
            StringBuilder stringBuilder = new StringBuilder(128);
            foreach (byte hashByte in passwordHashBinary)
                stringBuilder.Append(hashByte.ToString("X2"));
            return stringBuilder.ToString();
        }
    }
}