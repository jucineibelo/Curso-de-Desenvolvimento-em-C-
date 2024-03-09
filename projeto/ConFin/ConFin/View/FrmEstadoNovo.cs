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
    public partial class FrmEstadoNovo : Form
    {
        NpgsqlConnection conexao = null;
        public FrmEstadoNovo(NpgsqlConnection conexao)
        {
            this.conexao = conexao; //this.conexao = variavel - conexao = parametro da função
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Estado estado = new Estado(edtUf.Text, edtEstado.Text);
            bool realizou = EstadoDB.setIncluiEstado(conexao, estado);
            if (realizou)
            {
                MessageBox.Show("Estado cadastrado com sucesso!");
                Close();
            } else
            {
                MessageBox.Show("Estado não cadastrado.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
