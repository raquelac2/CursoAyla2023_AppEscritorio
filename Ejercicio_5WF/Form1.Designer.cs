namespace Ejercicio_5WF
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
            statusStrip1 = new StatusStrip();
            ProgressBar1 = new ToolStripProgressBar();
            lblProgreso = new ToolStripStatusLabel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblCarpeta = new Label();
            txtCarpeta = new TextBox();
            btnCarpeta = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            btnCargarFicheros = new Button();
            txtFicheros = new TextBox();
            lblFicheros = new Label();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { ProgressBar1, lblProgreso });
            statusStrip1.Location = new Point(0, 339);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.Professional;
            statusStrip1.Size = new Size(617, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // ProgressBar1
            // 
            ProgressBar1.Name = "ProgressBar1";
            ProgressBar1.Size = new Size(100, 16);
            // 
            // lblProgreso
            // 
            lblProgreso.Name = "lblProgreso";
            lblProgreso.Size = new Size(25, 17);
            lblProgreso.Text = "xxx";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // lblCarpeta
            // 
            lblCarpeta.AutoSize = true;
            lblCarpeta.BackColor = SystemColors.ControlLightLight;
            lblCarpeta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCarpeta.Location = new Point(13, 9);
            lblCarpeta.Name = "lblCarpeta";
            lblCarpeta.Size = new Size(54, 15);
            lblCarpeta.TabIndex = 1;
            lblCarpeta.Text = "Carpeta: ";
            // 
            // txtCarpeta
            // 
            txtCarpeta.BackColor = Color.White;
            txtCarpeta.Location = new Point(13, 28);
            txtCarpeta.Name = "txtCarpeta";
            txtCarpeta.ReadOnly = true;
            txtCarpeta.Size = new Size(464, 23);
            txtCarpeta.TabIndex = 2;
            txtCarpeta.TextChanged += txtCarpeta_TextChanged;
            // 
            // btnCarpeta
            // 
            btnCarpeta.Location = new Point(482, 27);
            btnCarpeta.Name = "btnCarpeta";
            btnCarpeta.Size = new Size(24, 23);
            btnCarpeta.TabIndex = 3;
            btnCarpeta.Text = "...";
            btnCarpeta.UseVisualStyleBackColor = true;
            btnCarpeta.Click += btnCarpeta_Click;
            // 
            // btnCargarFicheros
            // 
            btnCargarFicheros.Enabled = false;
            btnCargarFicheros.Location = new Point(525, 27);
            btnCargarFicheros.Name = "btnCargarFicheros";
            btnCargarFicheros.Size = new Size(75, 23);
            btnCargarFicheros.TabIndex = 4;
            btnCargarFicheros.Text = "Cargar";
            btnCargarFicheros.UseVisualStyleBackColor = true;
            btnCargarFicheros.Click += btnCargarFicheros_Click;
            // 
            // txtFicheros
            // 
            txtFicheros.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtFicheros.Location = new Point(13, 123);
            txtFicheros.Multiline = true;
            txtFicheros.Name = "txtFicheros";
            txtFicheros.ScrollBars = ScrollBars.Vertical;
            txtFicheros.Size = new Size(587, 213);
            txtFicheros.TabIndex = 5;
            // 
            // lblFicheros
            // 
            lblFicheros.AutoSize = true;
            lblFicheros.BackColor = Color.White;
            lblFicheros.Location = new Point(13, 104);
            lblFicheros.Name = "lblFicheros";
            lblFicheros.Size = new Size(57, 15);
            lblFicheros.TabIndex = 6;
            lblFicheros.Text = "Ficheros: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(617, 361);
            Controls.Add(lblFicheros);
            Controls.Add(txtFicheros);
            Controls.Add(btnCargarFicheros);
            Controls.Add(btnCarpeta);
            Controls.Add(txtCarpeta);
            Controls.Add(lblCarpeta);
            Controls.Add(statusStrip1);
            Name = "Form1";
            Text = "Form1";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripProgressBar ProgressBar1;
        private ToolStripStatusLabel lblProgreso;
        private Label lblCarpeta;
        private TextBox txtCarpeta;
        private Button btnCarpeta;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnCargarFicheros;
        private TextBox txtFicheros;
        private Label lblFicheros;
    }
}