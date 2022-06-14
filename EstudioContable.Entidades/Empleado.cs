using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioContable.Entidades
{
    public class Empleado : Persona
    {
   
        public int _idEmpresa;
        public int _idCategoria;
        public long _cuil;
        public DateTime _fechaNacimiento;
        public DateTime _fechaAlta;
        public bool _activo;

        public Empleado(int id, int idEmpresa,string nombre,string apellido, int idCategoria, long cuil, DateTime fechaNacimiento, DateTime fechaAlta, bool activo) :  base (id,  nombre,  apellido )
        {
            _idEmpresa = idEmpresa;
            _idCategoria = idCategoria;
            _cuil = cuil;
            _fechaNacimiento = fechaNacimiento;
            _fechaAlta = fechaAlta;
            _activo = activo;
        }

        public override string ToString()
        {
            return "ID: " +_id.ToString()+ "\r\n" +
                "NOMBRE: " + _nombre + "\r\n"  + 
                "APELLIDO " + _apellido + "\r\n"  +
                "FECHA DE ALTA:  " + _fechaAlta.ToString("dd - MM - yyyy");
            
               
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
