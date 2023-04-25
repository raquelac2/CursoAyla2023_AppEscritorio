using _LIBCoches;

namespace Ejercicio_1WF
{
    /// <summary>
    /// Aplicación para crear objetos de tipo coches y rellenar el desplegable de forma dinámica
    /// </summary>
    public partial class Form1 : Form
    {
        public List<Coche> MisCoches { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Coches coches = new Coches();
            MisCoches = coches.ListaCoches;
        }

        private void lblModelo_Click(object sender, EventArgs e)
        {

        }

        private void lblMarca_Click(object sender, EventArgs e)
        {
        }

        private void lblID_Click(object sender, EventArgs e)
        {
        }
    }
}