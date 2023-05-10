using System.Data;
using System.Data.OleDb;

namespace Ejemplo_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string CadenaConexion = "Provider = SQLOLEDB.1; Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = AuditoriasCentros; Data Source = localhost\\SQLEXPRESS";
            string SQL = "INSERT INTO Tabla_Centro (Nombre, PoblacionId, Direccion, CP)" +
                          "VALUES   (?, ?, ?, ?)";

            using (OleDbConnection conexion = new OleDbConnection(CadenaConexion))
            {
                conexion.Open();

                //OleDbCommand comando = conexion.CreateCommand ();
                //comando.CommandText = SQL;
                OleDbCommand comando = new OleDbCommand(SQL, conexion);

                OleDbParameter parametro = new OleDbParameter("@Nombre", OleDbType.VarChar);
                parametro.Value = "Centro de Charizard I de Guadalajara";
                comando.Parameters.Add(parametro);

                parametro = new OleDbParameter("@PoblacionId", OleDbType.Integer);
                parametro.Value = "18791";
                comando.Parameters.Add(parametro);

                parametro = new OleDbParameter("@Direccion", OleDbType.VarChar);
                parametro.Value = "C/ Ferial 3";
                comando.Parameters.Add(parametro);

                parametro = new OleDbParameter("@CP", OleDbType.Integer);
                parametro.Value = 19002;
                comando.Parameters.Add(parametro);

                comando.ExecuteScalar();

                SQL = "SELECT @@Identity";
                comando.CommandText = SQL;
                OleDbDataReader reader = comando.ExecuteReader();

                ////FORMA 1 DE RECUPERAR EL ÚLTIMO ID INTRODUCIDO
                //int UltimoID;
                //while (reader.Read())
                //{
                //    UltimoID = Convert.ToInt32(reader[0]);
                //}

                //FORMA 2 DE RECUPERAR EL ÚLTIMO ID INTRODUCIDO
                DataTable tabla = new DataTable();
                tabla.Load(reader);

                int ID = Convert.ToInt32(tabla.Rows[0][0]);
                MessageBox.Show(ID.ToString());


                conexion.Close();
            }

            MessageBox.Show("El centro ha sido creado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string CadenaConexion = "Provider = SQLOLEDB.1; Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = AuditoriasCentros; Data Source = localhost\\SQLEXPRESS";

            string SQL = "UPDATE Tabla_Centro SET Nombre = ? WHERE Id = ?";

            using (OleDbConnection conexion = new OleDbConnection(CadenaConexion))
            {
                conexion.Open();

                OleDbCommand comando = conexion.CreateCommand();
                comando.CommandText = SQL;

                OleDbParameter parametro = new OleDbParameter("@Nombre", OleDbType.VarChar);
                parametro.Value = txtCentro.Text;
                comando.Parameters.Add(parametro);


                parametro = new OleDbParameter("@Id", OleDbType.Integer);
                parametro.Value = Convert.ToInt32(txtCentroId.Text);
                comando.Parameters.Add(parametro);

                int resultado = comando.ExecuteNonQuery();

                conexion.Close();
            }

            MessageBox.Show("El centro ha sido actualizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string CadenaConexion = "Provider = SQLOLEDB.1; Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = AuditoriasCentros; Data Source = localhost\\SQLEXPRESS";

            string SQL = "DELETE FROM Tabla_Centro WHERE Id = ?";

            using (OleDbConnection conexion = new OleDbConnection(CadenaConexion))
            {
                conexion.Open();

                OleDbCommand comando = conexion.CreateCommand();
                comando.CommandText = SQL;


                OleDbParameter parametro = new OleDbParameter("@Id", OleDbType.Integer);
                parametro.Value = Convert.ToInt32(txtCentroIdABorrar.Text);
                comando.Parameters.Add(parametro);

                int resultado = comando.ExecuteNonQuery();

                

                conexion.Close();
            }
            MessageBox.Show("El centro ha sido eliminado","", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}