using System;
using cJobs.Models;
using cJobs.Repositories;

namespace cJobs.Services
{
    public class ContractorJobsService
    {

        private readonly ContractorJobsRepository _repo;

        public ContractorJobsService(ContractorJobsRepository repo)
        {
            _repo = repo;
        }

        internal ContractorJob Create(ContractorJob newCJ)
        {
            return _repo.Create(newCJ);
        }

        internal void Delete(int id)
        {
            _repo.Delete(id);
        }
    }
}