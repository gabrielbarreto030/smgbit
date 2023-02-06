using System;
using System.Collections.Generic;
using System.Text;

namespace SMGBIT.Core.Entity
{
    public class Viagem :Base
    {
        public DateTime DataViagem { get; set; }
        public int NumeroViagem { get; set; }
        public string Motorista { get; set; }
        public string Placa { get; set; }
        public string TipoVeiculo { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public int CaixasCarregadas { get; set; }
        public int Entregas { get; set; }
        public int KmRodado { get; set; }
        public string TipoViagem { get; set; }
        public string TabelaViagem { get; set; }
        public double ValorViagem { get; set; }
    }
}
