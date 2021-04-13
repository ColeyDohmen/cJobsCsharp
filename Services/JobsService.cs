using System;
using System.Collections.Generic;
using cJobs.Models;
using cJobs.Repositories;

namespace cJobs.Services
{
    public class JobsService
    {
        private readonly JobsRepository _repo;

        public JobsService(JobsRepository repo)
        {
            _repo = repo;
        }

        internal IEnumerable<Job> GetAll()
        {
            return _repo.GetAll();
        }

        internal Job GetById(int id)
        {
            var data = _repo.GetById(id);
            if (data == null)
            {
                throw new Exception("Invalid Id Aye");
            }
            return data;
        }

        internal Job Create(Job newJob)
        {
            return _repo.Create(newJob);
        }

        internal Job Delete(int id)
        {
            Job original = GetById(id);
            _repo.Delete(id);
            return original;
        }

        internal IEnumerable<ContractorJobViewModel> GetJobsByContractorId(int id)
        {
            return _repo.GetJobsByContractorId(id);
        }
    }
}