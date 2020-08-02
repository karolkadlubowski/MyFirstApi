using Librus.models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librus.data
{
    public interface IDatabase
    {
        void CreateTable<T>() where T : class;

        IRepository<Teacher> TeacherRepository { get; }

        IRepository<Subject> SubjectRepository { get; }

        IRepository<Student> StudentRepository { get; }

        IRepository<StudentSubject> StudentSubjectRepository { get; }

        IRepository<GradeStudentSubject> GradeStudentSubjectRepository { get; }
    }

    public class Database : IDatabase
    {
        private readonly SQLiteConnection connection;

        private const string DatabaseLocation = @"D:\Studia\Projekty\librus\data\Database.db";

        public Database()
        {
            this.connection = new SQLiteConnection(DatabaseLocation);
        }

        public void CreateTable<T>() where T : class
        {
            connection.CreateTable<T>();
        }

        private IRepository<Teacher> teacherRepository;

        public IRepository<Teacher> TeacherRepository
        {
            get => teacherRepository ?? new Repository<Teacher>(connection);
        }

        private IRepository<Subject> subjectRepository;

        public IRepository<Subject> SubjectRepository
        {
            get => subjectRepository ?? new Repository<Subject>(connection);
        }

        private IRepository<Student> studentRepository;

        public IRepository<Student> StudentRepository
        {
            get => studentRepository ?? new Repository<Student>(connection);
        }

        private IRepository<StudentSubject> studentSubjectRepository;

        public IRepository<StudentSubject> StudentSubjectRepository
        {
            get => studentSubjectRepository ?? new Repository<StudentSubject>(connection);
        }

        private IRepository<GradeStudentSubject> gradeStudentSubjectRepository;

        public IRepository<GradeStudentSubject> GradeStudentSubjectRepository
        {
            get => gradeStudentSubjectRepository ?? new Repository<GradeStudentSubject>(connection);
        }


    }
}
