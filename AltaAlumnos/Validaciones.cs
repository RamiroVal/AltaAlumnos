using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AltaAlumnos
{
    public class Validaciones
    {
        /// <summary>
        /// Método que determina si un campo se ha dejado vacío.
        /// </summary>
        /// <param name="cadena">Cadena a analizar.</param>
        /// <returns>true = vacía.</returns>
        public static bool ValidaBlanco(string cadena)
        {
            if (string.IsNullOrEmpty(cadena) || string.IsNullOrWhiteSpace(cadena))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método que valida si un caracter es válido para un nombre.
        /// </summary>
        /// <param name="c">Caracter a validar.</param>
        /// <returns>true = válido.</returns>
        public static bool ValidaNombre(char c)
        {
            if (Char.IsLetter(c) || c == (char)Keys.Back || Char.IsWhiteSpace(c))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método que valida si un caracter es válido para una clave.
        /// </summary>
        /// <param name="c">Caracter a validar.</param>
        /// <returns>true = válida.</returns>
        public static bool ValidaClave(char c)
        {
            if(Char.IsDigit(c) || c == (char)Keys.Back)
            {
                return true;
            }
            return false;
        }
    }
}
