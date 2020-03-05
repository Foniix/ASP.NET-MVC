using System.Collections.Generic;
using System.Threading.Tasks;

namespace ToDo_List.Models.Repository
{
    interface IRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task Save(T item);
        Task Delete(int id);
        Task Update(T item);
    }
}
