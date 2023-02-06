using SMGBIT.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMGBIT.Application.DTO
{
    public class ViagemDTO
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "A Data da viagem é obrigatória")]
        public DateTime DataViagem { get; set; }
        public int NumeroViagem { get; set; }
        public string Motorista { get; set; }
        public string Placa { get; set; }
        public string TipoVeiculo { get; set; }
        public string Origem { get; set; }

        [Required(ErrorMessage = "O destino é obrigatório")]
        public string Destino { get; set; }
        public int CaixasCarregadas { get; set; }
        public int Entregas { get; set; }
        public int KmRodado { get; set; }
        public string TipoViagem { get; set; }
        public string TabelaViagem { get; set; }
        public double ValorViagem { get; set; }
    }
}
