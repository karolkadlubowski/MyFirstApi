using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librus.data
{
    public interface IRepository<T> where T : class, new()
    {
        IEnumerable<T> GetAll();

        bool Insert(T entity);
    }

    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly SQLiteConnection database;

        public Repository(SQLiteConnection database)
        {
            this.database = database;
        }

        public IEnumerable<T> GetAll() =>
            database.Table<T>().AsEnumerable();

        public bool Insert(T entity) =>
            database.Insert(entity) == 1;
    }
}
