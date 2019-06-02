using System;
using System.Collections.Generic;
using System.Linq;
using TestTask.BusinessLogic.Entity;

namespace TestTask.BusinessLogic.Database
{
    public class Table<T> where T: BaseEntity
    {
        private List<T> _entities { get; set; }

        public Table()
        {
            _entities = new List<T>();
        }

        public Table(List<T> entities)
        {
            _entities = entities;
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.OrderBy(x => x.Id);
        }

        public T GetById(int id)
        {
            return _entities.FirstOrDefault(e => e.Id == id);
        }

        public T Add(T entity)
        {
            entity.Id = _entities.Max(x => x.Id) + 1;

            _entities.Add(entity);
            return entity;
        }

        public T Delete(int id)
        {
            var item = GetById(id);
            _entities.Remove(item);
            return item;
        }

        public T Update(T entity)
        {
            var item = Delete(entity.Id);
            if (item != null)
            {
                _entities.Add(entity);
                return entity;
            }
            return null;
        }
    }
}
