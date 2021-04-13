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
    }
}