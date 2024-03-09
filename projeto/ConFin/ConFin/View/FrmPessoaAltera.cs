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
    public partial class FrmAlteraPessoa : Form
    {
        NpgsqlConnection conexao = null;
        Pessoa pessoa = null;
        public FrmAlteraPessoa(NpgsqlConnection conexao, Pessoa pessoa)
        {
            this.conexao = conexao;
            this.pessoa = pessoa;
            InitializeComponent();
            ajustaDados();
        }

        private void ajustaDados()
        {
            List<Cidade> lista = CidadeDB.getCidades(conexao);
            cbCidade.Items.Clear();
            cbCidade.DataSource = lista;
            int indice = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                Cidade cidade = lista[i];
                if (cidade.cidade_id == pessoa.cidade_id)
                {
                    indice = i;
                    break;
                }
                cbCidade.SelectedIndex = indice;
            }
               
            edtID.Text = pessoa.pessoa_id.ToString();
            edtNome.Text = pessoa.nome;
            edtCpfCnpj.Text = pessoa.cpfcnpj;
            edtEndereco.Text = pessoa.endereco;
            edtBairro.Text = pessoa.bairro;
            edtTelefone.Text = pessoa.telefone; 
            edtEmail.Text = pessoa.email;
            cbTipo.SelectedIndex = pessoa.tipo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            pessoa.nome = edtNome.Text;
            pessoa.endereco = edtEndereco.Text;
            pessoa.cpfcnpj = edtCpfCnpj.Text;
            pessoa.bairro = edtBairro.Text;
            pessoa.telefone = edtTelefone.Text;
            pessoa.email = edtEmail.Text;
            Cidade cidade = (Cidade)cbCidade.SelectedItem; 
            pessoa.cidade_id = cidade.cidade_id;
            pessoa.tipo = cbTipo.SelectedIndex;

            bool realizou = PessoaDB.setAlteraPessoa(conexao, pessoa);
            if (realizou)
            {
                MessageBox.Show("Pessoa salva com sucesso");
                Close();
            } else
            {
                MessageBox.Show("Erro ao cadastrar pessoa");
            }
        }
    }
}
