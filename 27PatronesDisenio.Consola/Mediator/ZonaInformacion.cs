using System;

namespace _27PatronesDisenio.Consola.Mediator
{
    public class ZonaInformacion : Control
    {
        public ZonaInformacion(string nombre) : base(nombre) { }

        public override void informa()
        {
            Console.WriteLine("Informaci�n de: " + nombre);
            valor = Console.ReadLine();
            this.modifica();
        }
    } 
}