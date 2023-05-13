﻿using _LIBGeoClases.NEGOCIO;
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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            Comunidad miComunidad = new Comunidad();
            List<Comunidad> Comunidades = miComunidad.GetComunidades_Negocio();

            Comunidades.Insert(0, miComunidad);

            cboComunidad.DataSource = Comunidades;
            cboComunidad.DisplayMember = "Nombre";
            cboComunidad.ValueMember = "Id";
        }

        private void cboComunidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Comunidad comunidadSeleccionada = (Comunidad)cboComunidad.SelectedItem;

            Provincia miProvincia = new Provincia();
            List<Provincia> Provincias = miProvincia.GetProvinciasPorComunidadId_Negocio(comunidadSeleccionada.Id);
            lbProvincias.DataSource = Provincias;
            lbProvincias.DisplayMember = "Nombre";
            lbProvincias.ValueMember = "Id";
        }

        private void lbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Provincia ProvinciaSeleccionada = (Provincia)lbProvincias.SelectedItem;

            Municipio miMunicipio = new Municipio();
            List<Municipio> Municipios = miMunicipio.GetMunicipiosPorProvinciaId_Negocio(ProvinciaSeleccionada.Id);
            dgvMunicipios.DataSource = Municipios;
        }

        private void dgvMunicipios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvMunicipios.SelectedRows[0];
            Municipio miMunipio = (Municipio)filaSeleccionada.DataBoundItem;

            FormPoblacion frmPoblacion = new FormPoblacion(miMunipio.Id);
            frmPoblacion.ShowDialog();
        }
    }
}
