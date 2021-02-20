using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RT_GUI.Repository
{
    public interface IRepository<T>
    {
        event EventHandler<T> OnItemAdded;
        event EventHandler<T> OnItemUpdate;
        event EventHandler<T> OnItemDeleted;
        Task<List<T>> GetItems();
        Task<T> GetItem();
        Task<T> FindItemById(T item);
        Task AddItem(T item);
        Task Update(T item);
        Task DeleteItem(T item);
    }
}
