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
    public partial class FrmEmpleado : Form
    {
        private EstudioNegocio _estudioNegocio;
        public FrmEmpleado(Form padre)
        {
            InitializeComponent();

            _estudioNegocio = new EstudioNegocio();

            this.Owner = padre;
        }

        private void _btnAltaEmpleado_Clik(object sender, EventArgs e)
        {
            try
            {
                if (EsValido())
                {
                    int id = Convert.ToInt32(_txtId.Text);
                    int idCategoria = Convert.ToInt32(_txtIdCategoria.Text);
                    int idEmpresa = Convert.ToInt32(_txtIdEmpresa.Text);
                    string nombre = _txtNombre.Text;
                    string apellido = _txtApellido.Text;
                    int cuil = Convert.ToInt32(_txtCuil.Text);
                    DateTime fechaNacimiento = Convert.ToDateTime(_txtFechaNacimiento.Text);
                    DateTime fechaAlta = Convert.ToDateTime(_txtFechaAlta.Text);

                    _estudioNegocio.AltaEmpleado(id, idCategoria, idEmpresa, nombre, apellido, cuil, fechaNacimiento, fechaAlta, true);

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


        private void _btnVolver_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void _btnConsultaEmpleado_Click(object sender, EventArgs e)
        {

            if (_txtId.Text != "")
            {
                int idEmpleado = Convert.ToInt32(_txtId.Text);
                Empleado empleado = _estudioNegocio.GetByIdEmpleado(idEmpleado);
                if (empleado != null)
                {
                    MessageBox.Show(empleado.ToString());
                   
                }
                else
                {
                    MessageBox.Show("Empleado inexistente");
                    limpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Ingrese Id de Empleado");
            }

        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {

        }
        public void limpiarCampos()
        {
            _txtId.Text = string.Empty;
            _txtIdCategoria.Text = string.Empty;
            _txtIdEmpresa.Text = string.Empty;
            _txtCuil.Text = string.Empty;
            _txtNombre.Text = string.Empty;
            _txtApellido.Text = string.Empty;
            _txtFechaNacimiento.Text = string.Empty;
            _txtFechaAlta.Text = string.Empty;
        }

        public bool EsValido()
        {
            if (string.IsNullOrEmpty(_txtApellido.Text) || string.IsNullOrEmpty(_txtNombre.Text) || string.IsNullOrEmpty(_txtIdCategoria.Text)
                || string.IsNullOrEmpty(_txtIdEmpresa.Text) || string.IsNullOrEmpty(_txtCuil.Text) ||
                string.IsNullOrEmpty(_txtFechaNacimiento.Text) || string.IsNullOrEmpty(_txtFechaAlta.Text))
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
            if (!Regex.IsMatch(_txtId.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Debe ingresar un número de Id.");
                limpiarCampos();
            }

        }

        private void _txtCuil_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(_txtCuil.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Debe ingresar números en este campo.");
                _txtCuil.Text = string.Empty;
            }
        }

        private void _txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(_txtNombre.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Debe ingresar letras en este campo.");
                _txtNombre.Text = string.Empty;
            }
        }

        private void _txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(_txtApellido.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Debe ingresar letras en este campo.");
                _txtApellido.Text = string.Empty;
            }
        }
    }
}
