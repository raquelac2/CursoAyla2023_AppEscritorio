using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_8WF
{
    public partial class MiPrimerControl : UserControl
    {

        public DateTime FecInicio { get; set; }
        public DateTime FecFin { get; set; }

        public event EventHandler FechaCambiada;
        public event EventHandler<MeCagoEnTusMuelasEventArgs> MeCagoEnTusMuelas;


        public MiPrimerControl()
        {
            InitializeComponent();
        }

        private void mcCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            FecInicio = mcCalendario.SelectionStart;
            txtFechaInicio.Text = FecInicio.ToShortDateString();

            FecFin = mcCalendario.SelectionEnd;
            txtFechaFin.Text = FecFin.ToShortDateString();

            FechaCambiada(this, e);

        }

        private void txtFechaInicio_TextChanged(object sender, EventArgs e)
        {
            MeCagoEnTusMuelasEventArgs pepe = new MeCagoEnTusMuelasEventArgs
            {
                ColorDeLasMuelas = "Amarillas",
                NumeroDeMuelas = 4
            };

            MeCagoEnTusMuelas(this, pepe);
        }
    }
}
