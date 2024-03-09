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
    public partial class FrmCidadeAltera : Form
    {
        NpgsqlConnection conexao = null;
        Cidade cidade = null;

        public FrmCidadeAltera(NpgsqlConnection conexao, Cidade cidade)
        {
            this.cidade = cidade;   
            this.conexao = conexao;
            InitializeComponent();
            edtId.Text = cidade.cidade_id.ToString();
            edtNome.Text = cidade.nome;            
            populaCBEstado();
        }

        private void populaCBEstado()
        {
            List<Estado> lista = EstadoDB.getEstados(conexao);
            cbEstado.Items.Clear();
            cbEstado.DataSource = lista;
            int indice = 0;

            for(int i = 0; i < lista.Count; i++)
            {
                Estado estado = lista[i];
                if (estado.estado_id == cidade.estado_id) 
                {
                    indice = i;
                    break;
                }
                cbEstado.SelectedIndex = indice;
            } 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cidade.nome = edtNome.Text;
            Estado estado = (Estado) cbEstado.SelectedItem;
            cidade.estado_id = estado.estado_id;
            bool realizou = CidadeDB.setAlteraCidade(conexao, cidade);

            if (realizou)
            {
                MessageBox.Show("Cidade cadastrada com sucesso.");
                Close();
            } else
            {
                MessageBox.Show("Erro ao cadastrar cidade.");
            }
        }
    }
}
