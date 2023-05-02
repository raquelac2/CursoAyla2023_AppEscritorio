﻿using _LIBCoches;
using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Coches misCoches = new Coches();

            var resultado = from X in misCoches.ListaCoches
                            select new { Marca = X.Marca, Modelo = X.Modelo };

            dataGridView1.DataSource = resultado.ToList();

        }
    }
}
