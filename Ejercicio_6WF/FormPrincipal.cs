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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            Comunidad miComunidad = new Comunidad();
            List<Comunidad> misComunidades = miComunidad.GetComunidades_Negocio();

            misComunidades.Insert(0, miComunidad);

            cboComunidad.DataSource = misComunidades;
            cboComunidad.DisplayMember = "Nombre";
            cboComunidad.ValueMember = "Id";
        }

        private void lbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Provincia provinciaSeleccionada = (Provincia)lbProvincias.SelectedItem;
            Municipio miMunicipio = new Municipio();
            List<Municipio> municipios = miMunicipio.GetMunicipiosPorProvinciaId_Negocio(provinciaSeleccionada.Id);
            dgvMunicipios.DataSource = municipios;

        }

        private void dgvMunicipios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvMunicipios.SelectedRows[0];
            Municipio miMunicipio = (Municipio)filaSeleccionada.DataBoundItem;

            FormPoblacion frmPoblacion = new FormPoblacion(miMunicipio.Id);
            frmPoblacion.ShowDialog();  
        }
    }
}
