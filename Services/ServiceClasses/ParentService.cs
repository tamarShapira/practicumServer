using AutoMapper;
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
    public class ParentService:IParentService
    {
        private readonly IParentRepository rep;
        private readonly IMapper mapper;

        public ParentService(IParentRepository _rep, IMapper _mapper)
        {
            rep = _rep;
            mapper = _mapper;
        }
        public async Task<ParentModel> AddAsync(ParentModel model)
        {
            //Parent parent=new Parent();
            //parent.ParentFirstName = model.ParentFirstName;
            //parent.ParentLastName = model.ParentLastName;
            //parent.ParentId = model.ParentId;
            //parent.ParentDOB = model.ParentDOB;
            //parent.ParentSpecies = model.ParentSpecies;
            //parent.ParentHMO = model.ParentHMO;
            //parent.Children = model.Children;
            //return mapper.Map<ParentModel>(await rep.AddAsync(parent));
            return mapper.Map<ParentModel>(await rep.AddAsync(mapper.Map<Parent>(model)));
            //throw new NotImplementedException();
        }

        public async Task DeleteAsync(int key)
        {
            await rep.DeleteAsync(key);
        }

        public async Task<IEnumerable<ParentModel>> GetAllAsync()
        {
            return mapper.Map<IEnumerable<ParentModel>>(await rep.GetAllAsync());
        }

        public async Task<ParentModel> GetByIdAsync(int key)
        {
            return mapper.Map<ParentModel>(await rep.GetByIdAsync(key));
        }

        public async Task<ParentModel> UpdateAsync(ParentModel model)
        {
            return mapper.Map<ParentModel>(await rep.UpdateAsync(mapper.Map<Parent>(model)));
        }

        //public ParentModel Add(ParentModel model)
        //{
        //    return mapper.Map<ParentModel>(rep.Add(mapper.Map<Parent>(model)));
        //}

        //public void Delete(int key)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<ParentModel> GetAll()
        //{
        //    List<Parent> list = rep.GetAll();
        //    List<ParentModel> listToReturn = new List<ParentModel>();
        //    foreach (var item in list)
        //    {
        //        listToReturn.Add(mapper.Map<ParentModel>(item));
        //    }
        //    return listToReturn;
        //}

        //public ParentModel GetById(int key)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<ParentModel> Search(int id = 0, string searchstring = "")
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(ParentModel model)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
