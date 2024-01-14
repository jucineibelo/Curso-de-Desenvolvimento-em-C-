using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConFin.Controller
{
    public class Conexao  //publico pois vai chamar a classe em qualquer trecho do código
    {
        public static NpgsqlConnection getConexao()  //metodo declarado static, quando chamar no código não havera neccessidade de criar um objeto ex: Objeto obj = new Objeto
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = new NpgsqlConnection("server=localhost;port=5432;user id=postgres;password=root;database=dados;");
                conexao.Open();
                Console.WriteLine("Conectou");
            } catch (NpgsqlException error) 
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + error.Message);   
            }
            return conexao;
        }
        
        public static void setFechaConexao(NpgsqlConnection conexao) //void -  sem retorno 
        {
            if (conexao != null) 
            {
                try
                {
                    conexao.Close();
                    Console.WriteLine("Fechou conexão");
                }catch(NpgsqlException error)
                {
                    MessageBox.Show("Erro ao fechar banco de dados: " + error.Message);
                }            
            }

        }
    }
}
