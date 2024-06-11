using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiCumpleConSolid
{
    public class Avion : ITransporte, IVolador
    {
        public string Nombre { get; set; }
        public int VelocidadActual { get; set; }
        public int VelocidadMaxima { get; set; }
        public int AlturaActual { get; set; }
        public int AlturaMaxima { get; set; }

        public void Mover()
        {
            // Lógica para mover el avión
            Console.WriteLine("El avión se está moviendo.");
        }

        public void Volar(int altitud)
        {
            // Lógica para volar
            Console.WriteLine($"El avión está volando a una altura de {altitud} metros.");
        }
    }
}
