using SMGBIT.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMGBIT.Application.Interfaces
{
    public interface IViagensService
    {
        Task<IEnumerable<ViagemDTO>> getViagens();
        Task<ViagemDTO> getById(int id);
        Task Add(ViagemDTO viagemDto);
        Task Update(ViagemDTO viagemDto);
        Task Remove(int id);
    }
}
