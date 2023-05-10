using Ejercicio_4_LIB.DATOS;
using System.Data.OleDb;

namespace Ejercicio_4_LIB.NEGOCIO
{
    public class Centro
    {
        public long? Id { get; set; }
        public int PoblacionId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int CodigoPostal { get; set; }

        public Centro GuardarCentroEnBBDD(Centro centro)
        {
            CentroDB miCentro = new CentroDB();
            centro.Id = miCentro.GuardarCentro(centro);

            return centro;
        }


       
    }
}