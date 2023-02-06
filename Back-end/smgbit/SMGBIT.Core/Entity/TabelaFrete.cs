using System;
using System.Collections.Generic;
using System.Text;

namespace SMGBIT.Core.Entity
{
   public class TabelaFrete :Base
    {
        public TabelaFrete(int id,string nomeTabela,double Valor,string TipoVeiculo,string Cliente,string? Destino=null)
            
        {
            this.Id = id;
            this.NomeTabela = nomeTabela;
            this.Valor = Valor;
            this.TipoVeiculo = TipoVeiculo;                
            this.Cliente = Cliente;
            this.Destino = Destino;
                
        }
        public string NomeTabela { get; set; }
        public double Valor  { get; set; }
        public string TipoVeiculo { get; set; }
        public string Cliente { get; set; }
        public string? Destino { get; set; }

    }
}
