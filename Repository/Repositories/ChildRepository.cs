using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class ChildRepository : IChildRepository
    {
        IDataSource dataSource;
        public ChildRepository(IDataSource _dataSource)
        {
            dataSource = _dataSource;
        }
        public async Task<Child> AddAsync(Child model)
        {
            await dataSource.Child.AddAsync(model);
            await dataSource.SaveChangesAsync();
            return model;
        }
        public async Task DeleteAsync(int key)
        {
            var child = await GetByIdAsync(key);
            dataSource.Child.Remove(child);
            await dataSource.SaveChangesAsync();
        }
        public async Task<List<Child>> GetAllAsync()
        {
            return await dataSource.Child.ToListAsync();
        }
        public async Task<Child> GetByIdAsync(int key)
        {
            return await dataSource.Child.FindAsync(key);
        }
        public async Task<Child> UpdateAsync(Child model)
        {
            var updateChild= dataSource.Child.Update(model);
            await dataSource.SaveChangesAsync();
            return updateChild.Entity;
        }
        //public async Task<Child> GetByIdAsync(int key)
        //{
        //    return await dataSource.Child.FindAsync(key);
        //}
        //public async Task<Child> UpdateAsync(Child model)
        //{
        //    var updateChild=dataSource.Child.Update(model);
        //    await dataSource.SaveChangesAsync();
        //    return updateChild.Entity;
        //}
        //public Child Add(Child model)
        //{
        //   dataSource.Child.Add(model);
        //    dataSource.SaveChanges();
        //    return model;
        //}

        //public void Delete(int key)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Child> GetAll()
        //{
        //    return dataSource.Child.ToList();
        //}

        //public Child GetById(int key)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Child> Search(int id = 0, string searchstring = "")
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Child model)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
