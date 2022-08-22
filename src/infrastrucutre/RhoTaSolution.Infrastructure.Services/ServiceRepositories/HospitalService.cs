using AutoMapper;
using RhoTaSolution.Application.Contracts;
using RhoTaSolution.Application.DataTransferObjects.HospitalDTO;
using RhoTaSolution.Infrastructure.Services.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhoTaSolution.Infrastructure.Services.ServiceRepositories
{
    internal sealed class HospitalService : IHospitalService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
       

       
        public HospitalService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<HospitalDto> GetHospitals(bool trackChanges)
        {
            try
            {
                var hospitals = _repositoryManager.Hospital.GetAllHospital(trackChanges);
                var hospitalDto = _mapper.Map<IEnumerable<HospitalDto>>(hospitals);

                return hospitalDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetHospitals)} service method {ex}");
                throw;
            }
        }
    }
}
