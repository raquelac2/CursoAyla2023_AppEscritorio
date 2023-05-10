using Ejercicio_4_LIB.NEGOCIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_LIB.DATOS
{
    public class CentroDB
    {
        private string _CadenaConexion = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AuditoriasCentros;Data Source=localhost\SQLEXPRESS";

        public long GuardarCentro(Centro centro)
        {
            long ID;
           
            string SQL = "INSERT INTO Tabla_Centro (Nombre, PoblacionId, Direccion, CP)" +
                          "VALUES   (?, ?, ?, ?)";

            using (OleDbConnection conexion = new OleDbConnection(_CadenaConexion))
            {
                conexion.Open();

                //OleDbCommand comando = conexion.CreateCommand ();
                //comando.CommandText = SQL;
                OleDbCommand comando = new OleDbCommand(SQL, conexion);

                OleDbParameter parametro = new OleDbParameter("@Nombre", OleDbType.VarChar);
                parametro.Value = centro.Nombre;
                comando.Parameters.Add(parametro);

                parametro = new OleDbParameter("@PoblacionId", OleDbType.Integer);
                parametro.Value = centro.PoblacionId;
                comando.Parameters.Add(parametro);

                parametro = new OleDbParameter("@Direccion", OleDbType.VarChar);
                parametro.Value = centro.Direccion;
                comando.Parameters.Add(parametro);

                parametro = new OleDbParameter("@CP", OleDbType.Integer);
                parametro.Value = centro.CodigoPostal;
                comando.Parameters.Add(parametro);

                comando.ExecuteScalar();

                SQL = "SELECT @@Identity";
                comando.CommandText = SQL;
                OleDbDataReader reader = comando.ExecuteReader();

               
                DataTable tabla = new DataTable();
                tabla.Load(reader);
                ID = Convert.ToInt64(tabla.Rows[0][0]);

                conexion.Close();
            }
            return ID; 

        }
     
    }
}
