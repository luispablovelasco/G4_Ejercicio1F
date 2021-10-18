using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G4_Ejercicio1F
{
    abstract class Persona
    {

        string nombre;
        string usuario;
        string codigo;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
    }
}
