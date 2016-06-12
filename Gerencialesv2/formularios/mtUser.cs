using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gerencialesv2.formularios
{
    public partial class mtUser : Form
    {
        public mtUser()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDGerencialDataSet);

        }

        private void mtUser_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDGerencialDataSet.rol' Puede moverla o quitarla según sea necesario.
           // this.rolTableAdapter.Fill(this.bDGerencialDataSet.rol);
            // TODO: esta línea de código carga datos en la tabla 'bDGerencialDataSet.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.bDGerencialDataSet.usuario);

        }

    }
}
