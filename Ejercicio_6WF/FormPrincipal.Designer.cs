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
            lblProvincia = new Label();
            cboProvincia = new ComboBox();
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
            // lblProvincia
            // 
            lblProvincia.AutoSize = true;
            lblProvincia.Location = new Point(293, 9);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.Size = new Size(62, 15);
            lblProvincia.TabIndex = 2;
            lblProvincia.Text = "Provincia: ";
            // 
            // cboProvincia
            // 
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(366, 9);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(184, 23);
            cboProvincia.TabIndex = 3;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(588, 398);
            Controls.Add(cboProvincia);
            Controls.Add(lblProvincia);
            Controls.Add(cboComunidad);
            Controls.Add(lblComunidad);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblComunidad;
        private ComboBox cboComunidad;
        private Label lblProvincia;
        private ComboBox cboProvincia;
    }
}