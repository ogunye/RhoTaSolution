using RhoTaSolution.Application.Contracts;
using RhoTaSolution.Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhoTaSolution.Infrastructure.Persistence.ApplicationDBContext
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IHospitalRepository> _hospitalRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _hospitalRepository = new Lazy<IHospitalRepository>(() => new HospitalRepository(repositoryContext)); 
        }
        public IHospitalRepository Hospital => _hospitalRepository.Value;

        public void Save() => _repositoryContext.SaveChanges();
    }
}
