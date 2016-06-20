using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Collections;


namespace Gerencialesv2
{
    public partial class frmPrincipal : Form
    {
        public String userName;
        public String pasword;
        public frmLogin login;
        Conexion conn;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Se crea conexion;
            conn = new Conexion();
            conn.login = login;
            conn.principal = this;
            //Se manda el menu y el id de usario
            conn.CrearMenu(menuStrip1,userName,pasword);

        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
            //MessageBox.Show("chali", "FormClosing Event");
        }
        public void crearR1(DateTime fechaini, DateTime fechafin, reportes.frmcostosAdmin rpt,int empres,String nempre)
        {
            //reportes.frmcostosAdmin rpt = new reportes.frmcostosAdmin();
            reportes.costosAdmin ca = new reportes.costosAdmin();
            ca.SetParameterValue("fechaini", fechaini);
            ca.SetParameterValue("fechafin", fechafin);
            ca.SetParameterValue("user", userName);
            ca.SetParameterValue("empres", empres);
            ca.SetParameterValue("nempre", nempre);
            rpt.crystalReportViewer1.ReportSource=ca;
           // rpt.Parent = this;
           // this.Hide();
            rpt.Refresh();
            rpt.Show();
        }
        public void crearR2(DateTime fechaini, DateTime fechafin, reportes.frmIngresoNeto rpt, int empres, String nempre)
        {
            //reportes.frmcostosAdmin rpt = new reportes.frmcostosAdmin();
            reportes.ingresoNeto ca = new reportes.ingresoNeto();
            ca.SetParameterValue("fechaini", fechaini);
            ca.SetParameterValue("fechafin", fechafin);
            ca.SetParameterValue("user", userName);
            ca.SetParameterValue("empres", empres);
            ca.SetParameterValue("nempre", nempre);
            rpt.crystalReportViewer1.ReportSource = ca;
            // rpt.Parent = this;
            // this.Hide();
            rpt.ShowDialog();
        }
        public void crearR3(DateTime fechaini, DateTime fechafin, reportes.frmcostoBeneficio rpt,int empres,String nempre)
        {
            //reportes.frmcostosAdmin rpt = new reportes.frmcostosAdmin();
            reportes.costoBeneficio ca = new reportes.costoBeneficio();
            ca.SetParameterValue("fechaini", fechaini);
            ca.SetParameterValue("fechafin", fechafin);
            ca.SetParameterValue("user", userName);
            ca.SetParameterValue("empres", empres);
            ca.SetParameterValue("nempre", nempre);
            rpt.crystalReportViewer1.ReportSource = ca;
            // rpt.Parent = this;
            // this.Hide();
            rpt.Show();
        }
        public void crearR4(DateTime fechaini, DateTime fechafin, reportes.frmGastosTotalesViajes rpt, int empres, String nempre)
        {
            //reportes.frmcostosAdmin rpt = new reportes.frmcostosAdmin();
            reportes.gastosTotalesViajes ca = new reportes.gastosTotalesViajes();
            ca.SetParameterValue("fechaini", fechaini);
            ca.SetParameterValue("fechafin", fechafin);
            ca.SetParameterValue("user", userName);
            ca.SetParameterValue("empres", empres);
            ca.SetParameterValue("nempre", nempre);
            rpt.crystalReportViewer1.ReportSource = ca;
            // rpt.Parent = this;
            // this.Hide();
            rpt.Show();
        }
        public void crearR5(DateTime fechaini, DateTime fechafin, reportes.frmIngresosTotalesViajesMes rpt)
        {
            //reportes.frmcostosAdmin rpt = new reportes.frmcostosAdmin();
            reportes.ingresoTotalesViajesMes ca = new reportes.ingresoTotalesViajesMes();
            ca.SetParameterValue("fechaini", fechaini);
            ca.SetParameterValue("fechafin", fechafin);
            ca.SetParameterValue("user", userName);
            rpt.crystalReportViewer1.ReportSource = ca;
            // rpt.Parent = this;
            // this.Hide();
            rpt.Show();
        }
        public void crearRT1(DateTime fechaini, DateTime fechafin, reportes.frmIngresosTotalesViajes rpt, int empres, String nempre)
        {
            //reportes.frmcostosAdmin rpt = new reportes.frmcostosAdmin();
            reportes.ingresoTotalesViajes ca = new reportes.ingresoTotalesViajes();
            ca.SetParameterValue("fechaini", fechaini);
            ca.SetParameterValue("fechafin", fechafin);
            ca.SetParameterValue("user", userName);
            ca.SetParameterValue("empres", empres);
            ca.SetParameterValue("nempre", nempre);
            rpt.crystalReportViewer1.ReportSource = ca;
            // rpt.Parent = this;
            // this.Hide();
            rpt.Show();
        }
        public void crearRT2(reportes.frmGastosTotalesViajesSF rpt, int empres, String nempre)
        {
            //reportes.frmcostosAdmin rpt = new reportes.frmcostosAdmin();
            reportes.gastosTotalesViajesSF ca = new reportes.gastosTotalesViajesSF();
            ca.SetParameterValue("user", userName);
            ca.SetParameterValue("empres", empres);
            ca.SetParameterValue("nempre", nempre);
            rpt.crystalReportViewer1.ReportSource = ca;
            // rpt.Parent = this;
            // this.Hide();
            rpt.Show();
        }
        public void crearRT3(DateTime fechaini, DateTime fechafin, reportes.frmUsuarioUnidad rpt, int empres, String nempre)
        {
            //reportes.frmcostosAdmin rpt = new reportes.frmcostosAdmin();
            reportes.usuarioUnidad ca = new reportes.usuarioUnidad();
            ca.SetParameterValue("fechaini", fechaini);
            ca.SetParameterValue("fechafin", fechafin);
            ca.SetParameterValue("user", userName);
            ca.SetParameterValue("empres", empres);
            ca.SetParameterValue("nempre", nempre);
            rpt.crystalReportViewer1.ReportSource = ca;
            // rpt.Parent = this;
            // this.Hide();
            rpt.Show();
        }
        public void crearRT4(DateTime fechaini, DateTime fechafin, reportes.frmUsuarioViaje rpt, int empres, String nempre)
        {
            //reportes.frmcostosAdmin rpt = new reportes.frmcostosAdmin();
            reportes.usuarioViaje ca = new reportes.usuarioViaje();
            ca.SetParameterValue("fechaini", fechaini);
            ca.SetParameterValue("fechafin", fechafin);
            ca.SetParameterValue("user", userName);
            ca.SetParameterValue("empres", empres);
            ca.SetParameterValue("nempre", nempre);
            rpt.crystalReportViewer1.ReportSource = ca;
            // rpt.Parent = this;
            // this.Hide();
            rpt.Show();
        }
        public void crearRT5(DateTime fechaini, DateTime fechafin, reportes.frmcostosCombustible rpt, int empres, String nempre)
        {
            //reportes.frmcostosAdmin rpt = new reportes.frmcostosAdmin();
            reportes.costosCombustible ca = new reportes.costosCombustible();
            ca.SetParameterValue("fechaini", fechaini);
            ca.SetParameterValue("fechafin", fechafin);
            ca.SetParameterValue("user", userName);
            ca.SetParameterValue("empres", empres);
            ca.SetParameterValue("nempre", nempre);
            rpt.crystalReportViewer1.ReportSource = ca;
            // rpt.Parent = this;
            // this.Hide();
            rpt.Show();
        }
        public void crearRT6(DateTime fechaini, DateTime fechafin, reportes.frmComparativoIngresos rpt,int empres,String nempre)
        {
            //reportes.frmcostosAdmin rpt = new reportes.frmcostosAdmin();
            reportes.compartivoIngresoUsuario ca = new reportes.compartivoIngresoUsuario();
            ca.SetParameterValue("fechaini", fechaini);
            ca.SetParameterValue("fechafin", fechafin);
            ca.SetParameterValue("user", userName);
            ca.SetParameterValue("empres", empres);
            ca.SetParameterValue("nempre", nempre);
            rpt.crystalReportViewer1.ReportSource = ca;
            // rpt.Parent = this;
            // this.Hide();
            rpt.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*private void usuarios(object sender, EventArgs e)
        {
            mtUser user = new mtUser();
            user.show();
        }*/
    }
}
