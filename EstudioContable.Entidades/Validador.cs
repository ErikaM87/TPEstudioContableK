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
        public string PedirStrNoVac(string mensaje)
        {
            string valor;
            do
            {
                Console.WriteLine(mensaje);
                valor = Console.ReadLine().ToUpper();
                if (valor == "")
                {
                    Console.WriteLine("No puede ser vacío");
                }
            } while (valor == "");

            return valor;
        }

        public string PedirSoN(string mensaje)
        {
            string valor = "";
            string mensError = "Debe ingresar S o N";
            do
            {
                valor = PedirStrNoVac(mensaje);
                if (valor != "S" && valor != "N")
                {
                    Console.WriteLine(mensError);
                }
            } while (valor != "S" && valor != "N");

            return valor;
        }

        public int PedirInt(string mensaje)
        {
            int valor;
            bool valido = false;
            string mensError = "Debe ingresar un valor";

            do
            {
                Console.WriteLine(mensaje);
                if (!int.TryParse(Console.ReadLine(), out valor))
                {
                    Console.WriteLine(mensError);
                }
                else
                {
                    valido = true;
                }
            } while (!valido);

            return valor;
        }
        public static int PedirId(string mensaje)
        {
            int valor;
            bool valido = false;
            string mensError = "Debe ingresar un Id";

            do
            {
                Console.WriteLine(mensaje);
                if (!int.TryParse(Console.ReadLine(), out valor))
                {
                    Console.WriteLine(mensError);
                }
                else
                {
                    valido = true;
                }
            } while (!valido);

            return valor;
        }


        //public long PedirLong(string mensaje, long min, long max)
        ////muestra "mensaje" por consola, y pide ingreso
        ////por consola hasta que el usuario ingrese un numero entre
        ////min y max para devolverlo
        //{​​​​​​​​
        //    bool valido;
        //    valido = false;
        //    long retorno;
        //    do
        //    {​​​​​​​​
        //        valido = long.TryParse(PedirStrNoVac(mensaje + ". Rango válido: " + min + " - " + max).ToUpper(), out retorno);
        //        if (!valido || retorno > max || retorno < min)
        //        {​​​​​​​​
        //        Console.Write("\nValor ingresado no válido\n");

        //        }​​​​​​​​
        //    }​​​​​​​​ while (!valido) ;


        //    return retorno;
        //}​​​​​​​​
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
    }
}
