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
        private List<Empleado> _empleados;
        public EstudioNegocio estudioNegocio;
        public FrmReporteEmpleados(Empresa empresa)
        {
            _empleados = estudioNegocio.ReporteGetByIdEmpresa(empresa._id);
            InitializeComponent();
        }

        private void FrmReporteEmpleados_Load(object sender, EventArgs e)
        {
            txtReporteEmpleados.Text = _empleados.ToString();
        }
    }
}
