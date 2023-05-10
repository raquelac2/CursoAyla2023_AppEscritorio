namespace Ejemplo_7WF
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            txtNombre = new TextBox();
            txtApellidos = new TextBox();
            txtDireccion = new TextBox();
            txtEmail = new TextBox();
            lblNombre = new Label();
            lblApellidos = new Label();
            lblDireccion = new Label();
            lblEmail = new Label();
            btnAceptar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(194, 23);
            txtNombre.TabIndex = 0;
            txtNombre.Tag = "Nombre";
            txtNombre.Validating += CampoObligatorio_Validating;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(12, 83);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(194, 23);
            txtApellidos.TabIndex = 1;
            txtApellidos.Tag = "Apellidos";
            txtApellidos.Validating += CampoObligatorio_Validating;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(303, 27);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(194, 23);
            txtDireccion.TabIndex = 2;
            txtDireccion.Tag = "Dirección";
            txtDireccion.Validating += CampoObligatorio_Validating;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(303, 83);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(194, 23);
            txtEmail.TabIndex = 3;
            txtEmail.Tag = "Email";
            txtEmail.Validating += CampoObligatorio_Validating;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(57, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre: ";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(12, 65);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(62, 15);
            lblApellidos.TabIndex = 5;
            lblApellidos.Text = "Apellidos: ";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(303, 9);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(63, 15);
            lblDireccion.TabIndex = 6;
            lblDireccion.Text = "Dirección: ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(303, 65);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email: ";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(422, 147);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(lblEmail);
            Controls.Add(lblDireccion);
            Controls.Add(lblApellidos);
            Controls.Add(lblNombre);
            Controls.Add(txtEmail);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombre);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellidos;
        private TextBox txtDireccion;
        private TextBox txtEmail;
        private Label lblNombre;
        private Label lblApellidos;
        private Label lblDireccion;
        private Label lblEmail;
        private Button btnAceptar;
        private ErrorProvider errorProvider1;
    }
}