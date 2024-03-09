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
    public partial class FrmCidade : Form
    {
        NpgsqlConnection conexao = null;
        public FrmCidade(NpgsqlConnection conexao)
        {
            this.conexao = conexao;
            InitializeComponent();
            atualizaGrid();
        }

        private void atualizaGrid()
        {
            List<Cidade> lista = CidadeDB.getCidades(conexao);
            dataGridViewMostra.DataSource = lista;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCidadeNova form = new FrmCidadeNova(conexao);
            form.ShowDialog();
            atualizaGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cidade cidade = (Cidade) dataGridViewMostra.SelectedRows[0].DataBoundItem;
            FrmCidadeAltera form = new FrmCidadeAltera(conexao, cidade);
            form.ShowDialog();
            atualizaGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja mesmo excluir a cidade? ", "Excluir Cidade", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                Cidade cidade = (Cidade)dataGridViewMostra.SelectedRows[0].DataBoundItem;
                bool reazlizou = CidadeDB.setDeletaCidade(conexao, cidade.cidade_id);

                if (reazlizou)
                {
                    MessageBox.Show("Cidade Excluida com sucesso!");
                    atualizaGrid();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir estado!");
                }
            }
        }
    }
}
