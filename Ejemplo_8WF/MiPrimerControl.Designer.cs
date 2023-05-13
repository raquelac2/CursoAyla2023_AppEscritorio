namespace Ejemplo_8WF
{
    partial class MiPrimerControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            gbFechas = new GroupBox();
            txtFechaFin = new TextBox();
            lblFechaFin = new Label();
            txtFechaInicio = new TextBox();
            lblFechaInicio = new Label();
            mcCalendario = new MonthCalendar();
            gbFechas.SuspendLayout();
            SuspendLayout();
            // 
            // gbFechas
            // 
            gbFechas.Controls.Add(txtFechaFin);
            gbFechas.Controls.Add(lblFechaFin);
            gbFechas.Controls.Add(txtFechaInicio);
            gbFechas.Controls.Add(lblFechaInicio);
            gbFechas.Controls.Add(mcCalendario);
            gbFechas.Location = new Point(15, 14);
            gbFechas.Name = "gbFechas";
            gbFechas.Size = new Size(387, 267);
            gbFechas.TabIndex = 5;
            gbFechas.TabStop = false;
            gbFechas.Text = "Rango de fechas";
            // 
            // txtFechaFin
            // 
            txtFechaFin.Location = new Point(245, 124);
            txtFechaFin.Name = "txtFechaFin";
            txtFechaFin.Size = new Size(100, 23);
            txtFechaFin.TabIndex = 9;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Location = new Point(245, 106);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(29, 15);
            lblFechaFin.TabIndex = 8;
            lblFechaFin.Text = "Fin: ";
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.Location = new Point(245, 70);
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.Size = new Size(100, 23);
            txtFechaInicio.TabIndex = 7;
            txtFechaInicio.TextChanged += txtFechaInicio_TextChanged;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(245, 52);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(42, 15);
            lblFechaInicio.TabIndex = 6;
            lblFechaInicio.Text = "Inicio: ";
            // 
            // mcCalendario
            // 
            mcCalendario.Location = new Point(41, 52);
            mcCalendario.Name = "mcCalendario";
            mcCalendario.TabIndex = 5;
            mcCalendario.DateChanged += mcCalendario_DateChanged;
            // 
            // MiPrimerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbFechas);
            Name = "MiPrimerControl";
            Size = new Size(678, 362);
            gbFechas.ResumeLayout(false);
            gbFechas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbFechas;
        private TextBox txtFechaFin;
        private Label lblFechaFin;
        private TextBox txtFechaInicio;
        private Label lblFechaInicio;
        private MonthCalendar mcCalendario;
    }
}
