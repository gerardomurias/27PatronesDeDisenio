using System;

namespace _27PatronesDisenio.Consola.Mediator
{
    public class Boton : Control
    {
        public Boton(string nombre) : base(nombre) { }

        public override void informa()
        {
            Console.WriteLine("�Desea activar el bot�n " +
              nombre + " ?");
            string respuesta = Console.ReadLine();
            if (respuesta == "s�")
                this.modifica();
        }
    } 
}