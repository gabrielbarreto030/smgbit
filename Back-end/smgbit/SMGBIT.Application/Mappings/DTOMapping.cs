using AutoMapper;
using SMGBIT.Application.DTO;
using SMGBIT.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMGBIT.Application.Mappings
{
    public class DTOMapping : Profile
    {
        public DTOMapping()
        {
            CreateMap<Viagem, ViagemDTO>().ReverseMap();
            CreateMap<TabelaFrete, TabelaFreteDTO>().ReverseMap();
        }
    }
}
