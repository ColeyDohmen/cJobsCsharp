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
    }
}