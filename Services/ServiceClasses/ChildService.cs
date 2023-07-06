using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Repository.Entities;
using Repository.Interfaces;
using Services.Interfaces;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServiceClasses
{
    public class ChildService:IChildService
    {
        private readonly IChildRepository rep;
        private readonly IMapper mapper;

        public ChildService(IChildRepository _rep, IMapper _mapper)
        {
            rep = _rep;
            mapper = _mapper;
        }

        public async Task<ChildModel> AddAsync(ChildModel model)
        {
            //Child child=new Child();
            //child.ChildName = model.ChildName;
            //child.ChildId = model.ChildId;
            //child.ChildDOB = model.ChildDOB;
            //return mapper.Map<ChildModel>(await rep.AddAsync(child));
            // throw new NotImplementedException();
            return mapper.Map<ChildModel>(await rep.AddAsync(mapper.Map<Child>(model)));
        }

        public async Task DeleteAsync(int key)
        {
           await rep.DeleteAsync(key);
        }

        public async Task<IEnumerable<ChildModel>> GetAllAsync()
        {
            return mapper.Map<IEnumerable<ChildModel>>(await rep.GetAllAsync());
        }

        public async Task<ChildModel> GetByIdAsync(int key)
        {
           return mapper.Map<ChildModel>(await rep.GetByIdAsync(key));
        }

        public async Task<ChildModel> UpdateAsync(ChildModel model)
        {
            return mapper.Map<ChildModel>(await rep.UpdateAsync(mapper.Map<Child>(model)));
        }

        //public async Task<List<ChildModel>> AddAsync(ChildModel model)
        //{
        //    return mapper.Map<ChildModel>(await rep.AddAsync(rep.));
        //}

        //public Task DeleteAsync(int key)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<List<ChildModel>> GetAllAsync()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<List<ChildModel>> GetByIdAsync(ChildModel key)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<List<ChildModel>> UpdateAsync(ChildModel model)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<ChildModel> AddAsync(ChildModel model)
        //{
        //    return mapper.Map<ChildModel>(await rep.);
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    await rep.DeleteAsync(id);
        //    //throw new NotImplementedException();
        //}

        ////public async Task<IEnumerable<ChildModel> >GetAllAsync()
        ////{
        ////    //List<Child> list = rep.GetAll();
        ////    //List<ChildModel> listToReturn = new List<ChildModel>();
        ////    //foreach (var item in list)
        ////    //{
        ////    //    listToReturn.Add(mapper.Map<ChildModel>(item));
        ////    //}
        ////    //return listToReturn;
        ////    return mapper.Map<ChildModel>(await rep.Add)
        ////}

        //public ChildModel GetById(int key)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<ChildModel> Search(int id = 0, string searchstring = "")
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(ChildModel model)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
