namespace Ejercicio_6
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
            gbPoblaciones = new GroupBox();
            dgvPoblaciones = new DataGridView();
            gbPoblaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPoblaciones).BeginInit();
            SuspendLayout();
            // 
            // gbPoblaciones
            // 
            gbPoblaciones.Controls.Add(dgvPoblaciones);
            gbPoblaciones.Location = new Point(21, 27);
            gbPoblaciones.Name = "gbPoblaciones";
            gbPoblaciones.Size = new Size(619, 292);
            gbPoblaciones.TabIndex = 0;
            gbPoblaciones.TabStop = false;
            gbPoblaciones.Text = "Poblaciones";
            // 
            // dgvPoblaciones
            // 
            dgvPoblaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPoblaciones.Location = new Point(22, 35);
            dgvPoblaciones.Name = "dgvPoblaciones";
            dgvPoblaciones.RowHeadersWidth = 51;
            dgvPoblaciones.RowTemplate.Height = 29;
            dgvPoblaciones.Size = new Size(575, 237);
            dgvPoblaciones.TabIndex = 0;
            // 
            // FormPoblacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 337);
            Controls.Add(gbPoblaciones);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPoblacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPoblacion";
            gbPoblaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPoblaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbPoblaciones;
        private DataGridView dgvPoblaciones;
    }
}