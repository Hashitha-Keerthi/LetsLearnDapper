using LetsLearnDapper.Data;
using LetsLearnDapper.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace LetsLearnDapper.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private IDbConnection db;


        public CompanyRepository(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DapperDbConnection"));
        }

        public Company Add(Company company)
        {
           
        }

        public Company Find(int id)
        {
           
        }

        public List<Company> GetAll()
        {
            
        }

        public void Remove(int id)
        {
            
        }

        public Company Update(Company company)
        {
           
        }
    }
}
