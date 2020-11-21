using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaAlumnos
{
    class Alumno
    {
        private string nombre;
        private string domicilio;
        private string carrera;
        private int edad;

        public Alumno(string nombre, string domicilio, string carrera, int edad)
        {
            this.nombre = nombre;
            this.domicilio = domicilio;
            this.carrera = carrera;
            this.edad = edad;
        }

        /// <summary>
        /// Propiedad que obtiene o asigna domicilio.
        /// </summary>
        public string pDomicilio
        {
            get => domicilio;
            set => domicilio = value;
        }

        /// <summary>
        /// Propiedad que obtiene o asigna carrera.
        /// </summary>
        public string pCarrera
        {
            get => carrera;
            set => carrera = value;
        }

        /// <summary>
        /// Propiedad que obtiene o asigna edad.
        /// </summary>
        public int pEdad
        {
            get => edad;
            set => edad = value;
        }

        /// <summary>
        /// Propiedad que obtiene nombre.
        /// </summary>
        public string pNombre
        {
            get => nombre;
        }
    }
}
