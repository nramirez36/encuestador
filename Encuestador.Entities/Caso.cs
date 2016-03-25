using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuestador.Entities
{
    public class Caso
    {
        public int IdCaso { get; set; }
        public int IdDistanciaViaje { get; set; }
        public string TiempoRuta1 { get; set; }
        public string TiempoRuta2 { get; set; }
        public string TiempoRuta3 { get; set; }
        public string CostaRuta1{ get; set; }
        public string CostaRuta2 { get; set; }
        public string CostaRuta3 { get; set; }
        public int OrdenCaso { get; set; }
    }
}
