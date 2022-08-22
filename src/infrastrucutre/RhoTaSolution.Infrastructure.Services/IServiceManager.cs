using RhoTaSolution.Infrastructure.Services.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhoTaSolution.Infrastructure.Services
{
    public interface IServiceManager
    {
        IHospitalService HospitalService { get; }
    }
}
