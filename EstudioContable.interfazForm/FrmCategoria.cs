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
    public partial class FrmCategoria : Form
    {
        private EstudioNegocio _estudioNegocio;
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
                string nombre = _txtNombre.Text;
                string convenio = _txtConvenio.Text;
                double sueldoBasico = Convert.ToInt32(_txtSueldoBasico.Text);
                int id = Convert.ToInt32(_txtId.Text);
                

                _estudioNegocio.AltaCategoria(nombre, convenio, sueldoBasico, id);

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

        private void FrmCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
