using Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Services
{
    public interface IRepository<T> where T : IEntity
    {
        LayerResult<IEnumerable<T>> GetAll();
        LayerResult<T> GetById(int id);
    }
}
