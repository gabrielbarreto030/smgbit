using Microsoft.EntityFrameworkCore;
using SMGBIT.Core.Entity;
using SMGBIT.Core.Interfaces;
using SMGBIT.Infra.Data.Context;
using System;
using System.Collections.Generic;

using System.Threading.Tasks;

namespace SMGBIT.Infra.Data.Repository
{
    public class ViagensRepository : IViagensRepository
    {
        ApplicationContext _viagensContext;
        public  ViagensRepository(ApplicationContext context)
        {
            _viagensContext = context;
        }
        public async Task<bool> Delete(Viagem value)
        {
            _viagensContext.Remove(value);
            await _viagensContext.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Viagem>> GetAll()
        {
            return await _viagensContext.Viagens.ToListAsync();
        }

        public async Task<Viagem> GetById(int Id)
        {
            return  await _viagensContext.Viagens.FindAsync(Id);
        }

        public async Task<Viagem> Post(Viagem value)
        {
            _viagensContext.Add(value);
            await _viagensContext.SaveChangesAsync();
            return value;
        }

        public async Task<Viagem> Put(Viagem value)
        {
            _viagensContext.Update(value);
            await _viagensContext.SaveChangesAsync();
            return value;
        }
    }
}
