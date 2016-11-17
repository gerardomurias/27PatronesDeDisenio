using System;

namespace _27PatronesDisenio.Consola.AbstractFactory
{
    public class ScooterGasolina : Scooter
    {
        public ScooterGasolina(string modelo, string color,
          int potencia) : base(modelo, color, potencia) { }

        public override void mostrarCaracteristicas()
        {
            Console.WriteLine("Scooter eléctrica de modelo: " +
              modelo + " de color: " + color +
              " de potencia: " + potencia);
        }

    } 
}

