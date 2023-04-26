namespace Ejemplo_2
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
            lstbMiLista = new ListBox();
            btnVer = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // lstbMiLista
            // 
            lstbMiLista.ColumnWidth = 50;
            lstbMiLista.FormattingEnabled = true;
            lstbMiLista.ItemHeight = 15;
            lstbMiLista.Items.AddRange(new object[] { "Uno", "Dos", "Tres", "Cuatro", "Cinco" });
            lstbMiLista.Location = new Point(107, 42);
            lstbMiLista.MultiColumn = true;
            lstbMiLista.Name = "lstbMiLista";
            lstbMiLista.SelectionMode = SelectionMode.MultiSimple;
            lstbMiLista.Size = new Size(84, 49);
            lstbMiLista.TabIndex = 0;
            lstbMiLista.SelectedIndexChanged += lstbMiLista_SelectedIndexChanged;
            lstbMiLista.Enter += lstbMiLista_Enter;
            lstbMiLista.Leave += lstbMiLista_Leave;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(124, 139);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(95, 23);
            btnVer.TabIndex = 1;
            btnVer.Text = "Ver seleccion";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(330, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(btnVer);
            Controls.Add(lstbMiLista);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstbMiLista;
        private Button btnVer;
        private TextBox textBox1;
    }
}