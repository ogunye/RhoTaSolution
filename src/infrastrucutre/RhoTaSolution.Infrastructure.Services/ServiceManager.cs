using AutoMapper;
using RhoTaSolution.Application.Contracts;
using RhoTaSolution.Infrastructure.Services.Service.Contracts;
using RhoTaSolution.Infrastructure.Services.ServiceRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhoTaSolution.Infrastructure.Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IHospitalService> _hospitalService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _hospitalService = new Lazy<IHospitalService>(() => new HospitalService(repositoryManager,logger, mapper));
        }

        public IHospitalService HospitalService => _hospitalService.Value;
    }
}
