using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gerencialesv2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            Boolean ver=con.usuarioVerificacion(usuario.Text,con.encriptar(password.Text));
            if (ver)
            {
                frmPrincipal form = new frmPrincipal();
                form.userName = usuario.Text;
                form.pasword = con.encriptar(password.Text);
                form.login = this;
                form.label1.Text = "BIENVENIDOS/AS " + usuario.Text.ToUpper();
                usuario.Text = "";
                password.Text="";
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Error en el usario o password", "Error");
            }
        }

        private void frmReporteEstrategico1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
