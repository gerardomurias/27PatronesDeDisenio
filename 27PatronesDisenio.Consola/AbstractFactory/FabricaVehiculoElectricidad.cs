using System;

namespace _27PatronesDisenio.Consola.AbstractFactory
{
    public class FabricaVehiculoElectricidad : FabricaVehiculo
    {
        public Automovil creaAutomovil(string modelo, string
          color, int potencia, double espacio)
        {
            return new AutomovilElectricidad(modelo, color,
              potencia, espacio);
        }

        public Scooter creaScooter(string modelo, string
          color, int potencia)
        {
            return new ScooterElectricidad(modelo, color,
              potencia);
        }
    } 
}
