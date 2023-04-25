using Ejemplo1b.WF.Clases;

namespace Ejemplo1b
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMensajeAyuda.Text = "Hola world";


            cboListado.SelectedIndex = cboListado.Items.Count - 1;

            List<Persona> Personas = new List<Persona>();
            Personas.Add(new Persona
            {
                ID = 1,
                Nombre = "Pablo López"
            });
          
            Personas.Add(new Persona
            {
                ID = 2,
                Nombre = "Lola Flores"
            });

            Personas.Add(new Persona
            {
                ID = 3,
                Nombre = "Alejandro Sanz"
            });

            cboPersonas.DataSource = Personas;
            cboPersonas.DisplayMember = "Nombre";
            cboPersonas.ValueMember = "ID";
        }

        private void btnBoton_Click(object sender, EventArgs e)
        {
            lblMensajeAyuda.Text = txtMensaje.Text;
            //lblMensajeAyuda.Text = DateTime.Now.ToShortDateString();

            int i = cboPersonas.SelectedIndex;
            Persona pipo = (Persona) cboPersonas.SelectedItem;
        }

    }
}