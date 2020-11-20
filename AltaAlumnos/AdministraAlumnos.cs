using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaAlumnos
{
    public class AdministraAlumnos
    {
        private Dictionary<long, Alumno> dicAlumnos = new Dictionary<long, Alumno>();
        private static long numControl = 1;

        /// <summary>
        /// Método que guarda los objetos ded tipo Alumno en un Dictionary.
        /// </summary>
        /// <param name="numControl">Número de control del alumno.</param>
        /// <param name="nombre">Nombre del alumno.</param>
        /// <param name="domicilio">Dommicilio del alumno.</param>
        /// <param name="carrera">Carrera del alumno.</param>
        /// <param name="edad">Edad del alumno.</param>
        /// <returns>Retorna true si el alumno se guardó correctamente.</returns>
         public bool AgregaAlumno(long numControl, string nombre, string domicilio, string carrera, int edad)
        {
            try
            {
                Alumno alumno = new Alumno(nombre, domicilio, carrera, edad);
                dicAlumnos.Add(numControl, alumno);
                return true;
            }catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        /// <summary>
        /// Método que calcula el número de control.
        /// </summary>
        /// <returns>Retorna el número de control en string.</returns>
        public string CalculaNumControl()
        {
            numControl++;
            int año = DateTime.Now.Year;
            string numeroControl = año.ToString().Substring(2, 2) + "17" + numControl.ToString("D4");
            return numeroControl;
        }

        #region Datos de alumnos
        /// <summary>
        /// Método que obtiene todas las claves de los alumnos
        /// agregados hasta el momento.
        /// </summary>
        /// <returns>Retorna un arreglo long.</returns>
        private long[] ClavesAlumnos()
        {
            long[] claves = new long[dicAlumnos.Count];
            int i = 0;
            foreach(KeyValuePair<long, Alumno> item in dicAlumnos)
            {
                claves[i] = item.Key;
                i++;
            }
            return claves;
        }

        /// <summary>
        /// Método que obtiene todos los datos de los alumnos
        /// agregados hasta el momento.
        /// </summary>
        /// <returns>Retorna una matriz de string.</returns>
        public string[,] ConsultaAlumnos()
        {
            long[] claves = ClavesAlumnos();
            string[,] alumnos = new string[claves.Length, 5];
            for(int i = 0; i < claves.Length; i++)
            {
                Alumno a = dicAlumnos[claves[i]];
                alumnos[i, 0] = claves[i].ToString();
                alumnos[i, 1] = a.pNombre;
                alumnos[i, 2] = a.pCarrera;
                alumnos[i, 3] = a.pDomicilio;
                alumnos[i, 4] = a.pEdad.ToString();
            }
            return alumnos;
        }
        #endregion
    }
}
