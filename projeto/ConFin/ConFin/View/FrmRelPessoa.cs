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
    public partial class FrmRelPessoa : Form
    {
        NpgsqlConnection conexao = null;
        public FrmRelPessoa(NpgsqlConnection conexao)
        {
            this.conexao = conexao;
            InitializeComponent();
        }

        private void FrmRelPessoa_Load(object sender, EventArgs e)
        {
            List<Pessoa> lista = PessoaDB.getPessoa(conexao);
            pessoaBindingSource.DataSource = lista;
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.RefreshReport();
        }
    }
}
