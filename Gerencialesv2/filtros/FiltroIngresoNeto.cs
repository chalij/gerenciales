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
    public partial class FiltroIngresoNeto : Form
    {
        public frmPrincipal principal;
        public FiltroIngresoNeto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fechaIni.Value < fechaFin.Value)
            {
                this.Hide();
                reportes.frmIngresoNeto rpt = new reportes.frmIngresoNeto();
                principal.crearR2(Convert.ToDateTime(fechaIni.Text), Convert.ToDateTime(fechaFin.Text), rpt);
            }
            else
                MessageBox.Show("Fecha Inicio es Mayo a Fecha Final","Error");
        }

        private void FiltroGastosAdmin_Load(object sender, EventArgs e)
        {

        }

    }
}
