using Librus.models;
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
        }

    }
}
