﻿using Librus.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librus.data
{
    public interface IDatabaseManagement
    {
        void InitDatabase();
    }

    public class DatabaseManagement : IDatabaseManagement
    {
        private IDatabase database = new Database();

        public void InitDatabase()
        {
            database.CreateTable<Teacher>();
            database.CreateTable<Subject>();
            database.CreateTable<Student>();
            database.CreateTable<StudentSubject>();
            database.CreateTable<GradeStudentSubject>();
            database.CreateTable<Grade>();
            
            if(database.SubjectRepository.GetAll().ToList().Count==0)
            {
                var subjects = new List<Subject>()
                {
                    new Subject("Matematyka"),
                    new Subject("Fizyka"),
                    new Subject("Elektrotechnika"),
                    new Subject("Paktofonika"),
                    new Subject("Chemia"),
                    new Subject("Biologia"),
                    new Subject("Technika Układów cyfrowych")
                };
                subjects.ForEach(subject => database.SubjectRepository.Insert(subject));
            }

            if(database.GradeRepository.GetAll().ToList().Count==0)
            {
                var grades = new List<Grade>()
                {
                    new Grade("Niedostateczny"),
                    new Grade("Dopuszczający"),
                    new Grade("Dostateczny"),
                    new Grade("Dobry"),
                    new Grade("Bardzo dobry"),
                    new Grade("Celujący")
                };
                grades.ForEach(grade => database.GradeRepository.Insert(grade));
            }
        }

    }
}
