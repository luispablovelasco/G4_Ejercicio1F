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

        private void ActualizarEdu()
        {
            DgvEstudiantes.DataSource = null;
            DgvEstudiantes.DataSource = Estudiantes;
        }

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

        private void DgvEstudiantes_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selección = DgvEstudiantes.SelectedRows[0];
            int pos = DgvEstudiantes.Rows.IndexOf(selección);
            edit_indice = pos;


            Estudiante edu = Estudiantes[pos];

            txtnombre.Text = edu.Nombre;
            txtusuario.Text = edu.Usuario;
            txtcodigo.Text = edu.Codigo;

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            edu.Nombre = txtnombre.Text;
            edu.Usuario = txtusuario.Text;
            edu.Codigo = txtcodigo.Text;

            if (edit_indice > -1)
            {
                Estudiantes[edit_indice] = edu;
                edit_indice = -1;
            }
            else
            {
                Estudiantes.Add(edu);
            }
            ActualizarEdu();
            LimpiarEdu();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Estudiantes.Remove(edu);
            ActualizarEdu();
        }
    }
}
