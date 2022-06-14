using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudioContable.AccesoDatos;
using EstudioContable.Entidades;

namespace EstudioContable.Negocio
{
    public class EstudioNegocio
    {
        public EmpleadoDatos _empleadoDatos;
        public EmpresaDatos _empresaDatos;
        public CategoriaDatos _categoriaDatos;
        public LiquidacionDatos _liquidacionDatos;

        public EstudioNegocio()
        {
            _empleadoDatos = new EmpleadoDatos();
            _empresaDatos = new EmpresaDatos();
            _categoriaDatos = new CategoriaDatos();
            _liquidacionDatos = new LiquidacionDatos();
        }

        #region Métodos para Listas
        public List<Empleado> GetListaEmpleados()
        {
            List<Empleado> list = _empleadoDatos.TraerTodos();

            return list;
        }
        public List<Empresa> GetListaEmpresa()
        {
            List<Empresa> list = _empresaDatos.TraerTodosEmpresa();

            return list;
        }
        public List<Categoria> GetListaCategoria()
        {
            List<Categoria> list = _categoriaDatos.TraerTodos();

            return list;
        }
        public List<Liquidacion> GetListaLiquidacion()
        {
            List<Liquidacion> list = _liquidacionDatos.TraerTodos();

            return list;
        }

        #endregion

        #region Métodos que devuelven Objetos

        public Categoria TraerCategoria(Categoria categoria)
        {
            // validar cliente no nulo

            return _categoriaDatos.TraerPorIdCategoria(categoria._id);
        }
        public Liquidacion TraerLiquidacion(Liquidacion liquidacion)
        {
            // validar cliente no nulo

            return _liquidacionDatos.TraerPorIdLiquidacion(liquidacion._id);
        }
        #endregion

        #region Métodos por Id


        public Empleado GetByIdEmpleado(int idEmpleado)
        {

            foreach (var item in GetListaEmpleados())
            {
                if (idEmpleado == item._id)
                    return item;

            }

            return null;
        }
        public Empleado GetEmpleadoByIdEmpresa(int idEmpresa)
        {
           
            foreach (var item in GetListaEmpleados())
            {
                if (idEmpresa == item._id)
                    return item;
            }

            return null;
        }
        public Empresa GetByIdEmpresa(int idEmpresa)
        {
            
            foreach (var item in GetListaEmpresa())
            {
                if (idEmpresa == item._id)
                    return item;
            
            }

            return null;
        }
        public Categoria GetByIdCategoria(int idCategoria)
        {
           
            foreach (var item in GetListaCategoria())
            {
                if (idCategoria == item._id)
                    return item;
                
            }

            return null;
        }

        public Liquidacion GetByIdLiquidacion(int idLiquidacion)
        {
           
            foreach (var item in GetListaLiquidacion())
            {
                if (idLiquidacion == item._id)
                    return item;
                
            }

            return null;
        }


        #endregion

        #region Métodos de Altas
        public void AltaEmpleado(int id, int idCategoria, int idEmpresa, string nombre, string apellido, int cuil, DateTime fnac, DateTime fechaAlta, bool activo)
        {
            Empleado empleado = new Empleado(id,idEmpresa,nombre,apellido, idCategoria, cuil,fnac,fechaAlta, true);


            TransactionResult transaction = _empleadoDatos.Insertar(empleado);



            if (!transaction.IsOk)
                throw new Exception(transaction.Error);
        }
        public void AltaEmpresa(string razonSocial, int cuit, string domicilio, DateTime fechaAlta, int usuario, int id)
        {
            Empresa empresa = new Empresa(razonSocial,cuit,domicilio,fechaAlta,usuario,id);

            TransactionResult transaction = _empresaDatos.InsertarEmpresa(empresa);



            if (!transaction.IsOk)
                throw new Exception(transaction.Error);
        }
             

        public void AltaCategoria(string nombre, string convenio, double sueldoBasico, int id)
        {
            Categoria categoria = new Categoria(nombre, convenio, sueldoBasico, id);
           

            TransactionResult transaction = _categoriaDatos.InsertarCategoria(categoria);


            if (!transaction.IsOk)
                throw new Exception(transaction.Error);

        }
                       
        public void AltaLiquidacion(int idEmpleado, int periodo, string codigoTransferencia, double bruto, double descuentos, int id, DateTime fechaAlta)
        {
            Liquidacion liquidacion = new Liquidacion(id, idEmpleado, codigoTransferencia, periodo, bruto,descuentos,fechaAlta);


            liquidacion._id = id;

            TransactionResult transaction = _liquidacionDatos.InsertarLiquidacion(liquidacion);



            if (!transaction.IsOk)
                throw new Exception(transaction.Error);
        }

        #endregion

        #region Métodos Reportes
        //REPORTE EMPLEADO POR EMPRESA
        public List<Empleado> ReporteGetByIdEmpresa(int idEmpresa)
        {
            List<Empleado> empleados = new List<Empleado>();
            foreach (var item in GetListaEmpleados())
            {
                if (idEmpresa == item._idEmpresa)

                    empleados.Add(item);
            }

            return empleados;
        }

        //REPORTE LIQUIDACION POR CATEGORIA
        public List<Liquidacion> ReporteGetByIdLiquidacion(int idCategoria)
        {
            List<Liquidacion> resultado = new List<Liquidacion>();
            foreach (var item in GetListaLiquidacion())
            {
                if (idCategoria == item._id)

                    resultado.Add(item);
            }

            return resultado;
        }
        #endregion


    }
}
