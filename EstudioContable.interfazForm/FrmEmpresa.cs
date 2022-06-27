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
    public partial class FrmEmpresa : Form
    {
        private EstudioNegocio _estudioNegocio;
        Validador validador = new Validador();
        public FrmEmpresa(Form padre)
        {
            InitializeComponent();

            _estudioNegocio = new EstudioNegocio();

            this.Owner = padre;
        }


        private void _btnConsultaEmpresa_Click(object sender, EventArgs e)
        {
            if (_txtId.Text != "")
            {
                int idEmpresa = Convert.ToInt32(_txtId.Text);
                Empresa empresa = _estudioNegocio.GetByIdEmpresa(idEmpresa);
                if (empresa != null)
                {
                    MessageBox.Show(empresa.ToString());

                }
                else
                {
                    MessageBox.Show("Empresa inexistente");
                    limpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Ingrese Id de Empresa");
            }

        }

        private void _btnAltaEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                if (EsValido())
                {
                    int id = Convert.ToInt32(_txtId.Text);
                    string razonSocial = _txtRazonSocial.Text;
                    int cuit = Convert.ToInt32(_txtCuit.Text);
                    string domicilio = _txtDomicilio.Text;
                    DateTime fechaAlta = Convert.ToDateTime(_txtFechaAlta.Text);
                    int usuario = Convert.ToInt32(_txtUsuario.Text);


                    _estudioNegocio.AltaEmpresa(razonSocial, cuit, domicilio, fechaAlta, usuario, id);

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

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void _btnVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        public void limpiarCampos()
        {
            _txtId.Text = string.Empty;
            _txtRazonSocial.Text = string.Empty;
            _txtCuit.Text = string.Empty;
            _txtDomicilio.Text = string.Empty;
            _txtFechaAlta.Text = string.Empty;
            _txtUsuario.Text = string.Empty;
        }
        public bool EsValido()
        {
            if (string.IsNullOrEmpty(_txtId.Text) || string.IsNullOrEmpty(_txtRazonSocial.Text) || string.IsNullOrEmpty(_txtCuit.Text)
                || string.IsNullOrEmpty(_txtDomicilio.Text) || string.IsNullOrEmpty(_txtFechaAlta.Text) ||
                string.IsNullOrEmpty(_txtUsuario.Text))
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

        private void _txtRazonSocial_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarCampoString(_txtRazonSocial);
        }

        private void _txtCuit_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarCampoNumerico(_txtCuit);
        }

        private void _txtFechaAlta_Validated(object sender, EventArgs e)
        {
            validador.ValidarFecha(_txtFechaAlta);
        }

        private void _txtUsuario_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarCampoNumerico(_txtUsuario);
        }

    }
}
