﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaAlumnos
{
    public class AdministraAlumnos
    {
        private Dictionary<long, Alumno> dicAlumnos = new Dictionary<long, Alumno>(); // Directori para guardar Alumno
        private static long numControl = 1; // Variable para el cálculo del número de control

        /// <summary>
        /// Método para guardar los alumnos
        /// </summary>
        /// <param name="numControl">Número de Control</param>
        /// <param name="nombre">Nombre del alumno</param>
        /// <param name="domicilio">Domicilio del alumno</param>
        /// <param name="carrera">Carrera del alumno</param>
        /// <param name="edad">Edad del alumno</param>
        /// <returns></returns>
         public bool AgregaAlumno(long numControl, string nombre, string domicilio, long carrera, int edad)
        {
            try
            {
                Alumno alumno = new Alumno(nombre, domicilio, carrera, edad);
                dicAlumnos.Add(numControl, alumno);
                AdministraAlumnos.numControl++;
                return true;
            }catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        /// <summary>
        /// Método para calcular el número de control.
        /// </summary>
        /// <returns>Número de control</returns>
        public string CalculaNumControl()
        {
            int año = DateTime.Now.Year;
            string numeroControl = año.ToString().Substring(2, 2) + "17" + numControl.ToString("D4");
            return numeroControl;
        }

        #region Consultas
        /// <summary>
        /// Método que devuelve todas las claves de los alumnos dados de alta.
        /// </summary>
        /// <returns>Arreglo de las claves de alumnos.</returns>
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
        /// Método que guarda los alumnos que ha sido dados de alta en una matriz.
        /// </summary>
        /// <returns>Matriz de string con los datos de los alumnos.</returns>
        public string[,] ConsultaAlumnos(AdministraCarreras carr)
        {
            long[] claves = ClavesAlumnos();
            string[,] alumnos = new string[claves.Length, 5];
            for(int i = 0; i < claves.Length; i++)
            {
                Alumno a = dicAlumnos[claves[i]];
                alumnos[i, 0] = claves[i].ToString();
                alumnos[i, 1] = a.pNombre;
                alumnos[i, 2] = carr.NombreCarrera(a.pCarrera);
                alumnos[i, 3] = a.pDomicilio;
                alumnos[i, 4] = a.pEdad.ToString();
            }
            return alumnos;
        }

        /// <summary>
        /// Método que devuelve todas las calves y nombres de los alumnos.
        /// </summary>
        /// <returns>Arreglo string con claves y nombres.</returns>
        public string[] ClavesNombres()
        {
            string[] datos = new string[dicAlumnos.Count * 2];
            int i = 0;
            foreach(KeyValuePair<long,Alumno> item in dicAlumnos)
            {
                datos[i] = item.Key.ToString();
                i++;
                datos[i] = item.Value.pNombre;
                i++;
            }
            return datos;
        }

        /// <summary>
        /// Método que devuelve los datos del alumno por su nombre.
        /// </summary>
        /// <param name="nombre">Nombre del alumno.</param>
        /// <param name="a">Objeto AdministraCarreras para saber nombre de la carrera.</param>
        /// <returns>Datos del alumno.</returns>
        public string[] DatosAlumnoNombre(string nombre, AdministraCarreras a)
        {
            string[] alumno = new string[5];
            foreach (KeyValuePair<long, Alumno> item in dicAlumnos)
            {
                if (item.Value.pNombre == nombre)
                {
                    alumno[0] = item.Key.ToString();
                    alumno[1] = item.Value.pNombre;
                    alumno[2] = a.NombreCarrera(item.Value.pCarrera);
                    alumno[3] = item.Value.pDomicilio;
                    alumno[4] = item.Value.pEdad.ToString();
                }
            }
            return alumno;
        }

        /// <summary>
        /// Devuelve alumno por su clave.
        /// </summary>
        /// <param name="clave">Clave del alumno.</param>
        /// <returns>Alumno.</returns>
        public Alumno AlumnoClave(long clave) => dicAlumnos[clave];

        /// <summary>
        /// Devuelve true en caso de estar la clave del alumno.
        /// </summary>
        /// <param name="clave">Clave del alumno.</param>
        /// <returns>true = esta.</returns>
        public bool EstaClave(long clave)
        {
            if (dicAlumnos.ContainsKey(clave))
            {
                return true;
            }
            return false;
        }
        #endregion

        /// <summary>
        /// Propiedad que devuelve true en caso de haber alumnos agregados.
        /// </summary>
        public bool pHayAlumnos
        {
            get
            {
                if (dicAlumnos.Count == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
