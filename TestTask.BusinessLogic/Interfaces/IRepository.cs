using System.Collections.Generic;
using TestTask.BusinessLogic.Entity;

namespace TestTask.BusinessLogic.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        T Add(T entity);
        T Update(T entity);
        T DeleteById(int id);
    }
}
