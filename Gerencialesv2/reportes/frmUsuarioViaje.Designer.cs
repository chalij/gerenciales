namespace Gerencialesv2.reportes
{
    partial class frmUsuarioViaje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.usuarioViaje1 = new Gerencialesv2.reportes.usuarioViaje();
            this.ingresoNeto1 = new Gerencialesv2.reportes.ingresoNeto();
            this.bDGerencialDataSet2 = new Gerencialesv2.BDGerencialDataSet2();
            this.movimientodiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movimiento_diarioTableAdapter = new Gerencialesv2.BDGerencialDataSet2TableAdapters.movimiento_diarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bDGerencialDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimientodiarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.AllowDrop = true;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.usuarioViaje1;
            this.crystalReportViewer1.ReuseParameterValuesOnRefresh = true;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1124, 610);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // bDGerencialDataSet2
            // 
            this.bDGerencialDataSet2.DataSetName = "BDGerencialDataSet2";
            this.bDGerencialDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movimientodiarioBindingSource
            // 
            this.movimientodiarioBindingSource.DataMember = "movimiento_diario";
            this.movimientodiarioBindingSource.DataSource = this.bDGerencialDataSet2;
            // 
            // movimiento_diarioTableAdapter
            // 
            this.movimiento_diarioTableAdapter.ClearBeforeFill = true;
            // 
            // frmUsuarioViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 610);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frmUsuarioViaje";
            this.Text = "Usuarios por Viaje";
            this.Load += new System.EventHandler(this.frmIngresoNeto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDGerencialDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimientodiarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private ingresoNeto ingresoNeto1;
        private BDGerencialDataSet2 bDGerencialDataSet2;
        private System.Windows.Forms.BindingSource movimientodiarioBindingSource;
        private BDGerencialDataSet2TableAdapters.movimiento_diarioTableAdapter movimiento_diarioTableAdapter;
        private usuarioViaje usuarioViaje1;
    }
}