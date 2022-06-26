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
    public partial class FrmLiquidacion : Form
    {
        private EstudioNegocio _estudioNegocio;
        public FrmLiquidacion(Form padre)
        {
            InitializeComponent();

            _estudioNegocio = new EstudioNegocio();
            this.Owner = padre;
        }

        private void _btnConsultarLiquidacion_Click(object sender, EventArgs e)
        {
            if (_txtId.Text != "")
            {
                int idLiquidacion = Convert.ToInt32(_txtId.Text);
                Liquidacion liquidacion = _estudioNegocio.GetByIdLiquidacion(idLiquidacion);
                if (liquidacion != null)
                {
                    MessageBox.Show(liquidacion.ToString());

                }
                else
                {
                    MessageBox.Show("Liquidación inexistente");
                }
            }
            else
            {
                MessageBox.Show("Ingrese Id de liquidación");
            }
        }

        private void _btnAltaLiquidación_Click(object sender, EventArgs e)
        {
            try
            {
               
                int idEmpleado = Convert.ToInt32(_txtIdEmpleado.Text);
                int periodo = Convert.ToInt32(_txtPeriodo.Text);
                string codigoTransferencia = _txtCodigoTransferencia.Text;
                double bruto = Convert.ToDouble(_txtBruto.Text);
                double descuentos = Convert.ToDouble(_txtDescuentos.Text);
                DateTime fechaAlta = Convert.ToDateTime(_txtFechaAlta.Text) ;
                int id = Convert.ToInt32(_txtId.Text);
                _estudioNegocio.AltaLiquidacion( idEmpleado, periodo, codigoTransferencia, bruto, descuentos, fechaAlta,id);

                MessageBox.Show("Alta Generada con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        

        private void _linkVolver_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void FrmLiquidacion_Load(object sender, EventArgs e)
        {

        }
    }
}
