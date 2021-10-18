using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace G4_Ejercicio1F
{
    public partial class FrmBase : G4_Ejercicio1F.Form1
    {

        //Creamos un indice para el DGV
        public int edit_indice = -1;

        //Este metodo actualizara el DGV con la lista Estudiantes
        /*private void ActualzarGridEstudiantes()
        {
            Dgvdatos.DataSource = null;
            Dgvdatos.DataSource = Estudiantes; 
        }
        
        */

        //Hacemos un metodo para limpiar los campos de ambos Forms
        //Para limpiar el formulario Estudaites
        public void LimpiarEdu()
        {
            txtcodigo.Clear();
            txtnombre.Clear();
            txtusuario.Clear();
            txtnombre.Focus();
        }

        public FrmBase()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*private void dgvdatos_DoubleClick(object sender, EventArgs e)
        {
            

        }*/

        private void FrmBase_Load(object sender, EventArgs e)
        {

        }
    }
}
