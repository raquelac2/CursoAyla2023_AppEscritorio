namespace Ejemplo_4WF
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
            btnGenerar = new Button();
            dgvDatosPersonas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDatosPersonas).BeginInit();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(74, 50);
            btnGenerar.Margin = new Padding(4, 5, 4, 5);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(107, 38);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // dgvDatosPersonas
            // 
            dgvDatosPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosPersonas.Location = new Point(74, 135);
            dgvDatosPersonas.Margin = new Padding(4, 5, 4, 5);
            dgvDatosPersonas.Name = "dgvDatosPersonas";
            dgvDatosPersonas.RowHeadersWidth = 62;
            dgvDatosPersonas.RowTemplate.Height = 25;
            dgvDatosPersonas.Size = new Size(1041, 502);
            dgvDatosPersonas.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(dgvDatosPersonas);
            Controls.Add(btnGenerar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatosPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerar;
        private DataGridView dgvDatosPersonas;
    }
}