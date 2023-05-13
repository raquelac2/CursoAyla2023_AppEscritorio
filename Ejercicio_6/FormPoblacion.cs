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

namespace Ejercicio_6
{
    public partial class FormPoblacion : Form
    {
        public int MunicipioId { get; set; }

        public FormPoblacion(int IDMunicipio)
        {
            InitializeComponent();

            MunicipioId = IDMunicipio;
            Poblacion miPoblacion = new Poblacion();
            List<Poblacion> Poblaciones = miPoblacion.GetPoblacionesPorMunicipioId_Negocio(MunicipioId);
            dgvPoblaciones.DataSource = Poblaciones;
        }
    }
}
