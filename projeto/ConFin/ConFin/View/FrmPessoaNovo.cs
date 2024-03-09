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

namespace ConFin.View
{
    public partial class FrmPessoaNovo : Form
    {
        NpgsqlConnection conexao = null;
        public FrmPessoaNovo(NpgsqlConnection conexao)
        {
            this.conexao = conexao;
            InitializeComponent();
            populaCampoCidade();
            populaTipo();
        }

        private void populaCampoCidade()
        {
            List<Cidade> lista = CidadeDB.getCidades(conexao);
            cbCidade.Items.Clear();
            cbCidade.DataSource = lista;
            if (cbCidade.Items.Count > 0 )
            {
                cbCidade.SelectedIndex = 0;
            }

        }
        private void populaTipo()
        {
            List<string> tipos = new List<string>();
            cbTipo.SelectedIndex = 0;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa(edtNome.Text, edtCpfCnpj.Text, edtEndereco.Text, edtBairro.Text, edtTelefone.Text, edtEmail.Text,
                                       cbTipo.SelectedIndex, ( (Cidade) cbCidade.SelectedItem).cidade_id);
            bool realizou = PessoaDB.setIncluiPessoa(conexao, pessoa);
            if (realizou)
            {
                MessageBox.Show("Pesso cadastrada com sucesso!");
                Close();
            } else
            {
                MessageBox.Show("Erro ao cadastrar pessoa");
            }
        }
    }
}
