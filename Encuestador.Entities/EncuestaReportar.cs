using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuestador.Entities
{
    public class EncuestaReportar
    {
        public int IdRespuesta { get; set; }
        public int NroEncuesta { get; set; }
        public String Sentido { get; set; }
        public String PatenteLetras { get; set; }
        public string PatenteNumero { get; set; }
        public string PatenteExtranjera { get; set; }
        public DateTime FechaEncuesta { get; set; }
        public int RespuestaCaso1 { get; set; }
        public int RespuestaCaso2 { get; set; }
        public int RespuestaCaso3 { get; set; }
        public string TipoVehiculo { get; set; }
        public string UsuarioConectado { get; set; }
        public string Motivo { get; set; }
        public string Sitio { get; set; }
        public int TiempoRuta1 { get; set; }
        public int TiempoRuta2 { get; set; }
        public int TiempoRuta3 { get; set; }
        public string CostoRuta1 { get; set; }
        public string CostoRuta2 { get; set; }
        public string CostoRuta3 { get; set; }
        public int OrdenCaso { get; set; }
    }
}
