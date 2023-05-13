namespace Ejercicio_6
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblComunidad = new Label();
            cboComunidad = new ComboBox();
            gbProvincias = new GroupBox();
            lbProvincias = new ListBox();
            gpMunicipios = new GroupBox();
            dgvMunicipios = new DataGridView();
            gbProvincias.SuspendLayout();
            gpMunicipios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMunicipios).BeginInit();
            SuspendLayout();
            // 
            // lblComunidad
            // 
            lblComunidad.AutoSize = true;
            lblComunidad.Location = new Point(14, 15);
            lblComunidad.Name = "lblComunidad";
            lblComunidad.Size = new Size(93, 20);
            lblComunidad.TabIndex = 0;
            lblComunidad.Text = "Comunidad: ";
            // 
            // cboComunidad
            // 
            cboComunidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboComunidad.FormattingEnabled = true;
            cboComunidad.Location = new Point(122, 12);
            cboComunidad.Name = "cboComunidad";
            cboComunidad.Size = new Size(272, 28);
            cboComunidad.TabIndex = 1;
            cboComunidad.SelectedIndexChanged += cboComunidad_SelectedIndexChanged;
            // 
            // gbProvincias
            // 
            gbProvincias.Controls.Add(lbProvincias);
            gbProvincias.Location = new Point(14, 58);
            gbProvincias.Name = "gbProvincias";
            gbProvincias.Size = new Size(294, 419);
            gbProvincias.TabIndex = 2;
            gbProvincias.TabStop = false;
            gbProvincias.Text = "Provincias";
            // 
            // lbProvincias
            // 
            lbProvincias.FormattingEnabled = true;
            lbProvincias.ItemHeight = 20;
            lbProvincias.Location = new Point(23, 36);
            lbProvincias.Name = "lbProvincias";
            lbProvincias.Size = new Size(253, 364);
            lbProvincias.TabIndex = 0;
            lbProvincias.SelectedIndexChanged += lbProvincias_SelectedIndexChanged;
            // 
            // gpMunicipios
            // 
            gpMunicipios.Controls.Add(dgvMunicipios);
            gpMunicipios.Location = new Point(324, 58);
            gpMunicipios.Name = "gpMunicipios";
            gpMunicipios.Size = new Size(569, 419);
            gpMunicipios.TabIndex = 3;
            gpMunicipios.TabStop = false;
            gpMunicipios.Text = "Municipios";
            // 
            // dgvMunicipios
            // 
            dgvMunicipios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMunicipios.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvMunicipios.Location = new Point(19, 35);
            dgvMunicipios.MultiSelect = false;
            dgvMunicipios.Name = "dgvMunicipios";
            dgvMunicipios.RowHeadersWidth = 51;
            dgvMunicipios.RowTemplate.Height = 29;
            dgvMunicipios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMunicipios.Size = new Size(531, 365);
            dgvMunicipios.TabIndex = 0;
            dgvMunicipios.CellDoubleClick += dgvMunicipios_CellDoubleClick;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 489);
            Controls.Add(gpMunicipios);
            Controls.Add(gbProvincias);
            Controls.Add(cboComunidad);
            Controls.Add(lblComunidad);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            gbProvincias.ResumeLayout(false);
            gpMunicipios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMunicipios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblComunidad;
        private ComboBox cboComunidad;
        private GroupBox gbProvincias;
        private ListBox lbProvincias;
        private GroupBox gpMunicipios;
        private DataGridView dgvMunicipios;
    }
}