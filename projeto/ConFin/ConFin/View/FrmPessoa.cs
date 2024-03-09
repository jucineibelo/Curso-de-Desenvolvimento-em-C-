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
    public partial class FrmPessoa : Form
    {
        NpgsqlConnection conexao = null;
        public FrmPessoa(NpgsqlConnection conexao)
        {
            this.conexao = conexao;
            InitializeComponent();
            dataGridViewMostra.AutoGenerateColumns = false;
            atualizaGrid();
        }

        private void atualizaGrid()
        {
            List<Pessoa> lista = PessoaDB.getPessoa(conexao);
            dataGridViewMostra.DataSource = lista;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmPessoaNovo form = new FrmPessoaNovo(conexao);
            form.ShowDialog();
            atualizaGrid();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = (Pessoa)dataGridViewMostra.SelectedRows[0].DataBoundItem;
            FrmAlteraPessoa form = new FrmAlteraPessoa(conexao, pessoa);
            form.ShowDialog();
            atualizaGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir a pessoa?", "Excluir Pessoa", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                Pessoa pessoa = (Pessoa)dataGridViewMostra.SelectedRows[0].DataBoundItem;
                bool realizou = PessoaDB.setExcluiPessoa(conexao, pessoa.pessoa_id);
                if (realizou)
                {
                    MessageBox.Show("Pessoa excluida com sucesso!");
                    atualizaGrid();
                } else
                {
                    MessageBox.Show("Erro ao excluir pessoa");
                }
            }
            
        }
    }
}
