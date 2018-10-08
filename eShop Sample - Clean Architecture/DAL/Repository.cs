using Contracts.Entities;
using Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{    
    public abstract class Repository<T> : IRepository<T> where T : IEntity
    {
        public List<T> Table { get; set; }

        public LayerResult<IEnumerable<T>> GetAll()
        {
            return new LayerResult<IEnumerable<T>>(Table);
        }

        public LayerResult<T> GetById(int id)
        {
            return new LayerResult<T>(Table.Single(x => x.Id == id));
        }
    }
}
