using _LIBGeoClases.NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_6WF
{
    public partial class FormPoblacion : Form
    {
        public int MunicipioID { get; set; }
        public FormPoblacion(int IDMunicipio)
        {
            InitializeComponent();

            MunicipioID = IDMunicipio;

            Poblacion miPoblacion = new Poblacion();
            List<Poblacion> poblaciones = miPoblacion.GetPoblacionPorMunicipioId_Negocio(MunicipioID);
            dgvPoblaciones.DataSource = poblaciones;
        }


    }
}
