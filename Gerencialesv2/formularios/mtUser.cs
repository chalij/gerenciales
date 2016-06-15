using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Collections;

namespace Gerencialesv2.formularios
{

    public partial class mtUser : Form
    {
        private String server;
        private String serverT;
        private OdbcConnection DbConnection;

        public mtUser()
        {
            server = "Dsn=bdgerencial";
            serverT = "Dsn=administracion";
            DbConnection = new OdbcConnection(server);
            InitializeComponent();
            try
            {
                DbConnection.Open();
                DataSet data = new DataSet();
                OdbcDataAdapter adapter = new OdbcDataAdapter();
                OdbcCommandBuilder builer = new OdbcCommandBuilder(adapter);
                adapter.SelectCommand = new OdbcCommand(
                                         "SELECT * FROM usuario",
                                         DbConnection);
                adapter.Fill(data);
                tUsuarios.DataSource = data;


            }
            catch (Exception e) { }
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDGerencialDataSet);

        }

        private void mtUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDGerencialDataSet2.rol' table. You can move, or remove it, as needed.
            this.rolTableAdapter.Fill(this.bDGerencialDataSet2.rol);
            // TODO: esta línea de código carga datos en la tabla 'bDGerencialDataSet.rol' Puede moverla o quitarla según sea necesario.
            // this.rolTableAdapter.Fill(this.bDGerencialDataSet.rol);
            // TODO: esta línea de código carga datos en la tabla 'bDGerencialDataSet.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.bDGerencialDataSet.usuario);

        }

        private void id_rolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // BindingNavigatorAddNewItem.PerformClick();
        }

        private void EditarB_Click(object sender, EventArgs e)
        {


            //DataBindingNavidatorSaveItem.PerfomClick();

        }

        private void eliminarB_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.PerformClick();
            //MsgBox("Datos eliminados");
        }
    }
}

