using System;
using System.Collections.Generic;
using cJobs.Models;
using cJobs.Repositories;

namespace cJobs.Services
{
    public class ContractorsService
    {
        private readonly ContractorsRepository _repo;

        public ContractorsService(ContractorsRepository repo)
        {
            _repo = repo;
        }

        internal IEnumerable<Contractor> GetAll()
        {
            return _repo.GetAll();
        }
        internal Contractor GetById(int id)
        {
            var data = _repo.GetById(id);
            if (data == null)
            {
                throw new Exception("Invalid Id Aye");
            }
            return data;
        }

        internal Contractor Create(Contractor newContractor)
        {
            return _repo.Create(newContractor);
        }
    }
}