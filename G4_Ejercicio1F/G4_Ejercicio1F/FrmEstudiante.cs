using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace G4_Ejercicio1F
{
    public partial class FrmEstudiante : G4_Ejercicio1F.FrmBase
    {
        //Creamos la lista para guardar a los estudiantes
        private List<Estudiante> Estudiantes = new List<Estudiante>();

        //Creamos el objeto 
        Estudiante edu = new Estudiante();

        public FrmEstudiante()
        {
            InitializeComponent();
        }

        private void FrmEstudiante_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmEstudiante_Load(object sender, EventArgs e)
        {

        }
    }
}
