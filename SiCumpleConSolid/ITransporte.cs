using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiCumpleConSolid
{
    public interface ITransporte
    {
        void Mover();
    }

    public interface IVolador
    {
        void Volar(int altitud);
    }

    public interface IRepository<T>
    {
        void Guardar(T item);
    }
}
