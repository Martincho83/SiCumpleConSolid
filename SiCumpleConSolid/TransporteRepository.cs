using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiCumpleConSolid
{
    public class TransporteRepository : IRepository<ITransporte>
    {
        public void Guardar(ITransporte transporte)
        {
            // Lógica para guardar en la base de datos
            Console.WriteLine("Guardando el transporte en la base de datos.");
        }
    }
}
