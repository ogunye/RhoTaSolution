using RhoTaSolution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhoTaSolution.Application.Contracts
{
    public interface IHospitalRepository
    {
        IEnumerable<Hospital> GetAllHospital(bool trackCHanges);
    }
}
