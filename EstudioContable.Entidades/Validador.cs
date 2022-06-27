using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EstudioContable.Entidades
{
    public class Validador
    {
        public void ValidarFecha(TextBox txt)
        {
            DateTime resultado;
            bool conversionFecha;


            conversionFecha = DateTime.TryParse(txt.Text, out resultado);
            if (!conversionFecha)
            {
                MessageBox.Show("Debe ingresar fecha con formato fecha: dd-mm-yyyy o yyyy-mm-dd.");
                txt.Text = string.Empty;
            }

        }
        public void ValidarCampoString(TextBox txt)
        {

            if (Regex.IsMatch(txt.Text, @"^[0-9]+$") && (txt.Text != string.Empty))
            {
                MessageBox.Show("Debe ingresar letras en este campo.");
                txt.Text = string.Empty;
            }
        }

        public void ValidarCampoNumerico(TextBox txt)
        {
            if (!Regex.IsMatch(txt.Text, @"^[0-9]+$") && (txt.Text != string.Empty))
            {
                MessageBox.Show("Debe ingresar números en este campo.");
                txt.Text = string.Empty;
            }
        }
        public void ValidarCampoId(TextBox txt)
        {
            if (!Regex.IsMatch(txt.Text, @"^[0-9]+$") && (txt.Text != string.Empty))
            {
                MessageBox.Show("Debe ingresar un número de Id.");
                txt.Text = string.Empty;
            }
        }
        
    }
}
