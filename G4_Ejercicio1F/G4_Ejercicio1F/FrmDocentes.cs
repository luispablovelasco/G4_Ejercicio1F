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
        public FrmDocentes()
        {
            InitializeComponent();
        }

        private void FrmDocentes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
