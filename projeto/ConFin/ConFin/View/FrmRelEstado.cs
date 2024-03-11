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
    public partial class FrmRelEstado : Form
    {
        NpgsqlConnection conexao = null;
        public FrmRelEstado(NpgsqlConnection conexao)
        {
            this.conexao = conexao;
            InitializeComponent();
        }

        private void RelEstado_Load(object sender, EventArgs e)
        {
            List<Estado> lista = EstadoDB.getEstados(conexao);
            estadoBindingSource.DataSource = lista;
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
