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
    public partial class confirmETL : Form
    {
        public confirmETL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.progressBar1.Minimum = 0;
            this.progressBar1.Maximum = 100;
            Conexion con = new Conexion();
            this.button2.Text = "Cerrar";
            this.labelETL.Text = "Iniciado..";
            this.button1.Enabled = false;
            this.button2.Enabled = false;
            this.labelETL.Refresh();
            con.ETL(this.labelETL,this.progressBar1);
            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button2.Text = "Cerrar";
            progressBar1.Value = 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        internal Conexion con { get; set; }
    }
}
