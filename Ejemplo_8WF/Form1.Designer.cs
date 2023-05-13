namespace Ejemplo_8WF
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
            miPrimerControl1 = new MiPrimerControl();
            miPrimerControl2 = new MiPrimerControl();
            button1 = new Button();
            txtRangoFechas = new TextBox();
            txtRangoFechas2 = new TextBox();
            SuspendLayout();
            // 
            // miPrimerControl1
            // 
            miPrimerControl1.FecFin = new DateTime(0L);
            miPrimerControl1.FecInicio = new DateTime(0L);
            miPrimerControl1.Location = new Point(26, 12);
            miPrimerControl1.Name = "miPrimerControl1";
            miPrimerControl1.Size = new Size(371, 246);
            miPrimerControl1.TabIndex = 0;
            miPrimerControl1.Tag = "ControlUsuario1";
            // 
            // miPrimerControl2
            // 
            miPrimerControl2.FecFin = new DateTime(0L);
            miPrimerControl2.FecInicio = new DateTime(0L);
            miPrimerControl2.Location = new Point(448, 12);
            miPrimerControl2.Name = "miPrimerControl2";
            miPrimerControl2.Size = new Size(678, 246);
            miPrimerControl2.TabIndex = 1;
            miPrimerControl2.Tag = "ControlUsuario2";
            // 
            // button1
            // 
            button1.Location = new Point(322, 371);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtRangoFechas
            // 
            txtRangoFechas.Location = new Point(26, 294);
            txtRangoFechas.Name = "txtRangoFechas";
            txtRangoFechas.Size = new Size(257, 23);
            txtRangoFechas.TabIndex = 3;
            // 
            // txtRangoFechas2
            // 
            txtRangoFechas2.Location = new Point(448, 294);
            txtRangoFechas2.Name = "txtRangoFechas2";
            txtRangoFechas2.Size = new Size(257, 23);
            txtRangoFechas2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRangoFechas2);
            Controls.Add(txtRangoFechas);
            Controls.Add(button1);
            Controls.Add(miPrimerControl2);
            Controls.Add(miPrimerControl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MiPrimerControl miPrimerControl1;
        private MiPrimerControl miPrimerControl2;
        private Button button1;
        private TextBox txtRangoFechas;
        private TextBox txtRangoFechas2;
    }
}