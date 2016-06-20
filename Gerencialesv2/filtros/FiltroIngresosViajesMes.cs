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
    public partial class FiltroIngresosViajesMes: Form
    {
        public frmPrincipal principal;
        public FiltroIngresosViajesMes()
        {
            InitializeComponent();
            fechaIni.CustomFormat = "yyyy-MM-dd";
            fechaFin.CustomFormat = "yyyy-MM-dd";
            DateTime x = DateTime.Now;
            int dia = x.Day;
            int mes = x.Month;
            int ano = x.Year;
            ffinTxt.Text = ano + "-" + mes + "-" + dia;
            finiTxt.Text = ano + "-" + mes + "-" + dia;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fechaIni.Value < fechaFin.Value)
            {
                this.Hide();
                reportes.frmIngresosTotalesViajesMes rpt = new reportes.frmIngresosTotalesViajesMes();
                principal.crearR5(Convert.ToDateTime(fechaIni.Text), Convert.ToDateTime(fechaFin.Text), rpt);
            }
            else
                MessageBox.Show("Fecha Inicio es Mayo a Fecha Final","Error");
        }

        private void FiltroIngresosViajes_Load(object sender, EventArgs e)
        {

        }
        private void fechaFin_ValueChanged(object sender, EventArgs e)
        {

            ffinTxt.Text = fechaFin.Text;
        }

        private void fechaIni_ValueChanged(object sender, EventArgs e)
        {

            finiTxt.Text = fechaIni.Text;
        }

    }
}
