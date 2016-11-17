using System;

namespace _27PatronesDisenio.Consola.AbstractFactory
{
    public class AutomovilElectricidad : Automovil
    {
        public AutomovilElectricidad(string modelo, string
          color, int potencia, double espacio) : base(modelo,
          color, potencia, espacio)
        { }

        public override void mostrarCaracteristicas()
        {
            Console.WriteLine(
              "Autom�vil el�ctrico de modelo: " + modelo +
              " de color: " + color + " de potencia: " +
              potencia + " de espacio: " + espacio);
        }
    }

}