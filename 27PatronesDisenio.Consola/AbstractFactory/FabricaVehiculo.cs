using System;

namespace _27PatronesDisenio.Consola.AbstractFactory
{
    public interface FabricaVehiculo
    {
        Automovil creaAutomovil(string modelo, string color,
          int potencia, double espacio);

        Scooter creaScooter(string modelo, string color, int
          potencia);
    }

}