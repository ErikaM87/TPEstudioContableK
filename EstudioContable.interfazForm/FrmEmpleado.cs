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
        Validador validador = new Validador();
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
                    if (!_estudioNegocio.ValidarEmpleadoExistente(Convert.ToInt32(_txtId.Text)))
                    {
                        if (_estudioNegocio.ValidarCategoriaExistente(Convert.ToInt32(_txtIdCategoria.Text))) 
                        {

                            if (_estudioNegocio.ValidarEmpresaExistente(Convert.ToInt32(_txtIdEmpresa.Text)))
                            {
                                int id = Convert.ToInt32(_txtId.Text);
                                int idCategoria = Convert.ToInt32(_txtIdCategoria.Text);
                                int idEmpresa = Convert.ToInt32(_txtIdEmpresa.Text);
                                string nombre = _txtNombre.Text;
                                string apellido = _txtApellido.Text;
                                long cuil = long.Parse(_txtCuil.Text);
                                DateTime fechaNacimiento = Convert.ToDateTime(_txtFechaNacimiento.Text);
                                DateTime fechaAlta = Convert.ToDateTime(_txtFechaAlta.Text);

                                _estudioNegocio.AltaEmpleado(id, idCategoria, idEmpresa, nombre, apellido, cuil, fechaNacimiento, fechaAlta, true);

                                MessageBox.Show("Alta Generada con éxito");
                                limpiarCampos();
                            }
                            else
                            {
                                MessageBox.Show("Ha ingresado un Id de Empresa inexistente.");
                                _txtIdEmpresa.Text = string.Empty;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ha ingresado un Id de Categoria inexistente.");
                            _txtIdCategoria.Text = string.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ha ingresado un Id de Empleado que ya existe.");
                        _txtId.Text = string.Empty;
                    }
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
            validador.ValidarCampoId(_txtId);
        }

        private void _txtIdCategoria_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarCampoId(_txtIdCategoria);
        }

        private void _txtIdEmpresa_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarCampoId(_txtIdCategoria);
        }

        private void _txtCuil_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarCampoNumerico(_txtCuil);
        }

        private void _txtNombre_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarCampoString(_txtNombre);
        }

        private void _txtApellido_TextChanged(object sender, EventArgs e)
        {
            validador.ValidarCampoString(_txtApellido);
        }

        private void _txtFechaNacimiento_Validated(object sender, EventArgs e)
        {
            validador.ValidarFecha(_txtFechaNacimiento);
        }

        private void _txtFechaAlta_Validated(object sender, EventArgs e)
        {
            validador.ValidarFecha(_txtFechaAlta);
        }
    }
}
