namespace Ejemplo1b
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMensajeAyuda = new Label();
            btnBoton = new Button();
            txtMensaje = new TextBox();
            cboListado = new ComboBox();
            cboPersonas = new ComboBox();
            SuspendLayout();
            // 
            // lblMensajeAyuda
            // 
            lblMensajeAyuda.AutoSize = true;
            lblMensajeAyuda.ForeColor = SystemColors.ActiveCaptionText;
            lblMensajeAyuda.Location = new Point(12, 57);
            lblMensajeAyuda.Name = "lblMensajeAyuda";
            lblMensajeAyuda.Size = new Size(158, 15);
            lblMensajeAyuda.TabIndex = 0;
            lblMensajeAyuda.Text = "Esto es un mensaje de ayuda";
            // 
            // btnBoton
            // 
            btnBoton.Location = new Point(484, 11);
            btnBoton.Name = "btnBoton";
            btnBoton.Size = new Size(75, 23);
            btnBoton.TabIndex = 2;
            btnBoton.Text = "Mi Boton";
            btnBoton.UseVisualStyleBackColor = true;
            btnBoton.Click += btnBoton_Click;
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(12, 12);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(466, 23);
            txtMensaje.TabIndex = 1;
            // 
            // cboListado
            // 
            cboListado.FormattingEnabled = true;
            cboListado.Items.AddRange(new object[] { "primero", "segundo", "tercero", "cuarto ", "quinto" });
            cboListado.Location = new Point(12, 95);
            cboListado.Name = "cboListado";
            cboListado.Size = new Size(466, 23);
            cboListado.TabIndex = 3;
            // 
            // cboPersonas
            // 
            cboPersonas.FormattingEnabled = true;
            cboPersonas.Location = new Point(12, 137);
            cboPersonas.Name = "cboPersonas";
            cboPersonas.Size = new Size(466, 23);
            cboPersonas.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 186);
            Controls.Add(cboPersonas);
            Controls.Add(cboListado);
            Controls.Add(txtMensaje);
            Controls.Add(btnBoton);
            Controls.Add(lblMensajeAyuda);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensajeAyuda;
        private Button btnBoton;
        private TextBox txtMensaje;
        private ComboBox cboListado;
        private ComboBox cboPersonas;
    }
}