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
    public class AdministraCarreras
    {
        private List<Carrera> lCarreras = new List<Carrera>();

        /// <summary>
        /// Método que guarda las carreras dadas de alta
        /// </summary>
        /// <param name="clave">Clave de Carrera</param>
        /// <param name="nombre">Nombre de Carrera</param>
        /// <param name="estatus">Estatus de la Carrera</param>
        /// <returns></returns>
        public bool AgregaCarrera(long clave, string nombre, bool estatus)
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

        /// <summary>
        /// Método que Determina cuales carreras tienen el estatus activo.
        /// </summary>
        /// <returns>Arreglo de Carrera con estatus activo.</returns>
        public Carrera[] CarrerasActivas()
        {
            int activas = TotalActivas();
            Carrera[] carreras = new Carrera[activas];
            int i = 0;
            foreach(Carrera item in lCarreras)
            {
                if (item.pEstatus)
                {
                    carreras[i] = item;
                    i++;
                }
            }
            return carreras;
        }

        /// <summary>
        /// Método que determina el total de carreras activas.
        /// </summary>
        /// <returns>Total de carreras activas.</returns>
        public int TotalActivas()
        {
            int activas = 0;
            foreach (Carrera item in lCarreras)
            {
                if (item.pEstatus)
                {
                    activas++;
                }
            }
            return activas;
        }

        /// <summary>
        /// Método que devuelve todas las carreras agregadas hasta el momento.
        /// </summary>
        /// <returns>Arreglo de Carrera con todas las carreras agregadas hasta el momento.</returns>
        public Carrera[] TotalCarreras()
        {
            Carrera[] carreras = new Carrera[lCarreras.Count];
            int i = 0;
            foreach (Carrera item in lCarreras)
            {
                carreras[i] = item;
                i++;
            }
            return carreras;
        }

        #region Propiedades
        /// <summary>
        /// Propiedad que devuelve true en caso de haber carreras activas.
        /// </summary>
        public bool pHayActivas
        {
            get
            {
                if (TotalActivas() == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        /// <summary>
        /// Propiedad que devuelve true en caso de haber carreras añadidas.
        /// </summary>
        public bool pHayCarreras
        {
            get
            {
                if (lCarreras.Count == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        #endregion
    }
}
