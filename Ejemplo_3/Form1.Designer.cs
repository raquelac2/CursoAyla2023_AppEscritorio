namespace Ejemplo_3
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
            chkMiControl = new CheckBox();
            chklstMiControl = new CheckedListBox();
            radioBoton1 = new RadioButton();
            radioBoton2 = new RadioButton();
            dtFecha = new DateTimePicker();
            monthCalendar1 = new MonthCalendar();
            btnVerFechas = new Button();
            btnCerrar = new Button();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            maskedTextBox2 = new MaskedTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // chkMiControl
            // 
            chkMiControl.AutoSize = true;
            chkMiControl.ForeColor = Color.OrangeRed;
            chkMiControl.Location = new Point(107, 72);
            chkMiControl.Name = "chkMiControl";
            chkMiControl.Size = new Size(111, 19);
            chkMiControl.TabIndex = 0;
            chkMiControl.Text = "Texto de control";
            chkMiControl.TextAlign = ContentAlignment.BottomRight;
            chkMiControl.UseVisualStyleBackColor = true;
            chkMiControl.CheckedChanged += chkMiControl_CheckedChanged;
            // 
            // chklstMiControl
            // 
            chklstMiControl.FormattingEnabled = true;
            chklstMiControl.Items.AddRange(new object[] { "UNO", "DOS", "TRES", "DALE" });
            chklstMiControl.Location = new Point(129, 127);
            chklstMiControl.Name = "chklstMiControl";
            chklstMiControl.Size = new Size(120, 40);
            chklstMiControl.TabIndex = 1;
            chklstMiControl.SelectedIndexChanged += chklstMiControl_SelectedIndexChanged;
            // 
            // radioBoton1
            // 
            radioBoton1.AutoSize = true;
            radioBoton1.Location = new Point(338, 105);
            radioBoton1.Name = "radioBoton1";
            radioBoton1.Size = new Size(101, 19);
            radioBoton1.TabIndex = 2;
            radioBoton1.TabStop = true;
            radioBoton1.Text = "Ver lista Check";
            radioBoton1.UseVisualStyleBackColor = true;
            radioBoton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioBoton2
            // 
            radioBoton2.AutoSize = true;
            radioBoton2.Location = new Point(338, 130);
            radioBoton2.Name = "radioBoton2";
            radioBoton2.Size = new Size(120, 19);
            radioBoton2.TabIndex = 3;
            radioBoton2.TabStop = true;
            radioBoton2.Text = "No ver lista Check";
            radioBoton2.UseVisualStyleBackColor = true;
            radioBoton2.CheckedChanged += radioBoton2_CheckedChanged;
            // 
            // dtFecha
            // 
            dtFecha.CalendarForeColor = SystemColors.HotTrack;
            dtFecha.CalendarTitleBackColor = Color.OrangeRed;
            dtFecha.Location = new Point(196, 216);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(200, 23);
            dtFecha.TabIndex = 4;
            dtFecha.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(464, 186);
            monthCalendar1.MaxSelectionCount = 30;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 5;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // btnVerFechas
            // 
            btnVerFechas.Location = new Point(322, 279);
            btnVerFechas.Name = "btnVerFechas";
            btnVerFechas.Size = new Size(75, 23);
            btnVerFechas.TabIndex = 6;
            btnVerFechas.Text = "Ver Fechas";
            btnVerFechas.UseVisualStyleBackColor = true;
            btnVerFechas.Click += btnVerFechas_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(622, 46);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(90, 281);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Carnet de conducir";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(23, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(88, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Motocicleta";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(23, 31);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(59, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Coche";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(610, 137);
            maskedTextBox2.Mask = "00/00/0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(100, 23);
            maskedTextBox2.TabIndex = 10;
            maskedTextBox2.TextMaskFormat = MaskFormat.IncludePrompt;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(maskedTextBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCerrar);
            Controls.Add(btnVerFechas);
            Controls.Add(monthCalendar1);
            Controls.Add(dtFecha);
            Controls.Add(radioBoton2);
            Controls.Add(radioBoton1);
            Controls.Add(chklstMiControl);
            Controls.Add(chkMiControl);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkMiControl;
        private CheckedListBox chklstMiControl;
        private RadioButton radioBoton1;
        private RadioButton radioBoton2;
        private DateTimePicker dtFecha;
        private MonthCalendar monthCalendar1;
        private Button btnVerFechas;
        private Button btnCerrar;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private MaskedTextBox maskedTextBox2;
    }
}