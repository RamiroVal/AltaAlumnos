using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaAlumnos
{
    class Alumno
    {
        #region Atributos
        private string nombre; // Nombre del alumno.
        private string domicilio; // Domicilio del alumno.
        private string carrera; // Carrera del alumno.
        private int edad; // Edad del alumno.
        #endregion region

        /// <summary>
        /// Constructor de Alumno.
        /// </summary>
        /// <param name="nombre">Nombre del alumno.</param>
        /// <param name="domicilio">Domicilio del alumno.</param>
        /// <param name="carrera">Carrera del alumno.</param>
        /// <param name="edad">Edad del alumno.</param>
        public Alumno(string nombre, string domicilio, string carrera, int edad)
        {
            this.nombre = nombre;
            this.domicilio = domicilio;
            this.carrera = carrera;
            this.edad = edad;
        }

        #region Propiedades
        /// <summary>
        /// Propiedad que obtiene o establece domicilio.
        /// </summary>
        public string pDomicilio
        {
            get => domicilio;
            set => domicilio = value;
        }

        /// <summary>
        /// Propiedad que obtiene o establece carrera.
        /// </summary>
        public string pCarrera
        {
            get => carrera;
            set => carrera = value;
        }

        /// <summary>
        /// Porpiedad que obtiene o establece edad.
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
        #endregion
    }
}
