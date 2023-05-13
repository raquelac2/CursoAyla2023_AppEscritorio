namespace Ejercicio_6
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
            btnEntrar = new Button();
            pictureBox1 = new PictureBox();
            lblNombre = new Label();
            lblVersion = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(63, 377);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(248, 43);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Konosuba2;
            pictureBox1.Location = new Point(21, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(333, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.Navy;
            lblNombre.Location = new Point(40, 251);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(294, 32);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Consulta de poblaciones";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblVersion.ForeColor = Color.Navy;
            lblVersion.Location = new Point(132, 310);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(111, 25);
            lblVersion.TabIndex = 3;
            lblVersion.Text = "Versión 1.0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 450);
            Controls.Add(lblVersion);
            Controls.Add(lblNombre);
            Controls.Add(pictureBox1);
            Controls.Add(btnEntrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private PictureBox pictureBox1;
        private Label lblNombre;
        private Label lblVersion;
    }
}