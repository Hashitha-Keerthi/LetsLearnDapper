using LetsLearnDapper.Data;
using LetsLearnDapper.Models;
using System.Collections.Generic;
using System.Linq;

namespace LetsLearnDapper.Repository
{
    public class CompanyRepositoryEF : ICompanyRepository
    {
        private readonly ApplicationDbContext _db;

        public CompanyRepositoryEF(ApplicationDbContext db)
        {
            _db = db;
            
        }

        Company ICompanyRepository.Add(Company company)
        {
            _db.Companies.Add(company);
            _db.SaveChanges();
            return company;
        }

        Company ICompanyRepository.Find(int id)
        {
            return _db.Companies.FirstOrDefault(u => u.CompanyId ==id);
        }

        List<Company> ICompanyRepository.GetAll()
        {
            return _db.Companies.ToList();
        }

        void ICompanyRepository.Remove(int id)
        {
            Company company = _db.Companies.FirstOrDefault(u => u.CompanyId == id);
            _db.Companies.Remove(company);
            _db.SaveChanges();
            return;
        }

        Company ICompanyRepository.Update(Company company)
        {
            _db.Companies.Update(company);
            _db.SaveChanges();
            return company;


        }
    }
}
