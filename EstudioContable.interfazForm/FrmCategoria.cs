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
    public partial class FrmCategoria : Form
    {
        private EstudioNegocio _estudioNegocio;
        Validador validador = new Validador();
        public FrmCategoria(Form padre)
        {
            InitializeComponent();

            _estudioNegocio = new EstudioNegocio();
            this.Owner = padre;
        }

        private void _btnConsultaCategoria_Click(object sender, EventArgs e)
        {
            if (_txtId.Text != "")
            {
                int idCategoria = Convert.ToInt32(_txtId.Text);
                Categoria categoria = _estudioNegocio.GetByIdCategoria(idCategoria);
                if (categoria != null)
                {
                    MessageBox.Show(categoria.ToString());

                }
                else
                {
                    MessageBox.Show("Categoría inexistente");
                    limpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Ingrese Id de Categoría");
            }
        }

        private void _btnAltaCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (EsValido())
                {
                    string nombre = _txtNombre.Text;
                    string convenio = _txtConvenio.Text;
                    double sueldoBasico = Convert.ToInt32(_txtSueldoBasico.Text);
                    int id = Convert.ToInt32(_txtId.Text);


                    _estudioNegocio.AltaCategoria(nombre, convenio, sueldoBasico, id);

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

        private void FrmCategoria_Load(object sender, EventArgs e)
        {

        }

        public void limpiarCampos()
        {
            _txtId.Text = string.Empty;
            _txtNombre.Text = string.Empty;
            _txtConvenio.Text = string.Empty;
            _txtSueldoBasico.Text = string.Empty;
        }
        public bool EsValido()
        {
            if (string.IsNullOrEmpty(_txtId.Text) || string.IsNullOrEmpty(_txtNombre.Text) || string.IsNullOrEmpty(_txtConvenio.Text)
                || string.IsNullOrEmpty(_txtSueldoBasico.Text))
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
        private void _txtNombre_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarCampoString(_txtNombre);

        }

        private void _txtSueldoBasico_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarCampoNumerico(_txtSueldoBasico);

        }
    }
}
