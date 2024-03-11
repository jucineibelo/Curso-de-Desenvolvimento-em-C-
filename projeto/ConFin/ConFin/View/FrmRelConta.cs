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
    public partial class FrmRelConta : Form
    {
        NpgsqlConnection conexao = null;
        public FrmRelConta(NpgsqlConnection conexao)
        {
            this.conexao = conexao;
            InitializeComponent();
        }

        private void FrmRelConta_Load(object sender, EventArgs e)
        {
            List<Conta> lista = ContaDB.getContas(conexao);
            contaBindingSource.DataSource = lista;
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.RefreshReport();
        }
    }
}
