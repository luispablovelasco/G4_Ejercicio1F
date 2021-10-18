using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace G4_Ejercicio1F
{
    public partial class FrmMenu : G4_Ejercicio1F.Form1
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEstudiante estudiante = new FrmEstudiante();
            this.Hide();
            estudiante.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDocentes docente = new FrmDocentes();
            this.Hide();
            docente.Show();
        }
    }
}
