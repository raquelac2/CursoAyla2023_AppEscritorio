namespace Ejemplo_3
{
    partial class FormularioMDI
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
            menuStrip1 = new MenuStrip();
            formulariosToolStripMenuItem = new ToolStripMenuItem();
            mnuFormulario1 = new ToolStripMenuItem();
            mnuFormulario2 = new ToolStripMenuItem();
            mnuSalir = new ToolStripMenuItem();
            formulario3ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { formulariosToolStripMenuItem, mnuSalir });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // formulariosToolStripMenuItem
            // 
            formulariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuFormulario1, mnuFormulario2, formulario3ToolStripMenuItem });
            formulariosToolStripMenuItem.MergeIndex = 0;
            formulariosToolStripMenuItem.Name = "formulariosToolStripMenuItem";
            formulariosToolStripMenuItem.Size = new Size(82, 20);
            formulariosToolStripMenuItem.Text = "Formularios";
            // 
            // mnuFormulario1
            // 
            mnuFormulario1.Name = "mnuFormulario1";
            mnuFormulario1.Size = new Size(180, 22);
            mnuFormulario1.Text = "Formulario 1";
            mnuFormulario1.Click += mnuFormulario1_Click;
            // 
            // mnuFormulario2
            // 
            mnuFormulario2.Name = "mnuFormulario2";
            mnuFormulario2.Size = new Size(180, 22);
            mnuFormulario2.Text = "Formulario 2";
            mnuFormulario2.Click += mnuFormulario2_Click;
            // 
            // mnuSalir
            // 
            mnuSalir.MergeIndex = 2;
            mnuSalir.Name = "mnuSalir";
            mnuSalir.Size = new Size(41, 20);
            mnuSalir.Text = "Salir";
            mnuSalir.Click += mnuSalir_Click;
            // 
            // formulario3ToolStripMenuItem
            // 
            formulario3ToolStripMenuItem.Name = "formulario3ToolStripMenuItem";
            formulario3ToolStripMenuItem.Size = new Size(180, 22);
            formulario3ToolStripMenuItem.Text = "Formulario 3";
            formulario3ToolStripMenuItem.Click += formulario3ToolStripMenuItem_Click;
            // 
            // FormularioMDI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormularioMDI";
            Text = "FormularioMDI";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem formulariosToolStripMenuItem;
        private ToolStripMenuItem mnuFormulario1;
        private ToolStripMenuItem mnuFormulario2;
        private ToolStripMenuItem mnuSalir;
        private ToolStripMenuItem formulario3ToolStripMenuItem;
    }
}