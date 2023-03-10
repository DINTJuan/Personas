using Personas.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas.Servicios
{
    class NavegacionServicio
    {
        private ListaPersonasUserControl listaPUC;
        public NavegacionServicio()
        {
            listaPUC = new ListaPersonasUserControl();
        }

        public bool? AbrirNacionalidad()
        {
            AñadirNacionalidad nc = new AñadirNacionalidad();
            return nc.ShowDialog();
        }

        public UserControl AbrirNuevaPersona()
        {
            return new NuevaPersonaUserControl();
        }

        public UserControl AbrirListaPersona()
        {
            return listaPUC;
        }

    }
}
