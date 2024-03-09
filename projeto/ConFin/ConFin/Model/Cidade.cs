using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConFin.Model
{
    public class Cidade
    {
        public int cidade_id{get; set;}
        public string nome { get; set;}
        public int estado_id { get; set;}

        public Cidade(int cidade_id, string nome, int estado_id) 
        {   
            this.cidade_id = cidade_id;
            this.nome = nome;
            this.estado_id = estado_id;
        }

        //nesse metodo com sobrecarga está sem o campo ID para quando chamar o construtor não precisar passar o ID por parametro
        //porque o ID no banco de dados está como autoincremento
        public Cidade(string nome, int estado_id)
        {
            this.nome = nome;
            this.estado_id = estado_id;
        }

        override
        public String ToString()
        {
            return this.cidade_id + " - " + this.nome;
        }

    }
}
