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
    public partial class FrmReporteEmpleados : Form
    {
        private Empresa _empresa;
        private List<Empleado> _empleados;
        private EstudioNegocio _estudioNegocio;
       
        public FrmReporteEmpleados(Empresa empresa)
        {
            _empresa = empresa;
            _estudioNegocio = new EstudioNegocio();
            _empleados = _estudioNegocio.ReporteGetByIdEmpresa(_empresa.Id);
            InitializeComponent();
        }

        

        private void FrmReporteEmpleados_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
          
        }

        public void MostrarEmpleados()
        {
            try
            {
                _lstEmpleados.DataSource = null;
               

                if(_empleados != null)
                {
                    _lstEmpleados.DataSource = _empleados;
                }
                else 
                {
                    _lstEmpleados.DataSource = "No se han encontrado empleados pertenecientes a la empresa seleccionada";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al traer empleados: " + ex.Message);
            }
        }

     
    }
}
