using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaAlumnos
{
    class Carrera
    {
        private long clave;
        private string nombre;
        private string estatus;

        public Carrera(long clave, string nombre, string estatus)
        {
            this.clave = clave;
            this.nombre = nombre;
            this.estatus = estatus;
        }

        /// <summary>
        /// Método Equals sobreescrito, determina si un objeto es equivalente
        /// a objeto de tipo Carrera
        /// </summary>
        /// <param name="obj">Objeto a comparar</param>
        /// <returns>Retorna true si el objeto dado es equivalente</returns>
        public override bool Equals(object obj)
        {
            if(obj.GetType() == typeof(Carrera))
            {
                Carrera a = (Carrera)obj;
                if(a.pClave == pClave || a.pNombre == pNombre)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public long pClave => clave;

        public string pNombre => nombre;

        public string pEstatus
        {
            get => estatus;

            set
            {
                estatus = value;
            }
        }
    }
}
