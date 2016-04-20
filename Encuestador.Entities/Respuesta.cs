using System;

namespace Encuestador.Entities
{
    public class Respuesta
    {
        public int IdRespuesta { get; set; }
        public int IdUsuario { get; set; }
        public String NroEncuesta { get; set; }
        public int IdSitio { get; set; }
        public int IdMotivoViaje { get; set; }
        public string Sentido { get; set; }
        public int IdVehiculo { get; set; }
        public string PatenteLetras { get; set; }
        public string PatenteNumero { get; set; }
        public string PatenteExtranjera { get; set; }
        public DateTime FechaEncuesta { get; set; }
        public int DistanciaViaje { get; set; }
        public int RespuestaCaso1 { get; set; }
        public int RespuestaCaso2 { get; set; }
        public int RespuestaCaso3 { get; set; }
        public DateTime HoraEncuesta { get; set; }
        public string NombreUsuario { get; set; }
        public int IdTiempoViaje { get; set; }
    }
}
