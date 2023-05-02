namespace Ejemplo_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DateTime Ahora = DateTime.Now;
            dtFecha.MinDate = Ahora.AddMonths(-1);
            dtFecha.MaxDate = Ahora;

        }

        private void chkMiControl_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("El valor actual es: " + chkMiControl.Checked);
        }

        private void chklstMiControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBoton1.Checked)
            {
                chklstMiControl.Visible = true;
            }
        }

        private void radioBoton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBoton2.Checked)
            {
                chklstMiControl.Visible = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Fecha seleccionada: " + dtFecha.Value.ToShortDateString());
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {


        }

        private void btnVerFechas_Click(object sender, EventArgs e)
        {
            DateTime FechaInicial = monthCalendar1.SelectionStart;
            DateTime FechaFinal = monthCalendar1.SelectionEnd;
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}