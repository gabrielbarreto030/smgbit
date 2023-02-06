using SMGBIT.Core.Entity;
using SMGBIT.Core.Interfaces;
using SMGBIT.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMGBIT.Infra.Data.Repository
{
    public class TabelaFreteRepository : ITabelaFreteRepository
    {
        ApplicationContext _tabelaFreteContext;

       public TabelaFreteRepository(ApplicationContext context)
        {
            _tabelaFreteContext = context;
        }
        public async Task<bool> Delete(TabelaFrete value)
        {
           
            _tabelaFreteContext.Remove(value);
            await _tabelaFreteContext.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<TabelaFrete>> GetAll()
        {
            return await _tabelaFreteContext.Fretes.ToListAsync();
        }

        public async Task<TabelaFrete> GetById(int Id)
        {
            return await _tabelaFreteContext.Fretes.FindAsync(Id);
        }

        public async Task<TabelaFrete> Post(TabelaFrete value)
        {
            _tabelaFreteContext.Add(value);
            await _tabelaFreteContext.SaveChangesAsync();
            return value;
        }

        public async Task<TabelaFrete> Put(TabelaFrete value)
        {
            _tabelaFreteContext.Update(value);
            await _tabelaFreteContext.SaveChangesAsync();
            return value;
        }
    }
}
