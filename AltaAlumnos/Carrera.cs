using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaAlumnos
{
    public class Carrera
    {
        private long clave;
        private string nombre;
        private bool estatus;

        public Carrera(long clave, string nombre, bool estatus)
        {
            this.clave = clave;
            this.nombre = nombre;
            this.estatus = estatus;
        }

        #region Métodos sobreescritos
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

        /// <summary>
        /// Método sobreescrito ToString()
        /// </summary>
        /// <returns>Nombre de la carrera</returns>
        public override string ToString() => nombre;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad que obtiene clave.
        /// </summary>
        public long pClave => clave;

        /// <summary>
        /// Propiedad que obtiene nombre.
        /// </summary>
        public string pNombre => nombre;

        /// <summary>
        /// Propiedad que obtiene o establece estatus.
        /// </summary>
        public bool pEstatus
        {
            get => estatus;
            set => estatus = value;
        }
        #endregion
    }
}
