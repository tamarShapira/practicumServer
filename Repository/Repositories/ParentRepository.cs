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
    public class ParentRepository : IParentRepository
    {
        IDataSource dataSource;
        public ParentRepository(IDataSource _dataSource)
        {
            dataSource = _dataSource;
        }

        public async  Task<Parent> AddAsync(Parent model)
        {
            await dataSource.Parent.AddAsync(model);
            await dataSource.SaveChangesAsync();
            return model;
        }

        public async Task DeleteAsync(int key)
        {
            var child = await GetByIdAsync(key);
            dataSource.Parent.Remove(child);
            await dataSource.SaveChangesAsync();
        }

        public async Task<List<Parent>> GetAllAsync()
        {
            return await dataSource.Parent.ToListAsync();
        }

        public async Task<Parent> GetByIdAsync(int key)
        {
            return await dataSource.Parent.FindAsync(key);
        }

        public async Task<Parent> UpdateAsync(Parent model)
        {
            var updateChild = dataSource.Parent.Update(model);
            await dataSource.SaveChangesAsync();
            return updateChild.Entity;
        }
        //public Parent Add(Parent model)
        //{
        //   dataSource.Parent.Add(model);
        //    dataSource.SaveChanges();
        //    return model;
        //}

        //public void Delete(int key)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Parent> GetAll()
        //{
        //   return dataSource.Parent.ToList();
        //}

        //public Parent GetById(int key)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Parent> Search(int id = 0, string searchstring = "")
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Parent model)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
