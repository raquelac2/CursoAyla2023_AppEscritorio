namespace Ejercicio_1WF
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
            lblID = new Label();
            txtID = new TextBox();
            lblMarca = new Label();
            txtMarca = new TextBox();
            lblModelo = new Label();
            txtModelo = new TextBox();
            btnAddCoche = new Button();
            cboCoches = new ComboBox();
            lblCoches = new Label();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(12, 14);
            lblID.Name = "lblID";
            lblID.Size = new Size(24, 15);
            lblID.TabIndex = 0;
            lblID.Text = "ID: ";
            lblID.Click += lblID_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(74, 11);
            txtID.Name = "txtID";
            txtID.Size = new Size(79, 23);
            txtID.TabIndex = 1;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(12, 46);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(46, 15);
            lblMarca.TabIndex = 2;
            lblMarca.Text = "Marca: ";
            lblMarca.Click += lblMarca_Click;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(74, 43);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(100, 23);
            txtMarca.TabIndex = 3;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(12, 78);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(51, 15);
            lblModelo.TabIndex = 4;
            lblModelo.Text = "Modelo:";
            lblModelo.Click += lblModelo_Click;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(74, 75);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 5;
            // 
            // btnAddCoche
            // 
            btnAddCoche.Location = new Point(74, 125);
            btnAddCoche.Name = "btnAddCoche";
            btnAddCoche.Size = new Size(100, 23);
            btnAddCoche.TabIndex = 6;
            btnAddCoche.Text = "Añadir Coche";
            btnAddCoche.UseVisualStyleBackColor = true;
            // 
            // cboCoches
            // 
            cboCoches.FormattingEnabled = true;
            cboCoches.Location = new Point(414, 11);
            cboCoches.Name = "cboCoches";
            cboCoches.Size = new Size(237, 23);
            cboCoches.TabIndex = 7;
            // 
            // lblCoches
            // 
            lblCoches.AutoSize = true;
            lblCoches.Location = new Point(356, 15);
            lblCoches.Name = "lblCoches";
            lblCoches.Size = new Size(52, 15);
            lblCoches.TabIndex = 8;
            lblCoches.Text = "Coches: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCoches);
            Controls.Add(cboCoches);
            Controls.Add(btnAddCoche);
            Controls.Add(txtModelo);
            Controls.Add(lblModelo);
            Controls.Add(txtMarca);
            Controls.Add(lblMarca);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Name = "Form1";
            Text = "Añadir coche";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private TextBox txtID;
        private Label lblMarca;
        private TextBox txtMarca;
        private Label lblModelo;
        private TextBox txtModelo;
        private Button btnAddCoche;
        private ComboBox cboCoches;
        private Label lblCoches;
    }
}