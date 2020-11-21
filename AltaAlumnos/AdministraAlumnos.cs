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

        public string CalculaNumControl()
        {
            numControl++;
            int año = DateTime.Now.Year;
            string numeroControl = año.ToString().Substring(2, 2) + "17" + numControl.ToString("D4");
            return numeroControl;
        }

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
    }
}
