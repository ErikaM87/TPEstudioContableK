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
        public List<Liquidacion> _liquidaciones;
        private List<Categoria> _categorias;
        public EstudioNegocio estudioNegocio;
        public FrmReporteLiquidaciones(Categoria categoria)
        {


            _liquidaciones = estudioNegocio.ReporteGetByIdLiquidacion(categoria._id);
            InitializeComponent();
        }

        private void FrmReporteLiquidaciones_Load(object sender, EventArgs e)
        {
            txtReporteLiquidaciones.Text = _liquidaciones.ToString();
        }
    }
}
