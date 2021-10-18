namespace G4_Ejercicio1F
{
    partial class FrmEstudiante
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.DgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "REGISTRO ESTUDIANTES";
            // 
            // DgvEstudiantes
            // 
            this.DgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEstudiantes.Location = new System.Drawing.Point(12, 213);
            this.DgvEstudiantes.Name = "DgvEstudiantes";
            this.DgvEstudiantes.Size = new System.Drawing.Size(601, 125);
            this.DgvEstudiantes.TabIndex = 9;
            this.DgvEstudiantes.DoubleClick += new System.EventHandler(this.DgvEstudiantes_DoubleClick);
            // 
            // FrmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(625, 350);
            this.Controls.Add(this.DgvEstudiantes);
            this.Controls.Add(this.label4);
            this.Name = "FrmEstudiante";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEstudiante_FormClosed);
            this.Load += new System.EventHandler(this.FrmEstudiante_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnlimpiar, 0);
            this.Controls.SetChildIndex(this.btnmodificar, 0);
            this.Controls.SetChildIndex(this.btnguardar, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.DgvEstudiantes, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DgvEstudiantes;
    }
}
