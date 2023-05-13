using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_8WF
{
    public class MeCagoEnTusMuelasEventArgs : EventArgs
    {
        public int NumeroDeMuelas { get; set; }
        public string ColorDeLasMuelas { get; set; }
    }
}
