﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            lblMensaje.Text = "Buenas tardes del viernes";
        }

        private void btnVerFormulario_Click(object sender, EventArgs e)
        {
            nuevaVentanaToolStripMenuItem.Enabled = false;

            Form1 frmFormulario = new Form1();
            frmFormulario.ShowDialog();
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevaVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnVerFormulario.Enabled = false;

            Form1 frmFormulario = new Form1();
            frmFormulario.Show();
        }
    }
}
