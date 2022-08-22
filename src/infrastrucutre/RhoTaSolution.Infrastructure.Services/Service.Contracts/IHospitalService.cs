using RhoTaSolution.Application.DataTransferObjects.HospitalDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhoTaSolution.Infrastructure.Services.Service.Contracts
{
    public interface IHospitalService
    {
        IEnumerable<HospitalDto> GetHospitals(bool trackChanges);
    }
}
