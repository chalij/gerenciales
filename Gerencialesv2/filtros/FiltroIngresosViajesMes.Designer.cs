namespace Gerencialesv2.filtros
{
    partial class FiltroIngresosViajesMes
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
            this.label1 = new System.Windows.Forms.Label();
            this.ffinTxt = new System.Windows.Forms.TextBox();
            this.finiTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaFin = new System.Windows.Forms.DateTimePicker();
            this.fechaIni = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresos por Viajes Mensual";
            // 
            // ffinTxt
            // 
            this.ffinTxt.Enabled = false;
            this.ffinTxt.Location = new System.Drawing.Point(209, 75);
            this.ffinTxt.Name = "ffinTxt";
            this.ffinTxt.Size = new System.Drawing.Size(100, 20);
            this.ffinTxt.TabIndex = 16;
            // 
            // finiTxt
            // 
            this.finiTxt.Enabled = false;
            this.finiTxt.Location = new System.Drawing.Point(42, 75);
            this.finiTxt.Name = "finiTxt";
            this.finiTxt.Size = new System.Drawing.Size(100, 20);
            this.finiTxt.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Desde";
            // 
            // fechaFin
            // 
            this.fechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaFin.Location = new System.Drawing.Point(315, 75);
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.Size = new System.Drawing.Size(18, 20);
            this.fechaFin.TabIndex = 12;
            this.fechaFin.ValueChanged += new System.EventHandler(this.fechaFin_ValueChanged);
            // 
            // fechaIni
            // 
            this.fechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaIni.Location = new System.Drawing.Point(148, 75);
            this.fechaIni.Name = "fechaIni";
            this.fechaIni.Size = new System.Drawing.Size(18, 20);
            this.fechaIni.TabIndex = 11;
            this.fechaIni.ValueChanged += new System.EventHandler(this.fechaIni_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Procesar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FiltroIngresosViajesMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 164);
            this.Controls.Add(this.ffinTxt);
            this.Controls.Add(this.finiTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fechaFin);
            this.Controls.Add(this.fechaIni);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FiltroIngresosViajesMes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresos por Viajes";
            this.Load += new System.EventHandler(this.FiltroIngresosViajes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ffinTxt;
        private System.Windows.Forms.TextBox finiTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaFin;
        private System.Windows.Forms.DateTimePicker fechaIni;
        private System.Windows.Forms.Button button1;
    }
}