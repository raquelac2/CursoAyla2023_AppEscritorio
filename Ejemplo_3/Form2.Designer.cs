namespace Ejemplo_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            btnNuevoFormulario = new Button();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            abrirVentanaToolStripMenuItem = new ToolStripMenuItem();
            nuevaVentanaToolStripMenuItem = new ToolStripMenuItem();
            editarTextoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNuevoFormulario
            // 
            btnNuevoFormulario.Location = new Point(59, 22);
            btnNuevoFormulario.Name = "btnNuevoFormulario";
            btnNuevoFormulario.Size = new Size(119, 23);
            btnNuevoFormulario.TabIndex = 0;
            btnNuevoFormulario.Text = "Ver Formulario 1";
            btnNuevoFormulario.UseVisualStyleBackColor = true;
            btnNuevoFormulario.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(234, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 168);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { abrirVentanaToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // abrirVentanaToolStripMenuItem
            // 
            abrirVentanaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaVentanaToolStripMenuItem, editarTextoToolStripMenuItem });
            abrirVentanaToolStripMenuItem.Name = "abrirVentanaToolStripMenuItem";
            abrirVentanaToolStripMenuItem.Size = new Size(90, 20);
            abrirVentanaToolStripMenuItem.Text = "Abrir Ventana";
            // 
            // nuevaVentanaToolStripMenuItem
            // 
            nuevaVentanaToolStripMenuItem.Name = "nuevaVentanaToolStripMenuItem";
            nuevaVentanaToolStripMenuItem.Size = new Size(153, 22);
            nuevaVentanaToolStripMenuItem.Text = "Nueva ventana";
            nuevaVentanaToolStripMenuItem.Click += nuevaVentanaToolStripMenuItem_Click;
            // 
            // editarTextoToolStripMenuItem
            // 
            editarTextoToolStripMenuItem.Name = "editarTextoToolStripMenuItem";
            editarTextoToolStripMenuItem.Size = new Size(153, 22);
            editarTextoToolStripMenuItem.Text = "Editar texto";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btnNuevoFormulario);
            groupBox1.Location = new Point(28, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(59, 77);
            button1.Name = "button1";
            button1.Size = new Size(119, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(59, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(119, 23);
            textBox1.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevoFormulario;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem abrirVentanaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem nuevaVentanaToolStripMenuItem;
        private ToolStripMenuItem editarTextoToolStripMenuItem;
        private StatusStrip statusStrip1;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBox1;
    }
}