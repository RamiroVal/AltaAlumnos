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

        public string pDomicilio
        {
            get
            {
                return domicilio;
            }
            set
            {
                domicilio = value;
            }
        }

        public string pCarrera
        {
            get
            {
                return carrera;
            }
            set
            {
                carrera = value;
            }
        }

        public int pEdad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }

        public string pNombre
        {
            get
            {
                return nombre;
            }
        }
    }
}
