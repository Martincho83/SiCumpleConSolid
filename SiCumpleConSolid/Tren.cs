

namespace SiCumpleConSolid
{
    public class Tren : ITransporte
    {
        public string Nombre { get; set; }
        public int VelocidadActual { get; set; }
        public int VelocidadMaxima { get; set; }

        public void Mover()
        {
            // Lógica para mover el tren
            Console.WriteLine("El tren se está moviendo.");
        }
    }
}
