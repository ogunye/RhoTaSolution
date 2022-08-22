using AutoMapper;
using RhoTaSolution.Application.DataTransferObjects.HospitalDTO;
using RhoTaSolution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhoTaSolution.Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Hospital, HospitalDto>().ReverseMap();    
        }
    }
}
