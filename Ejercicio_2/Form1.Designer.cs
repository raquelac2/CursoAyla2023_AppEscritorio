﻿namespace Ejercicio_2
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
            btnDecimal = new Button();
            textBox1 = new TextBox();
            txtAcumulado = new TextBox();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.White;
            txtResultado.BorderStyle = BorderStyle.FixedSingle;
            txtResultado.ForeColor = SystemColors.ActiveCaptionText;
            txtResultado.Location = new Point(17, 29);
            txtResultado.MaxLength = 20;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(240, 23);
            txtResultado.TabIndex = 18;
            txtResultado.TabStop = false;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btn1
            // 
            btn1.Location = new Point(17, 97);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 23);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(98, 126);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 23);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(17, 126);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 23);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(182, 97);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 23);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(98, 97);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 23);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(182, 126);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 23);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(17, 155);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 23);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(98, 155);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 23);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(182, 155);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 23);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(17, 184);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 21);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnMas
            // 
            btnMas.Location = new Point(98, 184);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(75, 23);
            btnMas.TabIndex = 11;
            btnMas.Text = "+";
            btnMas.UseVisualStyleBackColor = true;
            btnMas.Click += btnMas_Click;
            // 
            // btnMenos
            // 
            btnMenos.Location = new Point(182, 184);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(75, 23);
            btnMenos.TabIndex = 12;
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = true;
            btnMenos.Click += btnMenos_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(98, 211);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 23);
            btnMultiplicar.TabIndex = 14;
            btnMultiplicar.Text = "x";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(17, 211);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 23);
            btnDividir.TabIndex = 13;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(98, 240);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(159, 23);
            btnIgual.TabIndex = 17;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(182, 211);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 15;
            btnBorrar.Text = "CE";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Location = new Point(17, 240);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(75, 23);
            btnDecimal.TabIndex = 16;
            btnDecimal.Text = ",";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(156, 58);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 16);
            textBox1.TabIndex = 19;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // txtAcumulado
            // 
            txtAcumulado.BorderStyle = BorderStyle.None;
            txtAcumulado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAcumulado.Location = new Point(17, 58);
            txtAcumulado.Name = "txtAcumulado";
            txtAcumulado.ReadOnly = true;
            txtAcumulado.Size = new Size(240, 16);
            txtAcumulado.TabIndex = 20;
            txtAcumulado.TabStop = false;
            txtAcumulado.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 277);
            Controls.Add(txtAcumulado);
            Controls.Add(textBox1);
            Controls.Add(btnDecimal);
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
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.MenuHighlight;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TopMost = true;
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
        private Button btnDecimal;
        private TextBox textBox1;
        private TextBox txtAcumulado;
    }
}