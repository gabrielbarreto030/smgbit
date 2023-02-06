using AutoMapper;
using SMGBIT.Application.DTO;
using SMGBIT.Application.Interfaces;
using SMGBIT.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMGBIT.Application.Services
{
    public class TabelaFreteService : ITabelaFreteService
    {
       
        private ITabelaFreteRepository _tabelaFreteRepository;
        private readonly IMapper _mapper;

        public TabelaFreteService(ITabelaFreteRepository tabelaFreteRepository,IMapper mapper)
        {
            this._mapper = mapper;
            this._tabelaFreteRepository = tabelaFreteRepository;
        }
        public async Task<TabelaFreteDTO> getById(int id)
        {
         var tabela=await _tabelaFreteRepository.GetById(id);
            return _mapper.Map<TabelaFreteDTO>(tabela);
           
        }

        public async Task<IEnumerable<TabelaFreteDTO>> getTabelas()
        {
            var tabelas = await _tabelaFreteRepository.GetAll();
            return _mapper.Map<IEnumerable<TabelaFreteDTO>>(tabelas);
        }
    }
}
