using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaAlumnos
{
    /// <summary>
    /// Clase para la administración de los objetos
    /// de tipo Carrera
    /// </summary>
    class AdministraCarreras
    {
        private List<Carrera> lCarreras = new List<Carrera>();

        /// <summary>
        /// Método que guarda las carreras dadas de alta
        /// </summary>
        /// <param name="clave">Clave de Carrera</param>
        /// <param name="nombre">Nombre de Carrera</param>
        /// <param name="estatus">Estatus de la Carrera</param>
        /// <returns></returns>
        public bool AgregaCarrera(long clave, string nombre, string estatus)
        {
            Carrera c = new Carrera(clave, nombre, estatus);
            if (lCarreras.Contains(c)){
                return false;
            }
            else
            {
                lCarreras.Add(c);
                return true;
            }
        }
    }
}
