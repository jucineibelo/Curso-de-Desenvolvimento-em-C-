using ConFin.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConFin.Controller
{
    public class CidadeDB
    {
        public static List<Cidade> getCidades(NpgsqlConnection conexao)
        {
            List<Cidade> lista = new List<Cidade>();

            try
            {
                string sql = "select cidade_id, nome, estado_id from cidade order by cidade_id asc";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader rd = cmd.ExecuteReader();  //Reader porque é select então vai buscar apenas senão seria ExecuteNonQuery()

                while (rd.Read())
                {
                    int cidade_id = int.Parse(rd["cidade_id"].ToString());
                    string nome = rd["nome"].ToString();
                    int estado_id = int.Parse(rd["estado_id"].ToString());
                    Cidade cidade = new Cidade(cidade_id, nome, estado_id);
                    lista.Add(cidade);
                }
                rd.Close();

            } catch (NpgsqlException erro)
            {
                MessageBox.Show("Erro ao listar " + erro.Message);
            }
            return lista;
        }

        public static bool setIncluiCidade(NpgsqlConnection conexao, Cidade cidade)
        {
            bool realizou = false;

            try
            {
                string sql = "INSERT INTO cidade (nome, estado_id) VALUES(@nome, @estado_id)";
                NpgsqlCommand cmd = new NpgsqlCommand( sql, conexao);
                cmd.Parameters.Add("nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = cidade.nome;
                cmd.Parameters.Add("estado_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = cidade.estado_id;
                int valor = cmd.ExecuteNonQuery();

                if(valor == 1)
                {
                    realizou = true;
                }         

            } catch(NpgsqlException erro)
            {
               MessageBox.Show("Erro ao incluir: " + erro.Message);
            }
            return realizou;
        }

        public static bool setAlteraCidade(NpgsqlConnection conexao, Cidade cidade)
        {
            bool realizou = false;

            try
            {
                string sql = "UPDATE cidade set nome=@nome, estado_id=@estado_id WHERE cidade_id=@cidade_id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = cidade.nome;
                cmd.Parameters.Add("estado_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = cidade.estado_id;
                cmd.Parameters.Add("cidade_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = cidade.cidade_id;
                int valor = cmd.ExecuteNonQuery();

                if (valor == 1)
                {
                    realizou = true;
                }

            } catch(NpgsqlException erro)
            {
                MessageBox.Show("Erro ao alterar: " + erro.Message);
            }
            return realizou;
        }

        public static bool setDeletaCidade(NpgsqlConnection conexao, int cidade_id)
        {
            bool realizou = false;

            try
            {
                string sql = "DELETE FROM cidade WHERE cidade_id = @cidade_id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@cidade_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = cidade_id;
                int valor = cmd.ExecuteNonQuery();

                if (valor == 1)
                {
                    realizou = true;
                }

            } catch(NpgsqlException erro)
            {
                MessageBox.Show("Erro ao excluir: " + erro.Message);    
            }
            return realizou;
        }
    }
}
