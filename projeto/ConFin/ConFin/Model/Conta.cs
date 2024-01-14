using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConFin.Model
{
    public class Conta
    {
        public int conta_id { get; set; }
        public string descricao { get; set; }   
        public double valor {  get; set; }
        public DateTime dataVencimento { get; set; }
        public char situacao { get; set; }
        public DateTime dataPagamento { get; set; } 
        public char tipo { get; set; }  
        public int pessoa_id { get; set; }  

        public Conta(int conta_id, string descricao, double valor, DateTime dataVencimento, char situacao, DateTime dataPagamento, char tipo, int pessoa_id)
        {
            this.conta_id = conta_id;
            this.descricao = descricao;
            this.valor = valor;
            this.dataVencimento = dataVencimento;
            this.situacao = situacao;
            this.dataPagamento = dataPagamento;
            this.tipo = tipo;
            this.pessoa_id = pessoa_id;
        }
    }
}
