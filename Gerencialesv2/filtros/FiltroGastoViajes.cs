using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gerencialesv2.filtros
{
    public partial class FiltroGastoViajes: Form
    {
        public frmPrincipal principal;
        public FiltroGastoViajes()
        {
            InitializeComponent();
            fechaIni.CustomFormat = "yyyy-MM-dd";
            fechaFin.CustomFormat = "yyyy-MM-dd";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fechaIni.Value < fechaFin.Value)
            {
                this.Hide();
                reportes.frmGastosTotalesViajes rpt = new reportes.frmGastosTotalesViajes();
                principal.crearR4(Convert.ToDateTime(fechaIni.Text), Convert.ToDateTime(fechaFin.Text), rpt);
            }
            else
                MessageBox.Show("Fecha Inicio es Mayo a Fecha Final","Error");
        }

    }
}
