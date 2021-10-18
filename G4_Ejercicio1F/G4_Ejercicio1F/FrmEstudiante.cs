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
        public FrmEstudiante()
        {
            InitializeComponent();
        }

        private void FrmEstudiante_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
