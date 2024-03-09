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
    public partial class FrmConta : Form
    {
        NpgsqlConnection conexao = null;
        public FrmConta(NpgsqlConnection conexao)
        {
            this.conexao = conexao;
            InitializeComponent();
            dataGridViewMostra.AutoGenerateColumns = false;
            atualizaGrid();
        }

        private void atualizaGrid()
        {
            List<Conta> lista = ContaDB.getContas(conexao);
            dataGridViewMostra.DataSource = lista;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmContaNova form = new frmContaNova(conexao);
            form.ShowDialog();
            atualizaGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Conta conta = (Conta)dataGridViewMostra.SelectedRows[0].DataBoundItem;
            FrmContaAltera form = new FrmContaAltera(conexao, conta);
            form.ShowDialog();
            atualizaGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja mesmo excluir a conta? ", "Excluir Conta", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                Conta conta = (Conta)dataGridViewMostra.SelectedRows[0].DataBoundItem;
                bool realizou = ContaDB.setExcluiConta(conexao, conta.conta_id);
                if (realizou)
                {
                    MessageBox.Show("Conta excluida com sucesso");
                    atualizaGrid();
                }
                else
                {
                    MessageBox.Show("Erro ao exclui conta");
                }
            }

        }
    }
}
