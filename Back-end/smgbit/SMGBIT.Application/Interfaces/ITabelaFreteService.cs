using SMGBIT.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMGBIT.Application.Interfaces
{
    public interface ITabelaFreteService
    {
        Task<IEnumerable<TabelaFreteDTO>> getTabelas();
        Task<TabelaFreteDTO> getById(int id);
    }
}
