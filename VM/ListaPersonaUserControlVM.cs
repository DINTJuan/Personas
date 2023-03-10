using Microsoft.Toolkit.Mvvm.ComponentModel;
using Personas.Clases;
using Personas.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.VM
{
    class ListaPersonaUserControlVM : ObservableObject
    {
        private PersonaServicio personaservicio;
        private ObservableCollection<Persona> listaPersonas;

        public ObservableCollection<Persona> ListaPersonas
        {
            get { return listaPersonas; }
            set { SetProperty(ref listaPersonas, value); }
        }

        public ListaPersonaUserControlVM()
        {
            personaservicio = new PersonaServicio();
            ListaPersonas = personaservicio.SacarPersonas();
        }
    }
}
