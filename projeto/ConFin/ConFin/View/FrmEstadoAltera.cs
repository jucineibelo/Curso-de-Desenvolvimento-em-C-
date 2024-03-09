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
    public partial class FrmEstadoAltera : Form
    {
        NpgsqlConnection conexao = null;
        public FrmEstadoAltera(NpgsqlConnection conexao, Estado estado)
        {
            this.conexao = conexao;
            InitializeComponent();
            edtId.Text = estado.estado_id.ToString();
            edtEstado.Text = estado.nome;
            edtUf.Text = estado.uf;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Estado estado = new Estado(edtUf.Text, edtEstado.Text);
            bool realizou = EstadoDB.setAlteraEstado(conexao, estado);
            if (realizou)
            {
                MessageBox.Show("Estado alterado com sucesso!");
                Close();
            } else
            {
                MessageBox.Show("Erro ao alterar sucesso!");
            }
        }
    }
}
