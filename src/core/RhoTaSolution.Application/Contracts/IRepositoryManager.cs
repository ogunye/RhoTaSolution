using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhoTaSolution.Application.Contracts
{
    public interface IRepositoryManager
    {
        IHospitalRepository Hospital { get; }

        void Save();
    }
}
