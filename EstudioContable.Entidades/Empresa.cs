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
        public int _cuit;
        public string _domicilio;
        public DateTime _fechaAlta;
        public int _usuario;
        public int _id;

        public Empresa()
        {
        }

        public Empresa(string razonSocial, int cuit, string domicilio, DateTime fechaAlta, int usuario, int id)
        {
            _razonSocial = razonSocial;
            _cuit = cuit;
            _domicilio = domicilio;
            _fechaAlta = fechaAlta;
            _usuario = usuario;
            _id = id;
        }

        public override string ToString()
        {
            return  _razonSocial + " " + _cuit.ToString() + " " + _domicilio + " " + _fechaAlta.ToString() + " " + _usuario + " " + _id;
                
        }





        //public int Id { get => _id; set => _id = value; }
        //public string RazonSocial { get => _razonSocial; set => _razonSocial = value; }
        //public long Cuit { get => _cuit; set => _cuit = value; }
        //public string Domicilio { get => _domicilio; set => _domicilio = value; }
        //public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
    }
}
