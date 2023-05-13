using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_7WF
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void CampoObligatorio_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox miTextBox = (TextBox)sender;
            if (string.IsNullOrEmpty(miTextBox.Text))
            {
                e.Cancel = true;
                string Mensaje = string.Format("El campo {0} es obligatorio", miTextBox.Tag);
                errorProvider1.SetError(miTextBox, Mensaje);

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(miTextBox, string.Empty);
            }
        }
    }
}
