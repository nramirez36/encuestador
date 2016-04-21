using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuestador.Entities
{
    public class EncuestaReportar
    {
        public String NroEncuesta { get; set; }
        public int IdRespuesta { get; set; }
        public int IdSitio { get; set; }
        public string Sitio { get; set; }
        public String Sentido { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaEncuesta { get; set; }
        public string HoraEncuesta{ get; set; }
        public string TipoVehiculo { get; set; }
        public String Placa { get; set; }
        public string  Distancia { get; set; }
        public string Motivo { get; set; }
        public string TiempoViaje { get; set; }

        public int RespuestaCaso1 { get; set; }

        public int RespuestaCaso2 { get; set; }

        public int RespuestaCaso3 { get; set; }
        
    }
}
