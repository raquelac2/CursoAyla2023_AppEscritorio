using System.Data;

namespace Ejemplo_4WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DataTable miTabla = new DataTable();
            miTabla.Columns.Add("ID", typeof(int));
            miTabla.Columns.Add("Nombre", typeof(string));  
            miTabla.Columns.Add("Apellidos", typeof (string));
            miTabla.Columns.Add("Edad", typeof(int));

            DataRow miFila = miTabla.NewRow();
            miFila["ID"] = 1;
            miFila["Nombre"] = "Pepe";
            miFila["Apellidos"] = "Lopez";
            miFila["Edad"] = 34;

            miTabla.Rows.Add(miFila);


        }
    }
}