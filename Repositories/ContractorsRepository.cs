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
    }
}