using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IRepository<T>
    {
       Task<T> AddAsync(T model);
       Task<List<T>> GetAllAsync();
       Task<T> GetByIdAsync(int key);
       Task<T> UpdateAsync(T model);
       Task DeleteAsync(int key);
       //Task<List<T>> Add(T model);
       // void Update(T model);
       // void Delete(int key);
       // T GetById(int key);
       // List<T> GetAll();
       // List<T> Search(int id = 0, string searchstring = "");
    }
}
