namespace Ejemplo_5
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
            btnGuardar = new Button();
            gboxEdicionCentro = new GroupBox();
            txtCentroId = new TextBox();
            lblId = new Label();
            txtCentro = new TextBox();
            lblNombre = new Label();
            btnActualizar = new Button();
            gbBorrado = new GroupBox();
            txtCentroIdABorrar = new TextBox();
            lblCentroIdABorrar = new Label();
            btnBorrar = new Button();
            gboxEdicionCentro.SuspendLayout();
            gbBorrado.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 273);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // gboxEdicionCentro
            // 
            gboxEdicionCentro.Controls.Add(txtCentroId);
            gboxEdicionCentro.Controls.Add(lblId);
            gboxEdicionCentro.Controls.Add(txtCentro);
            gboxEdicionCentro.Controls.Add(lblNombre);
            gboxEdicionCentro.Controls.Add(btnActualizar);
            gboxEdicionCentro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gboxEdicionCentro.ForeColor = Color.Red;
            gboxEdicionCentro.Location = new Point(12, 12);
            gboxEdicionCentro.Name = "gboxEdicionCentro";
            gboxEdicionCentro.Size = new Size(358, 112);
            gboxEdicionCentro.TabIndex = 6;
            gboxEdicionCentro.TabStop = false;
            gboxEdicionCentro.Text = "EDICIÓN DE CENTROS POKEMON";
            // 
            // txtCentroId
            // 
            txtCentroId.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCentroId.ForeColor = SystemColors.ActiveCaptionText;
            txtCentroId.Location = new Point(129, 54);
            txtCentroId.Name = "txtCentroId";
            txtCentroId.Size = new Size(100, 23);
            txtCentroId.TabIndex = 10;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.ForeColor = SystemColors.ActiveCaptionText;
            lblId.Location = new Point(144, 36);
            lblId.Name = "lblId";
            lblId.Size = new Size(56, 15);
            lblId.TabIndex = 9;
            lblId.Text = "CentroId:";
            // 
            // txtCentro
            // 
            txtCentro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCentro.ForeColor = SystemColors.ActiveCaptionText;
            txtCentro.Location = new Point(10, 54);
            txtCentro.Name = "txtCentro";
            txtCentro.Size = new Size(100, 23);
            txtCentro.TabIndex = 8;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.ActiveCaptionText;
            lblNombre.Location = new Point(10, 36);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(110, 15);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre del centro:";
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizar.ForeColor = SystemColors.ActiveCaptionText;
            btnActualizar.Location = new Point(273, 54);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // gbBorrado
            // 
            gbBorrado.Controls.Add(btnBorrar);
            gbBorrado.Controls.Add(txtCentroIdABorrar);
            gbBorrado.Controls.Add(lblCentroIdABorrar);
            gbBorrado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbBorrado.ForeColor = Color.Green;
            gbBorrado.Location = new Point(12, 139);
            gbBorrado.Name = "gbBorrado";
            gbBorrado.Size = new Size(358, 100);
            gbBorrado.TabIndex = 7;
            gbBorrado.TabStop = false;
            gbBorrado.Text = "BORRADO DE CENTROS POKEMON";
            // 
            // txtCentroIdABorrar
            // 
            txtCentroIdABorrar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCentroIdABorrar.ForeColor = SystemColors.ActiveCaptionText;
            txtCentroIdABorrar.Location = new Point(10, 51);
            txtCentroIdABorrar.Name = "txtCentroIdABorrar";
            txtCentroIdABorrar.Size = new Size(100, 23);
            txtCentroIdABorrar.TabIndex = 12;
            // 
            // lblCentroIdABorrar
            // 
            lblCentroIdABorrar.AutoSize = true;
            lblCentroIdABorrar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCentroIdABorrar.ForeColor = SystemColors.ActiveCaptionText;
            lblCentroIdABorrar.Location = new Point(10, 33);
            lblCentroIdABorrar.Name = "lblCentroIdABorrar";
            lblCentroIdABorrar.Size = new Size(56, 15);
            lblCentroIdABorrar.TabIndex = 11;
            lblCentroIdABorrar.Text = "CentroId:";
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrar.ForeColor = Color.Black;
            btnBorrar.Location = new Point(139, 53);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 13;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 308);
            Controls.Add(gbBorrado);
            Controls.Add(gboxEdicionCentro);
            Controls.Add(btnGuardar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gboxEdicionCentro.ResumeLayout(false);
            gboxEdicionCentro.PerformLayout();
            gbBorrado.ResumeLayout(false);
            gbBorrado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGuardar;
        private GroupBox gboxEdicionCentro;
        private TextBox txtCentroId;
        private Label lblId;
        private TextBox txtCentro;
        private Label lblNombre;
        private Button btnActualizar;
        private GroupBox gbBorrado;
        private TextBox txtCentroIdABorrar;
        private Label lblCentroIdABorrar;
        private Button btnBorrar;
    }
}