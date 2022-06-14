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
                int id = Convert.ToInt32(_txtId.Text);
                int idCategoria = Convert.ToInt32(_txtIdCategoria.Text);
                int idEmpresa = Convert.ToInt32(_txtIdEmpresa.Text);
                string nombre = _txtNombre.Text;
                string apellido = _txtApellido.Text;
                int cuil = Convert.ToInt32(_txtCuil.Text);
                DateTime fechaNacimiento = Convert.ToDateTime(_txtFechaNacimiento.Text);
                DateTime fechaAlta = Convert.ToDateTime(_txtFechaAlta.Text);

                _estudioNegocio.AltaEmpleado(id, idCategoria, idEmpresa, nombre, apellido, cuil, fechaNacimiento, fechaAlta);

                MessageBox.Show("Alta Generada con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

       
    }
}
