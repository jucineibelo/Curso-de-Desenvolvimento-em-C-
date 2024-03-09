using ConFin.Controller;
using ConFin.Model;
using ConFin.View;
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
            List<Conta> lista =  ContaDB.getContas(conexao);
            richTextBox1.Clear();

            for (int i = 0; i < lista.Count; i++)
            {
                Conta conta = lista[i];
                richTextBox1.AppendText("Conta: " + conta.conta_id + " - " + conta.descricao + " - " + conta.situacao + "\n");
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta("Gás", 10.20, DateTime.Now.AddDays(10), 0, DateTime.Now.AddDays(30), 0, 2 );
            bool realizou = ContaDB.setIncluiConta(conexao, conta);
            
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
            Conta conta = new Conta(3, "Manutenção", 150.80, DateTime.Now.AddDays(10), 0, DateTime.Now.AddDays(30), 0, 2);
            bool realizou = ContaDB.setAlteraConta(conexao, conta);

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
            bool realizou = ContaDB.setExcluiConta(conexao, 7);

            if (realizou)
            {
                MessageBox.Show("Excluido com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao excluir!");
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstado form = new FrmEstado(conexao);
            form.ShowDialog();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCidade form = new FrmCidade(conexao);
            form.ShowDialog();
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPessoa form = new FrmPessoa(conexao);
            form.ShowDialog();
        }

        private void contaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConta form = new FrmConta(conexao);
            form.ShowDialog();
        }
    }
}
