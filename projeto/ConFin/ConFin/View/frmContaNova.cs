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
    public partial class frmContaNova : Form
    {
        NpgsqlConnection conexao = null;
        public frmContaNova(NpgsqlConnection conexao)
        {
            this.conexao = conexao;
            InitializeComponent();
            ajustaCampos();
        }

        private void ajustaCampos()
        {
            List<Pessoa> lista = PessoaDB.getPessoa(conexao);
            cbPessoa.Items.Clear();
            cbPessoa.DataSource = lista;
            cbTipo.SelectedIndex = 0;
            cbSituacao.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string descricao = edtDescricao.Text;
            double valor = double.Parse(edtValor.Text);
            DateTime datavencimento = DateTime.Parse(edtDataVecimento.Text);
            
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
            int tipo = cbTipo.SelectedIndex;
            int situacao = cbSituacao.SelectedIndex;
            int pessoaid = ((Pessoa)cbPessoa.SelectedItem).pessoa_id;
            Conta conta = new Conta(descricao, valor, datavencimento, situacao, datapagamento, tipo, pessoaid);
            bool realizou = ContaDB.setIncluiConta(conexao, conta);
            if (realizou)
            {
                MessageBox.Show("Conta Cadastrada com sucesso");
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar conta");
            }

        }
    }
}
