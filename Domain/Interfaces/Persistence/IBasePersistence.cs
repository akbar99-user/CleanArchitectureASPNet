using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.Persistence
{
    public interface IBasePersistence<T> where T : class
    {
        Task<List<T>> GetRecords();
        Task<T> GetRecord(int id);
        Task<int> Insert(T entity);
        Task<int> Update(T entity);
        Task<int> Delete(int id);
    }
}
