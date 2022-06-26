using EstudioContable.Entidades;
using EstudioContable.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudioContable.interfazForm
{
    public partial class FrmReporteLiquidaciones : Form
    {
        private Categoria _categoria;
        private List<Liquidacion> _liquidaciones;
        private EstudioNegocio _estudioNegocio;
        private List<Empleado> _empleados;

        public FrmReporteLiquidaciones(Categoria categoria)
        {
            _categoria = categoria;
            _estudioNegocio = new EstudioNegocio();
            _empleados = _estudioNegocio.GetEmpleadoByIdCategoria(categoria._id);
            _liquidaciones = _estudioNegocio.ReporteGetByIdCategoria(_empleados);
            InitializeComponent();
        }



        private void FrmReporteLiquidaciones_Load(object sender, EventArgs e)
        {
            MostrarLiquidaciones();

        }

        public void MostrarLiquidaciones()
        {
            try
            {
                _lstLiquidaciones.DataSource = null;


                if (_empleados != null)
                {
                    _lstLiquidaciones.DataSource = _liquidaciones;
                }
                else
                {
                    _lstLiquidaciones.DataSource = "No se han encontrado empleados pertenecientes a la empresa seleccionada";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al traer liquidaciones: " + ex.Message);
            }
        }
    }
}
