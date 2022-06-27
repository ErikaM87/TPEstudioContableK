using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioContable.Entidades
{
    public class Liquidacion
    {
        private int _id;
        private int _idEmpleado;
        private string _codigoTransferencia;
        private int _periodo;
        private double _bruto;
        private double _descuentos;
        private DateTime _fechaAlta;

        

        public Liquidacion(int idEmpleado, int periodo, string codigoTransferencia,  double bruto, double descuentos, DateTime fechaAlta,int id)
        {
           
            _idEmpleado = idEmpleado;          
            _periodo = periodo;
            _codigoTransferencia = codigoTransferencia;
            _bruto = bruto;
            _descuentos = descuentos;
            _fechaAlta = fechaAlta;
            _id = id;
        }




        public int Id { get => _id; set => _id = value; }
        public int IdEmpleado { get => _idEmpleado; set => _idEmpleado = value; }
        public string CodigoTransferencia { get => _codigoTransferencia; set => _codigoTransferencia = value; }
        public int Periodo { get => _periodo; set => _periodo = value; }
        public double Bruto { get => _bruto; set => _bruto = value; }
        public double Descuentos { get => _descuentos; set => _descuentos = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }



        public override string ToString()
        {
            return "ID EMPLEADO: " + _idEmpleado.ToString() + "  "  +
                "BRUTO: $" + _bruto.ToString() + "  " + 
                "DESCUENTOS: $" + _descuentos.ToString();
        }
    }
}
