using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;

namespace Ejemplo_6WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadenaConexion = @"Server = localhost\SQLEXPRESS; Database = AuditoriasCentros; Trusted_Connection = True";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlTransaction transaccion = null;

                try
                {
                    conexion.Open();
                    //transaccion = conexion.BeginTransaction();

                    //SqlCommand comando = conexion.CreateCommand();
                    SqlCommand comando = new SqlCommand(cadenaConexion);
                    comando.Connection = conexion;

                    comando.CommandText = "SELECT Id, Nombre, PoblacionId, Direccion, CP " +
                                          "FROM Tabla_Centro WHERE Nombre LIKE @Nombre AND Id > @CentroId";

                    SqlParameter parametro = new SqlParameter("@CentroId", SqlDbType.BigInt);
                    parametro.Value = 5;
                    comando.Parameters.Add(parametro);

                    parametro = new SqlParameter("@Nombre", SqlDbType.NVarChar);
                    parametro.Value = "%Guadalajara";
                    comando.Parameters.Add(parametro);

                    SqlDataReader reader = comando.ExecuteReader();

                    //FORMA 1

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    //var pipo = from X in dt.AsEnumerable()
                    //           select X;

                    //FORMA 2
                    //long Id;
                    //int CP, PoblacionId;
                    //string  Nombre, Direccion;

                    //while (reader.Read()) 
                    //{
                    //    Id =  Convert.ToInt64(reader["Id"]);
                    //    Nombre = reader["Nombre"].ToString();
                    //    PoblacionId = Convert.ToInt32(reader["PoblacionId"]);
                    //    Direccion = reader["Direccion"].ToString();
                    //    CP = Convert.ToInt32(reader["CP"]);
                    //}

                    //transaccion.Commit();

                }
                catch (Exception ex) 
                {
                    //transaccion.Rollback();
                    
                }
                finally 
                { 
                    if (conexion.State == ConnectionState.Open) 
                    conexion.Close(); 
                }
            }
        }   
        

    }
        
    
}