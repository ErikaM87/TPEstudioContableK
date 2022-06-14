using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioContable.Entidades
{
    public class Empleado : Persona
    {
        public int _id;
        public int _idEmpresa;
        public int _idCategoria;
        public int _cuil;
        public DateTime _fechaNacimiento;
        public DateTime _fechaAlta;

        public Empleado()
        {
        }

        public Empleado(int id, int idEmpresa, int idCategoria, int cuil, DateTime fechaNacimiento, DateTime fechaAlta)
        {
            _id = id;
            _idEmpresa = idEmpresa;
            _idCategoria = idCategoria;
            _cuil = cuil;
            _fechaNacimiento = fechaNacimiento;
            _fechaAlta = fechaAlta;
        }

        public override string ToString()
        {
            return  _idCategoria.ToString() + " " +_idEmpresa.ToString() + " " + _cuil.ToString() + " " + _nombre + " " + _apellido + " " + 
                 _fechaNacimiento.ToString() + " " + _fechaAlta.ToString() + " " + _id.ToString();
            
               
        }

        //public int id { get => _id; set => _id = value; }
        //public int idEmpresa { get => _idEmpresa; set => _idEmpresa = value; }
        //public int idCategoria { get => _idCategoria; set => _idCategoria = value; }
        //public long cuit { get => _cuit; set => _cuit = value; }
        //public DateTime fechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        //public DateTime fechaAlta { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        //public bool activo { get => _activo; set => _activo = value; }


    }
}
