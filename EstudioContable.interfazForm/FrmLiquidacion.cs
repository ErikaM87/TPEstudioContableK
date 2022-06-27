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
using System.Text.RegularExpressions;

namespace EstudioContable.interfazForm
{
    public partial class FrmLiquidacion : Form
    {
        private EstudioNegocio _estudioNegocio;
        Validador validador = new Validador();
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
                    limpiarCampos();
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
               if (EsValido())
                {
                    int idEmpleado = Convert.ToInt32(_txtIdEmpleado.Text);
                    int periodo = Convert.ToInt32(_txtPeriodo.Text);
                    string codigoTransferencia = _txtCodigoTransferencia.Text;
                    double bruto = Convert.ToDouble(_txtBruto.Text);
                    double descuentos = Convert.ToDouble(_txtDescuentos.Text);
                    DateTime fechaAlta = Convert.ToDateTime(_txtFechaAlta.Text);
                    int id = Convert.ToInt32(_txtId.Text);
                    _estudioNegocio.AltaLiquidacion(idEmpleado, periodo, codigoTransferencia, bruto, descuentos, fechaAlta, id);

                    MessageBox.Show("Alta Generada con éxito");
                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show("Complete todos los campos");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                limpiarCampos();
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
        public void limpiarCampos()
        {
            _txtId.Text = string.Empty;
            _txtIdEmpleado.Text = string.Empty;
            _txtPeriodo.Text = string.Empty;
            _txtCodigoTransferencia.Text = string.Empty;
            _txtBruto.Text = string.Empty;
            _txtDescuentos.Text = string.Empty;
            _txtFechaAlta.Text = string.Empty;
        }
        public bool EsValido()
        {
            if (string.IsNullOrEmpty(_txtId.Text) || string.IsNullOrEmpty(_txtIdEmpleado.Text) || string.IsNullOrEmpty(_txtPeriodo.Text)
                || string.IsNullOrEmpty(_txtCodigoTransferencia.Text) || string.IsNullOrEmpty(_txtBruto.Text)
                || string.IsNullOrEmpty(_txtDescuentos.Text) || string.IsNullOrEmpty(_txtFechaAlta.Text))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private void _txtId_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarCampoId(_txtId);
        }
        private void _txtIdEmpleado_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarCampoId(_txtIdEmpleado);
        }
        private void _txtPeriodo_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarCampoNumerico(_txtPeriodo);
        }

        private void _txtBruto_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarCampoNumerico(_txtBruto);
        }

        private void _txtDescuentos_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarCampoNumerico(_txtDescuentos);
        }

        private void _txtFechaAlta_Validated(object sender, EventArgs e)
        {
            validador.ValidarFecha(_txtFechaAlta);
        }
    }
}
