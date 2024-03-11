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
    public partial class FrmRelCidade : Form
    {
        NpgsqlConnection conexao = null;
        public FrmRelCidade(NpgsqlConnection conexao)
        {
            this.conexao = conexao;
            InitializeComponent();
        }

        private void FrmRelCidade_Load(object sender, EventArgs e)
        {
            List<Cidade> lista = CidadeDB.getCidades(conexao);
            cidadeBindingSource.DataSource = lista;
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.RefreshReport();
        }
    }
}
