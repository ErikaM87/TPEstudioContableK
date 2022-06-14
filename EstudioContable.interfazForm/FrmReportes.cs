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
    public partial class FrmReportes : Form
    {
        public EstudioNegocio _estudioNegocio;
        public FrmReportes(Form padre)
        {
            InitializeComponent();
            _estudioNegocio = new EstudioNegocio();
            this.Owner = padre;
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
           MostarEmpresas();
        }

        public void CargarListas()
        {
            List<Empresa> lstEmpresas = _estudioNegocio.GetListaEmpresa();
            List<Categoria> lstCategoria = _estudioNegocio.GetListaCategoria();

            _lstEmpresas.DataSource = null;
            _lstCategorias.DataSource = null;

            _lstEmpresas.DataSource = lstEmpresas;
            _lstCategorias.DataSource = lstCategoria;


        }

        public void MostarEmpresas()
        {
            try
            {
                List<Empresa> listadoEmpresa = _estudioNegocio.GetListaEmpresa();
                _lstEmpresas.DataSource = null;
                _lstEmpresas.DataSource = listadoEmpresa;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al traer clientes: " + ex.Message);
            }

        }

        private void _lstEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void _btnReporteEmpleados_Click(object sender, EventArgs e)
        {
            Empresa _empSeleccionada = null;

            _empSeleccionada = (Empresa)_lstEmpresas.SelectedItem;

            if (_empSeleccionada != null)
            {
                FrmReporteEmpleados frmReporteEmpleados = new FrmReporteEmpleados(_empSeleccionada);
                frmReporteEmpleados.Show();
            }
        }

        private void btn_ReporteLiquidaciones_Click(object sender, EventArgs e)
        {
            Categoria catSeleccionada = null;

            catSeleccionada = (Categoria)_lstCategorias.SelectedItem;

            if (catSeleccionada != null)
            {
                FrmReporteLiquidaciones frmReporteEmpleados = new FrmReporteLiquidaciones(catSeleccionada);
                frmReporteEmpleados.Show();
            }
        }


        private void _btnVolver_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
