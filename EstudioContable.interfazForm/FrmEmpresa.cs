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
    public partial class FrmEmpresa : Form
    {
        private EstudioNegocio _estudioNegocio;
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
                int id = Convert.ToInt32(_txtId.Text);
                string razonSocial =_txtRazonSocial.Text;
                int cuit = Convert.ToInt32(_txtCuit.Text);
                string domicilio = _txtDomicilio.Text;
                DateTime fechaAlta = Convert.ToDateTime(_txtFechaAlta.Text) ;
                int usuario = Convert.ToInt32(_txtUsuario.Text);
   

                _estudioNegocio.AltaEmpresa(razonSocial, cuit, domicilio, fechaAlta, usuario, id);

                MessageBox.Show("Alta Generada con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

        
    }
}
