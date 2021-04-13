using System;
using System.Collections.Generic;
using System.Data;
using cJobs.Models;
using Dapper;

namespace cJobs.Repositories
{
    public class JobsRepository
    {
        private readonly IDbConnection _db;
        public JobsRepository(IDbConnection db)
        {
            _db = db;
        }
        internal IEnumerable<Job> GetAll()
        {
            string sql = "SELECT * FROM jobs;";
            return _db.Query<Job>(sql);
        }

        internal Job GetById(int id)
        {
            string sql = "SELECT * FROM jobs WHERE id = @id;";
            return _db.QueryFirstOrDefault<Job>(sql, new { id });
        }

        internal Job Create(Job newJob)
        {
            string sql = @"
            INSERT INTO jobs
            (id, name, location)
            VALUES
            (@Id, @Name, @Location);
            SELECT LAST_INSERT_ID();";
            int id = _db.ExecuteScalar<int>(sql, newJob);
            newJob.Id = id;
            return newJob;
        }
    }
}