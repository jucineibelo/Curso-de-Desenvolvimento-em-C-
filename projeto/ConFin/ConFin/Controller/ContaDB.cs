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
    public class ContaDB
    {
        public static List<Conta> getContas(NpgsqlConnection conexao)
        {
            List<Conta> lista = new List<Conta>();

            try
            {
                string sql = "select conta_id, descricao, valor, datavencimento, situacao, datapagamento, tipo, pessoa_id from conta order by conta_id asc";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    int conta_id = int.Parse(rd["conta_id"].ToString());
                    string descricao = rd["descricao"].ToString();
                    double valor = double.Parse(rd["valor"].ToString());
                    DateTime datavencimento = DateTime.Parse(rd["datavencimento"].ToString());
                    int situacao = int.Parse(rd["situacao"].ToString());
                    DateTime datapagamento = DateTime.Parse(rd["datapagamento"].ToString());
                    int tipo = int.Parse(rd["tipo"].ToString());
                    int pessoa_id = int.Parse(rd["pessoa_id"].ToString());
                    Conta conta = new Conta(conta_id, descricao, valor, datavencimento, situacao, datapagamento, tipo, pessoa_id);
                    lista.Add(conta);
                }
                rd.Close();
            }
            catch (NpgsqlException error)
            {
                MessageBox.Show("Erro ao listar: " + error.Message);
            }
            return lista;
        }
        
        public static bool setIncluiConta(NpgsqlConnection conexao, Conta conta)
        {
            bool realizou = false;

            try
            {
                string sql = "INSERT INTO conta (descricao, valor, datavencimento, situacao, datapagamento, tipo, pessoa_id) " +
                             "VALUES (@descricao, @valor, @datavencimento, @situacao, @datapagamento, @tipo, @pessoa_id)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("descricao", NpgsqlTypes.NpgsqlDbType.Varchar).Value = conta.descricao;
                cmd.Parameters.Add("valor", NpgsqlTypes.NpgsqlDbType.Double).Value = conta.valor;
                cmd.Parameters.Add("datavencimento", NpgsqlTypes.NpgsqlDbType.Date).Value = conta.dataVencimento;
                cmd.Parameters.Add("situacao", NpgsqlTypes.NpgsqlDbType.Integer).Value = conta.situacao;
                cmd.Parameters.Add("datapagamento", NpgsqlTypes.NpgsqlDbType.Date).Value = conta.dataPagamento;
                cmd.Parameters.Add("tipo", NpgsqlTypes.NpgsqlDbType.Integer).Value = conta.tipo;
                cmd.Parameters.Add("pessoa_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = conta.pessoa_id;
                int valor = cmd.ExecuteNonQuery();
                if (valor == 1)
                {
                    realizou = true;
                }

            } catch (NpgsqlException error)
            {
                MessageBox.Show("Erro ao incluir: " + error.Message);
            }
            return realizou;
            
        }
        public static bool setAlteraConta(NpgsqlConnection conexao, Conta conta)
        {
            bool realizou = false;

            try
            {
                string sql = "UPDATE conta SET descricao=@descricao, valor=@valor, datavencimento=@datavencimento, situacao=@situacao, " + 
                             "datapagamento = @datapagamento, tipo = @tipo, pessoa_id = @pessoa_id WHERE conta_id = @conta_id          ";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("descricao", NpgsqlTypes.NpgsqlDbType.Varchar).Value = conta.descricao;
                cmd.Parameters.Add("valor", NpgsqlTypes.NpgsqlDbType.Double).Value = conta.valor;
                cmd.Parameters.Add("datavencimento", NpgsqlTypes.NpgsqlDbType.Date).Value = conta.dataVencimento;
                cmd.Parameters.Add("situacao", NpgsqlTypes.NpgsqlDbType.Integer).Value = conta.situacao;
                cmd.Parameters.Add("datapagamento", NpgsqlTypes.NpgsqlDbType.Date).Value = conta.dataPagamento;
                cmd.Parameters.Add("tipo", NpgsqlTypes.NpgsqlDbType.Integer).Value = conta.tipo;
                cmd.Parameters.Add("pessoa_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = conta.pessoa_id;
                cmd.Parameters.Add("conta_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = conta.conta_id;
                int valor = cmd.ExecuteNonQuery();

                if (valor == 1)
                {
                    realizou = true;
                }
            }
            catch (NpgsqlException erro)
            {
                MessageBox.Show("Erro ao alterar: " + erro.Message);
            }
            return realizou;
        }

        public static bool setExcluiConta(NpgsqlConnection conexao, int conta_id)
        {
            bool realizou = false;

            try
            {
                string sql = "DELETE FROM conta WHERE conta_id = @conta_id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@conta_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = conta_id;
                int valor = cmd.ExecuteNonQuery();

                if (valor == 1)
                {
                    realizou = true;
                }
            }
            catch (NpgsqlException erro)
            {
                MessageBox.Show("Erro ao excluir: " + erro.Message);
            }
            return realizou;
        }
    }
}
