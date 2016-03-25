using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuestador.Entities
{
    public class Respuesta
    {
        public int IdRespuesta { get; set; }
        public int IdUsuario { get; set; }
        public int NroEncuesta { get; set; }
        public int IdSitio { get; set; }
        public int IdMotivoViaje { get; set; }
        public string Sentido { get; set; }
        public int IdVehiculo { get; set; }
        public string Patente { get; set; }
        public DateTime FechaEncuesta { get; set; }
        public int RespuestaCaso1 { get; set; }
        public int RespuestaCaso2 { get; set; }
        public int RespuestaCaso3 { get; set; }
    }
}
