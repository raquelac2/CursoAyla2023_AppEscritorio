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
            RecargarComboCoches();
            //cboCoches.DataSource = MisCoches;
            //cboCoches.DisplayMember = "MarcaModelo";
            //cboCoches.ValueMember = "ID";
        }
        private void btnAddCoche_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;
            //1. Comprobar que los campos estén rellenos
            if (string.IsNullOrEmpty(txtID.Text))
                Mensaje = "El campo ID es obligatorio";

            else if (string.IsNullOrEmpty(txtMarca.Text))
                Mensaje = "El campo Marca es obligatorio";

            else if (string.IsNullOrEmpty(txtModelo.Text))
                Mensaje = "El campo Modelo es obligatorio";

            if (Mensaje.Length > 0)
                MessageBox.Show(Mensaje,"ERROR", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            else
            {    //Entra aquí cuando todos los campos están rellenos

                //2. Comprobar que el ID del nuevo objeto no exista

                Coche buscado = (from c in MisCoches
                                where c.ID.ToString() == txtID.Text.Trim()
                                select c).FirstOrDefault();

                if (buscado != null)
                    MessageBox.Show("No se puede crear un coche con el mismo ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    //Que el ID no exsite todavía
                    //3. Crear el objeto coche 
                    Coche nuevo = new Coche 
                    { 
                    ID = Convert.ToInt32 (txtID.Text),
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    };
                    //4. Añadirlo a la colección de coches

                    MisCoches.Add(nuevo);

                    //5. Recargar el desplegable
                    RecargarComboCoches();

                    //cboCoches.DataSource = null;
                    //cboCoches.DataSource = MisCoches;
                    //cboCoches.DisplayMember = "MarcaModelo";
                    //cboCoches.ValueMember = "ID";
                }


            }

        }

        private void RecargarComboCoches()
        {
            cboCoches.DataSource = null;
            cboCoches.DataSource = MisCoches;
            cboCoches.DisplayMember = "MarcaModelo";
            cboCoches.ValueMember = "ID";
        }
    }

}