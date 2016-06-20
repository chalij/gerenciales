namespace Gerencialesv2.filtros
{
    partial class FiltroComparativoIngresos
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
            this.button1 = new System.Windows.Forms.Button();
            this.fechaIni = new System.Windows.Forms.DateTimePicker();
            this.fechaFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emp = new System.Windows.Forms.ComboBox();
            this.finitxt = new System.Windows.Forms.TextBox();
            this.ffintxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Procesar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fechaIni
            // 
            this.fechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaIni.Location = new System.Drawing.Point(152, 64);
            this.fechaIni.Name = "fechaIni";
            this.fechaIni.Size = new System.Drawing.Size(18, 20);
            this.fechaIni.TabIndex = 1;
            // 
            // fechaFin
            // 
            this.fechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaFin.Location = new System.Drawing.Point(307, 64);
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.Size = new System.Drawing.Size(16, 20);
            this.fechaFin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Comparativo de Ingresos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Empresario";
            // 
            // emp
            // 
            this.emp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emp.FormattingEnabled = true;
            this.emp.Location = new System.Drawing.Point(152, 120);
            this.emp.Name = "emp";
            this.emp.Size = new System.Drawing.Size(121, 21);
            this.emp.TabIndex = 7;
            // 
            // finitxt
            // 
            this.finitxt.Enabled = false;
            this.finitxt.Location = new System.Drawing.Point(49, 64);
            this.finitxt.Name = "finitxt";
            this.finitxt.Size = new System.Drawing.Size(100, 20);
            this.finitxt.TabIndex = 8;
            // 
            // ffintxt
            // 
            this.ffintxt.Enabled = false;
            this.ffintxt.Location = new System.Drawing.Point(204, 64);
            this.ffintxt.Name = "ffintxt";
            this.ffintxt.Size = new System.Drawing.Size(100, 20);
            this.ffintxt.TabIndex = 9;
            // 
            // FiltroComparativoIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 197);
            this.Controls.Add(this.ffintxt);
            this.Controls.Add(this.finitxt);
            this.Controls.Add(this.emp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechaFin);
            this.Controls.Add(this.fechaIni);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "FiltroComparativoIngresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comparativo de Ingresos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FiltroGastosAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker fechaIni;
        private System.Windows.Forms.DateTimePicker fechaFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox emp;
        private System.Windows.Forms.TextBox finitxt;
        private System.Windows.Forms.TextBox ffintxt;
    }
}