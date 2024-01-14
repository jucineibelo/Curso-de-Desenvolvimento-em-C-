using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConFin.Model
{
    public class Estado
    {
        public int estado_id {  get; set; }
        public string uf {  get; set; } 
        public string nome { get; set; }

        //construtor
        public Estado(int estado_id, string uf, string nome ) 
        {
            this.estado_id = estado_id;
            this.uf = uf;
            this.nome = nome;  //quando um parametro está com o this é porque vem das variaveis e parametro sem this é do escopo do construtor
        }

        public Estado(string uf, string nome)
        {
            this.uf = uf;
            this.nome = nome;  
        }

    }
}
