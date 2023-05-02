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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            TextBox miCajaDeTexto = new TextBox();
            miCajaDeTexto.Text = "Este es el texto de la caja";
            miCajaDeTexto.Width = 100;
            miCajaDeTexto.Height = 10;
            miCajaDeTexto.BackColor = Color.Aqua;
            miCajaDeTexto.Top = 5;
            miCajaDeTexto.Left = 5;
            
            

        }

      
    }
}
