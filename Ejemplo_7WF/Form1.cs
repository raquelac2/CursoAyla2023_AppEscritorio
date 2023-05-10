using System.Windows.Forms;

namespace Ejemplo_7WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                //MessageBox.Show(string.Format("El campo {0} es obligatorio", txtNombre.Tag));
                e.Cancel = true;

                errorProvider1.SetError(txtNombre, String.Format("El campo {0} es obligatorio", txtNombre.Tag));
            }
            else
            {
                //MessageBox.Show("El campo es válido");
                e.Cancel = false;

                //Reseteamos el mensaje de error
                errorProvider1.SetError(txtNombre, "");
            }
        }

        private void txtApellidos_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                //MessageBox.Show(String.Format("El campo {0} es obligatorio", txtApellidos.Tag));
                e.Cancel = true;

                errorProvider1.SetError(txtApellidos, String.Format("El campo {0} es obligatorio", txtApellidos.Tag));
            }
            else
            {
                //MessageBox.Show("El campo es válido");
                e.Cancel = false;

                //Reseteamos el mensaje de error
                errorProvider1.SetError(txtApellidos, "");
            }
        }
    }
}