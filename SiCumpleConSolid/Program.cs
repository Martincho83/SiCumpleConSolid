// See https://aka.ms/new-console-template for more information
using SiCumpleConSolid;
using System;

class Program
{
    static void Main(string[] args)
    {
        List<ITransporte> transportes = new List<ITransporte>();

        Avion avion1 = new Avion
        {
            Nombre = "AVION 01",
            VelocidadActual = 0,
            VelocidadMaxima = 100,
            AlturaActual = 0,
            AlturaMaxima = 100
        };
        transportes.Add(avion1);

        Tren tren1 = new Tren
        {
            Nombre = "TREN 01",
            VelocidadActual = 0,
            VelocidadMaxima = 100
        };
        transportes.Add(tren1);

        TransporteRepository repository = new TransporteRepository();

        foreach (var transporte in transportes)
        {
            TransporteService servicio = new TransporteService(transporte, repository);
            servicio.MoverTransporte();
            servicio.GuardarTransporte();

            if (transporte is IVolador volador)
            {
                volador.Volar(100);
            }
        }

        Console.WriteLine("Fin del viaje :)");
    }
}
