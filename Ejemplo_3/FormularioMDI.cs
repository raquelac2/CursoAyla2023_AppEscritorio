using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_3
{
    public partial class FormularioMDI : Form
    {
        public FormularioMDI()
        {
            InitializeComponent();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuFormulario1_Click(object sender, EventArgs e)
        {
            Form1 frmFormulario1 = new Form1();
            frmFormulario1.MdiParent = this;
            frmFormulario1.Show();
        }

        private void mnuFormulario2_Click(object sender, EventArgs e)
        {
            Form2 frmFormulario2 = new Form2();
            frmFormulario2.MdiParent = this;
            frmFormulario2.Show();
        }
    }
}
