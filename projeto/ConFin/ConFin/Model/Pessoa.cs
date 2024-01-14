using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConFin.Model
{
    public class Pessoa
    {
        public int pessoa_id { get; set; }
        public string nome { get; set; }
        public string cpfcnpj { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string tipo { get; set; }
        public int cidade_id { get; set; }

        public Pessoa(int pessoa_id, string nome, string cpfcnpj, string endereco, string bairro, string telefone, string email, string tipo, int cidade_id)
        {
            this.pessoa_id = pessoa_id;
            this.nome = nome;
            this.cpfcnpj = cpfcnpj;
            this.endereco = endereco;
            this.bairro = bairro;
            this.telefone = telefone;
            this.email = email;
            this.tipo = tipo;
            this.cidade_id = cidade_id;
        }
        public Pessoa( string nome, string cpfcnpj, string endereco, string bairro, string telefone, string email, string tipo, int cidade_id)
        {
            this.nome = nome;
            this.cpfcnpj = cpfcnpj;
            this.endereco = endereco;
            this.bairro = bairro;
            this.telefone = telefone;
            this.email = email;
            this.tipo = tipo;
            this.cidade_id = cidade_id;
        }
    }
}