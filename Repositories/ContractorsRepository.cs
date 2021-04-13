using System;
using System.Collections.Generic;
using System.Data;
using cJobs.Models;
using Dapper;

namespace cJobs.Repositories
{
    public class ContractorsRepository
    {

        private readonly IDbConnection _db;
        public ContractorsRepository(IDbConnection db)
        {
            _db = db;
        }
        internal IEnumerable<Contractor> GetAll()
        {
            string sql = "SELECT * FROM contractors;";
            return _db.Query<Contractor>(sql);
        }

        internal Contractor GetById(int id)
        {
            string sql = "SELECT * FROM contractors WHERE id = @id;";
            return _db.QueryFirstOrDefault<Contractor>(sql, new { id });
        }

        internal Contractor Create(Contractor newContractor)
        {
            string sql = @"
            INSERT INTO contractors
            (id, company, description)
            VALUES
            (@Id, @Company, @Description);
            SELECT LAST_INSERT_ID();";
            int id = _db.ExecuteScalar<int>(sql, newContractor);
            newContractor.Id = id;
            return newContractor;
        }
    }
}