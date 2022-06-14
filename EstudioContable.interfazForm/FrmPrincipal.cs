using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstudioContable.Negocio;
using EstudioContable.Entidades;

namespace EstudioContable.interfazForm
{
    public partial class FrmPrincipal : Form
    {
        private EstudioNegocio estudioNegocio;
        public FrmPrincipal()
        {
            InitializeComponent();

            estudioNegocio = new EstudioNegocio();
        }

        private void btnEmpleados_click(object sender, EventArgs e)
        {
            FrmEmpleado frmEmpleado = new FrmEmpleado(this);
            frmEmpleado.Show();
            this.Hide();
        }


        private void _btnEmpresas_Click(object sender, EventArgs e)
        {
            FrmEmpresa frmEmpresa = new FrmEmpresa(this);
            frmEmpresa.Show();
            this.Hide();
        }

        private void btnCategorias_click(object sender, EventArgs e)
        {
            
            FrmCategoria frmCategoria = new FrmCategoria(this);
            frmCategoria.Show();
            this.Hide();
        }

        private void _btnLiquidaciones_Click(object sender, EventArgs e)
        {
            FrmLiquidacion frmLiquidacion = new FrmLiquidacion(this);
            frmLiquidacion.Show();
            this.Hide();
        }

   

        private void _btnGenerarReportes_Click(object sender, EventArgs e)
        {
            FrmReportes frmReportes = new FrmReportes(this);
            frmReportes.Show();
            this.Hide();
        }

        private void FrmPrincipal_Load_1(object sender, EventArgs e)
        {

        }
    }
}
