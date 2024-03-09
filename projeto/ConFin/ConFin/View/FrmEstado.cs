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
    public partial class FrmEstado : Form
    {
        NpgsqlConnection conexao = null;
        public FrmEstado(NpgsqlConnection conexao)
        {
            this.conexao = conexao;    //this.conexao = variavel criada; conexao = parametro da função/construtor
            InitializeComponent();
            atualizaGrid();
        }
        private void atualizaGrid()
        {
            List<Estado> lista = EstadoDB.getEstados(conexao);
            dataGridViewMostra.DataSource = lista;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmEstadoNovo form = new FrmEstadoNovo(conexao);
            form.ShowDialog();
            atualizaGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Estado estado = (Estado) dataGridViewMostra.SelectedRows[0].DataBoundItem;
            FrmEstadoAltera form = new FrmEstadoAltera(conexao, estado);
            form.ShowDialog();
            atualizaGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja mesmo excluir o estado? ", "Excluir Estado", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK) 
            {
                Estado estado = (Estado)dataGridViewMostra.SelectedRows[0].DataBoundItem;
                bool reazlizou = EstadoDB.setExcluiEstado(conexao, estado.estado_id);

                if (reazlizou)
                {
                    MessageBox.Show("Estado Excluido com sucesso!");
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
