namespace Ejercicio_2
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
            txtResultado = new TextBox();
            btn1 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnMas = new Button();
            btnMenos = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            btnIgual = new Button();
            btnBorrar = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(16, 8);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(240, 23);
            txtResultado.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.Location = new Point(16, 77);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 23);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Location = new Point(97, 106);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 23);
            btn5.TabIndex = 2;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Location = new Point(16, 106);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 23);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Location = new Point(181, 77);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 23);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button3_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(97, 77);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 23);
            btn2.TabIndex = 5;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Location = new Point(181, 106);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 23);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Location = new Point(16, 135);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 23);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Location = new Point(97, 135);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 23);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Location = new Point(181, 135);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 23);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Location = new Point(16, 164);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 21);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btnMas
            // 
            btnMas.Location = new Point(97, 164);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(75, 23);
            btnMas.TabIndex = 11;
            btnMas.Text = "+";
            btnMas.UseVisualStyleBackColor = true;
            // 
            // btnMenos
            // 
            btnMenos.Location = new Point(181, 164);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(75, 23);
            btnMenos.TabIndex = 12;
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(97, 191);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 23);
            btnMultiplicar.TabIndex = 13;
            btnMultiplicar.Text = "x";
            btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(16, 191);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 23);
            btnDividir.TabIndex = 14;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(13, 220);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(243, 23);
            btnIgual.TabIndex = 15;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(181, 191);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 16;
            btnBorrar.Text = "CE";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 353);
            Controls.Add(btnBorrar);
            Controls.Add(btnIgual);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnMenos);
            Controls.Add(btnMas);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn1);
            Controls.Add(txtResultado);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btn1;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnMas;
        private Button btnMenos;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnIgual;
        private Button btnBorrar;
    }
}