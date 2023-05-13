namespace Ejercicio_6WF
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
            gbMunicipios = new GroupBox();
            dgvMunicipios = new DataGridView();
            gbProvincias.SuspendLayout();
            gbMunicipios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMunicipios).BeginInit();
            SuspendLayout();
            // 
            // lblComunidad
            // 
            lblComunidad.AutoSize = true;
            lblComunidad.Location = new Point(12, 9);
            lblComunidad.Name = "lblComunidad";
            lblComunidad.Size = new Size(76, 15);
            lblComunidad.TabIndex = 0;
            lblComunidad.Text = "Comunidad: ";
            // 
            // cboComunidad
            // 
            cboComunidad.FormattingEnabled = true;
            cboComunidad.Location = new Point(94, 9);
            cboComunidad.Name = "cboComunidad";
            cboComunidad.Size = new Size(168, 23);
            cboComunidad.TabIndex = 1;
            // 
            // gbProvincias
            // 
            gbProvincias.Controls.Add(lbProvincias);
            gbProvincias.Location = new Point(24, 64);
            gbProvincias.Name = "gbProvincias";
            gbProvincias.Size = new Size(238, 312);
            gbProvincias.TabIndex = 2;
            gbProvincias.TabStop = false;
            gbProvincias.Text = "Provincias";
            // 
            // lbProvincias
            // 
            lbProvincias.FormattingEnabled = true;
            lbProvincias.ItemHeight = 15;
            lbProvincias.Location = new Point(12, 17);
            lbProvincias.Name = "lbProvincias";
            lbProvincias.Size = new Size(212, 289);
            lbProvincias.TabIndex = 0;
            lbProvincias.SelectedIndexChanged += lbProvincias_SelectedIndexChanged;
            // 
            // gbMunicipios
            // 
            gbMunicipios.Controls.Add(dgvMunicipios);
            gbMunicipios.Location = new Point(285, 64);
            gbMunicipios.Name = "gbMunicipios";
            gbMunicipios.Size = new Size(269, 312);
            gbMunicipios.TabIndex = 3;
            gbMunicipios.TabStop = false;
            gbMunicipios.Text = "Municipios";
            // 
            // dgvMunicipios
            // 
            dgvMunicipios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMunicipios.Location = new Point(6, 17);
            dgvMunicipios.Name = "dgvMunicipios";
            dgvMunicipios.RowTemplate.Height = 25;
            dgvMunicipios.Size = new Size(257, 289);
            dgvMunicipios.TabIndex = 0;
            dgvMunicipios.CellDoubleClick += dgvMunicipios_CellDoubleClick;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(588, 398);
            Controls.Add(gbMunicipios);
            Controls.Add(gbProvincias);
            Controls.Add(cboComunidad);
            Controls.Add(lblComunidad);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            gbProvincias.ResumeLayout(false);
            gbMunicipios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMunicipios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblComunidad;
        private ComboBox cboComunidad;
        private GroupBox gbProvincias;
        private ListBox lbProvincias;
        private GroupBox gbMunicipios;
        private DataGridView dgvMunicipios;
    }
}