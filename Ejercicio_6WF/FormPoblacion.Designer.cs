namespace Ejercicio_6WF
{
    partial class FormPoblacion
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
            gbPoblacion = new GroupBox();
            dgvPoblaciones = new DataGridView();
            gbPoblacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPoblaciones).BeginInit();
            SuspendLayout();
            // 
            // gbPoblacion
            // 
            gbPoblacion.Controls.Add(dgvPoblaciones);
            gbPoblacion.Location = new Point(26, 12);
            gbPoblacion.Name = "gbPoblacion";
            gbPoblacion.Size = new Size(434, 341);
            gbPoblacion.TabIndex = 0;
            gbPoblacion.TabStop = false;
            gbPoblacion.Text = "Poblaciones";
            // 
            // dgvPoblaciones
            // 
            dgvPoblaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPoblaciones.Location = new Point(6, 22);
            dgvPoblaciones.Name = "dgvPoblaciones";
            dgvPoblaciones.RowTemplate.Height = 25;
            dgvPoblaciones.Size = new Size(422, 313);
            dgvPoblaciones.TabIndex = 0;
            // 
            // FormPoblacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(500, 365);
            Controls.Add(gbPoblacion);
            Name = "FormPoblacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPoblacion";
            gbPoblacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPoblaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbPoblacion;
        private DataGridView dgvPoblaciones;
    }
}