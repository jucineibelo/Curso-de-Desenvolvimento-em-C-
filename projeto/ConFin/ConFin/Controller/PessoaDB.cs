using ConFin.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ConFin.Controller
{
    public class PessoaDB
    {
        public static List<Pessoa> getPessoa(NpgsqlConnection conexao)
        {
            List<Pessoa> lista = new List<Pessoa>();

            try
            {
                string sql = "select pessoa_id, nome, cpfcnpj, endereco, bairro, telefone, email, tipo, cidade_id from pessoa order by pessoa_id asc";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader rd = cmd.ExecuteReader();  //Reader porque é select então vai buscar apenas senão seria ExecuteNonQuery()

                while (rd.Read())
                {
                    int pessoa_id = int.Parse(rd["pessoa_id"].ToString());
                    string nome = rd["nome"].ToString();
                    string cpfcnpj =(rd["cpfcnpj"].ToString());
                    string endereco = (rd["endereco"].ToString());
                    string bairro = (rd["bairro"].ToString());
                    string telefone = (rd["telefone"].ToString());
                    string email = (rd["email"].ToString());
                    int tipo = int.Parse(rd["tipo"].ToString());
                    int cidade_id = int.TryParse(rd["cidade_id"].ToString(), out int parsedValue) ? parsedValue : 0;
                    Pessoa pessoa = new Pessoa(pessoa_id, nome, cpfcnpj, endereco, bairro, telefone, email, tipo, cidade_id);
                    lista.Add(pessoa);
                }
                rd.Close();
            }
            catch (NpgsqlException erro)
            {
                MessageBox.Show("Erro ao listar " + erro.Message);
            }
            return lista;
        }

        public static bool setIncluiPessoa(NpgsqlConnection conexao, Pessoa pessoa)
        {
            bool realizou = false;

            try
            {
                string sql = " INSERT INTO pessoa(nome, cpfcnpj, endereco, bairro, telefone, email, tipo, cidade_id) " +
                             " VALUES(@nome, @cpfcnpj, @endereco, @bairro, @telefone, @email, @tipo, @cidade_id)     ";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.nome;
                cmd.Parameters.Add("cpfcnpj", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.cpfcnpj;
                cmd.Parameters.Add("endereco", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.endereco;
                cmd.Parameters.Add("bairro", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.bairro;
                cmd.Parameters.Add("telefone", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.telefone;
                cmd.Parameters.Add("email", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.email;
                cmd.Parameters.Add("tipo", NpgsqlTypes.NpgsqlDbType.Integer).Value = pessoa.tipo;
                cmd.Parameters.Add("cidade_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = pessoa.cidade_id;
                int valor = cmd.ExecuteNonQuery();

                if (valor == 1)
                {
                    realizou = true;
                }
            }
            catch (NpgsqlException erro)
            {
                MessageBox.Show("Erro ao incluir: " + erro.Message);
            }
            return realizou;
        }

        public static bool setAlteraPessoa(NpgsqlConnection conexao, Pessoa pessoa)
        {
            bool realizou = false;

            try
            {
                string sql = "UPDATE pessoa SET nome=@nome, cpfcnpj=@cpfcnpj, endereco=@endereco, bairro=@bairro, telefone=@telefone, " +
                             "email=@email, tipo=@tipo, cidade_id=@cidade_id WHERE pessoa_id=@pessoa_id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.nome;
                cmd.Parameters.Add("cpfcnpj", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.cpfcnpj;
                cmd.Parameters.Add("endereco", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.endereco;
                cmd.Parameters.Add("bairro", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.bairro;
                cmd.Parameters.Add("telefone", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.telefone;
                cmd.Parameters.Add("email", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.email;
                cmd.Parameters.Add("tipo", NpgsqlTypes.NpgsqlDbType.Integer).Value = pessoa.tipo;
                cmd.Parameters.Add("cidade_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = pessoa.cidade_id;
                cmd.Parameters.Add("pessoa_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = pessoa.pessoa_id;

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

        public static bool setExcluiPessoa(NpgsqlConnection conexao, int pessoa_id)
        {
            bool realizou = false;

            try
            {
                string sql = "DELETE FROM pessoa WHERE pessoa_id = @pessoa_id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@pessoa_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = pessoa_id;
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

