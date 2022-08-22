using RhoTaSolution.Application.Contracts;
using RhoTaSolution.Domain.Entities;
using RhoTaSolution.Infrastructure.Persistence.ApplicationDBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhoTaSolution.Infrastructure.Persistence.Repositories
{
    public class HospitalRepository : RepositoryBase<Hospital>, IHospitalRepository
    {
        public HospitalRepository(RepositoryContext repositoryContext ) : base( repositoryContext )
        {

        }
        public IEnumerable<Hospital> GetAllHospital(bool trackCHanges) =>
            FindAll(trackCHanges)
            .OrderBy(c => c.Hospital_Name)
            .ToList();
        
    }
}
