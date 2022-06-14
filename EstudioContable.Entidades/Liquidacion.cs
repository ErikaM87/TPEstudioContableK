using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioContable.Entidades
{
    public class Liquidacion
    {
        public int _id;
        public int _idEmpleado;
        public string _codigoTransferencia;
        public int _periodo;
        public double _bruto;
        public double _descuentos;
        public DateTime _fechaAlta;

        public Liquidacion()
        {
        }

        public Liquidacion(int id, int idEmpleado, string codigoTransferencia, int periodo, double bruto, double descuentos, DateTime fechaAlta)
        {
            _id = id;
            _idEmpleado = idEmpleado;
            _codigoTransferencia = codigoTransferencia;
            _periodo = periodo;
            _bruto = bruto;
            _descuentos = descuentos;
            _fechaAlta = fechaAlta;
        }




        //public int id { get => _id; set => _id = value; }
        //public int IdEmpleado { get => _idEmpleado; set => _idEmpleado = value; }
        //public int CodigoTransferencia { get => _codigoTransferencia; set => _codigoTransferencia = value; }
        //public int Periodo { get => _periodo; set => _periodo = value; }
        //public double Bruto { get => _bruto; set => _bruto = value; }
        //public double Descuentos { get => _descuentos; set => _descuentos = value; }
        //public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }



        public override string ToString()
        {
            return _idEmpleado + " " + _periodo + " " + _codigoTransferencia + " " + _bruto.ToString() + " "
                + _descuentos.ToString() + " " + _fechaAlta.ToString() + " " + _id.ToString();
        }
    }
}
