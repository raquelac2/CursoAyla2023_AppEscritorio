namespace _LIBCoches
{
    public class Coche
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public string  MarcaModelo 
        { 
            get
            { 
                return Marca + "-" + Modelo; 
            }
        }


    }
}