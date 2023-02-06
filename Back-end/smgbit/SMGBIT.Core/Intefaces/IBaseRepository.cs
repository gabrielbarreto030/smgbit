using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SMGBIT.Core.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int Id);
        Task<T> Post(T value);
        Task<T> Put(T value);
        Task<bool> Delete(T value);
    }
}
