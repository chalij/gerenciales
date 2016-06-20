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
        Conexion con;
        public frmPrincipal principal;

        public mtUser()
        {
            InitializeComponent();
            con = new Conexion();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (con.ifEncryp(passwordTextBox.Text))
            {
                this.usuarioBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDGerencialDataSet);
            }
            else
            {
                if (con.validarClave(passwordTextBox.Text))
                {
                    this.passwordTextBox.Text = con.encriptar(this.passwordTextBox.Text);
                    this.usuarioBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bDGerencialDataSet);
                    MessageBox.Show("Se guardo con exito", "Guardado");
                }
                else
                    MessageBox.Show("La clave de ser como minimo de longitud de 10 caracteres, con al menos un numero, una mayuscula, y 3 minusculas","Clave debil");
            }

        }

        private void mtUser_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDGerencialDataSet2.rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.bDGerencialDataSet2.rol);
            // TODO: esta línea de código carga datos en la tabla 'bDGerencialDataSet.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.bDGerencialDataSet.usuario);


            Dictionary<string, string> test = con.ListaUsuarios();
            rol.DataSource = new BindingSource(test, null);
            rol.DisplayMember = "Value";
            rol.ValueMember = "Key";
            string value = ((KeyValuePair<string, string>)rol.SelectedItem).Value;
            rol.SelectedValue = id_rolTextBox.Text;

        }

        private void rol_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.id_rolTextBox.Text = rol.SelectedValue + "";
            string value = ((KeyValuePair<string, string>)rol.SelectedItem).Value;
        }

        private void id_rolTextBox_TextChanged(object sender, EventArgs e)
        {
            rol.SelectedValue = id_rolTextBox.Text;
        }

        private void rol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void id_usuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

