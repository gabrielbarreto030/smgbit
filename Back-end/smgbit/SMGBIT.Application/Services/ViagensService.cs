using AutoMapper;
using SMGBIT.Application.DTO;
using SMGBIT.Application.Interfaces;
using SMGBIT.Core.Entity;
using SMGBIT.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMGBIT.Application.Services
{
    public class ViagensService : IViagensService
    {
        private readonly IMapper _mapper;
        private IViagensRepository _viagensRepository;
        
        public ViagensService(IViagensRepository viagensRepository,IMapper mapper)
        {
            this._viagensRepository = viagensRepository;
            this._mapper=mapper;

        }

        public async Task Add(ViagemDTO viagemDto)
        {
            var viagem = _mapper.Map<Viagem>(viagemDto);
            await _viagensRepository.Post(viagem);
        }

        public async Task<ViagemDTO> getById(int id)
        {
          
            var viagem = await _viagensRepository.GetById(id);
            return _mapper.Map<ViagemDTO>(viagem);
        }

        public async Task<IEnumerable<ViagemDTO>> getViagens()
        {
            var viagens=await _viagensRepository.GetAll();
            return _mapper.Map<IEnumerable<ViagemDTO>>(viagens);
         
        }

        public async Task Remove(int id)
        {
            var viagem = _viagensRepository.GetById(id).Result;
            await _viagensRepository.Delete(viagem);
        }

        public async Task Update(ViagemDTO viagemDto)
        {
            var viagem = _mapper.Map<Viagem>(viagemDto);
            await _viagensRepository.Put(viagem);
        }
    }
}
