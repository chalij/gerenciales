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
    public partial class FiltroCostoBeneficio: Form
    {
        public frmPrincipal principal;
        Conexion con = new Conexion();
        public FiltroCostoBeneficio()
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
            Dictionary<string, string> test = con.ListaTabla("select id_propietario,nombre_empresario from propietario");
            emp.DataSource = new BindingSource(test, null);
            emp.DisplayMember = "Value";
            emp.ValueMember = "Key";
            string value = ((KeyValuePair<string, string>)emp.SelectedItem).Value;
            emp.SelectedItem = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fechaIni.Value < fechaFin.Value)
            {
                this.Hide();
                reportes.frmcostoBeneficio rpt = new reportes.frmcostoBeneficio();
                string value = ((KeyValuePair<string, string>)emp.SelectedItem).Value;
                principal.crearR3(Convert.ToDateTime(fechaIni.Text), Convert.ToDateTime(fechaFin.Text), rpt, int.Parse(emp.SelectedValue + ""), value);
            }
            else
                MessageBox.Show("Fecha Inicio es Mayo a Fecha Final","Error");
        }

    }
}
