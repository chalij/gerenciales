﻿using System;
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
        public void crearR1(DateTime fechaini, DateTime fechafin, reportes.frmcostosAdmin rpt)
        {
            //reportes.frmcostosAdmin rpt = new reportes.frmcostosAdmin();
            reportes.costosAdmin ca = new reportes.costosAdmin();
            ca.SetParameterValue("fechaini", fechaini);
            ca.SetParameterValue("fechafin", fechafin);
            ca.SetParameterValue("user", userName);
            rpt.crystalReportViewer1.ReportSource=ca;
           // rpt.Parent = this;
           // this.Hide();
            rpt.Refresh();
            rpt.Show();
        }
        public void crearR2(DateTime fechaini, DateTime fechafin, reportes.frmIngresoNeto rpt)
        {
            //reportes.frmcostosAdmin rpt = new reportes.frmcostosAdmin();
            reportes.ingresoNeto ca = new reportes.ingresoNeto();
            ca.SetParameterValue("fechaini", fechaini);
            ca.SetParameterValue("fechafin", fechafin);
            ca.SetParameterValue("user", userName);
            rpt.crystalReportViewer1.ReportSource = ca;
            // rpt.Parent = this;
            // this.Hide();
            rpt.ShowDialog();
        }
        public void crearR3(DateTime fechaini, DateTime fechafin, reportes.frmcostoBeneficio rpt)
        {
            //reportes.frmcostosAdmin rpt = new reportes.frmcostosAdmin();
            reportes.costoBeneficio ca = new reportes.costoBeneficio();
            ca.SetParameterValue("fechaini", fechaini);
            ca.SetParameterValue("fechafin", fechafin);
            ca.SetParameterValue("user", userName);
            rpt.crystalReportViewer1.ReportSource = ca;
            // rpt.Parent = this;
            // this.Hide();
            rpt.Show();
        }
        public void crearR4(DateTime fechaini, DateTime fechafin, reportes.frmGastosTotalesViajes rpt)
        {
            //reportes.frmcostosAdmin rpt = new reportes.frmcostosAdmin();
            reportes.gastosTotalesViajes ca = new reportes.gastosTotalesViajes();
            ca.SetParameterValue("fechaini", fechaini);
            ca.SetParameterValue("fechafin", fechafin);
            ca.SetParameterValue("user", userName);
            rpt.crystalReportViewer1.ReportSource = ca;
            // rpt.Parent = this;
            // this.Hide();
            rpt.Show();
        }
        public void crearR5(DateTime fechaini, DateTime fechafin, reportes.frmGastosTotalesViajes rpt)
        {
            //reportes.frmcostosAdmin rpt = new reportes.frmcostosAdmin();
            reportes.gastosTotalesViajes ca = new reportes.gastosTotalesViajes();
            ca.SetParameterValue("fechaini", fechaini);
            ca.SetParameterValue("fechafin", fechafin);
            ca.SetParameterValue("user", userName);
            rpt.crystalReportViewer1.ReportSource = ca;
            // rpt.Parent = this;
            // this.Hide();
            rpt.Show();
        }
        public void crearRT1(DateTime fechaini, DateTime fechafin, reportes.frmIngresosTotalesViajes rpt)
        {
            //reportes.frmcostosAdmin rpt = new reportes.frmcostosAdmin();
            reportes.ingresoTotalesViajes ca = new reportes.ingresoTotalesViajes();
            ca.SetParameterValue("fechaini", fechaini);
            ca.SetParameterValue("fechafin", fechafin);
            ca.SetParameterValue("user", userName);
            rpt.crystalReportViewer1.ReportSource = ca;
            // rpt.Parent = this;
            // this.Hide();
            rpt.Show();
        }
        public void crearRT2(reportes.frmGastosTotalesViajesSF rpt)
        {
            //reportes.frmcostosAdmin rpt = new reportes.frmcostosAdmin();
            reportes.gastosTotalesViajesSF ca = new reportes.gastosTotalesViajesSF();
            ca.SetParameterValue("user", userName);
            rpt.crystalReportViewer1.ReportSource = ca;
            // rpt.Parent = this;
            // this.Hide();
            rpt.Show();
        }
        public void crearRT3(DateTime fechaini, DateTime fechafin, reportes.frmUsuarioUnidad rpt)
        {
            //reportes.frmcostosAdmin rpt = new reportes.frmcostosAdmin();
            reportes.usuarioUnidad ca = new reportes.usuarioUnidad();
            ca.SetParameterValue("fechaini", fechaini);
            ca.SetParameterValue("fechafin", fechafin);
            ca.SetParameterValue("user", userName);
            rpt.crystalReportViewer1.ReportSource = ca;
            // rpt.Parent = this;
            // this.Hide();
            rpt.Show();
        }
        public void crearRT4(DateTime fechaini, DateTime fechafin, reportes.frmUsuarioViaje rpt)
        {
            //reportes.frmcostosAdmin rpt = new reportes.frmcostosAdmin();
            reportes.usuarioViaje ca = new reportes.usuarioViaje();
            ca.SetParameterValue("fechaini", fechaini);
            ca.SetParameterValue("fechafin", fechafin);
            ca.SetParameterValue("user", userName);
            rpt.crystalReportViewer1.ReportSource = ca;
            // rpt.Parent = this;
            // this.Hide();
            rpt.Show();
        }
        public void crearRT5(DateTime fechaini, DateTime fechafin, reportes.frmcostosCombustible rpt)
        {
            //reportes.frmcostosAdmin rpt = new reportes.frmcostosAdmin();
            reportes.costosCombustible ca = new reportes.costosCombustible();
            ca.SetParameterValue("fechaini", fechaini);
            ca.SetParameterValue("fechafin", fechafin);
            ca.SetParameterValue("user", userName);
            rpt.crystalReportViewer1.ReportSource = ca;
            // rpt.Parent = this;
            // this.Hide();
            rpt.Show();
        }
        public void crearRT6(DateTime fechaini, DateTime fechafin, reportes.frmComparativoIngresos rpt)
        {
            //reportes.frmcostosAdmin rpt = new reportes.frmcostosAdmin();
            reportes.compartivoIngresoUsuario ca = new reportes.compartivoIngresoUsuario();
            ca.SetParameterValue("fechaini", fechaini);
            ca.SetParameterValue("fechafin", fechafin);
            ca.SetParameterValue("user", userName);
            rpt.crystalReportViewer1.ReportSource = ca;
            // rpt.Parent = this;
            // this.Hide();
            rpt.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
