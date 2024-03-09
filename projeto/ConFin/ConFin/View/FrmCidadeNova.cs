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
    public partial class FrmCidadeNova : Form
    {
        NpgsqlConnection conexao = null;
        public FrmCidadeNova(NpgsqlConnection conexao)
        {
            this.conexao = conexao;   
            InitializeComponent();
            populaCBEstado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void populaCBEstado()
        {
            List<Estado> lista = EstadoDB.getEstados(conexao);
            cbEstado.Items.Clear();
            cbEstado.DataSource = lista;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = edtNome.Text;
            Estado estado = (Estado) cbEstado.SelectedItem;
            Cidade cidade = new Cidade(edtNome.Text, estado.estado_id);
            bool realizou = CidadeDB.setIncluiCidade(conexao, cidade);
            if (realizou)
            {
                MessageBox.Show("Cidade cadastrada com sucesso!");
                Close();
            } else
            {
                MessageBox.Show("Erro ao cadastrar cidade.");
            }
        }
    }
}
