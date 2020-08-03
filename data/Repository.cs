using SQLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Librus.data
{
    public interface IRepository<T> where T : class, new()
    {
        T Get(int id);

        IEnumerable<T> GetAll();

        bool Insert(T entity);

        IEnumerable<T> GetWhere(Expression<Func<T, bool>> predicate);

        bool Delete(T entity);
    }

    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly SQLiteConnection database;

        public Repository(SQLiteConnection database)
        {
            this.database = database;
        }

        public T Get(int id) =>
            database.Find<T>(id);

        public IEnumerable<T> GetAll() =>
            database.Table<T>().AsEnumerable();

        public bool Insert(T entity) =>
            database.Insert(entity) == 1;

        public IEnumerable<T> GetWhere(Expression<Func<T, bool>> predicate)
            => database.Table<T>().Where(predicate).ToList();

        public bool Delete(T entity)
            => database.Delete(entity) == 1;
    }
}
