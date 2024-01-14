using ConFin.Controller;
using ConFin.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConFin
{
    public partial class FrmPrincipal : Form
    {
        public NpgsqlConnection conexao = null;
        public FrmPrincipal()
        {
            conexao = Conexao.getConexao();
            InitializeComponent();
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Conexao.setFechaConexao(conexao);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Pessoa> lista =  PessoaDB.getPessoa(conexao);
            richTextBox1.Clear();

            for (int i = 0; i < lista.Count; i++)
            {
                Pessoa pessoa = lista[i];
                richTextBox1.AppendText("Pessoa: " + pessoa.pessoa_id + " - " + pessoa.nome + " - " + pessoa.endereco + "\n");
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa("Daia", "123", "Rua Armando Marinho", "São Jorge", "99812356", "daia@example.com", "0", 1);
            bool realizou = PessoaDB.setIncluiPessoa(conexao, pessoa);
            
            if (realizou)
            {
                MessageBox.Show("Incluido com sucesso!");
            } else
            {
                MessageBox.Show("Erro ao incluir!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa(5, "Dayane", "123", "Rua Armando Marinho", "São Jorge", "99812356", "daia@example.com", "0", 1);
            bool realizou = PessoaDB.setAlteraPessoa(conexao, pessoa);

            if (realizou)
            {
                MessageBox.Show("Alterado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao alterar!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            bool realizou = PessoaDB.setExcluiPessoa(conexao, 7);

            if (realizou)
            {
                MessageBox.Show("Excluido com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao excluir!");
            }
        }
    }
}
