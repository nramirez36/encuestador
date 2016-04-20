namespace Encuestador.Entities
{
    public class Caso
    {
        public int IdCaso { get; set; }
        public int IdTiempoViaje { get; set; }
        public string TiempoRuta1 { get; set; }
        public string TiempoRuta2 { get; set; }
        public string TiempoRuta3 { get; set; }
        public string CostaRuta1{ get; set; }
        public string CostaRuta2 { get; set; }
        public string CostaRuta3 { get; set; }
        public int OrdenCaso { get; set; }
        public int IdVehiculo { get; set; }
    }
}
