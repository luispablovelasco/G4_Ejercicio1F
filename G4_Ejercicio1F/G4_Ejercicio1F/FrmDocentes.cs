using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace G4_Ejercicio1F
{
    public partial class FrmDocentes : G4_Ejercicio1F.FrmBase
    {
        //Creamos la lista para guardar a los docentes
        private List<Docente> Docentes = new List<Docente>();

        //Creamos un objeto de la clase Docente
        Docente doc = new Docente();

        //Este metodo actualizara el DGV con la lista Docentes
        private void ActualizarGridDocentes()
        {
            Dgvdocentes.DataSource = null;
            Dgvdocentes.DataSource = Docentes;
        }

        private void LimpiarDoc()
        {
            txtcodigo.Clear();
            txtnombre.Clear();
            txtusuario.Clear();
            txtmateria.Clear();
            txtnombre.Focus();
        }

        public FrmDocentes()
        {
            InitializeComponent();
        }

        private void FrmDocentes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmDocentes_Load(object sender, EventArgs e)
        {

        }

        private void Dgvdocentes_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selección = Dgvdocentes.SelectedRows[0];
            int pos = Dgvdocentes.Rows.IndexOf(selección);
            edit_indice = pos;

            
                Docente doc = Docentes[pos];

                txtnombre.Text = doc.Nombre;
                txtusuario.Text = doc.Usuario;
                txtcodigo.Text = doc.Codigo;
                txtmateria.Text = doc.Materia;

            
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            

            doc.Nombre = txtnombre.Text;
            doc.Usuario = txtusuario.Text;
            doc.Codigo = txtcodigo.Text;
            doc.Materia = txtmateria.Text;

            if (edit_indice > -1)
            {
                Docentes[edit_indice] = doc;
                edit_indice = -1;
            }
            else
            {
                Docentes.Add(doc);
            }
            ActualizarGridDocentes();
            LimpiarDoc();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Docentes.Remove(doc);
            ActualizarGridDocentes();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
