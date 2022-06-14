using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioContable.Entidades
{
    public class Empresa
    {
        public string _razonSocial;
        public long _cuit;
        public string _domicilio;
        public DateTime _fechaAlta;
        public int _usuario;
        public int _id;



        public override string ToString()
        {
            return  "RAZÓN SOCIAL: " + _razonSocial +  "\r\n" +
                "CUIT: " + _cuit ;
                
        }

        public Empresa(string razonSocial, long cuit, string domicilio, DateTime fechaAlta, int usuario, int id)
        {
            _razonSocial = razonSocial;
            _cuit = cuit;
            _domicilio = domicilio;
            _fechaAlta = fechaAlta;
            _usuario = usuario;
            _id = id;
        }





        //public int Id { get => _id; set => _id = value; }
        //public string RazonSocial { get => _razonSocial; set => _razonSocial = value; }
        //public long Cuit { get => _cuit; set => _cuit = value; }
        //public string Domicilio { get => _domicilio; set => _domicilio = value; }
        //public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
    }
}
