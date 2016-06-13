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
    public partial class FiltroGastoViajesSF: Form
    {
        public frmPrincipal principal;
        public FiltroGastoViajesSF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            reportes.frmGastosTotalesViajesSF rpt = new reportes.frmGastosTotalesViajesSF();
            principal.crearRT2(rpt);
        }

    }
}
