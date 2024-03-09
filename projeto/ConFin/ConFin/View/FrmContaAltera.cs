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
    public partial class FrmContaAltera : Form
    {
        NpgsqlConnection conexao = null;
        Conta conta = null;

        public FrmContaAltera(NpgsqlConnection conexao, Conta conta)
        {
            this.conexao = conexao;
            this.conta = conta;
            InitializeComponent();
            ajustaCampos();
        }

        private void ajustaCampos()
        {
            List<Pessoa> lista = PessoaDB.getPessoa(conexao);
            cbPessoa.Items.Clear();
            cbPessoa.DataSource = lista;

            int indice = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                Pessoa pessoa = lista[i];
                if (pessoa.pessoa_id == conta.pessoa_id) 
                {
                    indice = 1;
                    break;
                }
            }
            cbPessoa.SelectedIndex = indice;

            edtId.Text = conta.conta_id.ToString();
            edtDescricao.Text = conta.descricao;
            edtValor.Text = conta.valor.ToString("N2"); //N2 = 2  casas decimais
            edtDataVecimento.Text = conta.dataVencimento.ToString();
            edtDataPagamento.Text = conta.dataPagamento.ToString();
            cbTipo.SelectedIndex = conta.tipo;
            cbSituacao.SelectedIndex = conta.situacao;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            conta.descricao = edtDescricao.Text;
            conta.valor = double.Parse(edtValor.Text);
            conta.dataVencimento = DateTime.Parse(edtDataVecimento.Text);

            DateTime? valorPadrao = null; //nsse trecho da variavel valorPadrao e datapagamento é para quando não informar a data buscar uma                                                                                                                                                                    data default
            DateTime datapagamento = valorPadrao.GetValueOrDefault();
            try
            {
                datapagamento = DateTime.Parse(edtDataPagamento.Text);
            }
            catch (Exception error)
            {
                Console.WriteLine("Erro na conversão de data: " + error.Message);
            }

            conta.dataPagamento = datapagamento;
            conta.tipo = cbTipo.SelectedIndex;
            conta.situacao = cbSituacao.SelectedIndex;
            conta.pessoa_id = ((Pessoa) cbPessoa.SelectedItem).pessoa_id;

            bool realizou = ContaDB.setAlteraConta(conexao, conta);
            if (realizou)
            {
                MessageBox.Show("Conta Alterada com sucesso.");
                Close();
            } else
            {
                MessageBox.Show("Erro ao alterar conta.");
            }

        }
    }
}
