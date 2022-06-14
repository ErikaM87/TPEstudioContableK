using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioContable.Entidades
{
    public class Categoria
    {
        public int _id;
        public string _nombre;
        public string _convenio;
        public double _sueldoBasico;

     

        public Categoria( string nombre, string convenio, double sueldoBasico, int id)
        {
            
            _nombre = nombre;
            _convenio = convenio;
            _sueldoBasico = sueldoBasico;
            _id = id;
        }

        public override string ToString()
        {
            return "ID: "  +_id.ToString() + " " + "\r\n"   +"NOMBRE:"
                 + " " +_nombre;
        }

        //public int id { get => _id; set => _id = value }
        //public string Nombre { get => _nombre; set => _nombre = value; }
        //public string Convenio { get => _convenio; set => _convenio = value; }
        //public double SueldoBasico { get => _sueldoBasico; set => _sueldoBasico = value; }

    }
}
