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
    public class EstadoDB
    {
        public static List<Estado> getEstados(NpgsqlConnection conexao)
        {
            List<Estado> lista = new List<Estado>();
            try
            {
                string sql = "select estado_id, uf, nome from estado order by estado_id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read()) //laço de repetição que percore todos os registros de rd
                {
                    int estado_id = int.Parse(rd["estado_id"].ToString());
                    string uf = rd["uf"].ToString();
                    string nome = rd["nome"].ToString();
                    Estado estado = new Estado(estado_id, uf, nome);
                    lista.Add(estado);
                }

                rd.Close();
            }
            catch (NpgsqlException erro)
            {
                MessageBox.Show("Erro de SQL: " + erro.Message);
            }
            return lista;
        }

        public static bool setIncluiEstado(NpgsqlConnection conexao, Estado estado)
        {
            bool realizou = false;

            try
            {
                string sql = "INSERT INTO estado (uf, nome) VALUES(@uf, @nome)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.Add("@uf", NpgsqlTypes.NpgsqlDbType.Varchar).Value = estado.uf;
                cmd.Parameters.Add("@nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = estado.nome;

                int valor = cmd.ExecuteNonQuery();
                if (valor == 1)
                {
                    realizou = true;
                }
            }
            catch (NpgsqlException erro)
            {
                MessageBox.Show("Erro do SQL: " + erro.Message);
            }
            return realizou;
        }

        public static bool setAlteraEstado(NpgsqlConnection conexao, Estado estado)
        {
            bool realizou = false;
            try
            {
                string sql = "UPDATE estado set uf = @uf, nome = @nome where estado_id = @estado_id ";
                NpgsqlCommand cmd = new NpgsqlCommand( sql, conexao);
                cmd.Parameters.Add("@estado_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = estado.estado_id;
                cmd.Parameters.Add("@uf", NpgsqlTypes.NpgsqlDbType.Varchar).Value = estado.uf;
                cmd.Parameters.Add("@nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = estado.nome;
                int valor = cmd.ExecuteNonQuery( );

                if (valor == 1)
                {
                    realizou = true;
                }
            }
            catch (NpgsqlException erro )
            {
                MessageBox.Show("Erro ao alterar estado: " + erro.Message);
            }
            return realizou;
        }

        public static bool setExcluiEstado(NpgsqlConnection conexao, int estado_id)
        {
            bool realizou = false;
            try
            {
                string sql = "DELETE FROM estado WHERE estado_id = @estado_id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@estado_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = estado_id;
                int valor = cmd.ExecuteNonQuery();
                
                if (valor == 1)
                {
                    realizou = true;
                }
            }catch (NpgsqlException erro )
            {
                MessageBox.Show("Erro de SQL ao tentar excluir registro: " + erro.Message);
            }

            return realizou;           
        }

    }
}



