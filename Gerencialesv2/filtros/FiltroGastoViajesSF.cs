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
        Conexion con = new Conexion();
        public FiltroGastoViajesSF()
        {
            InitializeComponent();
            Dictionary<string, string> test = con.ListaTabla("select id_propietario,nombre_empresario from propietario");
            emp.DataSource = new BindingSource(test, null);
            emp.DisplayMember = "Value";
            emp.ValueMember = "Key";
            string value = ((KeyValuePair<string, string>)emp.SelectedItem).Value;
            emp.SelectedItem = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            reportes.frmGastosTotalesViajesSF rpt = new reportes.frmGastosTotalesViajesSF();
            string value = ((KeyValuePair<string, string>)emp.SelectedItem).Value;
            principal.crearRT2(rpt, int.Parse(emp.SelectedValue + ""), value);
        }

    }
}
