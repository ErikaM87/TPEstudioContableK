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
            List<Empresa> list = _empresaDatos.Traer(892310);

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
            Empleado empleado = new Empleado();
            List<Empleado> empleados = _empleadoDatos.TraerTodos();
            foreach (var item in empleados)
            {
                if (idEmpleado == item._id)
                    empleado = item;
            }

               return empleado;
        }
        public Empleado GetEmpleadoByIdEmpresa(int idEmpresa)
        {
            Empleado empleado = new Empleado();
            foreach (var item in GetListaEmpleados())
            {
                if (idEmpresa == item._id)
                    return item;
                empleado = item;
            }

            return empleado;
        }
        public Empresa GetByIdEmpresa(int idEmpresa)
        {
            Empresa empresa = new Empresa();
            foreach (var item in GetListaEmpresa())
            {
                if (idEmpresa == item._id)
                    return item;
                empresa = item;
            }

            return empresa;
        }
        public Categoria GetByIdCategoria(int idCategoria)
        {
            Categoria categoria = new Categoria();
            foreach (var item in GetListaCategoria())
            {
                if (idCategoria == item._id)
                    return item;
                categoria = item;
            }

            return categoria;
        }

        public Liquidacion GetByIdLiquidacion(int idLiquidacion)
        {
            Liquidacion liquidacion = new Liquidacion();
            foreach (var item in GetListaLiquidacion())
            {
                if (idLiquidacion == item._id)
                    return item;
                liquidacion = item;
            }

            return liquidacion;
        }


        #endregion

        #region Métodos de Altas
        public void AltaEmpleado(int id, int idCategoria, int idEmpresa, string nombre, string apellido, int cuil, DateTime fnac, DateTime fechaAlta)
        {
            Empleado empleado = new Empleado();
            empleado._id = id;
            empleado._idCategoria = idCategoria;
            empleado._idEmpresa = idEmpresa;
            empleado._cuil = cuil;
            empleado._nombre = nombre;
            empleado._apellido = apellido;
            empleado._fechaNacimiento = fnac;
            empleado._fechaAlta = fechaAlta;


            TransactionResult transaction = _empleadoDatos.Insertar(empleado);



            if (!transaction.IsOk)
                throw new Exception(transaction.Error);
        }
        public void AltaEmpresa(string razonSocial, int cuit, string domicilio, DateTime fechaAlta, int usuario, int id)
        {
            Empresa empresa = new Empresa();
            empresa._razonSocial = razonSocial;
            empresa._cuit = cuit;
            empresa._domicilio = domicilio;
            empresa._fechaAlta = fechaAlta;
            empresa._usuario = usuario;
            empresa._id = id;

            TransactionResult transaction = _empresaDatos.InsertarEmpresa(empresa);



            if (!transaction.IsOk)
                throw new Exception(transaction.Error);
        }
             

        public void AltaCategoria(string nombre, string convenio, double sueldoBasico, int id)
        {
            Categoria categoria = new Categoria();
            categoria._nombre = nombre;
            categoria._convenio = convenio;
            categoria._sueldoBasico = sueldoBasico;
            categoria._id = id;

            TransactionResult transaction = _categoriaDatos.InsertarCategoria(categoria);


            if (!transaction.IsOk)
                throw new Exception(transaction.Error);

        }
                       
        public void AltaLiquidacion(int idEmpleado, int periodo, string codigoTransferencia, double bruto, double descuentos, int id, DateTime fechaAlta)
        {
            Liquidacion liquidacion = new Liquidacion();
            liquidacion._idEmpleado = idEmpleado;
            liquidacion._periodo = periodo;
            liquidacion._codigoTransferencia = codigoTransferencia;
            liquidacion._bruto = bruto;
            liquidacion._descuentos = descuentos;
            liquidacion._fechaAlta = fechaAlta;


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
