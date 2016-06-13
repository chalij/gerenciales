using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gerencialesv2.reportes
{
    public partial class frmIngresoNeto : Form
    {
        public frmIngresoNeto()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frmIngresoNeto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDGerencialDataSet2.movimiento_diario' Puede moverla o quitarla según sea necesario.
            this.movimiento_diarioTableAdapter.Fill(this.bDGerencialDataSet2.movimiento_diario);

        }

    }
}
