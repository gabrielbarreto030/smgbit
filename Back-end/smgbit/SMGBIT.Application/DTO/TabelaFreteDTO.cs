using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMGBIT.Application.DTO
{
    public class TabelaFreteDTO
    {

        public string NomeTabela { get; set; }
        [Required(ErrorMessage ="O valor do frete é obrigatório")]
        public double Valor { get; set; }
        public string TipoVeiculo { get; set; }
        public string Cliente { get; set; }
        public string? Destino { get; set; }
    }
}
