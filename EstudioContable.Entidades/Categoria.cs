using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioContable.Entidades
{
    public class Categoria
    {
        private int _id;
        private string _nombre;
        private string _convenio;
        private double _sueldoBasico;

     

        public Categoria( string nombre, string convenio, double sueldoBasico, int id)
        {
            
            _nombre = nombre;
            _convenio = convenio;
            _sueldoBasico = sueldoBasico;
            _id = id;
        }

        public int Id { get { return _id; } set { _id = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Convenio { get { return _convenio; } set { _convenio = value; } }
        public double SueldoBasico { get { return _sueldoBasico; } set { _sueldoBasico = value; } }

        public override string ToString()
        {
            return "ID: " + Id.ToString() + "  " +
                "NOMBRE: " + Nombre;
        }
    }
}
