namespace Ejemplo_8WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            miPrimerControl1.FechaCambiada += LaFechaCambiaEnElControl;
            miPrimerControl1.MeCagoEnTusMuelas += ReciboLaCagadaEnSusMuelas;


            miPrimerControl2.FechaCambiada += LaFechaCambiaEnElControl;
            miPrimerControl2.MeCagoEnTusMuelas += ReciboLaCagadaEnSusMuelas;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = miPrimerControl1.FecInicio;
            DateTime fecha2 = miPrimerControl1.FecFin;

            DateTime fecha3 = miPrimerControl2.FecInicio;
            DateTime fecha4 = miPrimerControl2.FecFin;
        }

        private void LaFechaCambiaEnElControl(object sender, EventArgs e)
        {
            MiPrimerControl control = (MiPrimerControl)sender;

            string texto = String.Format("{0} - {1}", control.FecInicio.ToShortDateString(), control.FecFin.ToShortDateString());
            if (control.Tag == "ControlUsuario1")
            {
                txtRangoFechas.Text = texto;

            }
            else
            {
                txtRangoFechas2.Text = texto;
            }

            //MessageBox.Show(control.FecInicio.ToShortDateString());
        }

        private void ReciboLaCagadaEnSusMuelas (object sender, MeCagoEnTusMuelasEventArgs e) 
        {
            MiPrimerControl control = (MiPrimerControl)sender;
            string texto = String.Format("El control {0} tiene {1} muleas de color {2}", control.Tag, e.NumeroDeMuelas, e.ColorDeLasMuelas);
            MessageBox.Show(texto);
           
        }
    }
}